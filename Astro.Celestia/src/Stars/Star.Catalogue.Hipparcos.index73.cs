using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_73() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110565"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.97511738),
        dec: Angle.Degrees(+13.72392776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28556"},
        {"Hipparcos Number", "HIP 21036"},
        {"Celescope Catalog", "CEL 417"},
        {"Geneva Identification System", "GEN# +5.20250084"},
        {"Smithsonian Astrophysical Observation", "SAO 93979"},
        {"Wilson Evans Batten Catalogue", "WEB 4048"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.65541066),
        dec: Angle.Degrees(+13.72445018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353911"},
        {"Hipparcos Number", "HIP 97695"},
        {"Smithsonian Astrophysical Observation", "SAO 105343"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.81740573),
        dec: Angle.Degrees(+13.72813375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71795",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9343 AB"},
        {"Henry Draper", "HD 129246J"},
        {"Hipparcos Number", "HIP 71795"},
        {"Geneva Identification System", "GEN# +1.00129247J"},
        {"Smithsonian Astrophysical Observation", "SAO 101145"},
    },
    visualMagnitude: 3.78,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.28716819),
        dec: Angle.Degrees(+13.72833113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89056"},
        {"Hipparcos Number", "HIP 50333"},
        {"Fundamental Katalog 5th Edition", "FK5 2824"},
        {"Geneva Identification System", "GEN# +1.00089056"},
        {"Smithsonian Astrophysical Observation", "SAO 99034"},
        {"Wilson Evans Batten Catalogue", "WEB 9243"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16979666),
        dec: Angle.Degrees(+13.72837138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37920",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6350 AB"},
        {"Henry Draper", "HD 62786"},
        {"Hipparcos Number", "HIP 37920"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.56533991),
        dec: Angle.Degrees(+13.72872244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218499"},
        {"Hipparcos Number", "HIP 114262"},
        {"Geneva Identification System", "GEN# +1.00218499"},
        {"Smithsonian Astrophysical Observation", "SAO 108423"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.11555156),
        dec: Angle.Degrees(+13.72950877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32347"},
        {"Hipparcos Number", "HIP 23498"},
        {"Geneva Identification System", "GEN# +5.20250187"},
        {"Wilson Evans Batten Catalogue", "WEB 4576"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.78174186),
        dec: Angle.Degrees(+13.73071388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122386"},
        {"Hipparcos Number", "HIP 68495"},
        {"Geneva Identification System", "GEN# +1.00122386"},
        {"Smithsonian Astrophysical Observation", "SAO 100815"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.33183844),
        dec: Angle.Degrees(+13.73259967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95920"},
        {"Hipparcos Number", "HIP 54097"},
        {"Smithsonian Astrophysical Observation", "SAO 99424"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.04149985),
        dec: Angle.Degrees(+13.73283466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65749"},
        {"Geneva Identification System", "GEN# +0.01402622"},
        {"Smithsonian Astrophysical Observation", "SAO 100586"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.16932925),
        dec: Angle.Degrees(+13.73460420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4575 AB"},
        {"Henry Draper", "HD 40427"},
        {"Hipparcos Number", "HIP 28345"},
        {"Smithsonian Astrophysical Observation", "SAO 95088"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.84377483),
        dec: Angle.Degrees(+13.73533036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7604"},
        {"Hipparcos Number", "HIP 5922"},
        {"Geneva Identification System", "GEN# +1.00007604"},
        {"Smithsonian Astrophysical Observation", "SAO 92340"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.04480102),
        dec: Angle.Degrees(+13.73546423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171067"},
        {"Hipparcos Number", "HIP 90864"},
        {"Geneva Identification System", "GEN# +1.00171067"},
        {"Smithsonian Astrophysical Observation", "SAO 103819"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.04331920),
        dec: Angle.Degrees(+13.73626659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354754"},
        {"Hipparcos Number", "HIP 98892"},
        {"Smithsonian Astrophysical Observation", "SAO 105651"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.22820023),
        dec: Angle.Degrees(+13.73649267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86448"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.95323572),
        dec: Angle.Degrees(+13.73913227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229365"},
        {"Hipparcos Number", "HIP 91995"},
        {"Smithsonian Astrophysical Observation", "SAO 104057"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.26103190),
        dec: Angle.Degrees(+13.73919127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105835"},
        {"Smithsonian Astrophysical Observation", "SAO 107134"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.53846888),
        dec: Angle.Degrees(+13.73956981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103171"},
        {"Hipparcos Number", "HIP 57932"},
        {"Geneva Identification System", "GEN# +1.00103171"},
        {"Smithsonian Astrophysical Observation", "SAO 99841"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22262123),
        dec: Angle.Degrees(+13.74434861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192062"},
        {"Hipparcos Number", "HIP 99589"},
        {"Geneva Identification System", "GEN# +1.00192062"},
        {"Smithsonian Astrophysical Observation", "SAO 105839"},
        {"Wilson Evans Batten Catalogue", "WEB 17822"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.16170544),
        dec: Angle.Degrees(+13.74437738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84937"},
        {"Hipparcos Number", "HIP 48152"},
        {"Cincinnati Publication", "Ci 18 1163"},
        {"Cincinnati Publication 2", "Ci 20 549"},
        {"Geneva Identification System", "GEN# +1.00084937"},
        {"Smithsonian Astrophysical Observation", "SAO 98781"},
        {"Wilson Evans Batten Catalogue", "WEB 8993"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.23280788),
        dec: Angle.Degrees(+13.74613874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 373.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -774.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74380"},
        {"Hipparcos Number", "HIP 42865"},
        {"Geneva Identification System", "GEN# +1.00074380"},
        {"Smithsonian Astrophysical Observation", "SAO 98081"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.02330091),
        dec: Angle.Degrees(+13.74876430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81762"},
        {"Hipparcos Number", "HIP 46415"},
        {"Geneva Identification System", "GEN# +1.00081762"},
        {"Smithsonian Astrophysical Observation", "SAO 98587"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98116435),
        dec: Angle.Degrees(+13.74897275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188347"},
        {"Hipparcos Number", "HIP 97941"},
        {"Geneva Identification System", "GEN# +1.00188347"},
        {"Smithsonian Astrophysical Observation", "SAO 105399"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.56466962),
        dec: Angle.Degrees(+13.74916238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15691"},
        {"Henry Draper", "HD 210462"},
        {"Hipparcos Number", "HIP 109440"},
        {"Smithsonian Astrophysical Observation", "SAO 107705"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.58218952),
        dec: Angle.Degrees(+13.74938965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121561"},
        {"Hipparcos Number", "HIP 68048"},
        {"Smithsonian Astrophysical Observation", "SAO 100778"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.99436427),
        dec: Angle.Degrees(+13.74944185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 896"},
        {"Smithsonian Astrophysical Observation", "SAO 91762"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.76524987),
        dec: Angle.Degrees(+13.75051092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107363"},
        {"Hipparcos Number", "HIP 60188"},
        {"Geneva Identification System", "GEN# +1.00107363"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.14050812),
        dec: Angle.Degrees(+13.75124437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231747"},
        {"Hipparcos Number", "HIP 96133"},
        {"Smithsonian Astrophysical Observation", "SAO 104953"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.20495003),
        dec: Angle.Degrees(+13.75215055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48662"},
        {"Hipparcos Number", "HIP 32346"},
        {"Smithsonian Astrophysical Observation", "SAO 96071"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.27830725),
        dec: Angle.Degrees(+13.75299945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16150"},
        {"Hipparcos Number", "HIP 12111"},
        {"Geneva Identification System", "GEN# +1.00016150"},
        {"Smithsonian Astrophysical Observation", "SAO 93016"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.00534332),
        dec: Angle.Degrees(+13.75509045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11673"},
        {"Hipparcos Number", "HIP 8916"},
        {"Geneva Identification System", "GEN# +1.00011673"},
        {"Smithsonian Astrophysical Observation", "SAO 92693"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.69670227),
        dec: Angle.Degrees(+13.75702204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135503"},
        {"Hipparcos Number", "HIP 74638"},
        {"Smithsonian Astrophysical Observation", "SAO 101459"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.75459185),
        dec: Angle.Degrees(+13.75956479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55411"},
        {"Hipparcos Number", "HIP 34913"},
        {"Smithsonian Astrophysical Observation", "SAO 96639"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.34904350),
        dec: Angle.Degrees(+13.76299253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115539"},
        {"Hipparcos Number", "HIP 64858"},
        {"Geneva Identification System", "GEN# +1.00115539"},
        {"Smithsonian Astrophysical Observation", "SAO 100500"},
        {"Wilson Evans Batten Catalogue", "WEB 11463"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40834286),
        dec: Angle.Degrees(+13.76379869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190572"},
        {"Hipparcos Number", "HIP 98911"},
        {"Smithsonian Astrophysical Observation", "SAO 105652"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.27289760),
        dec: Angle.Degrees(+13.76418008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229500"},
        {"Hipparcos Number", "HIP 92189"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.83123971),
        dec: Angle.Degrees(+13.76541631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82293"},
    },
    visualMagnitude: 11.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.22549451),
        dec: Angle.Degrees(+13.76628412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19610"},
        {"Hipparcos Number", "HIP 14694"},
        {"Smithsonian Astrophysical Observation", "SAO 93311"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.46131710),
        dec: Angle.Degrees(+13.76778898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72985"},
        {"Hipparcos Number", "HIP 42195"},
        {"Smithsonian Astrophysical Observation", "SAO 97953"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.05470248),
        dec: Angle.Degrees(+13.76931814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24527"},
        {"Hipparcos Number", "HIP 18274"},
        {"Geneva Identification System", "GEN# +1.00024527"},
        {"Smithsonian Astrophysical Observation", "SAO 93664"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.63955439),
        dec: Angle.Degrees(+13.77104705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61630"},
        {"Hipparcos Number", "HIP 37404"},
        {"Smithsonian Astrophysical Observation", "SAO 97136"},
        {"Wilson Evans Batten Catalogue", "WEB 7401"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.19660870),
        dec: Angle.Degrees(+13.77126983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159141"},
        {"Hipparcos Number", "HIP 85843"},
        {"Smithsonian Astrophysical Observation", "SAO 102901"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.12148202),
        dec: Angle.Degrees(+13.77230205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10311"},
        {"Hipparcos Number", "HIP 7859"},
        {"Smithsonian Astrophysical Observation", "SAO 92574"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.26848781),
        dec: Angle.Degrees(+13.77363695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66528"},
        {"Hipparcos Number", "HIP 39507"},
        {"Smithsonian Astrophysical Observation", "SAO 97533"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.12512290),
        dec: Angle.Degrees(+13.77443653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168199"},
        {"Hipparcos Number", "HIP 89677"},
        {"Fundamental Katalog 5th Edition", "FK5 3456"},
        {"Geneva Identification System", "GEN# +1.00168199"},
        {"Smithsonian Astrophysical Observation", "SAO 103578"},
        {"Wilson Evans Batten Catalogue", "WEB 15278"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.51226775),
        dec: Angle.Degrees(+13.77705548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72965"},
        {"Hipparcos Number", "HIP 42193"},
        {"Smithsonian Astrophysical Observation", "SAO 97952"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.04562966),
        dec: Angle.Degrees(+13.77754674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117176"},
        {"Hipparcos Number", "HIP 65721"},
        {"Cincinnati Publication", "Ci 20 781"},
        {"Fundamental Katalog 5th Edition", "FK5 1349"},
        {"Geneva Identification System", "GEN# +1.00117176"},
        {"Smithsonian Astrophysical Observation", "SAO 100582"},
        {"Wilson Evans Batten Catalogue", "WEB 11632"},
    },
    visualMagnitude: 4.97,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.10812668),
        dec: Angle.Degrees(+13.78018777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -576.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22017"},
        {"Hipparcos Number", "HIP 16572"},
        {"Geneva Identification System", "GEN# +1.00022017"},
        {"Smithsonian Astrophysical Observation", "SAO 93487"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.33832945),
        dec: Angle.Degrees(+13.78246379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52637"},
        {"Hipparcos Number", "HIP 33944"},
        {"Smithsonian Astrophysical Observation", "SAO 96412"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.65936386),
        dec: Angle.Degrees(+13.78295939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161322"},
        {"Hipparcos Number", "HIP 86813"},
        {"Smithsonian Astrophysical Observation", "SAO 103070"},
        {"Wilson Evans Batten Catalogue", "WEB 14642"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.07655500),
        dec: Angle.Degrees(+13.78392161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15625"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.30192492),
        dec: Angle.Degrees(+13.78400666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101550"},
        {"Hipparcos Number", "HIP 57007"},
        {"Smithsonian Astrophysical Observation", "SAO 99734"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.30448523),
        dec: Angle.Degrees(+13.78558115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141353"},
        {"Hipparcos Number", "HIP 77412"},
        {"Geneva Identification System", "GEN# +1.00141353"},
        {"Smithsonian Astrophysical Observation", "SAO 101744"},
        {"Wilson Evans Batten Catalogue", "WEB 13112"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.05546553),
        dec: Angle.Degrees(+13.78933425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166896"},
        {"Hipparcos Number", "HIP 89197"},
        {"Smithsonian Astrophysical Observation", "SAO 103471"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.04588703),
        dec: Angle.Degrees(+13.79052858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102153"},
        {"Smithsonian Astrophysical Observation", "SAO 106393"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.48006051),
        dec: Angle.Degrees(+13.79059523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39127"},
        {"Geneva Identification System", "GEN# +0.01401802"},
        {"Wilson Evans Batten Catalogue", "WEB 7675"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06503331),
        dec: Angle.Degrees(+13.79688392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19112"},
        {"Hipparcos Number", "HIP 14329"},
        {"Geneva Identification System", "GEN# +1.00019112"},
        {"Smithsonian Astrophysical Observation", "SAO 93261"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.20676405),
        dec: Angle.Degrees(+13.79749254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116011"},
        {"Hipparcos Number", "HIP 65130"},
        {"Geneva Identification System", "GEN# +1.00116011"},
        {"Smithsonian Astrophysical Observation", "SAO 100524"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.20192074),
        dec: Angle.Degrees(+13.79912682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48579"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.62014798),
        dec: Angle.Degrees(+13.80180254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211303"},
        {"Hipparcos Number", "HIP 109938"},
        {"Smithsonian Astrophysical Observation", "SAO 107777"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.99678816),
        dec: Angle.Degrees(+13.80357414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109983"},
        {"Hipparcos Number", "HIP 61701"},
        {"Geneva Identification System", "GEN# +1.00109983"},
        {"Smithsonian Astrophysical Observation", "SAO 100189"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.71464023),
        dec: Angle.Degrees(+13.80375354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109942"},
        {"Hipparcos Number", "HIP 61676"},
        {"Geneva Identification System", "GEN# +1.00109942"},
        {"Smithsonian Astrophysical Observation", "SAO 100187"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.64624169),
        dec: Angle.Degrees(+13.80553530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63027"},
        {"Geneva Identification System", "GEN# +0.01402561"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.73839842),
        dec: Angle.Degrees(+13.80774735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197169"},
        {"Hipparcos Number", "HIP 102114"},
        {"Geneva Identification System", "GEN# +1.00197169"},
        {"Renson", "Renson 55000"},
        {"Smithsonian Astrophysical Observation", "SAO 106387"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.40684883),
        dec: Angle.Degrees(+13.80880473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25959"},
        {"Hipparcos Number", "HIP 19221"},
        {"Geneva Identification System", "GEN# +1.00025959"},
        {"Smithsonian Astrophysical Observation", "SAO 93769"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.79433157),
        dec: Angle.Degrees(+13.81237724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91800"},
        {"Hipparcos Number", "HIP 51902"},
        {"Smithsonian Astrophysical Observation", "SAO 99202"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.05695756),
        dec: Angle.Degrees(+13.81297883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159908"},
        {"Hipparcos Number", "HIP 86179"},
        {"Smithsonian Astrophysical Observation", "SAO 102958"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.15328583),
        dec: Angle.Degrees(+13.81328474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244378"},
        {"Hipparcos Number", "HIP 25812"},
        {"Smithsonian Astrophysical Observation", "SAO 94599"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.69431149),
        dec: Angle.Degrees(+13.81520952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185936"},
        {"Hipparcos Number", "HIP 96840"},
        {"Fundamental Katalog 5th Edition", "FK5 3574"},
        {"Geneva Identification System", "GEN# +1.00185936J"},
        {"Smithsonian Astrophysical Observation", "SAO 105132"},
        {"Wilson Evans Batten Catalogue", "WEB 16998"},
    },
    visualMagnitude: 5.98,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.27303453),
        dec: Angle.Degrees(+13.81570826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6705"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.55721808),
        dec: Angle.Degrees(+13.81647710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168796"},
        {"Hipparcos Number", "HIP 89939"},
        {"Renson", "Renson 47310"},
        {"Smithsonian Astrophysical Observation", "SAO 103632"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.26072968),
        dec: Angle.Degrees(+13.81685504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72374"},
        {"Smithsonian Astrophysical Observation", "SAO 101222"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.97967267),
        dec: Angle.Degrees(+13.81694093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16113"},
        {"Hipparcos Number", "HIP 12079"},
        {"Smithsonian Astrophysical Observation", "SAO 93015"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.92700403),
        dec: Angle.Degrees(+13.81726009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195397"},
        {"Hipparcos Number", "HIP 101181"},
        {"Geneva Identification System", "GEN# +1.00195397"},
        {"Smithsonian Astrophysical Observation", "SAO 106180"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.63946852),
        dec: Angle.Degrees(+13.81732852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224494"},
        {"Hipparcos Number", "HIP 118191"},
        {"Smithsonian Astrophysical Observation", "SAO 108941"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.61134253),
        dec: Angle.Degrees(+13.82249311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91778"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.72455094),
        dec: Angle.Degrees(+13.82309786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80498"},
        {"Smithsonian Astrophysical Observation", "SAO 102161"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.47517219),
        dec: Angle.Degrees(+13.82400623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8858"},
        {"Smithsonian Astrophysical Observation", "SAO 92686"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.48706898),
        dec: Angle.Degrees(+13.82520847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355547"},
        {"Hipparcos Number", "HIP 100419"},
        {"Geneva Identification System", "GEN# +0.01304370"},
        {"Geneva Identification System 2", "GEN# +1.00355547"},
        {"Smithsonian Astrophysical Observation", "SAO 106022"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.44186880),
        dec: Angle.Degrees(+13.82578936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85500"},
        {"Smithsonian Astrophysical Observation", "SAO 102843"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.09602745),
        dec: Angle.Degrees(+13.82618239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27789"},
        {"Hipparcos Number", "HIP 20508"},
        {"Geneva Identification System", "GEN# +1.00027789"},
        {"Smithsonian Astrophysical Observation", "SAO 93903"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.92299201),
        dec: Angle.Degrees(+13.82873269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75976"},
        {"Hipparcos Number", "HIP 43666"},
        {"Smithsonian Astrophysical Observation", "SAO 98202"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.44065846),
        dec: Angle.Degrees(+13.83041940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48753"},
        {"Smithsonian Astrophysical Observation", "SAO 98855"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.15813282),
        dec: Angle.Degrees(+13.83376605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125945"},
        {"Hipparcos Number", "HIP 70234"},
        {"Smithsonian Astrophysical Observation", "SAO 100994"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.55625386),
        dec: Angle.Degrees(+13.83433597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121248"},
        {"Hipparcos Number", "HIP 67865"},
        {"Geneva Identification System", "GEN# +1.00121248"},
        {"Smithsonian Astrophysical Observation", "SAO 100762"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.50552650),
        dec: Angle.Degrees(+13.83470373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27145"},
        {"Hipparcos Number", "HIP 20025"},
        {"Geneva Identification System", "GEN# +1.00027145"},
        {"Smithsonian Astrophysical Observation", "SAO 93847"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.42910862),
        dec: Angle.Degrees(+13.83648571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6900"},
        {"Smithsonian Astrophysical Observation", "SAO 92455"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.20743750),
        dec: Angle.Degrees(+13.83700594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15822"},
        {"Smithsonian Astrophysical Observation", "SAO 93411"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.96768480),
        dec: Angle.Degrees(+13.83726998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25311"},
        {"Hipparcos Number", "HIP 18806"},
        {"Geneva Identification System", "GEN# +1.00025311"},
        {"Smithsonian Astrophysical Observation", "SAO 93728"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.44275665),
        dec: Angle.Degrees(+13.83755030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65914"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.69381980),
        dec: Angle.Degrees(+13.83826216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287028"},
        {"Hipparcos Number", "HIP 22183"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.58788814),
        dec: Angle.Degrees(+13.83887152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208418"},
        {"Hipparcos Number", "HIP 108249"},
        {"Smithsonian Astrophysical Observation", "SAO 107514"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.95634430),
        dec: Angle.Degrees(+13.83890500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147735"},
        {"Hipparcos Number", "HIP 80260"},
        {"Geneva Identification System", "GEN# +1.00147735"},
        {"Smithsonian Astrophysical Observation", "SAO 102116"},
        {"Wilson Evans Batten Catalogue", "WEB 13584"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.77394185),
        dec: Angle.Degrees(+13.83979248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64998"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.84564054),
        dec: Angle.Degrees(+13.84016235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2994"},
        {"Hipparcos Number", "HIP 2626"},
        {"Geneva Identification System", "GEN# +1.00002994"},
        {"Smithsonian Astrophysical Observation", "SAO 91965"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.32664516),
        dec: Angle.Degrees(+13.84062112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177955"},
        {"Hipparcos Number", "HIP 93811"},
        {"Smithsonian Astrophysical Observation", "SAO 104475"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.57998459),
        dec: Angle.Degrees(+13.84176539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184883"},
        {"Hipparcos Number", "HIP 96401"},
        {"Smithsonian Astrophysical Observation", "SAO 105027"},
        {"Wilson Evans Batten Catalogue", "WEB 16911"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.99726653),
        dec: Angle.Degrees(+13.84188436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44200",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7125 AB"},
        {"Henry Draper", "HD 77025"},
        {"Hipparcos Number", "HIP 44200"},
        {"Smithsonian Astrophysical Observation", "SAO 98285"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.05342572),
        dec: Angle.Degrees(+13.84409637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112961"},
        {"Hipparcos Number", "HIP 63472"},
        {"Fundamental Katalog 5th Edition", "FK5 5146"},
        {"Geneva Identification System", "GEN# +1.00112961"},
        {"Smithsonian Astrophysical Observation", "SAO 100364"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.09210677),
        dec: Angle.Degrees(+13.84439292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59450"},
        {"Hipparcos Number", "HIP 36497"},
        {"Geneva Identification System", "GEN# +1.00059450"},
        {"Smithsonian Astrophysical Observation", "SAO 96967"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.63344300),
        dec: Angle.Degrees(+13.84447897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39700"},
        {"Hipparcos Number", "HIP 27944"},
        {"Geneva Identification System", "GEN# +1.00039700"},
        {"Smithsonian Astrophysical Observation", "SAO 94984"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.69623563),
        dec: Angle.Degrees(+13.84629663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130004"},
        {"Hipparcos Number", "HIP 72146"},
        {"Cincinnati Publication", "Ci 18 1945"},
        {"Smithsonian Astrophysical Observation", "SAO 101188"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.35134201),
        dec: Angle.Degrees(+13.84686352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20458"},
        {"Hipparcos Number", "HIP 15345"},
        {"Smithsonian Astrophysical Observation", "SAO 93373"},
        {"Wilson Evans Batten Catalogue", "WEB 2952"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.46841666),
        dec: Angle.Degrees(+13.84723416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127789"},
        {"Hipparcos Number", "HIP 71137"},
        {"Smithsonian Astrophysical Observation", "SAO 101074"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.23040787),
        dec: Angle.Degrees(+13.84842450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192687"},
        {"Hipparcos Number", "HIP 99866"},
        {"Renson", "Renson 53770"},
        {"Smithsonian Astrophysical Observation", "SAO 105903"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.92662311),
        dec: Angle.Degrees(+13.84914437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43112"},
        {"Hipparcos Number", "HIP 29678"},
        {"Celescope Catalog", "CEL 1138"},
        {"Fundamental Katalog 5th Edition", "FK5 2474"},
        {"Geneva Identification System", "GEN# +1.00043112A"},
        {"Smithsonian Astrophysical Observation", "SAO 95444"},
        {"Wilson Evans Batten Catalogue", "WEB 5846"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.78523916),
        dec: Angle.Degrees(+13.85107261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104870"},
        {"Smithsonian Astrophysical Observation", "SAO 106951"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.64869602),
        dec: Angle.Degrees(+13.85147171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20305"},
        {"Hipparcos Number", "HIP 15233"},
        {"Geneva Identification System", "GEN# +1.00020305"},
        {"Smithsonian Astrophysical Observation", "SAO 93367"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.10602167),
        dec: Angle.Degrees(+13.85149403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46050"},
        {"Smithsonian Astrophysical Observation", "SAO 98541"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.86566127),
        dec: Angle.Degrees(+13.85284798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39680"},
        {"Hipparcos Number", "HIP 27941"},
        {"Celescope Catalog", "CEL 1028"},
        {"Geneva Identification System", "GEN# +1.00039680"},
        {"Smithsonian Astrophysical Observation", "SAO 94983"},
        {"Wilson Evans Batten Catalogue", "WEB 5471"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.68638357),
        dec: Angle.Degrees(+13.85474393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60150",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8514 A"},
        {"Henry Draper", "HD 107288"},
        {"Hipparcos Number", "HIP 60150"},
        {"Geneva Identification System", "GEN# +1.00107288"},
        {"Smithsonian Astrophysical Observation", "SAO 100048"},
        {"Wilson Evans Batten Catalogue", "WEB 10692"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.02039304),
        dec: Angle.Degrees(+13.85508018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170542"},
        {"Hipparcos Number", "HIP 90618"},
        {"Geneva Identification System", "GEN# +1.00170542"},
        {"Smithsonian Astrophysical Observation", "SAO 103770"},
        {"Wilson Evans Batten Catalogue", "WEB 15518"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.36428493),
        dec: Angle.Degrees(+13.85511061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94504"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.51495914),
        dec: Angle.Degrees(+13.85660906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96574"},
        {"Hipparcos Number", "HIP 54383"},
        {"Geneva Identification System", "GEN# +1.00096574"},
        {"Smithsonian Astrophysical Observation", "SAO 99459"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.90174386),
        dec: Angle.Degrees(+13.85856656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -364.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63474"},
        {"Hipparcos Number", "HIP 38208"},
        {"Geneva Identification System", "GEN# +1.00063474"},
        {"Smithsonian Astrophysical Observation", "SAO 97283"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.41939698),
        dec: Angle.Degrees(+13.85861711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215386"},
        {"Hipparcos Number", "HIP 112288"},
        {"Smithsonian Astrophysical Observation", "SAO 108141"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.16282913),
        dec: Angle.Degrees(+13.86169409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217339"},
        {"Hipparcos Number", "HIP 113550"},
        {"Geneva Identification System", "GEN# +1.00217339"},
        {"Smithsonian Astrophysical Observation", "SAO 108316"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.96873025),
        dec: Angle.Degrees(+13.86226314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93747",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Okab"},
        {"Aitken", "ADS 12026 A"},
        {"Henry Draper", "HD 177724"},
        {"Hipparcos Number", "HIP 93747"},
        {"Fundamental Katalog 5th Edition", "FK5 716"},
        {"Geneva Identification System", "GEN# +1.00177724"},
        {"Smithsonian Astrophysical Observation", "SAO 104461"},
        {"Wilson Evans Batten Catalogue", "WEB 16294"},
    },
    visualMagnitude: 2.99,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.35255180),
        dec: Angle.Degrees(+13.86370983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55946"},
        {"Hipparcos Number", "HIP 35124"},
        {"Geneva Identification System", "GEN# +1.00055946"},
        {"Smithsonian Astrophysical Observation", "SAO 96699"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.92402876),
        dec: Angle.Degrees(+13.86438485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27483"},
        {"Hipparcos Number", "HIP 20284"},
        {"Celescope Catalog", "CEL 389"},
        {"Geneva Identification System", "GEN# +5.20250034"},
        {"Smithsonian Astrophysical Observation", "SAO 93878"},
        {"Wilson Evans Batten Catalogue", "WEB 3879"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.21940620),
        dec: Angle.Degrees(+13.86447069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1563"},
        {"Smithsonian Astrophysical Observation", "SAO 91847"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.85776992),
        dec: Angle.Degrees(+13.86458537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36485",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6135 A"},
        {"Henry Draper", "HD 59432"},
        {"Henry Draper 2", "HD 59432A"},
        {"Hipparcos Number", "HIP 36485"},
        {"Geneva Identification System", "GEN# +1.00059432"},
        {"Smithsonian Astrophysical Observation", "SAO 96964"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.60938217),
        dec: Angle.Degrees(+13.86500784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56329"},
        {"Hipparcos Number", "HIP 35268"},
        {"Geneva Identification System", "GEN# +1.00056329"},
        {"Smithsonian Astrophysical Observation", "SAO 96722"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.29767217),
        dec: Angle.Degrees(+13.86575707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28258"},
        {"Hipparcos Number", "HIP 20850"},
        {"Geneva Identification System", "GEN# +5.20250178"},
        {"Wilson Evans Batten Catalogue", "WEB 4001"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.01821661),
        dec: Angle.Degrees(+13.86798498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156484"},
        {"Hipparcos Number", "HIP 84566"},
        {"Geneva Identification System", "GEN# +1.00156484"},
        {"Smithsonian Astrophysical Observation", "SAO 102713"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.31520844),
        dec: Angle.Degrees(+13.86885257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115201"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.00725533),
        dec: Angle.Degrees(+13.87091803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6324"},
    },
    visualMagnitude: 12.15,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.29590973),
        dec: Angle.Degrees(+13.87109344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88679"},
        {"Hipparcos Number", "HIP 50124"},
        {"Smithsonian Astrophysical Observation", "SAO 99013"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.48671095),
        dec: Angle.Degrees(+13.87225262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76282"},
        {"Wilson Evans Batten Catalogue", "WEB 12952"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.71642688),
        dec: Angle.Degrees(+13.87481794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15351"},
        {"Hipparcos Number", "HIP 11522"},
        {"Smithsonian Astrophysical Observation", "SAO 92968"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.14293141),
        dec: Angle.Degrees(+13.87661165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7132"},
        {"Hipparcos Number", "HIP 5596"},
        {"Geneva Identification System", "GEN# +1.00007132"},
        {"Smithsonian Astrophysical Observation", "SAO 92306"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.94034616),
        dec: Angle.Degrees(+13.87672050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88007",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10944 AB"},
        {"Hipparcos Number", "HIP 88007"},
        {"Smithsonian Astrophysical Observation", "SAO 103263"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.65858845),
        dec: Angle.Degrees(+13.88370173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153226"},
        {"Hipparcos Number", "HIP 82989"},
        {"Fundamental Katalog 5th Edition", "FK5 3346"},
        {"Geneva Identification System", "GEN# +1.00153226"},
        {"Smithsonian Astrophysical Observation", "SAO 102496"},
        {"Wilson Evans Batten Catalogue", "WEB 14030"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.38370142),
        dec: Angle.Degrees(+13.88394324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6566"},
        {"Hipparcos Number", "HIP 5207"},
        {"Geneva Identification System", "GEN# +1.00006566"},
        {"Smithsonian Astrophysical Observation", "SAO 92251"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.65204665),
        dec: Angle.Degrees(+13.88470299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62949"},
        {"Hipparcos Number", "HIP 37967"},
        {"Smithsonian Astrophysical Observation", "SAO 97233"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.73806474),
        dec: Angle.Degrees(+13.88760088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154464"},
        {"Hipparcos Number", "HIP 83590"},
        {"Smithsonian Astrophysical Observation", "SAO 102581"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.26609892),
        dec: Angle.Degrees(+13.88908614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68157"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.30221321),
        dec: Angle.Degrees(+13.88925016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22682"},
        {"Hipparcos Number", "HIP 17049"},
        {"Fundamental Katalog 5th Edition", "FK5 4329"},
        {"Geneva Identification System", "GEN# +1.00022682"},
        {"Smithsonian Astrophysical Observation", "SAO 93532"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.82102357),
        dec: Angle.Degrees(+13.89173640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142861"},
        {"Hipparcos Number", "HIP 78075"},
        {"Smithsonian Astrophysical Observation", "SAO 101827"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.12053433),
        dec: Angle.Degrees(+13.89182222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25186"},
        {"Hipparcos Number", "HIP 18718"},
        {"Smithsonian Astrophysical Observation", "SAO 93718"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.15426747),
        dec: Angle.Degrees(+13.89224145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28424"},
        {"Hipparcos Number", "HIP 20952"},
        {"Fundamental Katalog 5th Edition", "FK5 4408"},
        {"Geneva Identification System", "GEN# +1.00028424"},
        {"Smithsonian Astrophysical Observation", "SAO 93965"},
        {"Wilson Evans Batten Catalogue", "WEB 4026"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.38575263),
        dec: Angle.Degrees(+13.89474652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5094 A"},
        {"Henry Draper", "HD 257905"},
        {"Hipparcos Number", "HIP 30820"},
        {"Smithsonian Astrophysical Observation", "SAO 95722"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.12230165),
        dec: Angle.Degrees(+13.89760845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27364",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4381 A"},
        {"Henry Draper", "HD 38622"},
        {"Hipparcos Number", "HIP 27364"},
        {"Celescope Catalog", "CEL 971"},
        {"Fundamental Katalog 5th Edition", "FK5 2433"},
        {"Geneva Identification System", "GEN# +1.00038622A"},
        {"Smithsonian Astrophysical Observation", "SAO 94864"},
        {"Wilson Evans Batten Catalogue", "WEB 5376"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.92877017),
        dec: Angle.Degrees(+13.89963175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81002"},
        {"Smithsonian Astrophysical Observation", "SAO 102232"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.13853505),
        dec: Angle.Degrees(+13.90169104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99088"},
        {"Hipparcos Number", "HIP 55661"},
        {"Geneva Identification System", "GEN# +1.00099088"},
        {"Smithsonian Astrophysical Observation", "SAO 99589"},
        {"Wilson Evans Batten Catalogue", "WEB 10006"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.06552026),
        dec: Angle.Degrees(+13.90198314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28635"},
        {"Hipparcos Number", "HIP 21112"},
        {"Geneva Identification System", "GEN# +5.20250088"},
        {"Smithsonian Astrophysical Observation", "SAO 93988"},
        {"Wilson Evans Batten Catalogue", "WEB 4060"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.87204966),
        dec: Angle.Degrees(+13.90351710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125247"},
        {"Hipparcos Number", "HIP 69865"},
        {"Geneva Identification System", "GEN# +1.00125247"},
        {"Smithsonian Astrophysical Observation", "SAO 100962"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.45843408),
        dec: Angle.Degrees(+13.90398142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164137"},
        {"Hipparcos Number", "HIP 88065"},
        {"Smithsonian Astrophysical Observation", "SAO 103271"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.79697432),
        dec: Angle.Degrees(+13.90501747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89994"},
        {"Hipparcos Number", "HIP 50884"},
        {"Geneva Identification System", "GEN# +1.00089994"},
        {"Smithsonian Astrophysical Observation", "SAO 99095"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.85602271),
        dec: Angle.Degrees(+13.90542670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141993"},
        {"Hipparcos Number", "HIP 77682"},
        {"Smithsonian Astrophysical Observation", "SAO 101779"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.88728607),
        dec: Angle.Degrees(+13.90563831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216840"},
        {"Hipparcos Number", "HIP 113270"},
        {"Geneva Identification System", "GEN# +1.00216840"},
        {"Smithsonian Astrophysical Observation", "SAO 108265"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.04806208),
        dec: Angle.Degrees(+13.90638010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176232"},
        {"Hipparcos Number", "HIP 93179"},
        {"Geneva Identification System", "GEN# +1.00176232"},
        {"Renson", "Renson 49160"},
        {"Smithsonian Astrophysical Observation", "SAO 104303"},
        {"Wilson Evans Batten Catalogue", "WEB 16146"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.69551472),
        dec: Angle.Degrees(+13.90677273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125659"},
        {"Hipparcos Number", "HIP 70087"},
        {"Geneva Identification System", "GEN# +1.00125659"},
        {"Smithsonian Astrophysical Observation", "SAO 100982"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.13490089),
        dec: Angle.Degrees(+13.90723285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179373"},
        {"Hipparcos Number", "HIP 94315"},
        {"Smithsonian Astrophysical Observation", "SAO 104579"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.94831445),
        dec: Angle.Degrees(+13.90926107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189985"},
        {"Hipparcos Number", "HIP 98657"},
        {"Smithsonian Astrophysical Observation", "SAO 105575"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.58284518),
        dec: Angle.Degrees(+13.90946678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114538"},
        {"Hipparcos Number", "HIP 64328"},
        {"Geneva Identification System", "GEN# +1.00114538"},
        {"Smithsonian Astrophysical Observation", "SAO 100448"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.78021214),
        dec: Angle.Degrees(+13.91001749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32259"},
        {"Hipparcos Number", "HIP 23443"},
        {"Geneva Identification System", "GEN# +1.00032259"},
        {"Smithsonian Astrophysical Observation", "SAO 94280"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.58463004),
        dec: Angle.Degrees(+13.91048443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194578"},
        {"Hipparcos Number", "HIP 100781"},
        {"Smithsonian Astrophysical Observation", "SAO 106097"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.50659436),
        dec: Angle.Degrees(+13.91167933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18257"},
        {"Hipparcos Number", "HIP 13678"},
        {"Cincinnati Publication", "Ci 18 381"},
        {"Smithsonian Astrophysical Observation", "SAO 93193"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.05015070),
        dec: Angle.Degrees(+13.91318803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117044"},
        {"Hipparcos Number", "HIP 65644"},
        {"Geneva Identification System", "GEN# +1.00117044"},
        {"Renson", "Renson 33760"},
        {"Smithsonian Astrophysical Observation", "SAO 100573"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.87517957),
        dec: Angle.Degrees(+13.91378305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89517"},
        {"Wilson Evans Batten Catalogue", "WEB 15243"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.00913002),
        dec: Angle.Degrees(+13.91460796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -500.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231241"},
        {"Hipparcos Number", "HIP 95206"},
        {"Geneva Identification System", "GEN# +1.00231241"},
        {"Smithsonian Astrophysical Observation", "SAO 104769"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.52037674),
        dec: Angle.Degrees(+13.91539620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1243"},
        {"Hipparcos Number", "HIP 1340"},
        {"Smithsonian Astrophysical Observation", "SAO 91812"},
        {"Wilson Evans Batten Catalogue", "WEB 240"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.19017076),
        dec: Angle.Degrees(+13.91680830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13567"},
        {"Hipparcos Number", "HIP 10300"},
        {"Smithsonian Astrophysical Observation", "SAO 92837"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.17755113),
        dec: Angle.Degrees(+13.91848558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198703"},
        {"Hipparcos Number", "HIP 102977"},
        {"Smithsonian Astrophysical Observation", "SAO 106585"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.95132895),
        dec: Angle.Degrees(+13.91886873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205353"},
        {"Hipparcos Number", "HIP 106512"},
        {"Geneva Identification System", "GEN# +1.00205353"},
        {"Smithsonian Astrophysical Observation", "SAO 107243"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.59762203),
        dec: Angle.Degrees(+13.91997755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229663"},
        {"Hipparcos Number", "HIP 92428"},
        {"Smithsonian Astrophysical Observation", "SAO 104161"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.54644963),
        dec: Angle.Degrees(+13.92098591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286878"},
        {"Hipparcos Number", "HIP 21533"},
        {"Smithsonian Astrophysical Observation", "SAO 94039"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.35340482),
        dec: Angle.Degrees(+13.92101651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76078"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.07047756),
        dec: Angle.Degrees(+13.92133865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33734"},
        {"Hipparcos Number", "HIP 24302"},
        {"Geneva Identification System", "GEN# +1.00033734"},
        {"Smithsonian Astrophysical Observation", "SAO 94396"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.22200285),
        dec: Angle.Degrees(+13.92145251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38865"},
        {"Hipparcos Number", "HIP 27504"},
        {"Smithsonian Astrophysical Observation", "SAO 94885"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.35707291),
        dec: Angle.Degrees(+13.92178728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8534 AB"},
        {"Henry Draper", "HD 107855"},
        {"Hipparcos Number", "HIP 60445"},
        {"Geneva Identification System", "GEN# +1.00107855"},
        {"Smithsonian Astrophysical Observation", "SAO 100075"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.88686041),
        dec: Angle.Degrees(+13.92257829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217386"},
        {"Hipparcos Number", "HIP 113568"},
        {"Smithsonian Astrophysical Observation", "SAO 108321"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.03992001),
        dec: Angle.Degrees(+13.92470054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4519 A"},
        {"Henry Draper", "HD 39881"},
        {"Hipparcos Number", "HIP 28066"},
        {"Cincinnati Publication", "Ci 20 358"},
        {"Geneva Identification System", "GEN# +1.00039881"},
        {"Smithsonian Astrophysical Observation", "SAO 95004"},
        {"Wilson Evans Batten Catalogue", "WEB 5494"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.01336958),
        dec: Angle.Degrees(+13.92608804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 373.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -483.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120864"},
        {"Hipparcos Number", "HIP 67676"},
        {"Geneva Identification System", "GEN# +1.00120864"},
        {"Smithsonian Astrophysical Observation", "SAO 100743"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.97061314),
        dec: Angle.Degrees(+13.92699263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101152"},
        {"Hipparcos Number", "HIP 56782"},
        {"Smithsonian Astrophysical Observation", "SAO 99707"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.62292492),
        dec: Angle.Degrees(+13.92726368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49589"},
        {"Smithsonian Astrophysical Observation", "SAO 98956"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.84798712),
        dec: Angle.Degrees(+13.92730936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106114",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15018 AB"},
        {"Henry Draper", "HD 204643"},
        {"Hipparcos Number", "HIP 106114"},
        {"Smithsonian Astrophysical Observation", "SAO 107174"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.41550974),
        dec: Angle.Degrees(+13.92772501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10046"},
        {"Hipparcos Number", "HIP 7644"},
        {"Geneva Identification System", "GEN# +1.00010046"},
        {"Smithsonian Astrophysical Observation", "SAO 92548"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.61484059),
        dec: Angle.Degrees(+13.92832550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252248"},
        {"Hipparcos Number", "HIP 29121"},
        {"Geneva Identification System", "GEN# +2.21690005"},
        {"Smithsonian Astrophysical Observation", "SAO 95281"},
        {"Wilson Evans Batten Catalogue", "WEB 5707"},
        {"New General Catalogue", "NGC 2169 5"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.11398934),
        dec: Angle.Degrees(+13.93087369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5726"},
        {"Smithsonian Astrophysical Observation", "SAO 92321"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.41152238),
        dec: Angle.Degrees(+13.93138248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17150"},
        {"Hipparcos Number", "HIP 12869"},
        {"Smithsonian Astrophysical Observation", "SAO 93087"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.35798337),
        dec: Angle.Degrees(+13.93199726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68462"},
        {"Hipparcos Number", "HIP 40232"},
        {"Geneva Identification System", "GEN# +1.00068462"},
        {"Smithsonian Astrophysical Observation", "SAO 97656"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.25476133),
        dec: Angle.Degrees(+13.93290948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89306"},
        {"Hipparcos Number", "HIP 50479"},
        {"Geneva Identification System", "GEN# +1.00089306"},
        {"Smithsonian Astrophysical Observation", "SAO 99052"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.60860128),
        dec: Angle.Degrees(+13.93372956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57603"},
        {"Hipparcos Number", "HIP 35760"},
        {"Geneva Identification System", "GEN# +1.00057603"},
        {"Smithsonian Astrophysical Observation", "SAO 96829"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.64784705),
        dec: Angle.Degrees(+13.93890144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1965"},
        {"Smithsonian Astrophysical Observation", "SAO 91883"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.20963977),
        dec: Angle.Degrees(+13.94153924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286481"},
        {"Hipparcos Number", "HIP 18927"},
        {"Smithsonian Astrophysical Observation", "SAO 93741"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.85730224),
        dec: Angle.Degrees(+13.94270165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56915"},
        {"Hipparcos Number", "HIP 35501"},
        {"Geneva Identification System", "GEN# +1.00056915"},
        {"Smithsonian Astrophysical Observation", "SAO 96774"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.90477003),
        dec: Angle.Degrees(+13.94383444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72391"},
        {"Smithsonian Astrophysical Observation", "SAO 101223"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.01425684),
        dec: Angle.Degrees(+13.94475650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24335"},
        {"Hipparcos Number", "HIP 18145"},
        {"Smithsonian Astrophysical Observation", "SAO 93647"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.19634540),
        dec: Angle.Degrees(+13.94680456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5734"},
    },
    visualMagnitude: 12.37,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.42709878),
        dec: Angle.Degrees(+13.94733668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14243"},
        {"Hipparcos Number", "HIP 10766"},
        {"Geneva Identification System", "GEN# +1.00014243"},
        {"Smithsonian Astrophysical Observation", "SAO 92880"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.64187024),
        dec: Angle.Degrees(+13.95030053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108676"},
        {"Hipparcos Number", "HIP 60918"},
        {"Geneva Identification System", "GEN# +1.00108676"},
        {"Smithsonian Astrophysical Observation", "SAO 100121"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.27370256),
        dec: Angle.Degrees(+13.95032288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211607"},
        {"Hipparcos Number", "HIP 110089"},
        {"Geneva Identification System", "GEN# +1.00211607"},
        {"Smithsonian Astrophysical Observation", "SAO 107807"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.51682609),
        dec: Angle.Degrees(+13.95036038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92127"},
        {"Hipparcos Number", "HIP 52070"},
        {"Geneva Identification System", "GEN# +1.00092127"},
        {"Smithsonian Astrophysical Observation", "SAO 99223"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.60866284),
        dec: Angle.Degrees(+13.95090611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54516"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.31015303),
        dec: Angle.Degrees(+13.95182000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5418"},
        {"Hipparcos Number", "HIP 4382"},
        {"Fundamental Katalog 5th Edition", "FK5 4083"},
        {"Geneva Identification System", "GEN# +1.00005418"},
        {"Smithsonian Astrophysical Observation", "SAO 92159"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.03800933),
        dec: Angle.Degrees(+13.95196746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210554"},
        {"Hipparcos Number", "HIP 109486"},
        {"Geneva Identification System", "GEN# +1.00210554"},
        {"Smithsonian Astrophysical Observation", "SAO 107715"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.70516523),
        dec: Angle.Degrees(+13.95214638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85266"},
        {"Smithsonian Astrophysical Observation", "SAO 102812"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.34725593),
        dec: Angle.Degrees(+13.95287603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116833"},
        {"Smithsonian Astrophysical Observation", "SAO 108767"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.19882255),
        dec: Angle.Degrees(+13.95295289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202644"},
        {"Hipparcos Number", "HIP 105057"},
        {"Geneva Identification System", "GEN# +1.00202644"},
        {"Smithsonian Astrophysical Observation", "SAO 106990"},
        {"Wilson Evans Batten Catalogue", "WEB 19084"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.22805792),
        dec: Angle.Degrees(+13.95317281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43343"},
        {"Smithsonian Astrophysical Observation", "SAO 98147"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.44175177),
        dec: Angle.Degrees(+13.95424877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178006"},
        {"Hipparcos Number", "HIP 93830"},
        {"Smithsonian Astrophysical Observation", "SAO 104481"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.61744875),
        dec: Angle.Degrees(+13.95528942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8748"},
        {"Hipparcos Number", "HIP 6724"},
        {"Geneva Identification System", "GEN# +1.00008748"},
        {"Smithsonian Astrophysical Observation", "SAO 92443"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.63444961),
        dec: Angle.Degrees(+13.95916583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15597"},
        {"Hipparcos Number", "HIP 11700"},
        {"Smithsonian Astrophysical Observation", "SAO 92984"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.73164933),
        dec: Angle.Degrees(+13.95971296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72611"},
        {"Smithsonian Astrophysical Observation", "SAO 101243"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.68431864),
        dec: Angle.Degrees(+13.96127645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198389"},
        {"Hipparcos Number", "HIP 102807"},
        {"Geneva Identification System", "GEN# +1.00198389"},
        {"Smithsonian Astrophysical Observation", "SAO 106538"},
        {"Wilson Evans Batten Catalogue", "WEB 18644"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.41248671),
        dec: Angle.Degrees(+13.96276045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56119"},
        {"Smithsonian Astrophysical Observation", "SAO 99636"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.55169428),
        dec: Angle.Degrees(+13.96317333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241068"},
        {"Hipparcos Number", "HIP 23974"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28892715),
        dec: Angle.Degrees(+13.96520367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174853"},
        {"Hipparcos Number", "HIP 92593"},
        {"Fundamental Katalog 5th Edition", "FK5 3503"},
        {"Geneva Identification System", "GEN# +1.00174853"},
        {"Smithsonian Astrophysical Observation", "SAO 104196"},
        {"Wilson Evans Batten Catalogue", "WEB 16015"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.00802921),
        dec: Angle.Degrees(+13.96566731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33108"},
        {"Hipparcos Number", "HIP 23938"},
        {"Smithsonian Astrophysical Observation", "SAO 94343"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.16347325),
        dec: Angle.Degrees(+13.96644017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29127",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4728 D"},
        {"Hipparcos Number", "HIP 29127"},
        {"Geneva Identification System", "GEN# +2.21690004"},
        {"New General Catalogue", "NGC 2169 4"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.13343185),
        dec: Angle.Degrees(+13.96693967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11422"},
        {"Smithsonian Astrophysical Observation", "SAO 92956"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.83012298),
        dec: Angle.Degrees(+13.96793707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13987 AB"},
        {"Hipparcos Number", "HIP 101390"},
        {"Geneva Identification System", "GEN# +0.01304434"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.22107543),
        dec: Angle.Degrees(+13.96920659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216259"},
        {"Hipparcos Number", "HIP 112870"},
        {"Cincinnati Publication", "Ci 20 1384"},
        {"Fundamental Katalog 5th Edition", "FK5 6017"},
        {"Geneva Identification System", "GEN# +1.00216259"},
        {"Smithsonian Astrophysical Observation", "SAO 108215"},
        {"Wilson Evans Batten Catalogue", "WEB 20100"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.85880920),
        dec: Angle.Degrees(+13.96949165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 404.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29126",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4728 AB"},
        {"Henry Draper", "HD 41943"},
        {"Hipparcos Number", "HIP 29126"},
        {"Geneva Identification System", "GEN# +2.21690001"},
        {"Smithsonian Astrophysical Observation", "SAO 95282"},
        {"Wilson Evans Batten Catalogue", "WEB 5706"},
        {"New General Catalogue", "NGC 2169 1"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.12652337),
        dec: Angle.Degrees(+13.97106622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252214"},
        {"Hipparcos Number", "HIP 29106"},
        {"Geneva Identification System", "GEN# +2.21690002"},
        {"Smithsonian Astrophysical Observation", "SAO 95271"},
        {"New General Catalogue", "NGC 2169 2"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07545859),
        dec: Angle.Degrees(+13.97153562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55555"},
        {"Hipparcos Number", "HIP 34959"},
        {"Geneva Identification System", "GEN# +1.00055555"},
        {"Smithsonian Astrophysical Observation", "SAO 96655"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.49780625),
        dec: Angle.Degrees(+13.97441984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163732"},
        {"Hipparcos Number", "HIP 87876"},
        {"Smithsonian Astrophysical Observation", "SAO 103239"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.26971308),
        dec: Angle.Degrees(+13.97456766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96"},
        {"Geneva Identification System", "GEN# +0.01305195A"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.30489357),
        dec: Angle.Degrees(+13.97474826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25049"},
        {"Hipparcos Number", "HIP 18634"},
        {"Geneva Identification System", "GEN# +1.00025049"},
        {"Smithsonian Astrophysical Observation", "SAO 93705"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.83213805),
        dec: Angle.Degrees(+13.97519023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124678"},
        {"Hipparcos Number", "HIP 69585"},
        {"Smithsonian Astrophysical Observation", "SAO 100929"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.64859650),
        dec: Angle.Degrees(+13.97525489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3107"},
        {"Smithsonian Astrophysical Observation", "SAO 92009"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.89161620),
        dec: Angle.Degrees(+13.97546228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31399"},
        {"Hipparcos Number", "HIP 22942"},
        {"Smithsonian Astrophysical Observation", "SAO 94216"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.04573284),
        dec: Angle.Degrees(+13.97558764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92587"},
        {"Hipparcos Number", "HIP 52329"},
        {"Smithsonian Astrophysical Observation", "SAO 99249"},
        {"Wilson Evans Batten Catalogue", "WEB 9525"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.40483898),
        dec: Angle.Degrees(+13.97846149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133211"},
        {"Hipparcos Number", "HIP 73621"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.73631429),
        dec: Angle.Degrees(+13.97888812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355163"},
        {"Hipparcos Number", "HIP 99584"},
        {"Renson", "Renson 53540"},
        {"Smithsonian Astrophysical Observation", "SAO 105837"},
    },
    visualMagnitude: 9.62,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.14494690),
        dec: Angle.Degrees(+13.98150940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188264"},
        {"Hipparcos Number", "HIP 97908"},
        {"Geneva Identification System", "GEN# +1.00188264"},
        {"Smithsonian Astrophysical Observation", "SAO 105391"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.44765752),
        dec: Angle.Degrees(+13.98180679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49333"},
        {"Wilson Evans Batten Catalogue", "WEB 9122"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.06630381),
        dec: Angle.Degrees(+13.98272003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53561"},
        {"Hipparcos Number", "HIP 34258"},
        {"Smithsonian Astrophysical Observation", "SAO 96485"},
        {"Wilson Evans Batten Catalogue", "WEB 6862"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.52098501),
        dec: Angle.Degrees(+13.98580063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260240"},
        {"Hipparcos Number", "HIP 31495"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.94055511),
        dec: Angle.Degrees(+13.98595237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57537"},
        {"Hipparcos Number", "HIP 35730"},
        {"Smithsonian Astrophysical Observation", "SAO 96826"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.56268838),
        dec: Angle.Degrees(+13.98672153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77668"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.85665270),
        dec: Angle.Degrees(+13.98739816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81982"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.20822368),
        dec: Angle.Degrees(+13.98820314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95652"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.84813742),
        dec: Angle.Degrees(+13.98836598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231460"},
        {"Hipparcos Number", "HIP 95649"},
        {"Geneva Identification System", "GEN# +1.00231460"},
        {"Smithsonian Astrophysical Observation", "SAO 104855"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.84449889),
        dec: Angle.Degrees(+13.98846644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17480"},
        {"Smithsonian Astrophysical Observation", "SAO 93578"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.18272915),
        dec: Angle.Degrees(+13.98948970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9904 AB"},
        {"Henry Draper", "HD 143993"},
        {"Hipparcos Number", "HIP 78621"},
        {"Smithsonian Astrophysical Observation", "SAO 101894"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.75920891),
        dec: Angle.Degrees(+13.99147647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3963"},
        {"Hipparcos Number", "HIP 3323"},
        {"Smithsonian Astrophysical Observation", "SAO 92041"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.58871370),
        dec: Angle.Degrees(+13.99453332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146451"},
        {"Hipparcos Number", "HIP 79695"},
        {"Smithsonian Astrophysical Observation", "SAO 102045"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.96829458),
        dec: Angle.Degrees(+13.99545364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42241"},
        {"Smithsonian Astrophysical Observation", "SAO 97964"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.17143501),
        dec: Angle.Degrees(+13.99561341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2822"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96726021),
        dec: Angle.Degrees(+13.99765783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260472"},
        {"Hipparcos Number", "HIP 31581"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.13921850),
        dec: Angle.Degrees(+13.99821520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -324.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95723",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)28, 12.3800),
        dec: Angle.DegreesMinutesSeconds((int)+13, (int)59, 55.600)
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
    primaryId: "HIP 113581",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16437 AB"},
        {"Henry Draper", "HD 217401"},
        {"Hipparcos Number", "HIP 113581"},
        {"Renson", "Renson 59960"},
        {"Smithsonian Astrophysical Observation", "SAO 108325"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08034356),
        dec: Angle.Degrees(+14.00087220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231510"},
        {"Hipparcos Number", "HIP 95727"},
        {"Geneva Identification System", "GEN# +1.00231510"},
        {"Geneva Identification System 2", "GEN# +0.01304024"},
        {"Smithsonian Astrophysical Observation", "SAO 104872"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.05736833),
        dec: Angle.Degrees(+14.00152237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31609"},
        {"Hipparcos Number", "HIP 23069"},
        {"Geneva Identification System", "GEN# +5.20250127"},
        {"Smithsonian Astrophysical Observation", "SAO 94231"},
        {"Wilson Evans Batten Catalogue", "WEB 4476"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.45609880),
        dec: Angle.Degrees(+14.00223322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55773"},
        {"Hipparcos Number", "HIP 35053"},
        {"Smithsonian Astrophysical Observation", "SAO 96678"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.73618976),
        dec: Angle.Degrees(+14.00295466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4423"},
        {"Hipparcos Number", "HIP 3642"},
        {"Geneva Identification System", "GEN# +1.00004423"},
        {"Smithsonian Astrophysical Observation", "SAO 92077"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.66006967),
        dec: Angle.Degrees(+14.00317689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4161 AB"},
        {"Aitken 2", "ADS 4161"},
        {"Henry Draper", "HD 36740"},
        {"Hipparcos Number", "HIP 26151"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.62854315),
        dec: Angle.Degrees(+14.00331668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68332"},
        {"Hipparcos Number", "HIP 40177"},
        {"Geneva Identification System", "GEN# +1.00068332"},
        {"Smithsonian Astrophysical Observation", "SAO 97647"},
        {"Wilson Evans Batten Catalogue", "WEB 7837"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.09245280),
        dec: Angle.Degrees(+14.00413114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133371"},
        {"Hipparcos Number", "HIP 73686"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.92829152),
        dec: Angle.Degrees(+14.00707268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -394.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203304"},
        {"Hipparcos Number", "HIP 105416"},
        {"Geneva Identification System", "GEN# +1.00203304"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.28297827),
        dec: Angle.Degrees(+14.00709831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161768"},
        {"Hipparcos Number", "HIP 87012"},
        {"Smithsonian Astrophysical Observation", "SAO 103100"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.70086191),
        dec: Angle.Degrees(+14.00942062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100903"},
        {"Hipparcos Number", "HIP 56648"},
        {"Smithsonian Astrophysical Observation", "SAO 99696"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.23854992),
        dec: Angle.Degrees(+14.01331776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216949"},
        {"Hipparcos Number", "HIP 113334"},
        {"Geneva Identification System", "GEN# +1.00216949"},
        {"Smithsonian Astrophysical Observation", "SAO 108278"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.28337810),
        dec: Angle.Degrees(+14.01423064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48736"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.11605725),
        dec: Angle.Degrees(+14.01456798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15906"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.21416685),
        dec: Angle.Degrees(+14.01487511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89590"},
        {"Smithsonian Astrophysical Observation", "SAO 103555"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.23275250),
        dec: Angle.Degrees(+14.01585870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42842"},
        {"Hipparcos Number", "HIP 29544"},
        {"Smithsonian Astrophysical Observation", "SAO 95398"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.38275855),
        dec: Angle.Degrees(+14.01681404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153225"},
        {"Hipparcos Number", "HIP 82988"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.37957222),
        dec: Angle.Degrees(+14.01710175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81579"},
        {"Smithsonian Astrophysical Observation", "SAO 102299"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.90734293),
        dec: Angle.Degrees(+14.01860358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92170"},
        {"Hipparcos Number", "HIP 52099"},
        {"Smithsonian Astrophysical Observation", "SAO 99225"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.68133696),
        dec: Angle.Degrees(+14.01938517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84194"},
        {"Hipparcos Number", "HIP 47723"},
        {"Fundamental Katalog 5th Edition", "FK5 1252"},
        {"Geneva Identification System", "GEN# +1.00084194"},
        {"Smithsonian Astrophysical Observation", "SAO 98733"},
        {"Wilson Evans Batten Catalogue", "WEB 8941"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93292295),
        dec: Angle.Degrees(+14.02170696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208789"},
        {"Hipparcos Number", "HIP 108471"},
        {"Smithsonian Astrophysical Observation", "SAO 107553"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.61380796),
        dec: Angle.Degrees(+14.02233141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120877"},
        {"Hipparcos Number", "HIP 67685"},
        {"Smithsonian Astrophysical Observation", "SAO 100744"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.98840236),
        dec: Angle.Degrees(+14.02404036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166255"},
        {"Hipparcos Number", "HIP 88931"},
        {"Smithsonian Astrophysical Observation", "SAO 103428"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.29757072),
        dec: Angle.Degrees(+14.02610713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35711"},
        {"Hipparcos Number", "HIP 25513"},
        {"Smithsonian Astrophysical Observation", "SAO 94561"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.84060550),
        dec: Angle.Degrees(+14.02899472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128731"},
        {"Hipparcos Number", "HIP 71572"},
        {"Smithsonian Astrophysical Observation", "SAO 101120"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.56038997),
        dec: Angle.Degrees(+14.02923597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103311"},
        {"Hipparcos Number", "HIP 58006"},
        {"Geneva Identification System", "GEN# +1.00103311"},
        {"Smithsonian Astrophysical Observation", "SAO 99848"},
        {"Wilson Evans Batten Catalogue", "WEB 10390"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.46439064),
        dec: Angle.Degrees(+14.02965487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87487"},
    },
    visualMagnitude: 11.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.13748256),
        dec: Angle.Degrees(+14.03143661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211960"},
        {"Hipparcos Number", "HIP 110323"},
        {"Smithsonian Astrophysical Observation", "SAO 107846"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.17635585),
        dec: Angle.Degrees(+14.03235130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62528"},
        {"Smithsonian Astrophysical Observation", "SAO 100278"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.20698994),
        dec: Angle.Degrees(+14.03287979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80463",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cujam"},
        {"Aitken", "ADS 10054 AB"},
        {"Henry Draper", "HD 148112"},
        {"Hipparcos Number", "HIP 80463"},
        {"Fundamental Katalog 5th Edition", "FK5 613"},
        {"Geneva Identification System", "GEN# +1.00148112"},
        {"Renson", "Renson 41850"},
        {"Smithsonian Astrophysical Observation", "SAO 102153"},
        {"Wilson Evans Batten Catalogue", "WEB 13611"},
    },
    visualMagnitude: 4.57,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.35387324),
        dec: Angle.Degrees(+14.03341514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215092"},
        {"Hipparcos Number", "HIP 112121"},
        {"Geneva Identification System", "GEN# +1.00215092"},
        {"Smithsonian Astrophysical Observation", "SAO 108119"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.66297103),
        dec: Angle.Degrees(+14.03352204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199923"},
        {"Hipparcos Number", "HIP 103629"},
        {"Smithsonian Astrophysical Observation", "SAO 106737"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.95016684),
        dec: Angle.Degrees(+14.03386340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151953"},
        {"Hipparcos Number", "HIP 82379"},
        {"Smithsonian Astrophysical Observation", "SAO 102417"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.50751678),
        dec: Angle.Degrees(+14.03437463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27397"},
        {"Hipparcos Number", "HIP 20219"},
        {"Celescope Catalog", "CEL 386"},
        {"Geneva Identification System", "GEN# +5.20250030"},
        {"Smithsonian Astrophysical Observation", "SAO 93872"},
        {"Wilson Evans Batten Catalogue", "WEB 3856"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.99014508),
        dec: Angle.Degrees(+14.03524954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132343"},
        {"Hipparcos Number", "HIP 73253"},
        {"Fundamental Katalog 5th Edition", "FK5 5325"},
        {"Smithsonian Astrophysical Observation", "SAO 101306"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.56747078),
        dec: Angle.Degrees(+14.03758707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103914"},
        {"Hipparcos Number", "HIP 58359"},
        {"Geneva Identification System", "GEN# +1.00103914"},
        {"Smithsonian Astrophysical Observation", "SAO 99888"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.50434195),
        dec: Angle.Degrees(+14.03775966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107759"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.45297302),
        dec: Angle.Degrees(+14.03828633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9777 AB"},
        {"Hipparcos Number", "HIP 77202"},
        {"Smithsonian Astrophysical Observation", "SAO 101719"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.45756828),
        dec: Angle.Degrees(+14.03895156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209406"},
        {"Hipparcos Number", "HIP 108843"},
        {"Smithsonian Astrophysical Observation", "SAO 107619"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.73319594),
        dec: Angle.Degrees(+14.03931054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19884"},
        {"Hipparcos Number", "HIP 14897"},
        {"Smithsonian Astrophysical Observation", "SAO 93334"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06328167),
        dec: Angle.Degrees(+14.03953508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65916"},
        {"Hipparcos Number", "HIP 39247"},
        {"Smithsonian Astrophysical Observation", "SAO 97486"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.39712838),
        dec: Angle.Degrees(+14.04057780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61038"},
        {"Hipparcos Number", "HIP 37136"},
        {"Smithsonian Astrophysical Observation", "SAO 97095"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.46202054),
        dec: Angle.Degrees(+14.04220241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78348"},
        {"Hipparcos Number", "HIP 44831"},
        {"Smithsonian Astrophysical Observation", "SAO 98380"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.02667555),
        dec: Angle.Degrees(+14.04251663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90326"},
        {"Smithsonian Astrophysical Observation", "SAO 103705"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.44876768),
        dec: Angle.Degrees(+14.04269999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108348"},
        {"Hipparcos Number", "HIP 60738"},
        {"Geneva Identification System", "GEN# +1.00108348"},
        {"Smithsonian Astrophysical Observation", "SAO 100100"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.72165399),
        dec: Angle.Degrees(+14.04386971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137004"},
        {"Hipparcos Number", "HIP 75321"},
        {"Geneva Identification System", "GEN# +1.00137004"},
        {"Smithsonian Astrophysical Observation", "SAO 101517"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.83747541),
        dec: Angle.Degrees(+14.04520691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91876"},
        {"Hipparcos Number", "HIP 51949"},
        {"Geneva Identification System", "GEN# +1.00091876"},
        {"Smithsonian Astrophysical Observation", "SAO 99207"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.19099298),
        dec: Angle.Degrees(+14.04553906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69986"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.81159848),
        dec: Angle.Degrees(+14.04777839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39099"},
        {"Hipparcos Number", "HIP 27618"},
        {"Geneva Identification System", "GEN# +1.00039099"},
        {"Smithsonian Astrophysical Observation", "SAO 94916"},
        {"Wilson Evans Batten Catalogue", "WEB 5423"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.71410357),
        dec: Angle.Degrees(+14.04802980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96720"},
        {"Geneva Identification System", "GEN# +0.01304091"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.92262472),
        dec: Angle.Degrees(+14.04816756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203699"},
        {"Hipparcos Number", "HIP 105623"},
        {"Fundamental Katalog 5th Edition", "FK5 3706"},
        {"Geneva Identification System", "GEN# +1.00203699"},
        {"Smithsonian Astrophysical Observation", "SAO 107095"},
        {"Wilson Evans Batten Catalogue", "WEB 19173"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.89743223),
        dec: Angle.Degrees(+14.05019694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11261 AB"},
        {"Hipparcos Number", "HIP 89809"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.92565142),
        dec: Angle.Degrees(+14.05134804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286734"},
        {"Hipparcos Number", "HIP 20527"},
        {"Geneva Identification System", "GEN# +5.20251294"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.97642905),
        dec: Angle.Degrees(+14.05215000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1547",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Citadelle"},
        {"Henry Draper", "HD 1502"},
        {"Hipparcos Number", "HIP 1547"},
        {"Geneva Identification System", "GEN# +1.00001502"},
        {"Smithsonian Astrophysical Observation", "SAO 91845"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.82092175),
        dec: Angle.Degrees(+14.05479812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121560"},
        {"Hipparcos Number", "HIP 68030"},
        {"Fundamental Katalog 5th Edition", "FK5 3109"},
        {"Geneva Identification System", "GEN# +1.00121560"},
        {"Smithsonian Astrophysical Observation", "SAO 100776"},
        {"Wilson Evans Batten Catalogue", "WEB 11946"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.95903560),
        dec: Angle.Degrees(+14.05648068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -291.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8126"},
        {"Smithsonian Astrophysical Observation", "SAO 92606"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.10471141),
        dec: Angle.Degrees(+14.05662416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43583"},
        {"Hipparcos Number", "HIP 29881"},
        {"Celescope Catalog", "CEL 1161"},
        {"Geneva Identification System", "GEN# +1.00043583"},
        {"Smithsonian Astrophysical Observation", "SAO 95494"},
        {"Wilson Evans Batten Catalogue", "WEB 5917"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.38880311),
        dec: Angle.Degrees(+14.05868430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127740"},
        {"Hipparcos Number", "HIP 71132"},
        {"Geneva Identification System", "GEN# +1.00127740"},
        {"Smithsonian Astrophysical Observation", "SAO 101073"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.20623494),
        dec: Angle.Degrees(+14.06092371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8426"},
        {"Smithsonian Astrophysical Observation", "SAO 92642"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16289060),
        dec: Angle.Degrees(+14.06117957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74743"},
        {"Hipparcos Number", "HIP 43043"},
        {"Smithsonian Astrophysical Observation", "SAO 98110"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.54801126),
        dec: Angle.Degrees(+14.06212153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102864"},
        {"Smithsonian Astrophysical Observation", "SAO 106556"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.60217984),
        dec: Angle.Degrees(+14.06311154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45778"},
        {"Smithsonian Astrophysical Observation", "SAO 98505"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.01420406),
        dec: Angle.Degrees(+14.06382414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63131"},
        {"Geneva Identification System", "GEN# +0.01402562"},
        {"Smithsonian Astrophysical Observation", "SAO 100340"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.02003792),
        dec: Angle.Degrees(+14.06419090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141692"},
        {"Hipparcos Number", "HIP 77536"},
        {"Geneva Identification System", "GEN# +1.00141692"},
        {"Smithsonian Astrophysical Observation", "SAO 101761"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.47123323),
        dec: Angle.Degrees(+14.06564857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81506"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.71601768),
        dec: Angle.Degrees(+14.06620182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49820"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.55377128),
        dec: Angle.Degrees(+14.06781370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218936"},
        {"Hipparcos Number", "HIP 114538"},
        {"Smithsonian Astrophysical Observation", "SAO 108450"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.99880048),
        dec: Angle.Degrees(+14.06836428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18406"},
        {"Hipparcos Number", "HIP 13810"},
        {"Smithsonian Astrophysical Observation", "SAO 93208"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44891065),
        dec: Angle.Degrees(+14.07003259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211785"},
        {"Hipparcos Number", "HIP 110203"},
        {"Renson", "Renson 58780"},
        {"Smithsonian Astrophysical Observation", "SAO 107827"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.84786582),
        dec: Angle.Degrees(+14.07007596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40910"},
        {"Geneva Identification System", "GEN# +0.01401876"},
        {"Wilson Evans Batten Catalogue", "WEB 7933"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.23074731),
        dec: Angle.Degrees(+14.07196910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82906"},
        {"Hipparcos Number", "HIP 47035"},
        {"Geneva Identification System", "GEN# +1.00082906A"},
        {"Smithsonian Astrophysical Observation", "SAO 98654"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.78963532),
        dec: Angle.Degrees(+14.07565697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27628"},
        {"Hipparcos Number", "HIP 20400"},
        {"Celescope Catalog", "CEL 391"},
        {"Geneva Identification System", "GEN# +5.20250038"},
        {"Renson", "Renson 7080"},
        {"Smithsonian Astrophysical Observation", "SAO 93892"},
        {"Wilson Evans Batten Catalogue", "WEB 3900"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.51437351),
        dec: Angle.Degrees(+14.07725051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72780"},
        {"Smithsonian Astrophysical Observation", "SAO 101265"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.15739283),
        dec: Angle.Degrees(+14.07933137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153473"},
        {"Hipparcos Number", "HIP 83123"},
        {"Geneva Identification System", "GEN# +1.00153473"},
        {"Smithsonian Astrophysical Observation", "SAO 102509"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.79942246),
        dec: Angle.Degrees(+14.07942252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225182"},
        {"Hipparcos Number", "HIP 335"},
        {"Smithsonian Astrophysical Observation", "SAO 91686"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06601848),
        dec: Angle.Degrees(+14.08162325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32237"},
        {"Hipparcos Number", "HIP 23431"},
        {"Cincinnati Publication", "Ci 20 313"},
        {"Geneva Identification System", "GEN# +1.00032237"},
        {"Smithsonian Astrophysical Observation", "SAO 94279"},
        {"Wilson Evans Batten Catalogue", "WEB 4552"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.54074698),
        dec: Angle.Degrees(+14.08254884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -405.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9685 A"},
        {"Henry Draper", "HD 138454"},
        {"Hipparcos Number", "HIP 76038"},
        {"Geneva Identification System", "GEN# +1.00138454"},
        {"Smithsonian Astrophysical Observation", "SAO 101595"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.93748669),
        dec: Angle.Degrees(+14.08346987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126582"},
        {"Hipparcos Number", "HIP 70563"},
        {"Geneva Identification System", "GEN# +1.00126582"},
        {"Smithsonian Astrophysical Observation", "SAO 101020"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.50462866),
        dec: Angle.Degrees(+14.08392822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82906B"},
        {"Hipparcos Number", "HIP 47038"},
        {"Smithsonian Astrophysical Observation", "SAO 98655"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.79917703),
        dec: Angle.Degrees(+14.08452381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353408"},
        {"Hipparcos Number", "HIP 96847"},
        {"Smithsonian Astrophysical Observation", "SAO 105137"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.29394971),
        dec: Angle.Degrees(+14.08469888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32851"},
        {"Hipparcos Number", "HIP 23789"},
        {"Geneva Identification System", "GEN# +1.00032851"},
        {"Smithsonian Astrophysical Observation", "SAO 94323"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.67951832),
        dec: Angle.Degrees(+14.08507264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4897"},
        {"Hipparcos Number", "HIP 3983"},
        {"Geneva Identification System", "GEN# +1.00004897"},
        {"Smithsonian Astrophysical Observation", "SAO 92117"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.80613339),
        dec: Angle.Degrees(+14.08583370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23702"},
        {"Hipparcos Number", "HIP 17714"},
        {"Smithsonian Astrophysical Observation", "SAO 93603"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.90952442),
        dec: Angle.Degrees(+14.08689603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154880"},
        {"Hipparcos Number", "HIP 83790"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87158846),
        dec: Angle.Degrees(+14.08791383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66321"},
        {"Hipparcos Number", "HIP 39427"},
        {"Smithsonian Astrophysical Observation", "SAO 97516"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.89110386),
        dec: Angle.Degrees(+14.09035477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75399"},
        {"Smithsonian Astrophysical Observation", "SAO 101528"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.09115491),
        dec: Angle.Degrees(+14.09082657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154143"},
        {"Hipparcos Number", "HIP 83430"},
        {"Geneva Identification System", "GEN# +1.00154143"},
        {"Smithsonian Astrophysical Observation", "SAO 102553"},
        {"Wilson Evans Batten Catalogue", "WEB 14102"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.78273333),
        dec: Angle.Degrees(+14.09210030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165074"},
        {"Hipparcos Number", "HIP 88455"},
        {"Geneva Identification System", "GEN# +1.00165074"},
        {"Smithsonian Astrophysical Observation", "SAO 103338"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.89629341),
        dec: Angle.Degrees(+14.09263273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45044"},
        {"Henry Draper 2", "HD 45045"},
        {"Hipparcos Number", "HIP 30586"},
        {"Geneva Identification System", "GEN# +1.00045044"},
        {"Smithsonian Astrophysical Observation", "SAO 95666"},
        {"Wilson Evans Batten Catalogue", "WEB 6099"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.42530737),
        dec: Angle.Degrees(+14.09269603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243047"},
        {"Hipparcos Number", "HIP 25113"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.64646399),
        dec: Angle.Degrees(+14.09687641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180556"},
        {"Hipparcos Number", "HIP 94718"},
        {"Geneva Identification System", "GEN# +1.00180556"},
        {"Smithsonian Astrophysical Observation", "SAO 104667"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.10300929),
        dec: Angle.Degrees(+14.09782269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133967"},
        {"Hipparcos Number", "HIP 73967"},
        {"Geneva Identification System", "GEN# +1.00133967"},
        {"Smithsonian Astrophysical Observation", "SAO 101374"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.73374841),
        dec: Angle.Degrees(+14.09811318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65507"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.41119323),
        dec: Angle.Degrees(+14.09933138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36077",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6068 B"},
        {"Henry Draper", "HD 58383B"},
        {"Hipparcos Number", "HIP 36077"},
        {"Geneva Identification System", "GEN# +1.00058383B"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.50923718),
        dec: Angle.Degrees(+14.09999969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60303"},
        {"Hipparcos Number", "HIP 36826"},
        {"Smithsonian Astrophysical Observation", "SAO 97028"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.60626096),
        dec: Angle.Degrees(+14.10114253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6068 A"},
        {"Henry Draper", "HD 58383"},
        {"Hipparcos Number", "HIP 36078"},
        {"Geneva Identification System", "GEN# +1.00058383A"},
        {"Smithsonian Astrophysical Observation", "SAO 96892"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.51010125),
        dec: Angle.Degrees(+14.10296368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117126"},
        {"Smithsonian Astrophysical Observation", "SAO 108806"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.17221206),
        dec: Angle.Degrees(+14.10403850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29461"},
        {"Hipparcos Number", "HIP 21654"},
        {"Geneva Identification System", "GEN# +5.20250106"},
        {"Smithsonian Astrophysical Observation", "SAO 94049"},
        {"Wilson Evans Batten Catalogue", "WEB 4159"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.73855140),
        dec: Angle.Degrees(+14.10563192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55088"},
        {"Smithsonian Astrophysical Observation", "SAO 99533"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.18317286),
        dec: Angle.Degrees(+14.10592968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116907"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.46651448),
        dec: Angle.Degrees(+14.10727408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74227"},
        {"Hipparcos Number", "HIP 42797"},
        {"Geneva Identification System", "GEN# +1.00074227"},
        {"Smithsonian Astrophysical Observation", "SAO 98068"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80385673),
        dec: Angle.Degrees(+14.10790943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6441"},
        {"Hipparcos Number", "HIP 5101"},
        {"Smithsonian Astrophysical Observation", "SAO 92236"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.34761612),
        dec: Angle.Degrees(+14.10809871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78688"},
        {"Smithsonian Astrophysical Observation", "SAO 101899"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.95511495),
        dec: Angle.Degrees(+14.10827823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56112"},
        {"Smithsonian Astrophysical Observation", "SAO 99634"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.53418959),
        dec: Angle.Degrees(+14.11087808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118068"},
        {"Hipparcos Number", "HIP 66221"},
        {"Geneva Identification System", "GEN# +1.00118068"},
        {"Smithsonian Astrophysical Observation", "SAO 100625"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.58698525),
        dec: Angle.Degrees(+14.11107071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9515"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.59564160),
        dec: Angle.Degrees(+14.11126188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44738"},
        {"Hipparcos Number", "HIP 30433"},
        {"Geneva Identification System", "GEN# +1.00044738"},
        {"Renson", "Renson 11850"},
        {"Smithsonian Astrophysical Observation", "SAO 95625"},
        {"Wilson Evans Batten Catalogue", "WEB 6056"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.97513792),
        dec: Angle.Degrees(+14.11352535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113381"},
        {"Hipparcos Number", "HIP 63694"},
        {"Geneva Identification System", "GEN# +1.00113381"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.79491170),
        dec: Angle.Degrees(+14.11376684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117621"},
        {"Smithsonian Astrophysical Observation", "SAO 108871"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.82512539),
        dec: Angle.Degrees(+14.11513943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141187"},
        {"Hipparcos Number", "HIP 77336"},
        {"Geneva Identification System", "GEN# +1.00141187"},
        {"Smithsonian Astrophysical Observation", "SAO 101739"},
        {"Wilson Evans Batten Catalogue", "WEB 13100"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.82230086),
        dec: Angle.Degrees(+14.11527157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41197"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.09931134),
        dec: Angle.Degrees(+14.11599971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119260"},
        {"Hipparcos Number", "HIP 66841"},
        {"Geneva Identification System", "GEN# +1.00119260"},
        {"Smithsonian Astrophysical Observation", "SAO 100667"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.48275916),
        dec: Angle.Degrees(+14.11815044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164553"},
        {"Hipparcos Number", "HIP 88240"},
        {"Smithsonian Astrophysical Observation", "SAO 103300"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.28011770),
        dec: Angle.Degrees(+14.12000264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72885"},
        {"Hipparcos Number", "HIP 42165"},
        {"Geneva Identification System", "GEN# +1.00072885"},
        {"Smithsonian Astrophysical Observation", "SAO 97943"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.94365554),
        dec: Angle.Degrees(+14.12039644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85258"},
        {"Hipparcos Number", "HIP 48300"},
        {"Geneva Identification System", "GEN# +1.00085258"},
        {"Smithsonian Astrophysical Observation", "SAO 98805"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.71034397),
        dec: Angle.Degrees(+14.12068714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5765"},
        {"Hipparcos Number", "HIP 4629"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.85626665),
        dec: Angle.Degrees(+14.12152843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111397"},
        {"Hipparcos Number", "HIP 62541"},
        {"Fundamental Katalog 5th Edition", "FK5 3022"},
        {"Geneva Identification System", "GEN# +1.00111397"},
        {"Smithsonian Astrophysical Observation", "SAO 100283"},
        {"Wilson Evans Batten Catalogue", "WEB 11101"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.22581729),
        dec: Angle.Degrees(+14.12263297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79111"},
        {"Smithsonian Astrophysical Observation", "SAO 101961"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20755363),
        dec: Angle.Degrees(+14.12284728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215762"},
        {"Hipparcos Number", "HIP 112505"},
        {"Smithsonian Astrophysical Observation", "SAO 108176"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.84034788),
        dec: Angle.Degrees(+14.12318822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102272"},
        {"Hipparcos Number", "HIP 57428"},
        {"Geneva Identification System", "GEN# +1.00102272"},
        {"Smithsonian Astrophysical Observation", "SAO 99784"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.59808249),
        dec: Angle.Degrees(+14.12396823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354581"},
        {"Hipparcos Number", "HIP 98619"},
        {"Geneva Identification System", "GEN# +1.00354581"},
        {"Smithsonian Astrophysical Observation", "SAO 105566"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.46398887),
        dec: Angle.Degrees(+14.12490033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83788"},
        {"Hipparcos Number", "HIP 47503"},
        {"Smithsonian Astrophysical Observation", "SAO 98708"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.27317936),
        dec: Angle.Degrees(+14.12594225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79726"},
        {"Hipparcos Number", "HIP 45488"},
        {"Geneva Identification System", "GEN# +1.00079726"},
        {"Smithsonian Astrophysical Observation", "SAO 98464"},
        {"Wilson Evans Batten Catalogue", "WEB 8650"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.03194322),
        dec: Angle.Degrees(+14.12649151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63473"},
        {"Hipparcos Number", "HIP 38202"},
        {"Geneva Identification System", "GEN# +1.00063473"},
        {"Smithsonian Astrophysical Observation", "SAO 97281"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.40251369),
        dec: Angle.Degrees(+14.13132057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47994"},
        {"Smithsonian Astrophysical Observation", "SAO 98763"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.75133827),
        dec: Angle.Degrees(+14.13197402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61472"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.94743909),
        dec: Angle.Degrees(+14.13239807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109215"},
        {"Smithsonian Astrophysical Observation", "SAO 107674"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.87737988),
        dec: Angle.Degrees(+14.13530090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119058"},
        {"Hipparcos Number", "HIP 66740"},
        {"Geneva Identification System", "GEN# +1.00119058"},
        {"Smithsonian Astrophysical Observation", "SAO 100659"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.19150288),
        dec: Angle.Degrees(+14.13546151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123759"},
        {"Hipparcos Number", "HIP 69144"},
        {"Smithsonian Astrophysical Observation", "SAO 100876"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.30829684),
        dec: Angle.Degrees(+14.13642163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91232"},
        {"Hipparcos Number", "HIP 51585"},
        {"Fundamental Katalog 5th Edition", "FK5 1272"},
        {"Geneva Identification System", "GEN# +1.00091232"},
        {"Smithsonian Astrophysical Observation", "SAO 99172"},
        {"Wilson Evans Batten Catalogue", "WEB 9413"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.04916002),
        dec: Angle.Degrees(+14.13720956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181494"},
        {"Hipparcos Number", "HIP 95035"},
        {"Geneva Identification System", "GEN# +1.00181494"},
        {"Smithsonian Astrophysical Observation", "SAO 104735"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.04845928),
        dec: Angle.Degrees(+14.13877857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88737"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.72943557),
        dec: Angle.Degrees(+14.13894075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76537"},
        {"Smithsonian Astrophysical Observation", "SAO 101656"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.47262446),
        dec: Angle.Degrees(+14.13988538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82918",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10270 AB"},
        {"Henry Draper", "HD 153064"},
        {"Hipparcos Number", "HIP 82918"},
        {"Smithsonian Astrophysical Observation", "SAO 102488"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.16526048),
        dec: Angle.Degrees(+14.14019356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 405"},
        {"Hipparcos Number", "HIP 704"},
        {"Geneva Identification System", "GEN# +1.00000405"},
        {"Smithsonian Astrophysical Observation", "SAO 91731"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.19110187),
        dec: Angle.Degrees(+14.14205698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202304"},
        {"Hipparcos Number", "HIP 104873"},
        {"Geneva Identification System", "GEN# +1.00202304"},
        {"Smithsonian Astrophysical Observation", "SAO 106952"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.65877277),
        dec: Angle.Degrees(+14.14220286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103287"},
        {"Smithsonian Astrophysical Observation", "SAO 106661"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.88295427),
        dec: Angle.Degrees(+14.14277131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90880"},
        {"Hipparcos Number", "HIP 51392"},
        {"Smithsonian Astrophysical Observation", "SAO 99160"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.44996076),
        dec: Angle.Degrees(+14.14437537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169628"},
        {"Hipparcos Number", "HIP 90263"},
        {"Geneva Identification System", "GEN# +1.00169628"},
        {"Smithsonian Astrophysical Observation", "SAO 103693"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.26226646),
        dec: Angle.Degrees(+14.14499710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242207"},
        {"Hipparcos Number", "HIP 24591"},
        {"Smithsonian Astrophysical Observation", "SAO 94429"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.12603960),
        dec: Angle.Degrees(+14.14690019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116110"},
        {"Hipparcos Number", "HIP 65172"},
        {"Geneva Identification System", "GEN# +1.00116110"},
        {"Smithsonian Astrophysical Observation", "SAO 100527"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.34354579),
        dec: Angle.Degrees(+14.14896950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109917"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.93033550),
        dec: Angle.Degrees(+14.15088123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103420"},
        {"Hipparcos Number", "HIP 58069"},
        {"Geneva Identification System", "GEN# +1.00103420"},
        {"Smithsonian Astrophysical Observation", "SAO 99859"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.63958958),
        dec: Angle.Degrees(+14.15143231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16366"},
        {"Hipparcos Number", "HIP 12258"},
        {"Geneva Identification System", "GEN# +1.00016366"},
        {"Smithsonian Astrophysical Observation", "SAO 93030"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.45693720),
        dec: Angle.Degrees(+14.15150527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286831"},
        {"Hipparcos Number", "HIP 21132"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.94934519),
        dec: Angle.Degrees(+14.15496082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -330.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -352.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46374"},
        {"Hipparcos Number", "HIP 31277"},
        {"Geneva Identification System", "GEN# +1.00046374"},
        {"Smithsonian Astrophysical Observation", "SAO 95830"},
        {"Wilson Evans Batten Catalogue", "WEB 6251"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.40072046),
        dec: Angle.Degrees(+14.15537477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49551"},
        {"Smithsonian Astrophysical Observation", "SAO 98953"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.75991975),
        dec: Angle.Degrees(+14.15801788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172503"},
        {"Hipparcos Number", "HIP 91531"},
        {"Geneva Identification System", "GEN# +1.00172503"},
        {"Smithsonian Astrophysical Observation", "SAO 103970"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.99990479),
        dec: Angle.Degrees(+14.15815076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61976"},
        {"Geneva Identification System", "GEN# +0.01402533"},
        {"Smithsonian Astrophysical Observation", "SAO 100212"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.50993122),
        dec: Angle.Degrees(+14.15937245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43164"},
        {"Smithsonian Astrophysical Observation", "SAO 98126"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.88887412),
        dec: Angle.Degrees(+14.16096150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231873"},
        {"Hipparcos Number", "HIP 96301"},
        {"Geneva Identification System", "GEN# +1.00231873"},
        {"Smithsonian Astrophysical Observation", "SAO 104994"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.70462390),
        dec: Angle.Degrees(+14.16454282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46019",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7333 A"},
        {"Hipparcos Number", "HIP 46019"},
        {"Smithsonian Astrophysical Observation", "SAO 98537"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.77715034),
        dec: Angle.Degrees(+14.16759135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6100"},
        {"Hipparcos Number", "HIP 4846"},
        {"Smithsonian Astrophysical Observation", "SAO 92213"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.58825619),
        dec: Angle.Degrees(+14.16793309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99087"},
        {"Hipparcos Number", "HIP 55665"},
        {"Geneva Identification System", "GEN# +1.00099087"},
        {"Smithsonian Astrophysical Observation", "SAO 99590"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.07523962),
        dec: Angle.Degrees(+14.16908684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63836"},
        {"Hipparcos Number", "HIP 38360"},
        {"Smithsonian Astrophysical Observation", "SAO 97313"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.85079102),
        dec: Angle.Degrees(+14.17050016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115425"},
        {"Hipparcos Number", "HIP 64809"},
        {"Geneva Identification System", "GEN# +1.00115425"},
        {"Smithsonian Astrophysical Observation", "SAO 100494"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.24375707),
        dec: Angle.Degrees(+14.17178053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39317"},
        {"Hipparcos Number", "HIP 27743"},
        {"Celescope Catalog", "CEL 1011"},
        {"Geneva Identification System", "GEN# +1.00039317"},
        {"Renson", "Renson 10560"},
        {"Smithsonian Astrophysical Observation", "SAO 94945"},
        {"Wilson Evans Batten Catalogue", "WEB 5441"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.09292572),
        dec: Angle.Degrees(+14.17179382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107014"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.10366347),
        dec: Angle.Degrees(+14.17185953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 244.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43481"},
        {"Hipparcos Number", "HIP 29832"},
        {"Smithsonian Astrophysical Observation", "SAO 95483"},
        {"Wilson Evans Batten Catalogue", "WEB 5898"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.22789686),
        dec: Angle.Degrees(+14.17209617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62366"},
        {"Hipparcos Number", "HIP 37708"},
        {"Smithsonian Astrophysical Observation", "SAO 97196"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04027220),
        dec: Angle.Degrees(+14.17324596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66976"},
        {"Geneva Identification System", "GEN# +0.01402653"},
        {"Smithsonian Astrophysical Observation", "SAO 100677"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.90889277),
        dec: Angle.Degrees(+14.17442211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15558"},
        {"Smithsonian Astrophysical Observation", "SAO 93395"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.10815646),
        dec: Angle.Degrees(+14.17468922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16748"},
        {"Smithsonian Astrophysical Observation", "SAO 93503"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.86720825),
        dec: Angle.Degrees(+14.17503688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16671"},
        {"Smithsonian Astrophysical Observation", "SAO 93496"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.63917895),
        dec: Angle.Degrees(+14.17580913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11454"},
        {"Hipparcos Number", "HIP 8774"},
        {"Geneva Identification System", "GEN# +1.00011454"},
        {"Smithsonian Astrophysical Observation", "SAO 92673"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21271592),
        dec: Angle.Degrees(+14.17748145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181253"},
        {"Hipparcos Number", "HIP 94949"},
        {"Geneva Identification System", "GEN# +1.00181253"},
        {"Smithsonian Astrophysical Observation", "SAO 104717"},
        {"Wilson Evans Batten Catalogue", "WEB 16579"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.82085169),
        dec: Angle.Degrees(+14.17755043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37981"},
        {"Hipparcos Number", "HIP 26930"},
        {"Geneva Identification System", "GEN# +1.00037981"},
        {"Smithsonian Astrophysical Observation", "SAO 94795"},
        {"Wilson Evans Batten Catalogue", "WEB 5311"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74210057),
        dec: Angle.Degrees(+14.17852107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76293"},
        {"Hipparcos Number", "HIP 43833"},
        {"Geneva Identification System", "GEN# +1.00076293"},
        {"Smithsonian Astrophysical Observation", "SAO 98232"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.91353705),
        dec: Angle.Degrees(+14.18105897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77501"},
        {"Hipparcos Number", "HIP 44446"},
        {"Smithsonian Astrophysical Observation", "SAO 98318"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.82777498),
        dec: Angle.Degrees(+14.18357368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12612"},
        {"Hipparcos Number", "HIP 9643"},
        {"Smithsonian Astrophysical Observation", "SAO 92777"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.98543205),
        dec: Angle.Degrees(+14.18416761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103685"},
        {"Hipparcos Number", "HIP 58221"},
        {"Geneva Identification System", "GEN# +1.00103685"},
        {"Smithsonian Astrophysical Observation", "SAO 99876"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.11177529),
        dec: Angle.Degrees(+14.18626775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286402"},
        {"Hipparcos Number", "HIP 18551"},
        {"Smithsonian Astrophysical Observation", "SAO 93695"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.55423465),
        dec: Angle.Degrees(+14.18690858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214514"},
        {"Hipparcos Number", "HIP 111781"},
        {"Smithsonian Astrophysical Observation", "SAO 108062"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62683424),
        dec: Angle.Degrees(+14.18862822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93291"},
        {"Hipparcos Number", "HIP 52689"},
        {"Fundamental Katalog 5th Edition", "FK5 2860"},
        {"Geneva Identification System", "GEN# +1.00093291"},
        {"Smithsonian Astrophysical Observation", "SAO 99282"},
        {"Wilson Evans Batten Catalogue", "WEB 9595"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.60563681),
        dec: Angle.Degrees(+14.19480263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3129"},
        {"Smithsonian Astrophysical Observation", "SAO 92012"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.94167167),
        dec: Angle.Degrees(+14.20036034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69809"},
        {"Hipparcos Number", "HIP 40761"},
        {"Geneva Identification System", "GEN# +1.00069809"},
        {"Smithsonian Astrophysical Observation", "SAO 97727"},
        {"Wilson Evans Batten Catalogue", "WEB 7912"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.80569766),
        dec: Angle.Degrees(+14.20062022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213645"},
        {"Hipparcos Number", "HIP 111301"},
        {"Smithsonian Astrophysical Observation", "SAO 107991"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.21024891),
        dec: Angle.Degrees(+14.20068398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32095"},
        {"Hipparcos Number", "HIP 23351"},
        {"Geneva Identification System", "GEN# +1.00032095"},
        {"Smithsonian Astrophysical Observation", "SAO 94266"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.33081043),
        dec: Angle.Degrees(+14.20435358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229942"},
        {"Hipparcos Number", "HIP 92725"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.42379422),
        dec: Angle.Degrees(+14.20439485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61913"},
        {"Hipparcos Number", "HIP 37521"},
        {"Fundamental Katalog 5th Edition", "FK5 2597"},
        {"Geneva Identification System", "GEN# +1.00061913"},
        {"Smithsonian Astrophysical Observation", "SAO 97157"},
        {"Wilson Evans Batten Catalogue", "WEB 7423"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.51341314),
        dec: Angle.Degrees(+14.20852972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42560"},
        {"Hipparcos Number", "HIP 29426"},
        {"Celescope Catalog", "CEL 1115"},
        {"Geneva Identification System", "GEN# +1.00042560"},
        {"Smithsonian Astrophysical Observation", "SAO 95362"},
        {"Wilson Evans Batten Catalogue", "WEB 5777"},
    },
    visualMagnitude: 4.45,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.98498656),
        dec: Angle.Degrees(+14.20881425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6983"},
        {"Smithsonian Astrophysical Observation", "SAO 92464"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.47271661),
        dec: Angle.Degrees(+14.20963973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71555"},
        {"Hipparcos Number", "HIP 41578"},
        {"Fundamental Katalog 5th Edition", "FK5 1222"},
        {"Geneva Identification System", "GEN# +1.00071555J"},
        {"Smithsonian Astrophysical Observation", "SAO 97843"},
        {"Wilson Evans Batten Catalogue", "WEB 8025"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.15561552),
        dec: Angle.Degrees(+14.21085416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79319"},
        {"Hipparcos Number", "HIP 45295"},
        {"Geneva Identification System", "GEN# +1.00079319"},
        {"Smithsonian Astrophysical Observation", "SAO 98443"},
        {"Wilson Evans Batten Catalogue", "WEB 8628"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.45868533),
        dec: Angle.Degrees(+14.21089481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93542"},
        {"Hipparcos Number", "HIP 52824"},
        {"Geneva Identification System", "GEN# +1.00093542"},
        {"Smithsonian Astrophysical Observation", "SAO 99297"},
        {"Wilson Evans Batten Catalogue", "WEB 9617"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.01507763),
        dec: Angle.Degrees(+14.21171306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57906"},
        {"Smithsonian Astrophysical Observation", "SAO 99839"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.15961421),
        dec: Angle.Degrees(+14.21467610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48011"},
        {"Hipparcos Number", "HIP 32055"},
        {"Celescope Catalog", "CEL 1352"},
        {"Smithsonian Astrophysical Observation", "SAO 96007"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.46090944),
        dec: Angle.Degrees(+14.21674130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18010"},
        {"Hipparcos Number", "HIP 13505"},
        {"Geneva Identification System", "GEN# +1.00018010"},
        {"Smithsonian Astrophysical Observation", "SAO 93169"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.48751932),
        dec: Angle.Degrees(+14.21894954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4497 A"},
        {"Henry Draper", "HD 39729"},
        {"Hipparcos Number", "HIP 27961"},
        {"Smithsonian Astrophysical Observation", "SAO 94990"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.72999057),
        dec: Angle.Degrees(+14.21988862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28113"},
        {"Hipparcos Number", "HIP 20740"},
        {"Smithsonian Astrophysical Observation", "SAO 93937"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.66240773),
        dec: Angle.Degrees(+14.22047486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70023"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.92867142),
        dec: Angle.Degrees(+14.22381998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135840"},
        {"Hipparcos Number", "HIP 74776"},
        {"Geneva Identification System", "GEN# +1.00135840"},
        {"Smithsonian Astrophysical Observation", "SAO 101473"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.23165732),
        dec: Angle.Degrees(+14.22484091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11156"},
        {"Hipparcos Number", "HIP 8532"},
        {"Smithsonian Astrophysical Observation", "SAO 92652"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.50464039),
        dec: Angle.Degrees(+14.22614193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67221"},
        {"Geneva Identification System", "GEN# +0.01402660"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61912534),
        dec: Angle.Degrees(+14.22750805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53293"},
        {"Hipparcos Number", "HIP 34162"},
        {"Smithsonian Astrophysical Observation", "SAO 96462"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.25772737),
        dec: Angle.Degrees(+14.22828432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50768"},
        {"Hipparcos Number", "HIP 33258"},
        {"Smithsonian Astrophysical Observation", "SAO 96272"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.79376026),
        dec: Angle.Degrees(+14.22835426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51502"},
        {"Hipparcos Number", "HIP 33529"},
        {"Geneva Identification System", "GEN# +1.00051502"},
        {"Smithsonian Astrophysical Observation", "SAO 96325"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.52747115),
        dec: Angle.Degrees(+14.22871600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7117 AB"},
        {"Henry Draper", "HD 76793"},
        {"Hipparcos Number", "HIP 44082"},
        {"Smithsonian Astrophysical Observation", "SAO 98270"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.69244351),
        dec: Angle.Degrees(+14.22971840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12838",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2101 AB"},
        {"Henry Draper", "HD 17104"},
        {"Hipparcos Number", "HIP 12838"},
        {"Smithsonian Astrophysical Observation", "SAO 93085"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.26004686),
        dec: Angle.Degrees(+14.23763273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80871"},
        {"Smithsonian Astrophysical Observation", "SAO 102216"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.70073768),
        dec: Angle.Degrees(+14.24033235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7772"},
        {"Hipparcos Number", "HIP 6036"},
        {"Geneva Identification System", "GEN# +1.00007772"},
        {"Smithsonian Astrophysical Observation", "SAO 92350"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.38741717),
        dec: Angle.Degrees(+14.24274813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76081"},
        {"Hipparcos Number", "HIP 43735"},
        {"Geneva Identification System", "GEN# +1.00076081"},
        {"Smithsonian Astrophysical Observation", "SAO 98219"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.61427640),
        dec: Angle.Degrees(+14.24489115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4914"},
        {"Hipparcos Number", "HIP 4000"},
        {"Smithsonian Astrophysical Observation", "SAO 92122"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.84245290),
        dec: Angle.Degrees(+14.24525964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77823"},
        {"Hipparcos Number", "HIP 44604"},
        {"Smithsonian Astrophysical Observation", "SAO 98348"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.31612454),
        dec: Angle.Degrees(+14.24526336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70263"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.65196453),
        dec: Angle.Degrees(+14.24721817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54103",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8044 AB"},
        {"Henry Draper", "HD 95936"},
        {"Hipparcos Number", "HIP 54103"},
        {"Smithsonian Astrophysical Observation", "SAO 99425"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.05927860),
        dec: Angle.Degrees(+14.24890237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51533"},
        {"Hipparcos Number", "HIP 33540"},
        {"Geneva Identification System", "GEN# +1.00051533"},
        {"Smithsonian Astrophysical Observation", "SAO 96331"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.55606701),
        dec: Angle.Degrees(+14.24923384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30959"},
        {"Hipparcos Number", "HIP 22667"},
        {"Fundamental Katalog 5th Edition", "FK5 1136"},
        {"Geneva Identification System", "GEN# +1.00030959"},
        {"Smithsonian Astrophysical Observation", "SAO 94176"},
        {"Wilson Evans Batten Catalogue", "WEB 4383"},
    },
    visualMagnitude: 4.71,
    bvColour: 1.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.13318214),
        dec: Angle.Degrees(+14.25077828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134714"},
        {"Hipparcos Number", "HIP 74287"},
        {"Smithsonian Astrophysical Observation", "SAO 101415"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.74688248),
        dec: Angle.Degrees(+14.25144801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61573"},
        {"Fundamental Katalog 5th Edition", "FK5 5111"},
        {"Geneva Identification System", "GEN# +0.01502483"},
        {"Smithsonian Astrophysical Observation", "SAO 100177"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.25954749),
        dec: Angle.Degrees(+14.25188176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6119"},
        {"Hipparcos Number", "HIP 4866"},
        {"Smithsonian Astrophysical Observation", "SAO 92214"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.64221015),
        dec: Angle.Degrees(+14.25201660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16304"},
        {"Smithsonian Astrophysical Observation", "SAO 93460"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.54818559),
        dec: Angle.Degrees(+14.25274773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108487"},
        {"Hipparcos Number", "HIP 60803"},
        {"Smithsonian Astrophysical Observation", "SAO 100107"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.92341399),
        dec: Angle.Degrees(+14.25784008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78823"},
        {"Hipparcos Number", "HIP 45065"},
        {"Geneva Identification System", "GEN# +1.00078823"},
        {"Smithsonian Astrophysical Observation", "SAO 98415"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.67754977),
        dec: Angle.Degrees(+14.25891018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138441"},
        {"Hipparcos Number", "HIP 76023"},
        {"Geneva Identification System", "GEN# +1.00138441"},
        {"Smithsonian Astrophysical Observation", "SAO 101594"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.91428777),
        dec: Angle.Degrees(+14.25967018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11672"},
        {"Smithsonian Astrophysical Observation", "SAO 92980"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.64297523),
        dec: Angle.Degrees(+14.26133489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49017"},
        {"Smithsonian Astrophysical Observation", "SAO 98889"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.00051017),
        dec: Angle.Degrees(+14.26311992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54299",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8058 AB"},
        {"Henry Draper", "HD 96345"},
        {"Hipparcos Number", "HIP 54299"},
        {"Cincinnati Publication", "Ci 18 1350"},
        {"Smithsonian Astrophysical Observation", "SAO 99440"},
    },
    visualMagnitude: 9.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.63102909),
        dec: Angle.Degrees(+14.26314547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -303.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102103"},
        {"Hipparcos Number", "HIP 57320"},
        {"Geneva Identification System", "GEN# +1.00102103"},
        {"Smithsonian Astrophysical Observation", "SAO 99774"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.29774406),
        dec: Angle.Degrees(+14.26332609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106495"},
        {"Hipparcos Number", "HIP 59736"},
        {"Geneva Identification System", "GEN# +1.00106495"},
        {"Smithsonian Astrophysical Observation", "SAO 100007"},
        {"Wilson Evans Batten Catalogue", "WEB 10613"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.75708431),
        dec: Angle.Degrees(+14.26495790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92109"},
        {"Hipparcos Number", "HIP 52066"},
        {"Smithsonian Astrophysical Observation", "SAO 99222"},
        {"Wilson Evans Batten Catalogue", "WEB 9492"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.58654621),
        dec: Angle.Degrees(+14.26763718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19208"},
        {"Hipparcos Number", "HIP 14404"},
        {"Smithsonian Astrophysical Observation", "SAO 93271"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.44883289),
        dec: Angle.Degrees(+14.26768444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55254",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8128 AB"},
        {"Henry Draper", "HD 98354"},
        {"Hipparcos Number", "HIP 55254"},
        {"Smithsonian Astrophysical Observation", "SAO 99551"},
        {"Wilson Evans Batten Catalogue", "WEB 9952"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.74944889),
        dec: Angle.Degrees(+14.26893470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148765"},
        {"Hipparcos Number", "HIP 80798"},
        {"Smithsonian Astrophysical Observation", "SAO 102211"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.47665741),
        dec: Angle.Degrees(+14.26922066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6489"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.84488996),
        dec: Angle.Degrees(+14.27052713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159735"},
        {"Hipparcos Number", "HIP 86103"},
        {"Smithsonian Astrophysical Observation", "SAO 102949"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.95170038),
        dec: Angle.Degrees(+14.27248693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27372"},
        {"Hipparcos Number", "HIP 20197"},
        {"Cincinnati Publication", "Ci 18 573"},
        {"Geneva Identification System", "GEN# +1.00027372A"},
        {"Smithsonian Astrophysical Observation", "SAO 93867"},
        {"Wilson Evans Batten Catalogue", "WEB 3850"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.93569544),
        dec: Angle.Degrees(+14.27419816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77881"},
        {"Geneva Identification System", "GEN# +0.01402955"},
        {"Smithsonian Astrophysical Observation", "SAO 101807"},
        {"Wilson Evans Batten Catalogue", "WEB 13170"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.56615027),
        dec: Angle.Degrees(+14.27421461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195631"},
        {"Hipparcos Number", "HIP 101305"},
        {"Geneva Identification System", "GEN# +1.00195631"},
        {"Smithsonian Astrophysical Observation", "SAO 106208"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.00761672),
        dec: Angle.Degrees(+14.27441724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69718"},
        {"Hipparcos Number", "HIP 40719"},
        {"Smithsonian Astrophysical Observation", "SAO 97722"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.67823502),
        dec: Angle.Degrees(+14.27599735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286573"},
        {"Hipparcos Number", "HIP 19526"},
        {"Smithsonian Astrophysical Observation", "SAO 93804"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.74650136),
        dec: Angle.Degrees(+14.27763616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122654"},
        {"Hipparcos Number", "HIP 68624"},
        {"Smithsonian Astrophysical Observation", "SAO 100827"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71198447),
        dec: Angle.Degrees(+14.27971953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183144"},
        {"Hipparcos Number", "HIP 95664"},
        {"Celescope Catalog", "CEL 4761"},
        {"Fundamental Katalog 5th Edition", "FK5 3555"},
        {"Geneva Identification System", "GEN# +1.00183144"},
        {"Smithsonian Astrophysical Observation", "SAO 104862"},
        {"Wilson Evans Batten Catalogue", "WEB 16733"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89126683),
        dec: Angle.Degrees(+14.28249131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353525"},
        {"Hipparcos Number", "HIP 97061"},
        {"Smithsonian Astrophysical Observation", "SAO 105188"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.88182254),
        dec: Angle.Degrees(+14.28291517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57606",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8311 AB"},
        {"Henry Draper", "HD 102590"},
        {"Hipparcos Number", "HIP 57606"},
        {"Geneva Identification System", "GEN# +1.00102590J"},
        {"Smithsonian Astrophysical Observation", "SAO 99800"},
        {"Wilson Evans Batten Catalogue", "WEB 10344"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.16154436),
        dec: Angle.Degrees(+14.28419729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166095"},
        {"Hipparcos Number", "HIP 88862"},
        {"Fundamental Katalog 5th Edition", "FK5 3442"},
        {"Geneva Identification System", "GEN# +1.00166095"},
        {"Renson", "Renson 46780"},
        {"Smithsonian Astrophysical Observation", "SAO 103414"},
        {"Wilson Evans Batten Catalogue", "WEB 15070"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.14058047),
        dec: Angle.Degrees(+14.28471737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10135"},
        {"Hipparcos Number", "HIP 7710"},
        {"Geneva Identification System", "GEN# +1.00010135"},
        {"Smithsonian Astrophysical Observation", "SAO 92556"},
        {"Wilson Evans Batten Catalogue", "WEB 1653"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.81411531),
        dec: Angle.Degrees(+14.28562593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7172"},
    },
    visualMagnitude: 11.52,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.11917564),
        dec: Angle.Degrees(+14.28582995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25749"},
        {"Hipparcos Number", "HIP 19085"},
        {"Geneva Identification System", "GEN# +1.00025749"},
        {"Smithsonian Astrophysical Observation", "SAO 93754"},
        {"Wilson Evans Batten Catalogue", "WEB 3665"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.37964611),
        dec: Angle.Degrees(+14.28638219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57675"},
        {"Hipparcos Number", "HIP 35772"},
        {"Geneva Identification System", "GEN# +1.00057675"},
        {"Smithsonian Astrophysical Observation", "SAO 96833"},
        {"Wilson Evans Batten Catalogue", "WEB 7127"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.68737064),
        dec: Angle.Degrees(+14.28773833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215957"},
        {"Hipparcos Number", "HIP 112640"},
        {"Smithsonian Astrophysical Observation", "SAO 108192"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.19675319),
        dec: Angle.Degrees(+14.28903741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90803"},
        {"Smithsonian Astrophysical Observation", "SAO 103806"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.85473218),
        dec: Angle.Degrees(+14.28925849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78648"},
        {"Smithsonian Astrophysical Observation", "SAO 101896"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.81790657),
        dec: Angle.Degrees(+14.28958879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142681"},
        {"Hipparcos Number", "HIP 77978"},
        {"Geneva Identification System", "GEN# +1.00142681"},
        {"Smithsonian Astrophysical Observation", "SAO 101818"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.86390163),
        dec: Angle.Degrees(+14.29017435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16007"},
        {"Smithsonian Astrophysical Observation", "SAO 93432"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.53676066),
        dec: Angle.Degrees(+14.29030415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215362"},
        {"Hipparcos Number", "HIP 112275"},
        {"Smithsonian Astrophysical Observation", "SAO 108140"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.12235527),
        dec: Angle.Degrees(+14.29057310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161149"},
        {"Hipparcos Number", "HIP 86732"},
        {"Fundamental Katalog 5th Edition", "FK5 3407"},
        {"Geneva Identification System", "GEN# +1.00161149"},
        {"Smithsonian Astrophysical Observation", "SAO 103052"},
        {"Wilson Evans Batten Catalogue", "WEB 14625"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.84175580),
        dec: Angle.Degrees(+14.29509983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148241"},
        {"Hipparcos Number", "HIP 80513"},
        {"Geneva Identification System", "GEN# +1.00148241"},
        {"Smithsonian Astrophysical Observation", "SAO 102166"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.54150654),
        dec: Angle.Degrees(+14.29558712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16359"},
        {"Smithsonian Astrophysical Observation", "SAO 93467"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.68923988),
        dec: Angle.Degrees(+14.29609239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14438"},
        {"Hipparcos Number", "HIP 10895"},
        {"Geneva Identification System", "GEN# +1.00014438"},
        {"Smithsonian Astrophysical Observation", "SAO 92890"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.05664907),
        dec: Angle.Degrees(+14.29779801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67657"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.92517849),
        dec: Angle.Degrees(+14.30164244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118660"},
        {"Hipparcos Number", "HIP 66522"},
        {"Geneva Identification System", "GEN# +1.00118660"},
        {"Renson", "Renson 34276"},
        {"Smithsonian Astrophysical Observation", "SAO 100644"},
        {"Wilson Evans Batten Catalogue", "WEB 11742"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.53276509),
        dec: Angle.Degrees(+14.30196227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29298"},
        {"Hipparcos Number", "HIP 21542"},
        {"Smithsonian Astrophysical Observation", "SAO 94041"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.38224879),
        dec: Angle.Degrees(+14.30206168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189131"},
        {"Hipparcos Number", "HIP 98266"},
        {"Geneva Identification System", "GEN# +1.00189131"},
        {"Smithsonian Astrophysical Observation", "SAO 105476"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.50329857),
        dec: Angle.Degrees(+14.30217509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20212"},
        {"Hipparcos Number", "HIP 15153"},
        {"Smithsonian Astrophysical Observation", "SAO 93362"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.82798443),
        dec: Angle.Degrees(+14.30315274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81595"},
        {"Hipparcos Number", "HIP 46345"},
        {"Smithsonian Astrophysical Observation", "SAO 98574"},
        {"Wilson Evans Batten Catalogue", "WEB 8762"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.73632840),
        dec: Angle.Degrees(+14.30321986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128800"},
        {"Hipparcos Number", "HIP 71608"},
        {"Geneva Identification System", "GEN# +1.00128800"},
        {"Smithsonian Astrophysical Observation", "SAO 101124"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.67932797),
        dec: Angle.Degrees(+14.30420949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231269"},
        {"Hipparcos Number", "HIP 95277"},
        {"Geneva Identification System", "GEN# +1.00231269"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76389141),
        dec: Angle.Degrees(+14.30514300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36653"},
        {"Hipparcos Number", "HIP 26093"},
        {"Fundamental Katalog 5th Edition", "FK5 2414"},
        {"Geneva Identification System", "GEN# +1.00036653"},
        {"Smithsonian Astrophysical Observation", "SAO 94652"},
        {"Wilson Evans Batten Catalogue", "WEB 5081"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.47618830),
        dec: Angle.Degrees(+14.30559209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39019"},
        {"Hipparcos Number", "HIP 27581"},
        {"Geneva Identification System", "GEN# +1.00039019"},
        {"Smithsonian Astrophysical Observation", "SAO 94904"},
        {"Wilson Evans Batten Catalogue", "WEB 5415"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62043148),
        dec: Angle.Degrees(+14.30569894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25153"},
        {"Hipparcos Number", "HIP 18692"},
        {"Geneva Identification System", "GEN# +1.00025153"},
        {"Smithsonian Astrophysical Observation", "SAO 93714"},
        {"Wilson Evans Batten Catalogue", "WEB 3598"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.06925676),
        dec: Angle.Degrees(+14.30594993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97306"},
        {"Hipparcos Number", "HIP 54711"},
        {"Smithsonian Astrophysical Observation", "SAO 99493"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.02299236),
        dec: Angle.Degrees(+14.30633965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102150",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14171 AB"},
        {"Henry Draper", "HD 197209"},
        {"Hipparcos Number", "HIP 102150"},
        {"Smithsonian Astrophysical Observation", "SAO 106392"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.47463068),
        dec: Angle.Degrees(+14.31074088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84921"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.32561716),
        dec: Angle.Degrees(+14.31113958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220107"},
        {"Hipparcos Number", "HIP 115289"},
        {"Geneva Identification System", "GEN# +1.00220107"},
        {"Smithsonian Astrophysical Observation", "SAO 108559"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.24024953),
        dec: Angle.Degrees(+14.31431874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136695"},
        {"Hipparcos Number", "HIP 75170"},
        {"Smithsonian Astrophysical Observation", "SAO 101503"},
        {"Wilson Evans Batten Catalogue", "WEB 12823"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.41472494),
        dec: Angle.Degrees(+14.31474072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2035"},
        {"Hipparcos Number", "HIP 1948"},
        {"Smithsonian Astrophysical Observation", "SAO 91881"},
        {"Wilson Evans Batten Catalogue", "WEB 366"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.15894159),
        dec: Angle.Degrees(+14.31552048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82207"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.91386512),
        dec: Angle.Degrees(+14.31620046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184041"},
        {"Hipparcos Number", "HIP 96060"},
        {"Smithsonian Astrophysical Observation", "SAO 104941"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.98162171),
        dec: Angle.Degrees(+14.31630338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70319"},
        {"Hipparcos Number", "HIP 40982"},
        {"Geneva Identification System", "GEN# +1.00070319"},
        {"Smithsonian Astrophysical Observation", "SAO 97756"},
        {"Wilson Evans Batten Catalogue", "WEB 7944"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.45180013),
        dec: Angle.Degrees(+14.31924820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66167"},
    },
    visualMagnitude: 11.49,
    bvColour: 2.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.44618097),
        dec: Angle.Degrees(+14.32208292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98883"},
        {"Hipparcos Number", "HIP 55568"},
        {"Fundamental Katalog 5th Edition", "FK5 5000"},
        {"Geneva Identification System", "GEN# +1.00098883"},
        {"Smithsonian Astrophysical Observation", "SAO 99581"},
        {"Wilson Evans Batten Catalogue", "WEB 9988"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.72808218),
        dec: Angle.Degrees(+14.32304413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16445"},
        {"Geneva Identification System", "GEN# +9.80005043"},
    },
    visualMagnitude: 12.26,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.94631242),
        dec: Angle.Degrees(+14.32323236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -674.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3633"},
        {"Smithsonian Astrophysical Observation", "SAO 92073"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.64135157),
        dec: Angle.Degrees(+14.32558918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51837"},
        {"Hipparcos Number", "HIP 33651"},
        {"Smithsonian Astrophysical Observation", "SAO 96352"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.86748864),
        dec: Angle.Degrees(+14.32636395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29778"},
        {"Hipparcos Number", "HIP 21864"},
        {"Smithsonian Astrophysical Observation", "SAO 94073"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.51939671),
        dec: Angle.Degrees(+14.32654770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188236"},
        {"Hipparcos Number", "HIP 97898"},
        {"Smithsonian Astrophysical Observation", "SAO 105389"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.42522712),
        dec: Angle.Degrees(+14.32716048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61728"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.79181638),
        dec: Angle.Degrees(+14.32725930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114592"},
        {"Hipparcos Number", "HIP 64344"},
        {"Geneva Identification System", "GEN# +1.00114592"},
        {"Smithsonian Astrophysical Observation", "SAO 100451"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.84043043),
        dec: Angle.Degrees(+14.32859738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61170"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.01552030),
        dec: Angle.Degrees(+14.33561677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52836"},
        {"Hipparcos Number", "HIP 33997"},
        {"Smithsonian Astrophysical Observation", "SAO 96421"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.80922297),
        dec: Angle.Degrees(+14.33615170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38751"},
        {"Smithsonian Astrophysical Observation", "SAO 97380"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.00601323),
        dec: Angle.Degrees(+14.33764368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116208"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.19339983),
        dec: Angle.Degrees(+14.33772205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87005"},
        {"Hipparcos Number", "HIP 49207"},
        {"Geneva Identification System", "GEN# +1.00087005"},
        {"Smithsonian Astrophysical Observation", "SAO 98917"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.64884547),
        dec: Angle.Degrees(+14.33952469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61037"},
        {"Hipparcos Number", "HIP 37135"},
        {"Smithsonian Astrophysical Observation", "SAO 97093"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.45958691),
        dec: Angle.Degrees(+14.34063643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8267"},
        {"Hipparcos Number", "HIP 6402"},
        {"Geneva Identification System", "GEN# +1.00008267A"},
        {"Smithsonian Astrophysical Observation", "SAO 92397"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.55465258),
        dec: Angle.Degrees(+14.34071307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64915"},
        {"Hipparcos Number", "HIP 38819"},
        {"Smithsonian Astrophysical Observation", "SAO 97392"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.17380613),
        dec: Angle.Degrees(+14.34220902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53966"},
        {"Hipparcos Number", "HIP 34376"},
        {"Geneva Identification System", "GEN# +1.00053966"},
        {"Smithsonian Astrophysical Observation", "SAO 96514"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.89919902),
        dec: Angle.Degrees(+14.34242965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90718"},
        {"Hipparcos Number", "HIP 51309"},
        {"Smithsonian Astrophysical Observation", "SAO 99150"},
        {"Wilson Evans Batten Catalogue", "WEB 9370"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.20236750),
        dec: Angle.Degrees(+14.34371768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8538",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)50, 04.8000),
        dec: Angle.DegreesMinutesSeconds((int)+14, (int)20, 43.500)
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
    primaryId: "HIP 65534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116844"},
        {"Hipparcos Number", "HIP 65534"},
        {"Geneva Identification System", "GEN# +1.00116844"},
        {"Smithsonian Astrophysical Observation", "SAO 100563"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53051902),
        dec: Angle.Degrees(+14.34673199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83343"},
        {"Hipparcos Number", "HIP 47266"},
        {"Geneva Identification System", "GEN# +1.00083343"},
        {"Smithsonian Astrophysical Observation", "SAO 98683"},
        {"Wilson Evans Batten Catalogue", "WEB 8886"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.50547905),
        dec: Angle.Degrees(+14.34745460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201197"},
        {"Hipparcos Number", "HIP 104288"},
        {"Geneva Identification System", "GEN# +1.00201197"},
        {"Smithsonian Astrophysical Observation", "SAO 106855"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.90785950),
        dec: Angle.Degrees(+14.34862518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254850"},
        {"Hipparcos Number", "HIP 29959"},
        {"Smithsonian Astrophysical Observation", "SAO 95507"},
        {"Wilson Evans Batten Catalogue", "WEB 5940"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.60105885),
        dec: Angle.Degrees(+14.34873356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67348"},
        {"Hipparcos Number", "HIP 39809"},
        {"Smithsonian Astrophysical Observation", "SAO 97580"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.01563659),
        dec: Angle.Degrees(+14.35057711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132680"},
        {"Hipparcos Number", "HIP 73399"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.00341144),
        dec: Angle.Degrees(+14.35065243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11168"},
        {"Hipparcos Number", "HIP 8539"},
        {"Smithsonian Astrophysical Observation", "SAO 92654"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.52274379),
        dec: Angle.Degrees(+14.35119127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249923"},
        {"Hipparcos Number", "HIP 28314"},
        {"Smithsonian Astrophysical Observation", "SAO 95076"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.74057433),
        dec: Angle.Degrees(+14.35197431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216611"},
        {"Hipparcos Number", "HIP 113089"},
        {"Smithsonian Astrophysical Observation", "SAO 108239"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.53683866),
        dec: Angle.Degrees(+14.35275648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14855 AB"},
        {"Henry Draper", "HD 203066"},
        {"Hipparcos Number", "HIP 105288"},
        {"Geneva Identification System", "GEN# +1.00203066J"},
        {"Smithsonian Astrophysical Observation", "SAO 107028"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.89595040),
        dec: Angle.Degrees(+14.35361258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110901"},
        {"Smithsonian Astrophysical Observation", "SAO 107936"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.03392146),
        dec: Angle.Degrees(+14.35403885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33253"},
        {"Hipparcos Number", "HIP 23996"},
        {"Smithsonian Astrophysical Observation", "SAO 94357"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.37427499),
        dec: Angle.Degrees(+14.35597235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286115"},
        {"Hipparcos Number", "HIP 22556"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.81071835),
        dec: Angle.Degrees(+14.35644278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59150"},
        {"Hipparcos Number", "HIP 36376"},
        {"Smithsonian Astrophysical Observation", "SAO 96938"},
        {"Wilson Evans Batten Catalogue", "WEB 7238"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.30593079),
        dec: Angle.Degrees(+14.35835090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23701"},
        {"Hipparcos Number", "HIP 17726"},
        {"Smithsonian Astrophysical Observation", "SAO 93605"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.93498652),
        dec: Angle.Degrees(+14.36015151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108572"},
        {"Smithsonian Astrophysical Observation", "SAO 107569"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.89992185),
        dec: Angle.Degrees(+14.36037175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3961 AB"},
        {"Henry Draper", "HD 35110"},
        {"Hipparcos Number", "HIP 25151"},
        {"Geneva Identification System", "GEN# +1.00035110J"},
        {"Smithsonian Astrophysical Observation", "SAO 94505"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.73694278),
        dec: Angle.Degrees(+14.36114701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115855"},
        {"Smithsonian Astrophysical Observation", "SAO 108626"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.09061950),
        dec: Angle.Degrees(+14.36297329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3550"},
        {"Geneva Identification System", "GEN# +0.01300099"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.33674982),
        dec: Angle.Degrees(+14.36305586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 265.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56714"},
        {"Hipparcos Number", "HIP 35411"},
        {"Geneva Identification System", "GEN# +1.00056714"},
        {"Smithsonian Astrophysical Observation", "SAO 96755"},
        {"Wilson Evans Batten Catalogue", "WEB 7065"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.66806777),
        dec: Angle.Degrees(+14.36342978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8659 B"},
        {"Hipparcos Number", "HIP 62249"},
        {"Geneva Identification System", "GEN# +0.01502503"},
        {"Smithsonian Astrophysical Observation", "SAO 100235"},
        {"Wilson Evans Batten Catalogue", "WEB 11059"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.36016012),
        dec: Angle.Degrees(+14.36367459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176200"},
        {"Hipparcos Number", "HIP 93158"},
        {"Geneva Identification System", "GEN# +1.00176200A"},
        {"Wilson Evans Batten Catalogue", "WEB 16138"},
    },
    visualMagnitude: 7.99,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.63511829),
        dec: Angle.Degrees(+14.36377862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56242",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8196 A"},
        {"Henry Draper", "HD 100180"},
        {"Hipparcos Number", "HIP 56242"},
        {"Geneva Identification System", "GEN# +1.00100180A"},
        {"Smithsonian Astrophysical Observation", "SAO 99648"},
        {"Wilson Evans Batten Catalogue", "WEB 10105"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.93809402),
        dec: Angle.Degrees(+14.36496370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -327.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41028"},
        {"Hipparcos Number", "HIP 28663"},
        {"Geneva Identification System", "GEN# +1.00041028"},
        {"Smithsonian Astrophysical Observation", "SAO 95162"},
        {"Wilson Evans Batten Catalogue", "WEB 5604"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.78599643),
        dec: Angle.Degrees(+14.36526683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119550"},
        {"Hipparcos Number", "HIP 66974"},
        {"Cincinnati Publication", "Ci 18 1779"},
        {"Geneva Identification System", "GEN# +1.00119550"},
        {"Smithsonian Astrophysical Observation", "SAO 100676"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.89953848),
        dec: Angle.Degrees(+14.36562620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -314.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205040"},
        {"Hipparcos Number", "HIP 106334"},
        {"Geneva Identification System", "GEN# +1.00205040"},
        {"Smithsonian Astrophysical Observation", "SAO 107210"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.04408715),
        dec: Angle.Degrees(+14.36705597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56861"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.87167772),
        dec: Angle.Degrees(+14.36978341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63507"},
        {"Smithsonian Astrophysical Observation", "SAO 100367"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.19222406),
        dec: Angle.Degrees(+14.36994720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212075"},
        {"Hipparcos Number", "HIP 110383"},
        {"Smithsonian Astrophysical Observation", "SAO 107853"},
        {"Wilson Evans Batten Catalogue", "WEB 19795"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.36987704),
        dec: Angle.Degrees(+14.37020645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100192",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13688 A"},
        {"Henry Draper", "HD 193350"},
        {"Henry Draper 2", "HD 193349"},
        {"Hipparcos Number", "HIP 100192"},
        {"Geneva Identification System", "GEN# +1.00193349"},
        {"Smithsonian Astrophysical Observation", "SAO 105957"},
        {"Wilson Evans Batten Catalogue", "WEB 18051"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.83816596),
        dec: Angle.Degrees(+14.37070327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8905 AB"},
        {"Henry Draper", "HD 116959"},
        {"Hipparcos Number", "HIP 65589"},
        {"Geneva Identification System", "GEN# +1.00116959"},
        {"Smithsonian Astrophysical Observation", "SAO 100568"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.72215410),
        dec: Angle.Degrees(+14.37308872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200598"},
        {"Hipparcos Number", "HIP 103979"},
        {"Smithsonian Astrophysical Observation", "SAO 106812"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.01477370),
        dec: Angle.Degrees(+14.37343058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62248",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8659 A"},
        {"Henry Draper", "HD 110932"},
        {"Hipparcos Number", "HIP 62248"},
        {"Geneva Identification System", "GEN# +1.00110932A"},
        {"Smithsonian Astrophysical Observation", "SAO 100236"},
        {"Wilson Evans Batten Catalogue", "WEB 11057"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.35915460),
        dec: Angle.Degrees(+14.37358874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113039"},
        {"Hipparcos Number", "HIP 63509"},
        {"Smithsonian Astrophysical Observation", "SAO 100368"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.19358546),
        dec: Angle.Degrees(+14.37744653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225151"},
        {"Hipparcos Number", "HIP 308"},
        {"Geneva Identification System", "GEN# +1.00225151"},
        {"Smithsonian Astrophysical Observation", "SAO 91682"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.98353978),
        dec: Angle.Degrees(+14.37891704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73786"},
        {"Hipparcos Number", "HIP 42566"},
        {"Smithsonian Astrophysical Observation", "SAO 98029"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.15209380),
        dec: Angle.Degrees(+14.37895004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47096",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7448 A"},
        {"Henry Draper", "HD 83023"},
        {"Hipparcos Number", "HIP 47096"},
        {"Geneva Identification System", "GEN# +1.00083023J"},
        {"Smithsonian Astrophysical Observation", "SAO 98662"},
        {"Wilson Evans Batten Catalogue", "WEB 8867"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.97045380),
        dec: Angle.Degrees(+14.37959340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172212"},
        {"Hipparcos Number", "HIP 91390"},
        {"Geneva Identification System", "GEN# +1.00172212"},
        {"Smithsonian Astrophysical Observation", "SAO 103940"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.58862738),
        dec: Angle.Degrees(+14.38102208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133858"},
        {"Hipparcos Number", "HIP 73907"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.56447344),
        dec: Angle.Degrees(+14.38245566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2829 A"},
        {"Henry Draper", "HD 24345"},
        {"Hipparcos Number", "HIP 18158"},
        {"Geneva Identification System", "GEN# +1.00024345"},
        {"Smithsonian Astrophysical Observation", "SAO 93648"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.23124448),
        dec: Angle.Degrees(+14.38261687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29931",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4901 AB"},
        {"Henry Draper", "HD 43683"},
        {"Hipparcos Number", "HIP 29931"},
        {"Celescope Catalog", "CEL 1164"},
        {"Fundamental Katalog 5th Edition", "FK5 2481"},
        {"Geneva Identification System", "GEN# +1.00043683J"},
        {"Smithsonian Astrophysical Observation", "SAO 95502"},
        {"Wilson Evans Batten Catalogue", "WEB 5933"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.52337933),
        dec: Angle.Degrees(+14.38284850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107254"},
        {"Hipparcos Number", "HIP 60124"},
        {"Geneva Identification System", "GEN# +1.00107254"},
        {"Smithsonian Astrophysical Observation", "SAO 100044"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.96220479),
        dec: Angle.Degrees(+14.38342825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31966"},
        {"Hipparcos Number", "HIP 23286"},
        {"Geneva Identification System", "GEN# +1.00031966"},
        {"Smithsonian Astrophysical Observation", "SAO 94253"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.14071109),
        dec: Angle.Degrees(+14.38368335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159119"},
        {"Hipparcos Number", "HIP 85838"},
        {"Geneva Identification System", "GEN# +1.00159119"},
        {"Smithsonian Astrophysical Observation", "SAO 102899"},
        {"Wilson Evans Batten Catalogue", "WEB 14488"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.10014890),
        dec: Angle.Degrees(+14.38391792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193315"},
        {"Hipparcos Number", "HIP 100174"},
        {"Geneva Identification System", "GEN# +1.00193315"},
        {"Smithsonian Astrophysical Observation", "SAO 105955"},
        {"Wilson Evans Batten Catalogue", "WEB 18047"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.78823096),
        dec: Angle.Degrees(+14.38417380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175592"},
        {"Hipparcos Number", "HIP 92879"},
        {"Geneva Identification System", "GEN# +1.00175592"},
        {"Smithsonian Astrophysical Observation", "SAO 104263"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.87651415),
        dec: Angle.Degrees(+14.38501902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9655"},
        {"Hipparcos Number", "HIP 7369"},
        {"Geneva Identification System", "GEN# +1.00009655"},
        {"Smithsonian Astrophysical Observation", "SAO 92523"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.72873942),
        dec: Angle.Degrees(+14.38526082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58116",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8348 AB"},
        {"Hipparcos Number", "HIP 58116"},
        {"Smithsonian Astrophysical Observation", "SAO 99863"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.78904563),
        dec: Angle.Degrees(+14.38710111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243335"},
        {"Hipparcos Number", "HIP 25275"},
        {"Smithsonian Astrophysical Observation", "SAO 94525"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.08438169),
        dec: Angle.Degrees(+14.38795217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11963"},
        {"Hipparcos Number", "HIP 9137"},
        {"Geneva Identification System", "GEN# +1.00011963"},
        {"Smithsonian Astrophysical Observation", "SAO 92724"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.44190709),
        dec: Angle.Degrees(+14.38878738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115926"},
        {"Smithsonian Astrophysical Observation", "SAO 108639"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.30923180),
        dec: Angle.Degrees(+14.38881704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41304"},
        {"Hipparcos Number", "HIP 28813"},
        {"Geneva Identification System", "GEN# +1.00041304"},
        {"Smithsonian Astrophysical Observation", "SAO 95203"},
        {"Wilson Evans Batten Catalogue", "WEB 5635"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.24243225),
        dec: Angle.Degrees(+14.38889230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84345",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rasalgethi"},
        {"Aitken", "ADS 10418 AB"},
        {"Henry Draper", "HD 156014J"},
        {"Hipparcos Number", "HIP 84345"},
        {"Geneva Identification System", "GEN# +1.00156014J"},
    },
    visualMagnitude: 2.78,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.66192687),
        dec: Angle.Degrees(+14.39025314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82198"},
        {"Smithsonian Astrophysical Observation", "SAO 102387"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.89299701),
        dec: Angle.Degrees(+14.39044008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184944"},
        {"Hipparcos Number", "HIP 96428"},
        {"Geneva Identification System", "GEN# +1.00184944"},
        {"Smithsonian Astrophysical Observation", "SAO 105036"},
        {"Wilson Evans Batten Catalogue", "WEB 16919"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.06532485),
        dec: Angle.Degrees(+14.39117275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154879"},
        {"Hipparcos Number", "HIP 83792"},
        {"Smithsonian Astrophysical Observation", "SAO 102605"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87480087),
        dec: Angle.Degrees(+14.39223910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117817"},
        {"Hipparcos Number", "HIP 66066"},
        {"Geneva Identification System", "GEN# +1.00117817"},
        {"Smithsonian Astrophysical Observation", "SAO 100611"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.15138975),
        dec: Angle.Degrees(+14.39416775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286297"},
        {"Hipparcos Number", "HIP 23099"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.55203488),
        dec: Angle.Degrees(+14.39628693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129726"},
        {"Hipparcos Number", "HIP 72022"},
        {"Smithsonian Astrophysical Observation", "SAO 101171"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.96894148),
        dec: Angle.Degrees(+14.39817617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285625"},
        {"Hipparcos Number", "HIP 19834"},
        {"Geneva Identification System", "GEN# +5.20253245"},
        {"Geneva Identification System 2", "GEN# +5.20251072"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.79308298),
        dec: Angle.Degrees(+14.39849914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97244"},
        {"Hipparcos Number", "HIP 54688"},
        {"Geneva Identification System", "GEN# +1.00097244"},
        {"Renson", "Renson 28046"},
        {"Smithsonian Astrophysical Observation", "SAO 99492"},
        {"Wilson Evans Batten Catalogue", "WEB 9871"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.93246821),
        dec: Angle.Degrees(+14.40018507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25849"},
        {"Hipparcos Number", "HIP 19157"},
        {"Geneva Identification System", "GEN# +1.00025849"},
        {"Smithsonian Astrophysical Observation", "SAO 93761"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.59524601),
        dec: Angle.Degrees(+14.40206659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89413"},
        {"Smithsonian Astrophysical Observation", "SAO 103515"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.69719557),
        dec: Angle.Degrees(+14.40317743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95049"},
        {"Hipparcos Number", "HIP 53649"},
        {"Smithsonian Astrophysical Observation", "SAO 99382"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.64232796),
        dec: Angle.Degrees(+14.40371395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166142"},
        {"Hipparcos Number", "HIP 88891"},
        {"Smithsonian Astrophysical Observation", "SAO 103420"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.19196801),
        dec: Angle.Degrees(+14.40623980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10081"},
        {"Smithsonian Astrophysical Observation", "SAO 92811"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40978265),
        dec: Angle.Degrees(+14.40641045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46864"},
        {"Smithsonian Astrophysical Observation", "SAO 98634"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.24068940),
        dec: Angle.Degrees(+14.40758845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75975"},
        {"Hipparcos Number", "HIP 43663"},
        {"Smithsonian Astrophysical Observation", "SAO 98201"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.43239592),
        dec: Angle.Degrees(+14.40916809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27561"},
        {"Hipparcos Number", "HIP 20357"},
        {"Celescope Catalog", "CEL 390"},
        {"Geneva Identification System", "GEN# +5.20250037"},
        {"Smithsonian Astrophysical Observation", "SAO 93885"},
        {"Wilson Evans Batten Catalogue", "WEB 3888"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.39471702),
        dec: Angle.Degrees(+14.40983562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10749 A"},
        {"Henry Draper", "HD 161321"},
        {"Hipparcos Number", "HIP 86809"},
        {"Geneva Identification System", "GEN# +1.00161321A"},
        {"Renson", "Renson 45460"},
        {"Smithsonian Astrophysical Observation", "SAO 103069"},
        {"Wilson Evans Batten Catalogue", "WEB 14641"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.07186946),
        dec: Angle.Degrees(+14.41003119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192246"},
        {"Hipparcos Number", "HIP 99659"},
        {"Geneva Identification System", "GEN# +1.00192246"},
        {"Smithsonian Astrophysical Observation", "SAO 105850"},
        {"Wilson Evans Batten Catalogue", "WEB 17863"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.35749909),
        dec: Angle.Degrees(+14.41036503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40525"},
        {"Smithsonian Astrophysical Observation", "SAO 97692"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.12475147),
        dec: Angle.Degrees(+14.41182692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27797"},
        {"Hipparcos Number", "HIP 20530"},
        {"Geneva Identification System", "GEN# +1.00027797"},
        {"Smithsonian Astrophysical Observation", "SAO 93905"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.98540494),
        dec: Angle.Degrees(+14.41294766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48010"},
        {"Hipparcos Number", "HIP 32049"},
        {"Geneva Identification System", "GEN# +1.00048010"},
        {"Smithsonian Astrophysical Observation", "SAO 96004"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.44776271),
        dec: Angle.Degrees(+14.41348068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142980"},
        {"Hipparcos Number", "HIP 78132"},
        {"Geneva Identification System", "GEN# +1.00142980"},
        {"Smithsonian Astrophysical Observation", "SAO 101834"},
        {"Wilson Evans Batten Catalogue", "WEB 13214"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.31101948),
        dec: Angle.Degrees(+14.41426805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123978"},
        {"Hipparcos Number", "HIP 69234"},
        {"Geneva Identification System", "GEN# +1.00123978"},
        {"Smithsonian Astrophysical Observation", "SAO 100891"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61894830),
        dec: Angle.Degrees(+14.41434376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123846"},
        {"Hipparcos Number", "HIP 69182"},
        {"Geneva Identification System", "GEN# +1.00123846"},
        {"Smithsonian Astrophysical Observation", "SAO 100883"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.42086545),
        dec: Angle.Degrees(+14.41539394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229393"},
        {"Hipparcos Number", "HIP 92035"},
        {"Smithsonian Astrophysical Observation", "SAO 104068"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.39340676),
        dec: Angle.Degrees(+14.41709958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 764"},
        {"Smithsonian Astrophysical Observation", "SAO 91741"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.34949364),
        dec: Angle.Degrees(+14.41766587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285830"},
        {"Hipparcos Number", "HIP 20827"},
        {"Geneva Identification System", "GEN# +5.20253274"},
        {"Geneva Identification System 2", "GEN# +5.20250179"},
        {"Wilson Evans Batten Catalogue", "WEB 3995"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.94572822),
        dec: Angle.Degrees(+14.41779710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68473"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.28349221),
        dec: Angle.Degrees(+14.41792577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216930"},
        {"Hipparcos Number", "HIP 113321"},
        {"Smithsonian Astrophysical Observation", "SAO 108277"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.25097989),
        dec: Angle.Degrees(+14.41892569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231195"},
        {"Hipparcos Number", "HIP 95082"},
        {"Geneva Identification System", "GEN# +1.00231195"},
        {"Smithsonian Astrophysical Observation", "SAO 104744"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.17019838),
        dec: Angle.Degrees(+14.41910422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62984"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.57979092),
        dec: Angle.Degrees(+14.42164353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83479"},
        {"Hipparcos Number", "HIP 47368"},
        {"Geneva Identification System", "GEN# +1.00083479"},
        {"Smithsonian Astrophysical Observation", "SAO 98691"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.76624528),
        dec: Angle.Degrees(+14.42204863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9931 AB"},
        {"Henry Draper", "HD 144935"},
        {"Hipparcos Number", "HIP 79034"},
        {"Smithsonian Astrophysical Observation", "SAO 101944"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.97979059),
        dec: Angle.Degrees(+14.42285945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105845"},
        {"Hipparcos Number", "HIP 59386"},
        {"Geneva Identification System", "GEN# +1.00105845"},
        {"Smithsonian Astrophysical Observation", "SAO 99974"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75127128),
        dec: Angle.Degrees(+14.42438328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2359"},
        {"Hipparcos Number", "HIP 2179"},
        {"Geneva Identification System", "GEN# +1.00002359"},
        {"Smithsonian Astrophysical Observation", "SAO 91904"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.88106364),
        dec: Angle.Degrees(+14.42570726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114378",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16553 A"},
        {"Henry Draper", "HD 218687"},
        {"Hipparcos Number", "HIP 114378"},
        {"Geneva Identification System", "GEN# +1.00218687"},
        {"Smithsonian Astrophysical Observation", "SAO 108437"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.48822468),
        dec: Angle.Degrees(+14.42676087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229357"},
        {"Hipparcos Number", "HIP 91970"},
        {"Smithsonian Astrophysical Observation", "SAO 104053"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.19128461),
        dec: Angle.Degrees(+14.42693647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111523"},
        {"Smithsonian Astrophysical Observation", "SAO 108023"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.92001625),
        dec: Angle.Degrees(+14.42809516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11958 AB"},
        {"Henry Draper", "HD 176978"},
        {"Hipparcos Number", "HIP 93461"},
        {"Smithsonian Astrophysical Observation", "SAO 104385"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.52035189),
        dec: Angle.Degrees(+14.42985557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41749"},
        {"Smithsonian Astrophysical Observation", "SAO 97867"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.70330039),
        dec: Angle.Degrees(+14.43109459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42890"},
        {"Smithsonian Astrophysical Observation", "SAO 98085"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.11243715),
        dec: Angle.Degrees(+14.43115855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39493"},
        {"Hipparcos Number", "HIP 27856"},
        {"Celescope Catalog", "CEL 1017"},
        {"Geneva Identification System", "GEN# +1.00039493"},
        {"Smithsonian Astrophysical Observation", "SAO 94964"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.40252692),
        dec: Angle.Degrees(+14.43277385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91727"},
        {"Smithsonian Astrophysical Observation", "SAO 104001"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.56985234),
        dec: Angle.Degrees(+14.43301318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178568"},
        {"Hipparcos Number", "HIP 94027"},
        {"Smithsonian Astrophysical Observation", "SAO 104522"},
        {"Wilson Evans Batten Catalogue", "WEB 16365"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.14760048),
        dec: Angle.Degrees(+14.43526333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81286"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.03377282),
        dec: Angle.Degrees(+14.43955881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68206"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.44899191),
        dec: Angle.Degrees(+14.43985731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31153"},
    },
    visualMagnitude: 12.88,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)32, 16.0700),
        dec: Angle.DegreesMinutesSeconds((int)+14, (int)26, 28.400)
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
    primaryId: "HIP 59933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106888"},
        {"Hipparcos Number", "HIP 59933"},
        {"Geneva Identification System", "GEN# +1.00106888"},
        {"Smithsonian Astrophysical Observation", "SAO 100021"},
        {"Wilson Evans Batten Catalogue", "WEB 10649"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.40102761),
        dec: Angle.Degrees(+14.44292101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27614",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4441 AB"},
        {"Henry Draper", "HD 39098"},
        {"Hipparcos Number", "HIP 27614"},
        {"Celescope Catalog", "CEL 1002"},
        {"Geneva Identification System", "GEN# +1.00039098J"},
        {"Smithsonian Astrophysical Observation", "SAO 94914"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.70273463),
        dec: Angle.Degrees(+14.44339484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221787"},
        {"Hipparcos Number", "HIP 116382"},
        {"Smithsonian Astrophysical Observation", "SAO 108692"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.74630037),
        dec: Angle.Degrees(+14.44440938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55522"},
        {"Cincinnati Publication", "Ci 20 630"},
        {"Geneva Identification System", "GEN# +9.80056034"},
        {"Wilson Evans Batten Catalogue", "WEB 9983"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.57947341),
        dec: Angle.Degrees(+14.44548120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -511.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119965"},
        {"Hipparcos Number", "HIP 67198"},
        {"Geneva Identification System", "GEN# +1.00119965"},
        {"Smithsonian Astrophysical Observation", "SAO 100700"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.56079647),
        dec: Angle.Degrees(+14.44586739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131951"},
        {"Hipparcos Number", "HIP 73087"},
        {"Fundamental Katalog 5th Edition", "FK5 551"},
        {"Geneva Identification System", "GEN# +1.00131951"},
        {"Smithsonian Astrophysical Observation", "SAO 101293"},
        {"Wilson Evans Batten Catalogue", "WEB 12528"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.05515840),
        dec: Angle.Degrees(+14.44626586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32850"},
        {"Hipparcos Number", "HIP 23786"},
        {"Cincinnati Publication", "Ci 18 658"},
        {"Geneva Identification System", "GEN# +1.00032850"},
        {"Smithsonian Astrophysical Observation", "SAO 94322"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.67519780),
        dec: Angle.Degrees(+14.44681583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135264"},
        {"Hipparcos Number", "HIP 74532"},
        {"Geneva Identification System", "GEN# +1.00135264J"},
        {"Smithsonian Astrophysical Observation", "SAO 101451"},
        {"Wilson Evans Batten Catalogue", "WEB 12715"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.44661462),
        dec: Angle.Degrees(+14.44845605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29599",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4835 BC"},
        {"Henry Draper", "HD 42956"},
        {"Hipparcos Number", "HIP 29599"},
        {"Smithsonian Astrophysical Observation", "SAO 95415"},
        {"Wilson Evans Batten Catalogue", "WEB 5824"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.56123866),
        dec: Angle.Degrees(+14.44861632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41676"},
        {"Hipparcos Number", "HIP 29000"},
        {"Smithsonian Astrophysical Observation", "SAO 95248"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.78724886),
        dec: Angle.Degrees(+14.44924175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222035"},
        {"Hipparcos Number", "HIP 116543"},
        {"Geneva Identification System", "GEN# +1.00222035"},
        {"Smithsonian Astrophysical Observation", "SAO 108721"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.28002439),
        dec: Angle.Degrees(+14.45027427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63382"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.82307032),
        dec: Angle.Degrees(+14.45065132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218133"},
        {"Hipparcos Number", "HIP 114028"},
        {"Geneva Identification System", "GEN# +1.00218133"},
        {"Smithsonian Astrophysical Observation", "SAO 108390"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.37884864),
        dec: Angle.Degrees(+14.45145197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 387.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71863"},
        {"Smithsonian Astrophysical Observation", "SAO 101157"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.48919249),
        dec: Angle.Degrees(+14.45385776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194914"},
        {"Hipparcos Number", "HIP 100924"},
        {"Smithsonian Astrophysical Observation", "SAO 106131"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.93067222),
        dec: Angle.Degrees(+14.45597447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78660"},
        {"Hipparcos Number", "HIP 44997"},
        {"Geneva Identification System", "GEN# +1.00078660"},
        {"Smithsonian Astrophysical Observation", "SAO 98405"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.47487470),
        dec: Angle.Degrees(+14.45670260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57891"},
        {"Smithsonian Astrophysical Observation", "SAO 99837"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.10315664),
        dec: Angle.Degrees(+14.45848767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72422"},
        {"Smithsonian Astrophysical Observation", "SAO 101225"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.12299617),
        dec: Angle.Degrees(+14.46160967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94967"},
        {"Hipparcos Number", "HIP 53598"},
        {"Smithsonian Astrophysical Observation", "SAO 99374"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.48310719),
        dec: Angle.Degrees(+14.46196449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158673"},
        {"Hipparcos Number", "HIP 85636"},
        {"Geneva Identification System", "GEN# +1.00158673"},
        {"Smithsonian Astrophysical Observation", "SAO 102865"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.51756197),
        dec: Angle.Degrees(+14.46246299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61339"},
        {"Hipparcos Number", "HIP 37282"},
        {"Smithsonian Astrophysical Observation", "SAO 97118"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.83463281),
        dec: Angle.Degrees(+14.46330110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353692"},
        {"Hipparcos Number", "HIP 97318"},
        {"Smithsonian Astrophysical Observation", "SAO 105238"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.66047743),
        dec: Angle.Degrees(+14.46348587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157226"},
        {"Hipparcos Number", "HIP 84939"},
        {"Geneva Identification System", "GEN# +1.00157226"},
        {"Smithsonian Astrophysical Observation", "SAO 102768"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.39023311),
        dec: Angle.Degrees(+14.46350558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164235"},
        {"Hipparcos Number", "HIP 88111"},
        {"Smithsonian Astrophysical Observation", "SAO 103278"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.92736812),
        dec: Angle.Degrees(+14.46353507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106291"},
        {"Smithsonian Astrophysical Observation", "SAO 107205"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.92097178),
        dec: Angle.Degrees(+14.46556124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14108"},
        {"Hipparcos Number", "HIP 10669"},
        {"Smithsonian Astrophysical Observation", "SAO 92871"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.32137833),
        dec: Angle.Degrees(+14.46594919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14192"},
        {"Hipparcos Number", "HIP 10727"},
        {"Geneva Identification System", "GEN# +1.00014192"},
        {"Smithsonian Astrophysical Observation", "SAO 92878"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.51552417),
        dec: Angle.Degrees(+14.46683908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171407"},
        {"Hipparcos Number", "HIP 91034"},
        {"Geneva Identification System", "GEN# +1.00171407"},
        {"Smithsonian Astrophysical Observation", "SAO 103858"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.55790498),
        dec: Angle.Degrees(+14.46838923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18972"},
        {"Hipparcos Number", "HIP 14236"},
        {"Smithsonian Astrophysical Observation", "SAO 93256"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.88889475),
        dec: Angle.Degrees(+14.47079399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31306"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.47754085),
        dec: Angle.Degrees(+14.47139873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115736"},
        {"Hipparcos Number", "HIP 64973"},
        {"Geneva Identification System", "GEN# +1.00115736"},
        {"Smithsonian Astrophysical Observation", "SAO 100511"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.75072301),
        dec: Angle.Degrees(+14.47244283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7784"},
        {"Smithsonian Astrophysical Observation", "SAO 92563"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.05131088),
        dec: Angle.Degrees(+14.47255220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73227"},
        {"Hipparcos Number", "HIP 42331"},
        {"Smithsonian Astrophysical Observation", "SAO 97978"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.45739698),
        dec: Angle.Degrees(+14.47288537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53416"},
        {"Hipparcos Number", "HIP 34207"},
        {"Smithsonian Astrophysical Observation", "SAO 96473"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.39451376),
        dec: Angle.Degrees(+14.47313033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181048"},
        {"Hipparcos Number", "HIP 94871"},
        {"Geneva Identification System", "GEN# +1.00181048"},
        {"Smithsonian Astrophysical Observation", "SAO 104698"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.59479548),
        dec: Angle.Degrees(+14.47419572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42456"},
        {"Hipparcos Number", "HIP 29364"},
        {"Geneva Identification System", "GEN# +1.00042456"},
        {"Smithsonian Astrophysical Observation", "SAO 95349"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.83962566),
        dec: Angle.Degrees(+14.47507852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149881"},
        {"Hipparcos Number", "HIP 81362"},
        {"Geneva Identification System", "GEN# +1.00149881"},
        {"Smithsonian Astrophysical Observation", "SAO 102273"},
        {"Wilson Evans Batten Catalogue", "WEB 13751"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.24252832),
        dec: Angle.Degrees(+14.47524488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203888"},
        {"Hipparcos Number", "HIP 105710"},
        {"Smithsonian Astrophysical Observation", "SAO 107108"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.16514036),
        dec: Angle.Degrees(+14.47636184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8942"},
        {"Hipparcos Number", "HIP 6860"},
        {"Geneva Identification System", "GEN# +1.00008942"},
        {"Smithsonian Astrophysical Observation", "SAO 92452"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.07860184),
        dec: Angle.Degrees(+14.47648330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16735 AB"},
        {"Henry Draper", "HD 220541"},
        {"Hipparcos Number", "HIP 115552"},
        {"Smithsonian Astrophysical Observation", "SAO 108595"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.09945318),
        dec: Angle.Degrees(+14.47913143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115481"},
        {"Smithsonian Astrophysical Observation", "SAO 108587"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.89905890),
        dec: Angle.Degrees(+14.48005926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17068"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.87364346),
        dec: Angle.Degrees(+14.48251463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48410"},
        {"Smithsonian Astrophysical Observation", "SAO 98819"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.04605917),
        dec: Angle.Degrees(+14.48283144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88257"},
        {"Hipparcos Number", "HIP 49866"},
        {"Geneva Identification System", "GEN# +1.00088257"},
        {"Smithsonian Astrophysical Observation", "SAO 98986"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.73542650),
        dec: Angle.Degrees(+14.48294049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25456"},
        {"Hipparcos Number", "HIP 18902"},
        {"Fundamental Katalog 5th Edition", "FK5 4365"},
        {"Geneva Identification System", "GEN# +1.00025456"},
        {"Smithsonian Astrophysical Observation", "SAO 93740"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.77733866),
        dec: Angle.Degrees(+14.48346375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209725"},
        {"Hipparcos Number", "HIP 109030"},
        {"Geneva Identification System", "GEN# +1.00209725"},
        {"Smithsonian Astrophysical Observation", "SAO 107650"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.30821266),
        dec: Angle.Degrees(+14.48598673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184723"},
        {"Hipparcos Number", "HIP 96342"},
        {"Smithsonian Astrophysical Observation", "SAO 105007"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.80600507),
        dec: Angle.Degrees(+14.48750553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155581"},
        {"Hipparcos Number", "HIP 84133"},
        {"Smithsonian Astrophysical Observation", "SAO 102643"},
        {"Wilson Evans Batten Catalogue", "WEB 14207"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.99747484),
        dec: Angle.Degrees(+14.48774785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38545"},
        {"Hipparcos Number", "HIP 27316"},
        {"Geneva Identification System", "GEN# +1.00038545"},
        {"Smithsonian Astrophysical Observation", "SAO 94855"},
        {"Wilson Evans Batten Catalogue", "WEB 5370"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.80478979),
        dec: Angle.Degrees(+14.48842452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244923"},
        {"Hipparcos Number", "HIP 26101"},
        {"Smithsonian Astrophysical Observation", "SAO 94654"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.50382276),
        dec: Angle.Degrees(+14.49010224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34593"},
        {"Hipparcos Number", "HIP 24812"},
        {"Geneva Identification System", "GEN# +1.00034593"},
        {"Smithsonian Astrophysical Observation", "SAO 94458"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.78186134),
        dec: Angle.Degrees(+14.49288442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29602",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4835 A"},
        {"Henry Draper", "HD 42955"},
        {"Hipparcos Number", "HIP 29602"},
        {"Geneva Identification System", "GEN# +1.00042955"},
        {"Smithsonian Astrophysical Observation", "SAO 95417"},
        {"Wilson Evans Batten Catalogue", "WEB 5825"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.57645865),
        dec: Angle.Degrees(+14.49361971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46335",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7373 A"},
        {"Henry Draper", "HD 81581"},
        {"Hipparcos Number", "HIP 46335"},
        {"Geneva Identification System", "GEN# +1.00081581"},
        {"Renson", "Renson 23180"},
        {"Smithsonian Astrophysical Observation", "SAO 98571"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.70144544),
        dec: Angle.Degrees(+14.49405705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68611"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.68439622),
        dec: Angle.Degrees(+14.49764233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45787"},
        {"Hipparcos Number", "HIP 30975"},
        {"Geneva Identification System", "GEN# +1.00045787"},
        {"Smithsonian Astrophysical Observation", "SAO 95754"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.52126018),
        dec: Angle.Degrees(+14.50098216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12359",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2011 AB"},
        {"Henry Draper", "HD 16497"},
        {"Hipparcos Number", "HIP 12359"},
        {"Wilson Evans Batten Catalogue", "WEB 2533"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.77626642),
        dec: Angle.Degrees(+14.50515004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67789"},
        {"Hipparcos Number", "HIP 39999"},
        {"Geneva Identification System", "GEN# +1.00067789"},
        {"Smithsonian Astrophysical Observation", "SAO 97618"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.52753984),
        dec: Angle.Degrees(+14.50822306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46525"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.34344873),
        dec: Angle.Degrees(+14.50950017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130155"},
        {"Hipparcos Number", "HIP 72229"},
        {"Smithsonian Astrophysical Observation", "SAO 101201"},
        {"Wilson Evans Batten Catalogue", "WEB 12428"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.57612300),
        dec: Angle.Degrees(+14.51033068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163973"},
        {"Hipparcos Number", "HIP 87983"},
        {"Smithsonian Astrophysical Observation", "SAO 103258"},
        {"Wilson Evans Batten Catalogue", "WEB 14856"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.58553067),
        dec: Angle.Degrees(+14.51063181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154160"},
        {"Hipparcos Number", "HIP 83435"},
        {"Cincinnati Publication", "Ci 18 2272"},
        {"Geneva Identification System", "GEN# +1.00154160"},
        {"Smithsonian Astrophysical Observation", "SAO 102554"},
        {"Wilson Evans Batten Catalogue", "WEB 14103"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.79393627),
        dec: Angle.Degrees(+14.51177301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187615"},
        {"Hipparcos Number", "HIP 97616"},
        {"Smithsonian Astrophysical Observation", "SAO 105331"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.60408781),
        dec: Angle.Degrees(+14.51387142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34386"},
        {"Hipparcos Number", "HIP 24660"},
        {"Geneva Identification System", "GEN# +1.00034386"},
        {"Smithsonian Astrophysical Observation", "SAO 94444"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.37805466),
        dec: Angle.Degrees(+14.51422310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3087"},
        {"Hipparcos Number", "HIP 2696"},
        {"Geneva Identification System", "GEN# +1.00003087"},
        {"Smithsonian Astrophysical Observation", "SAO 91972"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.55195352),
        dec: Angle.Degrees(+14.51575022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264017"},
        {"Hipparcos Number", "HIP 32593"},
        {"Smithsonian Astrophysical Observation", "SAO 96120"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.99598611),
        dec: Angle.Degrees(+14.51595774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214995"},
        {"Hipparcos Number", "HIP 112067"},
        {"Geneva Identification System", "GEN# +1.00214995"},
        {"Smithsonian Astrophysical Observation", "SAO 108109"},
        {"Wilson Evans Batten Catalogue", "WEB 20005"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.48916113),
        dec: Angle.Degrees(+14.51644444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61987",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8636 AB"},
        {"Hipparcos Number", "HIP 61987"},
        {"Smithsonian Astrophysical Observation", "SAO 100214"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.55902649),
        dec: Angle.Degrees(+14.51955490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215329"},
        {"Hipparcos Number", "HIP 112253"},
        {"Smithsonian Astrophysical Observation", "SAO 108137"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.04153785),
        dec: Angle.Degrees(+14.52241774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74165"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.30715418),
        dec: Angle.Degrees(+14.52307960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -352.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189756"},
        {"Hipparcos Number", "HIP 98547"},
        {"Geneva Identification System", "GEN# +1.00189756"},
        {"Smithsonian Astrophysical Observation", "SAO 105555"},
        {"Wilson Evans Batten Catalogue", "WEB 17410"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.28389205),
        dec: Angle.Degrees(+14.52319184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75981"},
        {"Smithsonian Astrophysical Observation", "SAO 101591"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.75461171),
        dec: Angle.Degrees(+14.52525386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143108"},
        {"Hipparcos Number", "HIP 78195"},
        {"Geneva Identification System", "GEN# +1.00143108"},
        {"Smithsonian Astrophysical Observation", "SAO 101841"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.49191726),
        dec: Angle.Degrees(+14.52652877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197040"},
        {"Hipparcos Number", "HIP 102038"},
        {"Smithsonian Astrophysical Observation", "SAO 106372"},
        {"Wilson Evans Batten Catalogue", "WEB 18449"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.17693544),
        dec: Angle.Degrees(+14.52688515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105722"},
        {"Hipparcos Number", "HIP 59327"},
        {"Geneva Identification System", "GEN# +1.00105722"},
        {"Smithsonian Astrophysical Observation", "SAO 99971"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.55965678),
        dec: Angle.Degrees(+14.52747089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30247"},
        {"Hipparcos Number", "HIP 22208"},
        {"Geneva Identification System", "GEN# +1.00030247"},
        {"Smithsonian Astrophysical Observation", "SAO 94116"},
        {"Wilson Evans Batten Catalogue", "WEB 4272"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.64064017),
        dec: Angle.Degrees(+14.53163508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57068"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.48518564),
        dec: Angle.Degrees(+14.53229282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33053"},
        {"Hipparcos Number", "HIP 23898"},
        {"Geneva Identification System", "GEN# +1.00033053"},
        {"Smithsonian Astrophysical Observation", "SAO 94341"},
        {"Wilson Evans Batten Catalogue", "WEB 4663"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.02628275),
        dec: Angle.Degrees(+14.53286710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208238"},
        {"Hipparcos Number", "HIP 108139"},
        {"Smithsonian Astrophysical Observation", "SAO 107492"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.63955548),
        dec: Angle.Degrees(+14.53480290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13650"},
        {"Hipparcos Number", "HIP 10353"},
        {"Smithsonian Astrophysical Observation", "SAO 92844"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.36558012),
        dec: Angle.Degrees(+14.53536226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92620",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11773 A"},
        {"Henry Draper", "HD 174897"},
        {"Hipparcos Number", "HIP 92620"},
        {"Geneva Identification System", "GEN# +1.00174897A"},
        {"Smithsonian Astrophysical Observation", "SAO 104203"},
        {"Wilson Evans Batten Catalogue", "WEB 16022"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.07761978),
        dec: Angle.Degrees(+14.53555831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116523"},
        {"Smithsonian Astrophysical Observation", "SAO 108713"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.22415538),
        dec: Angle.Degrees(+14.53750061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202782"},
        {"Hipparcos Number", "HIP 105135"},
        {"Geneva Identification System", "GEN# +1.00202782"},
        {"Smithsonian Astrophysical Observation", "SAO 107001"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.47126876),
        dec: Angle.Degrees(+14.53857543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104097"},
        {"Geneva Identification System", "GEN# +0.01304614A"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.34741699),
        dec: Angle.Degrees(+14.53986794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 515.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107170"},
        {"Hipparcos Number", "HIP 60089"},
        {"Geneva Identification System", "GEN# +1.00107170"},
        {"Smithsonian Astrophysical Observation", "SAO 100039"},
        {"Wilson Evans Batten Catalogue", "WEB 10681"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.83436738),
        dec: Angle.Degrees(+14.54175644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68860"},
        {"Smithsonian Astrophysical Observation", "SAO 100847"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.50840385),
        dec: Angle.Degrees(+14.54211957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254584"},
        {"Hipparcos Number", "HIP 29880"},
        {"Smithsonian Astrophysical Observation", "SAO 95493"},
        {"Wilson Evans Batten Catalogue", "WEB 5915"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.38089374),
        dec: Angle.Degrees(+14.54265802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23161",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3579 A"},
        {"Henry Draper", "HD 31764"},
        {"Hipparcos Number", "HIP 23161"},
        {"Geneva Identification System", "GEN# +1.00031764A"},
        {"Smithsonian Astrophysical Observation", "SAO 94240"},
        {"Wilson Evans Batten Catalogue", "WEB 4492"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.74752899),
        dec: Angle.Degrees(+14.54324510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15002"},
        {"Hipparcos Number", "HIP 11298"},
        {"Smithsonian Astrophysical Observation", "SAO 92939"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36553108),
        dec: Angle.Degrees(+14.54339203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94720",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12248 A"},
        {"Henry Draper", "HD 180555"},
        {"Hipparcos Number", "HIP 94720"},
        {"Geneva Identification System", "GEN# +1.00180555J"},
        {"Geneva Identification System 2", "GEN# +1.00180555A"},
        {"Smithsonian Astrophysical Observation", "SAO 104668"},
        {"Wilson Evans Batten Catalogue", "WEB 16517"},
    },
    visualMagnitude: 5.65,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.11159428),
        dec: Angle.Degrees(+14.54461509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110793"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.70160969),
        dec: Angle.Degrees(+14.54646082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285527"},
        {"Hipparcos Number", "HIP 19362"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.21947124),
        dec: Angle.Degrees(+14.54676250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176674"},
        {"Hipparcos Number", "HIP 93349"},
        {"Geneva Identification System", "GEN# +1.00176674"},
        {"Smithsonian Astrophysical Observation", "SAO 104351"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.20589531),
        dec: Angle.Degrees(+14.54688330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145743"},
        {"Hipparcos Number", "HIP 79384"},
        {"Smithsonian Astrophysical Observation", "SAO 101999"},
        {"Wilson Evans Batten Catalogue", "WEB 13425"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.02679930),
        dec: Angle.Degrees(+14.54707932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64257"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.55494030),
        dec: Angle.Degrees(+14.54815471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85384"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.70393982),
        dec: Angle.Degrees(+14.54879099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111974",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16173 AB"},
        {"Henry Draper", "HD 214850"},
        {"Hipparcos Number", "HIP 111974"},
        {"Geneva Identification System", "GEN# +1.00214850J"},
        {"Smithsonian Astrophysical Observation", "SAO 108094"},
        {"Wilson Evans Batten Catalogue", "WEB 19992"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.21882625),
        dec: Angle.Degrees(+14.54886051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145772"},
        {"Hipparcos Number", "HIP 79388"},
        {"Geneva Identification System", "GEN# +1.00145772"},
        {"Smithsonian Astrophysical Observation", "SAO 102001"},
        {"Wilson Evans Batten Catalogue", "WEB 13426"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.03491179),
        dec: Angle.Degrees(+14.54895010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23159",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3579 B"},
        {"Henry Draper", "HD 31747"},
        {"Hipparcos Number", "HIP 23159"},
        {"Geneva Identification System", "GEN# +1.00031764B"},
        {"Geneva Identification System 2", "GEN# +1.00031747"},
        {"Smithsonian Astrophysical Observation", "SAO 94239"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.73834718),
        dec: Angle.Degrees(+14.54958455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137721"},
        {"Hipparcos Number", "HIP 75630"},
        {"Smithsonian Astrophysical Observation", "SAO 101560"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.78662107),
        dec: Angle.Degrees(+14.55092509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12025"},
        {"Smithsonian Astrophysical Observation", "SAO 93010"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.76995260),
        dec: Angle.Degrees(+14.55098150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194012"},
        {"Hipparcos Number", "HIP 100511"},
        {"Geneva Identification System", "GEN# +1.00194012"},
        {"Smithsonian Astrophysical Observation", "SAO 106042"},
        {"Wilson Evans Batten Catalogue", "WEB 18154"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.71800750),
        dec: Angle.Degrees(+14.55111452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155967"},
        {"Hipparcos Number", "HIP 84323"},
        {"Geneva Identification System", "GEN# +1.00155967"},
        {"Smithsonian Astrophysical Observation", "SAO 102675"},
        {"Wilson Evans Batten Catalogue", "WEB 14236"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.58355213),
        dec: Angle.Degrees(+14.55252897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210749"},
        {"Hipparcos Number", "HIP 109610"},
        {"Wilson Evans Batten Catalogue", "WEB 19696"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.06737791),
        dec: Angle.Degrees(+14.55339963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37441"},
        {"Hipparcos Number", "HIP 26590"},
        {"Smithsonian Astrophysical Observation", "SAO 94726"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.78140852),
        dec: Angle.Degrees(+14.55676309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76967"},
        {"Smithsonian Astrophysical Observation", "SAO 101697"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.74167213),
        dec: Angle.Degrees(+14.55700758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86986"},
        {"Hipparcos Number", "HIP 49198"},
        {"Cincinnati Publication", "Ci 18 1195"},
        {"Geneva Identification System", "GEN# +1.00086986"},
        {"Smithsonian Astrophysical Observation", "SAO 98914"},
        {"Wilson Evans Batten Catalogue", "WEB 9111"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.62283023),
        dec: Angle.Degrees(+14.55750462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108153"},
        {"Smithsonian Astrophysical Observation", "SAO 107496"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.68078562),
        dec: Angle.Degrees(+14.55779918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136404"},
        {"Hipparcos Number", "HIP 75046"},
        {"Geneva Identification System", "GEN# +1.00136404"},
        {"Smithsonian Astrophysical Observation", "SAO 101491"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.02562287),
        dec: Angle.Degrees(+14.56104619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191655"},
        {"Hipparcos Number", "HIP 99398"},
        {"Geneva Identification System", "GEN# +1.00191655"},
        {"Smithsonian Astrophysical Observation", "SAO 105782"},
        {"Wilson Evans Batten Catalogue", "WEB 17743"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.62971571),
        dec: Angle.Degrees(+14.56106152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152795"},
        {"Hipparcos Number", "HIP 82762"},
        {"Smithsonian Astrophysical Observation", "SAO 102470"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.72162515),
        dec: Angle.Degrees(+14.56208048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189091"},
        {"Hipparcos Number", "HIP 98232"},
        {"Smithsonian Astrophysical Observation", "SAO 105468"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.43764791),
        dec: Angle.Degrees(+14.56280124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122021"},
        {"Hipparcos Number", "HIP 68294"},
        {"Smithsonian Astrophysical Observation", "SAO 100804"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.71147862),
        dec: Angle.Degrees(+14.56280835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 999"},
        {"Cincinnati Publication", "Ci 18 17"},
        {"Geneva Identification System", "GEN# +0.01300013"},
        {"Smithsonian Astrophysical Observation", "SAO 91772"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.12549160),
        dec: Angle.Degrees(+14.56369614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 321.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80205"},
        {"Smithsonian Astrophysical Observation", "SAO 102112"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.60722065),
        dec: Angle.Degrees(+14.56378201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231554"},
        {"Hipparcos Number", "HIP 95794"},
        {"Smithsonian Astrophysical Observation", "SAO 104889"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.25884561),
        dec: Angle.Degrees(+14.56456675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54324"},
        {"Hipparcos Number", "HIP 34505"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.24006662),
        dec: Angle.Degrees(+14.56581522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119057"},
        {"Hipparcos Number", "HIP 66741"},
        {"Smithsonian Astrophysical Observation", "SAO 100660"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.19478404),
        dec: Angle.Degrees(+14.56587016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177082"},
        {"Hipparcos Number", "HIP 93509"},
        {"Geneva Identification System", "GEN# +1.00177082"},
        {"Smithsonian Astrophysical Observation", "SAO 104394"},
        {"Wilson Evans Batten Catalogue", "WEB 16234"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.65817180),
        dec: Angle.Degrees(+14.56701386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193556"},
        {"Hipparcos Number", "HIP 100274"},
        {"Fundamental Katalog 5th Edition", "FK5 3629"},
        {"Geneva Identification System", "GEN# +1.00193556"},
        {"Smithsonian Astrophysical Observation", "SAO 105988"},
        {"Wilson Evans Batten Catalogue", "WEB 18082"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.08552482),
        dec: Angle.Degrees(+14.56924214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80153"},
        {"Smithsonian Astrophysical Observation", "SAO 102099"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.41168741),
        dec: Angle.Degrees(+14.56959657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108301"},
        {"Hipparcos Number", "HIP 60705"},
        {"Geneva Identification System", "GEN# +1.00108301"},
        {"Smithsonian Astrophysical Observation", "SAO 100097"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.62470298),
        dec: Angle.Degrees(+14.57201864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57632",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Denebola"},
        {"Aitken", "ADS 8314 A"},
        {"Henry Draper", "HD 102647"},
        {"Hipparcos Number", "HIP 57632"},
        {"Cincinnati Publication", "Ci 20 663"},
        {"Fundamental Katalog 5th Edition", "FK5 444"},
        {"Geneva Identification System", "GEN# +1.00102647"},
        {"Smithsonian Astrophysical Observation", "SAO 99809"},
        {"Wilson Evans Batten Catalogue", "WEB 10349"},
    },
    visualMagnitude: 2.14,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.26615977),
        dec: Angle.Degrees(+14.57233687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -499.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61109"},
        {"Smithsonian Astrophysical Observation", "SAO 100138"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.86088204),
        dec: Angle.Degrees(+14.57432090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168430"},
        {"Hipparcos Number", "HIP 89763"},
        {"Geneva Identification System", "GEN# +1.00168430"},
        {"Smithsonian Astrophysical Observation", "SAO 103603"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.76680682),
        dec: Angle.Degrees(+14.57449715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38220"},
        {"Hipparcos Number", "HIP 27096"},
        {"Geneva Identification System", "GEN# +1.00038220"},
        {"Smithsonian Astrophysical Observation", "SAO 94821"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.18565020),
        dec: Angle.Degrees(+14.57601844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87259"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.46211749),
        dec: Angle.Degrees(+14.58052823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89651"},
        {"Smithsonian Astrophysical Observation", "SAO 103570"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.43863716),
        dec: Angle.Degrees(+14.58162326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179424"},
        {"Hipparcos Number", "HIP 94321"},
        {"Geneva Identification System", "GEN# +1.00179424"},
        {"Smithsonian Astrophysical Observation", "SAO 104584"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.97225705),
        dec: Angle.Degrees(+14.58224063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13290 AB"},
        {"Henry Draper", "HD 190090"},
        {"Hipparcos Number", "HIP 98695"},
        {"Smithsonian Astrophysical Observation", "SAO 105589"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.69179680),
        dec: Angle.Degrees(+14.58268612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197121"},
        {"Hipparcos Number", "HIP 102080"},
        {"Geneva Identification System", "GEN# +1.00197121"},
        {"Smithsonian Astrophysical Observation", "SAO 106384"},
        {"Wilson Evans Batten Catalogue", "WEB 18459"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.31755670),
        dec: Angle.Degrees(+14.58287886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12899"},
        {"Hipparcos Number", "HIP 9848"},
        {"Geneva Identification System", "GEN# +1.00012899"},
        {"Smithsonian Astrophysical Observation", "SAO 92797"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.67332800),
        dec: Angle.Degrees(+14.58379035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29636",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4840 A"},
        {"Henry Draper", "HD 43044"},
        {"Henry Draper 2", "HD 43044A"},
        {"Hipparcos Number", "HIP 29636"},
        {"Celescope Catalog", "CEL 1135"},
        {"Geneva Identification System", "GEN# +1.00043044"},
        {"Smithsonian Astrophysical Observation", "SAO 95431"},
        {"Wilson Evans Batten Catalogue", "WEB 5835"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.67778037),
        dec: Angle.Degrees(+14.58634820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68379"},
        {"Hipparcos Number", "HIP 40194"},
        {"Geneva Identification System", "GEN# +1.00068379"},
        {"Smithsonian Astrophysical Observation", "SAO 97649"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.15362993),
        dec: Angle.Degrees(+14.58817766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46969"},
        {"Smithsonian Astrophysical Observation", "SAO 98645"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.59535134),
        dec: Angle.Degrees(+14.59079063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49290"},
        {"Hipparcos Number", "HIP 32612"},
        {"Smithsonian Astrophysical Observation", "SAO 96128"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.06863527),
        dec: Angle.Degrees(+14.59244644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221866"},
        {"Hipparcos Number", "HIP 116434"},
        {"Renson", "Renson 60798"},
        {"Smithsonian Astrophysical Observation", "SAO 108698"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.90622740),
        dec: Angle.Degrees(+14.59365834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31282"},
        {"Hipparcos Number", "HIP 22853"},
        {"Geneva Identification System", "GEN# +1.00031282"},
        {"Smithsonian Astrophysical Observation", "SAO 94202"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.75112899),
        dec: Angle.Degrees(+14.59377630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101769",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rotanev"},
        {"Aitken", "ADS 14073 AB"},
        {"Henry Draper", "HD 196524"},
        {"Hipparcos Number", "HIP 101769"},
        {"Geneva Identification System", "GEN# +1.00196524"},
        {"Renson", "Renson 54790"},
        {"Smithsonian Astrophysical Observation", "SAO 106316"},
        {"Wilson Evans Batten Catalogue", "WEB 18382"},
    },
    visualMagnitude: 3.64,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.38695734),
        dec: Angle.Degrees(+14.59520289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183492"},
        {"Hipparcos Number", "HIP 95822"},
        {"Geneva Identification System", "GEN# +1.00183492"},
        {"Smithsonian Astrophysical Observation", "SAO 104896"},
        {"Wilson Evans Batten Catalogue", "WEB 16776"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.34218384),
        dec: Angle.Degrees(+14.59607671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71026"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.89786655),
        dec: Angle.Degrees(+14.59615975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44361",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7151 A"},
        {"Henry Draper", "HD 77277"},
        {"Hipparcos Number", "HIP 44361"},
        {"Smithsonian Astrophysical Observation", "SAO 98304"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.51019076),
        dec: Angle.Degrees(+14.59866425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261548"},
        {"Hipparcos Number", "HIP 31883"},
        {"Smithsonian Astrophysical Observation", "SAO 95967"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.98160354),
        dec: Angle.Degrees(+14.59954417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62600"},
        {"Hipparcos Number", "HIP 37836"},
        {"Fundamental Katalog 5th Edition", "FK5 4700"},
        {"Smithsonian Astrophysical Observation", "SAO 97215"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.35233694),
        dec: Angle.Degrees(+14.59969513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117873"},
        {"Smithsonian Astrophysical Observation", "SAO 108900"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.64234898),
        dec: Angle.Degrees(+14.59976995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55284"},
        {"Hipparcos Number", "HIP 34859"},
        {"Wilson Evans Batten Catalogue", "WEB 6969"},
    },
    visualMagnitude: 10.05,
    bvColour: 3.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20404629),
        dec: Angle.Degrees(+14.60104164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207902"},
        {"Hipparcos Number", "HIP 107932"},
        {"Smithsonian Astrophysical Observation", "SAO 107457"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.00771907),
        dec: Angle.Degrees(+14.60159514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12616"},
        {"Smithsonian Astrophysical Observation", "SAO 93060"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.54669090),
        dec: Angle.Degrees(+14.60201488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142657"},
        {"Hipparcos Number", "HIP 77961"},
        {"Smithsonian Astrophysical Observation", "SAO 101814"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.82401979),
        dec: Angle.Degrees(+14.60420087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84968"},
        {"Hipparcos Number", "HIP 48169"},
        {"Smithsonian Astrophysical Observation", "SAO 98784"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.27721795),
        dec: Angle.Degrees(+14.60573796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198332"},
        {"Hipparcos Number", "HIP 102758"},
        {"Smithsonian Astrophysical Observation", "SAO 106529"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31106669),
        dec: Angle.Degrees(+14.60579005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182808"},
        {"Hipparcos Number", "HIP 95522"},
        {"Smithsonian Astrophysical Observation", "SAO 104821"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.45121361),
        dec: Angle.Degrees(+14.60867972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110220"},
        {"Smithsonian Astrophysical Observation", "SAO 107831"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.89404185),
        dec: Angle.Degrees(+14.60989660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355533"},
        {"Hipparcos Number", "HIP 100344"},
        {"Smithsonian Astrophysical Observation", "SAO 106001"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.24795995),
        dec: Angle.Degrees(+14.61021044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16087 AB"},
        {"Henry Draper", "HD 214010"},
        {"Hipparcos Number", "HIP 111480"},
        {"Smithsonian Astrophysical Observation", "SAO 108019"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.80043252),
        dec: Angle.Degrees(+14.61053848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261138"},
        {"Hipparcos Number", "HIP 31770"},
        {"Smithsonian Astrophysical Observation", "SAO 95936"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66314914),
        dec: Angle.Degrees(+14.61102282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17499"},
        {"Hipparcos Number", "HIP 13122"},
        {"Geneva Identification System", "GEN# +1.00017499"},
        {"Smithsonian Astrophysical Observation", "SAO 93121"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.19487378),
        dec: Angle.Degrees(+14.61364051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87986",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10940 A"},
        {"Henry Draper", "HD 163972"},
        {"Hipparcos Number", "HIP 87986"},
        {"Smithsonian Astrophysical Observation", "SAO 103259"},
        {"Wilson Evans Batten Catalogue", "WEB 14857"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.59517444),
        dec: Angle.Degrees(+14.61413043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59582"},
        {"Hipparcos Number", "HIP 36551"},
        {"Geneva Identification System", "GEN# +1.00059582"},
        {"Wilson Evans Batten Catalogue", "WEB 7271"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.78194099),
        dec: Angle.Degrees(+14.61484883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78413"},
        {"Smithsonian Astrophysical Observation", "SAO 101869"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.11208084),
        dec: Angle.Degrees(+14.61550153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179786"},
        {"Hipparcos Number", "HIP 94450"},
        {"Geneva Identification System", "GEN# +1.00179786"},
        {"Smithsonian Astrophysical Observation", "SAO 104620"},
        {"Wilson Evans Batten Catalogue", "WEB 16461"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.34111369),
        dec: Angle.Degrees(+14.61813444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78411",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)00, 26.0800),
        dec: Angle.DegreesMinutesSeconds((int)+14, (int)37, 06.200)
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
    primaryId: "HIP 95694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231490"},
        {"Hipparcos Number", "HIP 95694"},
        {"Geneva Identification System", "GEN# +1.00231490"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.96325750),
        dec: Angle.Degrees(+14.61923245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23233"},
        {"Hipparcos Number", "HIP 17426"},
        {"Smithsonian Astrophysical Observation", "SAO 93570"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.00030553),
        dec: Angle.Degrees(+14.62049967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91315"},
        {"Hipparcos Number", "HIP 51627"},
        {"Smithsonian Astrophysical Observation", "SAO 99176"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.20434160),
        dec: Angle.Degrees(+14.62078518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30974"},
        {"Hipparcos Number", "HIP 22688"},
        {"Geneva Identification System", "GEN# +1.00030974"},
        {"Smithsonian Astrophysical Observation", "SAO 94181"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.18738028),
        dec: Angle.Degrees(+14.62321982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26756"},
        {"Hipparcos Number", "HIP 19781"},
        {"Geneva Identification System", "GEN# +5.20250017"},
        {"Smithsonian Astrophysical Observation", "SAO 93829"},
        {"Wilson Evans Batten Catalogue", "WEB 3771"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.60660991),
        dec: Angle.Degrees(+14.62508304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50580"},
        {"Hipparcos Number", "HIP 33191"},
        {"Smithsonian Astrophysical Observation", "SAO 96256"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.61303806),
        dec: Angle.Degrees(+14.62563594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12124"},
        {"Hipparcos Number", "HIP 9286"},
        {"Geneva Identification System", "GEN# +1.00012124"},
        {"Smithsonian Astrophysical Observation", "SAO 92737"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.83552140),
        dec: Angle.Degrees(+14.62577743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30047"},
        {"Hipparcos Number", "HIP 22063"},
        {"Geneva Identification System", "GEN# +1.00030047"},
        {"Smithsonian Astrophysical Observation", "SAO 94097"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.18639936),
        dec: Angle.Degrees(+14.62683721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67959"},
        {"Hipparcos Number", "HIP 40058"},
        {"Geneva Identification System", "GEN# +1.00067959"},
        {"Smithsonian Astrophysical Observation", "SAO 97628"},
        {"Wilson Evans Batten Catalogue", "WEB 7813"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.74540846),
        dec: Angle.Degrees(+14.62951511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15690 A"},
        {"Henry Draper", "HD 210461"},
        {"Hipparcos Number", "HIP 109445"},
        {"Geneva Identification System", "GEN# +1.00210461"},
        {"Smithsonian Astrophysical Observation", "SAO 107707"},
        {"Wilson Evans Batten Catalogue", "WEB 19665"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.59177013),
        dec: Angle.Degrees(+14.62991869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107494"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.58104571),
        dec: Angle.Degrees(+14.63220056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224896"},
        {"Hipparcos Number", "HIP 126"},
        {"Geneva Identification System", "GEN# +1.00224896"},
        {"Smithsonian Astrophysical Observation", "SAO 108967"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.40873313),
        dec: Angle.Degrees(+14.63230674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181801"},
        {"Hipparcos Number", "HIP 95132"},
        {"Geneva Identification System", "GEN# +1.00181801"},
        {"Smithsonian Astrophysical Observation", "SAO 104754"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.32331838),
        dec: Angle.Degrees(+14.63371510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181493"},
        {"Hipparcos Number", "HIP 95025"},
        {"Geneva Identification System", "GEN# +1.00181493"},
        {"Smithsonian Astrophysical Observation", "SAO 104731"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.02330187),
        dec: Angle.Degrees(+14.63674476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17505"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.23360404),
        dec: Angle.Degrees(+14.64003201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7462"},
        {"Hipparcos Number", "HIP 5836"},
        {"Smithsonian Astrophysical Observation", "SAO 92331"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.71291520),
        dec: Angle.Degrees(+14.64197027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130085"},
        {"Hipparcos Number", "HIP 72180"},
        {"Geneva Identification System", "GEN# +1.00130085"},
        {"Smithsonian Astrophysical Observation", "SAO 101196"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.45355079),
        dec: Angle.Degrees(+14.64228339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109416"},
        {"Hipparcos Number", "HIP 61356"},
        {"Smithsonian Astrophysical Observation", "SAO 100150"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.59006426),
        dec: Angle.Degrees(+14.64373079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35972"},
        {"Smithsonian Astrophysical Observation", "SAO 96870"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20833204),
        dec: Angle.Degrees(+14.64517947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39178"},
        {"Smithsonian Astrophysical Observation", "SAO 97473"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.19754201),
        dec: Angle.Degrees(+14.64689579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191879"},
        {"Hipparcos Number", "HIP 99505"},
        {"Smithsonian Astrophysical Observation", "SAO 105806"},
        {"Wilson Evans Batten Catalogue", "WEB 17793"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.90901277),
        dec: Angle.Degrees(+14.64890624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121980"},
        {"Hipparcos Number", "HIP 68279"},
        {"Geneva Identification System", "GEN# +1.00121980"},
        {"Smithsonian Astrophysical Observation", "SAO 100801"},
        {"Wilson Evans Batten Catalogue", "WEB 11981"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.66643809),
        dec: Angle.Degrees(+14.64941736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105087"},
        {"Hipparcos Number", "HIP 59014"},
        {"Geneva Identification System", "GEN# +1.00105087"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.50333938),
        dec: Angle.Degrees(+14.64980025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108775"},
        {"Hipparcos Number", "HIP 60960"},
        {"Geneva Identification System", "GEN# +1.00108775"},
        {"Smithsonian Astrophysical Observation", "SAO 100127"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.44522606),
        dec: Angle.Degrees(+14.65016658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44033"},
        {"Hipparcos Number", "HIP 30099"},
        {"Geneva Identification System", "GEN# +1.00044033"},
        {"Smithsonian Astrophysical Observation", "SAO 95543"},
        {"Wilson Evans Batten Catalogue", "WEB 5988"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.01761580),
        dec: Angle.Degrees(+14.65116899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60608"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.33872167),
        dec: Angle.Degrees(+14.65135351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56807"},
        {"Smithsonian Astrophysical Observation", "SAO 99709"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.68572296),
        dec: Angle.Degrees(+14.65198835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169005"},
        {"Hipparcos Number", "HIP 90015"},
        {"Geneva Identification System", "GEN# +1.00169005"},
        {"Smithsonian Astrophysical Observation", "SAO 103643"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.50962108),
        dec: Angle.Degrees(+14.65774893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174263"},
        {"Hipparcos Number", "HIP 92339"},
        {"Smithsonian Astrophysical Observation", "SAO 104135"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.29604395),
        dec: Angle.Degrees(+14.65813471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206417"},
        {"Hipparcos Number", "HIP 107099"},
        {"Smithsonian Astrophysical Observation", "SAO 107329"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.40708353),
        dec: Angle.Degrees(+14.65857582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7486"},
        {"Hipparcos Number", "HIP 5856"},
        {"Smithsonian Astrophysical Observation", "SAO 92333"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.78049186),
        dec: Angle.Degrees(+14.66043081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9766"},
        {"Hipparcos Number", "HIP 7436"},
        {"Geneva Identification System", "GEN# +1.00009766"},
        {"Smithsonian Astrophysical Observation", "SAO 92530"},
        {"Wilson Evans Batten Catalogue", "WEB 1591"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.94350195),
        dec: Angle.Degrees(+14.66144102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154101"},
        {"Hipparcos Number", "HIP 83411"},
        {"Smithsonian Astrophysical Observation", "SAO 102552"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.72613054),
        dec: Angle.Degrees(+14.66305110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214742"},
        {"Hipparcos Number", "HIP 111902"},
        {"Geneva Identification System", "GEN# +1.00214742"},
        {"Smithsonian Astrophysical Observation", "SAO 108080"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.01017034),
        dec: Angle.Degrees(+14.66435807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42632"},
        {"Smithsonian Astrophysical Observation", "SAO 98041"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.32513294),
        dec: Angle.Degrees(+14.66658931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89396"},
        {"Hipparcos Number", "HIP 50535"},
        {"Geneva Identification System", "GEN# +1.00089396"},
        {"Smithsonian Astrophysical Observation", "SAO 99058"},
        {"Wilson Evans Batten Catalogue", "WEB 9271"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.81987915),
        dec: Angle.Degrees(+14.66808731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219017"},
        {"Hipparcos Number", "HIP 114574"},
        {"Smithsonian Astrophysical Observation", "SAO 108457"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.15100680),
        dec: Angle.Degrees(+14.67005226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17973"},
        {"Hipparcos Number", "HIP 13484"},
        {"Smithsonian Astrophysical Observation", "SAO 93166"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.41034706),
        dec: Angle.Degrees(+14.67026317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27771"},
        {"Hipparcos Number", "HIP 20492"},
        {"Geneva Identification System", "GEN# +5.20250046"},
        {"Smithsonian Astrophysical Observation", "SAO 93902"},
        {"Wilson Evans Batten Catalogue", "WEB 3922"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.88444721),
        dec: Angle.Degrees(+14.67052187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177415"},
        {"Hipparcos Number", "HIP 93628"},
        {"Smithsonian Astrophysical Observation", "SAO 104429"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.00132233),
        dec: Angle.Degrees(+14.67126995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178379"},
        {"Hipparcos Number", "HIP 93956"},
        {"Smithsonian Astrophysical Observation", "SAO 104507"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.95843768),
        dec: Angle.Degrees(+14.67229895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72504"},
        {"Hipparcos Number", "HIP 42012"},
        {"Geneva Identification System", "GEN# +1.00072504"},
        {"Smithsonian Astrophysical Observation", "SAO 97912"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.44351845),
        dec: Angle.Degrees(+14.67361443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153129"},
        {"Hipparcos Number", "HIP 82955"},
        {"Smithsonian Astrophysical Observation", "SAO 102492"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.27830233),
        dec: Angle.Degrees(+14.67367749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201254"},
        {"Hipparcos Number", "HIP 104320"},
        {"Fundamental Katalog 5th Edition", "FK5 5859"},
        {"Geneva Identification System", "GEN# +1.00201254"},
        {"Smithsonian Astrophysical Observation", "SAO 106859"},
        {"Wilson Evans Batten Catalogue", "WEB 18997"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.98916386),
        dec: Angle.Degrees(+14.67368436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52481"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.94278031),
        dec: Angle.Degrees(+14.67375299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196180"},
        {"Hipparcos Number", "HIP 101589"},
        {"Geneva Identification System", "GEN# +1.00196180"},
        {"Smithsonian Astrophysical Observation", "SAO 106274"},
        {"Wilson Evans Batten Catalogue", "WEB 18356"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.82711738),
        dec: Angle.Degrees(+14.67418482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84506",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10433 AB"},
        {"Henry Draper", "HD 156342"},
        {"Hipparcos Number", "HIP 84506"},
        {"Geneva Identification System", "GEN# +1.00156342J"},
        {"Smithsonian Astrophysical Observation", "SAO 102704"},
        {"Wilson Evans Batten Catalogue", "WEB 14270"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13820464),
        dec: Angle.Degrees(+14.67421520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117181"},
        {"Smithsonian Astrophysical Observation", "SAO 108812"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.35958668),
        dec: Angle.Degrees(+14.67505420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72858"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.37741060),
        dec: Angle.Degrees(+14.67537148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77628"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.72653345),
        dec: Angle.Degrees(+14.67608969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79671"},
        {"Smithsonian Astrophysical Observation", "SAO 102041"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.90267703),
        dec: Angle.Degrees(+14.67622947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58809"},
        {"Hipparcos Number", "HIP 36231"},
        {"Smithsonian Astrophysical Observation", "SAO 96917"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.91664878),
        dec: Angle.Degrees(+14.67627870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55160"},
        {"Hipparcos Number", "HIP 34810"},
        {"Smithsonian Astrophysical Observation", "SAO 96622"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.08297493),
        dec: Angle.Degrees(+14.67737861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44415"},
        {"Hipparcos Number", "HIP 30286"},
        {"Geneva Identification System", "GEN# +1.00044415"},
        {"Smithsonian Astrophysical Observation", "SAO 95589"},
        {"Wilson Evans Batten Catalogue", "WEB 6022"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.55496931),
        dec: Angle.Degrees(+14.67812645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22031"},
        {"Hipparcos Number", "HIP 16593"},
        {"Smithsonian Astrophysical Observation", "SAO 93489"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.39966273),
        dec: Angle.Degrees(+14.67849593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77630"},
        {"Smithsonian Astrophysical Observation", "SAO 101772"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.73012709),
        dec: Angle.Degrees(+14.67856574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176627"},
        {"Hipparcos Number", "HIP 93332"},
        {"Geneva Identification System", "GEN# +1.00176627"},
        {"Smithsonian Astrophysical Observation", "SAO 104346"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.14422097),
        dec: Angle.Degrees(+14.68038654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156432"},
        {"Hipparcos Number", "HIP 84553"},
        {"Geneva Identification System", "GEN# +1.00156432"},
        {"Smithsonian Astrophysical Observation", "SAO 102710"},
        {"Wilson Evans Batten Catalogue", "WEB 14276"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.26942824),
        dec: Angle.Degrees(+14.68078221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199399"},
        {"Hipparcos Number", "HIP 103366"},
        {"Smithsonian Astrophysical Observation", "SAO 106680"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.12840141),
        dec: Angle.Degrees(+14.68330680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40186"},
        {"Hipparcos Number", "HIP 28225"},
        {"Geneva Identification System", "GEN# +1.00040186"},
        {"Smithsonian Astrophysical Observation", "SAO 95054"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.45403340),
        dec: Angle.Degrees(+14.68409967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247297"},
        {"Hipparcos Number", "HIP 27182"},
        {"Geneva Identification System", "GEN# +1.00247297"},
        {"Smithsonian Astrophysical Observation", "SAO 94838"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.41809804),
        dec: Angle.Degrees(+14.68938115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104780",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Solaris"},
        {"Hipparcos Number", "HIP 104780"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.39937143),
        dec: Angle.Degrees(+14.68938431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28607"},
        {"Hipparcos Number", "HIP 21090"},
        {"Celescope Catalog", "CEL 423"},
        {"Geneva Identification System", "GEN# +1.00028607"},
        {"Smithsonian Astrophysical Observation", "SAO 93984"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.79544940),
        dec: Angle.Degrees(+14.68979580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7076"},
        {"Hipparcos Number", "HIP 5557"},
        {"Geneva Identification System", "GEN# +1.00007076"},
        {"Smithsonian Astrophysical Observation", "SAO 92302"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.81770602),
        dec: Angle.Degrees(+14.69178328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121108"},
        {"Hipparcos Number", "HIP 67789"},
        {"Smithsonian Astrophysical Observation", "SAO 100750"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.30820385),
        dec: Angle.Degrees(+14.69214836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27350"},
        {"Hipparcos Number", "HIP 20182"},
        {"Smithsonian Astrophysical Observation", "SAO 93865"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.89169992),
        dec: Angle.Degrees(+14.69230891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137569"},
        {"Hipparcos Number", "HIP 75577"},
        {"Geneva Identification System", "GEN# +1.00137569"},
        {"Smithsonian Astrophysical Observation", "SAO 101555"},
        {"Wilson Evans Batten Catalogue", "WEB 12877"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.58671810),
        dec: Angle.Degrees(+14.69344996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38106"},
        {"Hipparcos Number", "HIP 27022"},
        {"Smithsonian Astrophysical Observation", "SAO 94810"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.97032846),
        dec: Angle.Degrees(+14.69386297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71938"},
        {"Smithsonian Astrophysical Observation", "SAO 101165"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.69744751),
        dec: Angle.Degrees(+14.69471679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219656"},
        {"Hipparcos Number", "HIP 114988"},
        {"Geneva Identification System", "GEN# +1.00219656"},
        {"Smithsonian Astrophysical Observation", "SAO 108511"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.33430030),
        dec: Angle.Degrees(+14.69497149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100535"},
        {"Hipparcos Number", "HIP 56439"},
        {"Geneva Identification System", "GEN# +1.00100535"},
        {"Smithsonian Astrophysical Observation", "SAO 99669"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.57340832),
        dec: Angle.Degrees(+14.69590232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100809"},
        {"Hipparcos Number", "HIP 56597"},
        {"Geneva Identification System", "GEN# +1.00100809"},
        {"Renson", "Renson 28970"},
        {"Smithsonian Astrophysical Observation", "SAO 99688"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.06008610),
        dec: Angle.Degrees(+14.69767148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72870"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.41640717),
        dec: Angle.Degrees(+14.69832535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241402"},
        {"Hipparcos Number", "HIP 24170"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.84650882),
        dec: Angle.Degrees(+14.69834303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86543"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.29390803),
        dec: Angle.Degrees(+14.69856280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169247"},
        {"Hipparcos Number", "HIP 90111"},
        {"Geneva Identification System", "GEN# +1.00169247"},
        {"Smithsonian Astrophysical Observation", "SAO 103665"},
        {"Wilson Evans Batten Catalogue", "WEB 15406"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.83108500),
        dec: Angle.Degrees(+14.70006609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71562"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.53664213),
        dec: Angle.Degrees(+14.70146012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52897"},
        {"Smithsonian Astrophysical Observation", "SAO 99304"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.28144334),
        dec: Angle.Degrees(+14.70161165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10603"},
        {"Hipparcos Number", "HIP 8071"},
        {"Smithsonian Astrophysical Observation", "SAO 92598"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.92747321),
        dec: Angle.Degrees(+14.70217551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44172"},
        {"Hipparcos Number", "HIP 30180"},
        {"Celescope Catalog", "CEL 1187"},
        {"Geneva Identification System", "GEN# +1.00044172"},
        {"Smithsonian Astrophysical Observation", "SAO 95567"},
        {"Wilson Evans Batten Catalogue", "WEB 6003"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.25323678),
        dec: Angle.Degrees(+14.70486152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70413"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.07473828),
        dec: Angle.Degrees(+14.70516267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18192"},
        {"Hipparcos Number", "HIP 13643"},
        {"Smithsonian Astrophysical Observation", "SAO 93188"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.91781275),
        dec: Angle.Degrees(+14.70679685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1168"},
        {"Hipparcos Number", "HIP 1277"},
        {"Geneva Identification System", "GEN# +1.00001168"},
        {"Smithsonian Astrophysical Observation", "SAO 91806"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.00837390),
        dec: Angle.Degrees(+14.70735446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129537"},
        {"Hipparcos Number", "HIP 71931"},
        {"Geneva Identification System", "GEN# +1.00129537"},
        {"Smithsonian Astrophysical Observation", "SAO 101163"},
        {"Wilson Evans Batten Catalogue", "WEB 12387"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.67687835),
        dec: Angle.Degrees(+14.70859385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219751"},
        {"Hipparcos Number", "HIP 115051"},
        {"Smithsonian Astrophysical Observation", "SAO 108525"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.53127816),
        dec: Angle.Degrees(+14.71049264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96953"},
        {"Hipparcos Number", "HIP 54568"},
        {"Geneva Identification System", "GEN# +1.00096953"},
        {"Smithsonian Astrophysical Observation", "SAO 99475"},
        {"Wilson Evans Batten Catalogue", "WEB 9848"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.48875820),
        dec: Angle.Degrees(+14.71090890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78347"},
        {"Hipparcos Number", "HIP 44838"},
        {"Smithsonian Astrophysical Observation", "SAO 98381"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03502457),
        dec: Angle.Degrees(+14.71141939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71474"},
        {"Smithsonian Astrophysical Observation", "SAO 101108"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.26217844),
        dec: Angle.Degrees(+14.71162120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195970"},
        {"Hipparcos Number", "HIP 101487"},
        {"Smithsonian Astrophysical Observation", "SAO 106250"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.49275401),
        dec: Angle.Degrees(+14.71278732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182275"},
        {"Hipparcos Number", "HIP 95303"},
        {"Smithsonian Astrophysical Observation", "SAO 104782"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.83781258),
        dec: Angle.Degrees(+14.71302410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28100"},
        {"Hipparcos Number", "HIP 20732"},
        {"Geneva Identification System", "GEN# +1.00028100"},
        {"Smithsonian Astrophysical Observation", "SAO 93935"},
        {"Wilson Evans Batten Catalogue", "WEB 3977"},
    },
    visualMagnitude: 4.69,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.65156991),
        dec: Angle.Degrees(+14.71385764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88166"},
        {"Smithsonian Astrophysical Observation", "SAO 103288"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.10203162),
        dec: Angle.Degrees(+14.71593881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -469.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101694"},
        {"Smithsonian Astrophysical Observation", "SAO 106299"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.18812800),
        dec: Angle.Degrees(+14.71607055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217603"},
        {"Hipparcos Number", "HIP 113707"},
        {"Smithsonian Astrophysical Observation", "SAO 108340"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.43667049),
        dec: Angle.Degrees(+14.71923597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101130"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.49480436),
        dec: Angle.Degrees(+14.71970034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217118"},
        {"Hipparcos Number", "HIP 113418"},
        {"Smithsonian Astrophysical Observation", "SAO 108297"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.55240192),
        dec: Angle.Degrees(+14.72136945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218141"},
        {"Hipparcos Number", "HIP 114033"},
        {"Smithsonian Astrophysical Observation", "SAO 108393"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.39432287),
        dec: Angle.Degrees(+14.72154202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44984"},
        {"Hipparcos Number", "HIP 30564"},
        {"Geneva Identification System", "GEN# +1.00044984"},
        {"Smithsonian Astrophysical Observation", "SAO 95659"},
        {"Wilson Evans Batten Catalogue", "WEB 6093"},
    },
    visualMagnitude: 6.30,
    bvColour: 2.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.36739843),
        dec: Angle.Degrees(+14.72200346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86091"},
        {"Hipparcos Number", "HIP 48751"},
        {"Geneva Identification System", "GEN# +1.00086091"},
        {"Smithsonian Astrophysical Observation", "SAO 98854"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.15575932),
        dec: Angle.Degrees(+14.72449610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95959"},
        {"Hipparcos Number", "HIP 54113"},
        {"Smithsonian Astrophysical Observation", "SAO 99427"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.08797479),
        dec: Angle.Degrees(+14.72479206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8766 A"},
        {"Henry Draper", "HD 113713"},
        {"Hipparcos Number", "HIP 63878"},
        {"Geneva Identification System", "GEN# +1.00113713"},
        {"Smithsonian Astrophysical Observation", "SAO 100407"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36891233),
        dec: Angle.Degrees(+14.72545807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43779"},
        {"Smithsonian Astrophysical Observation", "SAO 98227"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.75048981),
        dec: Angle.Degrees(+14.72814504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196411"},
        {"Hipparcos Number", "HIP 101700"},
        {"Geneva Identification System", "GEN# +1.00196411"},
        {"Smithsonian Astrophysical Observation", "SAO 106302"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.20587151),
        dec: Angle.Degrees(+14.72843439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198015"},
        {"Hipparcos Number", "HIP 102565"},
        {"Smithsonian Astrophysical Observation", "SAO 106484"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.77123898),
        dec: Angle.Degrees(+14.72962008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200430"},
        {"Hipparcos Number", "HIP 103891"},
        {"Geneva Identification System", "GEN# +1.00200430"},
        {"Smithsonian Astrophysical Observation", "SAO 106796"},
        {"Wilson Evans Batten Catalogue", "WEB 18918"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.75741401),
        dec: Angle.Degrees(+14.73001442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118864"},
        {"Hipparcos Number", "HIP 66626"},
        {"Geneva Identification System", "GEN# +1.00118864"},
        {"Smithsonian Astrophysical Observation", "SAO 100652"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.85519425),
        dec: Angle.Degrees(+14.73043198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101698"},
        {"Smithsonian Astrophysical Observation", "SAO 106301"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.19904335),
        dec: Angle.Degrees(+14.73084133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92223"},
        {"Hipparcos Number", "HIP 52147"},
        {"Fundamental Katalog 5th Edition", "FK5 4947"},
        {"Smithsonian Astrophysical Observation", "SAO 99232"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.79182798),
        dec: Angle.Degrees(+14.73259850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171534"},
        {"Hipparcos Number", "HIP 91092"},
        {"Geneva Identification System", "GEN# +1.00171534"},
        {"Smithsonian Astrophysical Observation", "SAO 103870"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.71353362),
        dec: Angle.Degrees(+14.73277928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85689"},
        {"Hipparcos Number", "HIP 48524"},
        {"Geneva Identification System", "GEN# +1.00085689"},
        {"Smithsonian Astrophysical Observation", "SAO 98832"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.45171384),
        dec: Angle.Degrees(+14.73887666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94250"},
        {"Hipparcos Number", "HIP 53202"},
        {"Smithsonian Astrophysical Observation", "SAO 99338"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.22029464),
        dec: Angle.Degrees(+14.74015681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28294"},
        {"Hipparcos Number", "HIP 20873"},
        {"Celescope Catalog", "CEL 405"},
        {"Geneva Identification System", "GEN# +5.20250068"},
        {"Smithsonian Astrophysical Observation", "SAO 93948"},
        {"Wilson Evans Batten Catalogue", "WEB 4006"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.09723620),
        dec: Angle.Degrees(+14.74102599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102665"},
        {"Smithsonian Astrophysical Observation", "SAO 106511"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.06376516),
        dec: Angle.Degrees(+14.74135065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244124"},
        {"Hipparcos Number", "HIP 25678"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.26161342),
        dec: Angle.Degrees(+14.74413118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186819"},
        {"Hipparcos Number", "HIP 97274"},
        {"Smithsonian Astrophysical Observation", "SAO 105227"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.55153333),
        dec: Angle.Degrees(+14.74434318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148019"},
        {"Hipparcos Number", "HIP 80404"},
        {"Geneva Identification System", "GEN# +1.00148019"},
        {"Smithsonian Astrophysical Observation", "SAO 102143"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.17375079),
        dec: Angle.Degrees(+14.74452169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142846"},
        {"Hipparcos Number", "HIP 78060"},
        {"Geneva Identification System", "GEN# +1.00142846"},
        {"Smithsonian Astrophysical Observation", "SAO 101824"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.06197232),
        dec: Angle.Degrees(+14.75090106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243257"},
        {"Hipparcos Number", "HIP 25239"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96370011),
        dec: Angle.Degrees(+14.75094470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169720"},
        {"Hipparcos Number", "HIP 90307"},
        {"Geneva Identification System", "GEN# +1.00169720"},
        {"Smithsonian Astrophysical Observation", "SAO 103700"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.38605992),
        dec: Angle.Degrees(+14.75100706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50434"},
        {"Hipparcos Number", "HIP 33118"},
        {"Geneva Identification System", "GEN# +1.00050434"},
        {"Smithsonian Astrophysical Observation", "SAO 96244"},
        {"Wilson Evans Batten Catalogue", "WEB 6664"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.46393928),
        dec: Angle.Degrees(+14.75209508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5197 AB"},
        {"Henry Draper", "HD 46495"},
        {"Hipparcos Number", "HIP 31345"},
        {"Smithsonian Astrophysical Observation", "SAO 95847"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.58997487),
        dec: Angle.Degrees(+14.75216188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60302"},
        {"Hipparcos Number", "HIP 36822"},
        {"Geneva Identification System", "GEN# +1.00060302"},
        {"Smithsonian Astrophysical Observation", "SAO 97024"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.58167177),
        dec: Angle.Degrees(+14.75314331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90684"},
        {"Hipparcos Number", "HIP 51277"},
        {"Geneva Identification System", "GEN# +1.00090684"},
        {"Smithsonian Astrophysical Observation", "SAO 99144"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.10563714),
        dec: Angle.Degrees(+14.75349324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161960"},
        {"Hipparcos Number", "HIP 87113"},
        {"Smithsonian Astrophysical Observation", "SAO 103119"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.98405707),
        dec: Angle.Degrees(+14.75363343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126812"},
        {"Hipparcos Number", "HIP 70687"},
        {"Fundamental Katalog 5th Edition", "FK5 5277"},
        {"Smithsonian Astrophysical Observation", "SAO 101032"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.87588748),
        dec: Angle.Degrees(+14.75424587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66685"},
        {"Hipparcos Number", "HIP 39578"},
        {"Smithsonian Astrophysical Observation", "SAO 97543"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.30976533),
        dec: Angle.Degrees(+14.75492699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133461"},
        {"Hipparcos Number", "HIP 73721"},
        {"Geneva Identification System", "GEN# +1.00133461"},
        {"Smithsonian Astrophysical Observation", "SAO 101361"},
        {"Wilson Evans Batten Catalogue", "WEB 12604"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.04497574),
        dec: Angle.Degrees(+14.75809001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27836"},
        {"Hipparcos Number", "HIP 20553"},
        {"Geneva Identification System", "GEN# +5.20250050"},
        {"Smithsonian Astrophysical Observation", "SAO 93910"},
        {"Wilson Evans Batten Catalogue", "WEB 3934"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.05165805),
        dec: Angle.Degrees(+14.75828842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215151"},
        {"Hipparcos Number", "HIP 112163"},
        {"Geneva Identification System", "GEN# +1.00215151"},
        {"Smithsonian Astrophysical Observation", "SAO 108123"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75712110),
        dec: Angle.Degrees(+14.75928882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83982"},
        {"Hipparcos Number", "HIP 47597"},
        {"Smithsonian Astrophysical Observation", "SAO 98723"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.57612861),
        dec: Angle.Degrees(+14.76400042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72234"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.58388456),
        dec: Angle.Degrees(+14.76449711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32346"},
        {"Hipparcos Number", "HIP 23496"},
        {"Smithsonian Astrophysical Observation", "SAO 94284"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.76299718),
        dec: Angle.Degrees(+14.76571270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354850"},
        {"Hipparcos Number", "HIP 98980"},
        {"Geneva Identification System", "GEN# +1.00354850"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.42515852),
        dec: Angle.Degrees(+14.76639646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11512"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.10866306),
        dec: Angle.Degrees(+14.76709777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76147"},
        {"Hipparcos Number", "HIP 43759"},
        {"Geneva Identification System", "GEN# +1.00076147"},
        {"Smithsonian Astrophysical Observation", "SAO 98225"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.70675942),
        dec: Angle.Degrees(+14.76747208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70337"},
        {"Hipparcos Number", "HIP 40995"},
        {"Geneva Identification System", "GEN# +1.00070337"},
        {"Smithsonian Astrophysical Observation", "SAO 97762"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.48832074),
        dec: Angle.Degrees(+14.76815860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41753"},
        {"Hipparcos Number", "HIP 29038"},
        {"Fundamental Katalog 5th Edition", "FK5 232"},
        {"Geneva Identification System", "GEN# +1.00041753"},
        {"Smithsonian Astrophysical Observation", "SAO 95259"},
        {"Wilson Evans Batten Catalogue", "WEB 5687"},
    },
    visualMagnitude: 4.42,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.89300774),
        dec: Angle.Degrees(+14.76852318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116871"},
        {"Smithsonian Astrophysical Observation", "SAO 108775"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.33510978),
        dec: Angle.Degrees(+14.77216838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206860"},
        {"Hipparcos Number", "HIP 107350"},
        {"Fundamental Katalog 5th Edition", "FK5 3737"},
        {"Geneva Identification System", "GEN# +1.00206860"},
        {"Smithsonian Astrophysical Observation", "SAO 107364"},
        {"Wilson Evans Batten Catalogue", "WEB 19385"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.12996019),
        dec: Angle.Degrees(+14.77221491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109088"},
        {"Smithsonian Astrophysical Observation", "SAO 107658"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46987860),
        dec: Angle.Degrees(+14.77533497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5482"},
        {"Hipparcos Number", "HIP 4428"},
        {"Smithsonian Astrophysical Observation", "SAO 92168"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.17738705),
        dec: Angle.Degrees(+14.77615765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211245"},
        {"Hipparcos Number", "HIP 109897"},
        {"Smithsonian Astrophysical Observation", "SAO 107771"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.87774819),
        dec: Angle.Degrees(+14.77702406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116869"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.33307141),
        dec: Angle.Degrees(+14.77716127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154377"},
        {"Hipparcos Number", "HIP 83552"},
        {"Smithsonian Astrophysical Observation", "SAO 102576"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.13553677),
        dec: Angle.Degrees(+14.77850121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104605"},
        {"Hipparcos Number", "HIP 58735"},
        {"Smithsonian Astrophysical Observation", "SAO 99923"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.70237888),
        dec: Angle.Degrees(+14.77861055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161729"},
        {"Hipparcos Number", "HIP 86996"},
        {"Smithsonian Astrophysical Observation", "SAO 103095"},
        {"Wilson Evans Batten Catalogue", "WEB 14678"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.66746466),
        dec: Angle.Degrees(+14.77905239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222034"},
        {"Hipparcos Number", "HIP 116544"},
        {"Smithsonian Astrophysical Observation", "SAO 108722"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.28682841),
        dec: Angle.Degrees(+14.77999974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178693"},
        {"Hipparcos Number", "HIP 94067"},
        {"Smithsonian Astrophysical Observation", "SAO 104529"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.24864513),
        dec: Angle.Degrees(+14.78039936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68946"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.70154412),
        dec: Angle.Degrees(+14.78045968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11032 A"},
        {"Henry Draper", "HD 165172"},
        {"Hipparcos Number", "HIP 88493"},
        {"Smithsonian Astrophysical Observation", "SAO 103349"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.04129874),
        dec: Angle.Degrees(+14.78114900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177434"},
        {"Hipparcos Number", "HIP 93635"},
        {"Smithsonian Astrophysical Observation", "SAO 104432"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.01759605),
        dec: Angle.Degrees(+14.78384245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113407"},
        {"Hipparcos Number", "HIP 63713"},
        {"Geneva Identification System", "GEN# +1.00113407"},
        {"Smithsonian Astrophysical Observation", "SAO 100396"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.85581730),
        dec: Angle.Degrees(+14.78873061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146642"},
        {"Hipparcos Number", "HIP 79764"},
        {"Geneva Identification System", "GEN# +1.00146642"},
        {"Smithsonian Astrophysical Observation", "SAO 102055"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.19197478),
        dec: Angle.Degrees(+14.79049582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7043"},
        {"Smithsonian Astrophysical Observation", "SAO 92473"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.70353467),
        dec: Angle.Degrees(+14.79151969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17300"},
        {"Smithsonian Astrophysical Observation", "SAO 93556"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.55145028),
        dec: Angle.Degrees(+14.79284163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7981"},
        {"Hipparcos Number", "HIP 6190"},
        {"Geneva Identification System", "GEN# +1.00007981"},
        {"Smithsonian Astrophysical Observation", "SAO 92366"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.85297074),
        dec: Angle.Degrees(+14.79304922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91811"},
        {"Hipparcos Number", "HIP 51915"},
        {"Smithsonian Astrophysical Observation", "SAO 99203"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09085555),
        dec: Angle.Degrees(+14.79349188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150121"},
        {"Hipparcos Number", "HIP 81468"},
        {"Smithsonian Astrophysical Observation", "SAO 102282"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.59204453),
        dec: Angle.Degrees(+14.79379718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162990"},
        {"Hipparcos Number", "HIP 87571"},
        {"Geneva Identification System", "GEN# +1.00162990"},
        {"Smithsonian Astrophysical Observation", "SAO 103183"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.35006772),
        dec: Angle.Degrees(+14.79734960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101910"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.77237272),
        dec: Angle.Degrees(+14.79863532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37521"},
        {"Hipparcos Number", "HIP 26647"},
        {"Smithsonian Astrophysical Observation", "SAO 94734"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.94942951),
        dec: Angle.Degrees(+14.79919371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102341"},
        {"Smithsonian Astrophysical Observation", "SAO 106435"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.03507708),
        dec: Angle.Degrees(+14.80040971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189782"},
        {"Hipparcos Number", "HIP 98548"},
        {"Smithsonian Astrophysical Observation", "SAO 105556"},
        {"Wilson Evans Batten Catalogue", "WEB 17411"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.28674779),
        dec: Angle.Degrees(+14.80155203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135103"},
        {"Hipparcos Number", "HIP 74459"},
        {"Geneva Identification System", "GEN# +1.00135103"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.24186271),
        dec: Angle.Degrees(+14.80393151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120568"},
        {"Hipparcos Number", "HIP 67520"},
        {"Smithsonian Astrophysical Observation", "SAO 100733"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52424754),
        dec: Angle.Degrees(+14.80614373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55999"},
        {"Hipparcos Number", "HIP 35143"},
        {"Geneva Identification System", "GEN# +1.00055999"},
        {"Smithsonian Astrophysical Observation", "SAO 96701"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.96765635),
        dec: Angle.Degrees(+14.80860719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4698"},
        {"Hipparcos Number", "HIP 3823"},
        {"Smithsonian Astrophysical Observation", "SAO 92100"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.26941382),
        dec: Angle.Degrees(+14.80919912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222392"},
        {"Hipparcos Number", "HIP 116780"},
        {"Smithsonian Astrophysical Observation", "SAO 108755"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.00920965),
        dec: Angle.Degrees(+14.81051484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49214"},
        {"Smithsonian Astrophysical Observation", "SAO 98919"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.68132543),
        dec: Angle.Degrees(+14.81224333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29869"},
        {"Hipparcos Number", "HIP 21942"},
        {"Geneva Identification System", "GEN# +1.00029869"},
        {"Smithsonian Astrophysical Observation", "SAO 94082"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.74717192),
        dec: Angle.Degrees(+14.81454390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117303"},
        {"Hipparcos Number", "HIP 65793"},
        {"Geneva Identification System", "GEN# +1.00117303"},
        {"Smithsonian Astrophysical Observation", "SAO 100593"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.30832191),
        dec: Angle.Degrees(+14.81469024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209709"},
        {"Hipparcos Number", "HIP 109009"},
        {"Smithsonian Astrophysical Observation", "SAO 107646"},
        {"Wilson Evans Batten Catalogue", "WEB 19602"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.26446576),
        dec: Angle.Degrees(+14.81595456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199378"},
        {"Henry Draper 2", "HD 199379"},
        {"Hipparcos Number", "HIP 103358"},
        {"Smithsonian Astrophysical Observation", "SAO 106679"},
        {"Wilson Evans Batten Catalogue", "WEB 18787"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.10517493),
        dec: Angle.Degrees(+14.81626385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28345"},
        {"Hipparcos Number", "HIP 20898"},
        {"Celescope Catalog", "CEL 409"},
        {"Smithsonian Astrophysical Observation", "SAO 93959"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.19609054),
        dec: Angle.Degrees(+14.81951918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90042"},
        {"Hipparcos Number", "HIP 50911"},
        {"Smithsonian Astrophysical Observation", "SAO 99096"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.94640909),
        dec: Angle.Degrees(+14.82244913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71261"},
        {"Hipparcos Number", "HIP 41421"},
        {"Geneva Identification System", "GEN# +1.00071261"},
        {"Smithsonian Astrophysical Observation", "SAO 97822"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.72870392),
        dec: Angle.Degrees(+14.82356323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 588"},
        {"Smithsonian Astrophysical Observation", "SAO 91718"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.78467109),
        dec: Angle.Degrees(+14.82374977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355413"},
        {"Hipparcos Number", "HIP 100011"},
        {"Smithsonian Astrophysical Observation", "SAO 105930"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.34851551),
        dec: Angle.Degrees(+14.82404267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231944"},
        {"Hipparcos Number", "HIP 96400"},
        {"Smithsonian Astrophysical Observation", "SAO 105028"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.99345755),
        dec: Angle.Degrees(+14.82451851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43679"},
        {"Smithsonian Astrophysical Observation", "SAO 98208"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.47817909),
        dec: Angle.Degrees(+14.82855155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105567"},
        {"Hipparcos Number", "HIP 59250"},
        {"Geneva Identification System", "GEN# +1.00105567"},
        {"Smithsonian Astrophysical Observation", "SAO 99963"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.30899959),
        dec: Angle.Degrees(+14.82993711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43360",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7031 B"},
        {"Hipparcos Number", "HIP 43360"},
        {"Geneva Identification System", "GEN# +1.00075355B"},
        {"Smithsonian Astrophysical Observation", "SAO 98149"},
        {"Wilson Evans Batten Catalogue", "WEB 8354"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.48675318),
        dec: Angle.Degrees(+14.83088387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55952"},
        {"Smithsonian Astrophysical Observation", "SAO 99615"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.99365016),
        dec: Angle.Degrees(+14.83216802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93044",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11867 AB"},
        {"Henry Draper", "HD 175921"},
        {"Hipparcos Number", "HIP 93044"},
        {"Smithsonian Astrophysical Observation", "SAO 104283"},
        {"Wilson Evans Batten Catalogue", "WEB 16113"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.29813586),
        dec: Angle.Degrees(+14.83300385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132679"},
        {"Hipparcos Number", "HIP 73395"},
        {"Smithsonian Astrophysical Observation", "SAO 101320"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.99019195),
        dec: Angle.Degrees(+14.83335089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43359",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7031 A"},
        {"Henry Draper", "HD 75355"},
        {"Hipparcos Number", "HIP 43359"},
        {"Geneva Identification System", "GEN# +1.00075355A"},
        {"Smithsonian Astrophysical Observation", "SAO 98148"},
        {"Wilson Evans Batten Catalogue", "WEB 8351"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.48277823),
        dec: Angle.Degrees(+14.83337636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71088"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.06758346),
        dec: Angle.Degrees(+14.83385094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15536"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.03452491),
        dec: Angle.Degrees(+14.83432931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113785"},
        {"Hipparcos Number", "HIP 63923"},
        {"Smithsonian Astrophysical Observation", "SAO 100411"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.49706119),
        dec: Angle.Degrees(+14.83950504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58430"},
        {"Hipparcos Number", "HIP 36099"},
        {"Smithsonian Astrophysical Observation", "SAO 96893"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.54989335),
        dec: Angle.Degrees(+14.84034898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5900"},
        {"Hipparcos Number", "HIP 4727"},
        {"Smithsonian Astrophysical Observation", "SAO 92199"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.17286847),
        dec: Angle.Degrees(+14.84068069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63648"},
        {"Hipparcos Number", "HIP 38276"},
        {"Geneva Identification System", "GEN# +1.00063648"},
        {"Smithsonian Astrophysical Observation", "SAO 97298"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.63178248),
        dec: Angle.Degrees(+14.84164534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159354"},
        {"Hipparcos Number", "HIP 85934"},
        {"Geneva Identification System", "GEN# +1.00159354"},
        {"Smithsonian Astrophysical Observation", "SAO 102918"},
        {"Wilson Evans Batten Catalogue", "WEB 14503"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.42819351),
        dec: Angle.Degrees(+14.84177698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224221"},
        {"Hipparcos Number", "HIP 117998"},
        {"Geneva Identification System", "GEN# +1.00224221"},
        {"Smithsonian Astrophysical Observation", "SAO 108915"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.02025181),
        dec: Angle.Degrees(+14.84227708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173026"},
        {"Hipparcos Number", "HIP 91764"},
        {"Smithsonian Astrophysical Observation", "SAO 104011"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.68634383),
        dec: Angle.Degrees(+14.84228389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28910"},
        {"Hipparcos Number", "HIP 21273"},
        {"Celescope Catalog", "CEL 431"},
        {"Fundamental Katalog 5th Edition", "FK5 1125"},
        {"Geneva Identification System", "GEN# +5.20250095"},
        {"Smithsonian Astrophysical Observation", "SAO 94007"},
        {"Wilson Evans Batten Catalogue", "WEB 4087"},
    },
    visualMagnitude: 4.65,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.46189659),
        dec: Angle.Degrees(+14.84448749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107598"},
        {"Hipparcos Number", "HIP 60307"},
        {"Geneva Identification System", "GEN# +1.00107598"},
        {"Smithsonian Astrophysical Observation", "SAO 100061"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.48494312),
        dec: Angle.Degrees(+14.84460359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32009"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.31061184),
        dec: Angle.Degrees(+14.85075340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104976"},
        {"Hipparcos Number", "HIP 58951"},
        {"Geneva Identification System", "GEN# +1.00104976"},
        {"Smithsonian Astrophysical Observation", "SAO 99935"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.30645462),
        dec: Angle.Degrees(+14.85124637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159994"},
        {"Hipparcos Number", "HIP 86211"},
        {"Smithsonian Astrophysical Observation", "SAO 102969"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.25993190),
        dec: Angle.Degrees(+14.85167003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199700"},
        {"Hipparcos Number", "HIP 103531"},
        {"Geneva Identification System", "GEN# +1.00199700"},
        {"Smithsonian Astrophysical Observation", "SAO 106715"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.62796011),
        dec: Angle.Degrees(+14.85275746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42180"},
        {"Hipparcos Number", "HIP 29239"},
        {"Celescope Catalog", "CEL 1096"},
        {"Geneva Identification System", "GEN# +1.00042180"},
        {"Smithsonian Astrophysical Observation", "SAO 95308"},
        {"Wilson Evans Batten Catalogue", "WEB 5733"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.47313670),
        dec: Angle.Degrees(+14.85276002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142054"},
        {"Hipparcos Number", "HIP 77704"},
        {"Smithsonian Astrophysical Observation", "SAO 101781"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.97829317),
        dec: Angle.Degrees(+14.85298551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67403"},
        {"Hipparcos Number", "HIP 39837"},
        {"Geneva Identification System", "GEN# +1.00067403"},
        {"Smithsonian Astrophysical Observation", "SAO 97586"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.09364622),
        dec: Angle.Degrees(+14.85362301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
