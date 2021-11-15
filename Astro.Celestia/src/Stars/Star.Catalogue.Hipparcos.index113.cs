using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_113() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6047"},
        {"Hipparcos Number", "HIP 4904"},
        {"Geneva Identification System", "GEN# +1.00006047"},
        {"Smithsonian Astrophysical Observation", "SAO 11541"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.73488776),
        dec: Angle.Degrees(+64.83633307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170527"},
        {"Hipparcos Number", "HIP 90274"},
        {"Smithsonian Astrophysical Observation", "SAO 17878"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.29225230),
        dec: Angle.Degrees(+64.83827042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10124"},
        {"Smithsonian Astrophysical Observation", "SAO 12152"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.55507525),
        dec: Angle.Degrees(+64.83989776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21917"},
        {"Smithsonian Astrophysical Observation", "SAO 13238"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.70176862),
        dec: Angle.Degrees(+64.84520776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116955"},
        {"Hipparcos Number", "HIP 65486"},
        {"Geneva Identification System", "GEN# +1.00116955"},
        {"Smithsonian Astrophysical Observation", "SAO 16070"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.32852168),
        dec: Angle.Degrees(+64.84559045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114285"},
        {"Celescope Catalog", "CEL 5568"},
        {"Geneva Identification System", "GEN# +0.06401760"},
        {"Smithsonian Astrophysical Observation", "SAO 20446"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.20835619),
        dec: Angle.Degrees(+64.84620007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8603",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1459 C"},
        {"Hipparcos Number", "HIP 8603"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.74829194),
        dec: Angle.Degrees(+64.84680646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220072"},
        {"Hipparcos Number", "HIP 115203"},
        {"Geneva Identification System", "GEN# +1.00220072"},
        {"Smithsonian Astrophysical Observation", "SAO 20564"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.01103829),
        dec: Angle.Degrees(+64.84852242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70624"},
        {"Hipparcos Number", "HIP 41414"},
        {"Geneva Identification System", "GEN# +1.00070624"},
        {"Smithsonian Astrophysical Observation", "SAO 14551"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.71531277),
        dec: Angle.Degrees(+64.85277373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125306"},
        {"Hipparcos Number", "HIP 69698"},
        {"Renson", "Renson 35783"},
        {"Smithsonian Astrophysical Observation", "SAO 16321"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.99867016),
        dec: Angle.Degrees(+64.85315735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8626",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1459 A"},
        {"Henry Draper", "HD 11092"},
        {"Hipparcos Number", "HIP 8626"},
        {"Geneva Identification System", "GEN# +1.00011092A"},
        {"Smithsonian Astrophysical Observation", "SAO 12006"},
    },
    visualMagnitude: 6.54,
    bvColour: 2.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.82052450),
        dec: Angle.Degrees(+64.85496037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13427"},
        {"Hipparcos Number", "HIP 10388"},
        {"Smithsonian Astrophysical Observation", "SAO 12175"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.44980888),
        dec: Angle.Degrees(+64.85502564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111839"},
        {"Geneva Identification System", "GEN# +0.06401694"},
        {"Smithsonian Astrophysical Observation", "SAO 20193"},
        {"Wilson Evans Batten Catalogue", "WEB 19977"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.80437333),
        dec: Angle.Degrees(+64.85803957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 189.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112493"},
        {"Smithsonian Astrophysical Observation", "SAO 20244"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.80156229),
        dec: Angle.Degrees(+64.85822736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211887"},
        {"Hipparcos Number", "HIP 110122"},
        {"Smithsonian Astrophysical Observation", "SAO 19994"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.60548128),
        dec: Angle.Degrees(+64.85885792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94134"},
        {"Geneva Identification System", "GEN# +0.06401332"},
        {"Smithsonian Astrophysical Observation", "SAO 18183"},
        {"Wilson Evans Batten Catalogue", "WEB 16396"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.42747333),
        dec: Angle.Degrees(+64.85891859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8632",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1459 B"},
        {"Hipparcos Number", "HIP 8632"},
        {"Geneva Identification System", "GEN# +0.06400244"},
        {"Smithsonian Astrophysical Observation", "SAO 12007"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83405662),
        dec: Angle.Degrees(+64.86266139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165906"},
        {"Hipparcos Number", "HIP 88451"},
        {"Smithsonian Astrophysical Observation", "SAO 17739"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.88245671),
        dec: Angle.Degrees(+64.86424317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43399"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.60422090),
        dec: Angle.Degrees(+64.86453759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 912"},
        {"Hipparcos Number", "HIP 1105"},
        {"Geneva Identification System", "GEN# +1.00000912"},
        {"Smithsonian Astrophysical Observation", "SAO 11050"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.44344038),
        dec: Angle.Degrees(+64.86484243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193812"},
        {"Hipparcos Number", "HIP 100101"},
        {"Smithsonian Astrophysical Observation", "SAO 18799"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61158708),
        dec: Angle.Degrees(+64.86796514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218363"},
        {"Hipparcos Number", "HIP 114082"},
        {"Smithsonian Astrophysical Observation", "SAO 20423"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.57655727),
        dec: Angle.Degrees(+64.86887829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43910"},
        {"Smithsonian Astrophysical Observation", "SAO 14704"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.17873306),
        dec: Angle.Degrees(+64.87096263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203467"},
        {"Hipparcos Number", "HIP 105268"},
        {"Celescope Catalog", "CEL 5299"},
        {"Fundamental Katalog 5th Edition", "FK5 3703"},
        {"Geneva Identification System", "GEN# +1.00203467"},
        {"Smithsonian Astrophysical Observation", "SAO 19313"},
        {"Wilson Evans Batten Catalogue", "WEB 19121"},
    },
    visualMagnitude: 5.19,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.84255444),
        dec: Angle.Degrees(+64.87184231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17020 AB"},
        {"Henry Draper", "HD 223358"},
        {"Hipparcos Number", "HIP 117430"},
        {"Celescope Catalog", "CEL 5680"},
        {"Geneva Identification System", "GEN# +1.00223358J"},
        {"Renson", "Renson 61200"},
        {"Smithsonian Astrophysical Observation", "SAO 20866"},
        {"Wilson Evans Batten Catalogue", "WEB 20681"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.16262779),
        dec: Angle.Degrees(+64.87648481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110540"},
        {"Smithsonian Astrophysical Observation", "SAO 20045"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.89286526),
        dec: Angle.Degrees(+64.88064092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65988"},
        {"Hipparcos Number", "HIP 39608"},
        {"Smithsonian Astrophysical Observation", "SAO 14429"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.40848254),
        dec: Angle.Degrees(+64.88472631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27037"},
        {"Hipparcos Number", "HIP 20279"},
        {"Smithsonian Astrophysical Observation", "SAO 13100"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.19626438),
        dec: Angle.Degrees(+64.88635887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224598"},
        {"Hipparcos Number", "HIP 118240"},
        {"Geneva Identification System", "GEN# +1.00224598"},
        {"Smithsonian Astrophysical Observation", "SAO 20975"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.74367000),
        dec: Angle.Degrees(+64.88833450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41199",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6772 AB"},
        {"Henry Draper", "HD 70166"},
        {"Hipparcos Number", "HIP 41199"},
        {"Smithsonian Astrophysical Observation", "SAO 14532"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.10994762),
        dec: Angle.Degrees(+64.89093838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144012"},
        {"Hipparcos Number", "HIP 78325"},
        {"Smithsonian Astrophysical Observation", "SAO 16911"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.88871182),
        dec: Angle.Degrees(+64.89334935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122251"},
        {"Hipparcos Number", "HIP 68266"},
        {"Smithsonian Astrophysical Observation", "SAO 16234"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.62003336),
        dec: Angle.Degrees(+64.89385794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84558"},
        {"Hipparcos Number", "HIP 48132"},
        {"Geneva Identification System", "GEN# +1.00084558"},
        {"Smithsonian Astrophysical Observation", "SAO 14991"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.19493992),
        dec: Angle.Degrees(+64.89423286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114356"},
        {"Smithsonian Astrophysical Observation", "SAO 20465"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.40673035),
        dec: Angle.Degrees(+64.89499361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19439"},
        {"Hipparcos Number", "HIP 14791"},
        {"Geneva Identification System", "GEN# +1.00019439"},
        {"Smithsonian Astrophysical Observation", "SAO 12636"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.75335146),
        dec: Angle.Degrees(+64.89630197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92901"},
        {"Hipparcos Number", "HIP 52587"},
        {"Smithsonian Astrophysical Observation", "SAO 15275"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.29467813),
        dec: Angle.Degrees(+64.89805706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15408 B"},
        {"Hipparcos Number", "HIP 107909"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.94348418),
        dec: Angle.Degrees(+64.89941015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107914",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15408 A"},
        {"Henry Draper", "HD 208141"},
        {"Hipparcos Number", "HIP 107914"},
        {"Smithsonian Astrophysical Observation", "SAO 19687"},
        {"Wilson Evans Batten Catalogue", "WEB 19460"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.95114314),
        dec: Angle.Degrees(+64.89993728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12279"},
        {"Hipparcos Number", "HIP 9564"},
        {"Celescope Catalog", "CEL 188"},
        {"Geneva Identification System", "GEN# +1.00012279"},
        {"Renson", "Renson 3120"},
        {"Smithsonian Astrophysical Observation", "SAO 12095"},
        {"Wilson Evans Batten Catalogue", "WEB 2006"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.71872421),
        dec: Angle.Degrees(+64.90149425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6406 A"},
        {"Henry Draper", "HD 63384"},
        {"Hipparcos Number", "HIP 38489"},
        {"Smithsonian Astrophysical Observation", "SAO 14349"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.23110591),
        dec: Angle.Degrees(+64.90367545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3902 AB"},
        {"Hipparcos Number", "HIP 25046"},
        {"Smithsonian Astrophysical Observation", "SAO 13464"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.44749164),
        dec: Angle.Degrees(+64.90442163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111976"},
    },
    visualMagnitude: 12.42,
    bvColour: 2.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.22277737),
        dec: Angle.Degrees(+64.90687019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 363.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97771"},
        {"Hipparcos Number", "HIP 55039"},
        {"Smithsonian Astrophysical Observation", "SAO 15451"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.00651489),
        dec: Angle.Degrees(+64.90763559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20226"},
        {"Hipparcos Number", "HIP 15414"},
        {"Smithsonian Astrophysical Observation", "SAO 12696"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.67907111),
        dec: Angle.Degrees(+64.90787680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30437",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4974 AB"},
        {"Henry Draper", "HD 43960"},
        {"Hipparcos Number", "HIP 30437"},
        {"Smithsonian Astrophysical Observation", "SAO 13824"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.98582444),
        dec: Angle.Degrees(+64.91138126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32715"},
        {"Hipparcos Number", "HIP 24017"},
        {"Fundamental Katalog 5th Edition", "FK5 2384"},
        {"Geneva Identification System", "GEN# +1.00032715"},
        {"Smithsonian Astrophysical Observation", "SAO 13388"},
        {"Wilson Evans Batten Catalogue", "WEB 4677"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.43554096),
        dec: Angle.Degrees(+64.91993345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124753"},
        {"Hipparcos Number", "HIP 69416"},
        {"Smithsonian Astrophysical Observation", "SAO 16307"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.19216809),
        dec: Angle.Degrees(+64.92296196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112826"},
        {"Hipparcos Number", "HIP 63297"},
        {"Smithsonian Astrophysical Observation", "SAO 15955"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.57864526),
        dec: Angle.Degrees(+64.92550428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204130"},
        {"Hipparcos Number", "HIP 105625"},
        {"Celescope Catalog", "CEL 5306"},
        {"Geneva Identification System", "GEN# +1.00204130J"},
        {"Smithsonian Astrophysical Observation", "SAO 19376"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.89880584),
        dec: Angle.Degrees(+64.92720890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153494"},
        {"Hipparcos Number", "HIP 82805"},
        {"Geneva Identification System", "GEN# +1.00153494"},
        {"Smithsonian Astrophysical Observation", "SAO 17277"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.85037310),
        dec: Angle.Degrees(+64.92931216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64679"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.84889856),
        dec: Angle.Degrees(+64.93898701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46477"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.18443096),
        dec: Angle.Degrees(+64.93939778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104436"},
        {"Hipparcos Number", "HIP 58650"},
        {"Fundamental Katalog 5th Edition", "FK5 5057"},
        {"Geneva Identification System", "GEN# +1.00104436"},
        {"Smithsonian Astrophysical Observation", "SAO 15691"},
        {"Wilson Evans Batten Catalogue", "WEB 10463"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.40566507),
        dec: Angle.Degrees(+64.93939873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155304"},
        {"Hipparcos Number", "HIP 83672"},
        {"Geneva Identification System", "GEN# +1.00155304"},
        {"Smithsonian Astrophysical Observation", "SAO 17351"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.51994318),
        dec: Angle.Degrees(+64.93976875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6053 AB"},
        {"Henry Draper", "HD 57666"},
        {"Hipparcos Number", "HIP 36149"},
        {"Smithsonian Astrophysical Observation", "SAO 14191"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.69312846),
        dec: Angle.Degrees(+64.94682523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33265"},
        {"Hipparcos Number", "HIP 24375"},
        {"Smithsonian Astrophysical Observation", "SAO 13415"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.44491223),
        dec: Angle.Degrees(+64.94940635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17154"},
        {"Smithsonian Astrophysical Observation", "SAO 12858"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.11662008),
        dec: Angle.Degrees(+64.94955498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144283"},
        {"Hipparcos Number", "HIP 78452"},
        {"Fundamental Katalog 5th Edition", "FK5 3270"},
        {"Geneva Identification System", "GEN# +1.00144283"},
        {"Smithsonian Astrophysical Observation", "SAO 16927"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.24107998),
        dec: Angle.Degrees(+64.95004261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13783"},
        {"Hipparcos Number", "HIP 10629"},
        {"Cincinnati Publication", "Ci 18 288"},
        {"Cincinnati Publication 2", "Ci 20 158"},
        {"Geneva Identification System", "GEN# +1.00013783"},
        {"Smithsonian Astrophysical Observation", "SAO 12200"},
        {"Wilson Evans Batten Catalogue", "WEB 2236"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.20702084),
        dec: Angle.Degrees(+64.95338087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -342.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7301"},
        {"Smithsonian Astrophysical Observation", "SAO 11830"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.50259068),
        dec: Angle.Degrees(+64.95549531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210729"},
        {"Hipparcos Number", "HIP 109435"},
        {"Smithsonian Astrophysical Observation", "SAO 19914"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.56431711),
        dec: Angle.Degrees(+64.95662570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89665"},
        {"Hipparcos Number", "HIP 50841"},
        {"Smithsonian Astrophysical Observation", "SAO 15156"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.71660929),
        dec: Angle.Degrees(+64.95827628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26124"},
        {"Hipparcos Number", "HIP 19627"},
        {"Geneva Identification System", "GEN# +1.00026124"},
        {"Smithsonian Astrophysical Observation", "SAO 13060"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.08502292),
        dec: Angle.Degrees(+64.96034304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 890"},
        {"Geneva Identification System", "GEN# +0.06400007"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.73345038),
        dec: Angle.Degrees(+64.96318376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101904"},
        {"Hipparcos Number", "HIP 57221"},
        {"Geneva Identification System", "GEN# +1.00101904"},
        {"Smithsonian Astrophysical Observation", "SAO 15616"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.00183696),
        dec: Angle.Degrees(+64.96419519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71269"},
        {"Smithsonian Astrophysical Observation", "SAO 16434"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.63443860),
        dec: Angle.Degrees(+64.96611158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28612",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4583 AB"},
        {"Henry Draper", "HD 40202"},
        {"Hipparcos Number", "HIP 28612"},
        {"Smithsonian Astrophysical Observation", "SAO 13686"},
        {"Wilson Evans Batten Catalogue", "WEB 5589"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.58936282),
        dec: Angle.Degrees(+64.96886178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29621"},
        {"Smithsonian Astrophysical Observation", "SAO 13761"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.62988146),
        dec: Angle.Degrees(+64.96899170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69167"},
    },
    visualMagnitude: 11.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.37610155),
        dec: Angle.Degrees(+64.96910848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91874"},
        {"Hipparcos Number", "HIP 52050"},
        {"Smithsonian Astrophysical Observation", "SAO 15241"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.53821186),
        dec: Angle.Degrees(+64.97030535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49331"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.04197154),
        dec: Angle.Degrees(+64.97079861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101593"},
        {"Geneva Identification System", "GEN# +0.06401452"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.84075719),
        dec: Angle.Degrees(+64.97203552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 286.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31052"},
        {"Smithsonian Astrophysical Observation", "SAO 13857"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.73811947),
        dec: Angle.Degrees(+64.97767289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106772"},
        {"Smithsonian Astrophysical Observation", "SAO 19539"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.41635720),
        dec: Angle.Degrees(+64.98091130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224232"},
        {"Hipparcos Number", "HIP 117999"},
        {"Smithsonian Astrophysical Observation", "SAO 20941"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.02063851),
        dec: Angle.Degrees(+64.98337402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83962"},
        {"Hipparcos Number", "HIP 47791"},
        {"Geneva Identification System", "GEN# +1.00083962"},
        {"Smithsonian Astrophysical Observation", "SAO 14976"},
        {"Wilson Evans Batten Catalogue", "WEB 8947"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15260374),
        dec: Angle.Degrees(+64.98406585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106343"},
        {"Smithsonian Astrophysical Observation", "SAO 19477"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.06158173),
        dec: Angle.Degrees(+64.98453008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7179 AB"},
        {"Henry Draper", "HD 77725"},
        {"Hipparcos Number", "HIP 44788"},
        {"Smithsonian Astrophysical Observation", "SAO 14766"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.92132314),
        dec: Angle.Degrees(+64.98498805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46962"},
        {"Hipparcos Number", "HIP 31980"},
        {"Geneva Identification System", "GEN# +1.00046962"},
        {"Smithsonian Astrophysical Observation", "SAO 13919"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.24838879),
        dec: Angle.Degrees(+64.98689838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28401"},
        {"Hipparcos Number", "HIP 21229"},
        {"Geneva Identification System", "GEN# +1.00028401"},
        {"Smithsonian Astrophysical Observation", "SAO 13180"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.31426779),
        dec: Angle.Degrees(+64.98840275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164057"},
        {"Hipparcos Number", "HIP 87687"},
        {"Geneva Identification System", "GEN# +1.00164057"},
        {"Smithsonian Astrophysical Observation", "SAO 17678"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.66093218),
        dec: Angle.Degrees(+64.99305783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61251"},
        {"Hipparcos Number", "HIP 37587"},
        {"Smithsonian Astrophysical Observation", "SAO 14290"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.70010072),
        dec: Angle.Degrees(+64.99935383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204089"},
        {"Hipparcos Number", "HIP 105594"},
        {"Geneva Identification System", "GEN# +1.00204089"},
        {"Smithsonian Astrophysical Observation", "SAO 19370"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.82249228),
        dec: Angle.Degrees(+64.99957202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161284"},
        {"Hipparcos Number", "HIP 86456"},
        {"Geneva Identification System", "GEN# +1.00161284"},
        {"Smithsonian Astrophysical Observation", "SAO 17595"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98218345),
        dec: Angle.Degrees(+65.00137662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49580"},
        {"Hipparcos Number", "HIP 33108"},
        {"Geneva Identification System", "GEN# +1.00049580"},
        {"Smithsonian Astrophysical Observation", "SAO 13994"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.43392868),
        dec: Angle.Degrees(+65.00242613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91275"},
        {"Hipparcos Number", "HIP 51721"},
        {"Smithsonian Astrophysical Observation", "SAO 15220"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.52127331),
        dec: Angle.Degrees(+65.00553493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5659",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 983 AB"},
        {"Henry Draper", "HD 7102"},
        {"Hipparcos Number", "HIP 5659"},
        {"Smithsonian Astrophysical Observation", "SAO 11631"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.17199607),
        dec: Angle.Degrees(+65.00916137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2969 AB"},
        {"Henry Draper", "HD 25426"},
        {"Hipparcos Number", "HIP 19173"},
        {"Smithsonian Astrophysical Observation", "SAO 13017"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.65259553),
        dec: Angle.Degrees(+65.00921407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219496"},
        {"Hipparcos Number", "HIP 114792"},
        {"Geneva Identification System", "GEN# +1.00219496"},
        {"Smithsonian Astrophysical Observation", "SAO 20515"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80218815),
        dec: Angle.Degrees(+65.01229491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79968"},
        {"Hipparcos Number", "HIP 45794"},
        {"Cincinnati Publication", "Ci 18 1097"},
        {"Geneva Identification System", "GEN# +1.00079968"},
        {"Smithsonian Astrophysical Observation", "SAO 14845"},
        {"Wilson Evans Batten Catalogue", "WEB 8684"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.06009252),
        dec: Angle.Degrees(+65.01246096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6972"},
        {"Hipparcos Number", "HIP 5589"},
        {"Celescope Catalog", "CEL 127"},
        {"Fundamental Katalog 5th Edition", "FK5 2078"},
        {"Geneva Identification System", "GEN# +1.00006972"},
        {"Smithsonian Astrophysical Observation", "SAO 11617"},
        {"Wilson Evans Batten Catalogue", "WEB 1248"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.92237013),
        dec: Angle.Degrees(+65.01888517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72905"},
        {"Hipparcos Number", "HIP 42438"},
        {"Geneva Identification System", "GEN# +1.00072905"},
        {"Smithsonian Astrophysical Observation", "SAO 14609"},
        {"Wilson Evans Batten Catalogue", "WEB 8162"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.79892615),
        dec: Angle.Degrees(+65.02069298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201134"},
        {"Hipparcos Number", "HIP 104020"},
        {"Smithsonian Astrophysical Observation", "SAO 19177"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.11190764),
        dec: Angle.Degrees(+65.02076366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137490"},
        {"Hipparcos Number", "HIP 75265"},
        {"Smithsonian Astrophysical Observation", "SAO 16715"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.67455896),
        dec: Angle.Degrees(+65.02457585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113426"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.58085170),
        dec: Angle.Degrees(+65.02956217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95475"},
        {"Smithsonian Astrophysical Observation", "SAO 18337"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.31261457),
        dec: Angle.Degrees(+65.03298711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204100"},
        {"Hipparcos Number", "HIP 105610"},
        {"Celescope Catalog", "CEL 5305"},
        {"Geneva Identification System", "GEN# +1.00204100"},
        {"Smithsonian Astrophysical Observation", "SAO 19371"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.85520318),
        dec: Angle.Degrees(+65.03405504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119929"},
        {"Hipparcos Number", "HIP 67023"},
        {"Geneva Identification System", "GEN# +1.00119929"},
        {"Smithsonian Astrophysical Observation", "SAO 16156"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.02762237),
        dec: Angle.Degrees(+65.03544055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12882"},
        {"Hipparcos Number", "HIP 9997"},
        {"Celescope Catalog", "CEL 204"},
        {"Geneva Identification System", "GEN# +1.00012882"},
        {"Smithsonian Astrophysical Observation", "SAO 12145"},
        {"Wilson Evans Batten Catalogue", "WEB 2094"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.18931294),
        dec: Angle.Degrees(+65.03743284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10279 AB"},
        {"Henry Draper", "HD 153697"},
        {"Hipparcos Number", "HIP 82898"},
        {"Geneva Identification System", "GEN# +1.00153697"},
        {"Smithsonian Astrophysical Observation", "SAO 17285"},
        {"Wilson Evans Batten Catalogue", "WEB 14014"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.10548137),
        dec: Angle.Degrees(+65.03904488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14777"},
        {"Smithsonian Astrophysical Observation", "SAO 12634"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.68754535),
        dec: Angle.Degrees(+65.04450971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81108"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.48304037),
        dec: Angle.Degrees(+65.04506503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98988"},
        {"Hipparcos Number", "HIP 55662"},
        {"Geneva Identification System", "GEN# +1.00098988"},
        {"Smithsonian Astrophysical Observation", "SAO 15494"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.06556040),
        dec: Angle.Degrees(+65.04552470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92915"},
        {"Hipparcos Number", "HIP 52597"},
        {"Smithsonian Astrophysical Observation", "SAO 15278"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.32650128),
        dec: Angle.Degrees(+65.04783312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36194"},
        {"Hipparcos Number", "HIP 26186"},
        {"Smithsonian Astrophysical Observation", "SAO 13540"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.73173046),
        dec: Angle.Degrees(+65.04862917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28122"},
        {"Hipparcos Number", "HIP 21034"},
        {"Geneva Identification System", "GEN# +1.00028122"},
        {"Smithsonian Astrophysical Observation", "SAO 13163"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.64722303),
        dec: Angle.Degrees(+65.05112769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103974"},
        {"Smithsonian Astrophysical Observation", "SAO 19170"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.99865660),
        dec: Angle.Degrees(+65.05198473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103215"},
        {"Hipparcos Number", "HIP 57967"},
        {"Geneva Identification System", "GEN# +1.00103215"},
        {"Smithsonian Astrophysical Observation", "SAO 15654"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.34783024),
        dec: Angle.Degrees(+65.05266806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36117"},
        {"Smithsonian Astrophysical Observation", "SAO 14189"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.60069270),
        dec: Angle.Degrees(+65.05620698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40182"},
        {"Hipparcos Number", "HIP 28592"},
        {"Smithsonian Astrophysical Observation", "SAO 13684"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.52641510),
        dec: Angle.Degrees(+65.05982197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16280"},
        {"Smithsonian Astrophysical Observation", "SAO 12781"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.47605828),
        dec: Angle.Degrees(+65.06062727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216014"},
        {"Hipparcos Number", "HIP 112562"},
        {"Celescope Catalog", "CEL 5527"},
        {"Geneva Identification System", "GEN# +1.00216014"},
        {"Smithsonian Astrophysical Observation", "SAO 20247"},
        {"Wilson Evans Batten Catalogue", "WEB 20071"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.97060234),
        dec: Angle.Degrees(+65.06216715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32021"},
        {"Smithsonian Astrophysical Observation", "SAO 13922"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.34184309),
        dec: Angle.Degrees(+65.06752407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88149"},
        {"Hipparcos Number", "HIP 49972"},
        {"Smithsonian Astrophysical Observation", "SAO 15114"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.02760953),
        dec: Angle.Degrees(+65.06812251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 443"},
        {"Hipparcos Number", "HIP 755"},
        {"Geneva Identification System", "GEN# +1.00000443"},
        {"Smithsonian Astrophysical Observation", "SAO 11005"},
        {"Wilson Evans Batten Catalogue", "WEB 127"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.31906353),
        dec: Angle.Degrees(+65.07079864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147023"},
        {"Hipparcos Number", "HIP 79638"},
        {"Smithsonian Astrophysical Observation", "SAO 17011"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.77803173),
        dec: Angle.Degrees(+65.07214738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172556"},
        {"Hipparcos Number", "HIP 91190"},
        {"Smithsonian Astrophysical Observation", "SAO 17946"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.04426958),
        dec: Angle.Degrees(+65.07494587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7848"},
        {"Smithsonian Astrophysical Observation", "SAO 11905"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.22431509),
        dec: Angle.Degrees(+65.07875530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29438"},
        {"Smithsonian Astrophysical Observation", "SAO 13749"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.03174920),
        dec: Angle.Degrees(+65.08010948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166356"},
        {"Hipparcos Number", "HIP 88610"},
        {"Cincinnati Publication", "Ci 18 2402"},
        {"Geneva Identification System", "GEN# +1.00166356"},
        {"Smithsonian Astrophysical Observation", "SAO 17759"},
        {"Wilson Evans Batten Catalogue", "WEB 15007"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38397650),
        dec: Angle.Degrees(+65.08129076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4673"},
        {"Hipparcos Number", "HIP 3873"},
        {"Geneva Identification System", "GEN# +1.00004673"},
        {"Smithsonian Astrophysical Observation", "SAO 11416"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.42838509),
        dec: Angle.Degrees(+65.08280165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7976"},
        {"Hipparcos Number", "HIP 6296"},
        {"Smithsonian Astrophysical Observation", "SAO 11705"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.20247232),
        dec: Angle.Degrees(+65.08407267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19535"},
        {"Hipparcos Number", "HIP 14882"},
        {"Geneva Identification System", "GEN# +1.00019535"},
        {"Smithsonian Astrophysical Observation", "SAO 12648"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.02245319),
        dec: Angle.Degrees(+65.08437840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14153"},
        {"Hipparcos Number", "HIP 10888"},
        {"Geneva Identification System", "GEN# +1.00014153"},
        {"Smithsonian Astrophysical Observation", "SAO 12225"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.03159812),
        dec: Angle.Degrees(+65.08523565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4214"},
        {"Hipparcos Number", "HIP 3562"},
        {"Geneva Identification System", "GEN# +1.00004214"},
        {"Smithsonian Astrophysical Observation", "SAO 11370"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.38464496),
        dec: Angle.Degrees(+65.09315504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29361"},
        {"Hipparcos Number", "HIP 21854"},
        {"Smithsonian Astrophysical Observation", "SAO 13231"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.49431260),
        dec: Angle.Degrees(+65.09573715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59897"},
        {"Hipparcos Number", "HIP 37030"},
        {"Smithsonian Astrophysical Observation", "SAO 14250"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.14236417),
        dec: Angle.Degrees(+65.09622448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13033"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.87035322),
        dec: Angle.Degrees(+65.09677704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171361"},
        {"Hipparcos Number", "HIP 90645"},
        {"Geneva Identification System", "GEN# +1.00171361"},
        {"Smithsonian Astrophysical Observation", "SAO 17905"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.43220816),
        dec: Angle.Degrees(+65.10045162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18608"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.72951601),
        dec: Angle.Degrees(+65.10249332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12468"},
        {"Hipparcos Number", "HIP 9690"},
        {"Geneva Identification System", "GEN# +1.00012468"},
        {"Renson", "Renson 3190"},
        {"Smithsonian Astrophysical Observation", "SAO 12105"},
        {"Wilson Evans Batten Catalogue", "WEB 2036"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.16613087),
        dec: Angle.Degrees(+65.10356605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116188"},
        {"Hipparcos Number", "HIP 65076"},
        {"Fundamental Katalog 5th Edition", "FK5 5177"},
        {"Geneva Identification System", "GEN# +1.00116188"},
        {"Smithsonian Astrophysical Observation", "SAO 16050"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.09053270),
        dec: Angle.Degrees(+65.10602994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88983"},
        {"Hipparcos Number", "HIP 50448"},
        {"Fundamental Katalog 5th Edition", "FK5 1262"},
        {"Geneva Identification System", "GEN# +1.00088983"},
        {"Smithsonian Astrophysical Observation", "SAO 15135"},
        {"Wilson Evans Batten Catalogue", "WEB 9258"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.50896089),
        dec: Angle.Degrees(+65.10837358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85718"},
        {"Smithsonian Astrophysical Observation", "SAO 17511"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.73792401),
        dec: Angle.Degrees(+65.11029288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213405"},
        {"Hipparcos Number", "HIP 110998"},
        {"Geneva Identification System", "GEN# +1.00213405"},
        {"Smithsonian Astrophysical Observation", "SAO 20100"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.32306716),
        dec: Angle.Degrees(+65.11332947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36193"},
        {"Hipparcos Number", "HIP 26180"},
        {"Smithsonian Astrophysical Observation", "SAO 13538"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.72127276),
        dec: Angle.Degrees(+65.11490647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5775"},
        {"Hipparcos Number", "HIP 4714"},
        {"Smithsonian Astrophysical Observation", "SAO 11517"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13739403),
        dec: Angle.Degrees(+65.11507298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4523"},
        {"Hipparcos Number", "HIP 3755"},
        {"Geneva Identification System", "GEN# +1.00004523"},
        {"Smithsonian Astrophysical Observation", "SAO 11400"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.04855060),
        dec: Angle.Degrees(+65.11963799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20074"},
        {"Hipparcos Number", "HIP 15289"},
        {"Geneva Identification System", "GEN# +1.00020074"},
        {"Smithsonian Astrophysical Observation", "SAO 12685"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.31621730),
        dec: Angle.Degrees(+65.11967407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83021"},
        {"Hipparcos Number", "HIP 47315"},
        {"Smithsonian Astrophysical Observation", "SAO 14946"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.62319211),
        dec: Angle.Degrees(+65.12210996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114004"},
        {"Smithsonian Astrophysical Observation", "SAO 20410"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.32193689),
        dec: Angle.Degrees(+65.13065486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213087"},
        {"Hipparcos Number", "HIP 110817"},
        {"Celescope Catalog", "CEL 5477"},
        {"Fundamental Katalog 5th Edition", "FK5 3797"},
        {"Geneva Identification System", "GEN# +1.00213087"},
        {"Smithsonian Astrophysical Observation", "SAO 20075"},
        {"Wilson Evans Batten Catalogue", "WEB 19849"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77213047),
        dec: Angle.Degrees(+65.13227452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93427"},
        {"Hipparcos Number", "HIP 52877"},
        {"Geneva Identification System", "GEN# +1.00093427"},
        {"Smithsonian Astrophysical Observation", "SAO 15298"},
        {"Wilson Evans Batten Catalogue", "WEB 9626"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.20776058),
        dec: Angle.Degrees(+65.13247352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148362"},
        {"Hipparcos Number", "HIP 80265"},
        {"Smithsonian Astrophysical Observation", "SAO 17070"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78146951),
        dec: Angle.Degrees(+65.13249718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153597"},
        {"Hipparcos Number", "HIP 82860"},
        {"Geneva Identification System", "GEN# +1.00153597"},
        {"Smithsonian Astrophysical Observation", "SAO 17281"},
        {"Wilson Evans Batten Catalogue", "WEB 14005"},
    },
    visualMagnitude: 4.88,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.00566477),
        dec: Angle.Degrees(+65.13467204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65497"},
        {"Hipparcos Number", "HIP 39388"},
        {"Geneva Identification System", "GEN# +1.00065497"},
        {"Smithsonian Astrophysical Observation", "SAO 14413"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.78962440),
        dec: Angle.Degrees(+65.13592054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27022"},
        {"Hipparcos Number", "HIP 20266"},
        {"Fundamental Katalog 5th Edition", "FK5 2315"},
        {"Geneva Identification System", "GEN# +1.00027022"},
        {"Smithsonian Astrophysical Observation", "SAO 13098"},
        {"Wilson Evans Batten Catalogue", "WEB 3873"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.16818726),
        dec: Angle.Degrees(+65.14045287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36569"},
        {"Hipparcos Number", "HIP 26429"},
        {"Smithsonian Astrophysical Observation", "SAO 13551"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.37254650),
        dec: Angle.Degrees(+65.14181502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72037"},
        {"Hipparcos Number", "HIP 42080"},
        {"Geneva Identification System", "GEN# +1.00072037"},
        {"Renson", "Renson 19890"},
        {"Smithsonian Astrophysical Observation", "SAO 14590"},
        {"Wilson Evans Batten Catalogue", "WEB 8091"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.65078050),
        dec: Angle.Degrees(+65.14527349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197344"},
        {"Hipparcos Number", "HIP 101938"},
        {"Geneva Identification System", "GEN# +1.00197344"},
        {"Smithsonian Astrophysical Observation", "SAO 18975"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.86092706),
        dec: Angle.Degrees(+65.14558160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225179"},
        {"Hipparcos Number", "HIP 336"},
        {"Geneva Identification System", "GEN# +1.00225179"},
        {"Smithsonian Astrophysical Observation", "SAO 10955"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06656723),
        dec: Angle.Degrees(+65.15296110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37882",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6319 A"},
        {"Henry Draper", "HD 61907A"},
        {"Hipparcos Number", "HIP 37882"},
        {"Smithsonian Astrophysical Observation", "SAO 14311"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46765055),
        dec: Angle.Degrees(+65.15381687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18892"},
        {"Hipparcos Number", "HIP 14393"},
        {"Smithsonian Astrophysical Observation", "SAO 12598"},
        {"Wilson Evans Batten Catalogue", "WEB 2809"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.42062605),
        dec: Angle.Degrees(+65.15677928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38655"},
        {"Hipparcos Number", "HIP 27714"},
        {"Smithsonian Astrophysical Observation", "SAO 13632"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.03273129),
        dec: Angle.Degrees(+65.15784858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37884",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6319 B"},
        {"Henry Draper", "HD 61907B"},
        {"Hipparcos Number", "HIP 37884"},
        {"Smithsonian Astrophysical Observation", "SAO 14312"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46872043),
        dec: Angle.Degrees(+65.15794565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126795"},
        {"Hipparcos Number", "HIP 70473"},
        {"Geneva Identification System", "GEN# +1.00126795"},
        {"Smithsonian Astrophysical Observation", "SAO 16373"},
        {"Wilson Evans Batten Catalogue", "WEB 12226"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.21281842),
        dec: Angle.Degrees(+65.15842263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10013"},
        {"Hipparcos Number", "HIP 7744"},
        {"Cincinnati Publication", "Ci 18 225"},
        {"Geneva Identification System", "GEN# +1.00010013"},
        {"Smithsonian Astrophysical Observation", "SAO 11897"},
        {"Wilson Evans Batten Catalogue", "WEB 1661"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.92607729),
        dec: Angle.Degrees(+65.16003065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 252.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45231"},
        {"Hipparcos Number", "HIP 31060"},
        {"Cincinnati Publication", "Ci 18 798"},
        {"Geneva Identification System", "GEN# +1.00045231"},
        {"Smithsonian Astrophysical Observation", "SAO 13860"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.76648440),
        dec: Angle.Degrees(+65.16177967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14216"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.83173086),
        dec: Angle.Degrees(+65.16218355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106575"},
        {"Hipparcos Number", "HIP 59759"},
        {"Smithsonian Astrophysical Observation", "SAO 15750"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.81452487),
        dec: Angle.Degrees(+65.16735938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191805"},
        {"Hipparcos Number", "HIP 99147"},
        {"Geneva Identification System", "GEN# +1.00191805"},
        {"Smithsonian Astrophysical Observation", "SAO 18727"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.93149252),
        dec: Angle.Degrees(+65.16801440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61831"},
        {"Smithsonian Astrophysical Observation", "SAO 15862"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.07078812),
        dec: Angle.Degrees(+65.16894393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207684"},
        {"Hipparcos Number", "HIP 107648"},
        {"Smithsonian Astrophysical Observation", "SAO 19655"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.06243089),
        dec: Angle.Degrees(+65.17066009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8928"},
        {"Hipparcos Number", "HIP 6974"},
        {"Smithsonian Astrophysical Observation", "SAO 11776"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.44463773),
        dec: Angle.Degrees(+65.17106561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25354"},
        {"Geneva Identification System", "GEN# +6.20030460"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.33528573),
        dec: Angle.Degrees(+65.18176628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53885"},
        {"Smithsonian Astrophysical Observation", "SAO 15362"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.37005737),
        dec: Angle.Degrees(+65.18393519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116107"},
        {"Hipparcos Number", "HIP 65035"},
        {"Smithsonian Astrophysical Observation", "SAO 16044"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.96255587),
        dec: Angle.Degrees(+65.18437690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191736"},
        {"Hipparcos Number", "HIP 99125"},
        {"Geneva Identification System", "GEN# +1.00191736"},
        {"Smithsonian Astrophysical Observation", "SAO 18723"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.86147383),
        dec: Angle.Degrees(+65.18739085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75182"},
        {"Geneva Identification System", "GEN# +0.06501050"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.46006395),
        dec: Angle.Degrees(+65.18766176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218695"},
        {"Hipparcos Number", "HIP 114309"},
        {"Smithsonian Astrophysical Observation", "SAO 20451"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.25588272),
        dec: Angle.Degrees(+65.19303688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223804"},
        {"Hipparcos Number", "HIP 117742"},
        {"Smithsonian Astrophysical Observation", "SAO 20910"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.18692831),
        dec: Angle.Degrees(+65.19839491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58811"},
        {"Smithsonian Astrophysical Observation", "SAO 15698"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.93666526),
        dec: Angle.Degrees(+65.20397193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178473"},
        {"Hipparcos Number", "HIP 93653"},
        {"Smithsonian Astrophysical Observation", "SAO 18143"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.06131198),
        dec: Angle.Degrees(+65.20539165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139306"},
        {"Hipparcos Number", "HIP 76176"},
        {"Smithsonian Astrophysical Observation", "SAO 16766"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.38816217),
        dec: Angle.Degrees(+65.20680467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24568"},
        {"Smithsonian Astrophysical Observation", "SAO 13433"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.06095165),
        dec: Angle.Degrees(+65.20798434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218723"},
        {"Hipparcos Number", "HIP 114327"},
        {"Celescope Catalog", "CEL 5569"},
        {"Geneva Identification System", "GEN# +1.00218723"},
        {"Smithsonian Astrophysical Observation", "SAO 20456"},
        {"Wilson Evans Batten Catalogue", "WEB 20299"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.31810451),
        dec: Angle.Degrees(+65.21141366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67376"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13797646),
        dec: Angle.Degrees(+65.21273687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190186"},
        {"Hipparcos Number", "HIP 98403"},
        {"Smithsonian Astrophysical Observation", "SAO 18644"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.91333666),
        dec: Angle.Degrees(+65.21412055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73703"},
        {"Hipparcos Number", "HIP 42815"},
        {"Smithsonian Astrophysical Observation", "SAO 14639"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.86239050),
        dec: Angle.Degrees(+65.21519563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103351"},
        {"Hipparcos Number", "HIP 58045"},
        {"Smithsonian Astrophysical Observation", "SAO 15655"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.56764858),
        dec: Angle.Degrees(+65.21941233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19194"},
        {"Smithsonian Astrophysical Observation", "SAO 13021"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.69988131),
        dec: Angle.Degrees(+65.22182420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40060"},
        {"Wilson Evans Batten Catalogue", "WEB 7817"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.74886434),
        dec: Angle.Degrees(+65.22280554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214072"},
        {"Hipparcos Number", "HIP 111387"},
        {"Smithsonian Astrophysical Observation", "SAO 20155"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.49338661),
        dec: Angle.Degrees(+65.22305609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92526",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11795 AB"},
        {"Hipparcos Number", "HIP 92526"},
        {"Smithsonian Astrophysical Observation", "SAO 18050"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84582680),
        dec: Angle.Degrees(+65.22759841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61553"},
        {"Smithsonian Astrophysical Observation", "SAO 15837"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.18490943),
        dec: Angle.Degrees(+65.23319112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207884"},
        {"Hipparcos Number", "HIP 107755"},
        {"Smithsonian Astrophysical Observation", "SAO 19670"},
        {"Wilson Evans Batten Catalogue", "WEB 19434"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.43850581),
        dec: Angle.Degrees(+65.23347333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85345"},
        {"Smithsonian Astrophysical Observation", "SAO 17488"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.60020844),
        dec: Angle.Degrees(+65.23630285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151668"},
        {"Hipparcos Number", "HIP 81934"},
        {"Smithsonian Astrophysical Observation", "SAO 17206"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.05839078),
        dec: Angle.Degrees(+65.23744801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27394"},
        {"Hipparcos Number", "HIP 20518"},
        {"Geneva Identification System", "GEN# +1.00027394"},
        {"Smithsonian Astrophysical Observation", "SAO 13124"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.95198319),
        dec: Angle.Degrees(+65.23837696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33334"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.99416865),
        dec: Angle.Degrees(+65.23958980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14414"},
        {"Hipparcos Number", "HIP 11067"},
        {"Geneva Identification System", "GEN# +1.00014414"},
        {"Smithsonian Astrophysical Observation", "SAO 12247"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.61142677),
        dec: Angle.Degrees(+65.24206977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103690"},
        {"Hipparcos Number", "HIP 58232"},
        {"Geneva Identification System", "GEN# +1.00103690"},
        {"Smithsonian Astrophysical Observation", "SAO 15663"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.15668435),
        dec: Angle.Degrees(+65.24295205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100446"},
        {"Hipparcos Number", "HIP 56423"},
        {"Geneva Identification System", "GEN# +1.00100446"},
        {"Smithsonian Astrophysical Observation", "SAO 15554"},
        {"Wilson Evans Batten Catalogue", "WEB 10139"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.52971937),
        dec: Angle.Degrees(+65.24305731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94257"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.79292971),
        dec: Angle.Degrees(+65.24523145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146989"},
        {"Hipparcos Number", "HIP 79624"},
        {"Smithsonian Astrophysical Observation", "SAO 17010"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.72708585),
        dec: Angle.Degrees(+65.24624016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85515"},
        {"Hipparcos Number", "HIP 48612"},
        {"Smithsonian Astrophysical Observation", "SAO 15021"},
        {"Wilson Evans Batten Catalogue", "WEB 9049"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.70448169),
        dec: Angle.Degrees(+65.25024884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34907"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.33672152),
        dec: Angle.Degrees(+65.25061416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26810"},
        {"Hipparcos Number", "HIP 20119"},
        {"Geneva Identification System", "GEN# +1.00026810"},
        {"Smithsonian Astrophysical Observation", "SAO 13089"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.70986429),
        dec: Angle.Degrees(+65.25183237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130914"},
        {"Hipparcos Number", "HIP 72351"},
        {"Geneva Identification System", "GEN# +1.00130914"},
        {"Smithsonian Astrophysical Observation", "SAO 16503"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.91926303),
        dec: Angle.Degrees(+65.25185842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118388"},
        {"Hipparcos Number", "HIP 66263"},
        {"Smithsonian Astrophysical Observation", "SAO 16114"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.70984289),
        dec: Angle.Degrees(+65.25517659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214471"},
        {"Hipparcos Number", "HIP 111617"},
        {"Smithsonian Astrophysical Observation", "SAO 20176"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.17758470),
        dec: Angle.Degrees(+65.25743021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176598"},
        {"Hipparcos Number", "HIP 92969"},
        {"Fundamental Katalog 5th Edition", "FK5 3514"},
        {"Geneva Identification System", "GEN# +1.00176598"},
        {"Smithsonian Astrophysical Observation", "SAO 18079"},
        {"Wilson Evans Batten Catalogue", "WEB 16102"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.10725292),
        dec: Angle.Degrees(+65.25815397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13829"},
        {"Hipparcos Number", "HIP 10681"},
        {"Geneva Identification System", "GEN# +1.00013829"},
        {"Smithsonian Astrophysical Observation", "SAO 12206"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.35718753),
        dec: Angle.Degrees(+65.26213086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215024"},
        {"Hipparcos Number", "HIP 111950"},
        {"Celescope Catalog", "CEL 5510"},
        {"Smithsonian Astrophysical Observation", "SAO 20201"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.15862705),
        dec: Angle.Degrees(+65.26268381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28950"},
        {"Hipparcos Number", "HIP 21597"},
        {"Smithsonian Astrophysical Observation", "SAO 13209"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.55193492),
        dec: Angle.Degrees(+65.26559355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22468"},
        {"Smithsonian Astrophysical Observation", "SAO 13281"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.52828660),
        dec: Angle.Degrees(+65.26740355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117711"},
        {"Smithsonian Astrophysical Observation", "SAO 20904"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.09920544),
        dec: Angle.Degrees(+65.26925035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2619"},
        {"Hipparcos Number", "HIP 2390"},
        {"Geneva Identification System", "GEN# +1.00002619"},
        {"Smithsonian Astrophysical Observation", "SAO 11233"},
        {"Wilson Evans Batten Catalogue", "WEB 439"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.61804494),
        dec: Angle.Degrees(+65.27216229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181142"},
        {"Hipparcos Number", "HIP 94562"},
        {"Smithsonian Astrophysical Observation", "SAO 18237"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.68099252),
        dec: Angle.Degrees(+65.27278710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119581"},
        {"Hipparcos Number", "HIP 66857"},
        {"Smithsonian Astrophysical Observation", "SAO 16143"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.52637133),
        dec: Angle.Degrees(+65.27308282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95688"},
        {"Smithsonian Astrophysical Observation", "SAO 18351"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.94580848),
        dec: Angle.Degrees(+65.27407758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112385"},
        {"Smithsonian Astrophysical Observation", "SAO 20233"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.42799799),
        dec: Angle.Degrees(+65.27412701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139607"},
        {"Hipparcos Number", "HIP 76305"},
        {"Smithsonian Astrophysical Observation", "SAO 16778"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.80867172),
        dec: Angle.Degrees(+65.27767711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94667"},
        {"Hipparcos Number", "HIP 53535"},
        {"Geneva Identification System", "GEN# +1.00094667"},
        {"Smithsonian Astrophysical Observation", "SAO 15342"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.28844574),
        dec: Angle.Degrees(+65.27832281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31067"},
        {"Hipparcos Number", "HIP 23047"},
        {"Geneva Identification System", "GEN# +1.00031067"},
        {"Smithsonian Astrophysical Observation", "SAO 13316"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.38151838),
        dec: Angle.Degrees(+65.27837820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45767"},
        {"Hipparcos Number", "HIP 31333"},
        {"Geneva Identification System", "GEN# +1.00045767"},
        {"Smithsonian Astrophysical Observation", "SAO 13879"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.55735441),
        dec: Angle.Degrees(+65.28675379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142961"},
        {"Hipparcos Number", "HIP 77824"},
        {"Geneva Identification System", "GEN# +1.00142961"},
        {"Smithsonian Astrophysical Observation", "SAO 16888"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37092127),
        dec: Angle.Degrees(+65.28816978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73426"},
        {"Hipparcos Number", "HIP 42694"},
        {"Smithsonian Astrophysical Observation", "SAO 14626"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.52592212),
        dec: Angle.Degrees(+65.29018482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61250"},
        {"Hipparcos Number", "HIP 37604"},
        {"Geneva Identification System", "GEN# +1.00061250"},
        {"Renson", "Renson 16750"},
        {"Smithsonian Astrophysical Observation", "SAO 14292"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.73489786),
        dec: Angle.Degrees(+65.29069303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6081"},
        {"Wilson Evans Batten Catalogue", "WEB 1369"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.51124716),
        dec: Angle.Degrees(+65.29161742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55783"},
        {"Smithsonian Astrophysical Observation", "SAO 15501"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.44762948),
        dec: Angle.Degrees(+65.29459659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48209"},
        {"Cincinnati Publication", "Ci 20 548"},
        {"Geneva Identification System", "GEN# +0.06500737"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.43088135),
        dec: Angle.Degrees(+65.30480497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -423.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105807"},
        {"Smithsonian Astrophysical Observation", "SAO 19403"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.42334715),
        dec: Angle.Degrees(+65.30832376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20567"},
        {"Hipparcos Number", "HIP 15698"},
        {"Geneva Identification System", "GEN# +1.00020567"},
        {"Smithsonian Astrophysical Observation", "SAO 12720"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.55419950),
        dec: Angle.Degrees(+65.31505203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16067"},
        {"Hipparcos Number", "HIP 12262"},
        {"Geneva Identification System", "GEN# +1.00016067"},
        {"Smithsonian Astrophysical Observation", "SAO 12363"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.47076838),
        dec: Angle.Degrees(+65.31883054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15467 AB"},
        {"Henry Draper", "HD 208682"},
        {"Hipparcos Number", "HIP 108226"},
        {"Geneva Identification System", "GEN# +1.00208682J"},
        {"Smithsonian Astrophysical Observation", "SAO 19742"},
        {"Wilson Evans Batten Catalogue", "WEB 19506"},
    },
    visualMagnitude: 5.84,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.87912929),
        dec: Angle.Degrees(+65.32081194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169531"},
        {"Hipparcos Number", "HIP 89865"},
        {"Geneva Identification System", "GEN# +1.00169531"},
        {"Smithsonian Astrophysical Observation", "SAO 17860"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08024471),
        dec: Angle.Degrees(+65.32182059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90334"},
        {"Smithsonian Astrophysical Observation", "SAO 17886"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.47276220),
        dec: Angle.Degrees(+65.32618206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130460"},
        {"Hipparcos Number", "HIP 72130"},
        {"Geneva Identification System", "GEN# +1.00130460"},
        {"Smithsonian Astrophysical Observation", "SAO 16485"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.31989513),
        dec: Angle.Degrees(+65.32989229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87326"},
        {"Hipparcos Number", "HIP 49517"},
        {"Smithsonian Astrophysical Observation", "SAO 15079"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.65344524),
        dec: Angle.Degrees(+65.32990649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60041"},
        {"Hipparcos Number", "HIP 37078"},
        {"Geneva Identification System", "GEN# +1.00060041"},
        {"Smithsonian Astrophysical Observation", "SAO 14256"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.29098398),
        dec: Angle.Degrees(+65.33045043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86469"},
        {"Smithsonian Astrophysical Observation", "SAO 17598"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.00908775),
        dec: Angle.Degrees(+65.33335845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215371"},
        {"Hipparcos Number", "HIP 112169"},
        {"Celescope Catalog", "CEL 5517"},
        {"Geneva Identification System", "GEN# +1.00215371"},
        {"Smithsonian Astrophysical Observation", "SAO 20214"},
        {"Wilson Evans Batten Catalogue", "WEB 20020"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.76820874),
        dec: Angle.Degrees(+65.33625595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86186"},
        {"Hipparcos Number", "HIP 48969"},
        {"Smithsonian Astrophysical Observation", "SAO 15039"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.84144639),
        dec: Angle.Degrees(+65.33794586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118050"},
        {"Hipparcos Number", "HIP 66062"},
        {"Smithsonian Astrophysical Observation", "SAO 16105"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14476541),
        dec: Angle.Degrees(+65.33908976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12243",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1976 AB"},
        {"Henry Draper", "HD 16036"},
        {"Hipparcos Number", "HIP 12243"},
        {"Smithsonian Astrophysical Observation", "SAO 12362"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.41468958),
        dec: Angle.Degrees(+65.34056588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6893"},
        {"Smithsonian Astrophysical Observation", "SAO 11773"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.18897760),
        dec: Angle.Degrees(+65.34168879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220550"},
        {"Hipparcos Number", "HIP 115503"},
        {"Geneva Identification System", "GEN# +1.00220550"},
        {"Smithsonian Astrophysical Observation", "SAO 20602"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.96482233),
        dec: Angle.Degrees(+65.34340428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13035"},
        {"Hipparcos Number", "HIP 10113"},
        {"Geneva Identification System", "GEN# +1.00013035"},
        {"Smithsonian Astrophysical Observation", "SAO 12150"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.52360824),
        dec: Angle.Degrees(+65.34840504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105485"},
        {"Hipparcos Number", "HIP 59207"},
        {"Geneva Identification System", "GEN# +1.00105485"},
        {"Smithsonian Astrophysical Observation", "SAO 15723"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.13915111),
        dec: Angle.Degrees(+65.34963503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121953"},
        {"Hipparcos Number", "HIP 68085"},
        {"Geneva Identification System", "GEN# +1.00121953"},
        {"Smithsonian Astrophysical Observation", "SAO 16225"},
        {"Wilson Evans Batten Catalogue", "WEB 11952"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.10522279),
        dec: Angle.Degrees(+65.35143992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22043"},
        {"Hipparcos Number", "HIP 16875"},
        {"Fundamental Katalog 5th Edition", "FK5 4325"},
        {"Geneva Identification System", "GEN# +1.00022043"},
        {"Smithsonian Astrophysical Observation", "SAO 12832"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.28432834),
        dec: Angle.Degrees(+65.35365627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31486"},
        {"Hipparcos Number", "HIP 23324"},
        {"Smithsonian Astrophysical Observation", "SAO 13336"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.25852328),
        dec: Angle.Degrees(+65.36280550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126168"},
        {"Hipparcos Number", "HIP 70144"},
        {"Geneva Identification System", "GEN# +1.00126168"},
        {"Smithsonian Astrophysical Observation", "SAO 16351"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.28880465),
        dec: Angle.Degrees(+65.36346783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221035"},
        {"Hipparcos Number", "HIP 115823"},
        {"Smithsonian Astrophysical Observation", "SAO 20645"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.96890410),
        dec: Angle.Degrees(+65.36565196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107155"},
        {"Hipparcos Number", "HIP 60053"},
        {"Smithsonian Astrophysical Observation", "SAO 15769"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.73845913),
        dec: Angle.Degrees(+65.36729309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90845"},
        {"Smithsonian Astrophysical Observation", "SAO 17921"},
        {"Wilson Evans Batten Catalogue", "WEB 15575"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98756169),
        dec: Angle.Degrees(+65.37116289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206243"},
        {"Hipparcos Number", "HIP 106820"},
        {"Smithsonian Astrophysical Observation", "SAO 19545"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.51471461),
        dec: Angle.Degrees(+65.37427860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44903"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22212314),
        dec: Angle.Degrees(+65.37560723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216765"},
        {"Hipparcos Number", "HIP 113093"},
        {"Geneva Identification System", "GEN# +1.00216765"},
        {"Smithsonian Astrophysical Observation", "SAO 20310"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.54986887),
        dec: Angle.Degrees(+65.37980152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167470"},
        {"Hipparcos Number", "HIP 89048"},
        {"Fundamental Katalog 5th Edition", "FK5 5603"},
        {"Smithsonian Astrophysical Observation", "SAO 17801"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.63254499),
        dec: Angle.Degrees(+65.38062413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2110"},
        {"Hipparcos Number", "HIP 2037"},
        {"Smithsonian Astrophysical Observation", "SAO 11180"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.46776238),
        dec: Angle.Degrees(+65.38354358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55317"},
        {"Smithsonian Astrophysical Observation", "SAO 15474"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92340272),
        dec: Angle.Degrees(+65.39325902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5491"},
        {"Hipparcos Number", "HIP 4522"},
        {"Smithsonian Astrophysical Observation", "SAO 11495"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.47954051),
        dec: Angle.Degrees(+65.39349644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69328"},
        {"Hipparcos Number", "HIP 40882"},
        {"Geneva Identification System", "GEN# +1.00069328"},
        {"Smithsonian Astrophysical Observation", "SAO 14506"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.13893474),
        dec: Angle.Degrees(+65.39391927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128385"},
        {"Hipparcos Number", "HIP 71192"},
        {"Fundamental Katalog 5th Edition", "FK5 5287"},
        {"Geneva Identification System", "GEN# +1.00128385"},
        {"Smithsonian Astrophysical Observation", "SAO 16431"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.39778281),
        dec: Angle.Degrees(+65.39531602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70354"},
        {"Smithsonian Astrophysical Observation", "SAO 16368"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.92064385),
        dec: Angle.Degrees(+65.39542214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106874"},
        {"Smithsonian Astrophysical Observation", "SAO 19552"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.69874786),
        dec: Angle.Degrees(+65.39613050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143665"},
        {"Hipparcos Number", "HIP 78165"},
        {"Cincinnati Publication", "Ci 18 2141"},
        {"Geneva Identification System", "GEN# +1.00143665"},
        {"Smithsonian Astrophysical Observation", "SAO 16902"},
        {"Wilson Evans Batten Catalogue", "WEB 13218"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.41630887),
        dec: Angle.Degrees(+65.39708813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196229"},
        {"Hipparcos Number", "HIP 101325"},
        {"Smithsonian Astrophysical Observation", "SAO 18918"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.05632794),
        dec: Angle.Degrees(+65.39917125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40955"},
        {"Hipparcos Number", "HIP 28989"},
        {"Smithsonian Astrophysical Observation", "SAO 13717"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.76046974),
        dec: Angle.Degrees(+65.40183370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75691"},
    },
    visualMagnitude: 12.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.94355923),
        dec: Angle.Degrees(+65.40374165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82472"},
        {"Hipparcos Number", "HIP 47037"},
        {"Smithsonian Astrophysical Observation", "SAO 14930"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.79757250),
        dec: Angle.Degrees(+65.40916717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11744"},
        {"Hipparcos Number", "HIP 9124"},
        {"Geneva Identification System", "GEN# +1.00011744"},
        {"Smithsonian Astrophysical Observation", "SAO 12051"},
        {"Wilson Evans Batten Catalogue", "WEB 1915"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.40282201),
        dec: Angle.Degrees(+65.41008560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136728"},
        {"Hipparcos Number", "HIP 74913"},
        {"Smithsonian Astrophysical Observation", "SAO 16680"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63783341),
        dec: Angle.Degrees(+65.42094623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219459"},
        {"Hipparcos Number", "HIP 114769"},
        {"Geneva Identification System", "GEN# +1.00219459"},
        {"Smithsonian Astrophysical Observation", "SAO 20510"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.72817330),
        dec: Angle.Degrees(+65.42425671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11754"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.91460237),
        dec: Angle.Degrees(+65.42493260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110864"},
        {"Smithsonian Astrophysical Observation", "SAO 20083"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.92163550),
        dec: Angle.Degrees(+65.43033068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56196"},
        {"Hipparcos Number", "HIP 35599"},
        {"Cincinnati Publication", "Ci 18 872"},
        {"Geneva Identification System", "GEN# +1.00056196"},
        {"Smithsonian Astrophysical Observation", "SAO 14154"},
        {"Wilson Evans Batten Catalogue", "WEB 7092"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.19888247),
        dec: Angle.Degrees(+65.43062791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34910"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.34373356),
        dec: Angle.Degrees(+65.43218968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209317"},
        {"Hipparcos Number", "HIP 108603"},
        {"Smithsonian Astrophysical Observation", "SAO 19789"},
        {"Wilson Evans Batten Catalogue", "WEB 19545"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.01408533),
        dec: Angle.Degrees(+65.43277697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222199"},
        {"Hipparcos Number", "HIP 116622"},
        {"Smithsonian Astrophysical Observation", "SAO 20741"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.50678655),
        dec: Angle.Degrees(+65.43395453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94161"},
        {"Hipparcos Number", "HIP 53263"},
        {"Smithsonian Astrophysical Observation", "SAO 15322"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.39732927),
        dec: Angle.Degrees(+65.43467261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171653"},
        {"Hipparcos Number", "HIP 90780"},
        {"Geneva Identification System", "GEN# +1.00171653"},
        {"Renson", "Renson 48100"},
        {"Smithsonian Astrophysical Observation", "SAO 17912"},
        {"Wilson Evans Batten Catalogue", "WEB 15555"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.81213366),
        dec: Angle.Degrees(+65.43585416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61521"},
        {"Hipparcos Number", "HIP 37703"},
        {"Smithsonian Astrophysical Observation", "SAO 14305"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.02360146),
        dec: Angle.Degrees(+65.43813081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63076",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Taiyi"},
        {"Henry Draper", "HD 112429"},
        {"Hipparcos Number", "HIP 63076"},
        {"Fundamental Katalog 5th Edition", "FK5 486"},
        {"Geneva Identification System", "GEN# +1.00112429"},
        {"Smithsonian Astrophysical Observation", "SAO 15941"},
        {"Wilson Evans Batten Catalogue", "WEB 11186"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.86897970),
        dec: Angle.Degrees(+65.43854743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85817"},
        {"Smithsonian Astrophysical Observation", "SAO 17524"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.03020399),
        dec: Angle.Degrees(+65.44215247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69433"},
        {"Hipparcos Number", "HIP 40918"},
        {"Geneva Identification System", "GEN# +1.00069433"},
        {"Smithsonian Astrophysical Observation", "SAO 14509"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.26567712),
        dec: Angle.Degrees(+65.44266046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101180"},
        {"Cincinnati Publication", "Ci 20 1213"},
        {"Wilson Evans Batten Catalogue", "WEB 18276"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.63092880),
        dec: Angle.Degrees(+65.44886952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 443.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 284.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91097"},
        {"Hipparcos Number", "HIP 51638"},
        {"Geneva Identification System", "GEN# +1.00091097"},
        {"Smithsonian Astrophysical Observation", "SAO 15213"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.24469971),
        dec: Angle.Degrees(+65.45282605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74242"},
        {"Hipparcos Number", "HIP 43094"},
        {"Geneva Identification System", "GEN# +1.00074242"},
        {"Smithsonian Astrophysical Observation", "SAO 14654"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.65318253),
        dec: Angle.Degrees(+65.45527341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62066"},
        {"Hipparcos Number", "HIP 37949"},
        {"Fundamental Katalog 5th Edition", "FK5 2602"},
        {"Geneva Identification System", "GEN# +1.00062066"},
        {"Smithsonian Astrophysical Observation", "SAO 14321"},
        {"Wilson Evans Batten Catalogue", "WEB 7489"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.66682971),
        dec: Angle.Degrees(+65.45563092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20796"},
        {"Hipparcos Number", "HIP 15899"},
        {"Smithsonian Astrophysical Observation", "SAO 12744"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.20254369),
        dec: Angle.Degrees(+65.45806560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44270"},
        {"Hipparcos Number", "HIP 30596"},
        {"Smithsonian Astrophysical Observation", "SAO 13832"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.44912854),
        dec: Angle.Degrees(+65.46002285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52805",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7925 A"},
        {"Henry Draper", "HD 93270"},
        {"Hipparcos Number", "HIP 52805"},
        {"Geneva Identification System", "GEN# +1.00093270A"},
        {"Smithsonian Astrophysical Observation", "SAO 15292"},
        {"Wilson Evans Batten Catalogue", "WEB 9612"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.93277022),
        dec: Angle.Degrees(+65.46010924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79527"},
        {"Hipparcos Number", "HIP 45616"},
        {"Smithsonian Astrophysical Observation", "SAO 14832"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.47017571),
        dec: Angle.Degrees(+65.46167892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14999"},
        {"Hipparcos Number", "HIP 11475"},
        {"Smithsonian Astrophysical Observation", "SAO 12290"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.00204986),
        dec: Angle.Degrees(+65.46354278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213086"},
        {"Hipparcos Number", "HIP 110814"},
        {"Fundamental Katalog 5th Edition", "FK5 5980"},
        {"Geneva Identification System", "GEN# +1.00213086"},
        {"Smithsonian Astrophysical Observation", "SAO 20076"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77077579),
        dec: Angle.Degrees(+65.46619108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111161",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16025 AB"},
        {"Hipparcos Number", "HIP 111161"},
        {"Geneva Identification System", "GEN# +0.06401677J"},
        {"Smithsonian Astrophysical Observation", "SAO 20125"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.80656011),
        dec: Angle.Degrees(+65.46625108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110007"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.21655368),
        dec: Angle.Degrees(+65.46991142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108649"},
        {"Hipparcos Number", "HIP 60858"},
        {"Geneva Identification System", "GEN# +1.00108649"},
        {"Smithsonian Astrophysical Observation", "SAO 15808"},
        {"Wilson Evans Batten Catalogue", "WEB 10831"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.09763400),
        dec: Angle.Degrees(+65.47368458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111763"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.59257456),
        dec: Angle.Degrees(+65.47541033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133229"},
        {"Hipparcos Number", "HIP 73403"},
        {"Smithsonian Astrophysical Observation", "SAO 16570"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.01121514),
        dec: Angle.Degrees(+65.47626809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89839"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.00480517),
        dec: Angle.Degrees(+65.47830931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12370"},
        {"Smithsonian Astrophysical Observation", "SAO 12370"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.80548398),
        dec: Angle.Degrees(+65.48017210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12762"},
        {"Hipparcos Number", "HIP 9906"},
        {"Geneva Identification System", "GEN# +1.00012762"},
        {"Smithsonian Astrophysical Observation", "SAO 12137"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.88243860),
        dec: Angle.Degrees(+65.48212385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13856"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.59885222),
        dec: Angle.Degrees(+65.48442934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130944"},
        {"Hipparcos Number", "HIP 72343"},
        {"Geneva Identification System", "GEN# +1.00130944"},
        {"Smithsonian Astrophysical Observation", "SAO 16502"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.90175855),
        dec: Angle.Degrees(+65.48667272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172569"},
        {"Hipparcos Number", "HIP 91196"},
        {"Fundamental Katalog 5th Edition", "FK5 701"},
        {"Geneva Identification System", "GEN# +1.00172569"},
        {"Renson", "Renson 48340"},
        {"Smithsonian Astrophysical Observation", "SAO 17947"},
        {"Wilson Evans Batten Catalogue", "WEB 15660"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.05518973),
        dec: Angle.Degrees(+65.48851424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43297"},
        {"Hipparcos Number", "HIP 30130"},
        {"Cincinnati Publication", "Ci 18 782"},
        {"Smithsonian Astrophysical Observation", "SAO 13805"},
        {"Wilson Evans Batten Catalogue", "WEB 5992"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.10261886),
        dec: Angle.Degrees(+65.49855489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70028"},
        {"Hipparcos Number", "HIP 41158"},
        {"Smithsonian Astrophysical Observation", "SAO 14530"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.96471251),
        dec: Angle.Degrees(+65.50030297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212957"},
        {"Hipparcos Number", "HIP 110728"},
        {"Smithsonian Astrophysical Observation", "SAO 20065"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.50996576),
        dec: Angle.Degrees(+65.50334363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3554"},
        {"Hipparcos Number", "HIP 3089"},
        {"Smithsonian Astrophysical Observation", "SAO 11312"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.82842932),
        dec: Angle.Degrees(+65.50399477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15078"},
        {"Hipparcos Number", "HIP 11545"},
        {"Smithsonian Astrophysical Observation", "SAO 12297"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.19466191),
        dec: Angle.Degrees(+65.50429481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84362"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.71009090),
        dec: Angle.Degrees(+65.50760534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115365"},
        {"Smithsonian Astrophysical Observation", "SAO 20586"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.51783545),
        dec: Angle.Degrees(+65.51215802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9026"},
        {"Smithsonian Astrophysical Observation", "SAO 12045"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.07094845),
        dec: Angle.Degrees(+65.51748894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104462"},
        {"Smithsonian Astrophysical Observation", "SAO 19226"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.40707323),
        dec: Angle.Degrees(+65.51903557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25425"},
        {"Hipparcos Number", "HIP 19177"},
        {"Geneva Identification System", "GEN# +1.00025425"},
        {"Renson", "Renson 6480"},
        {"Smithsonian Astrophysical Observation", "SAO 13015"},
        {"Wilson Evans Batten Catalogue", "WEB 3680"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.66171942),
        dec: Angle.Degrees(+65.52085977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210770"},
        {"Hipparcos Number", "HIP 109453"},
        {"Celescope Catalog", "CEL 5448"},
        {"Geneva Identification System", "GEN# +1.00210770"},
        {"Smithsonian Astrophysical Observation", "SAO 19919"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.61632685),
        dec: Angle.Degrees(+65.52377158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40034"},
        {"Hipparcos Number", "HIP 28523"},
        {"Smithsonian Astrophysical Observation", "SAO 13675"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.31291408),
        dec: Angle.Degrees(+65.52554508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75972"},
        {"Hipparcos Number", "HIP 43928"},
        {"Geneva Identification System", "GEN# +1.00075972"},
        {"Smithsonian Astrophysical Observation", "SAO 14706"},
        {"Wilson Evans Batten Catalogue", "WEB 8446"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.22792951),
        dec: Angle.Degrees(+65.52600002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23475"},
        {"Hipparcos Number", "HIP 17884"},
        {"Geneva Identification System", "GEN# +1.00023475"},
        {"Smithsonian Astrophysical Observation", "SAO 12916"},
        {"Wilson Evans Batten Catalogue", "WEB 3436"},
    },
    visualMagnitude: 4.39,
    bvColour: 1.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.38035594),
        dec: Angle.Degrees(+65.52600645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92067"},
        {"Hipparcos Number", "HIP 52179"},
        {"Smithsonian Astrophysical Observation", "SAO 15249"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.89829767),
        dec: Angle.Degrees(+65.52710649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212956"},
        {"Hipparcos Number", "HIP 110727"},
        {"Smithsonian Astrophysical Observation", "SAO 20064"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.50877999),
        dec: Angle.Degrees(+65.52966687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2679"},
        {"Smithsonian Astrophysical Observation", "SAO 11263"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.48726969),
        dec: Angle.Degrees(+65.53044405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185306"},
        {"Hipparcos Number", "HIP 96222"},
        {"Smithsonian Astrophysical Observation", "SAO 18408"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.50728932),
        dec: Angle.Degrees(+65.53099638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23883"},
        {"Hipparcos Number", "HIP 18142"},
        {"Geneva Identification System", "GEN# +1.00023883"},
        {"Smithsonian Astrophysical Observation", "SAO 12944"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.17438708),
        dec: Angle.Degrees(+65.53156087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38662"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.73512127),
        dec: Angle.Degrees(+65.53171744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9838"},
        {"Hipparcos Number", "HIP 7616"},
        {"Smithsonian Astrophysical Observation", "SAO 11880"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.52578791),
        dec: Angle.Degrees(+65.53514416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 575"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.74821471),
        dec: Angle.Degrees(+65.53871712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46653"},
    },
    visualMagnitude: 11.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.68209978),
        dec: Angle.Degrees(+65.53976025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102121"},
        {"Hipparcos Number", "HIP 57350"},
        {"Geneva Identification System", "GEN# +1.00102121"},
        {"Smithsonian Astrophysical Observation", "SAO 15624"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38056751),
        dec: Angle.Degrees(+65.54079855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1021"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.18119076),
        dec: Angle.Degrees(+65.54522744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131359"},
        {"Hipparcos Number", "HIP 72545"},
        {"Smithsonian Astrophysical Observation", "SAO 16523"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.47333511),
        dec: Angle.Degrees(+65.54682728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188522"},
        {"Hipparcos Number", "HIP 97689"},
        {"Geneva Identification System", "GEN# +1.00188522"},
        {"Smithsonian Astrophysical Observation", "SAO 18564"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.80706632),
        dec: Angle.Degrees(+65.54697000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80808"},
        {"Hipparcos Number", "HIP 46190"},
        {"Fundamental Katalog 5th Edition", "FK5 4838"},
        {"Smithsonian Astrophysical Observation", "SAO 14870"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.26879212),
        dec: Angle.Degrees(+65.55007887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4613"},
        {"Hipparcos Number", "HIP 3818"},
        {"Geneva Identification System", "GEN# +1.00004613"},
        {"Smithsonian Astrophysical Observation", "SAO 11410"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.25937494),
        dec: Angle.Degrees(+65.55039779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18823"},
        {"Hipparcos Number", "HIP 14356"},
        {"Geneva Identification System", "GEN# +1.00018823"},
        {"Smithsonian Astrophysical Observation", "SAO 12594"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.30160149),
        dec: Angle.Degrees(+65.55175112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21639"},
        {"Hipparcos Number", "HIP 16580"},
        {"Smithsonian Astrophysical Observation", "SAO 12805"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.36051369),
        dec: Angle.Degrees(+65.55196450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124169"},
        {"Hipparcos Number", "HIP 69146"},
        {"Smithsonian Astrophysical Observation", "SAO 16290"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.33299137),
        dec: Angle.Degrees(+65.55843188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181141"},
        {"Hipparcos Number", "HIP 94568"},
        {"Smithsonian Astrophysical Observation", "SAO 18238"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.69557129),
        dec: Angle.Degrees(+65.55867887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80453"},
        {"Smithsonian Astrophysical Observation", "SAO 17087"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.33578436),
        dec: Angle.Degrees(+65.55920441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90344",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fafnir"},
        {"Henry Draper", "HD 170693"},
        {"Hipparcos Number", "HIP 90344"},
        {"Fundamental Katalog 5th Edition", "FK5 3465"},
        {"Geneva Identification System", "GEN# +1.00170693"},
        {"Smithsonian Astrophysical Observation", "SAO 17888"},
        {"Wilson Evans Batten Catalogue", "WEB 15466"},
    },
    visualMagnitude: 4.82,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.49578299),
        dec: Angle.Degrees(+65.56354628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89822"},
        {"Hipparcos Number", "HIP 50933"},
        {"Fundamental Katalog 5th Edition", "FK5 387"},
        {"Geneva Identification System", "GEN# +1.00089822"},
        {"Renson", "Renson 25790"},
        {"Smithsonian Astrophysical Observation", "SAO 15163"},
        {"Wilson Evans Batten Catalogue", "WEB 9316"},
    },
    visualMagnitude: 4.94,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.03274518),
        dec: Angle.Degrees(+65.56647366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109161"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.67530541),
        dec: Angle.Degrees(+65.56762966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114687"},
        {"Hipparcos Number", "HIP 64294"},
        {"Geneva Identification System", "GEN# +1.00114687"},
        {"Smithsonian Astrophysical Observation", "SAO 16004"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.65763813),
        dec: Angle.Degrees(+65.56768269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131928"},
        {"Hipparcos Number", "HIP 72826"},
        {"Smithsonian Astrophysical Observation", "SAO 16541"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.28583868),
        dec: Angle.Degrees(+65.56818424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31676"},
        {"Hipparcos Number", "HIP 23455"},
        {"Fundamental Katalog 5th Edition", "FK5 4464"},
        {"Smithsonian Astrophysical Observation", "SAO 13342"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.62449645),
        dec: Angle.Degrees(+65.56852312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105440"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34974791),
        dec: Angle.Degrees(+65.57235509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114397"},
        {"Hipparcos Number", "HIP 64149"},
        {"Smithsonian Astrophysical Observation", "SAO 15994"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.21120147),
        dec: Angle.Degrees(+65.57291501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24569"},
        {"Hipparcos Number", "HIP 18594"},
        {"Smithsonian Astrophysical Observation", "SAO 12976"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.68312130),
        dec: Angle.Degrees(+65.57576284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113626"},
        {"Smithsonian Astrophysical Observation", "SAO 20364"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.18735066),
        dec: Angle.Degrees(+65.57614806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9788 A"},
        {"Henry Draper", "HD 141628"},
        {"Hipparcos Number", "HIP 77223"},
        {"Smithsonian Astrophysical Observation", "SAO 16846"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.50606370),
        dec: Angle.Degrees(+65.57987491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70255"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.62567310),
        dec: Angle.Degrees(+65.58559142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 269.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178326"},
        {"Hipparcos Number", "HIP 93570"},
        {"Geneva Identification System", "GEN# +1.00178326"},
        {"Smithsonian Astrophysical Observation", "SAO 18137"},
        {"Wilson Evans Batten Catalogue", "WEB 16253"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.86635577),
        dec: Angle.Degrees(+65.58690622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205849"},
        {"Hipparcos Number", "HIP 106585"},
        {"Smithsonian Astrophysical Observation", "SAO 19515"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.80690025),
        dec: Angle.Degrees(+65.58767321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 549"},
    },
    visualMagnitude: 11.55,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.67070715),
        dec: Angle.Degrees(+65.58769959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84812"},
        {"Hipparcos Number", "HIP 48266"},
        {"Geneva Identification System", "GEN# +1.00084812"},
        {"Smithsonian Astrophysical Observation", "SAO 15000"},
        {"Wilson Evans Batten Catalogue", "WEB 9004"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.59861150),
        dec: Angle.Degrees(+65.59329556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208904"},
        {"Hipparcos Number", "HIP 108333"},
        {"Geneva Identification System", "GEN# +1.00208904"},
        {"Smithsonian Astrophysical Observation", "SAO 19754"},
        {"Wilson Evans Batten Catalogue", "WEB 19514"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.22416998),
        dec: Angle.Degrees(+65.59350071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13908"},
        {"Hipparcos Number", "HIP 10743"},
        {"Geneva Identification System", "GEN# +1.00013908"},
        {"Smithsonian Astrophysical Observation", "SAO 12210"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.56053765),
        dec: Angle.Degrees(+65.59445278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5846"},
        {"Wilson Evans Batten Catalogue", "WEB 1334"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75456300),
        dec: Angle.Degrees(+65.59940658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102448"},
        {"Smithsonian Astrophysical Observation", "SAO 19024"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.39565539),
        dec: Angle.Degrees(+65.60401768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89212"},
        {"Smithsonian Astrophysical Observation", "SAO 17814"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.08918661),
        dec: Angle.Degrees(+65.60483487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38886"},
        {"Smithsonian Astrophysical Observation", "SAO 14379"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.36122618),
        dec: Angle.Degrees(+65.61059546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1077"},
        {"Geneva Identification System", "GEN# +0.06400013"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.35081788),
        dec: Angle.Degrees(+65.61346230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37783"},
        {"Hipparcos Number", "HIP 27213"},
        {"Fundamental Katalog 5th Edition", "FK5 4530"},
        {"Smithsonian Astrophysical Observation", "SAO 13600"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.51330510),
        dec: Angle.Degrees(+65.61418488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93238"},
        {"Hipparcos Number", "HIP 52794"},
        {"Smithsonian Astrophysical Observation", "SAO 15287"},
        {"Wilson Evans Batten Catalogue", "WEB 9608"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.90305150),
        dec: Angle.Degrees(+65.61673488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218536"},
        {"Hipparcos Number", "HIP 114203"},
        {"Geneva Identification System", "GEN# +1.00218536"},
        {"Smithsonian Astrophysical Observation", "SAO 20438"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.92553905),
        dec: Angle.Degrees(+65.61688278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106276"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.88730769),
        dec: Angle.Degrees(+65.61817329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106047"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.19627959),
        dec: Angle.Degrees(+65.61889192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71131"},
        {"Smithsonian Astrophysical Observation", "SAO 16427"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.20598007),
        dec: Angle.Degrees(+65.62067154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16764 AB"},
        {"Henry Draper", "HD 220940"},
        {"Hipparcos Number", "HIP 115772"},
        {"Fundamental Katalog 5th Edition", "FK5 3877"},
        {"Geneva Identification System", "GEN# +1.00220940J"},
        {"Smithsonian Astrophysical Observation", "SAO 20640"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.82174310),
        dec: Angle.Degrees(+65.62105241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186033"},
        {"Hipparcos Number", "HIP 96544"},
        {"Smithsonian Astrophysical Observation", "SAO 18444"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.41195510),
        dec: Angle.Degrees(+65.62165993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67756"},
        {"Cincinnati Publication", "Ci 20 822"},
    },
    visualMagnitude: 11.92,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.21178396),
        dec: Angle.Degrees(+65.62251504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -552.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36303"},
        {"Hipparcos Number", "HIP 26283"},
        {"Smithsonian Astrophysical Observation", "SAO 13542"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.94621640),
        dec: Angle.Degrees(+65.62376965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90633"},
        {"Hipparcos Number", "HIP 51401"},
        {"Geneva Identification System", "GEN# +1.00090633"},
        {"Smithsonian Astrophysical Observation", "SAO 15196"},
        {"Wilson Evans Batten Catalogue", "WEB 9384"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.47678657),
        dec: Angle.Degrees(+65.62630441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43277"},
        {"Hipparcos Number", "HIP 30125"},
        {"Smithsonian Astrophysical Observation", "SAO 13804"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.08662089),
        dec: Angle.Degrees(+65.62655609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84165"},
        {"Hipparcos Number", "HIP 47929"},
        {"Smithsonian Astrophysical Observation", "SAO 14981"},
        {"Wilson Evans Batten Catalogue", "WEB 8964"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.51142672),
        dec: Angle.Degrees(+65.62716117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108047"},
        {"Smithsonian Astrophysical Observation", "SAO 19714"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.34479070),
        dec: Angle.Degrees(+65.63493337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17540"},
        {"Hipparcos Number", "HIP 13376"},
        {"Smithsonian Astrophysical Observation", "SAO 12476"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.02765252),
        dec: Angle.Degrees(+65.63521766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30120"},
        {"Hipparcos Number", "HIP 22417"},
        {"Smithsonian Astrophysical Observation", "SAO 13276"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.36343687),
        dec: Angle.Degrees(+65.63647193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82645"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.40424338),
        dec: Angle.Degrees(+65.63816929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135420"},
        {"Hipparcos Number", "HIP 74319"},
        {"Smithsonian Astrophysical Observation", "SAO 16634"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.86036736),
        dec: Angle.Degrees(+65.63902617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157804"},
        {"Hipparcos Number", "HIP 84864"},
        {"Geneva Identification System", "GEN# +1.00157804"},
        {"Smithsonian Astrophysical Observation", "SAO 17444"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.17525956),
        dec: Angle.Degrees(+65.63992302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68830"},
        {"Hipparcos Number", "HIP 40685"},
        {"Smithsonian Astrophysical Observation", "SAO 14492"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.58942707),
        dec: Angle.Degrees(+65.64368175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12512"},
        {"Smithsonian Astrophysical Observation", "SAO 12384"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.26025639),
        dec: Angle.Degrees(+65.64412345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131444"},
        {"Hipparcos Number", "HIP 72578"},
        {"Smithsonian Astrophysical Observation", "SAO 16524"},
        {"Wilson Evans Batten Catalogue", "WEB 12479"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.59139249),
        dec: Angle.Degrees(+65.64582386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221437"},
        {"Hipparcos Number", "HIP 116101"},
        {"Geneva Identification System", "GEN# +1.00221437"},
        {"Smithsonian Astrophysical Observation", "SAO 20680"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.87246296),
        dec: Angle.Degrees(+65.64657054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118838"},
        {"Hipparcos Number", "HIP 66456"},
        {"Smithsonian Astrophysical Observation", "SAO 16126"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.35504000),
        dec: Angle.Degrees(+65.64736373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20336"},
        {"Hipparcos Number", "HIP 15520"},
        {"Geneva Identification System", "GEN# +1.00020336"},
        {"Smithsonian Astrophysical Observation", "SAO 12704"},
        {"Wilson Evans Batten Catalogue", "WEB 2981"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.99690314),
        dec: Angle.Degrees(+65.65232717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 592"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.79749147),
        dec: Angle.Degrees(+65.65378903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2436 AB"},
        {"Henry Draper", "HD 20104"},
        {"Hipparcos Number", "HIP 15309"},
        {"Geneva Identification System", "GEN# +1.00020104J"},
        {"Smithsonian Astrophysical Observation", "SAO 12686"},
        {"Wilson Evans Batten Catalogue", "WEB 2946"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.38141844),
        dec: Angle.Degrees(+65.65835007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22265"},
        {"Hipparcos Number", "HIP 17036"},
        {"Smithsonian Astrophysical Observation", "SAO 12841"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.78024519),
        dec: Angle.Degrees(+65.66007417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78784"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.26033181),
        dec: Angle.Degrees(+65.66064114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66823"},
        {"Hipparcos Number", "HIP 39955"},
        {"Smithsonian Astrophysical Observation", "SAO 14442"},
        {"Wilson Evans Batten Catalogue", "WEB 7788"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.38889159),
        dec: Angle.Degrees(+65.66107823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105791"},
        {"Hipparcos Number", "HIP 59344"},
        {"Cincinnati Publication", "Ci 18 1515"},
        {"Geneva Identification System", "GEN# +1.00105791"},
        {"Smithsonian Astrophysical Observation", "SAO 15730"},
        {"Wilson Evans Batten Catalogue", "WEB 10558"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.60773478),
        dec: Angle.Degrees(+65.66224392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -295.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62152"},
        {"Smithsonian Astrophysical Observation", "SAO 15885"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.07734789),
        dec: Angle.Degrees(+65.66423721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113920"},
        {"Hipparcos Number", "HIP 63893"},
        {"Smithsonian Astrophysical Observation", "SAO 15984"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.42190056),
        dec: Angle.Degrees(+65.66888639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2283"},
        {"Hipparcos Number", "HIP 2163"},
        {"Smithsonian Astrophysical Observation", "SAO 11207"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.81902889),
        dec: Angle.Degrees(+65.68027658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115095"},
        {"Smithsonian Astrophysical Observation", "SAO 20555"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.67985998),
        dec: Angle.Degrees(+65.68201987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202030"},
        {"Hipparcos Number", "HIP 104502"},
        {"Celescope Catalog", "CEL 5262"},
        {"Geneva Identification System", "GEN# +1.00202030"},
        {"Smithsonian Astrophysical Observation", "SAO 19232"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.53120367),
        dec: Angle.Degrees(+65.68625862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199713"},
        {"Hipparcos Number", "HIP 103284"},
        {"Celescope Catalog", "CEL 5214"},
        {"Geneva Identification System", "GEN# +1.00199713"},
        {"Smithsonian Astrophysical Observation", "SAO 19104"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.87168016),
        dec: Angle.Degrees(+65.68730168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101557"},
        {"Hipparcos Number", "HIP 57048"},
        {"Geneva Identification System", "GEN# +1.00101557"},
        {"Smithsonian Astrophysical Observation", "SAO 15603"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43527389),
        dec: Angle.Degrees(+65.68760289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115500"},
        {"Hipparcos Number", "HIP 64735"},
        {"Geneva Identification System", "GEN# +1.00115500"},
        {"Smithsonian Astrophysical Observation", "SAO 16028"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01674174),
        dec: Angle.Degrees(+65.69197909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87400"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.91512134),
        dec: Angle.Degrees(+65.69499881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25637"},
        {"Smithsonian Astrophysical Observation", "SAO 13504"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.14435199),
        dec: Angle.Degrees(+65.69608870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101613"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.90803059),
        dec: Angle.Degrees(+65.69639101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37289"},
        {"Hipparcos Number", "HIP 26882"},
        {"Fundamental Katalog 5th Edition", "FK5 2426"},
        {"Geneva Identification System", "GEN# +1.00037289"},
        {"Smithsonian Astrophysical Observation", "SAO 13570"},
        {"Wilson Evans Batten Catalogue", "WEB 5298"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.61020131),
        dec: Angle.Degrees(+65.69770140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191526"},
        {"Hipparcos Number", "HIP 99027"},
        {"Smithsonian Astrophysical Observation", "SAO 18711"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.55769993),
        dec: Angle.Degrees(+65.69793557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97403"},
        {"Hipparcos Number", "HIP 54841"},
        {"Smithsonian Astrophysical Observation", "SAO 15441"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.41452406),
        dec: Angle.Degrees(+65.70515285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94666"},
        {"Hipparcos Number", "HIP 53540"},
        {"Geneva Identification System", "GEN# +1.00094666"},
        {"Smithsonian Astrophysical Observation", "SAO 15343"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.29589530),
        dec: Angle.Degrees(+65.70676433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182564"},
        {"Hipparcos Number", "HIP 95081"},
        {"Fundamental Katalog 5th Edition", "FK5 3547"},
        {"Geneva Identification System", "GEN# +1.00182564"},
        {"Renson", "Renson 50487"},
        {"Smithsonian Astrophysical Observation", "SAO 18299"},
        {"Wilson Evans Batten Catalogue", "WEB 16608"},
    },
    visualMagnitude: 4.60,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.16696656),
        dec: Angle.Degrees(+65.71443030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83895",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aldhibah"},
        {"Henry Draper", "HD 155763"},
        {"Hipparcos Number", "HIP 83895"},
        {"Fundamental Katalog 5th Edition", "FK5 639"},
        {"Geneva Identification System", "GEN# +1.00155763"},
        {"Smithsonian Astrophysical Observation", "SAO 17365"},
        {"Wilson Evans Batten Catalogue", "WEB 14179"},
    },
    visualMagnitude: 3.17,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.19677111),
        dec: Angle.Degrees(+65.71463676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92424"},
        {"Hipparcos Number", "HIP 52353"},
        {"Fundamental Katalog 5th Edition", "FK5 2855"},
        {"Geneva Identification System", "GEN# +1.00092424"},
        {"Smithsonian Astrophysical Observation", "SAO 15261"},
        {"Wilson Evans Batten Catalogue", "WEB 9528"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.48659345),
        dec: Angle.Degrees(+65.71646212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41927"},
        {"Hipparcos Number", "HIP 29490"},
        {"Fundamental Katalog 5th Edition", "FK5 233"},
        {"Geneva Identification System", "GEN# +1.00041927"},
        {"Smithsonian Astrophysical Observation", "SAO 13756"},
        {"Wilson Evans Batten Catalogue", "WEB 5797"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.21271986),
        dec: Angle.Degrees(+65.71849922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9455"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.40467819),
        dec: Angle.Degrees(+65.71878600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78765"},
        {"Hipparcos Number", "HIP 45246"},
        {"Geneva Identification System", "GEN# +1.00078765"},
        {"Smithsonian Astrophysical Observation", "SAO 14810"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.33820041),
        dec: Angle.Degrees(+65.72050255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13003"},
        {"Smithsonian Astrophysical Observation", "SAO 12436"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.78916398),
        dec: Angle.Degrees(+65.72190420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166330"},
        {"Hipparcos Number", "HIP 88587"},
        {"Smithsonian Astrophysical Observation", "SAO 17754"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.31273887),
        dec: Angle.Degrees(+65.72348285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16907"},
        {"Hipparcos Number", "HIP 12906"},
        {"Smithsonian Astrophysical Observation", "SAO 12431"},
        {"Wilson Evans Batten Catalogue", "WEB 2619"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.47835450),
        dec: Angle.Degrees(+65.72642628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94467"},
        {"Hipparcos Number", "HIP 53435"},
        {"Geneva Identification System", "GEN# +1.00094467"},
        {"Smithsonian Astrophysical Observation", "SAO 15337"},
        {"Wilson Evans Batten Catalogue", "WEB 9698"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.96690775),
        dec: Angle.Degrees(+65.73187395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206522"},
        {"Hipparcos Number", "HIP 106964"},
        {"Smithsonian Astrophysical Observation", "SAO 19563"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.95720634),
        dec: Angle.Degrees(+65.73355260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5801"},
        {"Smithsonian Astrophysical Observation", "SAO 11648"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.60433611),
        dec: Angle.Degrees(+65.73751285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221512"},
        {"Hipparcos Number", "HIP 116161"},
        {"Geneva Identification System", "GEN# +1.00221512"},
        {"Smithsonian Astrophysical Observation", "SAO 20685"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.04783498),
        dec: Angle.Degrees(+65.73913823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69959"},
        {"Hipparcos Number", "HIP 41132"},
        {"Geneva Identification System", "GEN# +1.00069959"},
        {"Smithsonian Astrophysical Observation", "SAO 14526"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.87984863),
        dec: Angle.Degrees(+65.74110108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209887"},
        {"Hipparcos Number", "HIP 108941"},
        {"Smithsonian Astrophysical Observation", "SAO 19835"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.07470793),
        dec: Angle.Degrees(+65.74232950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16024"},
        {"Hipparcos Number", "HIP 12239"},
        {"Fundamental Katalog 5th Edition", "FK5 2178"},
        {"Geneva Identification System", "GEN# +1.00016024"},
        {"Smithsonian Astrophysical Observation", "SAO 12361"},
        {"Wilson Evans Batten Catalogue", "WEB 2512"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.40002834),
        dec: Angle.Degrees(+65.74535775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51416"},
        {"Hipparcos Number", "HIP 33901"},
        {"Smithsonian Astrophysical Observation", "SAO 14050"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.54612388),
        dec: Angle.Degrees(+65.75149076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15407 AB"},
        {"Hipparcos Number", "HIP 107893"},
        {"Smithsonian Astrophysical Observation", "SAO 19686"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.90522385),
        dec: Angle.Degrees(+65.75276063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4405 AB"},
        {"Henry Draper", "HD 38475"},
        {"Hipparcos Number", "HIP 27634"},
        {"Smithsonian Astrophysical Observation", "SAO 13627"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.75458337),
        dec: Angle.Degrees(+65.75405933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195503"},
        {"Hipparcos Number", "HIP 100933"},
        {"Smithsonian Astrophysical Observation", "SAO 18879"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.96574603),
        dec: Angle.Degrees(+65.75582904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116592"},
        {"Hipparcos Number", "HIP 65287"},
        {"Smithsonian Astrophysical Observation", "SAO 16061"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.71257066),
        dec: Angle.Degrees(+65.75978711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8666"},
        {"Hipparcos Number", "HIP 6784"},
        {"Smithsonian Astrophysical Observation", "SAO 11763"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.82642978),
        dec: Angle.Degrees(+65.77280597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85631"},
        {"Hipparcos Number", "HIP 48678"},
        {"Smithsonian Astrophysical Observation", "SAO 15024"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.92438224),
        dec: Angle.Degrees(+65.77497352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62895"},
        {"Smithsonian Astrophysical Observation", "SAO 15933"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.34811424),
        dec: Angle.Degrees(+65.77820634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133826"},
        {"Hipparcos Number", "HIP 73623"},
        {"Geneva Identification System", "GEN# +1.00133826"},
        {"Smithsonian Astrophysical Observation", "SAO 16585"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.74499883),
        dec: Angle.Degrees(+65.77858207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74480"},
        {"Fundamental Katalog 5th Edition", "FK5 5352"},
        {"Smithsonian Astrophysical Observation", "SAO 16649"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.28464081),
        dec: Angle.Degrees(+65.77931474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26253"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.87382068),
        dec: Angle.Degrees(+65.78102066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109798"},
        {"Smithsonian Astrophysical Observation", "SAO 19958"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.59034303),
        dec: Angle.Degrees(+65.78284364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223996"},
        {"Hipparcos Number", "HIP 117851"},
        {"Smithsonian Astrophysical Observation", "SAO 20926"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.54611585),
        dec: Angle.Degrees(+65.78380012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134807"},
        {"Hipparcos Number", "HIP 74082"},
        {"Smithsonian Astrophysical Observation", "SAO 16608"},
        {"Wilson Evans Batten Catalogue", "WEB 12656"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.08088456),
        dec: Angle.Degrees(+65.78864354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140250"},
        {"Hipparcos Number", "HIP 76593"},
        {"Smithsonian Astrophysical Observation", "SAO 16799"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.63929772),
        dec: Angle.Degrees(+65.79073055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11014"},
        {"Smithsonian Astrophysical Observation", "SAO 12239"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.45905858),
        dec: Angle.Degrees(+65.79129376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78820"},
        {"Hipparcos Number", "HIP 45279"},
        {"Geneva Identification System", "GEN# +1.00078820"},
        {"Smithsonian Astrophysical Observation", "SAO 14811"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.42567900),
        dec: Angle.Degrees(+65.79683058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11089"},
        {"Smithsonian Astrophysical Observation", "SAO 12253"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.70639326),
        dec: Angle.Degrees(+65.80405160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120163"},
        {"Hipparcos Number", "HIP 67141"},
        {"Smithsonian Astrophysical Observation", "SAO 16168"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.39861166),
        dec: Angle.Degrees(+65.80460297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17916"},
        {"Hipparcos Number", "HIP 13670"},
        {"Smithsonian Astrophysical Observation", "SAO 12514"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.01065877),
        dec: Angle.Degrees(+65.80727458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16907"},
        {"Smithsonian Astrophysical Observation", "SAO 12834"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.39219664),
        dec: Angle.Degrees(+65.80769311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46072"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.92470670),
        dec: Angle.Degrees(+65.80867585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82138"},
        {"Hipparcos Number", "HIP 46884"},
        {"Geneva Identification System", "GEN# +1.00082138"},
        {"Smithsonian Astrophysical Observation", "SAO 14915"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.31620802),
        dec: Angle.Degrees(+65.81223419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95955"},
        {"Hipparcos Number", "HIP 54199"},
        {"Cincinnati Publication", "Ci 18 1347"},
        {"Geneva Identification System", "GEN# +1.00095955"},
        {"Smithsonian Astrophysical Observation", "SAO 15391"},
        {"Wilson Evans Batten Catalogue", "WEB 9792"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.32036446),
        dec: Angle.Degrees(+65.81411240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32197"},
        {"Hipparcos Number", "HIP 23746"},
        {"Smithsonian Astrophysical Observation", "SAO 13367"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.55977854),
        dec: Angle.Degrees(+65.82152254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199869"},
        {"Hipparcos Number", "HIP 103357"},
        {"Smithsonian Astrophysical Observation", "SAO 19112"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.10382729),
        dec: Angle.Degrees(+65.82761181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145991"},
        {"Hipparcos Number", "HIP 79180"},
        {"Cincinnati Publication", "Ci 18 2172"},
        {"Geneva Identification System", "GEN# +1.00145991"},
        {"Smithsonian Astrophysical Observation", "SAO 16982"},
        {"Wilson Evans Batten Catalogue", "WEB 13387"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.41351481),
        dec: Angle.Degrees(+65.82976587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56867"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.88864954),
        dec: Angle.Degrees(+65.83280343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107408"},
        {"Geneva Identification System", "GEN# +2.71420002"},
        {"New General Catalogue", "NGC 7142 2"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.32770044),
        dec: Angle.Degrees(+65.83308468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57155"},
        {"Hipparcos Number", "HIP 35953"},
        {"Geneva Identification System", "GEN# +1.00057155"},
        {"Smithsonian Astrophysical Observation", "SAO 14180"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.17013872),
        dec: Angle.Degrees(+65.83868628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140611"},
        {"Hipparcos Number", "HIP 76786"},
        {"Cincinnati Publication", "Ci 18 2105"},
        {"Geneva Identification System", "GEN# +1.00140611"},
        {"Smithsonian Astrophysical Observation", "SAO 16812"},
        {"Wilson Evans Batten Catalogue", "WEB 13031"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.16737854),
        dec: Angle.Degrees(+65.84112808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43586"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.14937827),
        dec: Angle.Degrees(+65.84521568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55360"},
        {"Cincinnati Publication", "Ci 18 1383"},
        {"Cincinnati Publication 2", "Ci 20 629"},
        {"Geneva Identification System", "GEN# +0.06600717"},
        {"Smithsonian Astrophysical Observation", "SAO 15475"},
        {"Wilson Evans Batten Catalogue", "WEB 9967"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.03762202),
        dec: Angle.Degrees(+65.84603892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2946.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58194"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.02280281),
        dec: Angle.Degrees(+65.84969147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25530"},
        {"Hipparcos Number", "HIP 19259"},
        {"Smithsonian Astrophysical Observation", "SAO 13026"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.92093936),
        dec: Angle.Degrees(+65.85187734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193341"},
        {"Hipparcos Number", "HIP 99863"},
        {"Geneva Identification System", "GEN# +1.00193341"},
        {"Smithsonian Astrophysical Observation", "SAO 18785"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.92315416),
        dec: Angle.Degrees(+65.85363587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204458"},
        {"Hipparcos Number", "HIP 105801"},
        {"Smithsonian Astrophysical Observation", "SAO 19402"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.40038981),
        dec: Angle.Degrees(+65.85724329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141750"},
        {"Hipparcos Number", "HIP 77273"},
        {"Geneva Identification System", "GEN# +1.00141750"},
        {"Smithsonian Astrophysical Observation", "SAO 16850"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.64943958),
        dec: Angle.Degrees(+65.86441676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19425"},
        {"Hipparcos Number", "HIP 14816"},
        {"Smithsonian Astrophysical Observation", "SAO 12638"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.82108561),
        dec: Angle.Degrees(+65.86608358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129307"},
        {"Hipparcos Number", "HIP 71607"},
        {"Smithsonian Astrophysical Observation", "SAO 16450"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.67924030),
        dec: Angle.Degrees(+65.86619263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3801"},
        {"Hipparcos Number", "HIP 3267"},
        {"Geneva Identification System", "GEN# +1.00003801"},
        {"Smithsonian Astrophysical Observation", "SAO 11331"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.39382484),
        dec: Angle.Degrees(+65.86836175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113695"},
        {"Hipparcos Number", "HIP 63763"},
        {"Smithsonian Astrophysical Observation", "SAO 15969"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.03533442),
        dec: Angle.Degrees(+65.87494737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13731"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.20707763),
        dec: Angle.Degrees(+65.87514009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96074"},
        {"Hipparcos Number", "HIP 54275"},
        {"Geneva Identification System", "GEN# +1.00096074"},
        {"Smithsonian Astrophysical Observation", "SAO 15401"},
        {"Wilson Evans Batten Catalogue", "WEB 9805"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.54076514),
        dec: Angle.Degrees(+65.87578481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41510"},
        {"Smithsonian Astrophysical Observation", "SAO 14556"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.98532589),
        dec: Angle.Degrees(+65.88096556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8474"},
        {"Smithsonian Astrophysical Observation", "SAO 11996"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.31373004),
        dec: Angle.Degrees(+65.88198632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166728"},
        {"Hipparcos Number", "HIP 88744"},
        {"Smithsonian Astrophysical Observation", "SAO 17772"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.75351847),
        dec: Angle.Degrees(+65.88794793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207965"},
        {"Hipparcos Number", "HIP 107800"},
        {"Smithsonian Astrophysical Observation", "SAO 19672"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.57690738),
        dec: Angle.Degrees(+65.88994959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28111"},
        {"Hipparcos Number", "HIP 21041"},
        {"Smithsonian Astrophysical Observation", "SAO 13162"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.66630237),
        dec: Angle.Degrees(+65.89024866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71964"},
        {"Smithsonian Astrophysical Observation", "SAO 16475"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.77481840),
        dec: Angle.Degrees(+65.89058916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190695"},
        {"Hipparcos Number", "HIP 98632"},
        {"Geneva Identification System", "GEN# +1.00190695"},
        {"Smithsonian Astrophysical Observation", "SAO 18666"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.49214535),
        dec: Angle.Degrees(+65.89075134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4948"},
        {"Hipparcos Number", "HIP 4097"},
        {"Geneva Identification System", "GEN# +1.00004948"},
        {"Smithsonian Astrophysical Observation", "SAO 11439"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.15022957),
        dec: Angle.Degrees(+65.89176042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5151"},
        {"Smithsonian Astrophysical Observation", "SAO 11565"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.48321042),
        dec: Angle.Degrees(+65.89413068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88207"},
        {"Smithsonian Astrophysical Observation", "SAO 17726"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.19373026),
        dec: Angle.Degrees(+65.89730396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109002"},
        {"Hipparcos Number", "HIP 61068"},
        {"Smithsonian Astrophysical Observation", "SAO 15817"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.74260846),
        dec: Angle.Degrees(+65.89785922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89977"},
        {"Hipparcos Number", "HIP 51002"},
        {"Smithsonian Astrophysical Observation", "SAO 15169"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.27787899),
        dec: Angle.Degrees(+65.90923229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118192"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.61453399),
        dec: Angle.Degrees(+65.91337161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78914"},
        {"Hipparcos Number", "HIP 45324"},
        {"Smithsonian Astrophysical Observation", "SAO 14816"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.55330044),
        dec: Angle.Degrees(+65.91786884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133994"},
        {"Hipparcos Number", "HIP 73706"},
        {"Geneva Identification System", "GEN# +1.00133994"},
        {"Smithsonian Astrophysical Observation", "SAO 16587"},
        {"Wilson Evans Batten Catalogue", "WEB 12600"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.99055401),
        dec: Angle.Degrees(+65.91973604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86578"},
        {"Smithsonian Astrophysical Observation", "SAO 17609"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.39981768),
        dec: Angle.Degrees(+65.92400797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106117"},
        {"Smithsonian Astrophysical Observation", "SAO 19454"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.42078779),
        dec: Angle.Degrees(+65.92466030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86001"},
        {"Hipparcos Number", "HIP 48889"},
        {"Smithsonian Astrophysical Observation", "SAO 15036"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.57303860),
        dec: Angle.Degrees(+65.92664045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132813"},
        {"Hipparcos Number", "HIP 73199"},
        {"Fundamental Katalog 5th Edition", "FK5 554"},
        {"Geneva Identification System", "GEN# +1.00132813"},
        {"Smithsonian Astrophysical Observation", "SAO 16558"},
        {"Wilson Evans Batten Catalogue", "WEB 12546"},
    },
    visualMagnitude: 4.63,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.39632979),
        dec: Angle.Degrees(+65.93238126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26221"},
        {"Hipparcos Number", "HIP 19710"},
        {"Geneva Identification System", "GEN# +1.00026221"},
        {"Smithsonian Astrophysical Observation", "SAO 13065"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.34628986),
        dec: Angle.Degrees(+65.93553484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91509"},
        {"Smithsonian Astrophysical Observation", "SAO 17973"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.93429648),
        dec: Angle.Degrees(+65.93842180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207416"},
        {"Hipparcos Number", "HIP 107474"},
        {"Geneva Identification System", "GEN# +1.00207416"},
        {"Smithsonian Astrophysical Observation", "SAO 19634"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.51957796),
        dec: Angle.Degrees(+65.94035153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184803"},
        {"Hipparcos Number", "HIP 96042"},
        {"Smithsonian Astrophysical Observation", "SAO 18386"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.92582400),
        dec: Angle.Degrees(+65.94216365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111850"},
        {"Smithsonian Astrophysical Observation", "SAO 20194"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.85220995),
        dec: Angle.Degrees(+65.94469354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110741"},
        {"Hipparcos Number", "HIP 62072"},
        {"Geneva Identification System", "GEN# +1.00110741"},
        {"Smithsonian Astrophysical Observation", "SAO 15879"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.82484385),
        dec: Angle.Degrees(+65.94628425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25407"},
        {"Hipparcos Number", "HIP 19181"},
        {"Smithsonian Astrophysical Observation", "SAO 13016"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.67226745),
        dec: Angle.Degrees(+65.94849564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88257",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11016 AB"},
        {"Henry Draper", "HD 165522"},
        {"Hipparcos Number", "HIP 88257"},
        {"Smithsonian Astrophysical Observation", "SAO 17729"},
        {"Wilson Evans Batten Catalogue", "WEB 14912"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.34696050),
        dec: Angle.Degrees(+65.94862883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204976"},
        {"Hipparcos Number", "HIP 106084"},
        {"Smithsonian Astrophysical Observation", "SAO 19450"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.33160404),
        dec: Angle.Degrees(+65.94991381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112599"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.08125868),
        dec: Angle.Degrees(+65.95031932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188120"},
        {"Hipparcos Number", "HIP 97514"},
        {"Cincinnati Publication", "Ci 18 2592"},
        {"Smithsonian Astrophysical Observation", "SAO 18548"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.29836082),
        dec: Angle.Degrees(+65.95453447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 212.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7333"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.60301743),
        dec: Angle.Degrees(+65.96378751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53168"},
        {"Hipparcos Number", "HIP 34503"},
        {"Geneva Identification System", "GEN# +1.00053168"},
        {"Smithsonian Astrophysical Observation", "SAO 14085"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.22989551),
        dec: Angle.Degrees(+65.96503218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133704"},
        {"Hipparcos Number", "HIP 73578"},
        {"Smithsonian Astrophysical Observation", "SAO 16580"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.58601219),
        dec: Angle.Degrees(+65.96503234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53469"},
        {"Hipparcos Number", "HIP 34605"},
        {"Smithsonian Astrophysical Observation", "SAO 14094"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.52150953),
        dec: Angle.Degrees(+65.97023870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128608"},
        {"Hipparcos Number", "HIP 71287"},
        {"Geneva Identification System", "GEN# +1.00128608"},
        {"Smithsonian Astrophysical Observation", "SAO 16437"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.68160976),
        dec: Angle.Degrees(+65.97105480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6343"},
        {"Hipparcos Number", "HIP 5147"},
        {"Celescope Catalog", "CEL 116"},
        {"Geneva Identification System", "GEN# +1.00006343"},
        {"Smithsonian Astrophysical Observation", "SAO 11564"},
        {"Wilson Evans Batten Catalogue", "WEB 1067"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.47072853),
        dec: Angle.Degrees(+65.97107632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179933"},
        {"Hipparcos Number", "HIP 94140"},
        {"Fundamental Katalog 5th Edition", "FK5 3531"},
        {"Geneva Identification System", "GEN# +1.00179933"},
        {"Smithsonian Astrophysical Observation", "SAO 18187"},
        {"Wilson Evans Batten Catalogue", "WEB 16398"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.44083917),
        dec: Angle.Degrees(+65.97844349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120980"},
        {"Hipparcos Number", "HIP 67547"},
        {"Geneva Identification System", "GEN# +1.00120980"},
        {"Smithsonian Astrophysical Observation", "SAO 16194"},
        {"Wilson Evans Batten Catalogue", "WEB 11880"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.61313782),
        dec: Angle.Degrees(+65.98009818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216156"},
        {"Hipparcos Number", "HIP 112679"},
        {"Smithsonian Astrophysical Observation", "SAO 20258"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.26970765),
        dec: Angle.Degrees(+65.98693142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126912"},
        {"Hipparcos Number", "HIP 70522"},
        {"Geneva Identification System", "GEN# +1.00126912"},
        {"Smithsonian Astrophysical Observation", "SAO 16377"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.38764003),
        dec: Angle.Degrees(+65.98781094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203425"},
        {"Hipparcos Number", "HIP 105223"},
        {"Smithsonian Astrophysical Observation", "SAO 19310"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.71373702),
        dec: Angle.Degrees(+65.98935358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112559"},
        {"Hipparcos Number", "HIP 63152"},
        {"Geneva Identification System", "GEN# +1.00112559"},
        {"Smithsonian Astrophysical Observation", "SAO 15945"},
        {"Wilson Evans Batten Catalogue", "WEB 11196"},
    },
    visualMagnitude: 6.63,
    bvColour: 3.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.10788972),
        dec: Angle.Degrees(+65.99441512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213887"},
        {"Hipparcos Number", "HIP 111297"},
        {"Smithsonian Astrophysical Observation", "SAO 20145"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.19969339),
        dec: Angle.Degrees(+65.99936769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76271"},
        {"Hipparcos Number", "HIP 44084"},
        {"Geneva Identification System", "GEN# +1.00076271"},
        {"Smithsonian Astrophysical Observation", "SAO 14718"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.69541416),
        dec: Angle.Degrees(+66.00145295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105513"},
        {"Smithsonian Astrophysical Observation", "SAO 19357"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.55407259),
        dec: Angle.Degrees(+66.00278254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174529"},
        {"Hipparcos Number", "HIP 92084"},
        {"Smithsonian Astrophysical Observation", "SAO 18013"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.51410173),
        dec: Angle.Degrees(+66.00294708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32651"},
        {"Hipparcos Number", "HIP 24012"},
        {"Smithsonian Astrophysical Observation", "SAO 13385"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.42760568),
        dec: Angle.Degrees(+66.00415866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30556"},
        {"Hipparcos Number", "HIP 22733"},
        {"Geneva Identification System", "GEN# +1.00030556"},
        {"Smithsonian Astrophysical Observation", "SAO 13294"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.35706068),
        dec: Angle.Degrees(+66.00614067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10912"},
        {"Hipparcos Number", "HIP 8492"},
        {"Geneva Identification System", "GEN# +1.00010912"},
        {"Smithsonian Astrophysical Observation", "SAO 11998"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.36952712),
        dec: Angle.Degrees(+66.00695354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16880 AB"},
        {"Hipparcos Number", "HIP 116598"},
        {"Smithsonian Astrophysical Observation", "SAO 20738"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.44874291),
        dec: Angle.Degrees(+66.00897616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216477"},
        {"Hipparcos Number", "HIP 112893"},
        {"Smithsonian Astrophysical Observation", "SAO 20284"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.92827629),
        dec: Angle.Degrees(+66.00954002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97033"},
        {"Hipparcos Number", "HIP 54657"},
        {"Cincinnati Publication", "Ci 18 1359"},
        {"Geneva Identification System", "GEN# +1.00097033"},
        {"Smithsonian Astrophysical Observation", "SAO 15425"},
        {"Wilson Evans Batten Catalogue", "WEB 9866"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.83272406),
        dec: Angle.Degrees(+66.01376544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -329.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92538"},
        {"Hipparcos Number", "HIP 52410"},
        {"Geneva Identification System", "GEN# +1.00092538"},
        {"Smithsonian Astrophysical Observation", "SAO 15268"},
        {"Wilson Evans Batten Catalogue", "WEB 9538"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.70872452),
        dec: Angle.Degrees(+66.01544523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32957"},
        {"Hipparcos Number", "HIP 24199"},
        {"Smithsonian Astrophysical Observation", "SAO 13399"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.92720507),
        dec: Angle.Degrees(+66.01656776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67345"},
        {"Hipparcos Number", "HIP 40127"},
        {"Geneva Identification System", "GEN# +1.00067345"},
        {"Smithsonian Astrophysical Observation", "SAO 14454"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.94957432),
        dec: Angle.Degrees(+66.01712966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53475"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.08886941),
        dec: Angle.Degrees(+66.02112083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50152"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.57346396),
        dec: Angle.Degrees(+66.02566756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46117"},
        {"Hipparcos Number", "HIP 31566"},
        {"Geneva Identification System", "GEN# +1.00046117"},
        {"Smithsonian Astrophysical Observation", "SAO 13889"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.10443785),
        dec: Angle.Degrees(+66.02607452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87570"},
        {"Hipparcos Number", "HIP 49653"},
        {"Smithsonian Astrophysical Observation", "SAO 15090"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.05074319),
        dec: Angle.Degrees(+66.02790072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97050"},
        {"Hipparcos Number", "HIP 54676"},
        {"Geneva Identification System", "GEN# +1.00097050"},
        {"Smithsonian Astrophysical Observation", "SAO 15427"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.88395938),
        dec: Angle.Degrees(+66.03014602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60162"},
    },
    visualMagnitude: 11.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.05855032),
        dec: Angle.Degrees(+66.03538192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152139"},
        {"Hipparcos Number", "HIP 82137"},
        {"Geneva Identification System", "GEN# +1.00152139"},
        {"Smithsonian Astrophysical Observation", "SAO 17222"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.70761555),
        dec: Angle.Degrees(+66.04154942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96972"},
        {"Hipparcos Number", "HIP 54636"},
        {"Geneva Identification System", "GEN# +1.00096972"},
        {"Smithsonian Astrophysical Observation", "SAO 15423"},
        {"Wilson Evans Batten Catalogue", "WEB 9857"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.74571780),
        dec: Angle.Degrees(+66.04539962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73191"},
        {"Hipparcos Number", "HIP 42593"},
        {"Smithsonian Astrophysical Observation", "SAO 14619"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.21470847),
        dec: Angle.Degrees(+66.04625849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15769"},
        {"Hipparcos Number", "HIP 12030"},
        {"Smithsonian Astrophysical Observation", "SAO 12342"},
        {"Wilson Evans Batten Catalogue", "WEB 2476"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.78099042),
        dec: Angle.Degrees(+66.04939258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217182"},
        {"Hipparcos Number", "HIP 113350"},
        {"Smithsonian Astrophysical Observation", "SAO 20340"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.33694763),
        dec: Angle.Degrees(+66.05000322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6228 AB"},
        {"Henry Draper", "HD 60613"},
        {"Hipparcos Number", "HIP 37353"},
        {"Smithsonian Astrophysical Observation", "SAO 14277"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.00447234),
        dec: Angle.Degrees(+66.05035016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4625"},
        {"Hipparcos Number", "HIP 3831"},
        {"Smithsonian Astrophysical Observation", "SAO 11411"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.29365169),
        dec: Angle.Degrees(+66.05117555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53127"},
        {"Hipparcos Number", "HIP 34472"},
        {"Smithsonian Astrophysical Observation", "SAO 14082"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.17340234),
        dec: Angle.Degrees(+66.05347847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143933"},
        {"Hipparcos Number", "HIP 78270"},
        {"Geneva Identification System", "GEN# +1.00143933"},
        {"Smithsonian Astrophysical Observation", "SAO 16910"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.72759386),
        dec: Angle.Degrees(+66.05492089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150044"},
        {"Hipparcos Number", "HIP 81090"},
        {"Smithsonian Astrophysical Observation", "SAO 17146"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.44933079),
        dec: Angle.Degrees(+66.05514752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97841"},
        {"Smithsonian Astrophysical Observation", "SAO 18581"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.22740154),
        dec: Angle.Degrees(+66.05568501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71898"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.59172751),
        dec: Angle.Degrees(+66.05588609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -310.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33275"},
        {"Hipparcos Number", "HIP 24402"},
        {"Geneva Identification System", "GEN# +1.00033275"},
        {"Smithsonian Astrophysical Observation", "SAO 13417"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.52063071),
        dec: Angle.Degrees(+66.05661236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195963"},
        {"Hipparcos Number", "HIP 101175"},
        {"Smithsonian Astrophysical Observation", "SAO 18906"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.61521170),
        dec: Angle.Degrees(+66.05678517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51045"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.43179128),
        dec: Angle.Degrees(+66.06366367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209691"},
        {"Hipparcos Number", "HIP 108829"},
        {"Celescope Catalog", "CEL 5425"},
        {"Geneva Identification System", "GEN# +1.00209691"},
        {"Smithsonian Astrophysical Observation", "SAO 19814"},
        {"Wilson Evans Batten Catalogue", "WEB 19576"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.70638858),
        dec: Angle.Degrees(+66.06424122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218694"},
        {"Hipparcos Number", "HIP 114302"},
        {"Geneva Identification System", "GEN# +1.00218694"},
        {"Smithsonian Astrophysical Observation", "SAO 20450"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.23672277),
        dec: Angle.Degrees(+66.06634979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27540"},
        {"Smithsonian Astrophysical Observation", "SAO 13623"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.48584677),
        dec: Angle.Degrees(+66.06995160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206136"},
        {"Hipparcos Number", "HIP 106733"},
        {"Smithsonian Astrophysical Observation", "SAO 19534"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.30803707),
        dec: Angle.Degrees(+66.07002213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92030"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.37303490),
        dec: Angle.Degrees(+66.07204251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66308"},
        {"Smithsonian Astrophysical Observation", "SAO 16118"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.84772262),
        dec: Angle.Degrees(+66.07500215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8701"},
        {"Hipparcos Number", "HIP 6811"},
        {"Geneva Identification System", "GEN# +1.00008701"},
        {"Smithsonian Astrophysical Observation", "SAO 11764"},
        {"Wilson Evans Batten Catalogue", "WEB 1485"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.90717318),
        dec: Angle.Degrees(+66.07696970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209452"},
        {"Hipparcos Number", "HIP 108688"},
        {"Geneva Identification System", "GEN# +1.00209452"},
        {"Smithsonian Astrophysical Observation", "SAO 19799"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.25933619),
        dec: Angle.Degrees(+66.08248597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156889"},
        {"Hipparcos Number", "HIP 84388"},
        {"Smithsonian Astrophysical Observation", "SAO 17406"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.79676321),
        dec: Angle.Degrees(+66.08654267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107207"},
        {"Geneva Identification System", "GEN# +0.06501636"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.69172895),
        dec: Angle.Degrees(+66.08714952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114140"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.74289131),
        dec: Angle.Degrees(+66.09577127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39429"},
        {"Hipparcos Number", "HIP 28205"},
        {"Fundamental Katalog 5th Edition", "FK5 2448"},
        {"Geneva Identification System", "GEN# +1.00039429"},
        {"Smithsonian Astrophysical Observation", "SAO 13662"},
        {"Wilson Evans Batten Catalogue", "WEB 5519"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.39562095),
        dec: Angle.Degrees(+66.09612887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214417"},
        {"Hipparcos Number", "HIP 111574"},
        {"Geneva Identification System", "GEN# +1.00214417"},
        {"Smithsonian Astrophysical Observation", "SAO 20173"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.05735129),
        dec: Angle.Degrees(+66.09675301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9030"},
        {"Hipparcos Number", "HIP 7050"},
        {"Geneva Identification System", "GEN# +1.00009030"},
        {"Renson", "Renson 2190"},
        {"Smithsonian Astrophysical Observation", "SAO 11788"},
        {"Wilson Evans Batten Catalogue", "WEB 1523"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.71671740),
        dec: Angle.Degrees(+66.09811465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 207",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1 A"},
        {"Henry Draper", "HD 225009"},
        {"Hipparcos Number", "HIP 207"},
        {"Geneva Identification System", "GEN# +1.00225009"},
        {"Smithsonian Astrophysical Observation", "SAO 10937"},
        {"Wilson Evans Batten Catalogue", "WEB 35"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.65034249),
        dec: Angle.Degrees(+66.09896341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1 B"},
        {"Henry Draper", "HD 225010"},
        {"Hipparcos Number", "HIP 209"},
        {"Geneva Identification System", "GEN# +1.00225010"},
        {"Smithsonian Astrophysical Observation", "SAO 10938"},
        {"Wilson Evans Batten Catalogue", "WEB 36"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.66015960),
        dec: Angle.Degrees(+66.10037725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122298"},
        {"Hipparcos Number", "HIP 68274"},
        {"Geneva Identification System", "GEN# +1.00122298"},
        {"Smithsonian Astrophysical Observation", "SAO 16235"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.65760019),
        dec: Angle.Degrees(+66.10080982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40664"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.51425026),
        dec: Angle.Degrees(+66.10176582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180004"},
        {"Hipparcos Number", "HIP 94162"},
        {"Smithsonian Astrophysical Observation", "SAO 18194"},
        {"Wilson Evans Batten Catalogue", "WEB 16405"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.50971679),
        dec: Angle.Degrees(+66.10269453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7984"},
        {"Smithsonian Astrophysical Observation", "SAO 11924"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.63454067),
        dec: Angle.Degrees(+66.10797486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106381"},
        {"Hipparcos Number", "HIP 59658"},
        {"Fundamental Katalog 5th Edition", "FK5 2979"},
        {"Geneva Identification System", "GEN# +1.00106381"},
        {"Smithsonian Astrophysical Observation", "SAO 15747"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.52364799),
        dec: Angle.Degrees(+66.10927660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62556"},
        {"Cincinnati Publication", "Ci 20 742"},
        {"Geneva Identification System", "GEN# +6.10010487"},
        {"Geneva Identification System 2", "GEN# +9.80237078"},
        {"Wilson Evans Batten Catalogue", "WEB 11104"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.26409622),
        dec: Angle.Degrees(+66.11044073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -436.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64760"},
        {"Smithsonian Astrophysical Observation", "SAO 16031"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.07799374),
        dec: Angle.Degrees(+66.11070023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1200"},
        {"Smithsonian Astrophysical Observation", "SAO 11067"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.75449277),
        dec: Angle.Degrees(+66.11396057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62245"},
        {"Smithsonian Astrophysical Observation", "SAO 15891"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.35176833),
        dec: Angle.Degrees(+66.11547369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121800"},
        {"Hipparcos Number", "HIP 67977"},
        {"Geneva Identification System", "GEN# +1.00121800"},
        {"Smithsonian Astrophysical Observation", "SAO 16218"},
    },
    visualMagnitude: 9.04,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.81437339),
        dec: Angle.Degrees(+66.11685484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22563"},
        {"Hipparcos Number", "HIP 17273"},
        {"Smithsonian Astrophysical Observation", "SAO 12868"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.48671423),
        dec: Angle.Degrees(+66.11759047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1895"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.98828885),
        dec: Angle.Degrees(+66.12235344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104390"},
        {"Hipparcos Number", "HIP 58631"},
        {"Smithsonian Astrophysical Observation", "SAO 15690"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.34876115),
        dec: Angle.Degrees(+66.12297644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11449 A"},
        {"Aitken 2", "ADS 11449 AB"},
        {"Hipparcos Number", "HIP 90771"},
        {"Smithsonian Astrophysical Observation", "SAO 17913"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.79449001),
        dec: Angle.Degrees(+66.12626382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 145 AB"},
        {"Henry Draper", "HD 724"},
        {"Hipparcos Number", "HIP 957"},
        {"Smithsonian Astrophysical Observation", "SAO 11030"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.96013415),
        dec: Angle.Degrees(+66.12634754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211746"},
        {"Hipparcos Number", "HIP 110034"},
        {"Celescope Catalog", "CEL 5463"},
        {"Geneva Identification System", "GEN# +1.00211746"},
        {"Smithsonian Astrophysical Observation", "SAO 19982"},
        {"Wilson Evans Batten Catalogue", "WEB 19757"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.30068868),
        dec: Angle.Degrees(+66.12889714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7443"},
        {"Hipparcos Number", "HIP 5929"},
        {"Smithsonian Astrophysical Observation", "SAO 11665"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.05166680),
        dec: Angle.Degrees(+66.13049944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2418"},
        {"Renson", "Renson 640"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.70519082),
        dec: Angle.Degrees(+66.13106857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43534"},
        {"Geneva Identification System", "GEN# +0.06600582"},
        {"Smithsonian Astrophysical Observation", "SAO 14684"},
        {"Wilson Evans Batten Catalogue", "WEB 8391"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.00088105),
        dec: Angle.Degrees(+66.13125503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58679"},
        {"Hipparcos Number", "HIP 36578"},
        {"Smithsonian Astrophysical Observation", "SAO 14217"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.85144191),
        dec: Angle.Degrees(+66.13482236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29737"},
        {"Smithsonian Astrophysical Observation", "SAO 13769"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.93757765),
        dec: Angle.Degrees(+66.13547530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167779"},
        {"Hipparcos Number", "HIP 89169"},
        {"Smithsonian Astrophysical Observation", "SAO 17813"},
        {"Wilson Evans Batten Catalogue", "WEB 15146"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.95798622),
        dec: Angle.Degrees(+66.13566978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18533"},
        {"Smithsonian Astrophysical Observation", "SAO 12971"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.46487530),
        dec: Angle.Degrees(+66.13655072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80533"},
        {"Hipparcos Number", "HIP 46066"},
        {"Smithsonian Astrophysical Observation", "SAO 14862"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.91549122),
        dec: Angle.Degrees(+66.13744263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208971"},
        {"Hipparcos Number", "HIP 108378"},
        {"Smithsonian Astrophysical Observation", "SAO 19762"},
        {"Wilson Evans Batten Catalogue", "WEB 19521"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.35079197),
        dec: Angle.Degrees(+66.13907633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28022"},
        {"Hipparcos Number", "HIP 20991"},
        {"Geneva Identification System", "GEN# +1.00028022"},
        {"Smithsonian Astrophysical Observation", "SAO 13158"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.52039245),
        dec: Angle.Degrees(+66.14217229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214675"},
        {"Hipparcos Number", "HIP 111747"},
        {"Smithsonian Astrophysical Observation", "SAO 20186"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.54515757),
        dec: Angle.Degrees(+66.14409244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3856"},
        {"Hipparcos Number", "HIP 3299"},
        {"Fundamental Katalog 5th Edition", "FK5 2045"},
        {"Geneva Identification System", "GEN# +1.00003856"},
        {"Smithsonian Astrophysical Observation", "SAO 11336"},
        {"Wilson Evans Batten Catalogue", "WEB 587"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.51431560),
        dec: Angle.Degrees(+66.14761311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47499"},
        {"Smithsonian Astrophysical Observation", "SAO 14960"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.26128544),
        dec: Angle.Degrees(+66.14804847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42417"},
        {"Hipparcos Number", "HIP 29720"},
        {"Smithsonian Astrophysical Observation", "SAO 13768"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.90070561),
        dec: Angle.Degrees(+66.14848318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208947"},
        {"Hipparcos Number", "HIP 108364"},
        {"Geneva Identification System", "GEN# +1.00208947"},
        {"Smithsonian Astrophysical Observation", "SAO 19760"},
        {"Wilson Evans Batten Catalogue", "WEB 19518"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.29621747),
        dec: Angle.Degrees(+66.15615419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14419"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.54180644),
        dec: Angle.Degrees(+66.15718921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1050 AB"},
        {"Henry Draper", "HD 7757"},
        {"Hipparcos Number", "HIP 6156"},
        {"Smithsonian Astrophysical Observation", "SAO 11687"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73957467),
        dec: Angle.Degrees(+66.15777970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202142"},
        {"Hipparcos Number", "HIP 104543"},
        {"Smithsonian Astrophysical Observation", "SAO 19236"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.65301933),
        dec: Angle.Degrees(+66.15822403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5255 AB"},
        {"Henry Draper", "HD 46633"},
        {"Hipparcos Number", "HIP 31843"},
        {"Smithsonian Astrophysical Observation", "SAO 13912"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.86606188),
        dec: Angle.Degrees(+66.16234821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5657"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.16845974),
        dec: Angle.Degrees(+66.16335805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14337"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.22119779),
        dec: Angle.Degrees(+66.16367252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116855"},
        {"Hipparcos Number", "HIP 65435"},
        {"Smithsonian Astrophysical Observation", "SAO 16065"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16698123),
        dec: Angle.Degrees(+66.16493066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23432"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.54121011),
        dec: Angle.Degrees(+66.16571109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35857"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.89297009),
        dec: Angle.Degrees(+66.17513210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68192"},
        {"Hipparcos Number", "HIP 40462"},
        {"Geneva Identification System", "GEN# +1.00068192"},
        {"Smithsonian Astrophysical Observation", "SAO 14472"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.92549768),
        dec: Angle.Degrees(+66.17578886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11373"},
        {"Hipparcos Number", "HIP 8867"},
        {"Fundamental Katalog 5th Edition", "FK5 4172"},
        {"Geneva Identification System", "GEN# +1.00011373"},
        {"Smithsonian Astrophysical Observation", "SAO 12027"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.52575237),
        dec: Angle.Degrees(+66.17653388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11401"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.72026164),
        dec: Angle.Degrees(+66.17872336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1769"},
        {"Hipparcos Number", "HIP 1773"},
        {"Fundamental Katalog 5th Edition", "FK5 4040"},
        {"Smithsonian Astrophysical Observation", "SAO 11145"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.61193854),
        dec: Angle.Degrees(+66.18164436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39395"},
        {"Fundamental Katalog 5th Edition", "FK5 4725"},
        {"Smithsonian Astrophysical Observation", "SAO 14412"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.80548112),
        dec: Angle.Degrees(+66.18917587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47215"},
        {"Hipparcos Number", "HIP 32117"},
        {"Smithsonian Astrophysical Observation", "SAO 13929"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.62219104),
        dec: Angle.Degrees(+66.19784232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15755"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.74059776),
        dec: Angle.Degrees(+66.19944648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216228"},
        {"Hipparcos Number", "HIP 112724"},
        {"Fundamental Katalog 5th Edition", "FK5 863"},
        {"Geneva Identification System", "GEN# +1.00216228"},
        {"Smithsonian Astrophysical Observation", "SAO 20268"},
        {"Wilson Evans Batten Catalogue", "WEB 20087"},
    },
    visualMagnitude: 3.50,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.42046735),
        dec: Angle.Degrees(+66.20071089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12212"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.30500143),
        dec: Angle.Degrees(+66.20201459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17723"},
        {"Hipparcos Number", "HIP 13524"},
        {"Smithsonian Astrophysical Observation", "SAO 12496"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.54906935),
        dec: Angle.Degrees(+66.20592822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25138",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3917 AB"},
        {"Henry Draper", "HD 34491"},
        {"Hipparcos Number", "HIP 25138"},
        {"Smithsonian Astrophysical Observation", "SAO 13469"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.69565634),
        dec: Angle.Degrees(+66.20989484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100436"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.51496764),
        dec: Angle.Degrees(+66.21068216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74425"},
        {"Hipparcos Number", "HIP 43185"},
        {"Fundamental Katalog 5th Edition", "FK5 4790"},
        {"Geneva Identification System", "GEN# +1.00074425"},
        {"Smithsonian Astrophysical Observation", "SAO 14663"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.96189099),
        dec: Angle.Degrees(+66.21082455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20967"},
        {"Hipparcos Number", "HIP 16060"},
        {"Smithsonian Astrophysical Observation", "SAO 12759"},
        {"Wilson Evans Batten Catalogue", "WEB 3064"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.72068917),
        dec: Angle.Degrees(+66.21106691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70984"},
        {"Hipparcos Number", "HIP 41615"},
        {"Smithsonian Astrophysical Observation", "SAO 14566"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.26316019),
        dec: Angle.Degrees(+66.21382512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93345"},
        {"Hipparcos Number", "HIP 52836"},
        {"Smithsonian Astrophysical Observation", "SAO 15294"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.04978691),
        dec: Angle.Degrees(+66.21791243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105187"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.61460926),
        dec: Angle.Degrees(+66.22435997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 213.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61011"},
        {"Hipparcos Number", "HIP 37498"},
        {"Smithsonian Astrophysical Observation", "SAO 14283"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44446621),
        dec: Angle.Degrees(+66.22827439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95436"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.19519745),
        dec: Angle.Degrees(+66.22838457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35518"},
        {"Hipparcos Number", "HIP 25783"},
        {"Geneva Identification System", "GEN# +1.00035518"},
        {"Smithsonian Astrophysical Observation", "SAO 13516"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.57877397),
        dec: Angle.Degrees(+66.23498749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19719"},
        {"Hipparcos Number", "HIP 15069"},
        {"Smithsonian Astrophysical Observation", "SAO 12664"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.55298507),
        dec: Angle.Degrees(+66.23519680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60292"},
        {"Hipparcos Number", "HIP 37196"},
        {"Smithsonian Astrophysical Observation", "SAO 14262"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.62007519),
        dec: Angle.Degrees(+66.23523077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8989"},
        {"Hipparcos Number", "HIP 7019"},
        {"Smithsonian Astrophysical Observation", "SAO 11783"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.60430180),
        dec: Angle.Degrees(+66.24037870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44163"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.91851802),
        dec: Angle.Degrees(+66.24045017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72406"},
        {"Smithsonian Astrophysical Observation", "SAO 16512"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.07722207),
        dec: Angle.Degrees(+66.25304610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67740"},
        {"Hipparcos Number", "HIP 40301"},
        {"Geneva Identification System", "GEN# +1.00067740"},
        {"Smithsonian Astrophysical Observation", "SAO 14461"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.44478013),
        dec: Angle.Degrees(+66.25585831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184676"},
        {"Hipparcos Number", "HIP 95977"},
        {"Smithsonian Astrophysical Observation", "SAO 18381"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.75074832),
        dec: Angle.Degrees(+66.25677777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156142"},
        {"Hipparcos Number", "HIP 84047"},
        {"Smithsonian Astrophysical Observation", "SAO 17379"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.73682996),
        dec: Angle.Degrees(+66.25730109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90250"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.22037608),
        dec: Angle.Degrees(+66.26162482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40770"},
        {"Hipparcos Number", "HIP 28901"},
        {"Smithsonian Astrophysical Observation", "SAO 13709"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.52507231),
        dec: Angle.Degrees(+66.26494878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55514"},
        {"Smithsonian Astrophysical Observation", "SAO 15483"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.55323809),
        dec: Angle.Degrees(+66.26700196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72167"},
        {"Hipparcos Number", "HIP 42138"},
        {"Smithsonian Astrophysical Observation", "SAO 14593"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.84733434),
        dec: Angle.Degrees(+66.27094430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69827"},
        {"Smithsonian Astrophysical Observation", "SAO 16327"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.36188815),
        dec: Angle.Degrees(+66.27912639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42137"},
        {"Smithsonian Astrophysical Observation", "SAO 14592"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.84429608),
        dec: Angle.Degrees(+66.27950994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48859"},
        {"Hipparcos Number", "HIP 32817"},
        {"Smithsonian Astrophysical Observation", "SAO 13970"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.61764394),
        dec: Angle.Degrees(+66.27976881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210059"},
        {"Hipparcos Number", "HIP 109036"},
        {"Smithsonian Astrophysical Observation", "SAO 19857"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.33041190),
        dec: Angle.Degrees(+66.28314975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103014"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.06229252),
        dec: Angle.Degrees(+66.28406696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 291.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56192"},
        {"Smithsonian Astrophysical Observation", "SAO 15530"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.78102986),
        dec: Angle.Degrees(+66.28774636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100533"},
        {"Hipparcos Number", "HIP 56483"},
        {"Fundamental Katalog 5th Edition", "FK5 5020"},
        {"Smithsonian Astrophysical Observation", "SAO 15557"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.69850308),
        dec: Angle.Degrees(+66.28928271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114170"},
        {"Smithsonian Astrophysical Observation", "SAO 20435"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.81868410),
        dec: Angle.Degrees(+66.28928507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94978"},
        {"Hipparcos Number", "HIP 53711"},
        {"Geneva Identification System", "GEN# +1.00094978"},
        {"Smithsonian Astrophysical Observation", "SAO 15357"},
        {"Wilson Evans Batten Catalogue", "WEB 9730"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.84250276),
        dec: Angle.Degrees(+66.29211744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47522"},
        {"Hipparcos Number", "HIP 32264"},
        {"Geneva Identification System", "GEN# +1.00047522"},
        {"Smithsonian Astrophysical Observation", "SAO 13943"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04890527),
        dec: Angle.Degrees(+66.29648931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210759"},
        {"Hipparcos Number", "HIP 109441"},
        {"Smithsonian Astrophysical Observation", "SAO 19917"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.58421559),
        dec: Angle.Degrees(+66.30421619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224918"},
        {"Hipparcos Number", "HIP 142"},
        {"Smithsonian Astrophysical Observation", "SAO 21013"},
        {"Wilson Evans Batten Catalogue", "WEB 23"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.45374866),
        dec: Angle.Degrees(+66.30600204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13424 A"},
        {"Henry Draper", "HD 191700"},
        {"Hipparcos Number", "HIP 99090"},
        {"Geneva Identification System", "GEN# +1.00191700"},
        {"Smithsonian Astrophysical Observation", "SAO 18722"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.75001763),
        dec: Angle.Degrees(+66.30805078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90838"},
        {"Hipparcos Number", "HIP 51517"},
        {"Geneva Identification System", "GEN# +1.00090838"},
        {"Smithsonian Astrophysical Observation", "SAO 15207"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.82935819),
        dec: Angle.Degrees(+66.31213436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87355"},
        {"Hipparcos Number", "HIP 49552"},
        {"Smithsonian Astrophysical Observation", "SAO 15082"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.76668227),
        dec: Angle.Degrees(+66.31507385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115911"},
        {"Smithsonian Astrophysical Observation", "SAO 20656"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.26726632),
        dec: Angle.Degrees(+66.32039700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13540"},
        {"Hipparcos Number", "HIP 10466"},
        {"Geneva Identification System", "GEN# +1.00013540"},
        {"Smithsonian Astrophysical Observation", "SAO 12185"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.72961842),
        dec: Angle.Degrees(+66.32102076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113212"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.90014544),
        dec: Angle.Degrees(+66.32141019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1036"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.24686849),
        dec: Angle.Degrees(+66.32206636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197894"},
        {"Hipparcos Number", "HIP 102224"},
        {"Smithsonian Astrophysical Observation", "SAO 19002"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.70182836),
        dec: Angle.Degrees(+66.32671172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57742"},
        {"Hipparcos Number", "HIP 36211"},
        {"Fundamental Katalog 5th Edition", "FK5 2571"},
        {"Geneva Identification System", "GEN# +1.00057742"},
        {"Smithsonian Astrophysical Observation", "SAO 14195"},
        {"Wilson Evans Batten Catalogue", "WEB 7209"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.85767998),
        dec: Angle.Degrees(+66.33164165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177106"},
        {"Hipparcos Number", "HIP 93141"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.60421426),
        dec: Angle.Degrees(+66.33257337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104860"},
        {"Hipparcos Number", "HIP 58876"},
        {"Geneva Identification System", "GEN# +1.00104860"},
        {"Smithsonian Astrophysical Observation", "SAO 15703"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.14089100),
        dec: Angle.Degrees(+66.33646113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123421"},
        {"Hipparcos Number", "HIP 68798"},
        {"Smithsonian Astrophysical Observation", "SAO 16275"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.24146577),
        dec: Angle.Degrees(+66.33923907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127370"},
        {"Hipparcos Number", "HIP 70744"},
        {"Smithsonian Astrophysical Observation", "SAO 16389"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.00582218),
        dec: Angle.Degrees(+66.34047154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81593"},
        {"Smithsonian Astrophysical Observation", "SAO 17184"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.94525147),
        dec: Angle.Degrees(+66.34224067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30614"},
        {"Hipparcos Number", "HIP 22783"},
        {"Fundamental Katalog 5th Edition", "FK5 178"},
        {"Geneva Identification System", "GEN# +1.00030614"},
        {"Smithsonian Astrophysical Observation", "SAO 13298"},
        {"Wilson Evans Batten Catalogue", "WEB 4408"},
    },
    visualMagnitude: 4.26,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.51254425),
        dec: Angle.Degrees(+66.34266029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31538"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.03270590),
        dec: Angle.Degrees(+66.34505975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56599",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8228 AB"},
        {"Henry Draper", "HD 100738"},
        {"Hipparcos Number", "HIP 56599"},
        {"Smithsonian Astrophysical Observation", "SAO 15569"},
        {"Wilson Evans Batten Catalogue", "WEB 10174"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.06104162),
        dec: Angle.Degrees(+66.34512479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129499"},
        {"Hipparcos Number", "HIP 71679"},
        {"Geneva Identification System", "GEN# +1.00129499"},
        {"Smithsonian Astrophysical Observation", "SAO 16458"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.91558901),
        dec: Angle.Degrees(+66.34681074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 338"},
        {"Geneva Identification System", "GEN# +8.01660004"},
        {"Geneva Identification System 2", "GEN# +2.78220007"},
        {"New General Catalogue", "NGC 7822 7"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06734897),
        dec: Angle.Degrees(+66.34913841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120446"},
        {"Hipparcos Number", "HIP 67265"},
        {"Smithsonian Astrophysical Observation", "SAO 16181"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.79937992),
        dec: Angle.Degrees(+66.35007915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5550"},
        {"Hipparcos Number", "HIP 4572"},
        {"Celescope Catalog", "CEL 101"},
        {"Geneva Identification System", "GEN# +1.00005550"},
        {"Renson", "Renson 1470"},
        {"Smithsonian Astrophysical Observation", "SAO 11502"},
        {"Wilson Evans Batten Catalogue", "WEB 837"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.62916229),
        dec: Angle.Degrees(+66.35182541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172199"},
        {"Hipparcos Number", "HIP 91011"},
        {"Smithsonian Astrophysical Observation", "SAO 17930"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.48403039),
        dec: Angle.Degrees(+66.35693086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120248"},
    },
    visualMagnitude: 11.08,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.46143543),
        dec: Angle.Degrees(+66.35838738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206897"},
        {"Hipparcos Number", "HIP 107166"},
        {"Geneva Identification System", "GEN# +1.00206897"},
        {"Smithsonian Astrophysical Observation", "SAO 19593"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.60962004),
        dec: Angle.Degrees(+66.36219758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93088"},
        {"Hipparcos Number", "HIP 52715"},
        {"Smithsonian Astrophysical Observation", "SAO 15282"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.66797479),
        dec: Angle.Degrees(+66.36591766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36024"},
        {"Hipparcos Number", "HIP 26086"},
        {"Smithsonian Astrophysical Observation", "SAO 13533"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.45588532),
        dec: Angle.Degrees(+66.36728503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127005"},
        {"Hipparcos Number", "HIP 70567"},
        {"Smithsonian Astrophysical Observation", "SAO 16379"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.51644814),
        dec: Angle.Degrees(+66.37002982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5630 AB"},
        {"Henry Draper", "HD 50886"},
        {"Hipparcos Number", "HIP 33704"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.03648710),
        dec: Angle.Degrees(+66.37363379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146969"},
        {"Hipparcos Number", "HIP 79600"},
        {"Smithsonian Astrophysical Observation", "SAO 17006"},
        {"Wilson Evans Batten Catalogue", "WEB 13469"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.63076633),
        dec: Angle.Degrees(+66.37685456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19109"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.43579920),
        dec: Angle.Degrees(+66.37869397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19967"},
        {"Hipparcos Number", "HIP 15232"},
        {"Smithsonian Astrophysical Observation", "SAO 12677"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.10370053),
        dec: Angle.Degrees(+66.38033653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83662"},
        {"Hipparcos Number", "HIP 47655"},
        {"Smithsonian Astrophysical Observation", "SAO 14968"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.74464477),
        dec: Angle.Degrees(+66.38432692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140766"},
        {"Hipparcos Number", "HIP 76833"},
        {"Fundamental Katalog 5th Edition", "FK5 5389"},
        {"Smithsonian Astrophysical Observation", "SAO 16818"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.31050936),
        dec: Angle.Degrees(+66.38580934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107379"},
        {"Hipparcos Number", "HIP 60175"},
        {"Smithsonian Astrophysical Observation", "SAO 15774"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.09601539),
        dec: Angle.Degrees(+66.39117157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72205"},
        {"Hipparcos Number", "HIP 42160"},
        {"Smithsonian Astrophysical Observation", "SAO 14596"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.91922101),
        dec: Angle.Degrees(+66.39340246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223877"},
        {"Hipparcos Number", "HIP 117790"},
        {"Smithsonian Astrophysical Observation", "SAO 20916"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.30746063),
        dec: Angle.Degrees(+66.40326001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5326"},
        {"Hipparcos Number", "HIP 4389"},
        {"Celescope Catalog", "CEL 100"},
        {"Geneva Identification System", "GEN# +1.00005326"},
        {"Smithsonian Astrophysical Observation", "SAO 11472"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.06201923),
        dec: Angle.Degrees(+66.41277403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88475"},
        {"Hipparcos Number", "HIP 50169"},
        {"Smithsonian Astrophysical Observation", "SAO 15123"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.60893554),
        dec: Angle.Degrees(+66.41295825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94869"},
    },
    visualMagnitude: 11.40,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.58621714),
        dec: Angle.Degrees(+66.41325338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220031"},
        {"Hipparcos Number", "HIP 115174"},
        {"Smithsonian Astrophysical Observation", "SAO 20560"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92463571),
        dec: Angle.Degrees(+66.41606533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163788"},
        {"Hipparcos Number", "HIP 87530"},
        {"Smithsonian Astrophysical Observation", "SAO 17671"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.23347826),
        dec: Angle.Degrees(+66.41907043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53962"},
        {"Smithsonian Astrophysical Observation", "SAO 15369"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60134520),
        dec: Angle.Degrees(+66.41987693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212117"},
        {"Hipparcos Number", "HIP 110241"},
        {"Smithsonian Astrophysical Observation", "SAO 20011"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.95751393),
        dec: Angle.Degrees(+66.42204886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142516"},
        {"Hipparcos Number", "HIP 77612"},
        {"Geneva Identification System", "GEN# +1.00142516"},
        {"Smithsonian Astrophysical Observation", "SAO 16873"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.67122080),
        dec: Angle.Degrees(+66.42883383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178472"},
        {"Hipparcos Number", "HIP 93630"},
        {"Smithsonian Astrophysical Observation", "SAO 18141"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.00465836),
        dec: Angle.Degrees(+66.42886145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118118"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39208315),
        dec: Angle.Degrees(+66.43162890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123470"},
        {"Hipparcos Number", "HIP 68812"},
        {"Smithsonian Astrophysical Observation", "SAO 16276"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.31645360),
        dec: Angle.Degrees(+66.43371209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5110"},
        {"Hipparcos Number", "HIP 4239"},
        {"Geneva Identification System", "GEN# +1.00005110"},
        {"Smithsonian Astrophysical Observation", "SAO 11453"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.52510497),
        dec: Angle.Degrees(+66.43552948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5849"},
        {"Hipparcos Number", "HIP 4782"},
        {"Smithsonian Astrophysical Observation", "SAO 11527"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.35351807),
        dec: Angle.Degrees(+66.43771499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19865"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.90399577),
        dec: Angle.Degrees(+66.44573023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6415"},
        {"Hipparcos Number", "HIP 5190"},
        {"Smithsonian Astrophysical Observation", "SAO 11570"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.60873708),
        dec: Angle.Degrees(+66.44701017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75107"},
        {"Hipparcos Number", "HIP 43523"},
        {"Geneva Identification System", "GEN# +1.00075107"},
        {"Smithsonian Astrophysical Observation", "SAO 14683"},
        {"Wilson Evans Batten Catalogue", "WEB 8388"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.96620638),
        dec: Angle.Degrees(+66.44869123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8717",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1471 A"},
        {"Henry Draper", "HD 11161"},
        {"Hipparcos Number", "HIP 8717"},
        {"Cincinnati Publication", "Ci 18 246"},
        {"Smithsonian Astrophysical Observation", "SAO 12013"},
        {"Wilson Evans Batten Catalogue", "WEB 1836"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.04224513),
        dec: Angle.Degrees(+66.44910515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 283.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95294"},
        {"Hipparcos Number", "HIP 53891"},
        {"Smithsonian Astrophysical Observation", "SAO 15363"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.39928271),
        dec: Angle.Degrees(+66.44975873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1471 B"},
        {"Hipparcos Number", "HIP 8713"},
    },
    visualMagnitude: 10.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)52, 08.7300),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)27, 15.600)
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
    primaryId: "HIP 66919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119730"},
        {"Hipparcos Number", "HIP 66919"},
        {"Smithsonian Astrophysical Observation", "SAO 16148"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.72101933),
        dec: Angle.Degrees(+66.45515329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84896"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.25531922),
        dec: Angle.Degrees(+66.45608108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 404"},
        {"Hipparcos Number", "HIP 723"},
        {"Geneva Identification System", "GEN# +1.00000404"},
        {"Smithsonian Astrophysical Observation", "SAO 11002"},
        {"Wilson Evans Batten Catalogue", "WEB 120"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.23740813),
        dec: Angle.Degrees(+66.45664771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 296 D"},
        {"Henry Draper", "HD 1732"},
        {"Hipparcos Number", "HIP 1748"},
        {"Geneva Identification System", "GEN# +1.00001732"},
        {"Renson", "Renson 380"},
        {"Smithsonian Astrophysical Observation", "SAO 11141"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.53496185),
        dec: Angle.Degrees(+66.46084366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20435"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.65695981),
        dec: Angle.Degrees(+66.46126251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109518"},
        {"Smithsonian Astrophysical Observation", "SAO 19924"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.78302891),
        dec: Angle.Degrees(+66.46138748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192800"},
        {"Hipparcos Number", "HIP 99586"},
        {"Smithsonian Astrophysical Observation", "SAO 18764"},
        {"Wilson Evans Batten Catalogue", "WEB 17825"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.14623201),
        dec: Angle.Degrees(+66.46153379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70352"},
        {"Hipparcos Number", "HIP 41308"},
        {"Cincinnati Publication", "Ci 18 982"},
        {"Cincinnati Publication 2", "Ci 20 472"},
        {"Geneva Identification System", "GEN# +1.00070352"},
        {"Smithsonian Astrophysical Observation", "SAO 14541"},
        {"Wilson Evans Batten Catalogue", "WEB 7991"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.41875604),
        dec: Angle.Degrees(+66.46349546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -501.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19255"},
        {"Hipparcos Number", "HIP 14686"},
        {"Geneva Identification System", "GEN# +1.00019255"},
        {"Smithsonian Astrophysical Observation", "SAO 12622"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.42970799),
        dec: Angle.Degrees(+66.46572037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186406"},
        {"Hipparcos Number", "HIP 96715"},
        {"Smithsonian Astrophysical Observation", "SAO 18460"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.91338955),
        dec: Angle.Degrees(+66.46794991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59720"},
        {"Hipparcos Number", "HIP 36983"},
        {"Smithsonian Astrophysical Observation", "SAO 14247"},
        {"Wilson Evans Batten Catalogue", "WEB 7337"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.01856807),
        dec: Angle.Degrees(+66.47029517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168266"},
        {"Hipparcos Number", "HIP 89344"},
        {"Geneva Identification System", "GEN# +1.00168266"},
        {"Smithsonian Astrophysical Observation", "SAO 17829"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.45270238),
        dec: Angle.Degrees(+66.47242854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213481"},
        {"Hipparcos Number", "HIP 111042"},
        {"Geneva Identification System", "GEN# +1.00213481"},
        {"Smithsonian Astrophysical Observation", "SAO 20107"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.43713592),
        dec: Angle.Degrees(+66.47761233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10152"},
        {"Hipparcos Number", "HIP 7887"},
        {"Geneva Identification System", "GEN# +1.00010152"},
        {"Smithsonian Astrophysical Observation", "SAO 11912"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.36561309),
        dec: Angle.Degrees(+66.48870683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57878"},
        {"Hipparcos Number", "HIP 36270"},
        {"Geneva Identification System", "GEN# +1.00057878"},
        {"Smithsonian Astrophysical Observation", "SAO 14201"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01717899),
        dec: Angle.Degrees(+66.49121632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4243"},
        {"Hipparcos Number", "HIP 3587"},
        {"Geneva Identification System", "GEN# +1.00004243"},
        {"Smithsonian Astrophysical Observation", "SAO 11374"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.44840072),
        dec: Angle.Degrees(+66.49284151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9264"},
        {"Smithsonian Astrophysical Observation", "SAO 12068"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.76768469),
        dec: Angle.Degrees(+66.49338047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30376"},
        {"Hipparcos Number", "HIP 22615"},
        {"Geneva Identification System", "GEN# +1.00030376"},
        {"Smithsonian Astrophysical Observation", "SAO 13288"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.98735308),
        dec: Angle.Degrees(+66.49622492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114987"},
        {"Smithsonian Astrophysical Observation", "SAO 20537"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.33468431),
        dec: Angle.Degrees(+66.50008945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43119"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.72537281),
        dec: Angle.Degrees(+66.50691657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44002"},
        {"Hipparcos Number", "HIP 30481"},
        {"Fundamental Katalog 5th Edition", "FK5 4580"},
        {"Geneva Identification System", "GEN# +1.00044002"},
        {"Smithsonian Astrophysical Observation", "SAO 13825"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.11192818),
        dec: Angle.Degrees(+66.51352394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13195"},
        {"Hipparcos Number", "HIP 10240"},
        {"Geneva Identification System", "GEN# +1.00013195"},
        {"Smithsonian Astrophysical Observation", "SAO 12162"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.92937401),
        dec: Angle.Degrees(+66.51435556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225271"},
        {"Hipparcos Number", "HIP 412"},
        {"Smithsonian Astrophysical Observation", "SAO 10961"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.25755802),
        dec: Angle.Degrees(+66.51678960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2729"},
        {"Hipparcos Number", "HIP 2474"},
        {"Geneva Identification System", "GEN# +1.00002729"},
        {"Smithsonian Astrophysical Observation", "SAO 11243"},
        {"Wilson Evans Batten Catalogue", "WEB 450"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.85500767),
        dec: Angle.Degrees(+66.51962673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65733"},
        {"Hipparcos Number", "HIP 39516"},
        {"Smithsonian Astrophysical Observation", "SAO 14420"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.14699050),
        dec: Angle.Degrees(+66.51980431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215065"},
        {"Hipparcos Number", "HIP 111977"},
        {"Cincinnati Publication", "Ci 20 1377"},
        {"Cincinnati Publication 2", "Ci 18 2956"},
        {"Geneva Identification System", "GEN# +1.00215065"},
        {"Smithsonian Astrophysical Observation", "SAO 20205"},
        {"Wilson Evans Batten Catalogue", "WEB 19994"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.22665442),
        dec: Angle.Degrees(+66.52248607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 388.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13475"},
        {"Henry Draper 2", "HD 13474"},
        {"Hipparcos Number", "HIP 10438"},
        {"Fundamental Katalog 5th Edition", "FK5 76"},
        {"Geneva Identification System", "GEN# +1.00013474"},
        {"Smithsonian Astrophysical Observation", "SAO 12180"},
        {"Wilson Evans Batten Catalogue", "WEB 2183"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.62126544),
        dec: Angle.Degrees(+66.52444205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83357"},
        {"Smithsonian Astrophysical Observation", "SAO 17326"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.54225269),
        dec: Angle.Degrees(+66.52805636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3452 A"},
        {"Henry Draper", "HD 30164"},
        {"Hipparcos Number", "HIP 22465"},
        {"Smithsonian Astrophysical Observation", "SAO 13278"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.52267916),
        dec: Angle.Degrees(+66.53542188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93740"},
        {"Hipparcos Number", "HIP 53028"},
        {"Smithsonian Astrophysical Observation", "SAO 15310"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.74314773),
        dec: Angle.Degrees(+66.53848463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17566"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.43377020),
        dec: Angle.Degrees(+66.53869032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26989",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4267 ABC"},
        {"Henry Draper", "HD 37419"},
        {"Hipparcos Number", "HIP 26989"},
        {"Smithsonian Astrophysical Observation", "SAO 13577"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.89483861),
        dec: Angle.Degrees(+66.54466965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69733"},
        {"Hipparcos Number", "HIP 41047"},
        {"Smithsonian Astrophysical Observation", "SAO 14518"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.64691919),
        dec: Angle.Degrees(+66.54531399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187103"},
        {"Hipparcos Number", "HIP 97069"},
        {"Geneva Identification System", "GEN# +1.00187103"},
        {"Smithsonian Astrophysical Observation", "SAO 18499"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.91317448),
        dec: Angle.Degrees(+66.54532352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126409"},
        {"Hipparcos Number", "HIP 70245"},
        {"Smithsonian Astrophysical Observation", "SAO 16357"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.59293567),
        dec: Angle.Degrees(+66.54629874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26308"},
        {"Hipparcos Number", "HIP 19764"},
        {"Fundamental Katalog 5th Edition", "FK5 4386"},
        {"Smithsonian Astrophysical Observation", "SAO 13068"},
    },
    visualMagnitude: 8.27,
    bvColour: 2.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.56312321),
        dec: Angle.Degrees(+66.54791826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4267 D"},
        {"Hipparcos Number", "HIP 27000"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.91984000),
        dec: Angle.Degrees(+66.54847977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14824"},
        {"Hipparcos Number", "HIP 11370"},
        {"Smithsonian Astrophysical Observation", "SAO 12279"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.61426627),
        dec: Angle.Degrees(+66.54891852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222857"},
        {"Hipparcos Number", "HIP 117062"},
        {"Smithsonian Astrophysical Observation", "SAO 20807"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.98065048),
        dec: Angle.Degrees(+66.55206448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112717",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16298 AB"},
        {"Henry Draper", "HD 216227"},
        {"Hipparcos Number", "HIP 112717"},
        {"Celescope Catalog", "CEL 5531"},
        {"Geneva Identification System", "GEN# +1.00216227J"},
        {"Smithsonian Astrophysical Observation", "SAO 20267"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.40085359),
        dec: Angle.Degrees(+66.55386854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137826"},
        {"Hipparcos Number", "HIP 75370"},
        {"Cincinnati Publication", "Ci 18 2067"},
        {"Geneva Identification System", "GEN# +1.00137826"},
        {"Smithsonian Astrophysical Observation", "SAO 16725"},
        {"Wilson Evans Batten Catalogue", "WEB 12857"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.02231234),
        dec: Angle.Degrees(+66.55400233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160289"},
        {"Hipparcos Number", "HIP 85955"},
        {"Smithsonian Astrophysical Observation", "SAO 17540"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.51042595),
        dec: Angle.Degrees(+66.55836682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157892"},
        {"Hipparcos Number", "HIP 84890"},
        {"Smithsonian Astrophysical Observation", "SAO 17446"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.23632643),
        dec: Angle.Degrees(+66.56258642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84699"},
        {"Hipparcos Number", "HIP 48214"},
        {"Geneva Identification System", "GEN# +1.00084699"},
        {"Smithsonian Astrophysical Observation", "SAO 14995"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.45058554),
        dec: Angle.Degrees(+66.56309873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6450 AB"},
        {"Henry Draper", "HD 64034"},
        {"Hipparcos Number", "HIP 38812"},
        {"Smithsonian Astrophysical Observation", "SAO 14372"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.14807297),
        dec: Angle.Degrees(+66.56359687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143253"},
        {"Hipparcos Number", "HIP 77949"},
        {"Smithsonian Astrophysical Observation", "SAO 16896"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.77176903),
        dec: Angle.Degrees(+66.56543931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72911"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52540607),
        dec: Angle.Degrees(+66.57687529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28133"},
        {"Hipparcos Number", "HIP 21074"},
        {"Smithsonian Astrophysical Observation", "SAO 13164"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.75714270),
        dec: Angle.Degrees(+66.57758831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7423"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.90962348),
        dec: Angle.Degrees(+66.58090424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198022"},
        {"Hipparcos Number", "HIP 102312"},
        {"Smithsonian Astrophysical Observation", "SAO 19012"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.95193209),
        dec: Angle.Degrees(+66.58118484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58923"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.24350088),
        dec: Angle.Degrees(+66.58209668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113092"},
        {"Hipparcos Number", "HIP 63432"},
        {"Geneva Identification System", "GEN# +1.00113092"},
        {"Smithsonian Astrophysical Observation", "SAO 15960"},
        {"Wilson Evans Batten Catalogue", "WEB 11226"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.98031630),
        dec: Angle.Degrees(+66.59730755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112068"},
        {"Hipparcos Number", "HIP 62839"},
        {"Smithsonian Astrophysical Observation", "SAO 15926"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.15257892),
        dec: Angle.Degrees(+66.59804671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61126"},
        {"Smithsonian Astrophysical Observation", "SAO 15820"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.90105111),
        dec: Angle.Degrees(+66.60074981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118937"},
        {"Hipparcos Number", "HIP 66520"},
        {"Fundamental Katalog 5th Edition", "FK5 5203"},
        {"Smithsonian Astrophysical Observation", "SAO 16129"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.52316425),
        dec: Angle.Degrees(+66.60634165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12006"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.68606361),
        dec: Angle.Degrees(+66.61210423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146756"},
        {"Hipparcos Number", "HIP 79491"},
        {"Geneva Identification System", "GEN# +1.00146756"},
        {"Smithsonian Astrophysical Observation", "SAO 17000"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.32475840),
        dec: Angle.Degrees(+66.61485880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54155"},
        {"Hipparcos Number", "HIP 34857"},
        {"Smithsonian Astrophysical Observation", "SAO 14111"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20028390),
        dec: Angle.Degrees(+66.61646025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132523"},
        {"Hipparcos Number", "HIP 73076"},
        {"Smithsonian Astrophysical Observation", "SAO 16554"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.02199976),
        dec: Angle.Degrees(+66.61853323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80283"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.83414104),
        dec: Angle.Degrees(+66.62282484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37465"},
        {"Hipparcos Number", "HIP 27025"},
        {"Smithsonian Astrophysical Observation", "SAO 13578"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.98620780),
        dec: Angle.Degrees(+66.62631374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82620"},
        {"Smithsonian Astrophysical Observation", "SAO 17262"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35454541),
        dec: Angle.Degrees(+66.62674020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40206"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.17904374),
        dec: Angle.Degrees(+66.62748027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43296"},
        {"Hipparcos Number", "HIP 30152"},
        {"Smithsonian Astrophysical Observation", "SAO 13806"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.17291865),
        dec: Angle.Degrees(+66.62923214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108096"},
        {"Smithsonian Astrophysical Observation", "SAO 19728"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.51637634),
        dec: Angle.Degrees(+66.63412144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203231"},
        {"Hipparcos Number", "HIP 105122"},
        {"Geneva Identification System", "GEN# +1.00203231"},
        {"Smithsonian Astrophysical Observation", "SAO 19292"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.41292054),
        dec: Angle.Degrees(+66.63850294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43015"},
        {"Hipparcos Number", "HIP 30033"},
        {"Smithsonian Astrophysical Observation", "SAO 13797"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.79822630),
        dec: Angle.Degrees(+66.65009276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197950"},
        {"Hipparcos Number", "HIP 102253"},
        {"Fundamental Katalog 5th Edition", "FK5 3656"},
        {"Geneva Identification System", "GEN# +1.00197950"},
        {"Smithsonian Astrophysical Observation", "SAO 19004"},
        {"Wilson Evans Batten Catalogue", "WEB 18505"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.79576497),
        dec: Angle.Degrees(+66.65736293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84386"},
        {"Smithsonian Astrophysical Observation", "SAO 17407"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.78728236),
        dec: Angle.Degrees(+66.65769618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138663"},
        {"Hipparcos Number", "HIP 75817"},
        {"Smithsonian Astrophysical Observation", "SAO 16747"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.32574737),
        dec: Angle.Degrees(+66.65831226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17176"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.18203233),
        dec: Angle.Degrees(+66.66191613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112797"},
        {"Hipparcos Number", "HIP 63289"},
        {"Smithsonian Astrophysical Observation", "SAO 15953"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.54620104),
        dec: Angle.Degrees(+66.66453578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138916"},
        {"Hipparcos Number", "HIP 75983"},
        {"Geneva Identification System", "GEN# +1.00138916"},
        {"Smithsonian Astrophysical Observation", "SAO 16759"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.75970891),
        dec: Angle.Degrees(+66.67122861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90318"},
        {"Hipparcos Number", "HIP 51223"},
        {"Geneva Identification System", "GEN# +1.00090318"},
        {"Smithsonian Astrophysical Observation", "SAO 15184"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.93582088),
        dec: Angle.Degrees(+66.67971239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98196"},
        {"Hipparcos Number", "HIP 55241"},
        {"Smithsonian Astrophysical Observation", "SAO 15470"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.69480419),
        dec: Angle.Degrees(+66.68425432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194297"},
        {"Hipparcos Number", "HIP 100314"},
        {"Smithsonian Astrophysical Observation", "SAO 18824"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17631993),
        dec: Angle.Degrees(+66.69375307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36496"},
        {"Hipparcos Number", "HIP 26410"},
        {"Smithsonian Astrophysical Observation", "SAO 13548"},
        {"Wilson Evans Batten Catalogue", "WEB 5207"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31687949),
        dec: Angle.Degrees(+66.69671501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188852"},
        {"Hipparcos Number", "HIP 97812"},
        {"Geneva Identification System", "GEN# +1.00188852"},
        {"Smithsonian Astrophysical Observation", "SAO 18576"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.14359897),
        dec: Angle.Degrees(+66.70527025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110405",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15881"},
        {"Hipparcos Number", "HIP 110405"},
        {"Geneva Identification System", "GEN# +1.00212391"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.43822781),
        dec: Angle.Degrees(+66.70624807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77495"},
        {"Hipparcos Number", "HIP 44695"},
        {"Smithsonian Astrophysical Observation", "SAO 14762"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.62095076),
        dec: Angle.Degrees(+66.70639375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74604"},
        {"Hipparcos Number", "HIP 43266"},
        {"Geneva Identification System", "GEN# +1.00074604"},
        {"Smithsonian Astrophysical Observation", "SAO 14667"},
        {"Wilson Evans Batten Catalogue", "WEB 8340"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.20533270),
        dec: Angle.Degrees(+66.70816839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74223"},
        {"Smithsonian Astrophysical Observation", "SAO 16627"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.52840108),
        dec: Angle.Degrees(+66.70877320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103758",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14578 AB"},
        {"Henry Draper", "HD 200708"},
        {"Hipparcos Number", "HIP 103758"},
        {"Smithsonian Astrophysical Observation", "SAO 19156"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.38461304),
        dec: Angle.Degrees(+66.70932246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202181"},
        {"Hipparcos Number", "HIP 104562"},
        {"Smithsonian Astrophysical Observation", "SAO 19238"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.71245293),
        dec: Angle.Degrees(+66.70948130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225136"},
        {"Hipparcos Number", "HIP 302"},
        {"Geneva Identification System", "GEN# +1.00225136"},
        {"Smithsonian Astrophysical Observation", "SAO 10948"},
        {"Wilson Evans Batten Catalogue", "WEB 44"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.96511407),
        dec: Angle.Degrees(+66.71220273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105802"},
        {"Fundamental Katalog 5th Edition", "FK5 5888"},
        {"Smithsonian Astrophysical Observation", "SAO 19404"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.40902235),
        dec: Angle.Degrees(+66.71418487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102479"},
        {"Hipparcos Number", "HIP 57575"},
        {"Smithsonian Astrophysical Observation", "SAO 15636"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.03084496),
        dec: Angle.Degrees(+66.71667388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29207"},
        {"Smithsonian Astrophysical Observation", "SAO 13729"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39517560),
        dec: Angle.Degrees(+66.71716162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109126"},
        {"Hipparcos Number", "HIP 61144"},
        {"Smithsonian Astrophysical Observation", "SAO 15821"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.94938441),
        dec: Angle.Degrees(+66.71785564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47502"},
    },
    visualMagnitude: 11.31,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.27231921),
        dec: Angle.Degrees(+66.72167134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205741"},
        {"Hipparcos Number", "HIP 106515"},
        {"Smithsonian Astrophysical Observation", "SAO 19510"},
        {"Wilson Evans Batten Catalogue", "WEB 19274"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.60767059),
        dec: Angle.Degrees(+66.72652343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13449"},
        {"Hipparcos Number", "HIP 10420"},
        {"Smithsonian Astrophysical Observation", "SAO 12177"},
        {"Wilson Evans Batten Catalogue", "WEB 2181"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.57103691),
        dec: Angle.Degrees(+66.72836168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108110"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.55900174),
        dec: Angle.Degrees(+66.73147224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16404"},
        {"Cincinnati Publication", "Ci 20 236"},
        {"Geneva Identification System", "GEN# +0.06600268"},
        {"Wilson Evans Batten Catalogue", "WEB 3132"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.81517030),
        dec: Angle.Degrees(+66.73287495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1190.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1066.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29400"},
        {"Hipparcos Number", "HIP 21921"},
        {"Geneva Identification System", "GEN# +1.00029400"},
        {"Smithsonian Astrophysical Observation", "SAO 13236"},
        {"Wilson Evans Batten Catalogue", "WEB 4209"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.70706374),
        dec: Angle.Degrees(+66.73559432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 355.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52155"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.82765981),
        dec: Angle.Degrees(+66.73703601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216350"},
        {"Hipparcos Number", "HIP 112817"},
        {"Smithsonian Astrophysical Observation", "SAO 20277"},
        {"Wilson Evans Batten Catalogue", "WEB 20096"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.69986934),
        dec: Angle.Degrees(+66.73788032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220574"},
        {"Hipparcos Number", "HIP 115516"},
        {"Geneva Identification System", "GEN# +1.00220574"},
        {"Smithsonian Astrophysical Observation", "SAO 20604"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.99791990),
        dec: Angle.Degrees(+66.73837386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97003"},
        {"Hipparcos Number", "HIP 54655"},
        {"Smithsonian Astrophysical Observation", "SAO 15424"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.81807369),
        dec: Angle.Degrees(+66.73884725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55745"},
        {"Hipparcos Number", "HIP 35449"},
        {"Geneva Identification System", "GEN# +1.00055745"},
        {"Smithsonian Astrophysical Observation", "SAO 14145"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.78528334),
        dec: Angle.Degrees(+66.74000152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101673"},
        {"Hipparcos Number", "HIP 57111"},
        {"Fundamental Katalog 5th Edition", "FK5 440"},
        {"Geneva Identification System", "GEN# +1.00101673"},
        {"Smithsonian Astrophysical Observation", "SAO 15606"},
        {"Wilson Evans Batten Catalogue", "WEB 10281"},
    },
    visualMagnitude: 5.32,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.61844968),
        dec: Angle.Degrees(+66.74480850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34200"},
        {"Hipparcos Number", "HIP 24955"},
        {"Geneva Identification System", "GEN# +1.00034200"},
        {"Smithsonian Astrophysical Observation", "SAO 13458"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.16954675),
        dec: Angle.Degrees(+66.74681944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189344"},
        {"Hipparcos Number", "HIP 98006"},
        {"Smithsonian Astrophysical Observation", "SAO 18601"},
        {"Wilson Evans Batten Catalogue", "WEB 17258"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.75491171),
        dec: Angle.Degrees(+66.74840411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3038"},
        {"Hipparcos Number", "HIP 2707"},
        {"Geneva Identification System", "GEN# +1.00003038"},
        {"Smithsonian Astrophysical Observation", "SAO 11265"},
        {"Wilson Evans Batten Catalogue", "WEB 489"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.60369264),
        dec: Angle.Degrees(+66.75035211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99231"},
        {"Hipparcos Number", "HIP 55803"},
        {"Smithsonian Astrophysical Observation", "SAO 15502"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.51548513),
        dec: Angle.Degrees(+66.75438765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122599"},
        {"Hipparcos Number", "HIP 68404"},
        {"Smithsonian Astrophysical Observation", "SAO 16246"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.04702561),
        dec: Angle.Degrees(+66.75443430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149880"},
        {"Hipparcos Number", "HIP 81014"},
        {"Geneva Identification System", "GEN# +1.00149880"},
        {"Smithsonian Astrophysical Observation", "SAO 17137"},
        {"Wilson Evans Batten Catalogue", "WEB 13703"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.16773118),
        dec: Angle.Degrees(+66.75496699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96757"},
        {"Hipparcos Number", "HIP 54564"},
        {"Geneva Identification System", "GEN# +1.00096757"},
        {"Smithsonian Astrophysical Observation", "SAO 15417"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.47393864),
        dec: Angle.Degrees(+66.75682052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3709"},
        {"Smithsonian Astrophysical Observation", "SAO 11392"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.90922057),
        dec: Angle.Degrees(+66.75706141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28126"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.18213712),
        dec: Angle.Degrees(+66.75833250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2186"},
        {"Hipparcos Number", "HIP 2093"},
        {"Smithsonian Astrophysical Observation", "SAO 11190"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.60149197),
        dec: Angle.Degrees(+66.76087438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113944"},
        {"Geneva Identification System", "GEN# +0.06501846"},
        {"Wilson Evans Batten Catalogue", "WEB 20235"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.12398852),
        dec: Angle.Degrees(+66.76457853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 303.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85893"},
        {"Hipparcos Number", "HIP 48834"},
        {"Fundamental Katalog 5th Edition", "FK5 4886"},
        {"Smithsonian Astrophysical Observation", "SAO 15031"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.42580316),
        dec: Angle.Degrees(+66.76931385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205776"},
        {"Hipparcos Number", "HIP 106538"},
        {"Smithsonian Astrophysical Observation", "SAO 19511"},
        {"Wilson Evans Batten Catalogue", "WEB 19277"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.66246425),
        dec: Angle.Degrees(+66.77232595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210058"},
        {"Hipparcos Number", "HIP 109028"},
        {"Smithsonian Astrophysical Observation", "SAO 19855"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.30737840),
        dec: Angle.Degrees(+66.77524755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38156"},
        {"Smithsonian Astrophysical Observation", "SAO 14332"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.28517495),
        dec: Angle.Degrees(+66.77876312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171063"},
        {"Hipparcos Number", "HIP 90462"},
        {"Smithsonian Astrophysical Observation", "SAO 17896"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.89015257),
        dec: Angle.Degrees(+66.77887209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35850"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.87176716),
        dec: Angle.Degrees(+66.77927420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223128"},
        {"Hipparcos Number", "HIP 117265"},
        {"Celescope Catalog", "CEL 5670"},
        {"Geneva Identification System", "GEN# +1.00223128"},
        {"Renson", "Renson 61164"},
        {"Smithsonian Astrophysical Observation", "SAO 20838"},
        {"Wilson Evans Batten Catalogue", "WEB 20662"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.65302168),
        dec: Angle.Degrees(+66.78225128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79871"},
        {"Hipparcos Number", "HIP 45775"},
        {"Smithsonian Astrophysical Observation", "SAO 14843"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.00208259),
        dec: Angle.Degrees(+66.78445955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8458"},
        {"Smithsonian Astrophysical Observation", "SAO 11994"},
    },
    visualMagnitude: 9.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.26966279),
        dec: Angle.Degrees(+66.78515654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169485"},
        {"Hipparcos Number", "HIP 89815"},
        {"Smithsonian Astrophysical Observation", "SAO 17858"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.94457549),
        dec: Angle.Degrees(+66.78539085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78811"},
        {"Cincinnati Publication", "Ci 18 2165"},
        {"Geneva Identification System", "GEN# +0.06700925"},
        {"Smithsonian Astrophysical Observation", "SAO 16952"},
        {"Wilson Evans Batten Catalogue", "WEB 13325"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.33643551),
        dec: Angle.Degrees(+66.78911028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62423",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tianyi"},
        {"Henry Draper", "HD 111335"},
        {"Hipparcos Number", "HIP 62423"},
        {"Fundamental Katalog 5th Edition", "FK5 3020"},
        {"Geneva Identification System", "GEN# +1.00111335"},
        {"Smithsonian Astrophysical Observation", "SAO 15902"},
        {"Wilson Evans Batten Catalogue", "WEB 11083"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.89308893),
        dec: Angle.Degrees(+66.79031573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189978"},
        {"Hipparcos Number", "HIP 98297"},
        {"Smithsonian Astrophysical Observation", "SAO 18629"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.58999902),
        dec: Angle.Degrees(+66.79049873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15366 A"},
        {"Henry Draper", "HD 207826"},
        {"Hipparcos Number", "HIP 107710"},
        {"Geneva Identification System", "GEN# +1.00207826A"},
        {"Smithsonian Astrophysical Observation", "SAO 19665"},
        {"Wilson Evans Batten Catalogue", "WEB 19427"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.28384924),
        dec: Angle.Degrees(+66.79219333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10222"},
        {"Hipparcos Number", "HIP 7956"},
        {"Smithsonian Astrophysical Observation", "SAO 11918"},
        {"Wilson Evans Batten Catalogue", "WEB 1702"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.53904539),
        dec: Angle.Degrees(+66.79234761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7425 B"},
        {"Hipparcos Number", "HIP 46960"},
        {"Smithsonian Astrophysical Observation", "SAO 14922"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.57471766),
        dec: Angle.Degrees(+66.79406657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125556"},
        {"Hipparcos Number", "HIP 69816"},
        {"Wilson Evans Batten Catalogue", "WEB 12151"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.33293731),
        dec: Angle.Degrees(+66.79420534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128577"},
        {"Hipparcos Number", "HIP 71266"},
        {"Geneva Identification System", "GEN# +1.00128577"},
        {"Smithsonian Astrophysical Observation", "SAO 16435"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.62698376),
        dec: Angle.Degrees(+66.79467483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46964",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7425 A"},
        {"Henry Draper", "HD 82285"},
        {"Hipparcos Number", "HIP 46964"},
        {"Smithsonian Astrophysical Observation", "SAO 14923"},
        {"Wilson Evans Batten Catalogue", "WEB 8852"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.58148506),
        dec: Angle.Degrees(+66.79509545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78512"},
        {"Geneva Identification System", "GEN# +0.06700922"},
        {"Smithsonian Astrophysical Observation", "SAO 16931"},
        {"Wilson Evans Batten Catalogue", "WEB 13272"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.42092763),
        dec: Angle.Degrees(+66.80282974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76655"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.80544146),
        dec: Angle.Degrees(+66.80297416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -343.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204770"},
        {"Hipparcos Number", "HIP 105972"},
        {"Fundamental Katalog 5th Edition", "FK5 3718"},
        {"Geneva Identification System", "GEN# +1.00204770"},
        {"Smithsonian Astrophysical Observation", "SAO 19432"},
        {"Wilson Evans Batten Catalogue", "WEB 19213"},
    },
    visualMagnitude: 5.42,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.94232234),
        dec: Angle.Degrees(+66.80914613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174788"},
        {"Hipparcos Number", "HIP 92187"},
        {"Smithsonian Astrophysical Observation", "SAO 18025"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.82744587),
        dec: Angle.Degrees(+66.81009417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19456"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.50343684),
        dec: Angle.Degrees(+66.81387889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3564"},
        {"Hipparcos Number", "HIP 3098"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.85798996),
        dec: Angle.Degrees(+66.81910741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58594"},
        {"Hipparcos Number", "HIP 36549"},
        {"Geneva Identification System", "GEN# +1.00058594"},
        {"Smithsonian Astrophysical Observation", "SAO 14215"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.77432195),
        dec: Angle.Degrees(+66.81918468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48258"},
        {"Smithsonian Astrophysical Observation", "SAO 14999"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.57040189),
        dec: Angle.Degrees(+66.81954271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16387 AB"},
        {"Hipparcos Number", "HIP 113267"},
        {"Smithsonian Astrophysical Observation", "SAO 20330"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.04454198),
        dec: Angle.Degrees(+66.82035113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94175"},
        {"Hipparcos Number", "HIP 53280"},
        {"Geneva Identification System", "GEN# +1.00094175"},
        {"Smithsonian Astrophysical Observation", "SAO 15323"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.45017935),
        dec: Angle.Degrees(+66.82136495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31675"},
        {"Hipparcos Number", "HIP 23484"},
        {"Geneva Identification System", "GEN# +1.00031675"},
        {"Smithsonian Astrophysical Observation", "SAO 13344"},
        {"Wilson Evans Batten Catalogue", "WEB 4569"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.70974597),
        dec: Angle.Degrees(+66.82378884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83652"},
        {"Smithsonian Astrophysical Observation", "SAO 17350"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.45975103),
        dec: Angle.Degrees(+66.83538003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15398 AB"},
        {"Henry Draper", "HD 208074"},
        {"Hipparcos Number", "HIP 107855"},
        {"Smithsonian Astrophysical Observation", "SAO 19680"},
        {"Wilson Evans Batten Catalogue", "WEB 19450"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.77053701),
        dec: Angle.Degrees(+66.83742555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87509"},
        {"Hipparcos Number", "HIP 49638"},
        {"Geneva Identification System", "GEN# +1.00087509"},
        {"Smithsonian Astrophysical Observation", "SAO 15088"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.97740124),
        dec: Angle.Degrees(+66.83780242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14432"},
        {"Hipparcos Number", "HIP 11105"},
        {"Geneva Identification System", "GEN# +1.00014432"},
        {"Smithsonian Astrophysical Observation", "SAO 12255"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.73129857),
        dec: Angle.Degrees(+66.84395306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25818"},
        {"Hipparcos Number", "HIP 19473"},
        {"Smithsonian Astrophysical Observation", "SAO 13045"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.55787502),
        dec: Angle.Degrees(+66.84667064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222552"},
        {"Hipparcos Number", "HIP 116855"},
        {"Geneva Identification System", "GEN# +1.00222552"},
        {"Smithsonian Astrophysical Observation", "SAO 20777"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.29620100),
        dec: Angle.Degrees(+66.84667544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107905"},
        {"Smithsonian Astrophysical Observation", "SAO 19689"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.93652918),
        dec: Angle.Degrees(+66.84792810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224826"},
        {"Hipparcos Number", "HIP 73"},
        {"Smithsonian Astrophysical Observation", "SAO 20995"},
        {"Wilson Evans Batten Catalogue", "WEB 7"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.22045719),
        dec: Angle.Degrees(+66.84796687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47387"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.81212444),
        dec: Angle.Degrees(+66.84984118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191939"},
        {"Hipparcos Number", "HIP 99175"},
        {"Smithsonian Astrophysical Observation", "SAO 18731"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.02304848),
        dec: Angle.Degrees(+66.85073211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193664"},
        {"Hipparcos Number", "HIP 100017"},
        {"Cincinnati Publication", "Ci 20 1203"},
        {"Geneva Identification System", "GEN# +1.00193664"},
        {"Smithsonian Astrophysical Observation", "SAO 18796"},
        {"Wilson Evans Batten Catalogue", "WEB 18007"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.37763542),
        dec: Angle.Degrees(+66.85296587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 468.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 296.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81882"},
        {"Hipparcos Number", "HIP 46748"},
        {"Geneva Identification System", "GEN# +1.00081882"},
        {"Smithsonian Astrophysical Observation", "SAO 14907"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.92567422),
        dec: Angle.Degrees(+66.85543947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101829"},
        {"Hipparcos Number", "HIP 57194"},
        {"Smithsonian Astrophysical Observation", "SAO 15614"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.91119236),
        dec: Angle.Degrees(+66.85665958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221946"},
        {"Hipparcos Number", "HIP 116461"},
        {"Geneva Identification System", "GEN# +1.00221946"},
        {"Smithsonian Astrophysical Observation", "SAO 20720"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.97450558),
        dec: Angle.Degrees(+66.85984271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61929"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.37461885),
        dec: Angle.Degrees(+66.86117181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102045"},
        {"Hipparcos Number", "HIP 57303"},
        {"Smithsonian Astrophysical Observation", "SAO 15623"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.25078262),
        dec: Angle.Degrees(+66.86370121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113112"},
        {"Smithsonian Astrophysical Observation", "SAO 20313"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.58897853),
        dec: Angle.Degrees(+66.86439394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29102"},
        {"Hipparcos Number", "HIP 21720"},
        {"Smithsonian Astrophysical Observation", "SAO 13221"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.94761215),
        dec: Angle.Degrees(+66.86807900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61766"},
        {"Hipparcos Number", "HIP 37858"},
        {"Geneva Identification System", "GEN# +1.00061766"},
        {"Smithsonian Astrophysical Observation", "SAO 14309"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.41205824),
        dec: Angle.Degrees(+66.86852774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7488"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.10304826),
        dec: Angle.Degrees(+66.87019792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57973"},
        {"Hipparcos Number", "HIP 36308"},
        {"Smithsonian Astrophysical Observation", "SAO 14203"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.10526660),
        dec: Angle.Degrees(+66.87212583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112543"},
        {"Smithsonian Astrophysical Observation", "SAO 20246"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.92946351),
        dec: Angle.Degrees(+66.87332753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77800"},
        {"Hipparcos Number", "HIP 44857"},
        {"Geneva Identification System", "GEN# +1.00077800"},
        {"Smithsonian Astrophysical Observation", "SAO 14769"},
        {"Wilson Evans Batten Catalogue", "WEB 8571"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.09805477),
        dec: Angle.Degrees(+66.87333335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38646"},
        {"Hipparcos Number", "HIP 27769"},
        {"Smithsonian Astrophysical Observation", "SAO 13633"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.14538540),
        dec: Angle.Degrees(+66.87889866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108774"},
        {"Hipparcos Number", "HIP 60937"},
        {"Geneva Identification System", "GEN# +1.00108774"},
        {"Smithsonian Astrophysical Observation", "SAO 15811"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.34514840),
        dec: Angle.Degrees(+66.89391089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126048"},
        {"Hipparcos Number", "HIP 70059"},
        {"Smithsonian Astrophysical Observation", "SAO 16344"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.06089948),
        dec: Angle.Degrees(+66.89440794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55839",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8159 AB"},
        {"Henry Draper", "HD 99343"},
        {"Hipparcos Number", "HIP 55839"},
        {"Smithsonian Astrophysical Observation", "SAO 15507"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.67205025),
        dec: Angle.Degrees(+66.89572566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18380"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.92885256),
        dec: Angle.Degrees(+66.89800728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40140"},
        {"Hipparcos Number", "HIP 28607"},
        {"Fundamental Katalog 5th Edition", "FK5 4549"},
        {"Smithsonian Astrophysical Observation", "SAO 13683"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.56797172),
        dec: Angle.Degrees(+66.89971390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175656"},
        {"Hipparcos Number", "HIP 92520"},
        {"Smithsonian Astrophysical Observation", "SAO 18051"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.83268780),
        dec: Angle.Degrees(+66.90311995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10145"},
        {"Hipparcos Number", "HIP 7902"},
        {"Cincinnati Publication", "Ci 18 231"},
        {"Cincinnati Publication 2", "Ci 20 117"},
        {"Geneva Identification System", "GEN# +1.00010145"},
        {"Smithsonian Astrophysical Observation", "SAO 11913"},
        {"Wilson Evans Batten Catalogue", "WEB 1683"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.40291709),
        dec: Angle.Degrees(+66.91058850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 692.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19959"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.19339137),
        dec: Angle.Degrees(+66.91068077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15604"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.23283963),
        dec: Angle.Degrees(+66.91130637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172669"},
        {"Hipparcos Number", "HIP 91210"},
        {"Geneva Identification System", "GEN# +1.00172669"},
        {"Smithsonian Astrophysical Observation", "SAO 17955"},
        {"Wilson Evans Batten Catalogue", "WEB 15666"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.09728975),
        dec: Angle.Degrees(+66.91338216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31174"},
        {"Smithsonian Astrophysical Observation", "SAO 13869"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.12245870),
        dec: Angle.Degrees(+66.91474382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19193"},
        {"Hipparcos Number", "HIP 14637"},
        {"Geneva Identification System", "GEN# +1.00019193"},
        {"Smithsonian Astrophysical Observation", "SAO 12618"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.27948433),
        dec: Angle.Degrees(+66.91746498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220769"},
        {"Hipparcos Number", "HIP 115654"},
        {"Geneva Identification System", "GEN# +1.00220769"},
        {"Smithsonian Astrophysical Observation", "SAO 20623"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.43150903),
        dec: Angle.Degrees(+66.92104788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99760"},
        {"Hipparcos Number", "HIP 56063"},
        {"Geneva Identification System", "GEN# +1.00099760"},
        {"Smithsonian Astrophysical Observation", "SAO 15523"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.35355068),
        dec: Angle.Degrees(+66.92582475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103251"},
        {"Smithsonian Astrophysical Observation", "SAO 19098"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.76579961),
        dec: Angle.Degrees(+66.92772262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216036"},
        {"Hipparcos Number", "HIP 112566"},
        {"Geneva Identification System", "GEN# +1.00216036"},
        {"Smithsonian Astrophysical Observation", "SAO 20249"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.98253960),
        dec: Angle.Degrees(+66.92844013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29164"},
        {"Smithsonian Astrophysical Observation", "SAO 13728"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.27911145),
        dec: Angle.Degrees(+66.93026955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211335"},
        {"Hipparcos Number", "HIP 109776"},
        {"Smithsonian Astrophysical Observation", "SAO 19954"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.53004224),
        dec: Angle.Degrees(+66.93226952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65282"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68889481),
        dec: Angle.Degrees(+66.93775695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59011"},
        {"Hipparcos Number", "HIP 36701"},
        {"Fundamental Katalog 5th Edition", "FK5 4676"},
        {"Smithsonian Astrophysical Observation", "SAO 14229"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.24411867),
        dec: Angle.Degrees(+66.93785412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13204"},
        {"Smithsonian Astrophysical Observation", "SAO 12454"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.48621429),
        dec: Angle.Degrees(+66.93795254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85643"},
        {"Smithsonian Astrophysical Observation", "SAO 17510"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.53079409),
        dec: Angle.Degrees(+66.93935214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186585"},
        {"Hipparcos Number", "HIP 96795"},
        {"Smithsonian Astrophysical Observation", "SAO 18474"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.14510825),
        dec: Angle.Degrees(+66.93937034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211112"},
        {"Hipparcos Number", "HIP 109635"},
        {"Smithsonian Astrophysical Observation", "SAO 19938"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.13793266),
        dec: Angle.Degrees(+66.94192755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40567"},
        {"Hipparcos Number", "HIP 28808"},
        {"Geneva Identification System", "GEN# +1.00040567"},
        {"Smithsonian Astrophysical Observation", "SAO 13694"},
        {"Wilson Evans Batten Catalogue", "WEB 5633"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.22767320),
        dec: Angle.Degrees(+66.94284140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121979"},
        {"Hipparcos Number", "HIP 68076"},
        {"Geneva Identification System", "GEN# +1.00121979"},
        {"Smithsonian Astrophysical Observation", "SAO 16224"},
        {"Wilson Evans Batten Catalogue", "WEB 11951"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.07486196),
        dec: Angle.Degrees(+66.94459520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166379"},
        {"Hipparcos Number", "HIP 88583"},
        {"Fundamental Katalog 5th Edition", "FK5 3440"},
        {"Geneva Identification System", "GEN# +1.00166379"},
        {"Smithsonian Astrophysical Observation", "SAO 17756"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.29651966),
        dec: Angle.Degrees(+66.94550970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82180"},
        {"Smithsonian Astrophysical Observation", "SAO 17227"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.84291752),
        dec: Angle.Degrees(+66.94629758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105605"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.84044138),
        dec: Angle.Degrees(+66.95401111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22489"},
        {"Smithsonian Astrophysical Observation", "SAO 13280"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.57003236),
        dec: Angle.Degrees(+66.95602584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151186"},
        {"Hipparcos Number", "HIP 81669"},
        {"Smithsonian Astrophysical Observation", "SAO 17190"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.24980730),
        dec: Angle.Degrees(+66.95944349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27592"},
        {"Hipparcos Number", "HIP 20702"},
        {"Smithsonian Astrophysical Observation", "SAO 13140"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.52249146),
        dec: Angle.Degrees(+66.96141203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110344",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15870 AB"},
        {"Henry Draper", "HD 212278"},
        {"Hipparcos Number", "HIP 110344"},
        {"Smithsonian Astrophysical Observation", "SAO 20023"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.24006457),
        dec: Angle.Degrees(+66.96508801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8633"},
        {"Hipparcos Number", "HIP 6774"},
        {"Smithsonian Astrophysical Observation", "SAO 11760"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.77387983),
        dec: Angle.Degrees(+66.97422870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135676"},
        {"Hipparcos Number", "HIP 74409"},
        {"Smithsonian Astrophysical Observation", "SAO 16643"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.10584405),
        dec: Angle.Degrees(+66.97506160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160052"},
        {"Hipparcos Number", "HIP 85863"},
        {"Geneva Identification System", "GEN# +1.00160052"},
        {"Smithsonian Astrophysical Observation", "SAO 17528"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.18808782),
        dec: Angle.Degrees(+66.98225738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32679"},
        {"Smithsonian Astrophysical Observation", "SAO 13958"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.24792633),
        dec: Angle.Degrees(+66.98541188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47837"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.26237861),
        dec: Angle.Degrees(+66.98556302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12735"},
        {"Hipparcos Number", "HIP 9909"},
        {"Smithsonian Astrophysical Observation", "SAO 12135"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.89112263),
        dec: Angle.Degrees(+66.98933887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83148"},
        {"Smithsonian Astrophysical Observation", "SAO 17309"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.88840532),
        dec: Angle.Degrees(+66.99905842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80406"},
        {"Hipparcos Number", "HIP 46012"},
        {"Smithsonian Astrophysical Observation", "SAO 14859"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.76108157),
        dec: Angle.Degrees(+67.00279686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 293 AB"},
        {"Henry Draper", "HD 1658"},
        {"Hipparcos Number", "HIP 1700"},
        {"Geneva Identification System", "GEN# +1.00001658"},
        {"Smithsonian Astrophysical Observation", "SAO 11128"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.34238990),
        dec: Angle.Degrees(+67.00541229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106127"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.46255283),
        dec: Angle.Degrees(+67.00944322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39894"},
        {"Hipparcos Number", "HIP 28482"},
        {"Smithsonian Astrophysical Observation", "SAO 13674"},
        {"Wilson Evans Batten Catalogue", "WEB 5565"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.20141673),
        dec: Angle.Degrees(+67.01403353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10331"},
        {"Hipparcos Number", "HIP 8042"},
        {"Smithsonian Astrophysical Observation", "SAO 11932"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.81097502),
        dec: Angle.Degrees(+67.01428070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9605 AB"},
        {"Henry Draper", "HD 137049"},
        {"Hipparcos Number", "HIP 75031"},
        {"Smithsonian Astrophysical Observation", "SAO 16699"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.97165937),
        dec: Angle.Degrees(+67.01560664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180346"},
        {"Hipparcos Number", "HIP 94269"},
        {"Smithsonian Astrophysical Observation", "SAO 18205"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.81721559),
        dec: Angle.Degrees(+67.01591831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221934"},
        {"Hipparcos Number", "HIP 116448"},
        {"Smithsonian Astrophysical Observation", "SAO 20718"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.94009181),
        dec: Angle.Degrees(+67.02006887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81788"},
        {"Hipparcos Number", "HIP 46692"},
        {"Smithsonian Astrophysical Observation", "SAO 14904"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.77966141),
        dec: Angle.Degrees(+67.03343085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4100"},
        {"Hipparcos Number", "HIP 3477"},
        {"Smithsonian Astrophysical Observation", "SAO 11352"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.10403202),
        dec: Angle.Degrees(+67.03353677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118788"},
        {"Hipparcos Number", "HIP 66422"},
        {"Geneva Identification System", "GEN# +1.00118788"},
        {"Smithsonian Astrophysical Observation", "SAO 16124"},
        {"Wilson Evans Batten Catalogue", "WEB 11727"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.26135455),
        dec: Angle.Degrees(+67.03641892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122516"},
        {"Hipparcos Number", "HIP 68377"},
        {"Smithsonian Astrophysical Observation", "SAO 16245"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.94868026),
        dec: Angle.Degrees(+67.03738769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113587"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.09248181),
        dec: Angle.Degrees(+67.04210283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117542"},
        {"Hipparcos Number", "HIP 65773"},
        {"Smithsonian Astrophysical Observation", "SAO 16086"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.26240077),
        dec: Angle.Degrees(+67.04230065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11874"},
        {"Hipparcos Number", "HIP 9278"},
        {"Geneva Identification System", "GEN# +1.00011874"},
        {"Smithsonian Astrophysical Observation", "SAO 12071"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.81187644),
        dec: Angle.Degrees(+67.04356756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149198"},
        {"Hipparcos Number", "HIP 80682"},
        {"Geneva Identification System", "GEN# +1.00149198"},
        {"Smithsonian Astrophysical Observation", "SAO 17108"},
        {"Wilson Evans Batten Catalogue", "WEB 13647"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.08820161),
        dec: Angle.Degrees(+67.04401224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24807"},
        {"Hipparcos Number", "HIP 18764"},
        {"Smithsonian Astrophysical Observation", "SAO 12983"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.28995800),
        dec: Angle.Degrees(+67.04637849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24073"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.58028412),
        dec: Angle.Degrees(+67.04778885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60380"},
        {"Hipparcos Number", "HIP 37253"},
        {"Geneva Identification System", "GEN# +1.00060380"},
        {"Smithsonian Astrophysical Observation", "SAO 14269"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.76082977),
        dec: Angle.Degrees(+67.05034712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106085",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15040 AB"},
        {"Henry Draper", "HD 205022"},
        {"Hipparcos Number", "HIP 106085"},
        {"Smithsonian Astrophysical Observation", "SAO 19451"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.33560140),
        dec: Angle.Degrees(+67.05098669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89742"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.71755096),
        dec: Angle.Degrees(+67.05438804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48899"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.62648576),
        dec: Angle.Degrees(+67.05470188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11410"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.75981140),
        dec: Angle.Degrees(+67.06318830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60817"},
        {"Hipparcos Number", "HIP 37445"},
        {"Smithsonian Astrophysical Observation", "SAO 14280"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.30609298),
        dec: Angle.Degrees(+67.06635302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141060"},
        {"Hipparcos Number", "HIP 76947"},
        {"Smithsonian Astrophysical Observation", "SAO 16827"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.67471909),
        dec: Angle.Degrees(+67.06662340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8607"},
        {"Hipparcos Number", "HIP 6743"},
        {"Geneva Identification System", "GEN# +1.00008607"},
        {"Smithsonian Astrophysical Observation", "SAO 11756"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.70438248),
        dec: Angle.Degrees(+67.06891886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11080"},
        {"Geneva Identification System", "GEN# +0.06600205"},
        {"Smithsonian Astrophysical Observation", "SAO 12249"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.66570858),
        dec: Angle.Degrees(+67.07208080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148727"},
        {"Hipparcos Number", "HIP 80452"},
        {"Smithsonian Astrophysical Observation", "SAO 17088"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.33494205),
        dec: Angle.Degrees(+67.07236162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46879"},
        {"Hipparcos Number", "HIP 31983"},
        {"Smithsonian Astrophysical Observation", "SAO 13916"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.25200912),
        dec: Angle.Degrees(+67.07318647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59585",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8462 A"},
        {"Henry Draper", "HD 106221"},
        {"Hipparcos Number", "HIP 59585"},
        {"Smithsonian Astrophysical Observation", "SAO 15740"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.28315105),
        dec: Angle.Degrees(+67.07342952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193088"},
        {"Hipparcos Number", "HIP 99726"},
        {"Smithsonian Astrophysical Observation", "SAO 18776"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.53568446),
        dec: Angle.Degrees(+67.07400115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76289"},
        {"Hipparcos Number", "HIP 44112"},
        {"Smithsonian Astrophysical Observation", "SAO 14720"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.76543886),
        dec: Angle.Degrees(+67.07476512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88179"},
        {"Smithsonian Astrophysical Observation", "SAO 17725"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.13027990),
        dec: Angle.Degrees(+67.07543797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219209"},
        {"Hipparcos Number", "HIP 114605"},
        {"Geneva Identification System", "GEN# +1.00219209"},
        {"Smithsonian Astrophysical Observation", "SAO 20496"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.25879540),
        dec: Angle.Degrees(+67.07610403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103876"},
        {"Hipparcos Number", "HIP 58342"},
        {"Geneva Identification System", "GEN# +1.00103876"},
        {"Smithsonian Astrophysical Observation", "SAO 15671"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.46409735),
        dec: Angle.Degrees(+67.07942552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46420"},
        {"Hipparcos Number", "HIP 31753"},
        {"Smithsonian Astrophysical Observation", "SAO 13900"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.63343371),
        dec: Angle.Degrees(+67.08691121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55076"},
        {"Hipparcos Number", "HIP 35204"},
        {"Geneva Identification System", "GEN# +1.00055076"},
        {"Smithsonian Astrophysical Observation", "SAO 14131"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.13674466),
        dec: Angle.Degrees(+67.08727632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45064",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7203 C"},
        {"Hipparcos Number", "HIP 45064"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.67362138),
        dec: Angle.Degrees(+67.08729559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113437",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16423 AB"},
        {"Henry Draper", "HD 217296"},
        {"Hipparcos Number", "HIP 113437"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.61772264),
        dec: Angle.Degrees(+67.08799167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19287"},
        {"Hipparcos Number", "HIP 14714"},
        {"Smithsonian Astrophysical Observation", "SAO 12626"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.52629991),
        dec: Angle.Degrees(+67.08849382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3086 A"},
        {"Henry Draper", "HD 26669"},
        {"Hipparcos Number", "HIP 20037"},
        {"Smithsonian Astrophysical Observation", "SAO 13081"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.46142319),
        dec: Angle.Degrees(+67.08870187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133328"},
        {"Hipparcos Number", "HIP 73410"},
        {"Smithsonian Astrophysical Observation", "SAO 16572"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.03409016),
        dec: Angle.Degrees(+67.09047228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20031"},
        {"Hipparcos Number", "HIP 15277"},
        {"Smithsonian Astrophysical Observation", "SAO 12680"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.27614981),
        dec: Angle.Degrees(+67.09085915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125917"},
        {"Hipparcos Number", "HIP 70006"},
        {"Geneva Identification System", "GEN# +1.00125917"},
        {"Smithsonian Astrophysical Observation", "SAO 16337"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.86956077),
        dec: Angle.Degrees(+67.09416863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56669"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.28962105),
        dec: Angle.Degrees(+67.09599388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68599",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9096 AB"},
        {"Henry Draper", "HD 123012"},
        {"Hipparcos Number", "HIP 68599"},
        {"Smithsonian Astrophysical Observation", "SAO 16259"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63761757),
        dec: Angle.Degrees(+67.09862009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98499"},
        {"Hipparcos Number", "HIP 55412"},
        {"Fundamental Katalog 5th Edition", "FK5 2905"},
        {"Geneva Identification System", "GEN# +1.00098499"},
        {"Smithsonian Astrophysical Observation", "SAO 15478"},
        {"Wilson Evans Batten Catalogue", "WEB 9970"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.22378608),
        dec: Angle.Degrees(+67.10085581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209789"},
        {"Hipparcos Number", "HIP 108894"},
        {"Geneva Identification System", "GEN# +1.00209789"},
        {"Smithsonian Astrophysical Observation", "SAO 19824"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.87144061),
        dec: Angle.Degrees(+67.10699679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117987"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.98193550),
        dec: Angle.Degrees(+67.11405799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181043"},
        {"Hipparcos Number", "HIP 94505"},
        {"Smithsonian Astrophysical Observation", "SAO 18234"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.51629164),
        dec: Angle.Degrees(+67.11553561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10690 AB"},
        {"Henry Draper", "HD 160862"},
        {"Hipparcos Number", "HIP 86216"},
        {"Renson", "Renson 45320"},
        {"Smithsonian Astrophysical Observation", "SAO 17573"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.26925971),
        dec: Angle.Degrees(+67.11929360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176197"},
        {"Hipparcos Number", "HIP 92745"},
        {"Smithsonian Astrophysical Observation", "SAO 18066"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.49702294),
        dec: Angle.Degrees(+67.12101288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91395",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11568 AB"},
        {"Henry Draper", "HD 173084"},
        {"Hipparcos Number", "HIP 91395"},
        {"Cincinnati Publication", "Ci 18 2451"},
        {"Geneva Identification System", "GEN# +1.00173084"},
        {"Smithsonian Astrophysical Observation", "SAO 17964"},
        {"Wilson Evans Batten Catalogue", "WEB 15708"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.59944658),
        dec: Angle.Degrees(+67.12609706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 183.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7203 AB"},
        {"Henry Draper", "HD 78154"},
        {"Hipparcos Number", "HIP 45038"},
        {"Geneva Identification System", "GEN# +1.00078154J"},
        {"Smithsonian Astrophysical Observation", "SAO 14788"},
        {"Wilson Evans Batten Catalogue", "WEB 8597"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.59802574),
        dec: Angle.Degrees(+67.13423886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181653"},
        {"Hipparcos Number", "HIP 94716"},
        {"Smithsonian Astrophysical Observation", "SAO 18255"},
        {"Wilson Evans Batten Catalogue", "WEB 16519"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.10089832),
        dec: Angle.Degrees(+67.13518716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61547"},
        {"Smithsonian Astrophysical Observation", "SAO 15836"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.16750873),
        dec: Angle.Degrees(+67.13854498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79055"},
        {"Hipparcos Number", "HIP 45417"},
        {"Geneva Identification System", "GEN# +1.00079055"},
        {"Smithsonian Astrophysical Observation", "SAO 14822"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.82309310),
        dec: Angle.Degrees(+67.13886242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15765"},
        {"Smithsonian Astrophysical Observation", "SAO 12727"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.78672379),
        dec: Angle.Degrees(+67.16722000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195193"},
        {"Hipparcos Number", "HIP 100763"},
        {"Smithsonian Astrophysical Observation", "SAO 18866"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.44098629),
        dec: Angle.Degrees(+67.14130573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58984"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.40755485),
        dec: Angle.Degrees(+67.14299607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146603"},
        {"Hipparcos Number", "HIP 79414"},
        {"Geneva Identification System", "GEN# +1.00146603"},
        {"Smithsonian Astrophysical Observation", "SAO 16993"},
        {"Wilson Evans Batten Catalogue", "WEB 13431"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.10574027),
        dec: Angle.Degrees(+67.14427933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57177"},
        {"Hipparcos Number", "HIP 36002"},
        {"Smithsonian Astrophysical Observation", "SAO 14182"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.29395609),
        dec: Angle.Degrees(+67.14721507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27776"},
        {"Hipparcos Number", "HIP 20840"},
        {"Smithsonian Astrophysical Observation", "SAO 13147"},
    },
    visualMagnitude: 8.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.99273865),
        dec: Angle.Degrees(+67.14934775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7487 A"},
        {"Henry Draper", "HD 83661"},
        {"Hipparcos Number", "HIP 47669"},
        {"Smithsonian Astrophysical Observation", "SAO 14970"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.80274447),
        dec: Angle.Degrees(+67.15023004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111257"},
        {"Smithsonian Astrophysical Observation", "SAO 20141"},
        {"Wilson Evans Batten Catalogue", "WEB 19906"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.10450967),
        dec: Angle.Degrees(+67.15069465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29726"},
        {"Smithsonian Astrophysical Observation", "SAO 13766"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91381557),
        dec: Angle.Degrees(+67.15113977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161617"},
        {"Hipparcos Number", "HIP 86564"},
        {"Smithsonian Astrophysical Observation", "SAO 17608"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.34733905),
        dec: Angle.Degrees(+67.15195109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214974"},
        {"Hipparcos Number", "HIP 111917"},
        {"Smithsonian Astrophysical Observation", "SAO 20197"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.05355180),
        dec: Angle.Degrees(+67.15394957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212543"},
        {"Hipparcos Number", "HIP 110496"},
        {"Smithsonian Astrophysical Observation", "SAO 20043"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.74751357),
        dec: Angle.Degrees(+67.15609660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4132"},
        {"Hipparcos Number", "HIP 3509"},
        {"Geneva Identification System", "GEN# +1.00004132"},
        {"Smithsonian Astrophysical Observation", "SAO 11360"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.19905823),
        dec: Angle.Degrees(+67.15832122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2789"},
        {"Hipparcos Number", "HIP 2525"},
        {"Geneva Identification System", "GEN# +1.00002789"},
        {"Smithsonian Astrophysical Observation", "SAO 11251"},
        {"Wilson Evans Batten Catalogue", "WEB 461"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.01180667),
        dec: Angle.Degrees(+67.16112804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216319"},
        {"Hipparcos Number", "HIP 112792"},
        {"Smithsonian Astrophysical Observation", "SAO 20274"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.61811985),
        dec: Angle.Degrees(+67.16466379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23450"},
        {"Hipparcos Number", "HIP 17893"},
        {"Geneva Identification System", "GEN# +1.00023450"},
        {"Smithsonian Astrophysical Observation", "SAO 12915"},
        {"Wilson Evans Batten Catalogue", "WEB 3442"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.40916314),
        dec: Angle.Degrees(+67.16556878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225216"},
        {"Hipparcos Number", "HIP 379"},
        {"Geneva Identification System", "GEN# +1.00225216"},
        {"Smithsonian Astrophysical Observation", "SAO 10956"},
        {"Wilson Evans Batten Catalogue", "WEB 55"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.17432297),
        dec: Angle.Degrees(+67.16638761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22528"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.72028090),
        dec: Angle.Degrees(+67.16726460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117700"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.05060246),
        dec: Angle.Degrees(+67.16874159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109743"},
        {"Smithsonian Astrophysical Observation", "SAO 19951"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.45047378),
        dec: Angle.Degrees(+67.17392457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23521"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.85028832),
        dec: Angle.Degrees(+67.17402636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83436"},
        {"Fundamental Katalog 5th Edition", "FK5 5502"},
        {"Smithsonian Astrophysical Observation", "SAO 17334"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.79674890),
        dec: Angle.Degrees(+67.18052502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24720"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.52573979),
        dec: Angle.Degrees(+67.18323934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106757"},
        {"Smithsonian Astrophysical Observation", "SAO 19538"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.37901341),
        dec: Angle.Degrees(+67.18431003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107051"},
        {"Hipparcos Number", "HIP 59989"},
        {"Smithsonian Astrophysical Observation", "SAO 15763"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.55242812),
        dec: Angle.Degrees(+67.18661883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70793"},
        {"Smithsonian Astrophysical Observation", "SAO 16395"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.16939065),
        dec: Angle.Degrees(+67.18774638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60444"},
    },
    visualMagnitude: 11.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.88679784),
        dec: Angle.Degrees(+67.18861012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71951"},
        {"Hipparcos Number", "HIP 42068"},
        {"Smithsonian Astrophysical Observation", "SAO 14587"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.61510346),
        dec: Angle.Degrees(+67.18897067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115978"},
        {"Hipparcos Number", "HIP 64961"},
        {"Geneva Identification System", "GEN# +1.00115978"},
        {"Smithsonian Astrophysical Observation", "SAO 16041"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.72827558),
        dec: Angle.Degrees(+67.19490618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129513"},
        {"Hipparcos Number", "HIP 71675"},
        {"Smithsonian Astrophysical Observation", "SAO 16459"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.90408095),
        dec: Angle.Degrees(+67.19574449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29019"},
        {"Hipparcos Number", "HIP 21664"},
        {"Smithsonian Astrophysical Observation", "SAO 13216"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.76754809),
        dec: Angle.Degrees(+67.20093328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34392"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.96195688),
        dec: Angle.Degrees(+67.20141656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -290.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23005"},
        {"Hipparcos Number", "HIP 17585"},
        {"Fundamental Katalog 5th Edition", "FK5 2267"},
        {"Geneva Identification System", "GEN# +1.00023005"},
        {"Smithsonian Astrophysical Observation", "SAO 12890"},
        {"Wilson Evans Batten Catalogue", "WEB 3341"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.50339866),
        dec: Angle.Degrees(+67.20188088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7842"},
        {"Hipparcos Number", "HIP 6224"},
        {"Fundamental Katalog 5th Edition", "FK5 4119"},
        {"Smithsonian Astrophysical Observation", "SAO 11696"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.94838442),
        dec: Angle.Degrees(+67.20233627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160198"},
        {"Hipparcos Number", "HIP 85906"},
        {"Geneva Identification System", "GEN# +1.00160198"},
        {"Smithsonian Astrophysical Observation", "SAO 17532"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.32532622),
        dec: Angle.Degrees(+67.20359523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88131"},
        {"Hipparcos Number", "HIP 49992"},
        {"Smithsonian Astrophysical Observation", "SAO 15115"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.08247421),
        dec: Angle.Degrees(+67.20730488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218029"},
        {"Hipparcos Number", "HIP 113864"},
        {"Fundamental Katalog 5th Edition", "FK5 3844"},
        {"Geneva Identification System", "GEN# +1.00218029"},
        {"Smithsonian Astrophysical Observation", "SAO 20398"},
        {"Wilson Evans Batten Catalogue", "WEB 20227"},
    },
    visualMagnitude: 5.25,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.88686782),
        dec: Angle.Degrees(+67.20918487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133815"},
        {"Hipparcos Number", "HIP 73600"},
        {"Smithsonian Astrophysical Observation", "SAO 16582"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.66219796),
        dec: Angle.Degrees(+67.20985693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96707"},
        {"Hipparcos Number", "HIP 54540"},
        {"Geneva Identification System", "GEN# +1.00096707"},
        {"Renson", "Renson 27890"},
        {"Smithsonian Astrophysical Observation", "SAO 15414"},
        {"Wilson Evans Batten Catalogue", "WEB 9844"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.41632443),
        dec: Angle.Degrees(+67.21027498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67043"},
        {"Hipparcos Number", "HIP 40046"},
        {"Geneva Identification System", "GEN# +1.00067043"},
        {"Smithsonian Astrophysical Observation", "SAO 14450"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.70133695),
        dec: Angle.Degrees(+67.21285483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52892"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.25832030),
        dec: Angle.Degrees(+67.21454267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17160 A"},
        {"Hipparcos Number", "HIP 40"},
        {"Geneva Identification System", "GEN# +2.78220012"},
        {"New General Catalogue", "NGC 7822 12"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.12196971),
        dec: Angle.Degrees(+67.21679125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203711"},
        {"Hipparcos Number", "HIP 105380"},
        {"Smithsonian Astrophysical Observation", "SAO 19344"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.18818242),
        dec: Angle.Degrees(+67.22086079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49360"},
        {"Hipparcos Number", "HIP 33074"},
        {"Smithsonian Astrophysical Observation", "SAO 13984"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.32072788),
        dec: Angle.Degrees(+67.22206169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
