using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_42() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112603"},
        {"Hipparcos Number", "HIP 63286"},
        {"Fundamental Katalog 5th Edition", "FK5 5144"},
        {"Geneva Identification System", "GEN# +1.00112603"},
        {"Smithsonian Astrophysical Observation", "SAO 181274"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.54117503),
        dec: Angle.Degrees(-23.05511322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49390"},
        {"Hipparcos Number", "HIP 32528"},
        {"Smithsonian Astrophysical Observation", "SAO 172325"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.81402216),
        dec: Angle.Degrees(-23.05346968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208284"},
        {"Hipparcos Number", "HIP 108243"},
        {"Smithsonian Astrophysical Observation", "SAO 190742"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.92850703),
        dec: Angle.Degrees(-23.05298979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29800"},
        {"Hipparcos Number", "HIP 21781"},
        {"Smithsonian Astrophysical Observation", "SAO 169661"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.18854133),
        dec: Angle.Degrees(-23.05225508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174355"},
        {"Hipparcos Number", "HIP 92503"},
        {"Smithsonian Astrophysical Observation", "SAO 187353"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.77539735),
        dec: Angle.Degrees(-23.05146131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139411"},
        {"Hipparcos Number", "HIP 76614"},
        {"Smithsonian Astrophysical Observation", "SAO 183654"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.68577987),
        dec: Angle.Degrees(-23.04944619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29443"},
        {"Hipparcos Number", "HIP 21522"},
        {"Smithsonian Astrophysical Observation", "SAO 169619"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.32109565),
        dec: Angle.Degrees(-23.04861173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50939"},
        {"Hipparcos Number", "HIP 33182"},
        {"Celescope Catalog", "CEL 1427"},
        {"Geneva Identification System", "GEN# +1.00050939"},
        {"Smithsonian Astrophysical Observation", "SAO 172551"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.59371150),
        dec: Angle.Degrees(-23.04783988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50535"},
        {"Hipparcos Number", "HIP 33019"},
        {"Celescope Catalog", "CEL 1417"},
        {"Geneva Identification System", "GEN# +1.00050535"},
        {"Smithsonian Astrophysical Observation", "SAO 172497"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.19834221),
        dec: Angle.Degrees(-23.04704545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182346"},
        {"Henry Draper 2", "HD 182346A"},
        {"Hipparcos Number", "HIP 95457"},
        {"Smithsonian Astrophysical Observation", "SAO 188098"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.27571196),
        dec: Angle.Degrees(-23.04180805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102784"},
        {"Hipparcos Number", "HIP 57697"},
        {"Smithsonian Astrophysical Observation", "SAO 180223"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.48840177),
        dec: Angle.Degrees(-23.04116753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139976"},
        {"Hipparcos Number", "HIP 76898"},
        {"Geneva Identification System", "GEN# +1.00139976"},
        {"Smithsonian Astrophysical Observation", "SAO 183715"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.51824628),
        dec: Angle.Degrees(-23.03656415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 586"},
        {"Smithsonian Astrophysical Observation", "SAO 166059"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.78337358),
        dec: Angle.Degrees(-23.03614091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37849"},
        {"Hipparcos Number", "HIP 26701"},
        {"Smithsonian Astrophysical Observation", "SAO 170674"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.12292282),
        dec: Angle.Degrees(-23.03606620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23538"},
        {"Smithsonian Astrophysical Observation", "SAO 170026"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.92617461),
        dec: Angle.Degrees(-23.03424844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64060"},
        {"Hipparcos Number", "HIP 38343"},
        {"Smithsonian Astrophysical Observation", "SAO 174667"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80703513),
        dec: Angle.Degrees(-23.03262377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76136"},
        {"Hipparcos Number", "HIP 43658"},
        {"Smithsonian Astrophysical Observation", "SAO 176647"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.40645202),
        dec: Angle.Degrees(-23.03236776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224040"},
        {"Hipparcos Number", "HIP 117882"},
        {"Smithsonian Astrophysical Observation", "SAO 192232"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.66241540),
        dec: Angle.Degrees(-23.03230983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159160"},
        {"Hipparcos Number", "HIP 85954"},
        {"Geneva Identification System", "GEN# +1.00159160"},
        {"Smithsonian Astrophysical Observation", "SAO 185512"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.50995401),
        dec: Angle.Degrees(-23.03127983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88333",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10991 A"},
        {"Henry Draper", "HD 164492"},
        {"Henry Draper 2", "HD 164492A"},
        {"Hipparcos Number", "HIP 88333"},
        {"Celescope Catalog", "CEL 4596"},
        {"Geneva Identification System", "GEN# +2.65140145"},
        {"Smithsonian Astrophysical Observation", "SAO 186145"},
        {"Wilson Evans Batten Catalogue", "WEB 14927"},
        {"New General Catalogue", "NGC 6514 145"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59813566),
        dec: Angle.Degrees(-23.03082943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223078"},
        {"Hipparcos Number", "HIP 117247"},
        {"Geneva Identification System", "GEN# +1.00223078"},
        {"Smithsonian Astrophysical Observation", "SAO 192141"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.61170429),
        dec: Angle.Degrees(-23.02777868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46997"},
        {"Smithsonian Astrophysical Observation", "SAO 177686"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.67811809),
        dec: Angle.Degrees(-23.02773787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17799"},
        {"Hipparcos Number", "HIP 13272"},
        {"Smithsonian Astrophysical Observation", "SAO 168092"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.70881860),
        dec: Angle.Degrees(-23.02755762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20141"},
        {"Hipparcos Number", "HIP 15010"},
        {"Smithsonian Astrophysical Observation", "SAO 168392"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.37651592),
        dec: Angle.Degrees(-23.02696798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2453 A"},
        {"Henry Draper", "HD 20503"},
        {"Hipparcos Number", "HIP 15280"},
        {"Smithsonian Astrophysical Observation", "SAO 168439"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.29213870),
        dec: Angle.Degrees(-23.02647416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223244"},
        {"Hipparcos Number", "HIP 117363"},
        {"Smithsonian Astrophysical Observation", "SAO 192157"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.96100916),
        dec: Angle.Degrees(-23.02600745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57910"},
        {"Hipparcos Number", "HIP 35752"},
        {"Wilson Evans Batten Catalogue", "WEB 7125"},
    },
    visualMagnitude: 9.46,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.61885088),
        dec: Angle.Degrees(-23.02560948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28708"},
        {"Hipparcos Number", "HIP 21032"},
        {"Smithsonian Astrophysical Observation", "SAO 169521"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.64063175),
        dec: Angle.Degrees(-23.02438431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59612"},
        {"Hipparcos Number", "HIP 36431"},
        {"Geneva Identification System", "GEN# +1.00059612J"},
        {"Smithsonian Astrophysical Observation", "SAO 173864"},
        {"Wilson Evans Batten Catalogue", "WEB 7253"},
    },
    visualMagnitude: 4.85,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.46422560),
        dec: Angle.Degrees(-23.02429924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117879"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.65962783),
        dec: Angle.Degrees(-23.02401768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63004"},
        {"Hipparcos Number", "HIP 37881"},
        {"Smithsonian Astrophysical Observation", "SAO 174473"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46719549),
        dec: Angle.Degrees(-23.02333963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121699"},
        {"Hipparcos Number", "HIP 68177"},
        {"Geneva Identification System", "GEN# +1.00121699"},
        {"Smithsonian Astrophysical Observation", "SAO 182123"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.36561510),
        dec: Angle.Degrees(-23.02265213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85405"},
        {"Hipparcos Number", "HIP 48327"},
        {"Geneva Identification System", "GEN# +1.00085405"},
        {"Smithsonian Astrophysical Observation", "SAO 178088"},
        {"Wilson Evans Batten Catalogue", "WEB 9013"},
    },
    visualMagnitude: 6.85,
    bvColour: 3.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.76546416),
        dec: Angle.Degrees(-23.01730501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224565"},
        {"Hipparcos Number", "HIP 118236"},
        {"Smithsonian Astrophysical Observation", "SAO 192285"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.73562515),
        dec: Angle.Degrees(-23.01674467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96240"},
        {"Geneva Identification System", "GEN# -0.02315543"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.54089523),
        dec: Angle.Degrees(-23.01665648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129486"},
        {"Hipparcos Number", "HIP 71992"},
        {"Smithsonian Astrophysical Observation", "SAO 182801"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.85090647),
        dec: Angle.Degrees(-23.01646627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194768"},
        {"Hipparcos Number", "HIP 100958"},
        {"Smithsonian Astrophysical Observation", "SAO 189316"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.03677787),
        dec: Angle.Degrees(-23.01430549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133466"},
        {"Hipparcos Number", "HIP 73820"},
        {"Smithsonian Astrophysical Observation", "SAO 183155"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.32006286),
        dec: Angle.Degrees(-23.01330585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7908"},
        {"Hipparcos Number", "HIP 6108"},
        {"Geneva Identification System", "GEN# +1.00007908"},
        {"Smithsonian Astrophysical Observation", "SAO 166940"},
        {"Wilson Evans Batten Catalogue", "WEB 1373"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.60573330),
        dec: Angle.Degrees(-23.01313012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9274 A"},
        {"Henry Draper", "HD 126819"},
        {"Hipparcos Number", "HIP 70768"},
        {"Smithsonian Astrophysical Observation", "SAO 182574"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.09737978),
        dec: Angle.Degrees(-23.01246733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54887"},
        {"Hipparcos Number", "HIP 34580"},
        {"Smithsonian Astrophysical Observation", "SAO 173097"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.43250285),
        dec: Angle.Degrees(-23.00955622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211236"},
        {"Hipparcos Number", "HIP 109952"},
        {"Geneva Identification System", "GEN# +1.00211236"},
        {"Smithsonian Astrophysical Observation", "SAO 191009"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.03008785),
        dec: Angle.Degrees(-23.00941296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65508"},
        {"Hipparcos Number", "HIP 38958"},
        {"Smithsonian Astrophysical Observation", "SAO 174894"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.56529701),
        dec: Angle.Degrees(-23.00919732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218972"},
        {"Hipparcos Number", "HIP 114572"},
        {"Smithsonian Astrophysical Observation", "SAO 191722"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.14638050),
        dec: Angle.Degrees(-23.00846084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 302 ABC"},
        {"Henry Draper", "HD 1766"},
        {"Hipparcos Number", "HIP 1732"},
        {"Geneva Identification System", "GEN# +1.00001766J"},
        {"Smithsonian Astrophysical Observation", "SAO 166213"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.46832989),
        dec: Angle.Degrees(-23.00769985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 313846"},
        {"Hipparcos Number", "HIP 88597"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.35723001),
        dec: Angle.Degrees(-23.00564291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65143"},
        {"Hipparcos Number", "HIP 38804"},
        {"Smithsonian Astrophysical Observation", "SAO 174842"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.12626896),
        dec: Angle.Degrees(-23.00430023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42643"},
        {"Smithsonian Astrophysical Observation", "SAO 176307"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.34451923),
        dec: Angle.Degrees(-23.00423472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197111"},
        {"Hipparcos Number", "HIP 102175"},
        {"Smithsonian Astrophysical Observation", "SAO 189594"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.54812083),
        dec: Angle.Degrees(-23.00126076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40688"},
        {"Hipparcos Number", "HIP 28339"},
        {"Smithsonian Astrophysical Observation", "SAO 171105"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.83408259),
        dec: Angle.Degrees(-23.00041341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169966"},
        {"Hipparcos Number", "HIP 90513"},
        {"Geneva Identification System", "GEN# +1.00169966"},
        {"Smithsonian Astrophysical Observation", "SAO 186848"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02955667),
        dec: Angle.Degrees(-22.99968172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10608 AB"},
        {"Henry Draper", "HD 158758"},
        {"Hipparcos Number", "HIP 85804"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.98732268),
        dec: Angle.Degrees(-22.99951244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97590"},
        {"Hipparcos Number", "HIP 54843"},
        {"Smithsonian Astrophysical Observation", "SAO 179661"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.42105577),
        dec: Angle.Degrees(-22.99874494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77698"},
        {"Hipparcos Number", "HIP 44459"},
        {"Fundamental Katalog 5th Edition", "FK5 4805"},
        {"Smithsonian Astrophysical Observation", "SAO 176884"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.86796099),
        dec: Angle.Degrees(-22.99765849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213379"},
        {"Hipparcos Number", "HIP 111162"},
        {"Geneva Identification System", "GEN# +1.00213379"},
        {"Smithsonian Astrophysical Observation", "SAO 191201"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.80592765),
        dec: Angle.Degrees(-22.99653875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50092"},
        {"Hipparcos Number", "HIP 32836"},
        {"Geneva Identification System", "GEN# +1.00050092"},
        {"Smithsonian Astrophysical Observation", "SAO 172421"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.67507052),
        dec: Angle.Degrees(-22.99396224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76104"},
        {"Hipparcos Number", "HIP 43645"},
        {"Geneva Identification System", "GEN# +1.00076104"},
        {"Renson", "Renson 21290"},
        {"Smithsonian Astrophysical Observation", "SAO 176638"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.34549173),
        dec: Angle.Degrees(-22.99306301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16446"},
        {"Hipparcos Number", "HIP 12250"},
        {"Fundamental Katalog 5th Edition", "FK5 2181"},
        {"Geneva Identification System", "GEN# +1.00016446"},
        {"Smithsonian Astrophysical Observation", "SAO 167931"},
        {"Wilson Evans Batten Catalogue", "WEB 2514"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.43507569),
        dec: Angle.Degrees(-22.99200304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156619"},
        {"Hipparcos Number", "HIP 84761"},
        {"Smithsonian Astrophysical Observation", "SAO 185269"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.87867133),
        dec: Angle.Degrees(-22.99193012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3315",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 586 AB"},
        {"Henry Draper", "HD 3978"},
        {"Hipparcos Number", "HIP 3315"},
        {"Smithsonian Astrophysical Observation", "SAO 166497"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.55033363),
        dec: Angle.Degrees(-22.99185376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191887"},
        {"Hipparcos Number", "HIP 99609"},
        {"Geneva Identification System", "GEN# +1.00191887"},
        {"Smithsonian Astrophysical Observation", "SAO 189031"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.22376881),
        dec: Angle.Degrees(-22.99049699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73832"},
        {"Smithsonian Astrophysical Observation", "SAO 183158"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.33724978),
        dec: Angle.Degrees(-22.99013450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13260"},
        {"Hipparcos Number", "HIP 10029"},
        {"Fundamental Katalog 5th Edition", "FK5 4198"},
        {"Smithsonian Astrophysical Observation", "SAO 167589"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.26977844),
        dec: Angle.Degrees(-22.99005770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24387",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3819 A"},
        {"Henry Draper", "HD 34087"},
        {"Hipparcos Number", "HIP 24387"},
        {"Geneva Identification System", "GEN# +1.00034087"},
        {"Smithsonian Astrophysical Observation", "SAO 170216"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.48258369),
        dec: Angle.Degrees(-22.98850132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18412"},
        {"Hipparcos Number", "HIP 13733"},
        {"Geneva Identification System", "GEN# +1.00018412"},
        {"Smithsonian Astrophysical Observation", "SAO 168170"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.21482343),
        dec: Angle.Degrees(-22.98556467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215377"},
        {"Hipparcos Number", "HIP 112321"},
        {"Geneva Identification System", "GEN# +1.00215377"},
        {"Smithsonian Astrophysical Observation", "SAO 191371"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.25682950),
        dec: Angle.Degrees(-22.98519671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55496"},
        {"Hipparcos Number", "HIP 34795"},
        {"Geneva Identification System", "GEN# +1.00055496"},
        {"Smithsonian Astrophysical Observation", "SAO 173188"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.04735434),
        dec: Angle.Degrees(-22.98347388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41541"},
        {"Smithsonian Astrophysical Observation", "SAO 175894"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.06880021),
        dec: Angle.Degrees(-22.98127030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163017"},
        {"Hipparcos Number", "HIP 87712"},
        {"Smithsonian Astrophysical Observation", "SAO 185932"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.75083866),
        dec: Angle.Degrees(-22.98111391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144497"},
        {"Hipparcos Number", "HIP 78947"},
        {"Geneva Identification System", "GEN# +1.00144497"},
        {"Smithsonian Astrophysical Observation", "SAO 184128"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.74897497),
        dec: Angle.Degrees(-22.97679968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 313502"},
        {"Hipparcos Number", "HIP 87942"},
        {"Smithsonian Astrophysical Observation", "SAO 186008"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.48292591),
        dec: Angle.Degrees(-22.97580130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3485"},
        {"Hipparcos Number", "HIP 2967"},
        {"Smithsonian Astrophysical Observation", "SAO 166422"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.43887142),
        dec: Angle.Degrees(-22.97557174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126831"},
        {"Hipparcos Number", "HIP 70776"},
        {"Geneva Identification System", "GEN# +1.00126831"},
        {"Smithsonian Astrophysical Observation", "SAO 182576"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.12418959),
        dec: Angle.Degrees(-22.97469586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39190"},
        {"Hipparcos Number", "HIP 27533"},
        {"Celescope Catalog", "CEL 1001"},
        {"Geneva Identification System", "GEN# +1.00039190"},
        {"Smithsonian Astrophysical Observation", "SAO 170892"},
        {"Wilson Evans Batten Catalogue", "WEB 5407"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.47295636),
        dec: Angle.Degrees(-22.97192372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89581"},
        {"Hipparcos Number", "HIP 50571"},
        {"Smithsonian Astrophysical Observation", "SAO 178688"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.95358535),
        dec: Angle.Degrees(-22.97123461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27411"},
        {"Hipparcos Number", "HIP 20106"},
        {"Geneva Identification System", "GEN# +1.00027411"},
        {"Renson", "Renson 7040"},
        {"Smithsonian Astrophysical Observation", "SAO 169325"},
        {"Wilson Evans Batten Catalogue", "WEB 3839"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.65608026),
        dec: Angle.Degrees(-22.96982850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50710"},
        {"Hipparcos Number", "HIP 33084"},
        {"Geneva Identification System", "GEN# +1.00050710"},
        {"Smithsonian Astrophysical Observation", "SAO 172517"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.35396577),
        dec: Angle.Degrees(-22.96974567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15246"},
        {"Hipparcos Number", "HIP 11392"},
        {"Smithsonian Astrophysical Observation", "SAO 167797"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.69198400),
        dec: Angle.Degrees(-22.96972275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58195"},
        {"Hipparcos Number", "HIP 35865"},
        {"Geneva Identification System", "GEN# +1.00058195"},
        {"Wilson Evans Batten Catalogue", "WEB 7145"},
    },
    visualMagnitude: 8.70,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.91072052),
        dec: Angle.Degrees(-22.96967168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109651"},
        {"Hipparcos Number", "HIP 61523"},
        {"Smithsonian Astrophysical Observation", "SAO 180943"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07153305),
        dec: Angle.Degrees(-22.96913054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84199"},
        {"Hipparcos Number", "HIP 47646"},
        {"Geneva Identification System", "GEN# +1.00084199"},
        {"Smithsonian Astrophysical Observation", "SAO 177879"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.71203497),
        dec: Angle.Degrees(-22.96554270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83582"},
        {"Hipparcos Number", "HIP 47353"},
        {"Smithsonian Astrophysical Observation", "SAO 177787"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.72901658),
        dec: Angle.Degrees(-22.96490155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46933"},
        {"Hipparcos Number", "HIP 31416"},
        {"Fundamental Katalog 5th Edition", "FK5 249"},
        {"Geneva Identification System", "GEN# +1.00046933"},
        {"Smithsonian Astrophysical Observation", "SAO 171982"},
        {"Wilson Evans Batten Catalogue", "WEB 6288"},
    },
    visualMagnitude: 4.54,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76408302),
        dec: Angle.Degrees(-22.96483318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84199B"},
        {"Hipparcos Number", "HIP 47645"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.70723284),
        dec: Angle.Degrees(-22.96429831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21009"},
        {"Hipparcos Number", "HIP 15734"},
        {"Smithsonian Astrophysical Observation", "SAO 168496"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.67914416),
        dec: Angle.Degrees(-22.96157920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28296"},
        {"Hipparcos Number", "HIP 20759"},
        {"Smithsonian Astrophysical Observation", "SAO 169454"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.71836444),
        dec: Angle.Degrees(-22.95804030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12499"},
        {"Smithsonian Astrophysical Observation", "SAO 167968"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.20435532),
        dec: Angle.Degrees(-22.95622614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199471"},
        {"Hipparcos Number", "HIP 103494"},
        {"Smithsonian Astrophysical Observation", "SAO 189883"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.52270796),
        dec: Angle.Degrees(-22.95593001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189965"},
        {"Hipparcos Number", "HIP 98752"},
        {"Smithsonian Astrophysical Observation", "SAO 188858"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.87204958),
        dec: Angle.Degrees(-22.95590763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125299"},
        {"Hipparcos Number", "HIP 69973"},
        {"Smithsonian Astrophysical Observation", "SAO 182437"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77401791),
        dec: Angle.Degrees(-22.95351365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179548"},
        {"Hipparcos Number", "HIP 94494"},
        {"Smithsonian Astrophysical Observation", "SAO 187851"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.49189055),
        dec: Angle.Degrees(-22.93181883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116219"},
        {"Hipparcos Number", "HIP 65266"},
        {"Smithsonian Astrophysical Observation", "SAO 181599"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.63474823),
        dec: Angle.Degrees(-22.95281720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116220"},
        {"Hipparcos Number", "HIP 65269"},
        {"Smithsonian Astrophysical Observation", "SAO 181600"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.64215108),
        dec: Angle.Degrees(-22.95204586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18146"},
        {"Hipparcos Number", "HIP 13529"},
        {"Smithsonian Astrophysical Observation", "SAO 168131"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.56055421),
        dec: Angle.Degrees(-22.95138400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10581 AB"},
        {"Henry Draper", "HD 158406"},
        {"Hipparcos Number", "HIP 85642"},
        {"Smithsonian Astrophysical Observation", "SAO 185459"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.52710375),
        dec: Angle.Degrees(-22.95132059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16597",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2615 AB"},
        {"Henry Draper", "HD 22186"},
        {"Hipparcos Number", "HIP 16597"},
        {"Smithsonian Astrophysical Observation", "SAO 168630"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.40871906),
        dec: Angle.Degrees(-22.95030005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73104"},
        {"Smithsonian Astrophysical Observation", "SAO 183015"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.11850294),
        dec: Angle.Degrees(-22.94981462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2110"},
        {"Geneva Identification System", "GEN# -0.02300156"},
        {"Smithsonian Astrophysical Observation", "SAO 166273"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.69866816),
        dec: Angle.Degrees(-22.94919110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61535"},
        {"Hipparcos Number", "HIP 37238"},
        {"Geneva Identification System", "GEN# +1.00061535"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.72197598),
        dec: Angle.Degrees(-22.94866943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62356"},
        {"Hipparcos Number", "HIP 37573"},
        {"Smithsonian Astrophysical Observation", "SAO 174345"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66492259),
        dec: Angle.Degrees(-22.94861105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100949"},
        {"Hipparcos Number", "HIP 56654"},
        {"Smithsonian Astrophysical Observation", "SAO 180036"},
        {"Wilson Evans Batten Catalogue", "WEB 10185"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.24958483),
        dec: Angle.Degrees(-22.94820464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56042"},
        {"Hipparcos Number", "HIP 35003"},
        {"Geneva Identification System", "GEN# +1.00056042"},
        {"Smithsonian Astrophysical Observation", "SAO 173271"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.62929273),
        dec: Angle.Degrees(-22.94239063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221646"},
        {"Hipparcos Number", "HIP 116311"},
        {"Smithsonian Astrophysical Observation", "SAO 191995"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.49149458),
        dec: Angle.Degrees(-22.94223723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51283"},
        {"Hipparcos Number", "HIP 33316"},
        {"Celescope Catalog", "CEL 1442"},
        {"Geneva Identification System", "GEN# +5.11210025"},
        {"Smithsonian Astrophysical Observation", "SAO 172588"},
        {"Wilson Evans Batten Catalogue", "WEB 6697"},
    },
    visualMagnitude: 5.29,
    bvColour: -0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.94554133),
        dec: Angle.Degrees(-22.94144950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 891"},
        {"Hipparcos Number", "HIP 1054"},
        {"Smithsonian Astrophysical Observation", "SAO 166122"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.28692569),
        dec: Angle.Degrees(-22.93545560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114803"},
        {"Hipparcos Number", "HIP 64495"},
        {"Smithsonian Astrophysical Observation", "SAO 181463"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30050918),
        dec: Angle.Degrees(-22.93316750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24359"},
        {"Hipparcos Number", "HIP 18068"},
        {"Geneva Identification System", "GEN# +1.00024359"},
        {"Smithsonian Astrophysical Observation", "SAO 168895"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.92742485),
        dec: Angle.Degrees(-22.93151967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198603"},
        {"Hipparcos Number", "HIP 102998"},
        {"Smithsonian Astrophysical Observation", "SAO 189788"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.01442471),
        dec: Angle.Degrees(-22.92806481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39385"},
        {"Hipparcos Number", "HIP 27670"},
        {"Geneva Identification System", "GEN# +1.00039385"},
        {"Smithsonian Astrophysical Observation", "SAO 170931"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86923616),
        dec: Angle.Degrees(-22.92684343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156991"},
        {"Hipparcos Number", "HIP 84936"},
        {"Smithsonian Astrophysical Observation", "SAO 185310"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.38171543),
        dec: Angle.Degrees(-22.92585231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212629"},
        {"Hipparcos Number", "HIP 110731"},
        {"Smithsonian Astrophysical Observation", "SAO 191136"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.51540825),
        dec: Angle.Degrees(-22.92580368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94620"},
        {"Hipparcos Number", "HIP 53385"},
        {"Smithsonian Astrophysical Observation", "SAO 179332"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.77672936),
        dec: Angle.Degrees(-22.92543902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155414"},
        {"Hipparcos Number", "HIP 84172"},
        {"Smithsonian Astrophysical Observation", "SAO 185143"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09774188),
        dec: Angle.Degrees(-22.92521908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78219"},
        {"Hipparcos Number", "HIP 44690"},
        {"Smithsonian Astrophysical Observation", "SAO 176959"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.60701081),
        dec: Angle.Degrees(-22.92486857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70302"},
        {"Hipparcos Number", "HIP 40876"},
        {"Geneva Identification System", "GEN# +1.00070302J"},
        {"Smithsonian Astrophysical Observation", "SAO 175634"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.11399520),
        dec: Angle.Degrees(-22.92467992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108600"},
        {"Hipparcos Number", "HIP 60886"},
        {"Smithsonian Astrophysical Observation", "SAO 180825"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.16980517),
        dec: Angle.Degrees(-22.92367636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168708"},
        {"Hipparcos Number", "HIP 90016"},
        {"Fundamental Katalog 5th Edition", "FK5 5617"},
        {"Smithsonian Astrophysical Observation", "SAO 186715"},
        {"Smithsonian Astrophysical Observation 2", "SAO 186717"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.51261714),
        dec: Angle.Degrees(-22.92165959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162255"},
        {"Hipparcos Number", "HIP 87370"},
        {"Geneva Identification System", "GEN# +1.00162255"},
        {"Smithsonian Astrophysical Observation", "SAO 185842"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78211394),
        dec: Angle.Degrees(-22.92081949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9258",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1581 A"},
        {"Henry Draper", "HD 12180"},
        {"Hipparcos Number", "HIP 9258"},
        {"Smithsonian Astrophysical Observation", "SAO 167451"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.75274982),
        dec: Angle.Degrees(-22.91987980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60070"},
        {"Hipparcos Number", "HIP 36630"},
        {"Smithsonian Astrophysical Observation", "SAO 173937"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.99277801),
        dec: Angle.Degrees(-22.91862846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11356"},
        {"Smithsonian Astrophysical Observation", "SAO 167787"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.56156722),
        dec: Angle.Degrees(-22.91810060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97940"},
        {"Hipparcos Number", "HIP 55002"},
        {"Smithsonian Astrophysical Observation", "SAO 179701"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.92768685),
        dec: Angle.Degrees(-22.91603978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10254"},
        {"Hipparcos Number", "HIP 7757"},
        {"Geneva Identification System", "GEN# +1.00010254"},
        {"Smithsonian Astrophysical Observation", "SAO 167208"},
        {"Wilson Evans Batten Catalogue", "WEB 1666"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97415825),
        dec: Angle.Degrees(-22.91333382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77925",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77925"},
        {"Smithsonian Astrophysical Observation", "SAO 183917"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.71164624),
        dec: Angle.Degrees(-22.91318444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86381"},
        {"Hipparcos Number", "HIP 48826"},
        {"Smithsonian Astrophysical Observation", "SAO 178232"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.40548565),
        dec: Angle.Degrees(-22.91306181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58346"},
        {"Hipparcos Number", "HIP 35920"},
        {"Celescope Catalog", "CEL 1830"},
        {"Geneva Identification System", "GEN# +5.11210046"},
        {"Smithsonian Astrophysical Observation", "SAO 173656"},
        {"Wilson Evans Batten Catalogue", "WEB 7155"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.07182051),
        dec: Angle.Degrees(-22.91276481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180490"},
        {"Hipparcos Number", "HIP 94821"},
        {"Smithsonian Astrophysical Observation", "SAO 187928"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.41324692),
        dec: Angle.Degrees(-22.91262509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67507"},
        {"Hipparcos Number", "HIP 39751"},
        {"Geneva Identification System", "GEN# +1.00067507"},
        {"Smithsonian Astrophysical Observation", "SAO 175215"},
        {"Wilson Evans Batten Catalogue", "WEB 7757"},
    },
    visualMagnitude: 8.20,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.87429892),
        dec: Angle.Degrees(-22.91257778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136986"},
        {"Hipparcos Number", "HIP 75393"},
        {"Wilson Evans Batten Catalogue", "WEB 12862"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.08242127),
        dec: Angle.Degrees(-22.91103826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23250"},
        {"Hipparcos Number", "HIP 17350"},
        {"Geneva Identification System", "GEN# +1.00023250"},
        {"Smithsonian Astrophysical Observation", "SAO 168766"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.70477545),
        dec: Angle.Degrees(-22.91039380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4967"},
        {"Hipparcos Number", "HIP 4022"},
        {"Cincinnati Publication", "Ci 20 61"},
        {"Geneva Identification System", "GEN# +1.00004967"},
        {"Smithsonian Astrophysical Observation", "SAO 166631"},
        {"Wilson Evans Batten Catalogue", "WEB 719"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.89013153),
        dec: Angle.Degrees(-22.90939545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 612.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152056"},
        {"Hipparcos Number", "HIP 82524"},
        {"Geneva Identification System", "GEN# +1.00152056"},
        {"Smithsonian Astrophysical Observation", "SAO 184730"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.00913755),
        dec: Angle.Degrees(-22.90922553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165920"},
        {"Hipparcos Number", "HIP 88942"},
        {"Smithsonian Astrophysical Observation", "SAO 186367"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.32355439),
        dec: Angle.Degrees(-22.90732217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -459.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34940",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5912 A"},
        {"Henry Draper", "HD 55856"},
        {"Hipparcos Number", "HIP 34940"},
        {"Geneva Identification System", "GEN# +1.00055856J"},
        {"Geneva Identification System 2", "GEN# +1.00055856A"},
        {"Smithsonian Astrophysical Observation", "SAO 173247"},
        {"Wilson Evans Batten Catalogue", "WEB 6985"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.45161454),
        dec: Angle.Degrees(-22.90578603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1012 B"},
        {"Hipparcos Number", "HIP 5858"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.78618890),
        dec: Angle.Degrees(-22.90271623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35959"},
        {"Hipparcos Number", "HIP 25520"},
        {"Smithsonian Astrophysical Observation", "SAO 170439"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.86162980),
        dec: Angle.Degrees(-22.90264381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222768"},
        {"Hipparcos Number", "HIP 117038"},
        {"Smithsonian Astrophysical Observation", "SAO 192110"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.88628436),
        dec: Angle.Degrees(-22.90214907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16010"},
        {"Smithsonian Astrophysical Observation", "SAO 168540"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54445150),
        dec: Angle.Degrees(-22.90063720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5857",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1012 A"},
        {"Henry Draper", "HD 7530"},
        {"Hipparcos Number", "HIP 5857"},
        {"Smithsonian Astrophysical Observation", "SAO 166904"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.78335468),
        dec: Angle.Degrees(-22.89947801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136678"},
        {"Hipparcos Number", "HIP 75270"},
        {"Geneva Identification System", "GEN# +1.00136678"},
        {"Renson", "Renson 38835"},
        {"Smithsonian Astrophysical Observation", "SAO 183419"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.68226296),
        dec: Angle.Degrees(-22.89924928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223547"},
        {"Hipparcos Number", "HIP 117555"},
        {"Smithsonian Astrophysical Observation", "SAO 192191"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.60460914),
        dec: Angle.Degrees(-22.89870060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42778"},
        {"Hipparcos Number", "HIP 29391"},
        {"Smithsonian Astrophysical Observation", "SAO 171363"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.91279822),
        dec: Angle.Degrees(-22.89671554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177120"},
        {"Hipparcos Number", "HIP 93649"},
        {"Smithsonian Astrophysical Observation", "SAO 187632"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.05915637),
        dec: Angle.Degrees(-22.89650648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75041"},
        {"Smithsonian Astrophysical Observation", "SAO 183384"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.01993245),
        dec: Angle.Degrees(-22.89614909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224295"},
        {"Hipparcos Number", "HIP 118046"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.16480297),
        dec: Angle.Degrees(-22.89602246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144431"},
        {"Hipparcos Number", "HIP 78920"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.66478392),
        dec: Angle.Degrees(-22.89517929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34324"},
        {"Hipparcos Number", "HIP 24528"},
        {"Smithsonian Astrophysical Observation", "SAO 170243"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.93295628),
        dec: Angle.Degrees(-22.89437340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117626"},
        {"Hipparcos Number", "HIP 66014"},
        {"Smithsonian Astrophysical Observation", "SAO 181728"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.01005990),
        dec: Angle.Degrees(-22.89374756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149866"},
        {"Hipparcos Number", "HIP 81464"},
        {"Fundamental Katalog 5th Edition", "FK5 5472"},
        {"Geneva Identification System", "GEN# +1.00149866"},
        {"Smithsonian Astrophysical Observation", "SAO 184508"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.58020155),
        dec: Angle.Degrees(-22.89276079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57392"},
        {"Hipparcos Number", "HIP 35553"},
        {"Celescope Catalog", "CEL 1790"},
        {"Smithsonian Astrophysical Observation", "SAO 173492"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.04275341),
        dec: Angle.Degrees(-22.89108530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140577"},
        {"Hipparcos Number", "HIP 77155"},
        {"Smithsonian Astrophysical Observation", "SAO 183756"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.29737094),
        dec: Angle.Degrees(-22.89049112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107538"},
        {"Hipparcos Number", "HIP 60283"},
        {"Smithsonian Astrophysical Observation", "SAO 180719"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.42323181),
        dec: Angle.Degrees(-22.88865889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41418"},
        {"Geneva Identification System", "GEN# -0.02202275"},
        {"Smithsonian Astrophysical Observation", "SAO 175846"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.72086240),
        dec: Angle.Degrees(-22.88861548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107104"},
        {"Hipparcos Number", "HIP 60064"},
        {"Smithsonian Astrophysical Observation", "SAO 180676"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.75768886),
        dec: Angle.Degrees(-22.88833846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5269"},
        {"Hipparcos Number", "HIP 4251"},
        {"Smithsonian Astrophysical Observation", "SAO 166666"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.55599155),
        dec: Angle.Degrees(-22.88551097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94769"},
        {"Hipparcos Number", "HIP 53456"},
        {"Smithsonian Astrophysical Observation", "SAO 179351"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.03034283),
        dec: Angle.Degrees(-22.88364784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18115"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.09537918),
        dec: Angle.Degrees(-22.88297082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 438.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 197.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65228"},
        {"Hipparcos Number", "HIP 38835"},
        {"Fundamental Katalog 5th Edition", "FK5 2615"},
        {"Geneva Identification System", "GEN# +1.00065228"},
        {"Smithsonian Astrophysical Observation", "SAO 174852"},
        {"Wilson Evans Batten Catalogue", "WEB 7604"},
    },
    visualMagnitude: 4.20,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.21482616),
        dec: Angle.Degrees(-22.88014849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82812"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.86234325),
        dec: Angle.Degrees(-22.87975567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202116"},
        {"Hipparcos Number", "HIP 104864"},
        {"Geneva Identification System", "GEN# +1.00202116"},
        {"Smithsonian Astrophysical Observation", "SAO 190154"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.63657917),
        dec: Angle.Degrees(-22.87807338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199991"},
        {"Hipparcos Number", "HIP 103737"},
        {"Geneva Identification System", "GEN# +1.00199991"},
        {"Smithsonian Astrophysical Observation", "SAO 189937"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.31634009),
        dec: Angle.Degrees(-22.87751400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36949"},
        {"Geneva Identification System", "GEN# -4.02202386"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.94794506),
        dec: Angle.Degrees(-22.87748592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51854"},
        {"Hipparcos Number", "HIP 33523"},
        {"Celescope Catalog", "CEL 1460"},
        {"Geneva Identification System", "GEN# +1.00051854"},
        {"Smithsonian Astrophysical Observation", "SAO 172653"},
        {"Wilson Evans Batten Catalogue", "WEB 6741"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50882341),
        dec: Angle.Degrees(-22.87611021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182960"},
        {"Hipparcos Number", "HIP 95709"},
        {"Smithsonian Astrophysical Observation", "SAO 188155"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.01289361),
        dec: Angle.Degrees(-22.87436537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75381"},
        {"Hipparcos Number", "HIP 43269"},
        {"Smithsonian Astrophysical Observation", "SAO 176514"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.22342593),
        dec: Angle.Degrees(-22.87417021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62905"},
        {"Geneva Identification System", "GEN# -0.02203467"},
        {"Smithsonian Astrophysical Observation", "SAO 181201"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.38679576),
        dec: Angle.Degrees(-22.87289877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141534"},
        {"Hipparcos Number", "HIP 77585"},
        {"Smithsonian Astrophysical Observation", "SAO 183846"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.61083918),
        dec: Angle.Degrees(-22.87223637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1881"},
        {"Smithsonian Astrophysical Observation", "SAO 166237"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.94047240),
        dec: Angle.Degrees(-22.65470703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208808"},
        {"Hipparcos Number", "HIP 108540"},
        {"Geneva Identification System", "GEN# +1.00208808"},
        {"Smithsonian Astrophysical Observation", "SAO 190794"},
        {"Wilson Evans Batten Catalogue", "WEB 19540"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.82300801),
        dec: Angle.Degrees(-22.87187752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9069"},
        {"Smithsonian Astrophysical Observation", "SAO 167419"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.18785266),
        dec: Angle.Degrees(-22.87166597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13730"},
        {"Hipparcos Number", "HIP 10341"},
        {"Geneva Identification System", "GEN# +1.00013730"},
        {"Smithsonian Astrophysical Observation", "SAO 167641"},
        {"Wilson Evans Batten Catalogue", "WEB 2164"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.30815978),
        dec: Angle.Degrees(-22.87116735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157621"},
        {"Hipparcos Number", "HIP 85254"},
        {"Smithsonian Astrophysical Observation", "SAO 185380"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.31763136),
        dec: Angle.Degrees(-22.87107685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79484"},
        {"Hipparcos Number", "HIP 45287"},
        {"Geneva Identification System", "GEN# +1.00079484"},
        {"Smithsonian Astrophysical Observation", "SAO 177137"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.44730804),
        dec: Angle.Degrees(-22.86974514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82747"},
        {"Hipparcos Number", "HIP 46897"},
        {"Geneva Identification System", "GEN# +1.00082747"},
        {"Smithsonian Astrophysical Observation", "SAO 177649"},
        {"Wilson Evans Batten Catalogue", "WEB 8840"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.35873201),
        dec: Angle.Degrees(-22.86401784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106079"},
        {"Hipparcos Number", "HIP 59522"},
        {"Smithsonian Astrophysical Observation", "SAO 180560"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.10009033),
        dec: Angle.Degrees(-22.86039359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59136"},
        {"Hipparcos Number", "HIP 36236"},
        {"Celescope Catalog", "CEL 1864"},
        {"Geneva Identification System", "GEN# +1.00059136"},
        {"Smithsonian Astrophysical Observation", "SAO 173778"},
    },
    visualMagnitude: 5.98,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.92891065),
        dec: Angle.Degrees(-22.85919757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83662"},
        {"Smithsonian Astrophysical Observation", "SAO 185019"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.49833950),
        dec: Angle.Degrees(-22.85597479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -324.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186332"},
        {"Hipparcos Number", "HIP 97138"},
        {"Geneva Identification System", "GEN# +1.00186332"},
        {"Smithsonian Astrophysical Observation", "SAO 188509"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.13597683),
        dec: Angle.Degrees(-22.85576270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6628"},
        {"Hipparcos Number", "HIP 5227"},
        {"Geneva Identification System", "GEN# +1.00006628"},
        {"Smithsonian Astrophysical Observation", "SAO 166806"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.70437929),
        dec: Angle.Degrees(-22.85569871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2476"},
        {"Hipparcos Number", "HIP 2238"},
        {"Smithsonian Astrophysical Observation", "SAO 166297"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.09566307),
        dec: Angle.Degrees(-22.85495963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199037"},
        {"Hipparcos Number", "HIP 103253"},
        {"Fundamental Katalog 5th Edition", "FK5 5841"},
        {"Smithsonian Astrophysical Observation", "SAO 189837"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.76795859),
        dec: Angle.Degrees(-22.85235740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57573"},
        {"Hipparcos Number", "HIP 35609"},
        {"Celescope Catalog", "CEL 1793"},
        {"Geneva Identification System", "GEN# +1.00057573"},
        {"Smithsonian Astrophysical Observation", "SAO 173517"},
        {"Wilson Evans Batten Catalogue", "WEB 7095"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.22122933),
        dec: Angle.Degrees(-22.85043997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21244"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.35834747),
        dec: Angle.Degrees(-22.85000319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -415.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49867"},
        {"Hipparcos Number", "HIP 32722"},
        {"Smithsonian Astrophysical Observation", "SAO 172381"},
    },
    visualMagnitude: 10.08,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.39809083),
        dec: Angle.Degrees(-22.84951262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132572"},
        {"Hipparcos Number", "HIP 73442"},
        {"Smithsonian Astrophysical Observation", "SAO 183079"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.12672802),
        dec: Angle.Degrees(-22.84933883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174170"},
        {"Hipparcos Number", "HIP 92429"},
        {"Geneva Identification System", "GEN# +1.00174170"},
        {"Smithsonian Astrophysical Observation", "SAO 187331"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.55005341),
        dec: Angle.Degrees(-22.84817209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198032"},
        {"Hipparcos Number", "HIP 102668"},
        {"Smithsonian Astrophysical Observation", "SAO 189708"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.07041112),
        dec: Angle.Degrees(-22.84555131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195041"},
        {"Hipparcos Number", "HIP 101100"},
        {"Smithsonian Astrophysical Observation", "SAO 189348"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.40730817),
        dec: Angle.Degrees(-22.84510421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8779"},
        {"Smithsonian Astrophysical Observation", "SAO 167376"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.23345015),
        dec: Angle.Degrees(-22.84227758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3326"},
        {"Hipparcos Number", "HIP 2852"},
        {"Fundamental Katalog 5th Edition", "FK5 2037"},
        {"Geneva Identification System", "GEN# +1.00003326"},
        {"Renson", "Renson 910"},
        {"Smithsonian Astrophysical Observation", "SAO 166400"},
        {"Wilson Evans Batten Catalogue", "WEB 514"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.02876061),
        dec: Angle.Degrees(-22.84221094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107924"},
        {"Hipparcos Number", "HIP 60507"},
        {"Smithsonian Astrophysical Observation", "SAO 180763"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.06246504),
        dec: Angle.Degrees(-22.84078189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40151"},
        {"Hipparcos Number", "HIP 28085"},
        {"Geneva Identification System", "GEN# +1.00040151"},
        {"Smithsonian Astrophysical Observation", "SAO 171034"},
        {"Wilson Evans Batten Catalogue", "WEB 5497"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.05915111),
        dec: Angle.Degrees(-22.84005515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26614"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.85938789),
        dec: Angle.Degrees(-22.83802439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85773"},
        {"Hipparcos Number", "HIP 48516"},
        {"Geneva Identification System", "GEN# +1.00085773"},
        {"Smithsonian Astrophysical Observation", "SAO 178150"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.41355387),
        dec: Angle.Degrees(-22.83562075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37375"},
        {"Hipparcos Number", "HIP 26398"},
        {"Geneva Identification System", "GEN# +1.00037375"},
        {"Smithsonian Astrophysical Observation", "SAO 170599"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.28942285),
        dec: Angle.Degrees(-22.83526037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99199"},
        {"Hipparcos Number", "HIP 55700"},
        {"Smithsonian Astrophysical Observation", "SAO 179854"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.19781491),
        dec: Angle.Degrees(-22.83279747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125665"},
        {"Hipparcos Number", "HIP 70180"},
        {"Geneva Identification System", "GEN# +1.00125665"},
        {"Smithsonian Astrophysical Observation", "SAO 182461"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.38172097),
        dec: Angle.Degrees(-22.83240770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56776"},
        {"Hipparcos Number", "HIP 35302"},
        {"Smithsonian Astrophysical Observation", "SAO 173398"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.38339941),
        dec: Angle.Degrees(-22.82995715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29343",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4793 AB"},
        {"Henry Draper", "HD 42695"},
        {"Hipparcos Number", "HIP 29343"},
        {"Renson", "Renson 11420"},
        {"Smithsonian Astrophysical Observation", "SAO 171352"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80396803),
        dec: Angle.Degrees(-22.82817835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84989"},
        {"Hipparcos Number", "HIP 48096"},
        {"Smithsonian Astrophysical Observation", "SAO 178018"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.09560026),
        dec: Angle.Degrees(-22.82798663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149167"},
        {"Hipparcos Number", "HIP 81093"},
        {"Smithsonian Astrophysical Observation", "SAO 184461"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.45713536),
        dec: Angle.Degrees(-22.82621734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113520"},
        {"Hipparcos Number", "HIP 63798"},
        {"Smithsonian Astrophysical Observation", "SAO 181368"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.13924138),
        dec: Angle.Degrees(-22.82588782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123966"},
        {"Hipparcos Number", "HIP 69317"},
        {"Renson", "Renson 35464"},
        {"Smithsonian Astrophysical Observation", "SAO 182321"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.81499796),
        dec: Angle.Degrees(-22.82561920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97277"},
        {"Hipparcos Number", "HIP 54682"},
        {"Fundamental Katalog 5th Edition", "FK5 421"},
        {"Geneva Identification System", "GEN# +1.00097277"},
        {"Smithsonian Astrophysical Observation", "SAO 179624"},
        {"Wilson Evans Batten Catalogue", "WEB 9872"},
    },
    visualMagnitude: 4.46,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.91452617),
        dec: Angle.Degrees(-22.82560642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153610"},
        {"Hipparcos Number", "HIP 83297"},
        {"Smithsonian Astrophysical Observation", "SAO 184928"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.35309796),
        dec: Angle.Degrees(-22.82489728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10999"},
        {"Hipparcos Number", "HIP 8340"},
        {"Smithsonian Astrophysical Observation", "SAO 167296"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.88995265),
        dec: Angle.Degrees(-22.82305884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219940"},
        {"Hipparcos Number", "HIP 115204"},
        {"Geneva Identification System", "GEN# +1.00219940"},
        {"Smithsonian Astrophysical Observation", "SAO 191828"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.01163455),
        dec: Angle.Degrees(-22.82159228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207398"},
        {"Hipparcos Number", "HIP 107708"},
        {"Fundamental Katalog 5th Edition", "FK5 5925"},
        {"Geneva Identification System", "GEN# +1.00207398"},
        {"Smithsonian Astrophysical Observation", "SAO 190653"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.27919182),
        dec: Angle.Degrees(-22.81853687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 768"},
        {"Hipparcos Number", "HIP 964"},
        {"Geneva Identification System", "GEN# +1.00000768"},
        {"Smithsonian Astrophysical Observation", "SAO 166107"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.97819202),
        dec: Angle.Degrees(-22.81759748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41321"},
        {"Hipparcos Number", "HIP 28693"},
        {"Smithsonian Astrophysical Observation", "SAO 171186"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.87236249),
        dec: Angle.Degrees(-22.81664966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18918"},
        {"Smithsonian Astrophysical Observation", "SAO 169069"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.82536170),
        dec: Angle.Degrees(-22.81505528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219629"},
        {"Hipparcos Number", "HIP 114999"},
        {"Geneva Identification System", "GEN# +1.00219629"},
        {"Smithsonian Astrophysical Observation", "SAO 191795"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.36933924),
        dec: Angle.Degrees(-22.81438466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27529"},
        {"Hipparcos Number", "HIP 20208"},
        {"Smithsonian Astrophysical Observation", "SAO 169345"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.95660089),
        dec: Angle.Degrees(-22.81170042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186805"},
        {"Hipparcos Number", "HIP 97381"},
        {"Smithsonian Astrophysical Observation", "SAO 188568"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.87236795),
        dec: Angle.Degrees(-22.81022634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146175"},
        {"Hipparcos Number", "HIP 79676"},
        {"Smithsonian Astrophysical Observation", "SAO 184266"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.92571584),
        dec: Angle.Degrees(-22.80781684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18967"},
        {"Hipparcos Number", "HIP 14148"},
        {"Smithsonian Astrophysical Observation", "SAO 168248"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.60318233),
        dec: Angle.Degrees(-22.80737537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107938"},
        {"Hipparcos Number", "HIP 60520"},
        {"Smithsonian Astrophysical Observation", "SAO 180767"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.09478297),
        dec: Angle.Degrees(-22.80219250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148834"},
        {"Hipparcos Number", "HIP 80937"},
        {"Geneva Identification System", "GEN# +1.00148834"},
        {"Smithsonian Astrophysical Observation", "SAO 184440"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.90542214),
        dec: Angle.Degrees(-22.80119731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85176",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10519 AB"},
        {"Henry Draper", "HD 157470"},
        {"Hipparcos Number", "HIP 85176"},
        {"Smithsonian Astrophysical Observation", "SAO 185362"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.09943347),
        dec: Angle.Degrees(-22.80086870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79691"},
        {"Hipparcos Number", "HIP 45390"},
        {"Smithsonian Astrophysical Observation", "SAO 177167"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.74318592),
        dec: Angle.Degrees(-22.79916727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8767"},
        {"Hipparcos Number", "HIP 6699"},
        {"Fundamental Katalog 5th Edition", "FK5 4134"},
        {"Smithsonian Astrophysical Observation", "SAO 167043"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.52080913),
        dec: Angle.Degrees(-22.79838944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105144"},
        {"Hipparcos Number", "HIP 59041"},
        {"Smithsonian Astrophysical Observation", "SAO 180465"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.56858188),
        dec: Angle.Degrees(-22.79630905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211667"},
        {"Hipparcos Number", "HIP 110175"},
        {"Smithsonian Astrophysical Observation", "SAO 191051"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.74399742),
        dec: Angle.Degrees(-22.79512988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32503"},
        {"Hipparcos Number", "HIP 23474"},
        {"Geneva Identification System", "GEN# +1.00032503"},
        {"Smithsonian Astrophysical Observation", "SAO 170010"},
        {"Wilson Evans Batten Catalogue", "WEB 4567"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68726911),
        dec: Angle.Degrees(-22.79508768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65175",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8867 AB"},
        {"Henry Draper", "HD 116046"},
        {"Hipparcos Number", "HIP 65175"},
        {"Smithsonian Astrophysical Observation", "SAO 181582"},
        {"Smithsonian Astrophysical Observation 2", "SAO 181584"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.34847473),
        dec: Angle.Degrees(-22.79421155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97110"},
        {"Hipparcos Number", "HIP 54601"},
        {"Smithsonian Astrophysical Observation", "SAO 179615"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.62558067),
        dec: Angle.Degrees(-22.79114965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217498"},
        {"Hipparcos Number", "HIP 113673"},
        {"Fundamental Katalog 5th Edition", "FK5 3842"},
        {"Geneva Identification System", "GEN# +1.00217498"},
        {"Smithsonian Astrophysical Observation", "SAO 191585"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.34594456),
        dec: Angle.Degrees(-22.79083025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11767"},
        {"Hipparcos Number", "HIP 8931"},
        {"Smithsonian Astrophysical Observation", "SAO 167389"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.74205465),
        dec: Angle.Degrees(-22.78635685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100073"},
        {"Hipparcos Number", "HIP 56175"},
        {"Smithsonian Astrophysical Observation", "SAO 179949"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72442537),
        dec: Angle.Degrees(-22.78320930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96080"},
        {"Hipparcos Number", "HIP 54149"},
        {"Geneva Identification System", "GEN# +1.00096080"},
        {"Smithsonian Astrophysical Observation", "SAO 179504"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.15708618),
        dec: Angle.Degrees(-22.78276111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206178"},
        {"Hipparcos Number", "HIP 107052"},
        {"Geneva Identification System", "GEN# +1.00206178"},
        {"Smithsonian Astrophysical Observation", "SAO 190546"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.22254644),
        dec: Angle.Degrees(-22.78162431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60665"},
        {"Hipparcos Number", "HIP 36868"},
        {"Smithsonian Astrophysical Observation", "SAO 174036"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.68998642),
        dec: Angle.Degrees(-22.78157555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38279"},
        {"Hipparcos Number", "HIP 27003"},
        {"Smithsonian Astrophysical Observation", "SAO 170739"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.92329365),
        dec: Angle.Degrees(-22.78052935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10983 A"},
        {"Henry Draper", "HD 164402"},
        {"Hipparcos Number", "HIP 88298"},
        {"Celescope Catalog", "CEL 4595"},
        {"Geneva Identification System", "GEN# +2.65140055"},
        {"Smithsonian Astrophysical Observation", "SAO 186135"},
        {"Wilson Evans Batten Catalogue", "WEB 14924"},
        {"New General Catalogue", "NGC 6514 55"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.47658742),
        dec: Angle.Degrees(-22.78029065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187333"},
        {"Hipparcos Number", "HIP 97602"},
        {"Smithsonian Astrophysical Observation", "SAO 188612"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.56784666),
        dec: Angle.Degrees(-22.77991190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193525"},
        {"Hipparcos Number", "HIP 100376"},
        {"Smithsonian Astrophysical Observation", "SAO 189190"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.35088594),
        dec: Angle.Degrees(-22.77964861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3449 AB"},
        {"Henry Draper", "HD 30421"},
        {"Hipparcos Number", "HIP 22209"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.64391844),
        dec: Angle.Degrees(-22.77961079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214579"},
        {"Hipparcos Number", "HIP 111865"},
        {"Geneva Identification System", "GEN# +1.00214579"},
        {"Smithsonian Astrophysical Observation", "SAO 191304"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.88363403),
        dec: Angle.Degrees(-22.77887818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42443"},
        {"Hipparcos Number", "HIP 29234"},
        {"Geneva Identification System", "GEN# +1.00042443J"},
        {"Smithsonian Astrophysical Observation", "SAO 171317"},
        {"Wilson Evans Batten Catalogue", "WEB 5732"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.44961008),
        dec: Angle.Degrees(-22.77449062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138739"},
        {"Hipparcos Number", "HIP 76268"},
        {"Smithsonian Astrophysical Observation", "SAO 183585"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.67468401),
        dec: Angle.Degrees(-22.77122408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1121 AB"},
        {"Hipparcos Number", "HIP 6544"},
        {"Smithsonian Astrophysical Observation", "SAO 167016"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.02623002),
        dec: Angle.Degrees(-22.77097670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85754"},
        {"Hipparcos Number", "HIP 48496"},
        {"Smithsonian Astrophysical Observation", "SAO 178141"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.35013516),
        dec: Angle.Degrees(-22.77064171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 606"},
        {"Hipparcos Number", "HIP 842"},
        {"Smithsonian Astrophysical Observation", "SAO 166092"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.58572192),
        dec: Angle.Degrees(-22.76918457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28438"},
        {"Hipparcos Number", "HIP 20862"},
        {"Geneva Identification System", "GEN# +1.00028438"},
        {"Smithsonian Astrophysical Observation", "SAO 169483"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.06070607),
        dec: Angle.Degrees(-22.76795739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11287"},
        {"Hipparcos Number", "HIP 8554"},
        {"Smithsonian Astrophysical Observation", "SAO 167340"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.58932241),
        dec: Angle.Degrees(-22.76755249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47562"},
        {"Hipparcos Number", "HIP 31727"},
        {"Smithsonian Astrophysical Observation", "SAO 172065"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.56743121),
        dec: Angle.Degrees(-22.76751117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142315"},
        {"Hipparcos Number", "HIP 77911"},
        {"Celescope Catalog", "CEL 4404"},
        {"Geneva Identification System", "GEN# +1.00142315"},
        {"Smithsonian Astrophysical Observation", "SAO 183916"},
        {"Wilson Evans Batten Catalogue", "WEB 13175"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.67335387),
        dec: Angle.Degrees(-22.76619825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49099",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7610 A"},
        {"Henry Draper", "HD 86916"},
        {"Hipparcos Number", "HIP 49099"},
        {"Smithsonian Astrophysical Observation", "SAO 178307"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.31575233),
        dec: Angle.Degrees(-22.76501544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118515"},
        {"Hipparcos Number", "HIP 66481"},
        {"Smithsonian Astrophysical Observation", "SAO 181812"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.44458739),
        dec: Angle.Degrees(-22.76462680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160989"},
        {"Hipparcos Number", "HIP 86778"},
        {"Smithsonian Astrophysical Observation", "SAO 185667"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.98543268),
        dec: Angle.Degrees(-22.76190984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201930"},
        {"Hipparcos Number", "HIP 104764"},
        {"Geneva Identification System", "GEN# +1.00201930"},
        {"Smithsonian Astrophysical Observation", "SAO 190135"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.35505217),
        dec: Angle.Degrees(-22.76180125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146774"},
        {"Hipparcos Number", "HIP 79931"},
        {"Smithsonian Astrophysical Observation", "SAO 184307"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.71478560),
        dec: Angle.Degrees(-22.76071215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112519"},
        {"Hipparcos Number", "HIP 63243"},
        {"Geneva Identification System", "GEN# +1.00112519"},
        {"Smithsonian Astrophysical Observation", "SAO 181265"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.38819062),
        dec: Angle.Degrees(-22.75346787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140671"},
        {"Hipparcos Number", "HIP 77191"},
        {"Smithsonian Astrophysical Observation", "SAO 183765"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.42902008),
        dec: Angle.Degrees(-22.75324352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84412"},
        {"Hipparcos Number", "HIP 47790"},
        {"Geneva Identification System", "GEN# +1.00084412"},
        {"Smithsonian Astrophysical Observation", "SAO 177914"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15180647),
        dec: Angle.Degrees(-22.75190884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99691"},
        {"Hipparcos Number", "HIP 55959"},
        {"Smithsonian Astrophysical Observation", "SAO 179908"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.01342932),
        dec: Angle.Degrees(-22.75189460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74939"},
        {"Smithsonian Astrophysical Observation", "SAO 183364"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.69976902),
        dec: Angle.Degrees(-22.74954043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115429"},
        {"Hipparcos Number", "HIP 64831"},
        {"Smithsonian Astrophysical Observation", "SAO 181519"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.36104696),
        dec: Angle.Degrees(-22.74888964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203639"},
        {"Hipparcos Number", "HIP 105662"},
        {"Geneva Identification System", "GEN# +1.00203639"},
        {"Smithsonian Astrophysical Observation", "SAO 190293"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.03308102),
        dec: Angle.Degrees(-22.74707085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92761",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ainalrami"},
        {"Aitken", "ADS 11794 A"},
        {"Henry Draper", "HD 174974"},
        {"Hipparcos Number", "HIP 92761"},
        {"Geneva Identification System", "GEN# +1.00174974"},
        {"Smithsonian Astrophysical Observation", "SAO 187426"},
        {"Wilson Evans Batten Catalogue", "WEB 16051"},
    },
    visualMagnitude: 4.86,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.54239695),
        dec: Angle.Degrees(-22.74482020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35754"},
        {"Hipparcos Number", "HIP 25395"},
        {"Smithsonian Astrophysical Observation", "SAO 170419"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.49171240),
        dec: Angle.Degrees(-22.74109689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183857"},
        {"Hipparcos Number", "HIP 96107"},
        {"Renson", "Renson 50776"},
        {"Smithsonian Astrophysical Observation", "SAO 188255"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.10273750),
        dec: Angle.Degrees(-22.74067575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198044"},
        {"Hipparcos Number", "HIP 102675"},
        {"Geneva Identification System", "GEN# +1.00198044"},
        {"Smithsonian Astrophysical Observation", "SAO 189712"},
        {"Wilson Evans Batten Catalogue", "WEB 18611"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.09067469),
        dec: Angle.Degrees(-22.74027790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167266"},
        {"Hipparcos Number", "HIP 89456"},
        {"Smithsonian Astrophysical Observation", "SAO 186547"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.84626992),
        dec: Angle.Degrees(-22.73953255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214438"},
        {"Hipparcos Number", "HIP 111767"},
        {"Smithsonian Astrophysical Observation", "SAO 191288"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.60075059),
        dec: Angle.Degrees(-22.73867960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168139"},
        {"Hipparcos Number", "HIP 89781"},
        {"Smithsonian Astrophysical Observation", "SAO 186644"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.83099901),
        dec: Angle.Degrees(-22.73753353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189561"},
        {"Hipparcos Number", "HIP 98575"},
        {"Fundamental Katalog 5th Edition", "FK5 3600"},
        {"Geneva Identification System", "GEN# +1.00189561"},
        {"Smithsonian Astrophysical Observation", "SAO 188829"},
        {"Wilson Evans Batten Catalogue", "WEB 17423"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.34933830),
        dec: Angle.Degrees(-22.73727899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150714"},
        {"Hipparcos Number", "HIP 81893"},
        {"Geneva Identification System", "GEN# +1.00150714"},
        {"Renson", "Renson 42640"},
        {"Smithsonian Astrophysical Observation", "SAO 184578"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.91544454),
        dec: Angle.Degrees(-22.73642211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10656"},
        {"Hipparcos Number", "HIP 8061"},
        {"Smithsonian Astrophysical Observation", "SAO 167255"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.88661948),
        dec: Angle.Degrees(-22.73466543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2362"},
        {"Hipparcos Number", "HIP 2162"},
        {"Geneva Identification System", "GEN# +1.00002362"},
        {"Smithsonian Astrophysical Observation", "SAO 166283"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.81572475),
        dec: Angle.Degrees(-22.73400568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73362"},
        {"Hipparcos Number", "HIP 42285"},
        {"Smithsonian Astrophysical Observation", "SAO 176177"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.32838639),
        dec: Angle.Degrees(-22.73247211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7142"},
        {"Hipparcos Number", "HIP 5577"},
        {"Smithsonian Astrophysical Observation", "SAO 166860"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.87178393),
        dec: Angle.Degrees(-22.72901517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25828"},
        {"Hipparcos Number", "HIP 19044"},
        {"Smithsonian Astrophysical Observation", "SAO 169096"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.20517821),
        dec: Angle.Degrees(-22.72815003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185535"},
        {"Hipparcos Number", "HIP 96785"},
        {"Smithsonian Astrophysical Observation", "SAO 188425"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.09887722),
        dec: Angle.Degrees(-22.72802286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110396"},
        {"Hipparcos Number", "HIP 61967"},
        {"Smithsonian Astrophysical Observation", "SAO 181028"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.48619494),
        dec: Angle.Degrees(-22.72797633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16413"},
        {"Hipparcos Number", "HIP 12217"},
        {"Smithsonian Astrophysical Observation", "SAO 167926"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.33703613),
        dec: Angle.Degrees(-22.72578277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30256"},
        {"Geneva Identification System", "GEN# -2.02203005"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.47586513),
        dec: Angle.Degrees(-22.72401646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -633.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 279.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136941"},
        {"Hipparcos Number", "HIP 75378"},
        {"Smithsonian Astrophysical Observation", "SAO 183434"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.04725245),
        dec: Angle.Degrees(-22.72394933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120303"},
        {"Hipparcos Number", "HIP 67418"},
        {"Smithsonian Astrophysical Observation", "SAO 181982"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.25576595),
        dec: Angle.Degrees(-22.72381538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220812"},
        {"Hipparcos Number", "HIP 115748"},
        {"Smithsonian Astrophysical Observation", "SAO 191909"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.75518132),
        dec: Angle.Degrees(-22.72340033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5555"},
        {"Smithsonian Astrophysical Observation", "SAO 166857"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.81318378),
        dec: Angle.Degrees(-22.72307491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74219",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9523 AB"},
        {"Henry Draper", "HD 134339"},
        {"Hipparcos Number", "HIP 74219"},
        {"Smithsonian Astrophysical Observation", "SAO 183234"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.50108347),
        dec: Angle.Degrees(-22.72068874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36274"},
        {"Hipparcos Number", "HIP 25729"},
        {"Geneva Identification System", "GEN# +1.00036274"},
        {"Smithsonian Astrophysical Observation", "SAO 170482"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.41614394),
        dec: Angle.Degrees(-22.71874187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164637"},
        {"Hipparcos Number", "HIP 88396"},
        {"Celescope Catalog", "CEL 4600"},
        {"Geneva Identification System", "GEN# +1.00164637"},
        {"Smithsonian Astrophysical Observation", "SAO 186169"},
        {"Wilson Evans Batten Catalogue", "WEB 14943"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.75713079),
        dec: Angle.Degrees(-22.71848644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4700"},
        {"Smithsonian Astrophysical Observation", "SAO 166738"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.11448720),
        dec: Angle.Degrees(-22.71507100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43745"},
        {"Hipparcos Number", "HIP 29843"},
        {"Geneva Identification System", "GEN# +1.00043745A"},
        {"Smithsonian Astrophysical Observation", "SAO 171502"},
        {"Wilson Evans Batten Catalogue", "WEB 5908"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.26466059),
        dec: Angle.Degrees(-22.71460054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188578"},
        {"Hipparcos Number", "HIP 98134"},
        {"Smithsonian Astrophysical Observation", "SAO 188736"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.16320664),
        dec: Angle.Degrees(-22.71383229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28623"},
        {"Smithsonian Astrophysical Observation", "SAO 171166"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.64246674),
        dec: Angle.Degrees(-22.71313824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177017"},
        {"Hipparcos Number", "HIP 93605"},
        {"Geneva Identification System", "GEN# +1.00177017J"},
        {"Smithsonian Astrophysical Observation", "SAO 187624"},
        {"Wilson Evans Batten Catalogue", "WEB 16256"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.93235416),
        dec: Angle.Degrees(-22.71187546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151594"},
        {"Hipparcos Number", "HIP 82319"},
        {"Smithsonian Astrophysical Observation", "SAO 184671"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.30092049),
        dec: Angle.Degrees(-22.71152417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196188"},
        {"Hipparcos Number", "HIP 101658"},
        {"Smithsonian Astrophysical Observation", "SAO 189481"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.09853830),
        dec: Angle.Degrees(-22.71129978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216146"},
        {"Hipparcos Number", "HIP 112804"},
        {"Smithsonian Astrophysical Observation", "SAO 191438"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.66862604),
        dec: Angle.Degrees(-22.71066581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217882"},
        {"Hipparcos Number", "HIP 113910"},
        {"Smithsonian Astrophysical Observation", "SAO 191618"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.01499208),
        dec: Angle.Degrees(-22.71010835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156523"},
        {"Hipparcos Number", "HIP 84706"},
        {"Fundamental Katalog 5th Edition", "FK5 5527"},
        {"Geneva Identification System", "GEN# +1.00156523"},
        {"Smithsonian Astrophysical Observation", "SAO 185257"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.72829645),
        dec: Angle.Degrees(-22.70780179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62351"},
        {"Smithsonian Astrophysical Observation", "SAO 181091"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.64601922),
        dec: Angle.Degrees(-22.70615448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38883"},
        {"Hipparcos Number", "HIP 27379"},
        {"Smithsonian Astrophysical Observation", "SAO 170849"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.98436092),
        dec: Angle.Degrees(-22.70524722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150495"},
        {"Hipparcos Number", "HIP 81782"},
        {"Smithsonian Astrophysical Observation", "SAO 184556"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.55969344),
        dec: Angle.Degrees(-22.70278012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137875"},
        {"Hipparcos Number", "HIP 75816"},
        {"Smithsonian Astrophysical Observation", "SAO 183515"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.31740331),
        dec: Angle.Degrees(-22.69996140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66670"},
        {"Hipparcos Number", "HIP 39446"},
        {"Smithsonian Astrophysical Observation", "SAO 175086"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.95972412),
        dec: Angle.Degrees(-22.69827787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109186"},
        {"Hipparcos Number", "HIP 61251"},
        {"Smithsonian Astrophysical Observation", "SAO 180890"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.27993291),
        dec: Angle.Degrees(-22.69689997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46665"},
        {"Hipparcos Number", "HIP 31286"},
        {"Renson", "Renson 12510"},
        {"Smithsonian Astrophysical Observation", "SAO 171948"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.42137616),
        dec: Angle.Degrees(-22.69595468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74992"},
        {"Hipparcos Number", "HIP 43098"},
        {"Smithsonian Astrophysical Observation", "SAO 176455"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.66540025),
        dec: Angle.Degrees(-22.69577573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28219"},
        {"Smithsonian Astrophysical Observation", "SAO 171073"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.43603894),
        dec: Angle.Degrees(-22.69577529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176537"},
        {"Hipparcos Number", "HIP 93423"},
        {"Geneva Identification System", "GEN# +1.00176537"},
        {"Smithsonian Astrophysical Observation", "SAO 187584"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.40724237),
        dec: Angle.Degrees(-22.69536606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2979"},
        {"Hipparcos Number", "HIP 2589"},
        {"Smithsonian Astrophysical Observation", "SAO 166351"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.22167876),
        dec: Angle.Degrees(-22.69340258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24389"},
        {"Hipparcos Number", "HIP 18087"},
        {"Smithsonian Astrophysical Observation", "SAO 168898"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.99333449),
        dec: Angle.Degrees(-22.69318549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77127"},
        {"Hipparcos Number", "HIP 44175"},
        {"Geneva Identification System", "GEN# +1.00077127"},
        {"Smithsonian Astrophysical Observation", "SAO 176806"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.97369661),
        dec: Angle.Degrees(-22.69159906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84019"},
        {"Smithsonian Astrophysical Observation", "SAO 185105"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.62523635),
        dec: Angle.Degrees(-22.68871986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208540"},
        {"Hipparcos Number", "HIP 108379"},
        {"Smithsonian Astrophysical Observation", "SAO 190767"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.35527333),
        dec: Angle.Degrees(-22.68824537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143600"},
        {"Hipparcos Number", "HIP 78549"},
        {"Geneva Identification System", "GEN# +1.00143600"},
        {"Smithsonian Astrophysical Observation", "SAO 184045"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.55651417),
        dec: Angle.Degrees(-22.68750482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53150"},
    },
    visualMagnitude: 11.97,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.10946750),
        dec: Angle.Degrees(-22.68739314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83087"},
        {"Hipparcos Number", "HIP 47056"},
        {"Smithsonian Astrophysical Observation", "SAO 177707"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.85284616),
        dec: Angle.Degrees(-22.68591248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99408"},
        {"Hipparcos Number", "HIP 55812"},
        {"Renson", "Renson 28624"},
        {"Smithsonian Astrophysical Observation", "SAO 179876"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.55710245),
        dec: Angle.Degrees(-22.68326337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1906 A"},
        {"Henry Draper", "HD 15588"},
        {"Hipparcos Number", "HIP 11622"},
        {"Geneva Identification System", "GEN# +1.00015588"},
        {"Renson", "Renson 3890"},
        {"Smithsonian Astrophysical Observation", "SAO 167832"},
        {"Wilson Evans Batten Catalogue", "WEB 2421"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.48044474),
        dec: Angle.Degrees(-22.68318886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49335"},
        {"Hipparcos Number", "HIP 32508"},
        {"Smithsonian Astrophysical Observation", "SAO 172319"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.76183452),
        dec: Angle.Degrees(-22.68032344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85022"},
        {"Hipparcos Number", "HIP 48112"},
        {"Smithsonian Astrophysical Observation", "SAO 178023"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14481913),
        dec: Angle.Degrees(-22.68012188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213433"},
        {"Hipparcos Number", "HIP 111192"},
        {"Smithsonian Astrophysical Observation", "SAO 191204"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.89555488),
        dec: Angle.Degrees(-22.67687791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80263"},
        {"Hipparcos Number", "HIP 45638"},
        {"Geneva Identification System", "GEN# +1.00080263"},
        {"Smithsonian Astrophysical Observation", "SAO 177238"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.53754209),
        dec: Angle.Degrees(-22.67556794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87122",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10799 AB"},
        {"Henry Draper", "HD 161702"},
        {"Hipparcos Number", "HIP 87122"},
        {"Smithsonian Astrophysical Observation", "SAO 185774"},
    },
    visualMagnitude: 9.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)48, 00.7900),
        dec: Angle.DegreesMinutesSeconds((int)-22, (int)40, 29.700)
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
    primaryId: "HIP 82919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82919"},
        {"Smithsonian Astrophysical Observation", "SAO 184819"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.17109895),
        dec: Angle.Degrees(-22.67422327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55762"},
        {"Hipparcos Number", "HIP 34914"},
        {"Geneva Identification System", "GEN# +1.00055762"},
        {"Smithsonian Astrophysical Observation", "SAO 173230"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.35003994),
        dec: Angle.Degrees(-22.67414589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175190"},
        {"Hipparcos Number", "HIP 92845"},
        {"Geneva Identification System", "GEN# +1.00175190"},
        {"Smithsonian Astrophysical Observation", "SAO 187445"},
        {"Wilson Evans Batten Catalogue", "WEB 16071"},
    },
    visualMagnitude: 5.00,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.77946681),
        dec: Angle.Degrees(-22.67125323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122582"},
        {"Hipparcos Number", "HIP 68659"},
        {"Smithsonian Astrophysical Observation", "SAO 182193"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.81341455),
        dec: Angle.Degrees(-22.67102081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172934"},
        {"Hipparcos Number", "HIP 91864"},
        {"Smithsonian Astrophysical Observation", "SAO 187196"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.92806715),
        dec: Angle.Degrees(-22.67028770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203475"},
        {"Hipparcos Number", "HIP 105576"},
        {"Geneva Identification System", "GEN# +1.00203475"},
        {"Smithsonian Astrophysical Observation", "SAO 190285"},
        {"Wilson Evans Batten Catalogue", "WEB 19169"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.75196452),
        dec: Angle.Degrees(-22.66904892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91975"},
        {"Hipparcos Number", "HIP 51958"},
        {"Smithsonian Astrophysical Observation", "SAO 179029"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.21310884),
        dec: Angle.Degrees(-22.66524200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172256"},
        {"Hipparcos Number", "HIP 91550"},
        {"Geneva Identification System", "GEN# +1.00172256"},
        {"Smithsonian Astrophysical Observation", "SAO 187112"},
        {"Wilson Evans Batten Catalogue", "WEB 15740"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.04586912),
        dec: Angle.Degrees(-22.66382370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6914 AB"},
        {"Henry Draper", "HD 73752"},
        {"Hipparcos Number", "HIP 42430"},
        {"Cincinnati Publication", "Ci 20 480"},
        {"Geneva Identification System", "GEN# +1.00073752"},
        {"Smithsonian Astrophysical Observation", "SAO 176226"},
        {"Wilson Evans Batten Catalogue", "WEB 8160"},
    },
    visualMagnitude: 5.05,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.78362446),
        dec: Angle.Degrees(-22.66290580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -268.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 424.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175909"},
        {"Hipparcos Number", "HIP 93155"},
        {"Renson", "Renson 49110"},
        {"Smithsonian Astrophysical Observation", "SAO 187521"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.62886110),
        dec: Angle.Degrees(-22.66262509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61749"},
        {"Smithsonian Astrophysical Observation", "SAO 180987"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.82063705),
        dec: Angle.Degrees(-22.66087046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115994",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16793 AB"},
        {"Henry Draper", "HD 221199"},
        {"Hipparcos Number", "HIP 115994"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.51939013),
        dec: Angle.Degrees(-22.65892761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127493"},
        {"Hipparcos Number", "HIP 71096"},
        {"Geneva Identification System", "GEN# +1.00127493"},
        {"Renson", "Renson 36250"},
        {"Smithsonian Astrophysical Observation", "SAO 182646"},
        {"Wilson Evans Batten Catalogue", "WEB 12295"},
    },
    visualMagnitude: 10.04,
    bvColour: -0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.08963547),
        dec: Angle.Degrees(-22.65708063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89297"},
        {"Hipparcos Number", "HIP 50419"},
        {"Smithsonian Astrophysical Observation", "SAO 178631"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.42374553),
        dec: Angle.Degrees(-22.65592416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105451"},
        {"Hipparcos Number", "HIP 59204"},
        {"Smithsonian Astrophysical Observation", "SAO 180506"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.11289202),
        dec: Angle.Degrees(-22.65488494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147742"},
        {"Hipparcos Number", "HIP 80374"},
        {"Geneva Identification System", "GEN# +1.00147742"},
        {"Smithsonian Astrophysical Observation", "SAO 184366"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.10451898),
        dec: Angle.Degrees(-22.65483675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215934"},
        {"Hipparcos Number", "HIP 112660"},
        {"Smithsonian Astrophysical Observation", "SAO 191421"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.23809239),
        dec: Angle.Degrees(-22.65476745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101660"},
        {"Hipparcos Number", "HIP 57056"},
        {"Fundamental Katalog 5th Edition", "FK5 5036"},
        {"Smithsonian Astrophysical Observation", "SAO 180113"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.45522440),
        dec: Angle.Degrees(-22.65277880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84669"},
        {"Hipparcos Number", "HIP 47954"},
        {"Smithsonian Astrophysical Observation", "SAO 177960"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.57312713),
        dec: Angle.Degrees(-22.65258086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37831"},
        {"Hipparcos Number", "HIP 26698"},
        {"Smithsonian Astrophysical Observation", "SAO 170673"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.10608742),
        dec: Angle.Degrees(-22.64831311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3714 A"},
        {"Henry Draper", "HD 33143"},
        {"Hipparcos Number", "HIP 23823"},
        {"Smithsonian Astrophysical Observation", "SAO 170087"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.82405146),
        dec: Angle.Degrees(-22.64727178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52462"},
        {"Hipparcos Number", "HIP 33734"},
        {"Geneva Identification System", "GEN# +1.00052462"},
        {"Smithsonian Astrophysical Observation", "SAO 172732"},
        {"Wilson Evans Batten Catalogue", "WEB 6778"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.11704697),
        dec: Angle.Degrees(-22.64504863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51457"},
        {"Hipparcos Number", "HIP 33380"},
        {"Smithsonian Astrophysical Observation", "SAO 172606"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.14234358),
        dec: Angle.Degrees(-22.64489207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214362"},
        {"Hipparcos Number", "HIP 111730"},
        {"Geneva Identification System", "GEN# +1.00214362"},
        {"Smithsonian Astrophysical Observation", "SAO 191281"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.49400860),
        dec: Angle.Degrees(-22.64435313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152956"},
        {"Hipparcos Number", "HIP 82986"},
        {"Smithsonian Astrophysical Observation", "SAO 184831"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.37598743),
        dec: Angle.Degrees(-22.64357714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1765"},
        {"Hipparcos Number", "HIP 1729"},
        {"Geneva Identification System", "GEN# +1.00001765"},
        {"Smithsonian Astrophysical Observation", "SAO 166211"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.46268574),
        dec: Angle.Degrees(-22.64284579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33386"},
        {"Smithsonian Astrophysical Observation", "SAO 172608"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.14725579),
        dec: Angle.Degrees(-22.64027211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83396"},
        {"Smithsonian Astrophysical Observation", "SAO 184951"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.67287058),
        dec: Angle.Degrees(-22.63838183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18509"},
        {"Smithsonian Astrophysical Observation", "SAO 168985"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.36029827),
        dec: Angle.Degrees(-22.63817740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214532"},
        {"Hipparcos Number", "HIP 111830"},
        {"Smithsonian Astrophysical Observation", "SAO 191299"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.77541485),
        dec: Angle.Degrees(-22.63791193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118892"},
        {"Hipparcos Number", "HIP 66680"},
        {"Smithsonian Astrophysical Observation", "SAO 181845"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.04082647),
        dec: Angle.Degrees(-22.63791038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4123"},
        {"Hipparcos Number", "HIP 3417"},
        {"Smithsonian Astrophysical Observation", "SAO 166515"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.87199633),
        dec: Angle.Degrees(-22.63710052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33374"},
        {"Hipparcos Number", "HIP 23952"},
        {"Geneva Identification System", "GEN# +1.00033374"},
        {"Smithsonian Astrophysical Observation", "SAO 170115"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.21538834),
        dec: Angle.Degrees(-22.63481965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22399"},
    },
    visualMagnitude: 9.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.31286187),
        dec: Angle.Degrees(-22.63470719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190350"},
        {"Hipparcos Number", "HIP 98948"},
        {"Smithsonian Astrophysical Observation", "SAO 188896"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.34277516),
        dec: Angle.Degrees(-22.63210467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88492"},
        {"Hipparcos Number", "HIP 49948"},
        {"Smithsonian Astrophysical Observation", "SAO 178521"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.96405088),
        dec: Angle.Degrees(-22.63121920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110953"},
        {"Hipparcos Number", "HIP 62288"},
        {"Smithsonian Astrophysical Observation", "SAO 181087"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.47290928),
        dec: Angle.Degrees(-22.63037151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14131"},
        {"Hipparcos Number", "HIP 10605"},
        {"Smithsonian Astrophysical Observation", "SAO 167674"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.13416137),
        dec: Angle.Degrees(-22.63027023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151150"},
        {"Hipparcos Number", "HIP 82116"},
        {"Smithsonian Astrophysical Observation", "SAO 184625"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.62132704),
        dec: Angle.Degrees(-22.62832107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141683"},
        {"Hipparcos Number", "HIP 77642"},
        {"Geneva Identification System", "GEN# +1.00141683"},
        {"Smithsonian Astrophysical Observation", "SAO 183858"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.77191902),
        dec: Angle.Degrees(-22.62654001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122900"},
        {"Hipparcos Number", "HIP 68803"},
        {"Smithsonian Astrophysical Observation", "SAO 182226"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.27396990),
        dec: Angle.Degrees(-22.62211752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78401",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dschubba"},
        {"Henry Draper", "HD 143275"},
        {"Hipparcos Number", "HIP 78401"},
        {"Celescope Catalog", "CEL 4410"},
        {"Fundamental Katalog 5th Edition", "FK5 594"},
        {"Geneva Identification System", "GEN# +1.00143275"},
        {"Smithsonian Astrophysical Observation", "SAO 184014"},
        {"Wilson Evans Batten Catalogue", "WEB 13251"},
    },
    visualMagnitude: 2.29,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.08338225),
        dec: Angle.Degrees(-22.62162024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171013"},
        {"Hipparcos Number", "HIP 90966"},
        {"Geneva Identification System", "GEN# +1.00171013"},
        {"Smithsonian Astrophysical Observation", "SAO 186963"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.34156809),
        dec: Angle.Degrees(-22.62055832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59316",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Minkar"},
        {"Henry Draper", "HD 105707"},
        {"Hipparcos Number", "HIP 59316"},
        {"Fundamental Katalog 5th Edition", "FK5 453"},
        {"Geneva Identification System", "GEN# +1.00105707"},
        {"Smithsonian Astrophysical Observation", "SAO 180531"},
        {"Wilson Evans Batten Catalogue", "WEB 10552"},
    },
    visualMagnitude: 3.02,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.53135773),
        dec: Angle.Degrees(-22.61979211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118145"},
        {"Hipparcos Number", "HIP 66313"},
        {"Geneva Identification System", "GEN# +1.00118145"},
        {"Smithsonian Astrophysical Observation", "SAO 181774"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.85461538),
        dec: Angle.Degrees(-22.61888027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129065"},
        {"Hipparcos Number", "HIP 71792"},
        {"Smithsonian Astrophysical Observation", "SAO 182764"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.27807332),
        dec: Angle.Degrees(-22.61853975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122719"},
        {"Hipparcos Number", "HIP 68710"},
        {"Smithsonian Astrophysical Observation", "SAO 182206"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.99224450),
        dec: Angle.Degrees(-22.61740509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 716 AB"},
        {"Hipparcos Number", "HIP 4072"},
        {"Cincinnati Publication", "Ci 18 115"},
        {"Geneva Identification System", "GEN# +1.00005058"},
        {"Smithsonian Astrophysical Observation", "SAO 166640"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.05366556),
        dec: Angle.Degrees(-22.61675897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188178"},
        {"Hipparcos Number", "HIP 97981"},
        {"Geneva Identification System", "GEN# +1.00188178"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.68731267),
        dec: Angle.Degrees(-22.61658696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149288"},
        {"Hipparcos Number", "HIP 81169"},
        {"Smithsonian Astrophysical Observation", "SAO 184470"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.67438231),
        dec: Angle.Degrees(-22.61645862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29433"},
        {"Hipparcos Number", "HIP 21514"},
        {"Smithsonian Astrophysical Observation", "SAO 169617"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.30617188),
        dec: Angle.Degrees(-22.61489674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31593",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5260 AB"},
        {"Henry Draper", "HD 47247"},
        {"Hipparcos Number", "HIP 31593"},
        {"Geneva Identification System", "GEN# +1.00047247J"},
        {"Smithsonian Astrophysical Observation", "SAO 172021"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.17112193),
        dec: Angle.Degrees(-22.61475069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29730"},
        {"Hipparcos Number", "HIP 21736"},
        {"Smithsonian Astrophysical Observation", "SAO 169646"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.01620365),
        dec: Angle.Degrees(-22.61417320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217002"},
        {"Hipparcos Number", "HIP 113383"},
        {"Smithsonian Astrophysical Observation", "SAO 191530"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.44255547),
        dec: Angle.Degrees(-22.61053532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220409"},
        {"Hipparcos Number", "HIP 115492"},
        {"Smithsonian Astrophysical Observation", "SAO 191869"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.93454863),
        dec: Angle.Degrees(-22.60995825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223243"},
        {"Hipparcos Number", "HIP 117370"},
        {"Smithsonian Astrophysical Observation", "SAO 192158"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.97136429),
        dec: Angle.Degrees(-22.60897790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46566"},
        {"Hipparcos Number", "HIP 31239"},
        {"Geneva Identification System", "GEN# +1.00046566"},
        {"Smithsonian Astrophysical Observation", "SAO 171931"},
        {"Wilson Evans Batten Catalogue", "WEB 6246"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.29218822),
        dec: Angle.Degrees(-22.60885133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16896"},
        {"Hipparcos Number", "HIP 12594"},
        {"Smithsonian Astrophysical Observation", "SAO 167977"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.48933369),
        dec: Angle.Degrees(-22.60601266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78806"},
        {"Hipparcos Number", "HIP 44969"},
        {"Smithsonian Astrophysical Observation", "SAO 177047"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.41065913),
        dec: Angle.Degrees(-22.60272225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111416",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16061 AB"},
        {"Henry Draper", "HD 213792"},
        {"Hipparcos Number", "HIP 111416"},
        {"Smithsonian Astrophysical Observation", "SAO 191233"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.59052831),
        dec: Angle.Degrees(-22.60213913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32267"},
        {"Hipparcos Number", "HIP 23322"},
        {"Smithsonian Astrophysical Observation", "SAO 169972"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.23782290),
        dec: Angle.Degrees(-22.60179905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100053"},
        {"Smithsonian Astrophysical Observation", "SAO 189112"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.48018092),
        dec: Angle.Degrees(-22.60165340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177609"},
        {"Hipparcos Number", "HIP 93819"},
        {"Geneva Identification System", "GEN# +1.00177609"},
        {"Smithsonian Astrophysical Observation", "SAO 187675"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.59067044),
        dec: Angle.Degrees(-22.60024828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216749"},
        {"Hipparcos Number", "HIP 113214"},
        {"Smithsonian Astrophysical Observation", "SAO 191500"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.91569348),
        dec: Angle.Degrees(-22.59805402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190009"},
        {"Hipparcos Number", "HIP 98785"},
        {"Geneva Identification System", "GEN# +1.00190009"},
        {"Smithsonian Astrophysical Observation", "SAO 188863"},
        {"Wilson Evans Batten Catalogue", "WEB 17498"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.93472579),
        dec: Angle.Degrees(-22.59565192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5660"},
        {"Hipparcos Number", "HIP 4530"},
        {"Fundamental Katalog 5th Edition", "FK5 4088"},
        {"Smithsonian Astrophysical Observation", "SAO 166711"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.50172363),
        dec: Angle.Degrees(-22.59564011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148288"},
        {"Hipparcos Number", "HIP 80632"},
        {"Smithsonian Astrophysical Observation", "SAO 184401"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.96151196),
        dec: Angle.Degrees(-22.59523482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224728"},
        {"Hipparcos Number", "HIP 13"},
        {"Smithsonian Astrophysical Observation", "SAO 192308"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.04167970),
        dec: Angle.Degrees(-22.59468060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25575"},
        {"Hipparcos Number", "HIP 18875"},
        {"Smithsonian Astrophysical Observation", "SAO 169058"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.69603499),
        dec: Angle.Degrees(-22.59424919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147137"},
        {"Hipparcos Number", "HIP 80088"},
        {"Geneva Identification System", "GEN# +1.00147137"},
        {"Smithsonian Astrophysical Observation", "SAO 184333"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.20932432),
        dec: Angle.Degrees(-22.59405953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194348"},
        {"Hipparcos Number", "HIP 100769"},
        {"Smithsonian Astrophysical Observation", "SAO 189275"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.46717805),
        dec: Angle.Degrees(-22.59235430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30925",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5128 AB"},
        {"Henry Draper", "HD 45941"},
        {"Hipparcos Number", "HIP 30925"},
        {"Smithsonian Astrophysical Observation", "SAO 171831"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.35648556),
        dec: Angle.Degrees(-22.59112369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9712"},
        {"Smithsonian Astrophysical Observation", "SAO 167537"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.23875416),
        dec: Angle.Degrees(-22.58902904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80960"},
        {"Hipparcos Number", "HIP 45953"},
        {"Smithsonian Astrophysical Observation", "SAO 177345"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.58185198),
        dec: Angle.Degrees(-22.58823972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1205"},
        {"Hipparcos Number", "HIP 1306"},
        {"Geneva Identification System", "GEN# +1.00001205"},
        {"Smithsonian Astrophysical Observation", "SAO 166163"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.09768809),
        dec: Angle.Degrees(-22.58791845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14316"},
        {"Hipparcos Number", "HIP 10740"},
        {"Geneva Identification System", "GEN# +1.00014316"},
        {"Smithsonian Astrophysical Observation", "SAO 167691"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.55460644),
        dec: Angle.Degrees(-22.58597138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91472"},
        {"Hipparcos Number", "HIP 51675"},
        {"Smithsonian Astrophysical Observation", "SAO 178969"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.35533217),
        dec: Angle.Degrees(-22.58472260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200083"},
        {"Hipparcos Number", "HIP 103787"},
        {"Geneva Identification System", "GEN# +1.00200083"},
        {"Smithsonian Astrophysical Observation", "SAO 189946"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.47072383),
        dec: Angle.Degrees(-22.58241558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159894"},
        {"Hipparcos Number", "HIP 86303"},
        {"Geneva Identification System", "GEN# +1.00159894"},
        {"Smithsonian Astrophysical Observation", "SAO 185572"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.51590711),
        dec: Angle.Degrees(-22.58188170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158172"},
        {"Hipparcos Number", "HIP 85526"},
        {"Fundamental Katalog 5th Edition", "FK5 5538"},
        {"Smithsonian Astrophysical Observation", "SAO 185437"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.17320180),
        dec: Angle.Degrees(-22.58133949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92798"},
        {"Cincinnati Publication", "Ci 20 1114"},
        {"Smithsonian Astrophysical Observation", "SAO 187437"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.63328634),
        dec: Angle.Degrees(-22.58058853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -303.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1298"},
        {"Smithsonian Astrophysical Observation", "SAO 166160"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.06893587),
        dec: Angle.Degrees(-22.57793652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155702"},
        {"Hipparcos Number", "HIP 84299"},
        {"Smithsonian Astrophysical Observation", "SAO 185177"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.52187490),
        dec: Angle.Degrees(-22.57781875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8996"},
        {"Smithsonian Astrophysical Observation", "SAO 167403"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.97227461),
        dec: Angle.Degrees(-22.57774155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130692"},
        {"Hipparcos Number", "HIP 72565"},
        {"Smithsonian Astrophysical Observation", "SAO 182913"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.56022785),
        dec: Angle.Degrees(-22.57195197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45199"},
        {"Hipparcos Number", "HIP 30537"},
        {"Smithsonian Astrophysical Observation", "SAO 171716"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.29448868),
        dec: Angle.Degrees(-22.57185947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174973"},
        {"Hipparcos Number", "HIP 92758"},
        {"Smithsonian Astrophysical Observation", "SAO 187425"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.53245143),
        dec: Angle.Degrees(-22.57035420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164844"},
        {"Hipparcos Number", "HIP 88484"},
        {"Celescope Catalog", "CEL 4608"},
        {"Geneva Identification System", "GEN# +2.65310002"},
        {"Smithsonian Astrophysical Observation", "SAO 186211"},
        {"Wilson Evans Batten Catalogue", "WEB 14965"},
        {"New General Catalogue", "NGC 6531 2"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.01219724),
        dec: Angle.Degrees(-22.56595088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124609"},
        {"Hipparcos Number", "HIP 69639"},
        {"Geneva Identification System", "GEN# +1.00124609"},
        {"Smithsonian Astrophysical Observation", "SAO 182381"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.78819841),
        dec: Angle.Degrees(-22.56442581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206797"},
        {"Hipparcos Number", "HIP 107392"},
        {"Geneva Identification System", "GEN# +1.00206797"},
        {"Smithsonian Astrophysical Observation", "SAO 190597"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.27096920),
        dec: Angle.Degrees(-22.56397240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33841"},
        {"Celescope Catalog", "CEL 1512"},
        {"Geneva Identification System", "GEN# -0.02201661"},
        {"Smithsonian Astrophysical Observation", "SAO 172779"},
    },
    visualMagnitude: 9.86,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.37571368),
        dec: Angle.Degrees(-22.56273298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27116"},
        {"Hipparcos Number", "HIP 19901"},
        {"Smithsonian Astrophysical Observation", "SAO 169281"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.04074131),
        dec: Angle.Degrees(-22.56208068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42928"},
        {"Hipparcos Number", "HIP 29469"},
        {"Smithsonian Astrophysical Observation", "SAO 171386"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.13458852),
        dec: Angle.Degrees(-22.56087457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30496"},
        {"Hipparcos Number", "HIP 22252"},
        {"Geneva Identification System", "GEN# +1.00030496"},
        {"Smithsonian Astrophysical Observation", "SAO 169769"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.84766100),
        dec: Angle.Degrees(-22.56046399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127252"},
        {"Hipparcos Number", "HIP 70964"},
        {"Smithsonian Astrophysical Observation", "SAO 182622"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.72508425),
        dec: Angle.Degrees(-22.56017115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87394"},
        {"Hipparcos Number", "HIP 49337"},
        {"Smithsonian Astrophysical Observation", "SAO 178365"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.07892911),
        dec: Angle.Degrees(-22.55910825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65069"},
        {"Hipparcos Number", "HIP 38771"},
        {"Smithsonian Astrophysical Observation", "SAO 174831"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.05021502),
        dec: Angle.Degrees(-22.55385886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80429"},
        {"Hipparcos Number", "HIP 45712"},
        {"Smithsonian Astrophysical Observation", "SAO 177268"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.78282786),
        dec: Angle.Degrees(-22.55314900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164002"},
        {"Hipparcos Number", "HIP 88126"},
        {"Celescope Catalog", "CEL 4586"},
        {"Geneva Identification System", "GEN# +1.00164002"},
        {"Smithsonian Astrophysical Observation", "SAO 186069"},
        {"Wilson Evans Batten Catalogue", "WEB 14884"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.00340034),
        dec: Angle.Degrees(-22.54839291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171254"},
        {"Hipparcos Number", "HIP 91083"},
        {"Smithsonian Astrophysical Observation", "SAO 187000"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.67129038),
        dec: Angle.Degrees(-22.54660664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201945"},
        {"Hipparcos Number", "HIP 104766"},
        {"Geneva Identification System", "GEN# +1.00201945"},
        {"Smithsonian Astrophysical Observation", "SAO 190137"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.36289376),
        dec: Angle.Degrees(-22.54598906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15652"},
        {"Hipparcos Number", "HIP 11671"},
        {"Geneva Identification System", "GEN# +1.00015652"},
        {"Smithsonian Astrophysical Observation", "SAO 167839"},
        {"Wilson Evans Batten Catalogue", "WEB 2429"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.63662647),
        dec: Angle.Degrees(-22.54524212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145468"},
        {"Hipparcos Number", "HIP 79366"},
        {"Geneva Identification System", "GEN# +1.00145468"},
        {"Smithsonian Astrophysical Observation", "SAO 184211"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.96943267),
        dec: Angle.Degrees(-22.54497348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34894"},
        {"Hipparcos Number", "HIP 24862"},
        {"Geneva Identification System", "GEN# +1.00034894"},
        {"Smithsonian Astrophysical Observation", "SAO 170318"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.94600324),
        dec: Angle.Degrees(-22.54305385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5639"},
        {"Geneva Identification System", "GEN# -0.02300441"},
        {"Smithsonian Astrophysical Observation", "SAO 166872"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.11906542),
        dec: Angle.Degrees(-22.54276805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128688"},
        {"Hipparcos Number", "HIP 71619"},
        {"Smithsonian Astrophysical Observation", "SAO 182728"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.71204132),
        dec: Angle.Degrees(-22.54251366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8361 A"},
        {"Henry Draper", "HD 103817A"},
        {"Henry Draper 2", "HD 103817"},
        {"Hipparcos Number", "HIP 58298"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.32697870),
        dec: Angle.Degrees(-22.53803515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123619"},
        {"Hipparcos Number", "HIP 69143"},
        {"Geneva Identification System", "GEN# +1.00123619"},
        {"Smithsonian Astrophysical Observation", "SAO 182292"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.30518929),
        dec: Angle.Degrees(-22.53769936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162676"},
        {"Hipparcos Number", "HIP 87557"},
        {"Smithsonian Astrophysical Observation", "SAO 185894"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.30762402),
        dec: Angle.Degrees(-22.53672574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51984"},
        {"Hipparcos Number", "HIP 33586"},
        {"Celescope Catalog", "CEL 1467"},
        {"Geneva Identification System", "GEN# +1.00051984"},
        {"Smithsonian Astrophysical Observation", "SAO 172668"},
    },
    visualMagnitude: 9.36,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.66260322),
        dec: Angle.Degrees(-22.53612030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212840"},
        {"Hipparcos Number", "HIP 110845"},
        {"Smithsonian Astrophysical Observation", "SAO 191155"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.85661156),
        dec: Angle.Degrees(-22.53430844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222332"},
        {"Hipparcos Number", "HIP 116750"},
        {"Geneva Identification System", "GEN# +1.00222332"},
        {"Smithsonian Astrophysical Observation", "SAO 192068"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.92311179),
        dec: Angle.Degrees(-22.53332737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68109"},
        {"Hipparcos Number", "HIP 40010"},
        {"Geneva Identification System", "GEN# +1.00068109"},
        {"Smithsonian Astrophysical Observation", "SAO 175306"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.56506579),
        dec: Angle.Degrees(-22.53326762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92391"},
        {"Hipparcos Number", "HIP 52189"},
        {"Smithsonian Astrophysical Observation", "SAO 179088"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.92691340),
        dec: Angle.Degrees(-22.53058170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90451"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.84524997),
        dec: Angle.Degrees(-22.52961667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175892"},
        {"Hipparcos Number", "HIP 93140"},
        {"Geneva Identification System", "GEN# +1.00175892"},
        {"Smithsonian Astrophysical Observation", "SAO 187519"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.60345583),
        dec: Angle.Degrees(-22.52952554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81903"},
        {"Hipparcos Number", "HIP 46412"},
        {"Smithsonian Astrophysical Observation", "SAO 177488"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.97106189),
        dec: Angle.Degrees(-22.52859746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50739",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7739 AB"},
        {"Henry Draper", "HD 89828"},
        {"Hipparcos Number", "HIP 50739"},
        {"Geneva Identification System", "GEN# +1.00089828J"},
        {"Smithsonian Astrophysical Observation", "SAO 178723"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.39953770),
        dec: Angle.Degrees(-22.52851150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9341"},
        {"Smithsonian Astrophysical Observation", "SAO 167470"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.98690011),
        dec: Angle.Degrees(-22.52783843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91398"},
        {"Hipparcos Number", "HIP 51633"},
        {"Geneva Identification System", "GEN# +1.00091398"},
        {"Smithsonian Astrophysical Observation", "SAO 178957"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.22769832),
        dec: Angle.Degrees(-22.52761026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7497"},
        {"Hipparcos Number", "HIP 5825"},
        {"Smithsonian Astrophysical Observation", "SAO 166902"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.67883281),
        dec: Angle.Degrees(-22.52678253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11930"},
        {"Hipparcos Number", "HIP 9061"},
        {"Fundamental Katalog 5th Edition", "FK5 2131"},
        {"Geneva Identification System", "GEN# +1.00011930"},
        {"Smithsonian Astrophysical Observation", "SAO 167416"},
        {"Wilson Evans Batten Catalogue", "WEB 1901"},
    },
    visualMagnitude: 4.92,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.16732782),
        dec: Angle.Degrees(-22.52671153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201407"},
        {"Hipparcos Number", "HIP 104487"},
        {"Geneva Identification System", "GEN# +1.00201407"},
        {"Smithsonian Astrophysical Observation", "SAO 190080"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.49869171),
        dec: Angle.Degrees(-22.52619477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76648"},
        {"Hipparcos Number", "HIP 43921"},
        {"Geneva Identification System", "GEN# +1.00076648"},
        {"Smithsonian Astrophysical Observation", "SAO 176733"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.20769957),
        dec: Angle.Degrees(-22.52507142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52614"},
        {"Hipparcos Number", "HIP 33796"},
        {"Celescope Catalog", "CEL 1507"},
        {"Smithsonian Astrophysical Observation", "SAO 172758"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.26221071),
        dec: Angle.Degrees(-22.52468383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217357"},
        {"Hipparcos Number", "HIP 113576"},
        {"Cincinnati Publication", "Ci 20 1396"},
        {"Geneva Identification System", "GEN# +1.00217357"},
        {"Smithsonian Astrophysical Observation", "SAO 191563"},
        {"Wilson Evans Batten Catalogue", "WEB 20189"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.06954949),
        dec: Angle.Degrees(-22.52448801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -904.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6990",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1186 A"},
        {"Henry Draper", "HD 9175"},
        {"Hipparcos Number", "HIP 6990"},
        {"Geneva Identification System", "GEN# +1.00009175"},
        {"Smithsonian Astrophysical Observation", "SAO 167088"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.49924147),
        dec: Angle.Degrees(-22.52410171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150814"},
        {"Hipparcos Number", "HIP 81941"},
        {"Geneva Identification System", "GEN# +1.00150814"},
        {"Smithsonian Astrophysical Observation", "SAO 184593"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07363376),
        dec: Angle.Degrees(-22.52352366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89566"},
        {"Hipparcos Number", "HIP 50570"},
        {"Smithsonian Astrophysical Observation", "SAO 178687"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.95341652),
        dec: Angle.Degrees(-22.52338890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42362"},
        {"Smithsonian Astrophysical Observation", "SAO 176206"},
    },
    visualMagnitude: 10.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.56350571),
        dec: Angle.Degrees(-22.52276983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4398"},
        {"Hipparcos Number", "HIP 3607"},
        {"Geneva Identification System", "GEN# +1.00004398"},
        {"Smithsonian Astrophysical Observation", "SAO 166555"},
        {"Wilson Evans Batten Catalogue", "WEB 642"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.54845521),
        dec: Angle.Degrees(-22.52206718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82690"},
        {"Hipparcos Number", "HIP 46858"},
        {"Geneva Identification System", "GEN# +1.00082690"},
        {"Smithsonian Astrophysical Observation", "SAO 177631"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.23188638),
        dec: Angle.Degrees(-22.52197744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24434"},
        {"Smithsonian Astrophysical Observation", "SAO 170228"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.63435666),
        dec: Angle.Degrees(-22.52048082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63271"},
        {"Hipparcos Number", "HIP 37995"},
        {"Geneva Identification System", "GEN# +1.00063271"},
        {"Smithsonian Astrophysical Observation", "SAO 174533"},
        {"Wilson Evans Batten Catalogue", "WEB 7495"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.80232686),
        dec: Angle.Degrees(-22.51953536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80991"},
        {"Hipparcos Number", "HIP 45970"},
        {"Geneva Identification System", "GEN# +1.00080991"},
        {"Smithsonian Astrophysical Observation", "SAO 177347"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.62955154),
        dec: Angle.Degrees(-22.51904117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163800"},
        {"Hipparcos Number", "HIP 88040"},
        {"Celescope Catalog", "CEL 4581"},
        {"Geneva Identification System", "GEN# +1.00163800"},
        {"Smithsonian Astrophysical Observation", "SAO 186037"},
        {"Wilson Evans Batten Catalogue", "WEB 14872"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.73857741),
        dec: Angle.Degrees(-22.51754185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73543"},
        {"Hipparcos Number", "HIP 42361"},
        {"Smithsonian Astrophysical Observation", "SAO 176202"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.55417517),
        dec: Angle.Degrees(-22.51729655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10057"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.35913057),
        dec: Angle.Degrees(-22.51121931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15382",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2463 AB"},
        {"Henry Draper", "HD 20610"},
        {"Hipparcos Number", "HIP 15382"},
        {"Geneva Identification System", "GEN# +1.00020610"},
        {"Smithsonian Astrophysical Observation", "SAO 168452"},
        {"Wilson Evans Batten Catalogue", "WEB 2959"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.59206509),
        dec: Angle.Degrees(-22.51114978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90"},
        {"Hipparcos Number", "HIP 478"},
        {"Geneva Identification System", "GEN# +1.00000090"},
        {"Smithsonian Astrophysical Observation", "SAO 166041"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.42927167),
        dec: Angle.Degrees(-22.50977022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92860"},
        {"Hipparcos Number", "HIP 52417"},
        {"Geneva Identification System", "GEN# +1.00092860"},
        {"Smithsonian Astrophysical Observation", "SAO 179148"},
        {"Wilson Evans Batten Catalogue", "WEB 9542"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.72650871),
        dec: Angle.Degrees(-22.50864848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 636",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 89 A"},
        {"Henry Draper", "HD 319"},
        {"Hipparcos Number", "HIP 636"},
        {"Geneva Identification System", "GEN# +1.00000319"},
        {"Smithsonian Astrophysical Observation", "SAO 166066"},
        {"Wilson Evans Batten Catalogue", "WEB 108"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.94523194),
        dec: Angle.Degrees(-22.50847542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33933"},
        {"Hipparcos Number", "HIP 24293"},
        {"Geneva Identification System", "GEN# +1.00033933"},
        {"Smithsonian Astrophysical Observation", "SAO 170189"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.20030054),
        dec: Angle.Degrees(-22.50759727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38444"},
        {"Hipparcos Number", "HIP 27102"},
        {"Smithsonian Astrophysical Observation", "SAO 170772"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.20972516),
        dec: Angle.Degrees(-22.50605424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2672"},
        {"Hipparcos Number", "HIP 2359"},
        {"Smithsonian Astrophysical Observation", "SAO 166311"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.53844615),
        dec: Angle.Degrees(-22.50563116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21760"},
        {"Hipparcos Number", "HIP 16274"},
        {"Smithsonian Astrophysical Observation", "SAO 168587"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.45441205),
        dec: Angle.Degrees(-22.50551707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137431"},
        {"Hipparcos Number", "HIP 75598"},
        {"Smithsonian Astrophysical Observation", "SAO 183474"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.68588291),
        dec: Angle.Degrees(-22.50539978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6401"},
        {"Hipparcos Number", "HIP 5051"},
        {"Smithsonian Astrophysical Observation", "SAO 166783"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16239630),
        dec: Angle.Degrees(-22.50410659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8280"},
        {"Hipparcos Number", "HIP 6370"},
        {"Smithsonian Astrophysical Observation", "SAO 166989"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.46633972),
        dec: Angle.Degrees(-22.50265937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220579"},
        {"Hipparcos Number", "HIP 115597"},
        {"Smithsonian Astrophysical Observation", "SAO 191885"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.24188771),
        dec: Angle.Degrees(-22.50230102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200551"},
        {"Hipparcos Number", "HIP 104056"},
        {"Smithsonian Astrophysical Observation", "SAO 189989"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.21749528),
        dec: Angle.Degrees(-22.50153641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177799"},
        {"Hipparcos Number", "HIP 93866"},
        {"Smithsonian Astrophysical Observation", "SAO 187686"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.74288045),
        dec: Angle.Degrees(-22.49759408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101942"},
    },
    visualMagnitude: 11.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.87469584),
        dec: Angle.Degrees(-22.49590079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 291.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38969"},
        {"Hipparcos Number", "HIP 27425"},
        {"Smithsonian Astrophysical Observation", "SAO 170860"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.10901159),
        dec: Angle.Degrees(-22.49511949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24015",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3742 A"},
        {"Henry Draper", "HD 33495"},
        {"Hipparcos Number", "HIP 24015"},
        {"Smithsonian Astrophysical Observation", "SAO 170131"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.43050866),
        dec: Angle.Degrees(-22.49399895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54787"},
        {"Hipparcos Number", "HIP 34537"},
        {"Smithsonian Astrophysical Observation", "SAO 173082"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.33812341),
        dec: Angle.Degrees(-22.49308460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5454"},
        {"Hipparcos Number", "HIP 4381"},
        {"Geneva Identification System", "GEN# +1.00005454"},
        {"Smithsonian Astrophysical Observation", "SAO 166690"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.03700652),
        dec: Angle.Degrees(-22.49029914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87870"},
        {"Hipparcos Number", "HIP 49610"},
        {"Geneva Identification System", "GEN# +1.00087870"},
        {"Smithsonian Astrophysical Observation", "SAO 178437"},
        {"Wilson Evans Batten Catalogue", "WEB 9147"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88405462),
        dec: Angle.Degrees(-22.48961859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85905"},
        {"Hipparcos Number", "HIP 48584"},
        {"Geneva Identification System", "GEN# +1.00085905"},
        {"Smithsonian Astrophysical Observation", "SAO 178164"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.63262827),
        dec: Angle.Degrees(-22.48745326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218074"},
        {"Hipparcos Number", "HIP 114017"},
        {"Smithsonian Astrophysical Observation", "SAO 191638"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.35633968),
        dec: Angle.Degrees(-22.48683403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17438"},
        {"Hipparcos Number", "HIP 13008"},
        {"Geneva Identification System", "GEN# +1.00017438"},
        {"Smithsonian Astrophysical Observation", "SAO 168051"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.79641948),
        dec: Angle.Degrees(-22.48565414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145718"},
        {"Hipparcos Number", "HIP 79476"},
        {"Geneva Identification System", "GEN# +1.00145718"},
        {"Smithsonian Astrophysical Observation", "SAO 184232"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.29832127),
        dec: Angle.Degrees(-22.48511576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22550"},
        {"Hipparcos Number", "HIP 16848"},
        {"Smithsonian Astrophysical Observation", "SAO 168679"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.20743297),
        dec: Angle.Degrees(-22.48490086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85078"},
        {"Smithsonian Astrophysical Observation", "SAO 185351"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.81637278),
        dec: Angle.Degrees(-22.48415142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207038"},
        {"Hipparcos Number", "HIP 107530"},
        {"Smithsonian Astrophysical Observation", "SAO 190617"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.68704324),
        dec: Angle.Degrees(-22.48343529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6363"},
        {"Hipparcos Number", "HIP 5030"},
        {"Geneva Identification System", "GEN# +1.00006363"},
        {"Smithsonian Astrophysical Observation", "SAO 166779"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.10536835),
        dec: Angle.Degrees(-22.48323250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20575"},
        {"Hipparcos Number", "HIP 15352"},
        {"Smithsonian Astrophysical Observation", "SAO 168447"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.49040404),
        dec: Angle.Degrees(-22.48115823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77202"},
        {"Hipparcos Number", "HIP 44220"},
        {"Smithsonian Astrophysical Observation", "SAO 176816"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.10274475),
        dec: Angle.Degrees(-22.47984421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161664"},
        {"Hipparcos Number", "HIP 87099"},
        {"Geneva Identification System", "GEN# +1.00161664"},
        {"Smithsonian Astrophysical Observation", "SAO 185765"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93999971),
        dec: Angle.Degrees(-22.47776778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201474"},
        {"Hipparcos Number", "HIP 104534"},
        {"Geneva Identification System", "GEN# +1.00201474"},
        {"Smithsonian Astrophysical Observation", "SAO 190087"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.62758777),
        dec: Angle.Degrees(-22.47748716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 781 AB"},
        {"Hipparcos Number", "HIP 4368"},
        {"Smithsonian Astrophysical Observation", "SAO 166687"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.99620114),
        dec: Angle.Degrees(-22.47745695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36478"},
        {"Smithsonian Astrophysical Observation", "SAO 173883"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.59002863),
        dec: Angle.Degrees(-22.47620334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6896"},
        {"Smithsonian Astrophysical Observation", "SAO 167077"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.19804040),
        dec: Angle.Degrees(-22.47425672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139447"},
        {"Hipparcos Number", "HIP 76636"},
        {"Fundamental Katalog 5th Edition", "FK5 5384"},
        {"Smithsonian Astrophysical Observation", "SAO 183657"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.75599367),
        dec: Angle.Degrees(-22.47367319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72280"},
        {"Smithsonian Astrophysical Observation", "SAO 182868"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.71776980),
        dec: Angle.Degrees(-22.47305124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 877"},
        {"Hipparcos Number", "HIP 1046"},
        {"Smithsonian Astrophysical Observation", "SAO 166120"},
        {"Wilson Evans Batten Catalogue", "WEB 181"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.26630969),
        dec: Angle.Degrees(-22.47020965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135169"},
        {"Hipparcos Number", "HIP 74586"},
        {"Smithsonian Astrophysical Observation", "SAO 183296"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.59068876),
        dec: Angle.Degrees(-22.46999608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124375"},
        {"Hipparcos Number", "HIP 69503"},
        {"Smithsonian Astrophysical Observation", "SAO 182356"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.43144751),
        dec: Angle.Degrees(-22.46978606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156182"},
        {"Hipparcos Number", "HIP 84543"},
        {"Smithsonian Astrophysical Observation", "SAO 185225"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.24945549),
        dec: Angle.Degrees(-22.46845325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163892"},
        {"Hipparcos Number", "HIP 88085"},
        {"Celescope Catalog", "CEL 4584"},
        {"Geneva Identification System", "GEN# +1.00163892"},
        {"Smithsonian Astrophysical Observation", "SAO 186053"},
        {"Wilson Evans Batten Catalogue", "WEB 14879"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.85962543),
        dec: Angle.Degrees(-22.46690193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165407"},
        {"Hipparcos Number", "HIP 88721"},
        {"Smithsonian Astrophysical Observation", "SAO 186289"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.69217840),
        dec: Angle.Degrees(-22.46455579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210488"},
        {"Hipparcos Number", "HIP 109525"},
        {"Smithsonian Astrophysical Observation", "SAO 190948"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.79669766),
        dec: Angle.Degrees(-22.46451393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127208"},
        {"Hipparcos Number", "HIP 70945"},
        {"Fundamental Katalog 5th Edition", "FK5 3147"},
        {"Geneva Identification System", "GEN# +1.00127208"},
        {"Smithsonian Astrophysical Observation", "SAO 182611"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.66864223),
        dec: Angle.Degrees(-22.46090783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218640"},
        {"Henry Draper 2", "HD 218641"},
        {"Hipparcos Number", "HIP 114375"},
        {"Smithsonian Astrophysical Observation", "SAO 191687"},
        {"Wilson Evans Batten Catalogue", "WEB 20305"},
    },
    visualMagnitude: 4.71,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.47865379),
        dec: Angle.Degrees(-22.45759248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27141"},
        {"Smithsonian Astrophysical Observation", "SAO 170783"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.31838635),
        dec: Angle.Degrees(-22.45606671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197284"},
        {"Hipparcos Number", "HIP 102280"},
        {"Geneva Identification System", "GEN# +1.00197284"},
        {"Smithsonian Astrophysical Observation", "SAO 189613"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.86018826),
        dec: Angle.Degrees(-22.45388084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32145",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5377 B"},
        {"Hipparcos Number", "HIP 32145"},
        {"Geneva Identification System", "GEN# +1.00048501B"},
        {"Smithsonian Astrophysical Observation", "SAO 172205"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.69517120),
        dec: Angle.Degrees(-22.45292833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5158"},
        {"Geneva Identification System", "GEN# -0.02300395"},
        {"Smithsonian Astrophysical Observation", "SAO 166798"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.50800326),
        dec: Angle.Degrees(-22.45289221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100490"},
        {"Hipparcos Number", "HIP 56396"},
        {"Geneva Identification System", "GEN# +1.00100490"},
        {"Smithsonian Astrophysical Observation", "SAO 179988"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.43061934),
        dec: Angle.Degrees(-22.45248792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182481"},
        {"Hipparcos Number", "HIP 95516"},
        {"Smithsonian Astrophysical Observation", "SAO 188112"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.43051594),
        dec: Angle.Degrees(-22.45154127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70391"},
        {"Hipparcos Number", "HIP 40909"},
        {"Smithsonian Astrophysical Observation", "SAO 175646"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.22720762),
        dec: Angle.Degrees(-22.45044239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5377 A"},
        {"Henry Draper", "HD 48501"},
        {"Hipparcos Number", "HIP 32144"},
        {"Geneva Identification System", "GEN# +1.00048501J"},
        {"Geneva Identification System 2", "GEN# +1.00048501A"},
        {"Smithsonian Astrophysical Observation", "SAO 172204"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.69199298),
        dec: Angle.Degrees(-22.44883550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4334 A"},
        {"Henry Draper", "HD 38393"},
        {"Hipparcos Number", "HIP 27072"},
        {"Cincinnati Publication", "Ci 20 350"},
        {"Fundamental Katalog 5th Edition", "FK5 217"},
        {"Geneva Identification System", "GEN# +1.00038393"},
        {"Smithsonian Astrophysical Observation", "SAO 170759"},
        {"Wilson Evans Batten Catalogue", "WEB 5328"},
    },
    visualMagnitude: 3.59,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.11656241),
        dec: Angle.Degrees(-22.44748663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -368.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48355"},
        {"Hipparcos Number", "HIP 32084"},
        {"Smithsonian Astrophysical Observation", "SAO 172183"},
        {"Wilson Evans Batten Catalogue", "WEB 6479"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.53814868),
        dec: Angle.Degrees(-22.44354619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196384"},
        {"Hipparcos Number", "HIP 101785"},
        {"Geneva Identification System", "GEN# +1.00196384"},
        {"Smithsonian Astrophysical Observation", "SAO 189502"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.43105335),
        dec: Angle.Degrees(-22.44288803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9942"},
        {"Hipparcos Number", "HIP 7509"},
        {"Smithsonian Astrophysical Observation", "SAO 167174"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.19028024),
        dec: Angle.Degrees(-22.44205615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54520"},
        {"Hipparcos Number", "HIP 34431"},
        {"Geneva Identification System", "GEN# +1.00054520"},
        {"Smithsonian Astrophysical Observation", "SAO 173039"},
        {"Wilson Evans Batten Catalogue", "WEB 6899"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.06350400),
        dec: Angle.Degrees(-22.44036562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148623"},
        {"Hipparcos Number", "HIP 80810"},
        {"Smithsonian Astrophysical Observation", "SAO 184426"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.52965930),
        dec: Angle.Degrees(-22.44015661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 313696"},
        {"Hipparcos Number", "HIP 88508"},
        {"Geneva Identification System", "GEN# +2.65310007"},
        {"New General Catalogue", "NGC 6531 7"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.10129484),
        dec: Angle.Degrees(-22.43855515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50914"},
        {"Hipparcos Number", "HIP 33176"},
        {"Smithsonian Astrophysical Observation", "SAO 172548"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.58049003),
        dec: Angle.Degrees(-22.43638795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9904"},
        {"Hipparcos Number", "HIP 7478"},
        {"Geneva Identification System", "GEN# +1.00009904"},
        {"Smithsonian Astrophysical Observation", "SAO 167172"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.07348151),
        dec: Angle.Degrees(-22.43594729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11507"},
        {"Hipparcos Number", "HIP 8768"},
        {"Cincinnati Publication", "Ci 18 251"},
        {"Cincinnati Publication 2", "Ci 20 132"},
        {"Geneva Identification System", "GEN# +1.00011507"},
        {"Smithsonian Astrophysical Observation", "SAO 167374"},
        {"Wilson Evans Batten Catalogue", "WEB 1847"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.20266288),
        dec: Angle.Degrees(-22.43485464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 844.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66929"},
        {"Hipparcos Number", "HIP 39559"},
        {"Geneva Identification System", "GEN# +1.00066929"},
        {"Smithsonian Astrophysical Observation", "SAO 175130"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.25504119),
        dec: Angle.Degrees(-22.43446349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36108"},
        {"Hipparcos Number", "HIP 25616"},
        {"Geneva Identification System", "GEN# +1.00036108"},
        {"Smithsonian Astrophysical Observation", "SAO 170461"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.08797529),
        dec: Angle.Degrees(-22.43428482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98252"},
        {"Hipparcos Number", "HIP 55183"},
        {"Geneva Identification System", "GEN# +1.00098252"},
        {"Smithsonian Astrophysical Observation", "SAO 179751"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.47999406),
        dec: Angle.Degrees(-22.43145632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83259"},
        {"Hipparcos Number", "HIP 47156"},
        {"Smithsonian Astrophysical Observation", "SAO 177733"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.13558220),
        dec: Angle.Degrees(-22.42972699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118319",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Axolotl"},
        {"Henry Draper", "HD 224693"},
        {"Hipparcos Number", "HIP 118319"},
        {"Geneva Identification System", "GEN# +1.00224693"},
        {"Smithsonian Astrophysical Observation", "SAO 192301"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.97391252),
        dec: Angle.Degrees(-22.42818030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42301"},
        {"Hipparcos Number", "HIP 29150"},
        {"Fundamental Katalog 5th Edition", "FK5 1165"},
        {"Geneva Identification System", "GEN# +1.00042301"},
        {"Smithsonian Astrophysical Observation", "SAO 171293"},
        {"Wilson Evans Batten Catalogue", "WEB 5718"},
    },
    visualMagnitude: 5.49,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.24111381),
        dec: Angle.Degrees(-22.42728352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34752"},
        {"Hipparcos Number", "HIP 24787"},
        {"Geneva Identification System", "GEN# +1.00034752"},
        {"Smithsonian Astrophysical Observation", "SAO 170301"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.71375885),
        dec: Angle.Degrees(-22.42720159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117103"},
        {"Hipparcos Number", "HIP 65741"},
        {"Smithsonian Astrophysical Observation", "SAO 181683"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.13750530),
        dec: Angle.Degrees(-22.42668948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38162"},
        {"Geneva Identification System", "GEN# -0.02202037"},
        {"Smithsonian Astrophysical Observation", "SAO 174597"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30534977),
        dec: Angle.Degrees(-22.42627610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122703"},
        {"Hipparcos Number", "HIP 68705"},
        {"Fundamental Katalog 5th Edition", "FK5 3117"},
        {"Geneva Identification System", "GEN# +1.00122703"},
        {"Smithsonian Astrophysical Observation", "SAO 182204"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.97123833),
        dec: Angle.Degrees(-22.42161640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1171"},
        {"Hipparcos Number", "HIP 1275"},
        {"Geneva Identification System", "GEN# +1.00001171"},
        {"Smithsonian Astrophysical Observation", "SAO 166157"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.00005536),
        dec: Angle.Degrees(-22.42144969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61960"},
        {"Hipparcos Number", "HIP 37421"},
        {"Smithsonian Astrophysical Observation", "SAO 174277"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.22659111),
        dec: Angle.Degrees(-22.42090162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5590"},
        {"Hipparcos Number", "HIP 4481"},
        {"Geneva Identification System", "GEN# +1.00005590"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.35900186),
        dec: Angle.Degrees(-22.41985787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217516"},
        {"Hipparcos Number", "HIP 113691"},
        {"Geneva Identification System", "GEN# +1.00217516"},
        {"Smithsonian Astrophysical Observation", "SAO 191590"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.39297701),
        dec: Angle.Degrees(-22.41930586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34996"},
        {"Hipparcos Number", "HIP 24941"},
        {"Smithsonian Astrophysical Observation", "SAO 170331"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.14544417),
        dec: Angle.Degrees(-22.41679631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93689"},
        {"Hipparcos Number", "HIP 52864"},
        {"Smithsonian Astrophysical Observation", "SAO 179244"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.17104625),
        dec: Angle.Degrees(-22.41664473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9487"},
        {"Hipparcos Number", "HIP 7194"},
        {"Geneva Identification System", "GEN# +1.00009487"},
        {"Renson", "Renson 2290"},
        {"Smithsonian Astrophysical Observation", "SAO 167126"},
        {"Wilson Evans Batten Catalogue", "WEB 1552"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.18196127),
        dec: Angle.Degrees(-22.41415491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105881",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14971 A"},
        {"Henry Draper", "HD 204075"},
        {"Hipparcos Number", "HIP 105881"},
        {"Fundamental Katalog 5th Edition", "FK5 806"},
        {"Geneva Identification System", "GEN# +1.00204075"},
        {"Smithsonian Astrophysical Observation", "SAO 190341"},
        {"Wilson Evans Batten Catalogue", "WEB 19202"},
    },
    visualMagnitude: 3.77,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.66678212),
        dec: Angle.Degrees(-22.41137838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91826",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11595 A"},
        {"Henry Draper", "HD 172854"},
        {"Hipparcos Number", "HIP 91826"},
        {"Geneva Identification System", "GEN# +1.00172854"},
        {"Renson", "Renson 48470"},
        {"Smithsonian Astrophysical Observation", "SAO 187185"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.83436442),
        dec: Angle.Degrees(-22.41080291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129908"},
        {"Hipparcos Number", "HIP 72172"},
        {"Smithsonian Astrophysical Observation", "SAO 182852"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.43467965),
        dec: Angle.Degrees(-22.41040725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62171"},
        {"Hipparcos Number", "HIP 37495"},
        {"Smithsonian Astrophysical Observation", "SAO 174310"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44040298),
        dec: Angle.Degrees(-22.40420798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133603"},
        {"Hipparcos Number", "HIP 73884"},
        {"Smithsonian Astrophysical Observation", "SAO 183168"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.51304907),
        dec: Angle.Degrees(-22.40395769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72247"},
        {"Smithsonian Astrophysical Observation", "SAO 182861"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61693596),
        dec: Angle.Degrees(-22.40393483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75220"},
        {"Hipparcos Number", "HIP 43202"},
        {"Smithsonian Astrophysical Observation", "SAO 176489"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.01720276),
        dec: Angle.Degrees(-22.40310829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41878"},
        {"Hipparcos Number", "HIP 28960"},
        {"Smithsonian Astrophysical Observation", "SAO 171244"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.67854969),
        dec: Angle.Degrees(-22.40296369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181240"},
        {"Hipparcos Number", "HIP 95077"},
        {"Geneva Identification System", "GEN# +1.00181240"},
        {"Renson", "Renson 50234"},
        {"Smithsonian Astrophysical Observation", "SAO 187992"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.15898277),
        dec: Angle.Degrees(-22.40260314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132234B"},
        {"Hipparcos Number", "HIP 73289"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.67353658),
        dec: Angle.Degrees(-22.40170360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132234"},
        {"Hipparcos Number", "HIP 73287"},
        {"Geneva Identification System", "GEN# +1.00132234"},
        {"Smithsonian Astrophysical Observation", "SAO 183060"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.66996655),
        dec: Angle.Degrees(-22.40141422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117083"},
        {"Hipparcos Number", "HIP 65700"},
        {"Geneva Identification System", "GEN# +1.00117083"},
        {"Smithsonian Astrophysical Observation", "SAO 181678"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.05695459),
        dec: Angle.Degrees(-22.40038589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135534"},
        {"Hipparcos Number", "HIP 74732"},
        {"Fundamental Katalog 5th Edition", "FK5 3206"},
        {"Geneva Identification System", "GEN# +1.00135534"},
        {"Smithsonian Astrophysical Observation", "SAO 183328"},
        {"Wilson Evans Batten Catalogue", "WEB 12748"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.09596946),
        dec: Angle.Degrees(-22.39942083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32062"},
        {"Hipparcos Number", "HIP 23207"},
        {"Geneva Identification System", "GEN# +1.00032062"},
        {"Smithsonian Astrophysical Observation", "SAO 169949"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.90787264),
        dec: Angle.Degrees(-22.39914613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68797"},
        {"Hipparcos Number", "HIP 40248"},
        {"Smithsonian Astrophysical Observation", "SAO 175399"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.30591417),
        dec: Angle.Degrees(-22.39753972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99799"},
        {"Hipparcos Number", "HIP 56016"},
        {"Geneva Identification System", "GEN# +1.00099799"},
        {"Smithsonian Astrophysical Observation", "SAO 179921"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.20418528),
        dec: Angle.Degrees(-22.39567523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11009"},
        {"Hipparcos Number", "HIP 8348"},
        {"Smithsonian Astrophysical Observation", "SAO 167299"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91451729),
        dec: Angle.Degrees(-22.39279891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92111",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11652 A"},
        {"Henry Draper", "HD 173460"},
        {"Hipparcos Number", "HIP 92111"},
        {"Geneva Identification System", "GEN# +1.00173460"},
        {"Smithsonian Astrophysical Observation", "SAO 187255"},
        {"Wilson Evans Batten Catalogue", "WEB 15875"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.58578518),
        dec: Angle.Degrees(-22.39218449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106452"},
        {"Hipparcos Number", "HIP 59711"},
        {"Smithsonian Astrophysical Observation", "SAO 180599"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.69837710),
        dec: Angle.Degrees(-22.39206222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195006"},
        {"Hipparcos Number", "HIP 101090"},
        {"Fundamental Katalog 5th Edition", "FK5 3639"},
        {"Geneva Identification System", "GEN# +1.00195006"},
        {"Smithsonian Astrophysical Observation", "SAO 189345"},
        {"Wilson Evans Batten Catalogue", "WEB 18256"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.38056519),
        dec: Angle.Degrees(-22.39149166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111430"},
        {"Hipparcos Number", "HIP 62582"},
        {"Smithsonian Astrophysical Observation", "SAO 181130"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.35313812),
        dec: Angle.Degrees(-22.39139610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1569"},
        {"Hipparcos Number", "HIP 1585"},
        {"Smithsonian Astrophysical Observation", "SAO 166191"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.95901473),
        dec: Angle.Degrees(-22.39128516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127874"},
        {"Hipparcos Number", "HIP 71263"},
        {"Geneva Identification System", "GEN# +1.00127874"},
        {"Smithsonian Astrophysical Observation", "SAO 182669"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.61131801),
        dec: Angle.Degrees(-22.39105248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108351"},
        {"Hipparcos Number", "HIP 60753"},
        {"Geneva Identification System", "GEN# +1.00108351"},
        {"Smithsonian Astrophysical Observation", "SAO 180806"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.76082858),
        dec: Angle.Degrees(-22.38971007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203100"},
        {"Hipparcos Number", "HIP 105379"},
        {"Geneva Identification System", "GEN# +1.00203100"},
        {"Smithsonian Astrophysical Observation", "SAO 190248"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.17472052),
        dec: Angle.Degrees(-22.38684138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58145"},
        {"Geneva Identification System", "GEN# -0.02103420"},
        {"Smithsonian Astrophysical Observation", "SAO 180300"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86898727),
        dec: Angle.Degrees(-22.38654728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74298"},
        {"Hipparcos Number", "HIP 42737"},
        {"Geneva Identification System", "GEN# +1.00074298"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.64011168),
        dec: Angle.Degrees(-22.38617090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29823"},
        {"Hipparcos Number", "HIP 21803"},
        {"Smithsonian Astrophysical Observation", "SAO 169664"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.26153190),
        dec: Angle.Degrees(-22.38463090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187592"},
        {"Hipparcos Number", "HIP 97718"},
        {"Smithsonian Astrophysical Observation", "SAO 188638"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.87905241),
        dec: Angle.Degrees(-22.38420539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163799"},
        {"Hipparcos Number", "HIP 88039"},
        {"Geneva Identification System", "GEN# +1.00163799"},
        {"Smithsonian Astrophysical Observation", "SAO 186036"},
        {"Wilson Evans Batten Catalogue", "WEB 14869"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.73323324),
        dec: Angle.Degrees(-22.38399743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7746"},
        {"Smithsonian Astrophysical Observation", "SAO 167204"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.92816941),
        dec: Angle.Degrees(-22.38344606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115985"},
        {"Hipparcos Number", "HIP 65149"},
        {"Geneva Identification System", "GEN# +1.00115985"},
        {"Smithsonian Astrophysical Observation", "SAO 181576"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.26341990),
        dec: Angle.Degrees(-22.38299851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185863"},
        {"Hipparcos Number", "HIP 96913"},
        {"Smithsonian Astrophysical Observation", "SAO 188463"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.50341214),
        dec: Angle.Degrees(-22.38106972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24625"},
        {"Hipparcos Number", "HIP 18248"},
        {"Smithsonian Astrophysical Observation", "SAO 168931"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.53470912),
        dec: Angle.Degrees(-22.38059061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146029"},
        {"Hipparcos Number", "HIP 79621"},
        {"Geneva Identification System", "GEN# +1.00146029"},
        {"Smithsonian Astrophysical Observation", "SAO 184259"},
        {"Wilson Evans Batten Catalogue", "WEB 13477"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.72223187),
        dec: Angle.Degrees(-22.38025117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42916"},
        {"Hipparcos Number", "HIP 29471"},
        {"Smithsonian Astrophysical Observation", "SAO 171385"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.13526821),
        dec: Angle.Degrees(-22.38005501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71012"},
        {"Hipparcos Number", "HIP 41188"},
        {"Geneva Identification System", "GEN# +1.00071012"},
        {"Smithsonian Astrophysical Observation", "SAO 175756"},
        {"Wilson Evans Batten Catalogue", "WEB 7969"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.07528064),
        dec: Angle.Degrees(-22.37848178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77082"},
        {"Smithsonian Astrophysical Observation", "SAO 183747"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.08832312),
        dec: Angle.Degrees(-22.37819767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78218"},
        {"Hipparcos Number", "HIP 44692"},
        {"Smithsonian Astrophysical Observation", "SAO 176960"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.61390250),
        dec: Angle.Degrees(-22.37812124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178438"},
        {"Hipparcos Number", "HIP 94115"},
        {"Fundamental Katalog 5th Edition", "FK5 5686"},
        {"Smithsonian Astrophysical Observation", "SAO 187747"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.37851502),
        dec: Angle.Degrees(-22.37744739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18071"},
        {"Hipparcos Number", "HIP 13479"},
        {"Geneva Identification System", "GEN# +1.00018071"},
        {"Smithsonian Astrophysical Observation", "SAO 168121"},
        {"Wilson Evans Batten Catalogue", "WEB 2691"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39695392),
        dec: Angle.Degrees(-22.37612257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43762"},
        {"Hipparcos Number", "HIP 29851"},
        {"Geneva Identification System", "GEN# +1.00043762"},
        {"Smithsonian Astrophysical Observation", "SAO 171506"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.28303933),
        dec: Angle.Degrees(-22.37431205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38090"},
        {"Hipparcos Number", "HIP 26865"},
        {"Geneva Identification System", "GEN# +1.00038090"},
        {"Smithsonian Astrophysical Observation", "SAO 170715"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.55815990),
        dec: Angle.Degrees(-22.37373687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39717"},
        {"Hipparcos Number", "HIP 27833"},
        {"Celescope Catalog", "CEL 1022"},
        {"Smithsonian Astrophysical Observation", "SAO 170970"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.33907961),
        dec: Angle.Degrees(-22.37146952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114363"},
        {"Hipparcos Number", "HIP 64279"},
        {"Smithsonian Astrophysical Observation", "SAO 181428"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.60436023),
        dec: Angle.Degrees(-22.37146766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104819"},
        {"Hipparcos Number", "HIP 58849"},
        {"Smithsonian Astrophysical Observation", "SAO 180425"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.04604354),
        dec: Angle.Degrees(-22.37101002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32887"},
        {"Hipparcos Number", "HIP 23685"},
        {"Fundamental Katalog 5th Edition", "FK5 186"},
        {"Geneva Identification System", "GEN# +1.00032887"},
        {"Smithsonian Astrophysical Observation", "SAO 170051"},
        {"Wilson Evans Batten Catalogue", "WEB 4620"},
    },
    visualMagnitude: 3.19,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.36521705),
        dec: Angle.Degrees(-22.37085673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160768"},
        {"Hipparcos Number", "HIP 86684"},
        {"Smithsonian Astrophysical Observation", "SAO 185644"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.66885833),
        dec: Angle.Degrees(-22.36955383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216664"},
        {"Hipparcos Number", "HIP 113159"},
        {"Geneva Identification System", "GEN# +1.00216664"},
        {"Smithsonian Astrophysical Observation", "SAO 191488"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.72809565),
        dec: Angle.Degrees(-22.36845929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119398"},
        {"Hipparcos Number", "HIP 66952"},
        {"Smithsonian Astrophysical Observation", "SAO 181902"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.83640138),
        dec: Angle.Degrees(-22.36711818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17837"},
        {"Hipparcos Number", "HIP 13301"},
        {"Smithsonian Astrophysical Observation", "SAO 168098"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.79820336),
        dec: Angle.Degrees(-22.36676270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64418"},
        {"Hipparcos Number", "HIP 38498"},
        {"Smithsonian Astrophysical Observation", "SAO 174725"},
        {"Wilson Evans Batten Catalogue", "WEB 7567"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.26461345),
        dec: Angle.Degrees(-22.36512684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8906 AB"},
        {"Henry Draper", "HD 116898"},
        {"Hipparcos Number", "HIP 65607"},
        {"Geneva Identification System", "GEN# +1.00116898"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.78279172),
        dec: Angle.Degrees(-22.36503327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86685"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.67019049),
        dec: Angle.Degrees(-22.36381130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58306"},
        {"Hipparcos Number", "HIP 35912"},
        {"Smithsonian Astrophysical Observation", "SAO 173649"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.05140386),
        dec: Angle.Degrees(-22.36251201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114917"},
        {"Hipparcos Number", "HIP 64562"},
        {"Geneva Identification System", "GEN# +1.00114917"},
        {"Smithsonian Astrophysical Observation", "SAO 181471"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.50619189),
        dec: Angle.Degrees(-22.36234984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3822"},
        {"Smithsonian Astrophysical Observation", "SAO 166600"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.26895883),
        dec: Angle.Degrees(-22.36086232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48424"},
        {"Hipparcos Number", "HIP 32101"},
        {"Smithsonian Astrophysical Observation", "SAO 172191"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.59689441),
        dec: Angle.Degrees(-22.36067260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75739"},
        {"Hipparcos Number", "HIP 43458"},
        {"Smithsonian Astrophysical Observation", "SAO 176576"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.76808579),
        dec: Angle.Degrees(-22.35788873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10372"},
        {"Smithsonian Astrophysical Observation", "SAO 167646"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.41372255),
        dec: Angle.Degrees(-22.35772673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5446"},
        {"Smithsonian Astrophysical Observation", "SAO 166843"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.43164448),
        dec: Angle.Degrees(-22.35012757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63416"},
        {"Hipparcos Number", "HIP 38067"},
        {"Geneva Identification System", "GEN# +1.00063416"},
        {"Smithsonian Astrophysical Observation", "SAO 174556"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.02009779),
        dec: Angle.Degrees(-22.34831895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93528"},
        {"Hipparcos Number", "HIP 52787"},
        {"Smithsonian Astrophysical Observation", "SAO 179229"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.88013635),
        dec: Angle.Degrees(-22.34796385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122055"},
        {"Hipparcos Number", "HIP 68383"},
        {"Smithsonian Astrophysical Observation", "SAO 182151"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.97261214),
        dec: Angle.Degrees(-22.34478059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150634"},
        {"Hipparcos Number", "HIP 81860"},
        {"Smithsonian Astrophysical Observation", "SAO 184573"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.79020682),
        dec: Angle.Degrees(-22.34465179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81799"},
        {"Hipparcos Number", "HIP 46371"},
        {"Geneva Identification System", "GEN# +1.00081799"},
        {"Smithsonian Astrophysical Observation", "SAO 177469"},
        {"Wilson Evans Batten Catalogue", "WEB 8765"},
    },
    visualMagnitude: 4.72,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.82623904),
        dec: Angle.Degrees(-22.34341760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136459"},
        {"Hipparcos Number", "HIP 75159"},
        {"Smithsonian Astrophysical Observation", "SAO 183403"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.39158037),
        dec: Angle.Degrees(-22.34337746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68910"},
        {"Hipparcos Number", "HIP 40295"},
        {"Smithsonian Astrophysical Observation", "SAO 175413"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.43063296),
        dec: Angle.Degrees(-22.34090232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56955"},
        {"Hipparcos Number", "HIP 35358"},
        {"Smithsonian Astrophysical Observation", "SAO 173421"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.55116580),
        dec: Angle.Degrees(-22.33933352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8896"},
        {"Hipparcos Number", "HIP 6789"},
        {"Smithsonian Astrophysical Observation", "SAO 167055"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.84712814),
        dec: Angle.Degrees(-22.33802701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3507"},
        {"Hipparcos Number", "HIP 2987"},
        {"Geneva Identification System", "GEN# +1.00003507"},
        {"Smithsonian Astrophysical Observation", "SAO 166424"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.49149874),
        dec: Angle.Degrees(-22.33767623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66097"},
        {"Hipparcos Number", "HIP 39217"},
        {"Smithsonian Astrophysical Observation", "SAO 174989"},
    },
    visualMagnitude: 7.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.32737917),
        dec: Angle.Degrees(-22.33696055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16354"},
        {"Smithsonian Astrophysical Observation", "SAO 168597"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.67820339),
        dec: Angle.Degrees(-22.32159882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62082"},
        {"Hipparcos Number", "HIP 37465"},
        {"Geneva Identification System", "GEN# +1.00062082"},
        {"Smithsonian Astrophysical Observation", "SAO 174298"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.34802203),
        dec: Angle.Degrees(-22.33675243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201058"},
        {"Hipparcos Number", "HIP 104317"},
        {"Geneva Identification System", "GEN# +1.00201058"},
        {"Smithsonian Astrophysical Observation", "SAO 190040"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.98318792),
        dec: Angle.Degrees(-22.33525167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6524 C"},
        {"Hipparcos Number", "HIP 39222"},
        {"Smithsonian Astrophysical Observation", "SAO 174995"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.33952035),
        dec: Angle.Degrees(-22.33298911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17048"},
    },
    visualMagnitude: 11.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.82116257),
        dec: Angle.Degrees(-22.32978102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50826"},
        {"Hipparcos Number", "HIP 33130"},
        {"Smithsonian Astrophysical Observation", "SAO 172530"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48469221),
        dec: Angle.Degrees(-22.32862606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9328 AB"},
        {"Henry Draper", "HD 128687"},
        {"Hipparcos Number", "HIP 71621"},
        {"Smithsonian Astrophysical Observation", "SAO 182731"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.72761916),
        dec: Angle.Degrees(-22.32833728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72625"},
        {"Hipparcos Number", "HIP 41957"},
        {"Smithsonian Astrophysical Observation", "SAO 176063"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.29040096),
        dec: Angle.Degrees(-22.32787250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107389"},
        {"Hipparcos Number", "HIP 60209"},
        {"Smithsonian Astrophysical Observation", "SAO 180704"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.20311045),
        dec: Angle.Degrees(-22.32772040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224962"},
        {"Hipparcos Number", "HIP 165"},
        {"Renson", "Renson 61687"},
        {"Smithsonian Astrophysical Observation", "SAO 192330"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.51974463),
        dec: Angle.Degrees(-22.32747055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76726"},
        {"Smithsonian Astrophysical Observation", "SAO 183682"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.02361177),
        dec: Angle.Degrees(-22.32548440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87980"},
        {"Hipparcos Number", "HIP 49654"},
        {"Smithsonian Astrophysical Observation", "SAO 178453"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.05733183),
        dec: Angle.Degrees(-22.32275362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22822"},
        {"Hipparcos Number", "HIP 17046"},
        {"Geneva Identification System", "GEN# +1.00022822"},
        {"Smithsonian Astrophysical Observation", "SAO 168708"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.81469287),
        dec: Angle.Degrees(-22.32240945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21948",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3405 AB"},
        {"Henry Draper", "HD 30022"},
        {"Hipparcos Number", "HIP 21948"},
        {"Smithsonian Astrophysical Observation", "SAO 169690"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.76614933),
        dec: Angle.Degrees(-22.32228141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84232"},
        {"Hipparcos Number", "HIP 47668"},
        {"Geneva Identification System", "GEN# +1.00084232"},
        {"Smithsonian Astrophysical Observation", "SAO 177889"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.80237399),
        dec: Angle.Degrees(-22.32202608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46131"},
        {"Hipparcos Number", "HIP 31028"},
        {"Smithsonian Astrophysical Observation", "SAO 171861"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.66051695),
        dec: Angle.Degrees(-22.32181557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86539"},
        {"Hipparcos Number", "HIP 48912"},
        {"Smithsonian Astrophysical Observation", "SAO 178260"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.66768359),
        dec: Angle.Degrees(-22.32155195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155309"},
        {"Hipparcos Number", "HIP 84101"},
        {"Smithsonian Astrophysical Observation", "SAO 185128"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.89805640),
        dec: Angle.Degrees(-22.32149197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31023"},
        {"Hipparcos Number", "HIP 22581"},
        {"Smithsonian Astrophysical Observation", "SAO 169821"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.88978333),
        dec: Angle.Degrees(-22.32116573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196998"},
        {"Hipparcos Number", "HIP 102119"},
        {"Geneva Identification System", "GEN# +1.00196998"},
        {"Smithsonian Astrophysical Observation", "SAO 189584"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.42430115),
        dec: Angle.Degrees(-22.32105628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 659.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -535.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8523"},
        {"Smithsonian Astrophysical Observation", "SAO 167331"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.48254499),
        dec: Angle.Degrees(-22.32038071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27195"},
        {"Hipparcos Number", "HIP 19982"},
        {"Smithsonian Astrophysical Observation", "SAO 169301"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.27943460),
        dec: Angle.Degrees(-22.31820733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58082"},
        {"Hipparcos Number", "HIP 35817"},
        {"Smithsonian Astrophysical Observation", "SAO 173601"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.80197324),
        dec: Angle.Degrees(-22.31469357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160626"},
        {"Hipparcos Number", "HIP 86618"},
        {"Smithsonian Astrophysical Observation", "SAO 185628"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49091867),
        dec: Angle.Degrees(-22.31339630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18386"},
        {"Hipparcos Number", "HIP 13718"},
        {"Smithsonian Astrophysical Observation", "SAO 168166"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.15744552),
        dec: Angle.Degrees(-22.31031955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25218",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3993 A"},
        {"Henry Draper", "HD 35430"},
        {"Hipparcos Number", "HIP 25218"},
        {"Smithsonian Astrophysical Observation", "SAO 170383"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90897836),
        dec: Angle.Degrees(-22.30802410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3993 B"},
        {"Hipparcos Number", "HIP 25212"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90391539),
        dec: Angle.Degrees(-22.30684447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50352"},
        {"Hipparcos Number", "HIP 32961"},
        {"Geneva Identification System", "GEN# +1.00050352"},
        {"Smithsonian Astrophysical Observation", "SAO 172460"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.97977471),
        dec: Angle.Degrees(-22.30359275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160442"},
        {"Hipparcos Number", "HIP 86517"},
        {"Smithsonian Astrophysical Observation", "SAO 185613"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.20936687),
        dec: Angle.Degrees(-22.30306965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15540"},
        {"Hipparcos Number", "HIP 11594"},
        {"Smithsonian Astrophysical Observation", "SAO 167827"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.35888388),
        dec: Angle.Degrees(-22.30294915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60368"},
        {"Hipparcos Number", "HIP 36731"},
        {"Geneva Identification System", "GEN# +1.00060368"},
        {"Smithsonian Astrophysical Observation", "SAO 173988"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.31820013),
        dec: Angle.Degrees(-22.30091846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17621"},
    },
    visualMagnitude: 11.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.62585328),
        dec: Angle.Degrees(-22.30057678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 256.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96005"},
        {"Hipparcos Number", "HIP 54096"},
        {"Smithsonian Astrophysical Observation", "SAO 179494"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.04071703),
        dec: Angle.Degrees(-22.30035333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40267"},
        {"Hipparcos Number", "HIP 28132"},
        {"Smithsonian Astrophysical Observation", "SAO 171050"},
    },
    visualMagnitude: 9.85,
    bvColour: -0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.19595750),
        dec: Angle.Degrees(-22.29862464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211547"},
        {"Hipparcos Number", "HIP 110101"},
        {"Smithsonian Astrophysical Observation", "SAO 191033"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.54757297),
        dec: Angle.Degrees(-22.29862197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62469"},
        {"Hipparcos Number", "HIP 37632"},
        {"Geneva Identification System", "GEN# +1.00062469"},
        {"Smithsonian Astrophysical Observation", "SAO 174379"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.83406224),
        dec: Angle.Degrees(-22.29857518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116845"},
        {"Hipparcos Number", "HIP 65582"},
        {"Geneva Identification System", "GEN# +1.00116845"},
        {"Smithsonian Astrophysical Observation", "SAO 181659"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.68193709),
        dec: Angle.Degrees(-22.29820134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74708"},
        {"Hipparcos Number", "HIP 42918"},
        {"Smithsonian Astrophysical Observation", "SAO 176397"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.19491376),
        dec: Angle.Degrees(-22.29800651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7544"},
        {"Hipparcos Number", "HIP 5866"},
        {"Geneva Identification System", "GEN# +1.00007544"},
        {"Smithsonian Astrophysical Observation", "SAO 166905"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.80992087),
        dec: Angle.Degrees(-22.29674346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60532"},
        {"Hipparcos Number", "HIP 36795"},
        {"Fundamental Katalog 5th Edition", "FK5 288"},
        {"Geneva Identification System", "GEN# +1.00060532"},
        {"Smithsonian Astrophysical Observation", "SAO 174009"},
        {"Wilson Evans Batten Catalogue", "WEB 7312"},
    },
    visualMagnitude: 4.44,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.51335813),
        dec: Angle.Degrees(-22.29618077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60921"},
        {"Hipparcos Number", "HIP 36979"},
        {"Geneva Identification System", "GEN# +1.00060921J"},
        {"Smithsonian Astrophysical Observation", "SAO 174087"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.01076422),
        dec: Angle.Degrees(-22.29362398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173570"},
        {"Hipparcos Number", "HIP 92154"},
        {"Smithsonian Astrophysical Observation", "SAO 187272"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.74085541),
        dec: Angle.Degrees(-22.29318054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4943"},
        {"Smithsonian Astrophysical Observation", "SAO 166775"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.85560225),
        dec: Angle.Degrees(-22.29060610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52776"},
        {"Geneva Identification System", "GEN# -0.02103153"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.85611121),
        dec: Angle.Degrees(-22.28664288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9465"},
        {"Smithsonian Astrophysical Observation", "SAO 167501"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.45552436),
        dec: Angle.Degrees(-22.28661108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60282"},
        {"Hipparcos Number", "HIP 36700"},
        {"Geneva Identification System", "GEN# +1.00060282"},
        {"Smithsonian Astrophysical Observation", "SAO 173979"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.23905794),
        dec: Angle.Degrees(-22.28636786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65828"},
        {"Hipparcos Number", "HIP 39100"},
        {"Smithsonian Astrophysical Observation", "SAO 174953"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.97983938),
        dec: Angle.Degrees(-22.28525293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79662"},
        {"Hipparcos Number", "HIP 45375"},
        {"Smithsonian Astrophysical Observation", "SAO 177165"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.71232693),
        dec: Angle.Degrees(-22.27976831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29369"},
        {"Hipparcos Number", "HIP 21472"},
        {"Smithsonian Astrophysical Observation", "SAO 169607"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.16797457),
        dec: Angle.Degrees(-22.27970420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24472"},
        {"Hipparcos Number", "HIP 18153"},
        {"Geneva Identification System", "GEN# +1.00024472"},
        {"Smithsonian Astrophysical Observation", "SAO 168913"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.20733752),
        dec: Angle.Degrees(-22.27636502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25385"},
        {"Hipparcos Number", "HIP 18766"},
        {"Geneva Identification System", "GEN# +1.00025385"},
        {"Smithsonian Astrophysical Observation", "SAO 169036"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.30067869),
        dec: Angle.Degrees(-22.27592715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17000 AB"},
        {"Henry Draper", "HD 223182"},
        {"Hipparcos Number", "HIP 117328"},
        {"Smithsonian Astrophysical Observation", "SAO 192152"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.85718721),
        dec: Angle.Degrees(-22.27532850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6131"},
        {"Smithsonian Astrophysical Observation", "SAO 166949"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.67377458),
        dec: Angle.Degrees(-22.27332758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10059"},
        {"Smithsonian Astrophysical Observation", "SAO 167597"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.37281989),
        dec: Angle.Degrees(-22.26930335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184777"},
        {"Hipparcos Number", "HIP 96474"},
        {"Smithsonian Astrophysical Observation", "SAO 188342"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.20411256),
        dec: Angle.Degrees(-22.26837867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126849"},
        {"Hipparcos Number", "HIP 70790"},
        {"Geneva Identification System", "GEN# +1.00126849"},
        {"Smithsonian Astrophysical Observation", "SAO 182579"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.14793590),
        dec: Angle.Degrees(-22.26821135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40150"},
        {"Hipparcos Number", "HIP 28083"},
        {"Smithsonian Astrophysical Observation", "SAO 171032"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.05019692),
        dec: Angle.Degrees(-22.26734553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174287"},
        {"Hipparcos Number", "HIP 92469"},
        {"Smithsonian Astrophysical Observation", "SAO 187339"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.66717985),
        dec: Angle.Degrees(-22.26640624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 855"},
        {"Hipparcos Number", "HIP 1032"},
        {"Smithsonian Astrophysical Observation", "SAO 166116"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.22251341),
        dec: Angle.Degrees(-22.26429777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210880"},
        {"Hipparcos Number", "HIP 109753"},
        {"Geneva Identification System", "GEN# +1.00210880"},
        {"Smithsonian Astrophysical Observation", "SAO 190980"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.46894992),
        dec: Angle.Degrees(-22.26427402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3540"},
        {"Hipparcos Number", "HIP 3003"},
        {"Smithsonian Astrophysical Observation", "SAO 166433"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.54904725),
        dec: Angle.Degrees(-22.26383444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38466"},
        {"Hipparcos Number", "HIP 27127"},
        {"Smithsonian Astrophysical Observation", "SAO 170778"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.28785976),
        dec: Angle.Degrees(-22.26276216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22436"},
        {"Geneva Identification System", "GEN# -0.02200926"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42427217),
        dec: Angle.Degrees(-22.25994886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105376"},
        {"Hipparcos Number", "HIP 59171"},
        {"Renson", "Renson 30457"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.01325357),
        dec: Angle.Degrees(-22.25873079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212407"},
        {"Hipparcos Number", "HIP 110598"},
        {"Smithsonian Astrophysical Observation", "SAO 191116"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.09050738),
        dec: Angle.Degrees(-22.25761906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29336"},
        {"Hipparcos Number", "HIP 21448"},
        {"Geneva Identification System", "GEN# +1.00029336"},
        {"Smithsonian Astrophysical Observation", "SAO 169604"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.09166556),
        dec: Angle.Degrees(-22.25586428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72991"},
        {"Hipparcos Number", "HIP 42114"},
        {"Smithsonian Astrophysical Observation", "SAO 176121"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.77258078),
        dec: Angle.Degrees(-22.25486214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88168"},
        {"Hipparcos Number", "HIP 49776"},
        {"Smithsonian Astrophysical Observation", "SAO 178480"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.41253603),
        dec: Angle.Degrees(-22.25306299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90846"},
        {"Hipparcos Number", "HIP 51326"},
        {"Smithsonian Astrophysical Observation", "SAO 178876"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.25906134),
        dec: Angle.Degrees(-22.25303379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188977"},
        {"Hipparcos Number", "HIP 98318"},
        {"Smithsonian Astrophysical Observation", "SAO 188772"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.64109854),
        dec: Angle.Degrees(-22.25186384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90955"},
        {"Hipparcos Number", "HIP 51381"},
        {"Smithsonian Astrophysical Observation", "SAO 178890"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.41185230),
        dec: Angle.Degrees(-22.24698156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209587"},
        {"Hipparcos Number", "HIP 109000"},
        {"Smithsonian Astrophysical Observation", "SAO 190872"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.22523231),
        dec: Angle.Degrees(-22.24489559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67908",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9050 AB"},
        {"Henry Draper", "HD 121223"},
        {"Hipparcos Number", "HIP 67908"},
        {"Smithsonian Astrophysical Observation", "SAO 182070"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.63200137),
        dec: Angle.Degrees(-22.24482570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126587"},
        {"Hipparcos Number", "HIP 70647"},
        {"Geneva Identification System", "GEN# +1.00126587"},
        {"Smithsonian Astrophysical Observation", "SAO 182556"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.75155433),
        dec: Angle.Degrees(-22.24403542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223546"},
        {"Hipparcos Number", "HIP 117556"},
        {"Smithsonian Astrophysical Observation", "SAO 192192"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.60864519),
        dec: Angle.Degrees(-22.24299847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4397"},
        {"Hipparcos Number", "HIP 3606"},
        {"Geneva Identification System", "GEN# +1.00004397"},
        {"Smithsonian Astrophysical Observation", "SAO 166554"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.54605612),
        dec: Angle.Degrees(-22.24147318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209925"},
        {"Hipparcos Number", "HIP 109199"},
        {"Fundamental Katalog 5th Edition", "FK5 5953"},
        {"Geneva Identification System", "GEN# +1.00209925"},
        {"Smithsonian Astrophysical Observation", "SAO 190898"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.81291070),
        dec: Angle.Degrees(-22.24071252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166263"},
        {"Hipparcos Number", "HIP 89071"},
        {"Geneva Identification System", "GEN# +1.00166263"},
        {"Smithsonian Astrophysical Observation", "SAO 186410"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.68393766),
        dec: Angle.Degrees(-22.23970557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156847"},
        {"Hipparcos Number", "HIP 84869"},
        {"Smithsonian Astrophysical Observation", "SAO 185290"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.18478207),
        dec: Angle.Degrees(-22.23899761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168731"},
        {"Hipparcos Number", "HIP 90029"},
        {"Smithsonian Astrophysical Observation", "SAO 186721"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.54221230),
        dec: Angle.Degrees(-22.23882005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102168"},
        {"Hipparcos Number", "HIP 57343"},
        {"Smithsonian Astrophysical Observation", "SAO 180162"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.35980820),
        dec: Angle.Degrees(-22.23513392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217894"},
        {"Hipparcos Number", "HIP 113920"},
        {"Smithsonian Astrophysical Observation", "SAO 191622"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.04772350),
        dec: Angle.Degrees(-22.23463468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163574"},
        {"Hipparcos Number", "HIP 87929"},
        {"Smithsonian Astrophysical Observation", "SAO 186001"},
    },
    visualMagnitude: 8.97,
    bvColour: 2.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.43291526),
        dec: Angle.Degrees(-22.23370165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101443",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13988 A"},
        {"Henry Draper", "HD 195680"},
        {"Henry Draper 2", "HD 195680A"},
        {"Hipparcos Number", "HIP 101443"},
        {"Geneva Identification System", "GEN# +1.00195680"},
        {"Smithsonian Astrophysical Observation", "SAO 189425"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.37915641),
        dec: Angle.Degrees(-22.23172205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145208"},
        {"Hipparcos Number", "HIP 79252"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.62035894),
        dec: Angle.Degrees(-22.22988575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18500"},
        {"Hipparcos Number", "HIP 13805"},
        {"Smithsonian Astrophysical Observation", "SAO 168187"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44256363),
        dec: Angle.Degrees(-22.22731635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67292"},
        {"Hipparcos Number", "HIP 39671"},
        {"Smithsonian Astrophysical Observation", "SAO 175176"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.60279704),
        dec: Angle.Degrees(-22.22692311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36618"},
        {"Hipparcos Number", "HIP 25932"},
        {"Smithsonian Astrophysical Observation", "SAO 170521"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.01906234),
        dec: Angle.Degrees(-22.22687277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98493"},
        {"Hipparcos Number", "HIP 55313"},
        {"Smithsonian Astrophysical Observation", "SAO 179770"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.91752894),
        dec: Angle.Degrees(-22.22580268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64358"},
        {"Hipparcos Number", "HIP 38464"},
        {"Smithsonian Astrophysical Observation", "SAO 174714"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.18739789),
        dec: Angle.Degrees(-22.22407313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165674"},
        {"Hipparcos Number", "HIP 88838"},
        {"Geneva Identification System", "GEN# +1.00165674"},
    },
    visualMagnitude: 8.82,
    bvColour: 2.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.01685924),
        dec: Angle.Degrees(-22.22404833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11038"},
        {"Hipparcos Number", "HIP 8383"},
        {"Geneva Identification System", "GEN# +1.00011038"},
        {"Smithsonian Astrophysical Observation", "SAO 167305"},
        {"Wilson Evans Batten Catalogue", "WEB 1783"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.01843844),
        dec: Angle.Degrees(-22.22345167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218280"},
        {"Hipparcos Number", "HIP 114146"},
        {"Smithsonian Astrophysical Observation", "SAO 191661"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.75530921),
        dec: Angle.Degrees(-22.22043565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43307"},
        {"Hipparcos Number", "HIP 29625"},
        {"Smithsonian Astrophysical Observation", "SAO 171442"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.64592730),
        dec: Angle.Degrees(-22.21996883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142704"},
        {"Hipparcos Number", "HIP 78103"},
        {"Smithsonian Astrophysical Observation", "SAO 183960"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.21329639),
        dec: Angle.Degrees(-22.21993651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52399"},
        {"Smithsonian Astrophysical Observation", "SAO 179141"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.65408519),
        dec: Angle.Degrees(-22.21894395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8517 A"},
        {"Henry Draper", "HD 107348"},
        {"Hipparcos Number", "HIP 60189"},
        {"Geneva Identification System", "GEN# +1.00107348J"},
        {"Smithsonian Astrophysical Observation", "SAO 180700"},
        {"Wilson Evans Batten Catalogue", "WEB 10702"},
    },
    visualMagnitude: 5.20,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.14046113),
        dec: Angle.Degrees(-22.21583387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44573"},
        {"Hipparcos Number", "HIP 30225"},
        {"Geneva Identification System", "GEN# +1.00044573"},
        {"Smithsonian Astrophysical Observation", "SAO 171620"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.38795855),
        dec: Angle.Degrees(-22.21417190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -240.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48205"},
        {"Hipparcos Number", "HIP 32018"},
        {"Smithsonian Astrophysical Observation", "SAO 172163"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.33604621),
        dec: Angle.Degrees(-22.21384842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202025"},
        {"Hipparcos Number", "HIP 104810"},
        {"Smithsonian Astrophysical Observation", "SAO 190147"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.50734787),
        dec: Angle.Degrees(-22.21208960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189193"},
        {"Hipparcos Number", "HIP 98399"},
        {"Smithsonian Astrophysical Observation", "SAO 188795"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.89185877),
        dec: Angle.Degrees(-22.21129829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66396"},
        {"Hipparcos Number", "HIP 39331"},
        {"Geneva Identification System", "GEN# +1.00066396"},
        {"Smithsonian Astrophysical Observation", "SAO 175038"},
        {"Wilson Evans Batten Catalogue", "WEB 7701"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61359306),
        dec: Angle.Degrees(-22.20880546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210521"},
        {"Hipparcos Number", "HIP 109544"},
        {"Geneva Identification System", "GEN# +1.00210521"},
        {"Smithsonian Astrophysical Observation", "SAO 190952"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84336969),
        dec: Angle.Degrees(-22.20866674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151855"},
        {"Hipparcos Number", "HIP 82439"},
        {"Smithsonian Astrophysical Observation", "SAO 184704"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.72014014),
        dec: Angle.Degrees(-22.20575092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5185"},
        {"Hipparcos Number", "HIP 4194"},
        {"Geneva Identification System", "GEN# +1.00005185"},
        {"Smithsonian Astrophysical Observation", "SAO 166654"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.39519100),
        dec: Angle.Degrees(-22.20333385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91660"},
        {"Hipparcos Number", "HIP 51768"},
        {"Smithsonian Astrophysical Observation", "SAO 178990"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.67506425),
        dec: Angle.Degrees(-22.20328755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51630"},
        {"Hipparcos Number", "HIP 33447"},
        {"Celescope Catalog", "CEL 1454"},
        {"Geneva Identification System", "GEN# +5.11210038"},
        {"Smithsonian Astrophysical Observation", "SAO 172629"},
        {"Smithsonian Astrophysical Observation 2", "SAO 172631"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.31153292),
        dec: Angle.Degrees(-22.20287436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176551"},
        {"Hipparcos Number", "HIP 93428"},
        {"Smithsonian Astrophysical Observation", "SAO 187585"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.41774954),
        dec: Angle.Degrees(-22.19901125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34831"},
        {"Celescope Catalog", "CEL 1672"},
    },
    visualMagnitude: 9.71,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.13138039),
        dec: Angle.Degrees(-22.06527247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161083"},
        {"Hipparcos Number", "HIP 86819"},
        {"Geneva Identification System", "GEN# +1.00161083"},
        {"Smithsonian Astrophysical Observation", "SAO 185678"},
        {"Wilson Evans Batten Catalogue", "WEB 14645"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.09985237),
        dec: Angle.Degrees(-22.19490506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74162"},
        {"Hipparcos Number", "HIP 42654"},
        {"Smithsonian Astrophysical Observation", "SAO 176314"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.39610135),
        dec: Angle.Degrees(-22.19434363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23955"},
        {"Hipparcos Number", "HIP 17777"},
        {"Smithsonian Astrophysical Observation", "SAO 168844"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.08695998),
        dec: Angle.Degrees(-22.19338292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4883 AB"},
        {"Henry Draper", "HD 43517"},
        {"Hipparcos Number", "HIP 29732"},
        {"Smithsonian Astrophysical Observation", "SAO 171469"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.92293165),
        dec: Angle.Degrees(-22.19223100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51228"},
        {"Hipparcos Number", "HIP 33305"},
        {"Smithsonian Astrophysical Observation", "SAO 172582"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.91343176),
        dec: Angle.Degrees(-22.19192214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114260"},
        {"Hipparcos Number", "HIP 64219"},
        {"Geneva Identification System", "GEN# +1.00114260"},
        {"Smithsonian Astrophysical Observation", "SAO 181420"},
        {"Wilson Evans Batten Catalogue", "WEB 11350"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.42690374),
        dec: Angle.Degrees(-22.19177270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -339.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190177"},
        {"Hipparcos Number", "HIP 98851"},
        {"Geneva Identification System", "GEN# +1.00190177"},
        {"Smithsonian Astrophysical Observation", "SAO 188878"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.10991961),
        dec: Angle.Degrees(-22.19097882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138124"},
        {"Hipparcos Number", "HIP 75951"},
        {"Renson", "Renson 39305"},
        {"Smithsonian Astrophysical Observation", "SAO 183535"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.68905172),
        dec: Angle.Degrees(-22.19030694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86595"},
        {"Hipparcos Number", "HIP 48937"},
        {"Geneva Identification System", "GEN# +1.00086595"},
        {"Smithsonian Astrophysical Observation", "SAO 178268"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.76741903),
        dec: Angle.Degrees(-22.18738042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8353 AB"},
        {"Henry Draper", "HD 103634"},
        {"Hipparcos Number", "HIP 58178"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.98005946),
        dec: Angle.Degrees(-22.18410643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165893"},
        {"Hipparcos Number", "HIP 88932"},
        {"Geneva Identification System", "GEN# +1.00165893J"},
        {"Smithsonian Astrophysical Observation", "SAO 186363"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.30073905),
        dec: Angle.Degrees(-22.18351254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168354"},
        {"Hipparcos Number", "HIP 89853"},
        {"Smithsonian Astrophysical Observation", "SAO 186668"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.04056664),
        dec: Angle.Degrees(-22.18184360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86931"},
    },
    visualMagnitude: 12.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.43698958),
        dec: Angle.Degrees(-22.18091602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 437"},
        {"Hipparcos Number", "HIP 720"},
        {"Fundamental Katalog 5th Edition", "FK5 4018"},
        {"Geneva Identification System", "GEN# +1.00000437"},
        {"Smithsonian Astrophysical Observation", "SAO 166077"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.22356284),
        dec: Angle.Degrees(-22.17950257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128189"},
        {"Hipparcos Number", "HIP 71407"},
        {"Geneva Identification System", "GEN# +1.00128189"},
        {"Smithsonian Astrophysical Observation", "SAO 182687"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.03224604),
        dec: Angle.Degrees(-22.17738473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8556"},
        {"Smithsonian Astrophysical Observation", "SAO 167341"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.59399213),
        dec: Angle.Degrees(-22.17706229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170300"},
        {"Hipparcos Number", "HIP 90631"},
        {"Smithsonian Astrophysical Observation", "SAO 186880"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39266186),
        dec: Angle.Degrees(-22.17706204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60157",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8515 AB"},
        {"Henry Draper", "HD 107295"},
        {"Hipparcos Number", "HIP 60157"},
        {"Geneva Identification System", "GEN# +1.00107295J"},
        {"Smithsonian Astrophysical Observation", "SAO 180695"},
        {"Wilson Evans Batten Catalogue", "WEB 10693"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.04514374),
        dec: Angle.Degrees(-22.17562676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41094"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74996203),
        dec: Angle.Degrees(-22.17532299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151310"},
        {"Hipparcos Number", "HIP 82191"},
        {"Geneva Identification System", "GEN# +1.00151310"},
        {"Smithsonian Astrophysical Observation", "SAO 184641"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.87394579),
        dec: Angle.Degrees(-22.17388745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112478"},
        {"Hipparcos Number", "HIP 63218"},
        {"Smithsonian Astrophysical Observation", "SAO 181259"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.29356558),
        dec: Angle.Degrees(-22.17184613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159088"},
        {"Hipparcos Number", "HIP 85925"},
        {"Smithsonian Astrophysical Observation", "SAO 185506"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.39409174),
        dec: Angle.Degrees(-22.17164736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109106"},
        {"Hipparcos Number", "HIP 61197"},
        {"Geneva Identification System", "GEN# +1.00109106"},
        {"Smithsonian Astrophysical Observation", "SAO 180876"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.10501119),
        dec: Angle.Degrees(-22.17107210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156060"},
        {"Hipparcos Number", "HIP 84486"},
        {"Smithsonian Astrophysical Observation", "SAO 185215"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.08064666),
        dec: Angle.Degrees(-22.17107090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167663"},
        {"Hipparcos Number", "HIP 89607"},
        {"Smithsonian Astrophysical Observation", "SAO 186591"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.29027746),
        dec: Angle.Degrees(-22.16990503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22922"},
        {"Hipparcos Number", "HIP 17123"},
        {"Renson", "Renson 5843"},
        {"Smithsonian Astrophysical Observation", "SAO 168722"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.00660736),
        dec: Angle.Degrees(-22.16975107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49484"},
        {"Hipparcos Number", "HIP 32570"},
        {"Smithsonian Astrophysical Observation", "SAO 172341"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.94633695),
        dec: Angle.Degrees(-22.16948280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143439"},
        {"Hipparcos Number", "HIP 78472"},
        {"Geneva Identification System", "GEN# +1.00143439"},
        {"Renson", "Renson 40613"},
        {"Smithsonian Astrophysical Observation", "SAO 184030"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.28383584),
        dec: Angle.Degrees(-22.16820136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62553"},
        {"Hipparcos Number", "HIP 37667"},
        {"Geneva Identification System", "GEN# +1.00062553"},
        {"Renson", "Renson 17170"},
        {"Smithsonian Astrophysical Observation", "SAO 174394"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.92964120),
        dec: Angle.Degrees(-22.16801012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11398"},
        {"Hipparcos Number", "HIP 8669"},
        {"Geneva Identification System", "GEN# +1.00011398"},
        {"Smithsonian Astrophysical Observation", "SAO 167353"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91151099),
        dec: Angle.Degrees(-22.16758412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17207"},
        {"Hipparcos Number", "HIP 12837"},
        {"Geneva Identification System", "GEN# +1.00017207"},
        {"Smithsonian Astrophysical Observation", "SAO 168021"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.25469579),
        dec: Angle.Degrees(-22.16629673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197784"},
        {"Hipparcos Number", "HIP 102512"},
        {"Smithsonian Astrophysical Observation", "SAO 189680"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.62553290),
        dec: Angle.Degrees(-22.16388415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11731 A"},
        {"Henry Draper", "HD 174309"},
        {"Hipparcos Number", "HIP 92480"},
        {"Fundamental Katalog 5th Edition", "FK5 1493"},
        {"Geneva Identification System", "GEN# +1.00174309"},
        {"Smithsonian Astrophysical Observation", "SAO 187342"},
        {"Wilson Evans Batten Catalogue", "WEB 15978"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.71042311),
        dec: Angle.Degrees(-22.16210451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195469"},
        {"Hipparcos Number", "HIP 101329"},
        {"Geneva Identification System", "GEN# +1.00195469"},
        {"Smithsonian Astrophysical Observation", "SAO 189405"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.06447540),
        dec: Angle.Degrees(-22.16176120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 313401"},
        {"Hipparcos Number", "HIP 87458"},
    },
    visualMagnitude: 8.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.05515940),
        dec: Angle.Degrees(-22.16121648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21371"},
        {"Hipparcos Number", "HIP 16006"},
        {"Geneva Identification System", "GEN# +1.00021371"},
        {"Smithsonian Astrophysical Observation", "SAO 168539"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.53183913),
        dec: Angle.Degrees(-22.16093679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165812"},
        {"Hipparcos Number", "HIP 88884"},
        {"Celescope Catalog", "CEL 4626"},
        {"Geneva Identification System", "GEN# +1.00165812"},
        {"Smithsonian Astrophysical Observation", "SAO 186348"},
        {"Wilson Evans Batten Catalogue", "WEB 15073"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.18714966),
        dec: Angle.Degrees(-22.16067552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96784"},
        {"Hipparcos Number", "HIP 54466"},
        {"Smithsonian Astrophysical Observation", "SAO 179573"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.15200348),
        dec: Angle.Degrees(-22.16047910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60951"},
        {"Hipparcos Number", "HIP 36986"},
        {"Geneva Identification System", "GEN# +1.00060951"},
        {"Smithsonian Astrophysical Observation", "SAO 174092"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.03092100),
        dec: Angle.Degrees(-22.16047711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145188"},
        {"Hipparcos Number", "HIP 79244"},
        {"Geneva Identification System", "GEN# +1.00145188"},
        {"Smithsonian Astrophysical Observation", "SAO 184188"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.58290763),
        dec: Angle.Degrees(-22.15695164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37848"},
        {"Hipparcos Number", "HIP 26707"},
        {"Geneva Identification System", "GEN# +1.00037848"},
        {"Smithsonian Astrophysical Observation", "SAO 170675"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.13174003),
        dec: Angle.Degrees(-22.15589863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120219"},
        {"Hipparcos Number", "HIP 67368"},
        {"Geneva Identification System", "GEN# +1.00120219"},
        {"Smithsonian Astrophysical Observation", "SAO 181973"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13021365),
        dec: Angle.Degrees(-22.15572480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195453"},
        {"Hipparcos Number", "HIP 101324"},
        {"Geneva Identification System", "GEN# +1.00195453"},
        {"Smithsonian Astrophysical Observation", "SAO 189403"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.05530500),
        dec: Angle.Degrees(-22.15485707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131991"},
        {"Hipparcos Number", "HIP 73181"},
        {"Geneva Identification System", "GEN# +1.00131991"},
        {"Smithsonian Astrophysical Observation", "SAO 183041"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.35431912),
        dec: Angle.Degrees(-22.15323836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104641"},
        {"Hipparcos Number", "HIP 58753"},
        {"Fundamental Katalog 5th Edition", "FK5 5060"},
        {"Smithsonian Astrophysical Observation", "SAO 180409"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.74984251),
        dec: Angle.Degrees(-22.15239188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27076"},
        {"Hipparcos Number", "HIP 19881"},
        {"Smithsonian Astrophysical Observation", "SAO 169274"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.96537884),
        dec: Angle.Degrees(-22.15133325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95642"},
        {"Hipparcos Number", "HIP 53924"},
        {"Smithsonian Astrophysical Observation", "SAO 179449"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.51117758),
        dec: Angle.Degrees(-22.15117723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9798",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1655 AB"},
        {"Henry Draper", "HD 12912"},
        {"Hipparcos Number", "HIP 9798"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.49728871),
        dec: Angle.Degrees(-22.15083961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153362"},
        {"Hipparcos Number", "HIP 83179"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.00288224),
        dec: Angle.Degrees(-22.14883158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221106"},
        {"Hipparcos Number", "HIP 115924"},
        {"Geneva Identification System", "GEN# +1.00221106"},
        {"Smithsonian Astrophysical Observation", "SAO 191943"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.30451484),
        dec: Angle.Degrees(-22.14749805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98218"},
        {"Hipparcos Number", "HIP 55173"},
        {"Smithsonian Astrophysical Observation", "SAO 179746"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.44627391),
        dec: Angle.Degrees(-22.14579927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191268"},
        {"Hipparcos Number", "HIP 99337"},
        {"Smithsonian Astrophysical Observation", "SAO 188969"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.43817346),
        dec: Angle.Degrees(-22.14502931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22303"},
        {"Hipparcos Number", "HIP 16680"},
        {"Smithsonian Astrophysical Observation", "SAO 168644"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.65783118),
        dec: Angle.Degrees(-22.14502845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41840"},
        {"Hipparcos Number", "HIP 28944"},
        {"Smithsonian Astrophysical Observation", "SAO 171238"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.64309909),
        dec: Angle.Degrees(-22.14483488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102914"},
        {"Hipparcos Number", "HIP 57770"},
        {"Smithsonian Astrophysical Observation", "SAO 180235"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.70502931),
        dec: Angle.Degrees(-22.14377375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82204"},
        {"Hipparcos Number", "HIP 46589"},
        {"Smithsonian Astrophysical Observation", "SAO 177551"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.50923779),
        dec: Angle.Degrees(-22.14191644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71197"},
        {"Hipparcos Number", "HIP 41280"},
        {"Fundamental Katalog 5th Edition", "FK5 4757"},
        {"Smithsonian Astrophysical Observation", "SAO 175793"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.32627647),
        dec: Angle.Degrees(-22.14033342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128355"},
        {"Hipparcos Number", "HIP 71473"},
        {"Geneva Identification System", "GEN# +1.00128355"},
        {"Smithsonian Astrophysical Observation", "SAO 182708"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.26096809),
        dec: Angle.Degrees(-22.13970397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77099"},
        {"Hipparcos Number", "HIP 44165"},
        {"Smithsonian Astrophysical Observation", "SAO 176803"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.93332836),
        dec: Angle.Degrees(-22.13648771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10431"},
        {"Hipparcos Number", "HIP 7882"},
        {"Smithsonian Astrophysical Observation", "SAO 167233"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.35113120),
        dec: Angle.Degrees(-22.13633825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115907"},
        {"Hipparcos Number", "HIP 65103"},
        {"Geneva Identification System", "GEN# +1.00115907"},
        {"Smithsonian Astrophysical Observation", "SAO 181566"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12801478),
        dec: Angle.Degrees(-22.13522100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219791"},
        {"Hipparcos Number", "HIP 115103"},
        {"Smithsonian Astrophysical Observation", "SAO 191812"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.70817022),
        dec: Angle.Degrees(-22.13332174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6614 AB"},
        {"Henry Draper", "HD 67652"},
        {"Hipparcos Number", "HIP 39820"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.04217493),
        dec: Angle.Degrees(-22.13209690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83211"},
        {"Smithsonian Astrophysical Observation", "SAO 184902"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.08948659),
        dec: Angle.Degrees(-22.13198542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164359"},
        {"Hipparcos Number", "HIP 88281"},
        {"Celescope Catalog", "CEL 4592"},
        {"Geneva Identification System", "GEN# +1.00164359"},
        {"Smithsonian Astrophysical Observation", "SAO 186126"},
        {"Wilson Evans Batten Catalogue", "WEB 14918"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.41297239),
        dec: Angle.Degrees(-22.13168165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111097"},
        {"Hipparcos Number", "HIP 62378"},
        {"Geneva Identification System", "GEN# +1.00111097"},
        {"Smithsonian Astrophysical Observation", "SAO 181096"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.76444990),
        dec: Angle.Degrees(-22.12946416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112792"},
        {"Hipparcos Number", "HIP 63394"},
        {"Smithsonian Astrophysical Observation", "SAO 181291"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.86063754),
        dec: Angle.Degrees(-22.12811306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105950"},
        {"Hipparcos Number", "HIP 59447"},
        {"Smithsonian Astrophysical Observation", "SAO 180550"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.90294661),
        dec: Angle.Degrees(-22.12794837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193108"},
        {"Hipparcos Number", "HIP 100181"},
        {"Smithsonian Astrophysical Observation", "SAO 189138"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.79888393),
        dec: Angle.Degrees(-22.12761539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9260 A"},
        {"Henry Draper", "HD 126430"},
        {"Hipparcos Number", "HIP 70552"},
        {"Smithsonian Astrophysical Observation", "SAO 182539"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.48305288),
        dec: Angle.Degrees(-22.12693657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57583"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.06260373),
        dec: Angle.Degrees(-22.12647092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -256.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148211"},
        {"Hipparcos Number", "HIP 80587"},
        {"Cincinnati Publication", "Ci 20 988"},
        {"Cincinnati Publication 2", "Ci 18 2193"},
        {"Geneva Identification System", "GEN# +1.00148211"},
        {"Smithsonian Astrophysical Observation", "SAO 184396"},
        {"Wilson Evans Batten Catalogue", "WEB 13633"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.80447235),
        dec: Angle.Degrees(-22.12606445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -301.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100257"},
        {"Geneva Identification System", "GEN# -0.02205393"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.00798068),
        dec: Angle.Degrees(-22.12488778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45607"},
        {"Hipparcos Number", "HIP 30737"},
        {"Geneva Identification System", "GEN# +1.00045607"},
        {"Renson", "Renson 12123"},
        {"Smithsonian Astrophysical Observation", "SAO 171780"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.86820074),
        dec: Angle.Degrees(-22.12426622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9260 B"},
        {"Hipparcos Number", "HIP 70550"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.47902368),
        dec: Angle.Degrees(-22.12425173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199060"},
        {"Hipparcos Number", "HIP 103274"},
        {"Geneva Identification System", "GEN# +1.00199060"},
        {"Smithsonian Astrophysical Observation", "SAO 189843"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.82783194),
        dec: Angle.Degrees(-22.12362112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27872"},
        {"Hipparcos Number", "HIP 20466"},
        {"Smithsonian Astrophysical Observation", "SAO 169389"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.77569815),
        dec: Angle.Degrees(-22.12039966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14539"},
        {"Hipparcos Number", "HIP 10909"},
        {"Smithsonian Astrophysical Observation", "SAO 167714"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.10327043),
        dec: Angle.Degrees(-22.11972774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146089"},
        {"Hipparcos Number", "HIP 79644"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.79355785),
        dec: Angle.Degrees(-22.11938582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33721",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5687 AP"},
        {"Henry Draper", "HD 52437"},
        {"Hipparcos Number", "HIP 33721"},
        {"Celescope Catalog", "CEL 1495"},
        {"Geneva Identification System", "GEN# +1.00052437J"},
        {"Smithsonian Astrophysical Observation", "SAO 172725"},
        {"Wilson Evans Batten Catalogue", "WEB 6774"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.08068707),
        dec: Angle.Degrees(-22.11906969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42423"},
        {"Hipparcos Number", "HIP 29220"},
        {"Smithsonian Astrophysical Observation", "SAO 171314"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.42390523),
        dec: Angle.Degrees(-22.11896908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139202"},
        {"Hipparcos Number", "HIP 76508"},
        {"Renson", "Renson 39636"},
        {"Smithsonian Astrophysical Observation", "SAO 183632"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.38044318),
        dec: Angle.Degrees(-22.11700171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76043"},
        {"Hipparcos Number", "HIP 43626"},
        {"Geneva Identification System", "GEN# +1.00076043"},
        {"Smithsonian Astrophysical Observation", "SAO 176631"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27581917),
        dec: Angle.Degrees(-22.11696964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25871"},
        {"Hipparcos Number", "HIP 19069"},
        {"Smithsonian Astrophysical Observation", "SAO 169105"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.30815001),
        dec: Angle.Degrees(-22.11163487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189627"},
        {"Hipparcos Number", "HIP 98599"},
        {"Geneva Identification System", "GEN# +1.00189627"},
        {"Smithsonian Astrophysical Observation", "SAO 188833"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.40912960),
        dec: Angle.Degrees(-22.11075836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120467"},
        {"Hipparcos Number", "HIP 67487"},
        {"Cincinnati Publication", "Ci 20 813"},
        {"Geneva Identification System", "GEN# +1.00120467"},
        {"Smithsonian Astrophysical Observation", "SAO 181997"},
        {"Wilson Evans Batten Catalogue", "WEB 11871"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.44128262),
        dec: Angle.Degrees(-22.10989071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1748.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -494.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47012"},
        {"Hipparcos Number", "HIP 31469"},
        {"Smithsonian Astrophysical Observation", "SAO 171992"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.87838592),
        dec: Angle.Degrees(-22.10900153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147220"},
        {"Hipparcos Number", "HIP 80130"},
        {"Geneva Identification System", "GEN# +1.00147220"},
        {"Smithsonian Astrophysical Observation", "SAO 184338"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.33815643),
        dec: Angle.Degrees(-22.10891457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98763"},
        {"Hipparcos Number", "HIP 55480"},
        {"Geneva Identification System", "GEN# +1.00098763"},
        {"Smithsonian Astrophysical Observation", "SAO 179807"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.44159269),
        dec: Angle.Degrees(-22.10525583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184210"},
        {"Hipparcos Number", "HIP 96233"},
        {"Smithsonian Astrophysical Observation", "SAO 188288"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.53079246),
        dec: Angle.Degrees(-22.10444897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180828"},
        {"Hipparcos Number", "HIP 94919"},
        {"Smithsonian Astrophysical Observation", "SAO 187953"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.72629281),
        dec: Angle.Degrees(-22.10364741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44225"},
        {"Hipparcos Number", "HIP 30062"},
        {"Smithsonian Astrophysical Observation", "SAO 171571"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.90913958),
        dec: Angle.Degrees(-22.10314387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208402"},
        {"Hipparcos Number", "HIP 108308"},
        {"Geneva Identification System", "GEN# +1.00208402"},
        {"Smithsonian Astrophysical Observation", "SAO 190752"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.12815680),
        dec: Angle.Degrees(-22.10249656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4808"},
        {"Hipparcos Number", "HIP 3893"},
        {"Smithsonian Astrophysical Observation", "SAO 166610"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.48432584),
        dec: Angle.Degrees(-22.10206989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87163"},
        {"Hipparcos Number", "HIP 49216"},
        {"Smithsonian Astrophysical Observation", "SAO 178338"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.69863277),
        dec: Angle.Degrees(-22.10031318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20952"},
        {"Hipparcos Number", "HIP 15680"},
        {"Smithsonian Astrophysical Observation", "SAO 168490"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.50576137),
        dec: Angle.Degrees(-22.09984372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22658"},
        {"Hipparcos Number", "HIP 16932"},
        {"Smithsonian Astrophysical Observation", "SAO 168690"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.47377431),
        dec: Angle.Degrees(-22.09870836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134030"},
        {"Hipparcos Number", "HIP 74084"},
        {"Smithsonian Astrophysical Observation", "SAO 183204"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.09008531),
        dec: Angle.Degrees(-22.09756701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2978"},
        {"Hipparcos Number", "HIP 2584"},
        {"Geneva Identification System", "GEN# +1.00002978"},
        {"Smithsonian Astrophysical Observation", "SAO 166350"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.20458113),
        dec: Angle.Degrees(-22.09504164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176610"},
        {"Hipparcos Number", "HIP 93456"},
        {"Smithsonian Astrophysical Observation", "SAO 187591"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.49793159),
        dec: Angle.Degrees(-22.09324224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41920"},
        {"Hipparcos Number", "HIP 28983"},
        {"Smithsonian Astrophysical Observation", "SAO 171250"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73725039),
        dec: Angle.Degrees(-22.09306931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171348"},
        {"Hipparcos Number", "HIP 91130"},
        {"Geneva Identification System", "GEN# +1.00171348"},
        {"Smithsonian Astrophysical Observation", "SAO 187010"},
        {"Wilson Evans Batten Catalogue", "WEB 15644"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.83529752),
        dec: Angle.Degrees(-22.09092977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18046"},
        {"Hipparcos Number", "HIP 13458"},
        {"Geneva Identification System", "GEN# +1.00018046"},
        {"Smithsonian Astrophysical Observation", "SAO 168120"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.32595464),
        dec: Angle.Degrees(-22.09074838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77369"},
    },
    visualMagnitude: 11.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.90705972),
        dec: Angle.Degrees(-22.08907091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99138"},
        {"Hipparcos Number", "HIP 55670"},
        {"Smithsonian Astrophysical Observation", "SAO 179845"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.10096112),
        dec: Angle.Degrees(-22.08730991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177685"},
        {"Hipparcos Number", "HIP 93837"},
        {"Smithsonian Astrophysical Observation", "SAO 187680"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64748423),
        dec: Angle.Degrees(-22.08564550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57437"},
        {"Hipparcos Number", "HIP 35566"},
        {"Geneva Identification System", "GEN# +1.00057437"},
        {"Smithsonian Astrophysical Observation", "SAO 173498"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.09513432),
        dec: Angle.Degrees(-22.08459441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73718"},
        {"Hipparcos Number", "HIP 42419"},
        {"Smithsonian Astrophysical Observation", "SAO 176222"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.75132764),
        dec: Angle.Degrees(-22.08436336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16067"},
        {"Smithsonian Astrophysical Observation", "SAO 168550"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.74068354),
        dec: Angle.Degrees(-22.08314278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120668"},
        {"Hipparcos Number", "HIP 67618"},
        {"Smithsonian Astrophysical Observation", "SAO 182025"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.83047611),
        dec: Angle.Degrees(-22.08162299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213924"},
        {"Hipparcos Number", "HIP 111476"},
        {"Renson", "Renson 59335"},
        {"Smithsonian Astrophysical Observation", "SAO 191242"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.77936208),
        dec: Angle.Degrees(-22.07994480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134537"},
        {"Hipparcos Number", "HIP 74291"},
        {"Smithsonian Astrophysical Observation", "SAO 183245"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.77026138),
        dec: Angle.Degrees(-22.07760137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12329"},
        {"Hipparcos Number", "HIP 9376"},
        {"Smithsonian Astrophysical Observation", "SAO 167476"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.12307126),
        dec: Angle.Degrees(-22.07552892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202579"},
        {"Hipparcos Number", "HIP 105084"},
        {"Smithsonian Astrophysical Observation", "SAO 190198"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.31764188),
        dec: Angle.Degrees(-22.07516640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11750"},
        {"Smithsonian Astrophysical Observation", "SAO 167852"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.90174384),
        dec: Angle.Degrees(-22.07410160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181698"},
        {"Hipparcos Number", "HIP 95215"},
        {"Smithsonian Astrophysical Observation", "SAO 188032"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.56485098),
        dec: Angle.Degrees(-22.07372280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154293"},
        {"Hipparcos Number", "HIP 83629"},
        {"Celescope Catalog", "CEL 4476"},
        {"Geneva Identification System", "GEN# +1.00154293"},
        {"Smithsonian Astrophysical Observation", "SAO 185012"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.37628120),
        dec: Angle.Degrees(-22.07271990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20461"},
        {"Hipparcos Number", "HIP 15257"},
        {"Smithsonian Astrophysical Observation", "SAO 168435"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.20112917),
        dec: Angle.Degrees(-22.07230937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186555"},
        {"Hipparcos Number", "HIP 97251"},
        {"Smithsonian Astrophysical Observation", "SAO 188537"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.48010685),
        dec: Angle.Degrees(-22.07222405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94151"},
        {"Hipparcos Number", "HIP 53087"},
        {"Geneva Identification System", "GEN# +1.00094151"},
        {"Smithsonian Astrophysical Observation", "SAO 179280"},
        {"Wilson Evans Batten Catalogue", "WEB 9648"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.91422516),
        dec: Angle.Degrees(-22.07189640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63889",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8765 AB"},
        {"Henry Draper", "HD 113669"},
        {"Hipparcos Number", "HIP 63889"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.39929347),
        dec: Angle.Degrees(-22.07131381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69945"},
        {"Hipparcos Number", "HIP 40708"},
        {"Smithsonian Astrophysical Observation", "SAO 175561"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.64488936),
        dec: Angle.Degrees(-22.07068622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213005"},
        {"Hipparcos Number", "HIP 110958"},
        {"Fundamental Katalog 5th Edition", "FK5 5983"},
        {"Geneva Identification System", "GEN# +1.00213005"},
        {"Smithsonian Astrophysical Observation", "SAO 191168"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.20440884),
        dec: Angle.Degrees(-22.07039887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44828"},
    },
    visualMagnitude: 11.55,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.02417754),
        dec: Angle.Degrees(-22.06884271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 812"},
        {"Hipparcos Number", "HIP 1000"},
        {"Geneva Identification System", "GEN# +1.00000812"},
        {"Smithsonian Astrophysical Observation", "SAO 166113"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.12556151),
        dec: Angle.Degrees(-22.06708268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78518"},
        {"Hipparcos Number", "HIP 44829"},
        {"Smithsonian Astrophysical Observation", "SAO 177001"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.02583050),
        dec: Angle.Degrees(-22.06513871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5201"},
        {"Smithsonian Astrophysical Observation", "SAO 166803"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.62744103),
        dec: Angle.Degrees(-22.06413823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21349"},
        {"Hipparcos Number", "HIP 15989"},
        {"Smithsonian Astrophysical Observation", "SAO 168538"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.48984452),
        dec: Angle.Degrees(-22.06390920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96741",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12743 AB"},
        {"Henry Draper", "HD 185447"},
        {"Hipparcos Number", "HIP 96741"},
        {"Fundamental Katalog 5th Edition", "FK5 5729"},
        {"Smithsonian Astrophysical Observation", "SAO 188414"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.98204326),
        dec: Angle.Degrees(-22.06272832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95417"},
        {"Cincinnati Publication", "Ci 20 1150"},
        {"Geneva Identification System", "GEN# +6.10010757"},
        {"Geneva Identification System 2", "GEN# -0.02213916"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.14325270),
        dec: Angle.Degrees(-22.06107741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -453.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179609"},
        {"Hipparcos Number", "HIP 94510"},
        {"Smithsonian Astrophysical Observation", "SAO 187856"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.53652609),
        dec: Angle.Degrees(-22.06060488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144548"},
        {"Hipparcos Number", "HIP 78977"},
        {"Smithsonian Astrophysical Observation", "SAO 184134"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.82413270),
        dec: Angle.Degrees(-22.06009402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191971"},
        {"Hipparcos Number", "HIP 99636"},
        {"Geneva Identification System", "GEN# +1.00191971"},
        {"Renson", "Renson 53516"},
        {"Smithsonian Astrophysical Observation", "SAO 189037"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.32192141),
        dec: Angle.Degrees(-22.05964131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149760"},
        {"Hipparcos Number", "HIP 81413"},
        {"Geneva Identification System", "GEN# +1.00149760"},
        {"Smithsonian Astrophysical Observation", "SAO 184501"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.40964239),
        dec: Angle.Degrees(-22.05909485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113326"},
        {"Smithsonian Astrophysical Observation", "SAO 191515"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.26786917),
        dec: Angle.Degrees(-22.05902515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212243"},
        {"Hipparcos Number", "HIP 110509"},
        {"Smithsonian Astrophysical Observation", "SAO 191102"},
        {"Wilson Evans Batten Catalogue", "WEB 19808"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.80353618),
        dec: Angle.Degrees(-22.05659637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170798"},
        {"Hipparcos Number", "HIP 90872"},
        {"Smithsonian Astrophysical Observation", "SAO 186938"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.05613240),
        dec: Angle.Degrees(-22.05602108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38935"},
        {"Hipparcos Number", "HIP 27419"},
        {"Smithsonian Astrophysical Observation", "SAO 170857"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.08791839),
        dec: Angle.Degrees(-22.05306899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5986 AB"},
        {"Henry Draper", "HD 57190"},
        {"Hipparcos Number", "HIP 35471"},
        {"Smithsonian Astrophysical Observation", "SAO 173466"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.83384957),
        dec: Angle.Degrees(-22.04971467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194062"},
        {"Hipparcos Number", "HIP 100637"},
        {"Geneva Identification System", "GEN# +1.00194062"},
        {"Smithsonian Astrophysical Observation", "SAO 189245"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.08857841),
        dec: Angle.Degrees(-22.04925284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7170"},
        {"Geneva Identification System", "GEN# -2.02200526"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.11071865),
        dec: Angle.Degrees(-21.90296705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -588.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -888.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16324"},
    },
    visualMagnitude: 10.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.60787277),
        dec: Angle.Degrees(-22.04859814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11806"},
        {"Hipparcos Number", "HIP 8963"},
        {"Smithsonian Astrophysical Observation", "SAO 167396"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.86304434),
        dec: Angle.Degrees(-22.04683438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61846"},
        {"Hipparcos Number", "HIP 37382"},
        {"Smithsonian Astrophysical Observation", "SAO 174256"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.10403730),
        dec: Angle.Degrees(-22.04601295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119232"},
        {"Hipparcos Number", "HIP 66873"},
        {"Geneva Identification System", "GEN# +1.00119232"},
        {"Smithsonian Astrophysical Observation", "SAO 181881"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.58591590),
        dec: Angle.Degrees(-22.04564023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202673"},
        {"Hipparcos Number", "HIP 105149"},
        {"Smithsonian Astrophysical Observation", "SAO 190210"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.50319118),
        dec: Angle.Degrees(-22.04534229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90954"},
        {"Hipparcos Number", "HIP 51385"},
        {"Geneva Identification System", "GEN# +1.00090954"},
        {"Smithsonian Astrophysical Observation", "SAO 178895"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.42580710),
        dec: Angle.Degrees(-22.04454178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149999"},
        {"Hipparcos Number", "HIP 81513"},
        {"Geneva Identification System", "GEN# +1.00149999"},
        {"Smithsonian Astrophysical Observation", "SAO 184522"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.75169725),
        dec: Angle.Degrees(-22.04410217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159376"},
        {"Hipparcos Number", "HIP 86060"},
        {"Geneva Identification System", "GEN# +1.00159376"},
        {"Renson", "Renson 44850"},
        {"Smithsonian Astrophysical Observation", "SAO 185526"},
        {"Wilson Evans Batten Catalogue", "WEB 14520"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.82708859),
        dec: Angle.Degrees(-22.04380131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137115"},
        {"Hipparcos Number", "HIP 75462"},
        {"Smithsonian Astrophysical Observation", "SAO 183447"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.23990548),
        dec: Angle.Degrees(-22.04363055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221995"},
        {"Hipparcos Number", "HIP 116525"},
        {"Smithsonian Astrophysical Observation", "SAO 192034"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.23254094),
        dec: Angle.Degrees(-22.04131043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166827"},
        {"Hipparcos Number", "HIP 89306"},
        {"Smithsonian Astrophysical Observation", "SAO 186487"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.34235092),
        dec: Angle.Degrees(-22.03998159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192190"},
        {"Hipparcos Number", "HIP 99745"},
        {"Geneva Identification System", "GEN# +1.00192190"},
        {"Smithsonian Astrophysical Observation", "SAO 189055"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.57754057),
        dec: Angle.Degrees(-22.03908031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31685"},
        {"Hipparcos Number", "HIP 23009"},
        {"Smithsonian Astrophysical Observation", "SAO 169912"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24182539),
        dec: Angle.Degrees(-22.03808988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46258"},
        {"Hipparcos Number", "HIP 31091"},
        {"Smithsonian Astrophysical Observation", "SAO 171883"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.86884558),
        dec: Angle.Degrees(-22.03778249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33294",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5601 A"},
        {"Henry Draper", "HD 51200"},
        {"Hipparcos Number", "HIP 33294"},
        {"Celescope Catalog", "CEL 1440"},
        {"Geneva Identification System", "GEN# +1.00051200"},
        {"Smithsonian Astrophysical Observation", "SAO 172578"},
        {"Wilson Evans Batten Catalogue", "WEB 6693"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.88705526),
        dec: Angle.Degrees(-22.03746336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97543"},
        {"Hipparcos Number", "HIP 54820"},
        {"Smithsonian Astrophysical Observation", "SAO 179651"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.33427903),
        dec: Angle.Degrees(-22.03706634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8959"},
        {"Hipparcos Number", "HIP 6835"},
        {"Geneva Identification System", "GEN# +1.00008959"},
        {"Smithsonian Astrophysical Observation", "SAO 167062"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.99767169),
        dec: Angle.Degrees(-22.03694621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44082"},
        {"Hipparcos Number", "HIP 30007"},
        {"Smithsonian Astrophysical Observation", "SAO 171550"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74135962),
        dec: Angle.Degrees(-22.03498868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94867"},
        {"Hipparcos Number", "HIP 53515"},
        {"Smithsonian Astrophysical Observation", "SAO 179367"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.21525311),
        dec: Angle.Degrees(-22.03372391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72766"},
        {"Hipparcos Number", "HIP 42021"},
        {"Smithsonian Astrophysical Observation", "SAO 176085"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.48222704),
        dec: Angle.Degrees(-22.03366459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133670"},
        {"Hipparcos Number", "HIP 73927"},
        {"Geneva Identification System", "GEN# +1.00133670"},
        {"Smithsonian Astrophysical Observation", "SAO 183176"},
        {"Wilson Evans Batten Catalogue", "WEB 12624"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.61291084),
        dec: Angle.Degrees(-22.03170347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53629"},
        {"Hipparcos Number", "HIP 34142"},
        {"Geneva Identification System", "GEN# +1.00053629"},
        {"Smithsonian Astrophysical Observation", "SAO 172906"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.19601008),
        dec: Angle.Degrees(-22.03160173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74203"},
        {"Hipparcos Number", "HIP 42678"},
        {"Smithsonian Astrophysical Observation", "SAO 176323"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.47842379),
        dec: Angle.Degrees(-22.02822203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241"},
        {"Hipparcos Number", "HIP 595"},
        {"Geneva Identification System", "GEN# +1.00000241"},
        {"Smithsonian Astrophysical Observation", "SAO 166061"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.80323898),
        dec: Angle.Degrees(-22.02767673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167116"},
        {"Hipparcos Number", "HIP 89410"},
        {"Smithsonian Astrophysical Observation", "SAO 186525"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.68667406),
        dec: Angle.Degrees(-22.02571894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32360"},
        {"Hipparcos Number", "HIP 23398"},
        {"Smithsonian Astrophysical Observation", "SAO 169989"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.43713776),
        dec: Angle.Degrees(-22.02544728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118187"},
        {"Hipparcos Number", "HIP 66322"},
        {"Geneva Identification System", "GEN# +1.00118187"},
        {"Smithsonian Astrophysical Observation", "SAO 181777"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.88221758),
        dec: Angle.Degrees(-22.02446468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94352"},
        {"Hipparcos Number", "HIP 53220"},
        {"Smithsonian Astrophysical Observation", "SAO 179302"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.27818977),
        dec: Angle.Degrees(-22.02352230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194745"},
        {"Hipparcos Number", "HIP 100951"},
        {"Smithsonian Astrophysical Observation", "SAO 189313"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.02207255),
        dec: Angle.Degrees(-22.02324905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95025"},
        {"Hipparcos Number", "HIP 53595"},
        {"Geneva Identification System", "GEN# +1.00095025"},
        {"Smithsonian Astrophysical Observation", "SAO 179383"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.47879753),
        dec: Angle.Degrees(-22.02096147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11683"},
        {"Smithsonian Astrophysical Observation", "SAO 167844"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.67290294),
        dec: Angle.Degrees(-22.02019737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31836"},
        {"Hipparcos Number", "HIP 23084"},
        {"Smithsonian Astrophysical Observation", "SAO 169926"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.51802246),
        dec: Angle.Degrees(-22.01954641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85042"},
        {"Hipparcos Number", "HIP 48138"},
        {"Fundamental Katalog 5th Edition", "FK5 4869"},
        {"Smithsonian Astrophysical Observation", "SAO 178029"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.20691139),
        dec: Angle.Degrees(-22.01883945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211792"},
        {"Hipparcos Number", "HIP 110255"},
        {"Geneva Identification System", "GEN# +1.00211792"},
        {"Smithsonian Astrophysical Observation", "SAO 191064"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.00363069),
        dec: Angle.Degrees(-22.01878483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29219"},
        {"Smithsonian Astrophysical Observation", "SAO 171313"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.42026001),
        dec: Angle.Degrees(-22.01563479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54059"},
        {"Hipparcos Number", "HIP 34295"},
        {"Geneva Identification System", "GEN# +1.00054059"},
        {"Smithsonian Astrophysical Observation", "SAO 172971"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.64456234),
        dec: Angle.Degrees(-22.01471206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132954"},
        {"Hipparcos Number", "HIP 73588"},
        {"Smithsonian Astrophysical Observation", "SAO 183108"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.62524206),
        dec: Angle.Degrees(-22.01410927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132475"},
        {"Hipparcos Number", "HIP 73385"},
        {"Cincinnati Publication", "Ci 20 902"},
        {"Geneva Identification System", "GEN# +1.00132475"},
        {"Smithsonian Astrophysical Observation", "SAO 183072"},
        {"Wilson Evans Batten Catalogue", "WEB 12567"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.95881846),
        dec: Angle.Degrees(-22.01150869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -560.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -499.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204800"},
        {"Hipparcos Number", "HIP 106273"},
        {"Smithsonian Astrophysical Observation", "SAO 190404"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.88432084),
        dec: Angle.Degrees(-22.01109363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63543"},
        {"Hipparcos Number", "HIP 38108"},
        {"Geneva Identification System", "GEN# +1.00063543"},
        {"Smithsonian Astrophysical Observation", "SAO 174578"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.14825296),
        dec: Angle.Degrees(-22.00925383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51764"},
        {"Smithsonian Astrophysical Observation", "SAO 178988"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.66386920),
        dec: Angle.Degrees(-22.00880134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83597"},
        {"Smithsonian Astrophysical Observation", "SAO 185006"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.28775487),
        dec: Angle.Degrees(-22.00792270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4247"},
        {"Hipparcos Number", "HIP 3505"},
        {"Geneva Identification System", "GEN# +1.00004247"},
        {"Smithsonian Astrophysical Observation", "SAO 166528"},
        {"Wilson Evans Batten Catalogue", "WEB 620"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.18515547),
        dec: Angle.Degrees(-22.00633247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199285"},
        {"Hipparcos Number", "HIP 103398"},
        {"Smithsonian Astrophysical Observation", "SAO 189861"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.21972908),
        dec: Angle.Degrees(-22.00573960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57236"},
        {"Hipparcos Number", "HIP 35493"},
        {"Geneva Identification System", "GEN# +1.00057236"},
        {"Smithsonian Astrophysical Observation", "SAO 173470"},
        {"Wilson Evans Batten Catalogue", "WEB 7078"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.87543125),
        dec: Angle.Degrees(-22.00480589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10036"},
        {"Smithsonian Astrophysical Observation", "SAO 167591"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.29260883),
        dec: Angle.Degrees(-22.00281006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64298"},
        {"Hipparcos Number", "HIP 38439"},
        {"Geneva Identification System", "GEN# +1.00064298"},
        {"Smithsonian Astrophysical Observation", "SAO 174705"},
        {"Wilson Evans Batten Catalogue", "WEB 7559"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.12529774),
        dec: Angle.Degrees(-21.99975357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192923"},
        {"Hipparcos Number", "HIP 100067"},
        {"Geneva Identification System", "GEN# +1.00192923"},
        {"Smithsonian Astrophysical Observation", "SAO 189120"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.52409568),
        dec: Angle.Degrees(-21.99833022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83213"},
        {"Hipparcos Number", "HIP 47134"},
        {"Smithsonian Astrophysical Observation", "SAO 177725"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.06783308),
        dec: Angle.Degrees(-21.99718917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46892"},
        {"Hipparcos Number", "HIP 31409"},
        {"Smithsonian Astrophysical Observation", "SAO 171980"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.74868899),
        dec: Angle.Degrees(-21.99549211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62393"},
        {"Hipparcos Number", "HIP 37603"},
        {"Smithsonian Astrophysical Observation", "SAO 174360"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.73453941),
        dec: Angle.Degrees(-21.99443385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3000"},
        {"Henry Draper", "HD 26087"},
        {"Hipparcos Number", "HIP 19202"},
        {"Renson", "Renson 6630"},
        {"Smithsonian Astrophysical Observation", "SAO 169135"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.74216132),
        dec: Angle.Degrees(-21.99403296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126848"},
        {"Hipparcos Number", "HIP 70787"},
        {"Smithsonian Astrophysical Observation", "SAO 182578"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.13939971),
        dec: Angle.Degrees(-21.99400069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68533"},
        {"Hipparcos Number", "HIP 40156"},
        {"Smithsonian Astrophysical Observation", "SAO 175369"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.01047724),
        dec: Angle.Degrees(-21.99275125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73101"},
        {"Hipparcos Number", "HIP 42171"},
        {"Renson", "Renson 20300"},
        {"Smithsonian Astrophysical Observation", "SAO 176137"},
    },
    visualMagnitude: 9.41,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96114399),
        dec: Angle.Degrees(-21.99240631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224225"},
        {"Hipparcos Number", "HIP 118002"},
        {"Geneva Identification System", "GEN# +1.00224225"},
        {"Smithsonian Astrophysical Observation", "SAO 192250"},
        {"Wilson Evans Batten Catalogue", "WEB 20750"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.02989898),
        dec: Angle.Degrees(-21.99209091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102930"},
        {"Smithsonian Astrophysical Observation", "SAO 189769"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.80252349),
        dec: Angle.Degrees(-21.99206598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126682"},
        {"Hipparcos Number", "HIP 70696"},
        {"Smithsonian Astrophysical Observation", "SAO 182562"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.88926142),
        dec: Angle.Degrees(-21.99190180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121202"},
        {"Hipparcos Number", "HIP 67903"},
        {"Smithsonian Astrophysical Observation", "SAO 182068"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.60904970),
        dec: Angle.Degrees(-21.98865450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10810"},
        {"Hipparcos Number", "HIP 8200"},
        {"Fundamental Katalog 5th Edition", "FK5 4157"},
        {"Geneva Identification System", "GEN# +1.00010810"},
        {"Smithsonian Astrophysical Observation", "SAO 167272"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.35388531),
        dec: Angle.Degrees(-21.98706973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131829"},
        {"Hipparcos Number", "HIP 73101"},
        {"Smithsonian Astrophysical Observation", "SAO 183013"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.10100473),
        dec: Angle.Degrees(-21.98529110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34779"},
        {"Hipparcos Number", "HIP 24800"},
        {"Smithsonian Astrophysical Observation", "SAO 170305"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.75445168),
        dec: Angle.Degrees(-21.98417326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78624"},
        {"Hipparcos Number", "HIP 44886"},
        {"Smithsonian Astrophysical Observation", "SAO 177020"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.18042222),
        dec: Angle.Degrees(-21.98336619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58585"},
        {"Hipparcos Number", "HIP 36017"},
        {"Geneva Identification System", "GEN# +1.00058585J"},
        {"Renson", "Renson 16000"},
        {"Smithsonian Astrophysical Observation", "SAO 173691"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.33323471),
        dec: Angle.Degrees(-21.98259839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143567"},
        {"Hipparcos Number", "HIP 78530"},
        {"Celescope Catalog", "CEL 4411"},
        {"Geneva Identification System", "GEN# +1.00143567"},
        {"Smithsonian Astrophysical Observation", "SAO 184043"},
        {"Wilson Evans Batten Catalogue", "WEB 13274"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.48109294),
        dec: Angle.Degrees(-21.98032976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220546"},
        {"Hipparcos Number", "HIP 115573"},
        {"Smithsonian Astrophysical Observation", "SAO 191879"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.16201672),
        dec: Angle.Degrees(-21.98020467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194603"},
        {"Hipparcos Number", "HIP 100879"},
        {"Smithsonian Astrophysical Observation", "SAO 189299"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.81349214),
        dec: Angle.Degrees(-21.97985109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183388"},
        {"Hipparcos Number", "HIP 95895"},
        {"Smithsonian Astrophysical Observation", "SAO 188205"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.53946108),
        dec: Angle.Degrees(-21.97803197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74477"},
        {"Wilson Evans Batten Catalogue", "WEB 12707"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.27599470),
        dec: Angle.Degrees(-21.97739797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -727.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24392"},
        {"Smithsonian Astrophysical Observation", "SAO 170217"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.49638683),
        dec: Angle.Degrees(-21.97370161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81751"},
        {"Hipparcos Number", "HIP 46346"},
        {"Geneva Identification System", "GEN# +1.00081751"},
        {"Smithsonian Astrophysical Observation", "SAO 177463"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.73792588),
        dec: Angle.Degrees(-21.97332303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142097"},
        {"Hipparcos Number", "HIP 77815"},
        {"Geneva Identification System", "GEN# +1.00142097"},
        {"Smithsonian Astrophysical Observation", "SAO 183894"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.34138545),
        dec: Angle.Degrees(-21.97123616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205109"},
        {"Hipparcos Number", "HIP 106454"},
        {"Smithsonian Astrophysical Observation", "SAO 190440"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.41426499),
        dec: Angle.Degrees(-21.96922554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61985"},
        {"Smithsonian Astrophysical Observation", "SAO 181031"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.54218847),
        dec: Angle.Degrees(-21.96750246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138343"},
        {"Hipparcos Number", "HIP 76071"},
        {"Geneva Identification System", "GEN# +1.00138343"},
        {"Smithsonian Astrophysical Observation", "SAO 183547"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.04307680),
        dec: Angle.Degrees(-21.96677288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12561"},
        {"Hipparcos Number", "HIP 9534"},
        {"Geneva Identification System", "GEN# +1.00012561"},
        {"Smithsonian Astrophysical Observation", "SAO 167512"},
        {"Wilson Evans Batten Catalogue", "WEB 2001"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64691584),
        dec: Angle.Degrees(-21.96576972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172158"},
        {"Hipparcos Number", "HIP 91487"},
        {"Geneva Identification System", "GEN# +1.00172158"},
        {"Smithsonian Astrophysical Observation", "SAO 187096"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.87597891),
        dec: Angle.Degrees(-21.96554237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52613"},
        {"Hipparcos Number", "HIP 33799"},
        {"Geneva Identification System", "GEN# +1.00052613"},
        {"Smithsonian Astrophysical Observation", "SAO 172759"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.26882084),
        dec: Angle.Degrees(-21.96479013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20129"},
        {"Hipparcos Number", "HIP 15012"},
        {"Smithsonian Astrophysical Observation", "SAO 168391"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.37934190),
        dec: Angle.Degrees(-21.96428785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164491"},
        {"Hipparcos Number", "HIP 88325"},
        {"Smithsonian Astrophysical Observation", "SAO 186144"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59160256),
        dec: Angle.Degrees(-21.96312895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197236"},
        {"Hipparcos Number", "HIP 102251"},
        {"Smithsonian Astrophysical Observation", "SAO 189604"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.78211613),
        dec: Angle.Degrees(-21.96260567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163296"},
        {"Hipparcos Number", "HIP 87819"},
        {"Geneva Identification System", "GEN# +1.00163296"},
        {"Smithsonian Astrophysical Observation", "SAO 185966"},
        {"Wilson Evans Batten Catalogue", "WEB 14823"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.08872088),
        dec: Angle.Degrees(-21.95597962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106897"},
        {"Hipparcos Number", "HIP 59939"},
        {"Smithsonian Astrophysical Observation", "SAO 180655"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.41597322),
        dec: Angle.Degrees(-21.95487299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80032"},
        {"Hipparcos Number", "HIP 45535"},
        {"Smithsonian Astrophysical Observation", "SAO 177203"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.21023874),
        dec: Angle.Degrees(-21.95451034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175142"},
        {"Hipparcos Number", "HIP 92834"},
        {"Renson", "Renson 49005"},
        {"Smithsonian Astrophysical Observation", "SAO 187443"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.72071856),
        dec: Angle.Degrees(-21.95396517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90365"},
        {"Hipparcos Number", "HIP 51035"},
        {"Smithsonian Astrophysical Observation", "SAO 178802"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.39614221),
        dec: Angle.Degrees(-21.95317174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191598"},
        {"Hipparcos Number", "HIP 99484"},
        {"Geneva Identification System", "GEN# +1.00191598"},
        {"Smithsonian Astrophysical Observation", "SAO 189000"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.85395973),
        dec: Angle.Degrees(-21.95064051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83132"},
        {"Hipparcos Number", "HIP 47089"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.94759154),
        dec: Angle.Degrees(-21.94726226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62615"},
        {"Smithsonian Astrophysical Observation", "SAO 181137"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.45611121),
        dec: Angle.Degrees(-21.94521171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8557"},
        {"Hipparcos Number", "HIP 6549"},
        {"Geneva Identification System", "GEN# +1.00008557"},
        {"Smithsonian Astrophysical Observation", "SAO 167018"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.04982618),
        dec: Angle.Degrees(-21.94183404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151496"},
        {"Hipparcos Number", "HIP 82271"},
        {"Geneva Identification System", "GEN# +1.00151496"},
        {"Smithsonian Astrophysical Observation", "SAO 184657"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.15102521),
        dec: Angle.Degrees(-21.94108731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144940"},
        {"Hipparcos Number", "HIP 79146"},
        {"Geneva Identification System", "GEN# +1.00144940"},
        {"Smithsonian Astrophysical Observation", "SAO 184171"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.31232131),
        dec: Angle.Degrees(-21.94101622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16592 AB"},
        {"Henry Draper", "HD 219019"},
        {"Hipparcos Number", "HIP 114584"},
        {"Smithsonian Astrophysical Observation", "SAO 191725"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.19344672),
        dec: Angle.Degrees(-21.93847655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51790"},
        {"Hipparcos Number", "HIP 33504"},
        {"Geneva Identification System", "GEN# +1.00051790"},
        {"Renson", "Renson 14250"},
        {"Wilson Evans Batten Catalogue", "WEB 6736"},
    },
    visualMagnitude: 9.37,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.46317757),
        dec: Angle.Degrees(-21.93722324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218191"},
        {"Hipparcos Number", "HIP 114076"},
        {"Smithsonian Astrophysical Observation", "SAO 191646"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.56214432),
        dec: Angle.Degrees(-21.93703278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80440"},
        {"Cincinnati Publication", "Ci 20 985"},
        {"Geneva Identification System", "GEN# -0.02104352"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.30568812),
        dec: Angle.Degrees(-21.93654138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -574.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119966"},
        {"Hipparcos Number", "HIP 67243"},
        {"Smithsonian Astrophysical Observation", "SAO 181950"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.72156210),
        dec: Angle.Degrees(-21.93393414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 655"},
        {"Hipparcos Number", "HIP 878"},
        {"Smithsonian Astrophysical Observation", "SAO 166095"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69357223),
        dec: Angle.Degrees(-21.93357013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4259"},
        {"Smithsonian Astrophysical Observation", "SAO 166667"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.58283825),
        dec: Angle.Degrees(-21.93243434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162184"},
        {"Hipparcos Number", "HIP 87332"},
        {"Geneva Identification System", "GEN# +1.00162184"},
        {"Smithsonian Astrophysical Observation", "SAO 185834"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.66303073),
        dec: Angle.Degrees(-21.93109465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60219"},
        {"Hipparcos Number", "HIP 36666"},
        {"Geneva Identification System", "GEN# +1.00060219"},
        {"Smithsonian Astrophysical Observation", "SAO 173963"},
        {"Wilson Evans Batten Catalogue", "WEB 7291"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.15270859),
        dec: Angle.Degrees(-21.93042427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16093"},
        {"Hipparcos Number", "HIP 11986"},
        {"Fundamental Katalog 5th Edition", "FK5 4234"},
        {"Smithsonian Astrophysical Observation", "SAO 167885"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.64946912),
        dec: Angle.Degrees(-21.93035013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9625 A"},
        {"Henry Draper", "HD 137210"},
        {"Henry Draper 2", "HD 137210A"},
        {"Hipparcos Number", "HIP 75504"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.34416228),
        dec: Angle.Degrees(-21.92921292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206266"},
        {"Hipparcos Number", "HIP 107091"},
        {"Smithsonian Astrophysical Observation", "SAO 190552"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.37668836),
        dec: Angle.Degrees(-21.92861927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94338",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12139 A"},
        {"Henry Draper", "HD 179113"},
        {"Hipparcos Number", "HIP 94338"},
        {"Smithsonian Astrophysical Observation", "SAO 187806"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.02422148),
        dec: Angle.Degrees(-21.92824109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22204"},
        {"Hipparcos Number", "HIP 16608"},
        {"Smithsonian Astrophysical Observation", "SAO 168633"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.43991838),
        dec: Angle.Degrees(-21.92753236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143937"},
        {"Hipparcos Number", "HIP 78708"},
        {"Geneva Identification System", "GEN# +1.00143937"},
        {"Smithsonian Astrophysical Observation", "SAO 184077"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.01257870),
        dec: Angle.Degrees(-21.92747786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -293.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1784"},
        {"Smithsonian Astrophysical Observation", "SAO 166227"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.67104930),
        dec: Angle.Degrees(-21.92729296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73805"},
        {"Hipparcos Number", "HIP 42469"},
        {"Smithsonian Astrophysical Observation", "SAO 176237"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.87405588),
        dec: Angle.Degrees(-21.92595601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20605"},
        {"Hipparcos Number", "HIP 15376"},
        {"Geneva Identification System", "GEN# +1.00020605"},
        {"Smithsonian Astrophysical Observation", "SAO 168451"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.57401162),
        dec: Angle.Degrees(-21.92548739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 196.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222281"},
        {"Hipparcos Number", "HIP 116721"},
        {"Geneva Identification System", "GEN# +1.00222281"},
        {"Smithsonian Astrophysical Observation", "SAO 192063"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.81606546),
        dec: Angle.Degrees(-21.92400760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64564"},
        {"Hipparcos Number", "HIP 38562"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)53, 44.7000),
        dec: Angle.DegreesMinutesSeconds((int)-21, (int)55, 20.600)
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
    primaryId: "HIP 12507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16783"},
        {"Hipparcos Number", "HIP 12507"},
        {"Smithsonian Astrophysical Observation", "SAO 167970"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.23355058),
        dec: Angle.Degrees(-21.92225929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56372"},
        {"Hipparcos Number", "HIP 35150"},
    },
    visualMagnitude: 9.62,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98474813),
        dec: Angle.Degrees(-21.92175246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174596"},
        {"Hipparcos Number", "HIP 92602"},
        {"Smithsonian Astrophysical Observation", "SAO 187381"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.03478021),
        dec: Angle.Degrees(-21.92141108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198521"},
        {"Hipparcos Number", "HIP 102948"},
        {"Smithsonian Astrophysical Observation", "SAO 189774"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.86608256),
        dec: Angle.Degrees(-21.92140278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115233"},
        {"Hipparcos Number", "HIP 64738"},
        {"Geneva Identification System", "GEN# +1.00115233"},
        {"Smithsonian Astrophysical Observation", "SAO 181499"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.02528702),
        dec: Angle.Degrees(-21.91736991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81675"},
        {"Hipparcos Number", "HIP 46301"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.63975548),
        dec: Angle.Degrees(-21.91725250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60973"},
        {"Hipparcos Number", "HIP 36990"},
        {"Fundamental Katalog 5th Edition", "FK5 4682"},
        {"Geneva Identification System", "GEN# +1.00060973"},
        {"Smithsonian Astrophysical Observation", "SAO 174094"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.05141002),
        dec: Angle.Degrees(-21.91679438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160042"},
        {"Hipparcos Number", "HIP 86352"},
        {"Geneva Identification System", "GEN# +1.00160042"},
        {"Smithsonian Astrophysical Observation", "SAO 185584"},
        {"Wilson Evans Batten Catalogue", "WEB 14568"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.68695573),
        dec: Angle.Degrees(-21.91262453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12609"},
        {"Hipparcos Number", "HIP 9577"},
        {"Smithsonian Astrophysical Observation", "SAO 167520"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.75880123),
        dec: Angle.Degrees(-21.91189977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49590"},
        {"Hipparcos Number", "HIP 32613"},
        {"Smithsonian Astrophysical Observation", "SAO 172348"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.06886248),
        dec: Angle.Degrees(-21.90658228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50143"},
        {"Hipparcos Number", "HIP 32866"},
        {"Geneva Identification System", "GEN# +1.00050143"},
        {"Renson", "Renson 13666"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74213542),
        dec: Angle.Degrees(-21.90587272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32803"},
        {"Hipparcos Number", "HIP 23636"},
        {"Geneva Identification System", "GEN# +1.00032803"},
        {"Smithsonian Astrophysical Observation", "SAO 170041"},
        {"Wilson Evans Batten Catalogue", "WEB 4609"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.21182688),
        dec: Angle.Degrees(-21.90450785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5601"},
        {"Smithsonian Astrophysical Observation", "SAO 166865"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.96198984),
        dec: Angle.Degrees(-21.90323717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184795"},
        {"Hipparcos Number", "HIP 96488"},
        {"Geneva Identification System", "GEN# +1.00184795"},
        {"Smithsonian Astrophysical Observation", "SAO 188346"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.22846951),
        dec: Angle.Degrees(-21.90268877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224462"},
        {"Hipparcos Number", "HIP 118164"},
        {"Geneva Identification System", "GEN# +1.00224462"},
        {"Smithsonian Astrophysical Observation", "SAO 192272"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.53478669),
        dec: Angle.Degrees(-21.90151021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12039"},
        {"Hipparcos Number", "HIP 9141"},
        {"Geneva Identification System", "GEN# +1.00012039"},
        {"Smithsonian Astrophysical Observation", "SAO 167434"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.45380158),
        dec: Angle.Degrees(-21.90136168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146589"},
        {"Hipparcos Number", "HIP 79839"},
        {"Smithsonian Astrophysical Observation", "SAO 184296"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.44605322),
        dec: Angle.Degrees(-21.90036048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140007"},
        {"Hipparcos Number", "HIP 76903"},
        {"Geneva Identification System", "GEN# +1.00140007"},
        {"Smithsonian Astrophysical Observation", "SAO 183716"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.54319395),
        dec: Angle.Degrees(-21.89957526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103436"},
        {"Hipparcos Number", "HIP 58066"},
        {"Smithsonian Astrophysical Observation", "SAO 180287"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.63238427),
        dec: Angle.Degrees(-21.89825548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157620"},
        {"Hipparcos Number", "HIP 85247"},
        {"Geneva Identification System", "GEN# +1.00157620"},
        {"Smithsonian Astrophysical Observation", "SAO 185377"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.29846479),
        dec: Angle.Degrees(-21.89545318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30719"},
        {"Hipparcos Number", "HIP 22388"},
        {"Smithsonian Astrophysical Observation", "SAO 169793"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.29269938),
        dec: Angle.Degrees(-21.89107305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18143"},
        {"Smithsonian Astrophysical Observation", "SAO 168909"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.18423626),
        dec: Angle.Degrees(-21.88586065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213452"},
        {"Hipparcos Number", "HIP 111204"},
        {"Smithsonian Astrophysical Observation", "SAO 191206"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.93565312),
        dec: Angle.Degrees(-21.88547960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221226"},
        {"Hipparcos Number", "HIP 116009"},
        {"Geneva Identification System", "GEN# +1.00221226"},
        {"Renson", "Renson 60654"},
        {"Smithsonian Astrophysical Observation", "SAO 191954"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.56653010),
        dec: Angle.Degrees(-21.88285722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69562"},
        {"Hipparcos Number", "HIP 40543"},
        {"Geneva Identification System", "GEN# +1.00069562"},
        {"Smithsonian Astrophysical Observation", "SAO 175492"},
        {"Wilson Evans Batten Catalogue", "WEB 7889"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.18564923),
        dec: Angle.Degrees(-21.88208368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3179"},
        {"Hipparcos Number", "HIP 2727"},
        {"Geneva Identification System", "GEN# +1.00003179"},
        {"Smithsonian Astrophysical Observation", "SAO 166375"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.71070462),
        dec: Angle.Degrees(-21.88207785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50802"},
        {"Hipparcos Number", "HIP 33116"},
        {"Geneva Identification System", "GEN# +1.00050802"},
        {"Smithsonian Astrophysical Observation", "SAO 172528"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.45821143),
        dec: Angle.Degrees(-21.88132029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98081"},
        {"Hipparcos Number", "HIP 55091"},
        {"Geneva Identification System", "GEN# +1.00098081"},
        {"Smithsonian Astrophysical Observation", "SAO 179727"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.19424475),
        dec: Angle.Degrees(-21.88038808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
