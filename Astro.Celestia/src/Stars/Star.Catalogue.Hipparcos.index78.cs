using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_78() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156948"},
        {"Hipparcos Number", "HIP 84767"},
        {"Smithsonian Astrophysical Observation", "SAO 102750"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.89757075),
        dec: Angle.Degrees(+19.27450338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37644"},
        {"Smithsonian Astrophysical Observation", "SAO 97183"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.87418826),
        dec: Angle.Degrees(+19.27640359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11897"},
        {"Hipparcos Number", "HIP 9103"},
        {"Smithsonian Astrophysical Observation", "SAO 92719"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.30809473),
        dec: Angle.Degrees(+19.27710848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86335"},
        {"Smithsonian Astrophysical Observation", "SAO 102991"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.62000321),
        dec: Angle.Degrees(+19.28374882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76627"},
        {"Hipparcos Number", "HIP 44022"},
        {"Geneva Identification System", "GEN# +1.00076627"},
        {"Smithsonian Astrophysical Observation", "SAO 98259"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.48004292),
        dec: Angle.Degrees(+19.28416288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74432",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9535 A"},
        {"Henry Draper", "HD 135101"},
        {"Henry Draper 2", "HD 135101A"},
        {"Hipparcos Number", "HIP 74432"},
        {"Cincinnati Publication", "Ci 20 917"},
        {"Geneva Identification System", "GEN# +1.00135101A"},
        {"Smithsonian Astrophysical Observation", "SAO 101437"},
        {"Wilson Evans Batten Catalogue", "WEB 12703"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.18270388),
        dec: Angle.Degrees(+19.28532629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -595.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 288.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258452"},
        {"Hipparcos Number", "HIP 31014"},
        {"Geneva Identification System", "GEN# +1.00258452"},
        {"Smithsonian Astrophysical Observation", "SAO 95760"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.62019193),
        dec: Angle.Degrees(+19.28557836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110157"},
        {"Smithsonian Astrophysical Observation", "SAO 107818"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.69309280),
        dec: Angle.Degrees(+19.28592337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149010"},
        {"Hipparcos Number", "HIP 80905"},
        {"Smithsonian Astrophysical Observation", "SAO 102218"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.82601929),
        dec: Angle.Degrees(+19.28659683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81899"},
        {"Hipparcos Number", "HIP 46501"},
        {"Smithsonian Astrophysical Observation", "SAO 98596"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.25272229),
        dec: Angle.Degrees(+19.28841365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142024"},
        {"Hipparcos Number", "HIP 77680"},
        {"Smithsonian Astrophysical Observation", "SAO 101780"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.88524710),
        dec: Angle.Degrees(+19.28915290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86188"},
        {"Hipparcos Number", "HIP 48812"},
        {"Smithsonian Astrophysical Observation", "SAO 98861"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.34753082),
        dec: Angle.Degrees(+19.28939806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161479"},
        {"Hipparcos Number", "HIP 86882"},
        {"Cincinnati Publication", "Ci 18 2362"},
        {"Smithsonian Astrophysical Observation", "SAO 103077"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.26179595),
        dec: Angle.Degrees(+19.29034048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15674"},
        {"Hipparcos Number", "HIP 11760"},
        {"Smithsonian Astrophysical Observation", "SAO 92988"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.93079628),
        dec: Angle.Degrees(+19.29097940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9535 B"},
        {"Henry Draper", "HD 135101B"},
        {"Hipparcos Number", "HIP 74434"},
        {"Cincinnati Publication", "Ci 20 918"},
        {"Geneva Identification System", "GEN# +1.00135101B"},
        {"Geneva Identification System 2", "GEN# +1.20135101"},
        {"Smithsonian Astrophysical Observation", "SAO 101438"},
        {"Wilson Evans Batten Catalogue", "WEB 12705"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.18392888),
        dec: Angle.Degrees(+19.29174670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -589.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 282.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231692"},
        {"Hipparcos Number", "HIP 96046"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.92983910),
        dec: Angle.Degrees(+19.29377457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8832",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mesarthim"},
        {"Aitken", "ADS 1507 AB"},
        {"Hipparcos Number", "HIP 8832"},
        {"Celescope Catalog", "CEL 179"},
        {"Geneva Identification System", "GEN# +1.00011503"},
    },
    visualMagnitude: 3.88,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.38235506),
        dec: Angle.Degrees(+19.29409264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151852"},
        {"Hipparcos Number", "HIP 82320"},
        {"Geneva Identification System", "GEN# +1.00151852"},
        {"Smithsonian Astrophysical Observation", "SAO 102407"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.30413561),
        dec: Angle.Degrees(+19.29415782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73297"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.69462846),
        dec: Angle.Degrees(+19.29454162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242135"},
        {"Hipparcos Number", "HIP 24574"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.07308914),
        dec: Angle.Degrees(+19.29529885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170267"},
        {"Hipparcos Number", "HIP 90479"},
        {"Smithsonian Astrophysical Observation", "SAO 103740"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.93306951),
        dec: Angle.Degrees(+19.29549311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194381"},
        {"Hipparcos Number", "HIP 100673"},
        {"Smithsonian Astrophysical Observation", "SAO 106076"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17578690),
        dec: Angle.Degrees(+19.29555132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141289"},
        {"Hipparcos Number", "HIP 77376"},
        {"Smithsonian Astrophysical Observation", "SAO 101743"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.92756305),
        dec: Angle.Degrees(+19.29647456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49946"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.96337182),
        dec: Angle.Degrees(+19.29745109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49710"},
        {"Hipparcos Number", "HIP 32824"},
        {"Smithsonian Astrophysical Observation", "SAO 96180"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.63808244),
        dec: Angle.Degrees(+19.29796860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242223"},
        {"Hipparcos Number", "HIP 24615"},
        {"Smithsonian Astrophysical Observation", "SAO 94433"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.19776930),
        dec: Angle.Degrees(+19.30222502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243837"},
        {"Hipparcos Number", "HIP 25534"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90407323),
        dec: Angle.Degrees(+19.30378244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36135"},
        {"Smithsonian Astrophysical Observation", "SAO 96900"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.65996963),
        dec: Angle.Degrees(+19.30441327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102389"},
        {"Hipparcos Number", "HIP 57503"},
        {"Geneva Identification System", "GEN# +1.00102389"},
        {"Smithsonian Astrophysical Observation", "SAO 99789"},
        {"Wilson Evans Batten Catalogue", "WEB 10326"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.79652842),
        dec: Angle.Degrees(+19.30627470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15386 A"},
        {"Henry Draper", "HD 207859"},
        {"Hipparcos Number", "HIP 107896"},
        {"Geneva Identification System", "GEN# +1.00207859"},
        {"Smithsonian Astrophysical Observation", "SAO 107450"},
        {"Wilson Evans Batten Catalogue", "WEB 19456"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.91740867),
        dec: Angle.Degrees(+19.30693948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205373"},
        {"Hipparcos Number", "HIP 106508"},
        {"Smithsonian Astrophysical Observation", "SAO 107244"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.58555920),
        dec: Angle.Degrees(+19.30733549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120184"},
        {"Hipparcos Number", "HIP 67307"},
        {"Geneva Identification System", "GEN# +1.00120184"},
        {"Smithsonian Astrophysical Observation", "SAO 100711"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.91980608),
        dec: Angle.Degrees(+19.30813669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176776"},
        {"Hipparcos Number", "HIP 93374"},
        {"Smithsonian Astrophysical Observation", "SAO 104362"},
        {"Wilson Evans Batten Catalogue", "WEB 16190"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.27262462),
        dec: Angle.Degrees(+19.30961261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34656"},
        {"Smithsonian Astrophysical Observation", "SAO 96591"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.66234251),
        dec: Angle.Degrees(+19.30993666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17768"},
        {"Hipparcos Number", "HIP 13337"},
        {"Smithsonian Astrophysical Observation", "SAO 93146"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.91868035),
        dec: Angle.Degrees(+19.31006678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219964"},
        {"Hipparcos Number", "HIP 115207"},
        {"Smithsonian Astrophysical Observation", "SAO 108548"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.01610088),
        dec: Angle.Degrees(+19.31184067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84306"},
        {"Smithsonian Astrophysical Observation", "SAO 102673"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.54019408),
        dec: Angle.Degrees(+19.31197763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16707"},
        {"Smithsonian Astrophysical Observation", "SAO 93499"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.74364174),
        dec: Angle.Degrees(+19.31284185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48448"},
        {"Smithsonian Astrophysical Observation", "SAO 98822"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.16442230),
        dec: Angle.Degrees(+19.31396965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60939"},
        {"Geneva Identification System", "GEN# +0.02002727"},
        {"Smithsonian Astrophysical Observation", "SAO 100124"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.35309066),
        dec: Angle.Degrees(+19.31531516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152225"},
        {"Hipparcos Number", "HIP 82476"},
        {"Smithsonian Astrophysical Observation", "SAO 102430"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.84014618),
        dec: Angle.Degrees(+19.31553951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94557"},
        {"Cincinnati Publication", "Ci 20 1142"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66474349),
        dec: Angle.Degrees(+19.31664395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -617.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 434.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79393"},
        {"Smithsonian Astrophysical Observation", "SAO 102004"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.04282737),
        dec: Angle.Degrees(+19.31817602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205852"},
        {"Hipparcos Number", "HIP 106787"},
        {"Fundamental Katalog 5th Edition", "FK5 1570"},
        {"Geneva Identification System", "GEN# +1.00205852"},
        {"Smithsonian Astrophysical Observation", "SAO 107288"},
        {"Wilson Evans Batten Catalogue", "WEB 19306"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.43903480),
        dec: Angle.Degrees(+19.31857481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197408"},
        {"Hipparcos Number", "HIP 102239"},
        {"Smithsonian Astrophysical Observation", "SAO 106419"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.75184015),
        dec: Angle.Degrees(+19.32142125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75899"},
        {"Hipparcos Number", "HIP 43642"},
        {"Smithsonian Astrophysical Observation", "SAO 98198"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.33594586),
        dec: Angle.Degrees(+19.32219922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111307"},
        {"Hipparcos Number", "HIP 62484"},
        {"Fundamental Katalog 5th Edition", "FK5 5133"},
        {"Geneva Identification System", "GEN# +1.00111307"},
        {"Smithsonian Astrophysical Observation", "SAO 100270"},
        {"Wilson Evans Batten Catalogue", "WEB 11092"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.07439886),
        dec: Angle.Degrees(+19.32261952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85216"},
        {"Hipparcos Number", "HIP 48305"},
        {"Geneva Identification System", "GEN# +1.00085216"},
        {"Renson", "Renson 24340"},
        {"Smithsonian Astrophysical Observation", "SAO 98803"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.72127374),
        dec: Angle.Degrees(+19.32354877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63889"},
        {"Hipparcos Number", "HIP 38394"},
        {"Geneva Identification System", "GEN# +1.00063889"},
        {"Smithsonian Astrophysical Observation", "SAO 97318"},
        {"Wilson Evans Batten Catalogue", "WEB 7551"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.98667865),
        dec: Angle.Degrees(+19.32517752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30123"},
        {"Hipparcos Number", "HIP 22112"},
        {"Geneva Identification System", "GEN# +2.16470015"},
        {"Smithsonian Astrophysical Observation", "SAO 94100"},
        {"New General Catalogue", "NGC 1647 15"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.39452447),
        dec: Angle.Degrees(+19.32830016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174262"},
        {"Hipparcos Number", "HIP 92312"},
        {"Geneva Identification System", "GEN# +1.00174262"},
        {"Smithsonian Astrophysical Observation", "SAO 104129"},
        {"Wilson Evans Batten Catalogue", "WEB 15934"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.22240149),
        dec: Angle.Degrees(+19.32877145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54692"},
        {"Hipparcos Number", "HIP 34660"},
        {"Smithsonian Astrophysical Observation", "SAO 96592"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.66688602),
        dec: Angle.Degrees(+19.32883654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200044"},
        {"Hipparcos Number", "HIP 103675"},
        {"Fundamental Katalog 5th Edition", "FK5 3675"},
        {"Geneva Identification System", "GEN# +1.00200044"},
        {"Smithsonian Astrophysical Observation", "SAO 106747"},
        {"Wilson Evans Batten Catalogue", "WEB 18869"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.11540786),
        dec: Angle.Degrees(+19.32972583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160057"},
        {"Hipparcos Number", "HIP 86217"},
        {"Smithsonian Astrophysical Observation", "SAO 102971"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.27875386),
        dec: Angle.Degrees(+19.33050468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42841"},
        {"Hipparcos Number", "HIP 29566"},
        {"Geneva Identification System", "GEN# +1.00042841"},
        {"Smithsonian Astrophysical Observation", "SAO 95402"},
        {"Wilson Evans Batten Catalogue", "WEB 5810"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.43398376),
        dec: Angle.Degrees(+19.33336370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2439 AB"},
        {"Henry Draper", "HD 20289"},
        {"Hipparcos Number", "HIP 15227"},
        {"Smithsonian Astrophysical Observation", "SAO 93366"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.08080668),
        dec: Angle.Degrees(+19.33777947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61000"},
        {"Geneva Identification System", "GEN# +0.02002728"},
        {"Smithsonian Astrophysical Observation", "SAO 100133"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.53598744),
        dec: Angle.Degrees(+19.34180546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54917"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.69264468),
        dec: Angle.Degrees(+19.34387333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82386"},
        {"Smithsonian Astrophysical Observation", "SAO 102420"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.51876963),
        dec: Angle.Degrees(+19.34556655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120540"},
        {"Hipparcos Number", "HIP 67492"},
        {"Geneva Identification System", "GEN# +1.00120540"},
        {"Smithsonian Astrophysical Observation", "SAO 100730"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.46178035),
        dec: Angle.Degrees(+19.34703163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130686"},
        {"Hipparcos Number", "HIP 72462"},
        {"Geneva Identification System", "GEN# +1.00130686"},
        {"Smithsonian Astrophysical Observation", "SAO 101228"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.26025803),
        dec: Angle.Degrees(+19.34757742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73712"},
        {"Hipparcos Number", "HIP 42542"},
        {"Geneva Identification System", "GEN# +2.26320284"},
        {"Smithsonian Astrophysical Observation", "SAO 98019"},
        {"Wilson Evans Batten Catalogue", "WEB 8202"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.08402337),
        dec: Angle.Degrees(+19.34902575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284842"},
        {"Hipparcos Number", "HIP 22105"},
        {"Geneva Identification System", "GEN# +5.20258067"},
        {"Geneva Identification System 2", "GEN# +2.16470016"},
        {"Smithsonian Astrophysical Observation", "SAO 94098"},
        {"New General Catalogue", "NGC 1647 16"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.36556325),
        dec: Angle.Degrees(+19.34916714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75750"},
        {"Hipparcos Number", "HIP 43564"},
        {"Geneva Identification System", "GEN# +1.00075750"},
        {"Smithsonian Astrophysical Observation", "SAO 98186"},
        {"Wilson Evans Batten Catalogue", "WEB 8395"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.08341624),
        dec: Angle.Degrees(+19.35078437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49115"},
        {"Smithsonian Astrophysical Observation", "SAO 98899"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.35470441),
        dec: Angle.Degrees(+19.35103868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105290"},
        {"Hipparcos Number", "HIP 59121"},
        {"Geneva Identification System", "GEN# +1.00105290"},
        {"Smithsonian Astrophysical Observation", "SAO 99947"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.84591905),
        dec: Angle.Degrees(+19.35327627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123945"},
        {"Hipparcos Number", "HIP 69214"},
        {"Geneva Identification System", "GEN# +1.00123945"},
        {"Smithsonian Astrophysical Observation", "SAO 100890"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.55501431),
        dec: Angle.Degrees(+19.35536898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191947"},
        {"Hipparcos Number", "HIP 99510"},
        {"Smithsonian Astrophysical Observation", "SAO 105812"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.93725581),
        dec: Angle.Degrees(+19.35604812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37771"},
        {"Hipparcos Number", "HIP 26826"},
        {"Celescope Catalog", "CEL 931"},
        {"Smithsonian Astrophysical Observation", "SAO 94767"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.43393285),
        dec: Angle.Degrees(+19.35709862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61500"},
        {"Hipparcos Number", "HIP 37381"},
        {"Geneva Identification System", "GEN# +1.00061500"},
        {"Smithsonian Astrophysical Observation", "SAO 97130"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.09990390),
        dec: Angle.Degrees(+19.35767437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11539"},
        {"Smithsonian Astrophysical Observation", "SAO 92969"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.18856543),
        dec: Angle.Degrees(+19.35770330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185335"},
        {"Hipparcos Number", "HIP 96570"},
        {"Smithsonian Astrophysical Observation", "SAO 105077"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.47914977),
        dec: Angle.Degrees(+19.35894620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22538"},
        {"Hipparcos Number", "HIP 16961"},
        {"Geneva Identification System", "GEN# +1.00022538"},
        {"Renson", "Renson 5730"},
        {"Smithsonian Astrophysical Observation", "SAO 93526"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.54551988),
        dec: Angle.Degrees(+19.36045757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80096"},
        {"Smithsonian Astrophysical Observation", "SAO 102095"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.25140878),
        dec: Angle.Degrees(+19.36091381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9959"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.04927112),
        dec: Angle.Degrees(+19.36163091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120509"},
        {"Hipparcos Number", "HIP 67469"},
        {"Smithsonian Astrophysical Observation", "SAO 100727"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.39320350),
        dec: Angle.Degrees(+19.36202340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250792"},
        {"Hipparcos Number", "HIP 28671"},
        {"Cincinnati Publication", "Ci 18 756"},
        {"Cincinnati Publication 2", "Ci 20 364"},
        {"Geneva Identification System", "GEN# +1.00250792A"},
        {"Smithsonian Astrophysical Observation", "SAO 95160"},
        {"Wilson Evans Batten Catalogue", "WEB 5605"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.81020899),
        dec: Angle.Degrees(+19.36225800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 666.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -623.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125859"},
        {"Hipparcos Number", "HIP 70193"},
        {"Geneva Identification System", "GEN# +1.00125859"},
        {"Smithsonian Astrophysical Observation", "SAO 100991"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.42161542),
        dec: Angle.Degrees(+19.36265059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156911"},
        {"Hipparcos Number", "HIP 84765"},
        {"Smithsonian Astrophysical Observation", "SAO 102749"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.89126239),
        dec: Angle.Degrees(+19.36293473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19324"},
        {"Hipparcos Number", "HIP 14493"},
        {"Smithsonian Astrophysical Observation", "SAO 93281"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.79309130),
        dec: Angle.Degrees(+19.36413119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90472"},
        {"Hipparcos Number", "HIP 51161"},
        {"Fundamental Katalog 5th Edition", "FK5 2837"},
        {"Geneva Identification System", "GEN# +1.00090472"},
        {"Smithsonian Astrophysical Observation", "SAO 99128"},
        {"Wilson Evans Batten Catalogue", "WEB 9351"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.75217477),
        dec: Angle.Degrees(+19.36455135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191837"},
        {"Hipparcos Number", "HIP 99462"},
        {"Geneva Identification System", "GEN# +1.00191837"},
        {"Smithsonian Astrophysical Observation", "SAO 105798"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.80402687),
        dec: Angle.Degrees(+19.36513832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215510"},
        {"Hipparcos Number", "HIP 112358"},
        {"Fundamental Katalog 5th Edition", "FK5 1596"},
        {"Geneva Identification System", "GEN# +1.00215510"},
        {"Smithsonian Astrophysical Observation", "SAO 108154"},
        {"Wilson Evans Batten Catalogue", "WEB 20042"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.36746971),
        dec: Angle.Degrees(+19.36642020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353056"},
        {"Hipparcos Number", "HIP 102886"},
        {"Smithsonian Astrophysical Observation", "SAO 106564"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66568905),
        dec: Angle.Degrees(+19.36684593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79267"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.66254769),
        dec: Angle.Degrees(+19.36771186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148406"},
        {"Hipparcos Number", "HIP 80573"},
        {"Geneva Identification System", "GEN# +1.00148406"},
        {"Smithsonian Astrophysical Observation", "SAO 102180"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.76741828),
        dec: Angle.Degrees(+19.36820660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81839"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.74195272),
        dec: Angle.Degrees(+19.36922577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -344.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10275"},
        {"Hipparcos Number", "HIP 7839"},
        {"Geneva Identification System", "GEN# +1.00010275"},
        {"Smithsonian Astrophysical Observation", "SAO 92571"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.21073862),
        dec: Angle.Degrees(+19.37158099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2122 AB"},
        {"Henry Draper", "HD 17332"},
        {"Hipparcos Number", "HIP 13027"},
        {"Geneva Identification System", "GEN# +1.00017332J"},
        {"Smithsonian Astrophysical Observation", "SAO 93105"},
        {"Wilson Evans Batten Catalogue", "WEB 2631"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.86395248),
        dec: Angle.Degrees(+19.37221052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201861"},
        {"Hipparcos Number", "HIP 104638"},
        {"Smithsonian Astrophysical Observation", "SAO 106905"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.93549307),
        dec: Angle.Degrees(+19.37274435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182274"},
        {"Hipparcos Number", "HIP 95293"},
        {"Geneva Identification System", "GEN# +1.00182274"},
        {"Smithsonian Astrophysical Observation", "SAO 104781"},
        {"Wilson Evans Batten Catalogue", "WEB 16653"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.80230184),
        dec: Angle.Degrees(+19.37559058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204188"},
        {"Hipparcos Number", "HIP 105860"},
        {"Geneva Identification System", "GEN# +1.00204188"},
        {"Renson", "Renson 56880"},
        {"Smithsonian Astrophysical Observation", "SAO 107138"},
        {"Wilson Evans Batten Catalogue", "WEB 19199"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61088664),
        dec: Angle.Degrees(+19.37559788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159225"},
        {"Hipparcos Number", "HIP 85867"},
        {"Geneva Identification System", "GEN# +1.00159225"},
        {"Smithsonian Astrophysical Observation", "SAO 102905"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.20372030),
        dec: Angle.Degrees(+19.37731970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6330"},
        {"Hipparcos Number", "HIP 5037"},
        {"Smithsonian Astrophysical Observation", "SAO 92227"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.12596004),
        dec: Angle.Degrees(+19.37735494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126645"},
        {"Hipparcos Number", "HIP 70591"},
        {"Smithsonian Astrophysical Observation", "SAO 101023"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.58926050),
        dec: Angle.Degrees(+19.37842298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19568"},
        {"Hipparcos Number", "HIP 14672"},
        {"Smithsonian Astrophysical Observation", "SAO 93304"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.39419645),
        dec: Angle.Degrees(+19.38075093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285233"},
        {"Hipparcos Number", "HIP 18347"},
        {"Smithsonian Astrophysical Observation", "SAO 93672"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.83771747),
        dec: Angle.Degrees(+19.38114117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 517"},
        {"Hipparcos Number", "HIP 790"},
        {"Smithsonian Astrophysical Observation", "SAO 91747"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.45190918),
        dec: Angle.Degrees(+19.38130034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225106"},
        {"Hipparcos Number", "HIP 282"},
        {"Smithsonian Astrophysical Observation", "SAO 91679"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.87642718),
        dec: Angle.Degrees(+19.38157170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143092"},
        {"Hipparcos Number", "HIP 78178"},
        {"Smithsonian Astrophysical Observation", "SAO 101840"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.43998971),
        dec: Angle.Degrees(+19.38312752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21975"},
        {"Hipparcos Number", "HIP 16551"},
        {"Smithsonian Astrophysical Observation", "SAO 93485"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.28207134),
        dec: Angle.Degrees(+19.38333108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104754"},
        {"Hipparcos Number", "HIP 58818"},
        {"Geneva Identification System", "GEN# +1.00104754"},
        {"Smithsonian Astrophysical Observation", "SAO 99926"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.95751810),
        dec: Angle.Degrees(+19.38394492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154085"},
        {"Hipparcos Number", "HIP 83384"},
        {"Smithsonian Astrophysical Observation", "SAO 102549"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.63140382),
        dec: Angle.Degrees(+19.38619576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231848"},
        {"Hipparcos Number", "HIP 96247"},
        {"Geneva Identification System", "GEN# +1.00231848"},
        {"Smithsonian Astrophysical Observation", "SAO 104977"},
        {"Wilson Evans Batten Catalogue", "WEB 16868"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.56067459),
        dec: Angle.Degrees(+19.38688585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121492"},
        {"Hipparcos Number", "HIP 67988"},
        {"Geneva Identification System", "GEN# +1.00121492"},
        {"Smithsonian Astrophysical Observation", "SAO 100772"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.84055590),
        dec: Angle.Degrees(+19.38733073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22916"},
        {"Hipparcos Number", "HIP 17234"},
        {"Smithsonian Astrophysical Observation", "SAO 93552"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.35980619),
        dec: Angle.Degrees(+19.38859629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12445"},
        {"Hipparcos Number", "HIP 9511"},
        {"Smithsonian Astrophysical Observation", "SAO 92759"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.58815779),
        dec: Angle.Degrees(+19.38995023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133125"},
        {"Hipparcos Number", "HIP 73577"},
        {"Smithsonian Astrophysical Observation", "SAO 101343"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.57986940),
        dec: Angle.Degrees(+19.39062221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41824"},
    },
    visualMagnitude: 11.90,
    bvColour: 1.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.90716970),
        dec: Angle.Degrees(+19.39451047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249262"},
        {"Hipparcos Number", "HIP 28046"},
        {"Smithsonian Astrophysical Observation", "SAO 94999"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.96651431),
        dec: Angle.Degrees(+19.39606042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229741"},
        {"Hipparcos Number", "HIP 92500"},
        {"Smithsonian Astrophysical Observation", "SAO 104179"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.77239789),
        dec: Angle.Degrees(+19.39620202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247194"},
        {"Hipparcos Number", "HIP 27171"},
        {"Smithsonian Astrophysical Observation", "SAO 94836"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37986350),
        dec: Angle.Degrees(+19.39649904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35575"},
        {"Smithsonian Astrophysical Observation", "SAO 96790"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.12916796),
        dec: Angle.Degrees(+19.39699464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113527"},
        {"Hipparcos Number", "HIP 63767"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.05193505),
        dec: Angle.Degrees(+19.39741504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185737"},
        {"Hipparcos Number", "HIP 96740"},
        {"Geneva Identification System", "GEN# +1.00185737"},
        {"Smithsonian Astrophysical Observation", "SAO 105116"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.98209925),
        dec: Angle.Degrees(+19.39974464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117791"},
    },
    visualMagnitude: 11.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.30753261),
        dec: Angle.Degrees(+19.40052037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220255"},
        {"Hipparcos Number", "HIP 115370"},
        {"Geneva Identification System", "GEN# +1.00220255"},
        {"Smithsonian Astrophysical Observation", "SAO 108568"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.55500504),
        dec: Angle.Degrees(+19.40060480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3859"},
        {"Hipparcos Number", "HIP 3244"},
        {"Geneva Identification System", "GEN# +1.00003859"},
        {"Smithsonian Astrophysical Observation", "SAO 92027"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.31838366),
        dec: Angle.Degrees(+19.40061072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192970"},
        {"Hipparcos Number", "HIP 99996"},
        {"Smithsonian Astrophysical Observation", "SAO 105927"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.29763835),
        dec: Angle.Degrees(+19.40118590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90347"},
        {"Hipparcos Number", "HIP 51067"},
        {"Smithsonian Astrophysical Observation", "SAO 99114"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.51680277),
        dec: Angle.Degrees(+19.40147959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87867"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.23363161),
        dec: Angle.Degrees(+19.40243337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18731"},
        {"Hipparcos Number", "HIP 14062"},
        {"Geneva Identification System", "GEN# +1.00018731"},
        {"Smithsonian Astrophysical Observation", "SAO 93237"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.29559677),
        dec: Angle.Degrees(+19.40284211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260270"},
        {"Hipparcos Number", "HIP 31536"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.02595441),
        dec: Angle.Degrees(+19.40322223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1407"},
        {"Hipparcos Number", "HIP 1468"},
        {"Smithsonian Astrophysical Observation", "SAO 91833"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57680139),
        dec: Angle.Degrees(+19.40442348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9321 AB"},
        {"Hipparcos Number", "HIP 71413"},
        {"Geneva Identification System", "GEN# +0.02002992J"},
        {"Smithsonian Astrophysical Observation", "SAO 101100"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.06390502),
        dec: Angle.Degrees(+19.40599019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6544"},
        {"Hipparcos Number", "HIP 5199"},
        {"Geneva Identification System", "GEN# +1.00006544"},
        {"Smithsonian Astrophysical Observation", "SAO 92247"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.62523873),
        dec: Angle.Degrees(+19.40657638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67666"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.95327497),
        dec: Angle.Degrees(+19.40806314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48021"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.83677371),
        dec: Angle.Degrees(+19.40853798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63535"},
        {"Hipparcos Number", "HIP 38252"},
        {"Smithsonian Astrophysical Observation", "SAO 97289"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.54366162),
        dec: Angle.Degrees(+19.40912311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142476"},
        {"Hipparcos Number", "HIP 77869"},
        {"Smithsonian Astrophysical Observation", "SAO 101803"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.52256967),
        dec: Angle.Degrees(+19.41103344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103432"},
        {"Hipparcos Number", "HIP 58067"},
        {"Cincinnati Publication", "Ci 20 668"},
        {"Geneva Identification System", "GEN# +1.00103432"},
        {"Smithsonian Astrophysical Observation", "SAO 99858"},
        {"Wilson Evans Batten Catalogue", "WEB 10398"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.63477708),
        dec: Angle.Degrees(+19.41126815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -450.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209724"},
        {"Hipparcos Number", "HIP 109027"},
        {"Smithsonian Astrophysical Observation", "SAO 107652"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.30568519),
        dec: Angle.Degrees(+19.41393627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104207"},
        {"Hipparcos Number", "HIP 58519"},
        {"Geneva Identification System", "GEN# +1.00104207"},
        {"Smithsonian Astrophysical Observation", "SAO 99901"},
        {"Wilson Evans Batten Catalogue", "WEB 10449"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.01981724),
        dec: Angle.Degrees(+19.41944059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180352"},
        {"Hipparcos Number", "HIP 94641"},
        {"Geneva Identification System", "GEN# +1.00180352"},
        {"Smithsonian Astrophysical Observation", "SAO 104660"},
        {"Wilson Evans Batten Catalogue", "WEB 16498"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.86582654),
        dec: Angle.Degrees(+19.42000361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40679"},
        {"Hipparcos Number", "HIP 28519"},
        {"Smithsonian Astrophysical Observation", "SAO 95119"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.29391032),
        dec: Angle.Degrees(+19.42046436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101154",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13921 AB"},
        {"Henry Draper", "HD 195358"},
        {"Hipparcos Number", "HIP 101154"},
        {"Smithsonian Astrophysical Observation", "SAO 106177"},
        {"Wilson Evans Batten Catalogue", "WEB 18270"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.56015491),
        dec: Angle.Degrees(+19.42104958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80147"},
        {"Hipparcos Number", "HIP 45678"},
        {"Smithsonian Astrophysical Observation", "SAO 98484"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.68013269),
        dec: Angle.Degrees(+19.42192970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52553"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16833720),
        dec: Angle.Degrees(+19.42298622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207651"},
        {"Hipparcos Number", "HIP 107786"},
        {"Geneva Identification System", "GEN# +1.00207651"},
        {"Smithsonian Astrophysical Observation", "SAO 107427"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.53415682),
        dec: Angle.Degrees(+19.42397468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350046"},
        {"Hipparcos Number", "HIP 95633"},
        {"Geneva Identification System", "GEN# +1.00350046"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.78079313),
        dec: Angle.Degrees(+19.42471084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68549"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.49295544),
        dec: Angle.Degrees(+19.42488971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61375"},
        {"Geneva Identification System", "GEN# +0.02002737"},
        {"Smithsonian Astrophysical Observation", "SAO 100154"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.65926382),
        dec: Angle.Degrees(+19.42695976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103431"},
        {"Hipparcos Number", "HIP 58073"},
        {"Cincinnati Publication", "Ci 20 669"},
        {"Geneva Identification System", "GEN# +1.00103431"},
        {"Smithsonian Astrophysical Observation", "SAO 99861"},
        {"Wilson Evans Batten Catalogue", "WEB 10397"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.64732892),
        dec: Angle.Degrees(+19.42786358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -452.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71667"},
        {"Geneva Identification System", "GEN# +0.02003004"},
        {"Wilson Evans Batten Catalogue", "WEB 12353"},
    },
    visualMagnitude: 10.11,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.88022957),
        dec: Angle.Degrees(+19.42874223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46516"},
        {"Hipparcos Number", "HIP 31368"},
        {"Fundamental Katalog 5th Edition", "FK5 4595"},
        {"Smithsonian Astrophysical Observation", "SAO 95852"},
        {"Wilson Evans Batten Catalogue", "WEB 6278"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.66378023),
        dec: Angle.Degrees(+19.42906439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16909"},
        {"Hipparcos Number", "HIP 12709"},
        {"Cincinnati Publication", "Ci 18 347"},
        {"Cincinnati Publication 2", "Ci 20 179"},
        {"Geneva Identification System", "GEN# +1.00016909"},
        {"Smithsonian Astrophysical Observation", "SAO 93072"},
        {"Wilson Evans Batten Catalogue", "WEB 2582"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.83604659),
        dec: Angle.Degrees(+19.42928193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 434.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13921 C"},
        {"Henry Draper", "HD 195341"},
        {"Hipparcos Number", "HIP 101143"},
        {"Smithsonian Astrophysical Observation", "SAO 106171"},
        {"Wilson Evans Batten Catalogue", "WEB 18268"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.53037914),
        dec: Angle.Degrees(+19.43015570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122504"},
        {"Hipparcos Number", "HIP 68548"},
        {"Smithsonian Astrophysical Observation", "SAO 100821"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.49069192),
        dec: Angle.Degrees(+19.43026817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230855"},
        {"Hipparcos Number", "HIP 94301"},
        {"Renson", "Renson 49820"},
        {"Smithsonian Astrophysical Observation", "SAO 104578"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.91635671),
        dec: Angle.Degrees(+19.43171010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77836"},
        {"Hipparcos Number", "HIP 44616"},
        {"Geneva Identification System", "GEN# +1.00077836"},
        {"Smithsonian Astrophysical Observation", "SAO 98353"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.37267941),
        dec: Angle.Degrees(+19.43589876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56642"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.20991650),
        dec: Angle.Degrees(+19.43653938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349209"},
        {"Hipparcos Number", "HIP 91604"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.22376479),
        dec: Angle.Degrees(+19.43869231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87412"},
        {"Hipparcos Number", "HIP 49410"},
        {"Geneva Identification System", "GEN# +1.00087412"},
        {"Smithsonian Astrophysical Observation", "SAO 98938"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.29849846),
        dec: Angle.Degrees(+19.43919639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80612"},
        {"Hipparcos Number", "HIP 45886"},
        {"Smithsonian Astrophysical Observation", "SAO 98518"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.34400648),
        dec: Angle.Degrees(+19.44013900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47140"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.08466443),
        dec: Angle.Degrees(+19.44181471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19082"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.35664593),
        dec: Angle.Degrees(+19.44223093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74325"},
        {"Smithsonian Astrophysical Observation", "SAO 101421"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.87161758),
        dec: Angle.Degrees(+19.44528695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110905"},
        {"Smithsonian Astrophysical Observation", "SAO 107940"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.04263550),
        dec: Angle.Degrees(+19.44724736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168386"},
        {"Hipparcos Number", "HIP 89714"},
        {"Smithsonian Astrophysical Observation", "SAO 103591"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.64020682),
        dec: Angle.Degrees(+19.45060839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61938"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.39842525),
        dec: Angle.Degrees(+19.45111258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40836"},
        {"Fundamental Katalog 5th Edition", "FK5 4748"},
        {"Smithsonian Astrophysical Observation", "SAO 97730"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00596456),
        dec: Angle.Degrees(+19.45324249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285348"},
        {"Hipparcos Number", "HIP 18946"},
        {"Geneva Identification System", "GEN# +5.20252011"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91235280),
        dec: Angle.Degrees(+19.45509359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43607"},
        {"Hipparcos Number", "HIP 29909"},
        {"Celescope Catalog", "CEL 1162"},
        {"Geneva Identification System", "GEN# +1.00043607"},
        {"Smithsonian Astrophysical Observation", "SAO 95495"},
        {"Wilson Evans Batten Catalogue", "WEB 5923"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.46194584),
        dec: Angle.Degrees(+19.45720682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163440"},
        {"Hipparcos Number", "HIP 87737"},
        {"Smithsonian Astrophysical Observation", "SAO 103218"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.83399600),
        dec: Angle.Degrees(+19.45756823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9072 A"},
        {"Henry Draper", "HD 121906"},
        {"Hipparcos Number", "HIP 68237"},
        {"Smithsonian Astrophysical Observation", "SAO 100797"},
        {"Wilson Evans Batten Catalogue", "WEB 11969"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.53096353),
        dec: Angle.Degrees(+19.45844645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257415"},
        {"Henry Draper 2", "HD 257416"},
        {"Hipparcos Number", "HIP 30734"},
        {"Smithsonian Astrophysical Observation", "SAO 95698"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.85092724),
        dec: Angle.Degrees(+19.45893114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8371"},
        {"Smithsonian Astrophysical Observation", "SAO 92635"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.95213140),
        dec: Angle.Degrees(+19.46104135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251761"},
        {"Hipparcos Number", "HIP 28979"},
        {"Smithsonian Astrophysical Observation", "SAO 95239"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73392241),
        dec: Angle.Degrees(+19.46253479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171167"},
        {"Hipparcos Number", "HIP 90889"},
        {"Smithsonian Astrophysical Observation", "SAO 103826"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.09049112),
        dec: Angle.Degrees(+19.46307134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214808"},
        {"Hipparcos Number", "HIP 111935"},
        {"Smithsonian Astrophysical Observation", "SAO 108086"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.11028015),
        dec: Angle.Degrees(+19.46470191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185152"},
        {"Hipparcos Number", "HIP 96492"},
        {"Smithsonian Astrophysical Observation", "SAO 105051"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.23624211),
        dec: Angle.Degrees(+19.46496940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91816",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11609 A"},
        {"Henry Draper", "HD 173171"},
        {"Hipparcos Number", "HIP 91816"},
        {"Smithsonian Astrophysical Observation", "SAO 104023"},
        {"Wilson Evans Batten Catalogue", "WEB 15796"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.81035256),
        dec: Angle.Degrees(+19.46645366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123711"},
        {"Hipparcos Number", "HIP 69116"},
        {"Smithsonian Astrophysical Observation", "SAO 100872"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.22488638),
        dec: Angle.Degrees(+19.46726384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59247"},
        {"Geneva Identification System", "GEN# +9.80059002"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.30399553),
        dec: Angle.Degrees(+19.46837530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27560"},
        {"Hipparcos Number", "HIP 20369"},
        {"Geneva Identification System", "GEN# +1.00027560"},
        {"Smithsonian Astrophysical Observation", "SAO 93887"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.42729938),
        dec: Angle.Degrees(+19.46853245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87041"},
        {"Smithsonian Astrophysical Observation", "SAO 103107"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.78058871),
        dec: Angle.Degrees(+19.46957478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89449"},
        {"Hipparcos Number", "HIP 50564"},
        {"Geneva Identification System", "GEN# +1.00089449"},
        {"Smithsonian Astrophysical Observation", "SAO 99065"},
        {"Wilson Evans Batten Catalogue", "WEB 9275"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.93462599),
        dec: Angle.Degrees(+19.47143591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210074"},
        {"Hipparcos Number", "HIP 109209"},
        {"Geneva Identification System", "GEN# +1.00210074"},
        {"Smithsonian Astrophysical Observation", "SAO 107675"},
        {"Wilson Evans Batten Catalogue", "WEB 19630"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.86882240),
        dec: Angle.Degrees(+19.47543631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81066"},
        {"Hipparcos Number", "HIP 46104"},
        {"Smithsonian Astrophysical Observation", "SAO 98547"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.02866948),
        dec: Angle.Degrees(+19.47562758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20737"},
        {"Hipparcos Number", "HIP 15612"},
        {"Geneva Identification System", "GEN# +1.00020737"},
        {"Smithsonian Astrophysical Observation", "SAO 93400"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.25528932),
        dec: Angle.Degrees(+19.47639989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207164"},
        {"Hipparcos Number", "HIP 107528"},
        {"Geneva Identification System", "GEN# +1.00207164"},
        {"Smithsonian Astrophysical Observation", "SAO 107393"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.68066918),
        dec: Angle.Degrees(+19.47709600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71914",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9352 AB"},
        {"Hipparcos Number", "HIP 71914"},
        {"Geneva Identification System", "GEN# +0.02003010"},
        {"Wilson Evans Batten Catalogue", "WEB 12386"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64085699),
        dec: Angle.Degrees(+19.48015622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -253.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137510"},
        {"Hipparcos Number", "HIP 75535"},
        {"Geneva Identification System", "GEN# +1.00137510"},
        {"Smithsonian Astrophysical Observation", "SAO 101548"},
        {"Wilson Evans Batten Catalogue", "WEB 12872"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.47209605),
        dec: Angle.Degrees(+19.48072447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112060"},
        {"Hipparcos Number", "HIP 62904"},
        {"Fundamental Katalog 5th Edition", "FK5 3026"},
        {"Geneva Identification System", "GEN# +1.00112060"},
        {"Smithsonian Astrophysical Observation", "SAO 100321"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.38416881),
        dec: Angle.Degrees(+19.48149121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2815"},
        {"Hipparcos Number", "HIP 2502"},
        {"Geneva Identification System", "GEN# +1.00002815"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.93099734),
        dec: Angle.Degrees(+19.48209050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74861"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.47330879),
        dec: Angle.Degrees(+19.48214272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -324.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4605"},
        {"Hipparcos Number", "HIP 3749"},
        {"Smithsonian Astrophysical Observation", "SAO 92092"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.03401593),
        dec: Angle.Degrees(+19.48358299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108945"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.07817035),
        dec: Angle.Degrees(+19.48385348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99223"},
        {"Hipparcos Number", "HIP 55737"},
        {"Smithsonian Astrophysical Observation", "SAO 99600"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.30635357),
        dec: Angle.Degrees(+19.48426988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106072"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.27674027),
        dec: Angle.Degrees(+19.48472656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31236"},
        {"Hipparcos Number", "HIP 22850"},
        {"Geneva Identification System", "GEN# +5.20250126"},
        {"Smithsonian Astrophysical Observation", "SAO 94199"},
        {"Wilson Evans Batten Catalogue", "WEB 4427"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.74301084),
        dec: Angle.Degrees(+19.48545720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176438"},
        {"Hipparcos Number", "HIP 93243"},
        {"Celescope Catalog", "CEL 4681"},
        {"Geneva Identification System", "GEN# +1.00176438"},
        {"Smithsonian Astrophysical Observation", "SAO 104322"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.90183119),
        dec: Angle.Degrees(+19.48646472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53375"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.73971082),
        dec: Angle.Degrees(+19.48676527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189319"},
        {"Hipparcos Number", "HIP 98337"},
        {"Fundamental Katalog 5th Edition", "FK5 752"},
        {"Geneva Identification System", "GEN# +1.00189319"},
        {"Smithsonian Astrophysical Observation", "SAO 105500"},
        {"Wilson Evans Batten Catalogue", "WEB 17348"},
    },
    visualMagnitude: 3.51,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.68911516),
        dec: Angle.Degrees(+19.49209287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7230"},
        {"Smithsonian Astrophysical Observation", "SAO 92506"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.29836541),
        dec: Angle.Degrees(+19.49223250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30233"},
        {"Hipparcos Number", "HIP 22211"},
        {"Smithsonian Astrophysical Observation", "SAO 94115"},
        {"New General Catalogue", "NGC 1647 105"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.64957064),
        dec: Angle.Degrees(+19.49425356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193797"},
        {"Hipparcos Number", "HIP 100397"},
        {"Smithsonian Astrophysical Observation", "SAO 106021"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.39870445),
        dec: Angle.Degrees(+19.49447334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109293"},
        {"Smithsonian Astrophysical Observation", "SAO 107686"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.11139854),
        dec: Angle.Degrees(+19.49498631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102081"},
        {"Hipparcos Number", "HIP 57307"},
        {"Geneva Identification System", "GEN# +1.00102081"},
        {"Smithsonian Astrophysical Observation", "SAO 99769"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.25603653),
        dec: Angle.Degrees(+19.50011888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13325"},
        {"Hipparcos Number", "HIP 10155"},
        {"Fundamental Katalog 5th Edition", "FK5 1056"},
        {"Geneva Identification System", "GEN# +1.00013325"},
        {"Smithsonian Astrophysical Observation", "SAO 92822"},
        {"Wilson Evans Batten Catalogue", "WEB 2120"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.65642510),
        dec: Angle.Degrees(+19.50040351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109936"},
        {"Smithsonian Astrophysical Observation", "SAO 107780"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.99179028),
        dec: Angle.Degrees(+19.50276424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71904"},
        {"Wilson Evans Batten Catalogue", "WEB 12384"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.61008101),
        dec: Angle.Degrees(+19.50395713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -260.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164447"},
        {"Hipparcos Number", "HIP 88172"},
        {"Geneva Identification System", "GEN# +1.00164447"},
        {"Smithsonian Astrophysical Observation", "SAO 103291"},
        {"Wilson Evans Batten Catalogue", "WEB 14899"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.11522556),
        dec: Angle.Degrees(+19.50578365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147769"},
        {"Hipparcos Number", "HIP 80257"},
        {"Smithsonian Astrophysical Observation", "SAO 102118"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.76910106),
        dec: Angle.Degrees(+19.50594809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95552"},
        {"Hipparcos Number", "HIP 53916"},
        {"Geneva Identification System", "GEN# +1.00095552"},
        {"Smithsonian Astrophysical Observation", "SAO 99407"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.48628378),
        dec: Angle.Degrees(+19.50732023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218564"},
        {"Hipparcos Number", "HIP 114283"},
        {"Smithsonian Astrophysical Observation", "SAO 108427"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.20558723),
        dec: Angle.Degrees(+19.50939202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80769"},
        {"Geneva Identification System", "GEN# +0.01903109"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.36252791),
        dec: Angle.Degrees(+19.50958608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126427"},
        {"Hipparcos Number", "HIP 70481"},
        {"Smithsonian Astrophysical Observation", "SAO 101016"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.24865029),
        dec: Angle.Degrees(+19.51021499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130767"},
        {"Hipparcos Number", "HIP 72505"},
        {"Geneva Identification System", "GEN# +1.00130767"},
        {"Smithsonian Astrophysical Observation", "SAO 101233"},
        {"Wilson Evans Batten Catalogue", "WEB 12463"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.36973914),
        dec: Angle.Degrees(+19.51038333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90460"},
        {"Hipparcos Number", "HIP 51147"},
        {"Smithsonian Astrophysical Observation", "SAO 99125"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.72592120),
        dec: Angle.Degrees(+19.51246529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2410"},
        {"Hipparcos Number", "HIP 2213"},
        {"Smithsonian Astrophysical Observation", "SAO 91909"},
        {"Wilson Evans Batten Catalogue", "WEB 411"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.99366564),
        dec: Angle.Degrees(+19.51408099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197644"},
        {"Hipparcos Number", "HIP 102368"},
        {"Smithsonian Astrophysical Observation", "SAO 106437"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.12569016),
        dec: Angle.Degrees(+19.51439389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230297"},
        {"Hipparcos Number", "HIP 93172"},
        {"Smithsonian Astrophysical Observation", "SAO 104305"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.67382901),
        dec: Angle.Degrees(+19.51718809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73175"},
        {"Hipparcos Number", "HIP 42319"},
        {"Geneva Identification System", "GEN# +2.26320045"},
        {"Smithsonian Astrophysical Observation", "SAO 97975"},
        {"Wilson Evans Batten Catalogue", "WEB 8132"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41970406),
        dec: Angle.Degrees(+19.51844985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56987"},
        {"Hipparcos Number", "HIP 35537"},
        {"Smithsonian Astrophysical Observation", "SAO 96781"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.01063556),
        dec: Angle.Degrees(+19.52088503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 885"},
        {"Hipparcos Number", "HIP 1070"},
        {"Smithsonian Astrophysical Observation", "SAO 91782"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.32212808),
        dec: Angle.Degrees(+19.52127377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39227"},
        {"Hipparcos Number", "HIP 27697"},
        {"Celescope Catalog", "CEL 1005"},
        {"Geneva Identification System", "GEN# +1.00039227"},
        {"Smithsonian Astrophysical Observation", "SAO 94934"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.96704819),
        dec: Angle.Degrees(+19.52138649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158955"},
        {"Hipparcos Number", "HIP 85744"},
        {"Smithsonian Astrophysical Observation", "SAO 102883"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.82800896),
        dec: Angle.Degrees(+19.52206843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214567"},
        {"Hipparcos Number", "HIP 111810"},
        {"Fundamental Katalog 5th Edition", "FK5 5997"},
        {"Geneva Identification System", "GEN# +1.00214567"},
        {"Smithsonian Astrophysical Observation", "SAO 108064"},
        {"Wilson Evans Batten Catalogue", "WEB 19974"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.71924203),
        dec: Angle.Degrees(+19.52249181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146588"},
        {"Hipparcos Number", "HIP 79720"},
        {"Geneva Identification System", "GEN# +1.00146588"},
        {"Smithsonian Astrophysical Observation", "SAO 102051"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.06068122),
        dec: Angle.Degrees(+19.52412551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 265.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101369"},
        {"Geneva Identification System", "GEN# +9.80144009"},
    },
    visualMagnitude: 11.63,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.17945509),
        dec: Angle.Degrees(+19.52740233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -365.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48566"},
        {"Hipparcos Number", "HIP 32324"},
        {"Geneva Identification System", "GEN# +1.00048566"},
        {"Smithsonian Astrophysical Observation", "SAO 96058"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.21885355),
        dec: Angle.Degrees(+19.52763157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348024"},
        {"Hipparcos Number", "HIP 89078"},
        {"Smithsonian Astrophysical Observation", "SAO 103457"},
    },
    visualMagnitude: 9.54,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.69405182),
        dec: Angle.Degrees(+19.52802243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196036"},
        {"Hipparcos Number", "HIP 101512"},
        {"Smithsonian Astrophysical Observation", "SAO 106259"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.56810119),
        dec: Angle.Degrees(+19.53056854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101587"},
        {"Hipparcos Number", "HIP 57030"},
        {"Geneva Identification System", "GEN# +1.00101587"},
        {"Smithsonian Astrophysical Observation", "SAO 99736"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.39452752),
        dec: Angle.Degrees(+19.53076462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100373"},
        {"Hipparcos Number", "HIP 56345"},
        {"Geneva Identification System", "GEN# +1.00100373"},
        {"Smithsonian Astrophysical Observation", "SAO 99657"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.25854419),
        dec: Angle.Degrees(+19.53411823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20390",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "T Tau A"},
        {"Common Name 2", "T Tau N"},
        {"Common Name 3", "T Tau S"},
        {"Common Name 4", "T Tau IRC"},
        {"Henry Draper", "HD 284419"},
        {"Hipparcos Number", "HIP 20390"},
        {"Wilson Evans Batten Catalogue", "WEB 3899"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.49760367),
        dec: Angle.Degrees(+19.53514937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209182"},
        {"Hipparcos Number", "HIP 108690"},
        {"Renson", "Renson 58190"},
        {"Smithsonian Astrophysical Observation", "SAO 107588"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.26811509),
        dec: Angle.Degrees(+19.53873220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26572"},
        {"Hipparcos Number", "HIP 19669"},
        {"Smithsonian Astrophysical Observation", "SAO 93814"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.20441786),
        dec: Angle.Degrees(+19.53880776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89618"},
        {"Hipparcos Number", "HIP 50663"},
        {"Geneva Identification System", "GEN# +1.00089618"},
        {"Smithsonian Astrophysical Observation", "SAO 99075"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.19917977),
        dec: Angle.Degrees(+19.53900549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42497",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6915 D"},
        {"Henry Draper", "HD 73598"},
        {"Hipparcos Number", "HIP 42497"},
        {"Geneva Identification System", "GEN# +2.26320212"},
        {"Smithsonian Astrophysical Observation", "SAO 98010"},
        {"Wilson Evans Batten Catalogue", "WEB 8180"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.96140184),
        dec: Angle.Degrees(+19.54084479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192167"},
        {"Hipparcos Number", "HIP 99610"},
        {"Smithsonian Astrophysical Observation", "SAO 105842"},
        {"Wilson Evans Batten Catalogue", "WEB 17838"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.22465120),
        dec: Angle.Degrees(+19.54430667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42556",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Meleph"},
        {"Henry Draper", "HD 73731"},
        {"Hipparcos Number", "HIP 42556"},
        {"Geneva Identification System", "GEN# +1.00073731"},
        {"Geneva Identification System 2", "GEN# +2.26320300"},
        {"Renson", "Renson 20550"},
        {"Smithsonian Astrophysical Observation", "SAO 98024"},
        {"Wilson Evans Batten Catalogue", "WEB 8210"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.11263537),
        dec: Angle.Degrees(+19.54484056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54321"},
        {"Hipparcos Number", "HIP 34520"},
        {"Smithsonian Astrophysical Observation", "SAO 96558"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.28633601),
        dec: Angle.Degrees(+19.54666205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86743"},
        {"Smithsonian Astrophysical Observation", "SAO 103055"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.87449758),
        dec: Angle.Degrees(+19.54675227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56484"},
        {"Hipparcos Number", "HIP 35331"},
        {"Geneva Identification System", "GEN# +1.00056484"},
        {"Renson", "Renson 15423"},
        {"Smithsonian Astrophysical Observation", "SAO 96739"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.46972785),
        dec: Angle.Degrees(+19.54714676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163149"},
        {"Hipparcos Number", "HIP 87628"},
        {"Smithsonian Astrophysical Observation", "SAO 103193"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.50243533),
        dec: Angle.Degrees(+19.54743815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223038"},
        {"Hipparcos Number", "HIP 117214"},
        {"Geneva Identification System", "GEN# +1.00223038"},
        {"Smithsonian Astrophysical Observation", "SAO 108817"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.49937598),
        dec: Angle.Degrees(+19.54909675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36975"},
        {"Hipparcos Number", "HIP 26298"},
        {"Smithsonian Astrophysical Observation", "SAO 94684"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.01080407),
        dec: Angle.Degrees(+19.54943246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81419"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.43867128),
        dec: Angle.Degrees(+19.55063650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36336"},
        {"Hipparcos Number", "HIP 25908"},
        {"Smithsonian Astrophysical Observation", "SAO 94620"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.94269910),
        dec: Angle.Degrees(+19.55120980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15014"},
        {"Hipparcos Number", "HIP 11316"},
        {"Smithsonian Astrophysical Observation", "SAO 92940"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.41554232),
        dec: Angle.Degrees(+19.55440945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58939"},
        {"Cincinnati Publication", "Ci 18 1496"},
        {"Smithsonian Astrophysical Observation", "SAO 99932"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.28008302),
        dec: Angle.Degrees(+19.55446399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -288.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112768"},
        {"Hipparcos Number", "HIP 63352"},
        {"Geneva Identification System", "GEN# +1.00112768"},
        {"Smithsonian Astrophysical Observation", "SAO 100356"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.72513155),
        dec: Angle.Degrees(+19.55587117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165042"},
        {"Hipparcos Number", "HIP 88434"},
        {"Geneva Identification System", "GEN# +1.00165042"},
        {"Smithsonian Astrophysical Observation", "SAO 103336"},
        {"Wilson Evans Batten Catalogue", "WEB 14953"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.83571891),
        dec: Angle.Degrees(+19.55588783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150048"},
        {"Hipparcos Number", "HIP 81418"},
        {"Smithsonian Astrophysical Observation", "SAO 102279"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.43341918),
        dec: Angle.Degrees(+19.55688683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58467"},
        {"Geneva Identification System", "GEN# +0.02002662"},
        {"Smithsonian Astrophysical Observation", "SAO 99896"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.85148075),
        dec: Angle.Degrees(+19.55743725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 502"},
        {"Hipparcos Number", "HIP 773"},
        {"Geneva Identification System", "GEN# +1.00000502"},
        {"Smithsonian Astrophysical Observation", "SAO 91744"},
        {"Wilson Evans Batten Catalogue", "WEB 132"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.37919673),
        dec: Angle.Degrees(+19.55922468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22329"},
        {"Hipparcos Number", "HIP 16808"},
        {"Smithsonian Astrophysical Observation", "SAO 93506"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.08941957),
        dec: Angle.Degrees(+19.55937896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216724"},
        {"Hipparcos Number", "HIP 113173"},
        {"Smithsonian Astrophysical Observation", "SAO 108255"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.75408469),
        dec: Angle.Degrees(+19.55979036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196811"},
        {"Hipparcos Number", "HIP 101915"},
        {"Smithsonian Astrophysical Observation", "SAO 106349"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.78044233),
        dec: Angle.Degrees(+19.56008163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27109"},
        {"Hipparcos Number", "HIP 20018"},
        {"Smithsonian Astrophysical Observation", "SAO 93844"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.40908024),
        dec: Angle.Degrees(+19.56095360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56399"},
        {"Smithsonian Astrophysical Observation", "SAO 99663"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.43781877),
        dec: Angle.Degrees(+19.56268302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188972"},
        {"Hipparcos Number", "HIP 98175"},
        {"Geneva Identification System", "GEN# +1.00188972"},
        {"Smithsonian Astrophysical Observation", "SAO 105456"},
        {"Wilson Evans Batten Catalogue", "WEB 17308"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.27639894),
        dec: Angle.Degrees(+19.56408007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23966"},
        {"Hipparcos Number", "HIP 17920"},
        {"Smithsonian Astrophysical Observation", "SAO 93627"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.47868511),
        dec: Angle.Degrees(+19.56639520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91349"},
        {"Hipparcos Number", "HIP 51644"},
        {"Smithsonian Astrophysical Observation", "SAO 99178"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.27247667),
        dec: Angle.Degrees(+19.56644584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45137"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.95102752),
        dec: Angle.Degrees(+19.56885933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100638",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13808 A"},
        {"Henry Draper", "HD 194318"},
        {"Hipparcos Number", "HIP 100638"},
        {"Smithsonian Astrophysical Observation", "SAO 106068"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.09413707),
        dec: Angle.Degrees(+19.57499971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43722"},
        {"Smithsonian Astrophysical Observation", "SAO 98212"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.56148622),
        dec: Angle.Degrees(+19.57551487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18485"},
        {"Hipparcos Number", "HIP 13893"},
        {"Smithsonian Astrophysical Observation", "SAO 93217"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.72721173),
        dec: Angle.Degrees(+19.57607453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13808 B"},
        {"Henry Draper", "HD 194318B"},
        {"Hipparcos Number", "HIP 100640"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.10104973),
        dec: Angle.Degrees(+19.57645582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34719"},
        {"Hipparcos Number", "HIP 24906"},
        {"Geneva Identification System", "GEN# +1.00034719"},
        {"Renson", "Renson 8850"},
        {"Smithsonian Astrophysical Observation", "SAO 94467"},
        {"Wilson Evans Batten Catalogue", "WEB 4824"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.07621707),
        dec: Angle.Degrees(+19.57826161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4490"},
        {"Hipparcos Number", "HIP 3685"},
        {"Fundamental Katalog 5th Edition", "FK5 2051"},
        {"Geneva Identification System", "GEN# +1.00004490"},
        {"Smithsonian Astrophysical Observation", "SAO 92082"},
        {"Wilson Evans Batten Catalogue", "WEB 653"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.80650093),
        dec: Angle.Degrees(+19.57868622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26720"},
        {"Hipparcos Number", "HIP 19772"},
        {"Geneva Identification System", "GEN# +1.00026720"},
        {"Smithsonian Astrophysical Observation", "SAO 93826"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.58724015),
        dec: Angle.Degrees(+19.57978471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73819"},
        {"Hipparcos Number", "HIP 42600"},
        {"Geneva Identification System", "GEN# +2.26320348"},
        {"Geneva Identification System 2", "GEN# +1.00073819"},
        {"Smithsonian Astrophysical Observation", "SAO 98032"},
        {"Wilson Evans Batten Catalogue", "WEB 8223"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.23466553),
        dec: Angle.Degrees(+19.58036383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190772"},
        {"Hipparcos Number", "HIP 99004"},
        {"Geneva Identification System", "GEN# +1.00190772"},
        {"Smithsonian Astrophysical Observation", "SAO 105682"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.49421720),
        dec: Angle.Degrees(+19.58090686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61795"},
        {"Geneva Identification System", "GEN# +0.02002752"},
        {"Smithsonian Astrophysical Observation", "SAO 100197"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.98262479),
        dec: Angle.Degrees(+19.58530503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70902"},
        {"Smithsonian Astrophysical Observation", "SAO 101056"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.47451019),
        dec: Angle.Degrees(+19.58565382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37412"},
        {"Geneva Identification System", "GEN# +9.80088046"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21383512),
        dec: Angle.Degrees(+19.58964690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -351.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350215"},
        {"Hipparcos Number", "HIP 96722"},
        {"Geneva Identification System", "GEN# +1.00350215"},
        {"Smithsonian Astrophysical Observation", "SAO 105111"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.92457381),
        dec: Angle.Degrees(+19.58980212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72779"},
        {"Hipparcos Number", "HIP 42133"},
        {"Geneva Identification System", "GEN# +2.26321133"},
        {"Smithsonian Astrophysical Observation", "SAO 97928"},
        {"Wilson Evans Batten Catalogue", "WEB 8095"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.83111464),
        dec: Angle.Degrees(+19.59009383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12824"},
    },
    visualMagnitude: 10.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.21741530),
        dec: Angle.Degrees(+19.59121550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103121",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14402 A"},
        {"Henry Draper", "HD 199008"},
        {"Hipparcos Number", "HIP 103121"},
        {"Smithsonian Astrophysical Observation", "SAO 106626"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.41018989),
        dec: Angle.Degrees(+19.59169762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284726"},
        {"Hipparcos Number", "HIP 21831"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.39844612),
        dec: Angle.Degrees(+19.59254229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153669"},
        {"Hipparcos Number", "HIP 83180"},
        {"Geneva Identification System", "GEN# +1.00153669"},
        {"Smithsonian Astrophysical Observation", "SAO 102521"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.00530321),
        dec: Angle.Degrees(+19.59342614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180188"},
        {"Hipparcos Number", "HIP 94578"},
        {"Smithsonian Astrophysical Observation", "SAO 104645"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.71705498),
        dec: Angle.Degrees(+19.59363840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50509"},
        {"Hipparcos Number", "HIP 33181"},
        {"Smithsonian Astrophysical Observation", "SAO 96253"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.59228089),
        dec: Angle.Degrees(+19.59521804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81080"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.40601238),
        dec: Angle.Degrees(+19.59547148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47379"},
        {"Hipparcos Number", "HIP 31810"},
        {"Geneva Identification System", "GEN# +1.00047379"},
        {"Smithsonian Astrophysical Observation", "SAO 95943"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.76353463),
        dec: Angle.Degrees(+19.59553474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285280"},
        {"Hipparcos Number", "HIP 18784"},
        {"Smithsonian Astrophysical Observation", "SAO 93725"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.36883761),
        dec: Angle.Degrees(+19.59653967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18091"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.00332247),
        dec: Angle.Degrees(+19.59697038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83565",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10326 AB"},
        {"Henry Draper", "HD 154441"},
        {"Hipparcos Number", "HIP 83565"},
        {"Geneva Identification System", "GEN# +1.00154441J"},
        {"Smithsonian Astrophysical Observation", "SAO 102579"},
        {"Wilson Evans Batten Catalogue", "WEB 14125"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.17224125),
        dec: Angle.Degrees(+19.59910193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95807"},
        {"Hipparcos Number", "HIP 54050"},
        {"Smithsonian Astrophysical Observation", "SAO 99419"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.90471242),
        dec: Angle.Degrees(+19.60035242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348783"},
        {"Hipparcos Number", "HIP 90862"},
        {"Smithsonian Astrophysical Observation", "SAO 103821"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.03338289),
        dec: Angle.Degrees(+19.60195630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254209"},
        {"Hipparcos Number", "HIP 29786"},
        {"Smithsonian Astrophysical Observation", "SAO 95464"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.07161188),
        dec: Angle.Degrees(+19.60261648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104078"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.28919578),
        dec: Angle.Degrees(+19.60304508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -567.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111997"},
        {"Hipparcos Number", "HIP 62860"},
        {"Geneva Identification System", "GEN# +1.00111997"},
        {"Smithsonian Astrophysical Observation", "SAO 100317"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.26630308),
        dec: Angle.Degrees(+19.60507029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85069"},
        {"Hipparcos Number", "HIP 48230"},
        {"Smithsonian Astrophysical Observation", "SAO 98797"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.49723161),
        dec: Angle.Degrees(+19.60558908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210500"},
        {"Hipparcos Number", "HIP 109456"},
        {"Smithsonian Astrophysical Observation", "SAO 107711"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.62455563),
        dec: Angle.Degrees(+19.60668258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230999"},
        {"Hipparcos Number", "HIP 94615"},
        {"Geneva Identification System", "GEN# +1.00230999"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.80992762),
        dec: Angle.Degrees(+19.60921047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26162"},
        {"Hipparcos Number", "HIP 19388"},
        {"Fundamental Katalog 5th Edition", "FK5 1115"},
        {"Geneva Identification System", "GEN# +1.00026162"},
        {"Smithsonian Astrophysical Observation", "SAO 93785"},
        {"Wilson Evans Batten Catalogue", "WEB 3723"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.29125233),
        dec: Angle.Degrees(+19.60929366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181182"},
        {"Henry Draper 2", "HD 181182B"},
        {"Hipparcos Number", "HIP 94910"},
        {"Geneva Identification System", "GEN# +1.00181182"},
        {"Smithsonian Astrophysical Observation", "SAO 104711"},
        {"Wilson Evans Batten Catalogue", "WEB 16569"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.70170105),
        dec: Angle.Degrees(+19.61047566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165029"},
        {"Hipparcos Number", "HIP 88429"},
        {"Geneva Identification System", "GEN# +1.00165029"},
        {"Smithsonian Astrophysical Observation", "SAO 103334"},
        {"Wilson Evans Batten Catalogue", "WEB 14948"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.81068909),
        dec: Angle.Degrees(+19.61315807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13682"},
        {"Hipparcos Number", "HIP 10390"},
        {"Smithsonian Astrophysical Observation", "SAO 92846"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.46540269),
        dec: Angle.Degrees(+19.61443211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112234"},
        {"Hipparcos Number", "HIP 63043"},
        {"Geneva Identification System", "GEN# +1.00112234"},
        {"Smithsonian Astrophysical Observation", "SAO 100332"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.77158886),
        dec: Angle.Degrees(+19.61489420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92126"},
        {"Hipparcos Number", "HIP 52082"},
        {"Geneva Identification System", "GEN# +1.00092126"},
        {"Smithsonian Astrophysical Observation", "SAO 99224"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.63678547),
        dec: Angle.Degrees(+19.61513624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210460"},
        {"Hipparcos Number", "HIP 109439"},
        {"Geneva Identification System", "GEN# +1.00210460"},
        {"Smithsonian Astrophysical Observation", "SAO 107706"},
        {"Wilson Evans Batten Catalogue", "WEB 19662"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.57901866),
        dec: Angle.Degrees(+19.61656699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194913"},
        {"Hipparcos Number", "HIP 100906"},
        {"Smithsonian Astrophysical Observation", "SAO 106129"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.89175384),
        dec: Angle.Degrees(+19.61815413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161020"},
        {"Hipparcos Number", "HIP 86656"},
        {"Smithsonian Astrophysical Observation", "SAO 103041"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.58653318),
        dec: Angle.Degrees(+19.61941772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114922"},
        {"Geneva Identification System", "GEN# +9.80067052"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.16596408),
        dec: Angle.Degrees(+19.62185061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95047"},
        {"Hipparcos Number", "HIP 53654"},
        {"Fundamental Katalog 5th Edition", "FK5 4969"},
        {"Smithsonian Astrophysical Observation", "SAO 99384"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.65626500),
        dec: Angle.Degrees(+19.62208803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6299"},
        {"Smithsonian Astrophysical Observation", "SAO 92382"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.21189672),
        dec: Angle.Degrees(+19.62285081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213618"},
        {"Hipparcos Number", "HIP 111263"},
        {"Smithsonian Astrophysical Observation", "SAO 107984"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.11431474),
        dec: Angle.Degrees(+19.62352879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97874"},
        {"Hipparcos Number", "HIP 54993"},
        {"Smithsonian Astrophysical Observation", "SAO 99523"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.90097339),
        dec: Angle.Degrees(+19.62376239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14484"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.74497901),
        dec: Angle.Degrees(+19.62825079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143919"},
        {"Hipparcos Number", "HIP 78561"},
        {"Geneva Identification System", "GEN# +1.00143919"},
        {"Smithsonian Astrophysical Observation", "SAO 101887"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.61210116),
        dec: Angle.Degrees(+19.62998114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14785"},
        {"Hipparcos Number", "HIP 11157"},
        {"Geneva Identification System", "GEN# +1.00014785"},
        {"Smithsonian Astrophysical Observation", "SAO 92917"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.88425843),
        dec: Angle.Degrees(+19.63204952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113002"},
        {"Hipparcos Number", "HIP 63484"},
        {"Geneva Identification System", "GEN# +1.00113002"},
        {"Smithsonian Astrophysical Observation", "SAO 100365"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.12018862),
        dec: Angle.Degrees(+19.63225496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59149"},
        {"Hipparcos Number", "HIP 36411"},
        {"Fundamental Katalog 5th Edition", "FK5 2577"},
        {"Geneva Identification System", "GEN# +1.00059149"},
        {"Smithsonian Astrophysical Observation", "SAO 96945"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.37804982),
        dec: Angle.Degrees(+19.63318126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219196"},
        {"Hipparcos Number", "HIP 114686"},
        {"Smithsonian Astrophysical Observation", "SAO 108472"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.49726566),
        dec: Angle.Degrees(+19.63391636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147952"},
        {"Hipparcos Number", "HIP 80334"},
        {"Geneva Identification System", "GEN# +1.00147952"},
        {"Smithsonian Astrophysical Observation", "SAO 102134"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.00247568),
        dec: Angle.Degrees(+19.63457024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206701"},
        {"Hipparcos Number", "HIP 107258"},
        {"Geneva Identification System", "GEN# +1.00206701"},
        {"Smithsonian Astrophysical Observation", "SAO 107354"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.87457985),
        dec: Angle.Degrees(+19.63566825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85066"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.77579321),
        dec: Angle.Degrees(+19.63596931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66180"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.46146510),
        dec: Angle.Degrees(+19.63922414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73905"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.56381743),
        dec: Angle.Degrees(+19.64205203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151329"},
        {"Hipparcos Number", "HIP 82059"},
        {"Geneva Identification System", "GEN# +1.00151329"},
        {"Smithsonian Astrophysical Observation", "SAO 102370"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.43282105),
        dec: Angle.Degrees(+19.64251531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2841"},
        {"Hipparcos Number", "HIP 2517"},
        {"Smithsonian Astrophysical Observation", "SAO 91949"},
        {"Wilson Evans Batten Catalogue", "WEB 460"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.97866946),
        dec: Angle.Degrees(+19.64295811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135869"},
        {"Hipparcos Number", "HIP 74781"},
        {"Smithsonian Astrophysical Observation", "SAO 101474"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.24568158),
        dec: Angle.Degrees(+19.64552122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55694"},
        {"Smithsonian Astrophysical Observation", "SAO 99596"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.17527980),
        dec: Angle.Degrees(+19.65174715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36319"},
        {"Cincinnati Publication", "Ci 18 892"},
        {"Geneva Identification System", "GEN# +0.01901739"},
        {"Smithsonian Astrophysical Observation", "SAO 96927"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.13957322),
        dec: Angle.Degrees(+19.65364738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47574"},
        {"Hipparcos Number", "HIP 31896"},
        {"Smithsonian Astrophysical Observation", "SAO 95968"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.00872356),
        dec: Angle.Degrees(+19.65794582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6903"},
        {"Hipparcos Number", "HIP 5454"},
        {"Geneva Identification System", "GEN# +1.00006903"},
        {"Smithsonian Astrophysical Observation", "SAO 92283"},
        {"Wilson Evans Batten Catalogue", "WEB 1196"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.45502008),
        dec: Angle.Degrees(+19.65838540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284414"},
        {"Hipparcos Number", "HIP 20482"},
        {"Geneva Identification System", "GEN# +5.20250043"},
        {"Smithsonian Astrophysical Observation", "SAO 93898"},
        {"Wilson Evans Batten Catalogue", "WEB 3918"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.84495355),
        dec: Angle.Degrees(+19.65875512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87499"},
        {"Smithsonian Astrophysical Observation", "SAO 103171"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.16974791),
        dec: Angle.Degrees(+19.65969606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107825"},
        {"Hipparcos Number", "HIP 60423"},
        {"Geneva Identification System", "GEN# +1.00107825"},
        {"Smithsonian Astrophysical Observation", "SAO 100072"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.83618524),
        dec: Angle.Degrees(+19.66003846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177199"},
        {"Hipparcos Number", "HIP 93523"},
        {"Fundamental Katalog 5th Edition", "FK5 3521"},
        {"Geneva Identification System", "GEN# +1.00177199"},
        {"Smithsonian Astrophysical Observation", "SAO 104405"},
        {"Wilson Evans Batten Catalogue", "WEB 16241"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.71923778),
        dec: Angle.Degrees(+19.66101428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187320"},
        {"Hipparcos Number", "HIP 97478"},
        {"Geneva Identification System", "GEN# +1.00187320"},
        {"Smithsonian Astrophysical Observation", "SAO 105289"},
        {"Wilson Evans Batten Catalogue", "WEB 17134"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.18437659),
        dec: Angle.Degrees(+19.66108044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193773"},
        {"Hipparcos Number", "HIP 100381"},
        {"Geneva Identification System", "GEN# +1.00193773"},
        {"Smithsonian Astrophysical Observation", "SAO 106015"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37103974),
        dec: Angle.Degrees(+19.66203902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111384"},
        {"Smithsonian Astrophysical Observation", "SAO 108001"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.48999159),
        dec: Angle.Degrees(+19.66324754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24284"},
        {"Geneva Identification System", "GEN# +6.10010192"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.17522082),
        dec: Angle.Degrees(+19.66507020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 238.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23183"},
        {"Hipparcos Number", "HIP 17408"},
        {"Geneva Identification System", "GEN# +1.00023183"},
        {"Smithsonian Astrophysical Observation", "SAO 93568"},
        {"Wilson Evans Batten Catalogue", "WEB 3293"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.94642290),
        dec: Angle.Degrees(+19.66516969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88791",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11080 AB"},
        {"Aitken 2", "ADS 11080"},
        {"Henry Draper", "HD 165886"},
        {"Hipparcos Number", "HIP 88791"},
        {"Smithsonian Astrophysical Observation", "SAO 103403"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.87298635),
        dec: Angle.Degrees(+19.66641919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223523"},
        {"Hipparcos Number", "HIP 117531"},
        {"Smithsonian Astrophysical Observation", "SAO 108861"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.53859393),
        dec: Angle.Degrees(+19.66674886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195340"},
        {"Hipparcos Number", "HIP 101139"},
        {"Smithsonian Astrophysical Observation", "SAO 106170"},
        {"Wilson Evans Batten Catalogue", "WEB 18267"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.51986132),
        dec: Angle.Degrees(+19.66760319)
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
    primaryId: "HIP 108060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208108"},
        {"Hipparcos Number", "HIP 108060"},
        {"Geneva Identification System", "GEN# +1.00208108"},
        {"Renson", "Renson 57847"},
        {"Smithsonian Astrophysical Observation", "SAO 107474"},
        {"Wilson Evans Batten Catalogue", "WEB 19480"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.40569599),
        dec: Angle.Degrees(+19.66838008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189182"},
        {"Hipparcos Number", "HIP 98280"},
        {"Geneva Identification System", "GEN# +1.00189182"},
        {"Smithsonian Astrophysical Observation", "SAO 105483"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.53699871),
        dec: Angle.Degrees(+19.66848415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42549",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6921 A"},
        {"Henry Draper", "HD 73710"},
        {"Hipparcos Number", "HIP 42549"},
        {"Geneva Identification System", "GEN# +1.00073710"},
        {"Geneva Identification System 2", "GEN# +2.26320283"},
        {"Smithsonian Astrophysical Observation", "SAO 98021"},
        {"Wilson Evans Batten Catalogue", "WEB 8207"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.09212013),
        dec: Angle.Degrees(+19.66997035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9750"},
        {"Hipparcos Number", "HIP 7435"},
        {"Smithsonian Astrophysical Observation", "SAO 92529"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.94012370),
        dec: Angle.Degrees(+19.67047433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9744 AB"},
        {"Henry Draper", "HD 140159"},
        {"Hipparcos Number", "HIP 76852"},
        {"Geneva Identification System", "GEN# +1.00140159J"},
        {"Smithsonian Astrophysical Observation", "SAO 101682"},
        {"Wilson Evans Batten Catalogue", "WEB 13037"},
    },
    visualMagnitude: 4.51,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.38788463),
        dec: Angle.Degrees(+19.67050566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3102"},
        {"Henry Draper", "HD 27028"},
        {"Hipparcos Number", "HIP 19975"},
        {"Geneva Identification System", "GEN# +1.00027028"},
        {"Smithsonian Astrophysical Observation", "SAO 93840"},
        {"Wilson Evans Batten Catalogue", "WEB 3810"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.25508595),
        dec: Angle.Degrees(+19.67593542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68642"},
        {"Hipparcos Number", "HIP 40327"},
        {"Smithsonian Astrophysical Observation", "SAO 97665"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.51345877),
        dec: Angle.Degrees(+19.67687220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111410"},
        {"Hipparcos Number", "HIP 62550"},
        {"Smithsonian Astrophysical Observation", "SAO 100284"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.24822268),
        dec: Angle.Degrees(+19.67993342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100447"},
        {"Hipparcos Number", "HIP 56383"},
        {"Geneva Identification System", "GEN# +1.00100447"},
        {"Smithsonian Astrophysical Observation", "SAO 99662"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.37267651),
        dec: Angle.Degrees(+19.67995035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37559"},
        {"Hipparcos Number", "HIP 26677"},
        {"Celescope Catalog", "CEL 903"},
        {"Smithsonian Astrophysical Observation", "SAO 94739"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.03991603),
        dec: Angle.Degrees(+19.68033615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10710"},
        {"Smithsonian Astrophysical Observation", "SAO 92876"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.48119107),
        dec: Angle.Degrees(+19.68067415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214698"},
        {"Hipparcos Number", "HIP 111884"},
        {"Geneva Identification System", "GEN# +1.00214698"},
        {"Smithsonian Astrophysical Observation", "SAO 108078"},
        {"Wilson Evans Batten Catalogue", "WEB 19984"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.94588694),
        dec: Angle.Degrees(+19.68114862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64084"},
        {"Smithsonian Astrophysical Observation", "SAO 100427"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.98843849),
        dec: Angle.Degrees(+19.68126479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156111"},
        {"Hipparcos Number", "HIP 84372"},
        {"Geneva Identification System", "GEN# +1.00156111"},
        {"Smithsonian Astrophysical Observation", "SAO 102688"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.73829298),
        dec: Angle.Degrees(+19.68304336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67776"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.27650454),
        dec: Angle.Degrees(+19.68375303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217697"},
        {"Hipparcos Number", "HIP 113765"},
        {"Geneva Identification System", "GEN# +1.00217697"},
        {"Smithsonian Astrophysical Observation", "SAO 108353"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.58612997),
        dec: Angle.Degrees(+19.68554639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116331"},
        {"Smithsonian Astrophysical Observation", "SAO 108681"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58139863),
        dec: Angle.Degrees(+19.68635755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14305"},
        {"Hipparcos Number", "HIP 10810"},
        {"Geneva Identification System", "GEN# +1.00014305"},
        {"Smithsonian Astrophysical Observation", "SAO 92884"},
        {"Wilson Evans Batten Catalogue", "WEB 2276"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.78638569),
        dec: Angle.Degrees(+19.68801228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10323 AB"},
        {"Henry Draper", "HD 154301"},
        {"Hipparcos Number", "HIP 83493"},
        {"Geneva Identification System", "GEN# +1.00154301J"},
        {"Smithsonian Astrophysical Observation", "SAO 102571"},
        {"Wilson Evans Batten Catalogue", "WEB 14114"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.96947300),
        dec: Angle.Degrees(+19.69049258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41040"},
        {"Hipparcos Number", "HIP 28691"},
        {"Celescope Catalog", "CEL 1064"},
        {"Geneva Identification System", "GEN# +1.00041040"},
        {"Smithsonian Astrophysical Observation", "SAO 95166"},
        {"Wilson Evans Batten Catalogue", "WEB 5613"},
        {"Wilson Evans Batten Catalogue 2", "WEB 5614"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.86400112),
        dec: Angle.Degrees(+19.69061033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115980"},
        {"Hipparcos Number", "HIP 65090"},
        {"Geneva Identification System", "GEN# +1.00115980"},
        {"Smithsonian Astrophysical Observation", "SAO 100520"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.11333753),
        dec: Angle.Degrees(+19.69114154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141753"},
        {"Hipparcos Number", "HIP 77549"},
        {"Geneva Identification System", "GEN# +1.00141753"},
        {"Smithsonian Astrophysical Observation", "SAO 101762"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.50407840),
        dec: Angle.Degrees(+19.69259206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224474"},
        {"Hipparcos Number", "HIP 118176"},
        {"Smithsonian Astrophysical Observation", "SAO 108939"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.57920230),
        dec: Angle.Degrees(+19.69354566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130704"},
        {"Hipparcos Number", "HIP 72466"},
        {"Smithsonian Astrophysical Observation", "SAO 101230"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27483080),
        dec: Angle.Degrees(+19.69826507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23016"},
        {"Hipparcos Number", "HIP 17309"},
        {"Fundamental Katalog 5th Edition", "FK5 2263"},
        {"Geneva Identification System", "GEN# +1.00023016"},
        {"Smithsonian Astrophysical Observation", "SAO 93557"},
        {"Wilson Evans Batten Catalogue", "WEB 3271"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.57893663),
        dec: Angle.Degrees(+19.70028593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132111"},
        {"Hipparcos Number", "HIP 73134"},
        {"Smithsonian Astrophysical Observation", "SAO 101297"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.19825782),
        dec: Angle.Degrees(+19.70045546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55674"},
        {"Hipparcos Number", "HIP 35019"},
        {"Geneva Identification System", "GEN# +1.00055674"},
        {"Smithsonian Astrophysical Observation", "SAO 96669"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.65706196),
        dec: Angle.Degrees(+19.70141534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44372"},
        {"Hipparcos Number", "HIP 30287"},
        {"Smithsonian Astrophysical Observation", "SAO 95586"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.55993247),
        dec: Angle.Degrees(+19.70258607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44811"},
        {"Hipparcos Number", "HIP 30496"},
        {"Geneva Identification System", "GEN# +1.00044811J"},
        {"Smithsonian Astrophysical Observation", "SAO 95633"},
        {"Wilson Evans Batten Catalogue", "WEB 6068"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.15980460),
        dec: Angle.Degrees(+19.70439915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67132"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.37988663),
        dec: Angle.Degrees(+19.70488239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3532"},
        {"Hipparcos Number", "HIP 3014"},
        {"Geneva Identification System", "GEN# +1.00003532"},
        {"Smithsonian Astrophysical Observation", "SAO 92004"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.58837156),
        dec: Angle.Degrees(+19.70505102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74718"},
        {"Hipparcos Number", "HIP 43050"},
        {"Geneva Identification System", "GEN# +1.00074718"},
        {"Smithsonian Astrophysical Observation", "SAO 98109"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.56453301),
        dec: Angle.Degrees(+19.70919002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104248"},
        {"Smithsonian Astrophysical Observation", "SAO 106852"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81173529),
        dec: Angle.Degrees(+19.70981521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172571"},
        {"Hipparcos Number", "HIP 91560"},
        {"Smithsonian Astrophysical Observation", "SAO 103978"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08198923),
        dec: Angle.Degrees(+19.71236236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116795"},
        {"Smithsonian Astrophysical Observation", "SAO 108758"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.06334238),
        dec: Angle.Degrees(+19.71260855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5687"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.29028373),
        dec: Angle.Degrees(+19.71274868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202522"},
        {"Hipparcos Number", "HIP 104990"},
        {"Smithsonian Astrophysical Observation", "SAO 106977"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.96671280),
        dec: Angle.Degrees(+19.71425661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108121",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15431 BC"},
        {"Hipparcos Number", "HIP 108121"},
        {"Geneva Identification System", "GEN# +1.00208202B"},
        {"Smithsonian Astrophysical Observation", "SAO 107491"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.57885729),
        dec: Angle.Degrees(+19.71605586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214113"},
        {"Hipparcos Number", "HIP 111535"},
        {"Smithsonian Astrophysical Observation", "SAO 108026"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.94696466),
        dec: Angle.Degrees(+19.71659870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229629"},
        {"Hipparcos Number", "HIP 92354"},
        {"Smithsonian Astrophysical Observation", "SAO 104145"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.33952070),
        dec: Angle.Degrees(+19.71711690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108119",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15431 A"},
        {"Henry Draper", "HD 208202"},
        {"Hipparcos Number", "HIP 108119"},
        {"Geneva Identification System", "GEN# +1.00208202A"},
        {"Smithsonian Astrophysical Observation", "SAO 107489"},
        {"Wilson Evans Batten Catalogue", "WEB 19491"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.57266177),
        dec: Angle.Degrees(+19.71815103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94959",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12309 A"},
        {"Henry Draper", "HD 181361"},
        {"Hipparcos Number", "HIP 94959"},
        {"Smithsonian Astrophysical Observation", "SAO 104720"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.85912791),
        dec: Angle.Degrees(+19.71838594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46087"},
        {"Hipparcos Number", "HIP 31144"},
        {"Geneva Identification System", "GEN# +1.00046087"},
        {"Smithsonian Astrophysical Observation", "SAO 95790"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.01333159),
        dec: Angle.Degrees(+19.71927470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73785"},
        {"Hipparcos Number", "HIP 42578"},
        {"Geneva Identification System", "GEN# +1.00073785"},
        {"Geneva Identification System 2", "GEN# +2.26320328"},
        {"Smithsonian Astrophysical Observation", "SAO 98030"},
        {"Wilson Evans Batten Catalogue", "WEB 8217"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18011560),
        dec: Angle.Degrees(+19.71934316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12309 B"},
        {"Hipparcos Number", "HIP 94961"},
    },
    visualMagnitude: 11.50,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.86137699),
        dec: Angle.Degrees(+19.72349562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241596"},
        {"Hipparcos Number", "HIP 24301"},
        {"Cincinnati Publication", "Ci 20 318"},
        {"Wilson Evans Batten Catalogue", "WEB 4715"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.22169987),
        dec: Angle.Degrees(+19.72380744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 366.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -674.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190027"},
        {"Hipparcos Number", "HIP 98660"},
        {"Smithsonian Astrophysical Observation", "SAO 105577"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.58867993),
        dec: Angle.Degrees(+19.72380903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284827"},
        {"Hipparcos Number", "HIP 22357"},
        {"Smithsonian Astrophysical Observation", "SAO 94139"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.19112745),
        dec: Angle.Degrees(+19.72398435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178004"},
        {"Hipparcos Number", "HIP 93803"},
        {"Smithsonian Astrophysical Observation", "SAO 104476"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.55170713),
        dec: Angle.Degrees(+19.72416287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116342"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.61463209),
        dec: Angle.Degrees(+19.72461314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161584"},
        {"Hipparcos Number", "HIP 86918"},
        {"Geneva Identification System", "GEN# +1.00161584"},
        {"Smithsonian Astrophysical Observation", "SAO 103084"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.40264733),
        dec: Angle.Degrees(+19.72539691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94689"},
        {"Hipparcos Number", "HIP 53455"},
        {"Smithsonian Astrophysical Observation", "SAO 99360"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.02868189),
        dec: Angle.Degrees(+19.72544728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131510"},
        {"Hipparcos Number", "HIP 72847"},
        {"Smithsonian Astrophysical Observation", "SAO 101275"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.34915437),
        dec: Angle.Degrees(+19.72624177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14838",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Botein"},
        {"Henry Draper", "HD 19787"},
        {"Hipparcos Number", "HIP 14838"},
        {"Fundamental Katalog 5th Edition", "FK5 114"},
        {"Geneva Identification System", "GEN# +1.00019787"},
        {"Smithsonian Astrophysical Observation", "SAO 93328"},
        {"Wilson Evans Batten Catalogue", "WEB 2865"},
    },
    visualMagnitude: 4.35,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.90695691),
        dec: Angle.Degrees(+19.72669777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16423"},
        {"Hipparcos Number", "HIP 12319"},
        {"Smithsonian Astrophysical Observation", "SAO 93033"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.65555499),
        dec: Angle.Degrees(+19.72769309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197518"},
        {"Hipparcos Number", "HIP 102295"},
        {"Smithsonian Astrophysical Observation", "SAO 106430"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.91168045),
        dec: Angle.Degrees(+19.72800598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51296"},
        {"Hipparcos Number", "HIP 33477"},
        {"Geneva Identification System", "GEN# +1.00051296"},
        {"Smithsonian Astrophysical Observation", "SAO 96312"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.38855524),
        dec: Angle.Degrees(+19.72918534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125751"},
        {"Hipparcos Number", "HIP 70132"},
        {"Geneva Identification System", "GEN# +1.00125751"},
        {"Smithsonian Astrophysical Observation", "SAO 100985"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.26118307),
        dec: Angle.Degrees(+19.73034736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20682"},
        {"Hipparcos Number", "HIP 15550"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.08594383),
        dec: Angle.Degrees(+19.73039160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60657"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.48156710),
        dec: Angle.Degrees(+19.73075084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11814"},
        {"Hipparcos Number", "HIP 9028"},
        {"Smithsonian Astrophysical Observation", "SAO 92706"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.07394262),
        dec: Angle.Degrees(+19.73175086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79668",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9981 AB"},
        {"Hipparcos Number", "HIP 79668"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.89128563),
        dec: Angle.Degrees(+19.73502859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65970"},
        {"Hipparcos Number", "HIP 39296"},
        {"Fundamental Katalog 5th Edition", "FK5 4723"},
        {"Smithsonian Astrophysical Observation", "SAO 97491"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.51968187),
        dec: Angle.Degrees(+19.73732490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26063"},
        {"Hipparcos Number", "HIP 19308"},
        {"Smithsonian Astrophysical Observation", "SAO 93778"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.08602455),
        dec: Angle.Degrees(+19.73765627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123879"},
        {"Hipparcos Number", "HIP 69187"},
        {"Geneva Identification System", "GEN# +1.00123879"},
        {"Smithsonian Astrophysical Observation", "SAO 100885"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.44386430),
        dec: Angle.Degrees(+19.74017025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28291"},
        {"Hipparcos Number", "HIP 20890"},
        {"Geneva Identification System", "GEN# +5.20250069"},
        {"Smithsonian Astrophysical Observation", "SAO 93953"},
        {"Wilson Evans Batten Catalogue", "WEB 4008"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.15480244),
        dec: Angle.Degrees(+19.74078200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224844"},
        {"Hipparcos Number", "HIP 100"},
        {"Geneva Identification System", "GEN# +1.00224844"},
        {"Smithsonian Astrophysical Observation", "SAO 108964"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.31645128),
        dec: Angle.Degrees(+19.74131648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9692"},
        {"Aitken 2", "ADS 9692 AB"},
        {"Henry Draper", "HD 138641"},
        {"Hipparcos Number", "HIP 76118"},
        {"Geneva Identification System", "GEN# +1.00138641J"},
        {"Smithsonian Astrophysical Observation", "SAO 101607"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.20074294),
        dec: Angle.Degrees(+19.74336579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285080"},
        {"Hipparcos Number", "HIP 23178"},
        {"Smithsonian Astrophysical Observation", "SAO 94243"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.78898559),
        dec: Angle.Degrees(+19.74600684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179186"},
        {"Hipparcos Number", "HIP 94216"},
        {"Geneva Identification System", "GEN# +1.00179186"},
        {"Smithsonian Astrophysical Observation", "SAO 104562"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.70127919),
        dec: Angle.Degrees(+19.74697368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39698"},
        {"Hipparcos Number", "HIP 27965"},
        {"Fundamental Katalog 5th Edition", "FK5 2447"},
        {"Geneva Identification System", "GEN# +1.00039698"},
        {"Smithsonian Astrophysical Observation", "SAO 94986"},
        {"Wilson Evans Batten Catalogue", "WEB 5479"},
    },
    visualMagnitude: 5.92,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73619396),
        dec: Angle.Degrees(+19.74962409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352860"},
        {"Hipparcos Number", "HIP 102357"},
        {"Cincinnati Publication", "Ci 20 1226"},
        {"Geneva Identification System", "GEN# +1.00352860"},
        {"Wilson Evans Batten Catalogue", "WEB 18530"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.09147356),
        dec: Angle.Degrees(+19.75114435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -600.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260564"},
        {"Hipparcos Number", "HIP 31626"},
        {"Geneva Identification System", "GEN# +1.00260564"},
        {"Wilson Evans Batten Catalogue", "WEB 6331"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.27205308),
        dec: Angle.Degrees(+19.75296520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36837"},
        {"Hipparcos Number", "HIP 26229"},
        {"Smithsonian Astrophysical Observation", "SAO 94670"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.82920428),
        dec: Angle.Degrees(+19.75299235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53473"},
        {"Hipparcos Number", "HIP 34243"},
        {"Smithsonian Astrophysical Observation", "SAO 96480"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.48732703),
        dec: Angle.Degrees(+19.75315308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7589 B"},
        {"Hipparcos Number", "HIP 48786"},
        {"Geneva Identification System", "GEN# +1.00086133B"},
        {"Smithsonian Astrophysical Observation", "SAO 98859"},
        {"Wilson Evans Batten Catalogue", "WEB 9072"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.26053603),
        dec: Angle.Degrees(+19.75395517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199072"},
        {"Hipparcos Number", "HIP 103172"},
        {"Smithsonian Astrophysical Observation", "SAO 106634"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.54377995),
        dec: Angle.Degrees(+19.75408732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116797",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16915 A"},
        {"Henry Draper", "HD 222418"},
        {"Hipparcos Number", "HIP 116797"},
        {"Smithsonian Astrophysical Observation", "SAO 108759"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.06666214),
        dec: Angle.Degrees(+19.75442503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157344"},
        {"Hipparcos Number", "HIP 84971"},
        {"Smithsonian Astrophysical Observation", "SAO 102774"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.50323963),
        dec: Angle.Degrees(+19.75815064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92941"},
        {"Hipparcos Number", "HIP 52513"},
        {"Geneva Identification System", "GEN# +1.00092941"},
        {"Smithsonian Astrophysical Observation", "SAO 81496"},
        {"Wilson Evans Batten Catalogue", "WEB 9564"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.06091378),
        dec: Angle.Degrees(+19.75888388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63068"},
        {"Geneva Identification System", "GEN# +0.02002775"},
        {"Smithsonian Astrophysical Observation", "SAO 82567"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.83717914),
        dec: Angle.Degrees(+19.75956524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3329 AB"},
        {"Henry Draper", "HD 29193"},
        {"Hipparcos Number", "HIP 21465"},
        {"Renson", "Renson 7480"},
        {"Smithsonian Astrophysical Observation", "SAO 94031"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.14464995),
        dec: Angle.Degrees(+19.76003759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48785",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7589 A"},
        {"Henry Draper", "HD 86133"},
        {"Hipparcos Number", "HIP 48785"},
        {"Geneva Identification System", "GEN# +1.00086133A"},
        {"Smithsonian Astrophysical Observation", "SAO 81101"},
        {"Wilson Evans Batten Catalogue", "WEB 9070"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.25979695),
        dec: Angle.Degrees(+19.76241065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195018"},
        {"Hipparcos Number", "HIP 100954"},
        {"Geneva Identification System", "GEN# +1.00195018"},
        {"Smithsonian Astrophysical Observation", "SAO 106136"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.03187808),
        dec: Angle.Degrees(+19.76280926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347868"},
        {"Hipparcos Number", "HIP 88539"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.19347762),
        dec: Angle.Degrees(+19.76420607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5653"},
        {"Hipparcos Number", "HIP 4565"},
        {"Smithsonian Astrophysical Observation", "SAO 92186"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.60938076),
        dec: Angle.Degrees(+19.76489419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5119"},
        {"Hipparcos Number", "HIP 4171"},
        {"Geneva Identification System", "GEN# +1.00005119"},
        {"Smithsonian Astrophysical Observation", "SAO 92136"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.32507759),
        dec: Angle.Degrees(+19.76655054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63351"},
        {"Hipparcos Number", "HIP 38163"},
        {"Smithsonian Astrophysical Observation", "SAO 97275"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30621515),
        dec: Angle.Degrees(+19.76950566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89458",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11208"},
        {"Henry Draper", "HD 167625"},
        {"Hipparcos Number", "HIP 89458"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.85436085),
        dec: Angle.Degrees(+19.77037789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67424"},
        {"Hipparcos Number", "HIP 39869"},
        {"Smithsonian Astrophysical Observation", "SAO 97590"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.16365984),
        dec: Angle.Degrees(+19.77072377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75437"},
    },
    visualMagnitude: 11.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.17952694),
        dec: Angle.Degrees(+19.77080407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -336.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72846"},
        {"Hipparcos Number", "HIP 42164"},
        {"Geneva Identification System", "GEN# +2.26321166"},
        {"Smithsonian Astrophysical Observation", "SAO 97941"},
        {"Wilson Evans Batten Catalogue", "WEB 8103"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.93789241),
        dec: Angle.Degrees(+19.77119205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 819"},
        {"Hipparcos Number", "HIP 1020"},
        {"Cincinnati Publication", "Ci 18 18"},
        {"Smithsonian Astrophysical Observation", "SAO 91773"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.17222053),
        dec: Angle.Degrees(+19.77166309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12622 A"},
        {"Henry Draper", "HD 184606"},
        {"Hipparcos Number", "HIP 96275"},
        {"Celescope Catalog", "CEL 4785"},
        {"Geneva Identification System", "GEN# +1.00184606J"},
        {"Smithsonian Astrophysical Observation", "SAO 104990"},
        {"Wilson Evans Batten Catalogue", "WEB 16877"},
    },
    visualMagnitude: 5.00,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.64536654),
        dec: Angle.Degrees(+19.77339742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78857"},
        {"Smithsonian Astrophysical Observation", "SAO 101920"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.45981532),
        dec: Angle.Degrees(+19.77488044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348688"},
        {"Hipparcos Number", "HIP 90607"},
        {"Smithsonian Astrophysical Observation", "SAO 103771"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.33582182),
        dec: Angle.Degrees(+19.77553185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73575"},
        {"Hipparcos Number", "HIP 42485"},
        {"Geneva Identification System", "GEN# +2.26320204"},
        {"Smithsonian Astrophysical Observation", "SAO 98006"},
        {"Wilson Evans Batten Catalogue", "WEB 8174"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.92782204),
        dec: Angle.Degrees(+19.77848535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37203"},
        {"Hipparcos Number", "HIP 26438"},
        {"Smithsonian Astrophysical Observation", "SAO 94710"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.39339205),
        dec: Angle.Degrees(+19.77952668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78307"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.83567151),
        dec: Angle.Degrees(+19.77980862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138983"},
        {"Hipparcos Number", "HIP 76283"},
        {"Smithsonian Astrophysical Observation", "SAO 101625"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.71696419),
        dec: Angle.Degrees(+19.77986796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37295"},
        {"Smithsonian Astrophysical Observation", "SAO 97119"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86344164),
        dec: Angle.Degrees(+19.78051603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116577"},
        {"Fundamental Katalog 5th Edition", "FK5 6093"},
        {"Smithsonian Astrophysical Observation", "SAO 108726"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.36433267),
        dec: Angle.Degrees(+19.78112829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205762"},
        {"Hipparcos Number", "HIP 106720"},
        {"Smithsonian Astrophysical Observation", "SAO 107280"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.26325793),
        dec: Angle.Degrees(+19.78286946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21775"},
        {"Hipparcos Number", "HIP 16401"},
        {"Smithsonian Astrophysical Observation", "SAO 93471"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.80595420),
        dec: Angle.Degrees(+19.78342944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115365"},
        {"Hipparcos Number", "HIP 64779"},
        {"Fundamental Katalog 5th Edition", "FK5 3059"},
        {"Geneva Identification System", "GEN# +1.00115365"},
        {"Smithsonian Astrophysical Observation", "SAO 82751"},
        {"Wilson Evans Batten Catalogue", "WEB 11448"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.13470200),
        dec: Angle.Degrees(+19.78521744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81192"},
        {"Hipparcos Number", "HIP 46155"},
        {"Geneva Identification System", "GEN# +1.00081192"},
        {"Smithsonian Astrophysical Observation", "SAO 80809"},
        {"Wilson Evans Batten Catalogue", "WEB 8739"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.18913533),
        dec: Angle.Degrees(+19.78690055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244359"},
        {"Hipparcos Number", "HIP 25834"},
        {"Smithsonian Astrophysical Observation", "SAO 94600"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.73372293),
        dec: Angle.Degrees(+19.78822479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109515"},
        {"Smithsonian Astrophysical Observation", "SAO 107719"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.77303842),
        dec: Angle.Degrees(+19.78869366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78606"},
        {"Smithsonian Astrophysical Observation", "SAO 101893"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.72850890),
        dec: Angle.Degrees(+19.79043610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117264"},
        {"Hipparcos Number", "HIP 65759"},
        {"Geneva Identification System", "GEN# +1.00117264"},
        {"Smithsonian Astrophysical Observation", "SAO 82860"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.22798818),
        dec: Angle.Degrees(+19.79056463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42509"},
        {"Hipparcos Number", "HIP 29433"},
        {"Celescope Catalog", "CEL 1114"},
        {"Fundamental Katalog 5th Edition", "FK5 2471"},
        {"Geneva Identification System", "GEN# +1.00042509"},
        {"Renson", "Renson 11320"},
        {"Smithsonian Astrophysical Observation", "SAO 95359"},
        {"Wilson Evans Batten Catalogue", "WEB 5780"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.00557898),
        dec: Angle.Degrees(+19.79057155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176301"},
        {"Hipparcos Number", "HIP 93175"},
        {"Celescope Catalog", "CEL 4676"},
        {"Geneva Identification System", "GEN# +1.00176301"},
        {"Smithsonian Astrophysical Observation", "SAO 104306"},
        {"Wilson Evans Batten Catalogue", "WEB 16144"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.68773621),
        dec: Angle.Degrees(+19.79440022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187428"},
        {"Hipparcos Number", "HIP 97516"},
        {"Geneva Identification System", "GEN# +1.00187428"},
        {"Smithsonian Astrophysical Observation", "SAO 105303"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.29844746),
        dec: Angle.Degrees(+19.79483667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66471"},
        {"Hipparcos Number", "HIP 39499"},
        {"Geneva Identification System", "GEN# +1.00066471"},
        {"Smithsonian Astrophysical Observation", "SAO 97528"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.11066794),
        dec: Angle.Degrees(+19.79750564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189017"},
        {"Hipparcos Number", "HIP 98207"},
        {"Smithsonian Astrophysical Observation", "SAO 105460"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.33598206),
        dec: Angle.Degrees(+19.79756984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124271"},
        {"Hipparcos Number", "HIP 69384"},
        {"Smithsonian Astrophysical Observation", "SAO 83216"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.04972375),
        dec: Angle.Degrees(+19.79821559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12344 AB"},
        {"Henry Draper", "HD 349972"},
        {"Hipparcos Number", "HIP 95140"},
        {"Smithsonian Astrophysical Observation", "SAO 104757"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.34797974),
        dec: Angle.Degrees(+19.79824289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12425 A"},
        {"Henry Draper", "HD 182762"},
        {"Hipparcos Number", "HIP 95498"},
        {"Geneva Identification System", "GEN# +1.00182762"},
        {"Smithsonian Astrophysical Observation", "SAO 104818"},
        {"Wilson Evans Batten Catalogue", "WEB 16700"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.36893140),
        dec: Angle.Degrees(+19.79853912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130317"},
        {"Hipparcos Number", "HIP 72286"},
        {"Smithsonian Astrophysical Observation", "SAO 83516"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.74849884),
        dec: Angle.Degrees(+19.79954129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350000"},
        {"Hipparcos Number", "HIP 95450"},
        {"Geneva Identification System", "GEN# +1.00350000"},
        {"Smithsonian Astrophysical Observation", "SAO 104809"},
        {"Wilson Evans Batten Catalogue", "WEB 16689"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.24806311),
        dec: Angle.Degrees(+19.79997376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154300"},
        {"Hipparcos Number", "HIP 83490"},
        {"Geneva Identification System", "GEN# +1.00154300"},
        {"Smithsonian Astrophysical Observation", "SAO 102570"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.96138827),
        dec: Angle.Degrees(+19.80044173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106088"},
        {"Hipparcos Number", "HIP 59525"},
        {"Smithsonian Astrophysical Observation", "SAO 82184"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.10269245),
        dec: Angle.Degrees(+19.80121079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14201"},
        {"Smithsonian Astrophysical Observation", "SAO 93251"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.78482471),
        dec: Angle.Degrees(+19.80143943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146697"},
        {"Hipparcos Number", "HIP 79773"},
        {"Smithsonian Astrophysical Observation", "SAO 102057"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.21427759),
        dec: Angle.Degrees(+19.80152955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128610"},
        {"Hipparcos Number", "HIP 71509"},
        {"Smithsonian Astrophysical Observation", "SAO 83442"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.36124943),
        dec: Angle.Degrees(+19.80183912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54691"},
        {"Hipparcos Number", "HIP 34650"},
        {"Geneva Identification System", "GEN# +1.00054691"},
        {"Smithsonian Astrophysical Observation", "SAO 96588"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.64119431),
        dec: Angle.Degrees(+19.80306067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105502",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14909 A"},
        {"Henry Draper", "HD 203504"},
        {"Hipparcos Number", "HIP 105502"},
        {"Fundamental Katalog 5th Edition", "FK5 804"},
        {"Geneva Identification System", "GEN# +1.00203504A"},
        {"Smithsonian Astrophysical Observation", "SAO 107073"},
        {"Wilson Evans Batten Catalogue", "WEB 19158"},
    },
    visualMagnitude: 4.08,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.52139118),
        dec: Angle.Degrees(+19.80435581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284724"},
        {"Hipparcos Number", "HIP 21875"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.54375519),
        dec: Angle.Degrees(+19.80520216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125920"},
        {"Hipparcos Number", "HIP 70224"},
        {"Smithsonian Astrophysical Observation", "SAO 83308"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.50671216),
        dec: Angle.Degrees(+19.80523605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231708"},
        {"Hipparcos Number", "HIP 96070"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.00038454),
        dec: Angle.Degrees(+19.80671564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3672 AB"},
        {"Henry Draper", "HD 32642"},
        {"Hipparcos Number", "HIP 23695"},
        {"Geneva Identification System", "GEN# +1.00032642J"},
        {"Smithsonian Astrophysical Observation", "SAO 94306"},
        {"Wilson Evans Batten Catalogue", "WEB 4619"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.38377776),
        dec: Angle.Degrees(+19.80675325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74452"},
        {"Smithsonian Astrophysical Observation", "SAO 101439"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.21568794),
        dec: Angle.Degrees(+19.80758726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6898"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.19968598),
        dec: Angle.Degrees(+19.80919818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174223"},
        {"Hipparcos Number", "HIP 92297"},
        {"Fundamental Katalog 5th Edition", "FK5 5652"},
        {"Geneva Identification System", "GEN# +1.00174223"},
        {"Smithsonian Astrophysical Observation", "SAO 104123"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.16471559),
        dec: Angle.Degrees(+19.80936849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16701"},
        {"Smithsonian Astrophysical Observation", "SAO 93498"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.73550997),
        dec: Angle.Degrees(+19.81018550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285279"},
        {"Hipparcos Number", "HIP 18787"},
        {"Smithsonian Astrophysical Observation", "SAO 93726"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.37657970),
        dec: Angle.Degrees(+19.81093297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3296 AB"},
        {"Henry Draper", "HD 284564"},
        {"Hipparcos Number", "HIP 21240"},
        {"Smithsonian Astrophysical Observation", "SAO 94001"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.34644380),
        dec: Angle.Degrees(+19.81374797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181934"},
        {"Hipparcos Number", "HIP 95157"},
        {"Smithsonian Astrophysical Observation", "SAO 104763"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.40022713),
        dec: Angle.Degrees(+19.81374838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90494"},
        {"Hipparcos Number", "HIP 51178"},
        {"Geneva Identification System", "GEN# +1.00090494"},
        {"Smithsonian Astrophysical Observation", "SAO 81353"},
        {"Wilson Evans Batten Catalogue", "WEB 9354"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.79487270),
        dec: Angle.Degrees(+19.81383368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40629"},
        {"Hipparcos Number", "HIP 28495"},
        {"Smithsonian Astrophysical Observation", "SAO 95112"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.22726769),
        dec: Angle.Degrees(+19.81414292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59360"},
        {"Hipparcos Number", "HIP 36481"},
        {"Fundamental Katalog 5th Edition", "FK5 4674"},
        {"Geneva Identification System", "GEN# +1.00059360"},
        {"Smithsonian Astrophysical Observation", "SAO 96960"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.59731966),
        dec: Angle.Degrees(+19.81423312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34810"},
        {"Hipparcos Number", "HIP 24977"},
        {"Geneva Identification System", "GEN# +1.00034810"},
        {"Smithsonian Astrophysical Observation", "SAO 94478"},
        {"Wilson Evans Batten Catalogue", "WEB 4837"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.23590518),
        dec: Angle.Degrees(+19.81436874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41115"},
        {"Smithsonian Astrophysical Observation", "SAO 97780"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.83539447),
        dec: Angle.Degrees(+19.81455852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115403"},
        {"Hipparcos Number", "HIP 64789"},
        {"Geneva Identification System", "GEN# +1.00115403"},
        {"Smithsonian Astrophysical Observation", "SAO 82753"},
        {"Wilson Evans Batten Catalogue", "WEB 11450"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.18554780),
        dec: Angle.Degrees(+19.81512181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353051"},
        {"Hipparcos Number", "HIP 102735"},
        {"Smithsonian Astrophysical Observation", "SAO 106528"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.26206202),
        dec: Angle.Degrees(+19.81522357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114638"},
        {"Hipparcos Number", "HIP 64369"},
        {"Geneva Identification System", "GEN# +1.00114638"},
        {"Smithsonian Astrophysical Observation", "SAO 82701"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.89627368),
        dec: Angle.Degrees(+19.81558558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65735"},
        {"Hipparcos Number", "HIP 39180"},
        {"Geneva Identification System", "GEN# +1.00065735"},
        {"Smithsonian Astrophysical Observation", "SAO 97471"},
        {"Wilson Evans Batten Catalogue", "WEB 7680"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.20040476),
        dec: Angle.Degrees(+19.81623542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42708"},
        {"Hipparcos Number", "HIP 29511"},
        {"Geneva Identification System", "GEN# +1.00042708"},
        {"Smithsonian Astrophysical Observation", "SAO 95383"},
        {"Wilson Evans Batten Catalogue", "WEB 5800"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.25437535),
        dec: Angle.Degrees(+19.81703645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349287"},
        {"Hipparcos Number", "HIP 91878"},
        {"Smithsonian Astrophysical Observation", "SAO 104036"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.95690824),
        dec: Angle.Degrees(+19.81729739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67150"},
        {"Hipparcos Number", "HIP 39749"},
        {"Geneva Identification System", "GEN# +1.00067150"},
        {"Smithsonian Astrophysical Observation", "SAO 97570"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.85887353),
        dec: Angle.Degrees(+19.81775403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13566"},
        {"Hipparcos Number", "HIP 10318"},
        {"Smithsonian Astrophysical Observation", "SAO 92838"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.22310985),
        dec: Angle.Degrees(+19.82126446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10364"},
        {"Hipparcos Number", "HIP 7907"},
        {"Smithsonian Astrophysical Observation", "SAO 92581"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.41425397),
        dec: Angle.Degrees(+19.82365543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81726"},
        {"Hipparcos Number", "HIP 46419"},
        {"Geneva Identification System", "GEN# +1.00081726"},
        {"Smithsonian Astrophysical Observation", "SAO 80842"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98647076),
        dec: Angle.Degrees(+19.82368801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53288"},
        {"Hipparcos Number", "HIP 34172"},
        {"Smithsonian Astrophysical Observation", "SAO 96465"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.31217144),
        dec: Angle.Degrees(+19.82462030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107887",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15383 A"},
        {"Henry Draper", "HD 207840"},
        {"Hipparcos Number", "HIP 107887"},
        {"Geneva Identification System", "GEN# +1.00207840A"},
        {"Renson", "Renson 57780"},
        {"Smithsonian Astrophysical Observation", "SAO 107445"},
        {"Wilson Evans Batten Catalogue", "WEB 19452"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.89264809),
        dec: Angle.Degrees(+19.82664938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23313"},
        {"Hipparcos Number", "HIP 17503"},
        {"Smithsonian Astrophysical Observation", "SAO 93579"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.22082228),
        dec: Angle.Degrees(+19.83065945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147204"},
        {"Hipparcos Number", "HIP 79994"},
        {"Smithsonian Astrophysical Observation", "SAO 102091"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.93822947),
        dec: Angle.Degrees(+19.83345298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34988"},
        {"Hipparcos Number", "HIP 25086"},
        {"Geneva Identification System", "GEN# +1.00034988"},
        {"Smithsonian Astrophysical Observation", "SAO 94494"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.56071445),
        dec: Angle.Degrees(+19.83423497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69456"},
        {"Hipparcos Number", "HIP 40644"},
        {"Smithsonian Astrophysical Observation", "SAO 97713"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.45817041),
        dec: Angle.Degrees(+19.83547494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150999"},
        {"Hipparcos Number", "HIP 81906"},
        {"Smithsonian Astrophysical Observation", "SAO 102352"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.95575960),
        dec: Angle.Degrees(+19.83557506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217636"},
        {"Hipparcos Number", "HIP 113724"},
        {"Smithsonian Astrophysical Observation", "SAO 108344"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.47676577),
        dec: Angle.Degrees(+19.83775404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6935"},
        {"Hipparcos Number", "HIP 5473"},
        {"Smithsonian Astrophysical Observation", "SAO 92286"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.51815693),
        dec: Angle.Degrees(+19.83790352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60471"},
        {"Hipparcos Number", "HIP 36925"},
        {"Smithsonian Astrophysical Observation", "SAO 97053"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.86062764),
        dec: Angle.Degrees(+19.83814578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64430"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.08919512),
        dec: Angle.Degrees(+19.83952913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1115 AB"},
        {"Henry Draper", "HD 8453"},
        {"Hipparcos Number", "HIP 6538"},
        {"Smithsonian Astrophysical Observation", "SAO 92416"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.00888133),
        dec: Angle.Degrees(+19.83974456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28483"},
        {"Hipparcos Number", "HIP 21008"},
        {"Geneva Identification System", "GEN# +5.20250081"},
        {"Smithsonian Astrophysical Observation", "SAO 93973"},
        {"Wilson Evans Batten Catalogue", "WEB 4042"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.57463636),
        dec: Angle.Degrees(+19.84064458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220809"},
        {"Hipparcos Number", "HIP 115725"},
        {"Geneva Identification System", "GEN# +1.00220809"},
        {"Smithsonian Astrophysical Observation", "SAO 108610"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.68269114),
        dec: Angle.Degrees(+19.84074853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220044"},
        {"Hipparcos Number", "HIP 115255"},
        {"Smithsonian Astrophysical Observation", "SAO 108554"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.16717151),
        dec: Angle.Degrees(+19.84081649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9495 AB"},
        {"Henry Draper", "HD 133528"},
        {"Hipparcos Number", "HIP 73748"},
        {"Smithsonian Astrophysical Observation", "SAO 83644"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.12258512),
        dec: Angle.Degrees(+19.84130806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50583",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Algieba"},
        {"Aitken", "ADS 7724 AB"},
        {"Hipparcos Number", "HIP 50583"},
        {"Geneva Identification System", "GEN# +1.00089484J"},
    },
    visualMagnitude: 2.01,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.99234054),
        dec: Angle.Degrees(+19.84186032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 310.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175468"},
        {"Hipparcos Number", "HIP 92813"},
        {"Celescope Catalog", "CEL 4666"},
        {"Geneva Identification System", "GEN# +1.00175468"},
        {"Smithsonian Astrophysical Observation", "SAO 104251"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.67038329),
        dec: Angle.Degrees(+19.84262616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28138"},
        {"Hipparcos Number", "HIP 20774"},
        {"Smithsonian Astrophysical Observation", "SAO 93941"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.75653719),
        dec: Angle.Degrees(+19.84333279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46280"},
        {"Hipparcos Number", "HIP 31249"},
        {"Smithsonian Astrophysical Observation", "SAO 95822"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.31836149),
        dec: Angle.Degrees(+19.84363035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159797"},
        {"Hipparcos Number", "HIP 86101"},
        {"Geneva Identification System", "GEN# +1.00159797"},
        {"Smithsonian Astrophysical Observation", "SAO 102952"},
        {"Wilson Evans Batten Catalogue", "WEB 14524"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.94774506),
        dec: Angle.Degrees(+19.84382087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65125"},
        {"Geneva Identification System", "GEN# +0.02002826"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.19675388),
        dec: Angle.Degrees(+19.84404733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13021"},
        {"Smithsonian Astrophysical Observation", "SAO 93103"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.85036825),
        dec: Angle.Degrees(+19.84422650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112535"},
        {"Geneva Identification System", "GEN# +9.80067020"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.90175134),
        dec: Angle.Degrees(+19.84697580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 329.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66421"},
        {"Geneva Identification System", "GEN# +0.02002849"},
        {"Smithsonian Astrophysical Observation", "SAO 82906"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.26000507),
        dec: Angle.Degrees(+19.84709071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55919"},
        {"Hipparcos Number", "HIP 35126"},
        {"Smithsonian Astrophysical Observation", "SAO 96697"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.92834012),
        dec: Angle.Degrees(+19.84736311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246629"},
        {"Hipparcos Number", "HIP 26916"},
        {"Smithsonian Astrophysical Observation", "SAO 94791"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.70683464),
        dec: Angle.Degrees(+19.84752826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128626"},
        {"Hipparcos Number", "HIP 71511"},
        {"Smithsonian Astrophysical Observation", "SAO 83443"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.37000062),
        dec: Angle.Degrees(+19.84770326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175803"},
        {"Hipparcos Number", "HIP 92957"},
        {"Celescope Catalog", "CEL 4670"},
        {"Geneva Identification System", "GEN# +1.00175803"},
        {"Smithsonian Astrophysical Observation", "SAO 104275"},
        {"Wilson Evans Batten Catalogue", "WEB 16099"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.07772147),
        dec: Angle.Degrees(+19.84773510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43905"},
        {"Geneva Identification System", "GEN# +0.02002243"},
        {"Smithsonian Astrophysical Observation", "SAO 80524"},
        {"Wilson Evans Batten Catalogue", "WEB 8443"},
    },
    visualMagnitude: 9.27,
    bvColour: 5.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.16725769),
        dec: Angle.Degrees(+19.84913479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194035"},
        {"Hipparcos Number", "HIP 100500"},
        {"Geneva Identification System", "GEN# +1.00194035"},
        {"Smithsonian Astrophysical Observation", "SAO 106041"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.68783145),
        dec: Angle.Degrees(+19.85007103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69938"},
        {"Hipparcos Number", "HIP 40832"},
        {"Geneva Identification System", "GEN# +1.00069938"},
        {"Smithsonian Astrophysical Observation", "SAO 80107"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00050104),
        dec: Angle.Degrees(+19.85098887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110376"},
        {"Hipparcos Number", "HIP 61939"},
        {"Smithsonian Astrophysical Observation", "SAO 82442"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.40443319),
        dec: Angle.Degrees(+19.85130353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202423"},
        {"Hipparcos Number", "HIP 104920"},
        {"Smithsonian Astrophysical Observation", "SAO 106963"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.79529500),
        dec: Angle.Degrees(+19.85388490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223756"},
        {"Hipparcos Number", "HIP 117709"},
        {"Geneva Identification System", "GEN# +1.00223756"},
        {"Smithsonian Astrophysical Observation", "SAO 108876"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.08333593),
        dec: Angle.Degrees(+19.85500480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15550"},
        {"Hipparcos Number", "HIP 11678"},
        {"Fundamental Katalog 5th Edition", "FK5 2172"},
        {"Geneva Identification System", "GEN# +1.00015550"},
        {"Smithsonian Astrophysical Observation", "SAO 92979"},
        {"Wilson Evans Batten Catalogue", "WEB 2430"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.65986622),
        dec: Angle.Degrees(+19.85538831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125409"},
        {"Hipparcos Number", "HIP 69944"},
        {"Smithsonian Astrophysical Observation", "SAO 83289"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.70384045),
        dec: Angle.Degrees(+19.85569265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82461"},
        {"Hipparcos Number", "HIP 46838"},
        {"Smithsonian Astrophysical Observation", "SAO 80898"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.16967934),
        dec: Angle.Degrees(+19.85577079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186703"},
        {"Hipparcos Number", "HIP 97204"},
        {"Smithsonian Astrophysical Observation", "SAO 105215"},
        {"Wilson Evans Batten Catalogue", "WEB 17064"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.32669548),
        dec: Angle.Degrees(+19.85579435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128799"},
        {"Hipparcos Number", "HIP 71588"},
        {"Fundamental Katalog 5th Edition", "FK5 5296"},
        {"Geneva Identification System", "GEN# +1.00128799"},
        {"Smithsonian Astrophysical Observation", "SAO 83447"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.61491111),
        dec: Angle.Degrees(+19.85618184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1375 AB"},
        {"Hipparcos Number", "HIP 8156"},
        {"Smithsonian Astrophysical Observation", "SAO 92610"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.22285320),
        dec: Angle.Degrees(+19.85682008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198290"},
        {"Hipparcos Number", "HIP 102713"},
        {"Geneva Identification System", "GEN# +1.00198290"},
        {"Smithsonian Astrophysical Observation", "SAO 106518"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.17835528),
        dec: Angle.Degrees(+19.85960023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33121"},
        {"Hipparcos Number", "HIP 23949"},
        {"Geneva Identification System", "GEN# +1.00033121"},
        {"Smithsonian Astrophysical Observation", "SAO 94345"},
        {"Wilson Evans Batten Catalogue", "WEB 4669"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.21011988),
        dec: Angle.Degrees(+19.85989402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134046"},
        {"Hipparcos Number", "HIP 73997"},
        {"Smithsonian Astrophysical Observation", "SAO 83669"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.82981205),
        dec: Angle.Degrees(+19.86070874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1295"},
        {"Geneva Identification System", "GEN# +9.80032006"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.05910638),
        dec: Angle.Degrees(+19.86228962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 721.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -753.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178426"},
        {"Hipparcos Number", "HIP 93957"},
        {"Smithsonian Astrophysical Observation", "SAO 104510"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.96512272),
        dec: Angle.Degrees(+19.86406271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197274"},
        {"Hipparcos Number", "HIP 102170"},
        {"Smithsonian Astrophysical Observation", "SAO 106401"},
        {"Wilson Evans Batten Catalogue", "WEB 18485"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.53988115),
        dec: Angle.Degrees(+19.86462114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194616"},
        {"Hipparcos Number", "HIP 100779"},
        {"Geneva Identification System", "GEN# +1.00194616"},
        {"Smithsonian Astrophysical Observation", "SAO 106100"},
        {"Wilson Evans Batten Catalogue", "WEB 18213"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.50478520),
        dec: Angle.Degrees(+19.86544804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39286"},
        {"Hipparcos Number", "HIP 27747"},
        {"Celescope Catalog", "CEL 1009"},
        {"Geneva Identification System", "GEN# +1.00039286"},
        {"Renson", "Renson 10550"},
        {"Smithsonian Astrophysical Observation", "SAO 94942"},
        {"Wilson Evans Batten Catalogue", "WEB 5440"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.09753810),
        dec: Angle.Degrees(+19.86785634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62637"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.52545157),
        dec: Angle.Degrees(+19.87106939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85519"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.15390302),
        dec: Angle.Degrees(+19.87206686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20681"},
        {"Hipparcos Number", "HIP 15555"},
        {"Smithsonian Astrophysical Observation", "SAO 93394"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.09718688),
        dec: Angle.Degrees(+19.87271416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44018"},
        {"Hipparcos Number", "HIP 30110"},
        {"Geneva Identification System", "GEN# +1.00044018"},
        {"Smithsonian Astrophysical Observation", "SAO 95544"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.05050342),
        dec: Angle.Degrees(+19.87413890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73974"},
        {"Hipparcos Number", "HIP 42673"},
        {"Geneva Identification System", "GEN# +2.26320428"},
        {"Smithsonian Astrophysical Observation", "SAO 80361"},
        {"Wilson Evans Batten Catalogue", "WEB 8239"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.45876296),
        dec: Angle.Degrees(+19.87420516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5517"},
        {"Hipparcos Number", "HIP 4459"},
        {"Smithsonian Astrophysical Observation", "SAO 92174"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.29471218),
        dec: Angle.Degrees(+19.87794594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208717"},
        {"Hipparcos Number", "HIP 108415"},
        {"Renson", "Renson 58030"},
        {"Smithsonian Astrophysical Observation", "SAO 107544"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.44799728),
        dec: Angle.Degrees(+19.87819932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167408"},
        {"Hipparcos Number", "HIP 89383"},
        {"Smithsonian Astrophysical Observation", "SAO 103514"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.60297025),
        dec: Angle.Degrees(+19.87914659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21408",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3316 AB"},
        {"Henry Draper", "HD 29104"},
        {"Hipparcos Number", "HIP 21408"},
        {"Geneva Identification System", "GEN# +1.00029104"},
        {"Smithsonian Astrophysical Observation", "SAO 94022"},
        {"Wilson Evans Batten Catalogue", "WEB 4108"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.92739034),
        dec: Angle.Degrees(+19.88183123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68378",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9078 AB"},
        {"Henry Draper", "HD 122168"},
        {"Hipparcos Number", "HIP 68378"},
        {"Smithsonian Astrophysical Observation", "SAO 83118"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.95084986),
        dec: Angle.Degrees(+19.88287563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171781"},
        {"Hipparcos Number", "HIP 91169"},
        {"Geneva Identification System", "GEN# +1.00171781"},
        {"Smithsonian Astrophysical Observation", "SAO 103890"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.99132728),
        dec: Angle.Degrees(+19.88332132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64648"},
        {"Hipparcos Number", "HIP 38722"},
        {"Fundamental Katalog 5th Edition", "FK5 2614"},
        {"Geneva Identification System", "GEN# +1.00064648"},
        {"Smithsonian Astrophysical Observation", "SAO 79799"},
        {"Wilson Evans Batten Catalogue", "WEB 7593"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.91626746),
        dec: Angle.Degrees(+19.88406657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221011"},
        {"Hipparcos Number", "HIP 115856"},
        {"Geneva Identification System", "GEN# +1.00221011"},
        {"Smithsonian Astrophysical Observation", "SAO 108627"},
        {"Wilson Evans Batten Catalogue", "WEB 20495"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.09812956),
        dec: Angle.Degrees(+19.88560836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54985"},
        {"Hipparcos Number", "HIP 34764"},
        {"Smithsonian Astrophysical Observation", "SAO 96610"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.95405501),
        dec: Angle.Degrees(+19.88562802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171047"},
        {"Hipparcos Number", "HIP 90840"},
        {"Smithsonian Astrophysical Observation", "SAO 103817"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98377268),
        dec: Angle.Degrees(+19.88576980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7206"},
        {"Smithsonian Astrophysical Observation", "SAO 92501"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.21084744),
        dec: Angle.Degrees(+19.88797687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131528"},
        {"Hipparcos Number", "HIP 72859"},
        {"Smithsonian Astrophysical Observation", "SAO 83569"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.37993274),
        dec: Angle.Degrees(+19.88852727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163639"},
        {"Hipparcos Number", "HIP 87825"},
        {"Smithsonian Astrophysical Observation", "SAO 103229"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.10251712),
        dec: Angle.Degrees(+19.88887216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102122"},
        {"Hipparcos Number", "HIP 57335"},
        {"Geneva Identification System", "GEN# +1.00102122"},
        {"Smithsonian Astrophysical Observation", "SAO 81972"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.33758588),
        dec: Angle.Degrees(+19.88930632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189550"},
        {"Hipparcos Number", "HIP 98428"},
        {"Geneva Identification System", "GEN# +1.00189550"},
        {"Smithsonian Astrophysical Observation", "SAO 105520"},
        {"Wilson Evans Batten Catalogue", "WEB 17375"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.98240327),
        dec: Angle.Degrees(+19.88951230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12445 A"},
        {"Henry Draper", "HD 182955"},
        {"Hipparcos Number", "HIP 95582"},
        {"Fundamental Katalog 5th Edition", "FK5 1505"},
        {"Geneva Identification System", "GEN# +1.00182955A"},
        {"Smithsonian Astrophysical Observation", "SAO 104839"},
        {"Wilson Evans Batten Catalogue", "WEB 16718"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.61952782),
        dec: Angle.Degrees(+19.89161003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44253"},
        {"Hipparcos Number", "HIP 30229"},
        {"Fundamental Katalog 5th Edition", "FK5 4575"},
        {"Geneva Identification System", "GEN# +1.00044253"},
        {"Smithsonian Astrophysical Observation", "SAO 95576"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.39863975),
        dec: Angle.Degrees(+19.89206367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216625"},
        {"Hipparcos Number", "HIP 113086"},
        {"Geneva Identification System", "GEN# +1.00216625"},
        {"Smithsonian Astrophysical Observation", "SAO 108240"},
        {"Wilson Evans Batten Catalogue", "WEB 20130"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.53103823),
        dec: Angle.Degrees(+19.89237128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107393"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.27061820),
        dec: Angle.Degrees(+19.89372104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55592"},
        {"Cincinnati Publication", "Ci 20 631"},
        {"Geneva Identification System", "GEN# +0.02002594"},
        {"Smithsonian Astrophysical Observation", "SAO 81798"},
        {"Wilson Evans Batten Catalogue", "WEB 9992"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.81847536),
        dec: Angle.Degrees(+19.89456094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -326.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12625"},
        {"Hipparcos Number", "HIP 9654"},
        {"Smithsonian Astrophysical Observation", "SAO 92778"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.03551176),
        dec: Angle.Degrees(+19.89589771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64834"},
        {"Hipparcos Number", "HIP 38814"},
        {"Smithsonian Astrophysical Observation", "SAO 79815"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.15202800),
        dec: Angle.Degrees(+19.89638681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129173"},
        {"Hipparcos Number", "HIP 71744"},
        {"Smithsonian Astrophysical Observation", "SAO 83461"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.13142197),
        dec: Angle.Degrees(+19.89681523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103812"},
        {"Cincinnati Publication", "Ci 18 2722"},
        {"Smithsonian Astrophysical Observation", "SAO 106778"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.55070166),
        dec: Angle.Degrees(+19.90034650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 223.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14191"},
        {"Hipparcos Number", "HIP 10732"},
        {"Celescope Catalog", "CEL 249"},
        {"Fundamental Katalog 5th Edition", "FK5 81"},
        {"Geneva Identification System", "GEN# +1.00014191"},
        {"Smithsonian Astrophysical Observation", "SAO 92877"},
        {"Wilson Evans Batten Catalogue", "WEB 2263"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.53144339),
        dec: Angle.Degrees(+19.90116135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44964"},
        {"Smithsonian Astrophysical Observation", "SAO 80667"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.40169969),
        dec: Angle.Degrees(+19.90368822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166684"},
        {"Hipparcos Number", "HIP 89098"},
        {"Smithsonian Astrophysical Observation", "SAO 103461"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77194677),
        dec: Angle.Degrees(+19.90436762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2096"},
        {"Hipparcos Number", "HIP 1999"},
        {"Geneva Identification System", "GEN# +1.00002096"},
        {"Smithsonian Astrophysical Observation", "SAO 91885"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.33967469),
        dec: Angle.Degrees(+19.90497069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27250"},
        {"Hipparcos Number", "HIP 20130"},
        {"Geneva Identification System", "GEN# +5.20250026"},
        {"Smithsonian Astrophysical Observation", "SAO 93856"},
        {"Wilson Evans Batten Catalogue", "WEB 3842"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.74126891),
        dec: Angle.Degrees(+19.90678965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21006"},
        {"Hipparcos Number", "HIP 15838"},
        {"Smithsonian Astrophysical Observation", "SAO 93412"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.00374867),
        dec: Angle.Degrees(+19.90704275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141069"},
        {"Hipparcos Number", "HIP 77247"},
        {"Geneva Identification System", "GEN# +1.00141069"},
        {"Smithsonian Astrophysical Observation", "SAO 83994"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.59683124),
        dec: Angle.Degrees(+19.90745754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11617"},
        {"Smithsonian Astrophysical Observation", "SAO 92974"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.45962930),
        dec: Angle.Degrees(+19.90748404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256413"},
        {"Hipparcos Number", "HIP 30446"},
        {"Geneva Identification System", "GEN# +1.00256413"},
        {"Smithsonian Astrophysical Observation", "SAO 95626"},
        {"Wilson Evans Batten Catalogue", "WEB 6061"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.00757005),
        dec: Angle.Degrees(+19.90897716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218261"},
        {"Hipparcos Number", "HIP 114096"},
        {"Geneva Identification System", "GEN# +1.00218261"},
        {"Smithsonian Astrophysical Observation", "SAO 108402"},
        {"Wilson Evans Batten Catalogue", "WEB 20259"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.63211340),
        dec: Angle.Degrees(+19.91084131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 287.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209061"},
        {"Hipparcos Number", "HIP 108616"},
        {"Smithsonian Astrophysical Observation", "SAO 107573"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.04937318),
        dec: Angle.Degrees(+19.91143167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7558",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1269 AB"},
        {"Hipparcos Number", "HIP 7558"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.34291274),
        dec: Angle.Degrees(+19.91251555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40461"},
        {"Hipparcos Number", "HIP 28373"},
        {"Smithsonian Astrophysical Observation", "SAO 95093"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.91256483),
        dec: Angle.Degrees(+19.91367624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87389"},
        {"Hipparcos Number", "HIP 49407"},
        {"Geneva Identification System", "GEN# +1.00087389"},
        {"Smithsonian Astrophysical Observation", "SAO 81171"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.29035739),
        dec: Angle.Degrees(+19.91579906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46074"},
        {"Hipparcos Number", "HIP 31140"},
        {"Smithsonian Astrophysical Observation", "SAO 95789"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.99927843),
        dec: Angle.Degrees(+19.91829071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114819"},
        {"Hipparcos Number", "HIP 64474"},
        {"Geneva Identification System", "GEN# +1.00114819"},
        {"Smithsonian Astrophysical Observation", "SAO 82718"},
        {"Wilson Evans Batten Catalogue", "WEB 11396"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.22377346),
        dec: Angle.Degrees(+19.91837061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59812"},
    },
    visualMagnitude: 11.38,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.98419820),
        dec: Angle.Degrees(+19.91853534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206776"},
        {"Hipparcos Number", "HIP 107290"},
        {"Smithsonian Astrophysical Observation", "SAO 107359"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.97855697),
        dec: Angle.Degrees(+19.91952404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85252"},
        {"Fundamental Katalog 5th Edition", "FK5 5534"},
        {"Smithsonian Astrophysical Observation", "SAO 102811"},
        {"Wilson Evans Batten Catalogue", "WEB 14393"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.31208312),
        dec: Angle.Degrees(+19.92075944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168831"},
        {"Hipparcos Number", "HIP 89942"},
        {"Smithsonian Astrophysical Observation", "SAO 103634"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.27803075),
        dec: Angle.Degrees(+19.92208600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160013"},
        {"Hipparcos Number", "HIP 86199"},
        {"Geneva Identification System", "GEN# +1.00160013"},
        {"Smithsonian Astrophysical Observation", "SAO 102970"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.23236041),
        dec: Angle.Degrees(+19.92254785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207201"},
        {"Hipparcos Number", "HIP 107541"},
        {"Geneva Identification System", "GEN# +1.00207201"},
        {"Smithsonian Astrophysical Observation", "SAO 107394"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.71720999),
        dec: Angle.Degrees(+19.92344780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30632"},
        {"Hipparcos Number", "HIP 22486"},
        {"Smithsonian Astrophysical Observation", "SAO 94154"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.56375969),
        dec: Angle.Degrees(+19.92345662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 447"},
        {"Hipparcos Number", "HIP 740"},
        {"Geneva Identification System", "GEN# +1.00000447"},
        {"Smithsonian Astrophysical Observation", "SAO 91736"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26793216),
        dec: Angle.Degrees(+19.92463831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68013"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.91954483),
        dec: Angle.Degrees(+19.92625641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63680"},
        {"Smithsonian Astrophysical Observation", "SAO 82623"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.75825860),
        dec: Angle.Degrees(+19.92723153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148929"},
        {"Hipparcos Number", "HIP 80854"},
        {"Smithsonian Astrophysical Observation", "SAO 84417"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67153375),
        dec: Angle.Degrees(+19.92793504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285085"},
        {"Hipparcos Number", "HIP 23356"},
        {"Smithsonian Astrophysical Observation", "SAO 94264"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.34007026),
        dec: Angle.Degrees(+19.93052628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114072"},
        {"Hipparcos Number", "HIP 64081"},
        {"Geneva Identification System", "GEN# +1.00114072"},
        {"Smithsonian Astrophysical Observation", "SAO 82664"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.97862257),
        dec: Angle.Degrees(+19.93294344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197076"},
        {"Hipparcos Number", "HIP 102040"},
        {"Geneva Identification System", "GEN# +1.00197076"},
        {"Smithsonian Astrophysical Observation", "SAO 106373"},
        {"Wilson Evans Batten Catalogue", "WEB 18450"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.18777967),
        dec: Angle.Degrees(+19.93477741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 312.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205436"},
        {"Hipparcos Number", "HIP 106554"},
        {"Smithsonian Astrophysical Observation", "SAO 107251"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.69579544),
        dec: Angle.Degrees(+19.93640817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116132"},
        {"Geneva Identification System", "GEN# +0.01905116"},
        {"Wilson Evans Batten Catalogue", "WEB 20530"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.96597910),
        dec: Angle.Degrees(+19.93741103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 554.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85586"},
        {"Hipparcos Number", "HIP 48484"},
        {"Geneva Identification System", "GEN# +1.00085586"},
        {"Smithsonian Astrophysical Observation", "SAO 81067"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.32095086),
        dec: Angle.Degrees(+19.93790945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182620"},
        {"Hipparcos Number", "HIP 95432"},
        {"Geneva Identification System", "GEN# +1.00182620"},
        {"Smithsonian Astrophysical Observation", "SAO 104806"},
        {"Wilson Evans Batten Catalogue", "WEB 16683"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.18472666),
        dec: Angle.Degrees(+19.93940186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351710"},
        {"Hipparcos Number", "HIP 99645"},
        {"Geneva Identification System", "GEN# +1.00351710"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33414777),
        dec: Angle.Degrees(+19.94330505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123191"},
        {"Hipparcos Number", "HIP 68845"},
        {"Smithsonian Astrophysical Observation", "SAO 83160"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.45556866),
        dec: Angle.Degrees(+19.94513954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27311"},
        {"Hipparcos Number", "HIP 20175"},
        {"Smithsonian Astrophysical Observation", "SAO 93863"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.87564107),
        dec: Angle.Degrees(+19.94782961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196023"},
        {"Hipparcos Number", "HIP 101499"},
        {"Smithsonian Astrophysical Observation", "SAO 106256"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.53043780),
        dec: Angle.Degrees(+19.95090743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108652"},
        {"Hipparcos Number", "HIP 60893"},
        {"Geneva Identification System", "GEN# +1.00108652"},
        {"Smithsonian Astrophysical Observation", "SAO 82327"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.18912027),
        dec: Angle.Degrees(+19.95188820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99788"},
        {"Hipparcos Number", "HIP 56022"},
        {"Smithsonian Astrophysical Observation", "SAO 81844"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.23040798),
        dec: Angle.Degrees(+19.95310589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77269"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.63521468),
        dec: Angle.Degrees(+19.95399108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34133"},
        {"Hipparcos Number", "HIP 24535"},
        {"Geneva Identification System", "GEN# +1.00034133"},
        {"Smithsonian Astrophysical Observation", "SAO 94421"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.95913488),
        dec: Angle.Degrees(+19.95403646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25720"},
        {"Hipparcos Number", "HIP 19093"},
        {"Smithsonian Astrophysical Observation", "SAO 93753"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.40312030),
        dec: Angle.Degrees(+19.95501245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53866"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.30133869),
        dec: Angle.Degrees(+19.95526015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8991 A"},
        {"Henry Draper", "HD 119055"},
        {"Hipparcos Number", "HIP 66727"},
        {"Geneva Identification System", "GEN# +1.00119055"},
        {"Smithsonian Astrophysical Observation", "SAO 82942"},
        {"Wilson Evans Batten Catalogue", "WEB 11770"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.16874236),
        dec: Angle.Degrees(+19.95566300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79147"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.31519159),
        dec: Angle.Degrees(+19.95855442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70336"},
        {"Hipparcos Number", "HIP 41002"},
        {"Smithsonian Astrophysical Observation", "SAO 80131"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.51620609),
        dec: Angle.Degrees(+19.95928718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14708 AB"},
        {"Henry Draper", "HD 201672"},
        {"Hipparcos Number", "HIP 104533"},
        {"Smithsonian Astrophysical Observation", "SAO 106894"},
        {"Wilson Evans Batten Catalogue", "WEB 19026"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.62646551),
        dec: Angle.Degrees(+19.95936982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219954"},
        {"Hipparcos Number", "HIP 115196"},
        {"Smithsonian Astrophysical Observation", "SAO 108547"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.99849107),
        dec: Angle.Degrees(+19.96035045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199999"},
        {"Hipparcos Number", "HIP 103660"},
        {"Geneva Identification System", "GEN# +1.00199999"},
        {"Smithsonian Astrophysical Observation", "SAO 106745"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.04457632),
        dec: Angle.Degrees(+19.96132536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211718"},
        {"Hipparcos Number", "HIP 110159"},
        {"Smithsonian Astrophysical Observation", "SAO 107819"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.69581565),
        dec: Angle.Degrees(+19.96227373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36607"},
        {"Geneva Identification System", "GEN# +0.02001828"},
        {"Smithsonian Astrophysical Observation", "SAO 79472"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.92777758),
        dec: Angle.Degrees(+19.96565120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69028"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.96700005),
        dec: Angle.Degrees(+19.96589528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32159"},
        {"Hipparcos Number", "HIP 23410"},
        {"Smithsonian Astrophysical Observation", "SAO 94273"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.47209049),
        dec: Angle.Degrees(+19.96602996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47813"},
        {"Hipparcos Number", "HIP 32016"},
        {"Smithsonian Astrophysical Observation", "SAO 78639"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.32992682),
        dec: Angle.Degrees(+19.96683385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75974"},
        {"Hipparcos Number", "HIP 43683"},
        {"Geneva Identification System", "GEN# +1.00075974J"},
        {"Smithsonian Astrophysical Observation", "SAO 80491"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48061769),
        dec: Angle.Degrees(+19.96714756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81759"},
        {"Smithsonian Astrophysical Observation", "SAO 84545"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.49684066),
        dec: Angle.Degrees(+19.96742654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29103"},
        {"Hipparcos Number", "HIP 21403"},
        {"Geneva Identification System", "GEN# +1.00029103"},
        {"Smithsonian Astrophysical Observation", "SAO 94021"},
        {"Wilson Evans Batten Catalogue", "WEB 4107"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.91671982),
        dec: Angle.Degrees(+19.96894360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173633"},
        {"Hipparcos Number", "HIP 92032"},
        {"Smithsonian Astrophysical Observation", "SAO 104071"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.38004895),
        dec: Angle.Degrees(+19.96989935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73666"},
        {"Hipparcos Number", "HIP 42523"},
        {"Geneva Identification System", "GEN# +2.26320265"},
        {"Renson", "Renson 20480"},
        {"Smithsonian Astrophysical Observation", "SAO 80336"},
        {"Wilson Evans Batten Catalogue", "WEB 8198"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.04781007),
        dec: Angle.Degrees(+19.97116768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74579"},
        {"Smithsonian Astrophysical Observation", "SAO 83727"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.57779449),
        dec: Angle.Degrees(+19.97137361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63786"},
    },
    visualMagnitude: 10.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.10680427),
        dec: Angle.Degrees(+19.97169315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348466"},
        {"Hipparcos Number", "HIP 90134"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.91126271),
        dec: Angle.Degrees(+19.97450869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106328"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.02670431),
        dec: Angle.Degrees(+19.97619801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92012"},
        {"Hipparcos Number", "HIP 52028"},
        {"Fundamental Katalog 5th Edition", "FK5 4944"},
        {"Smithsonian Astrophysical Observation", "SAO 81444"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.45200661),
        dec: Angle.Degrees(+19.97638664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103847"},
        {"Hipparcos Number", "HIP 58314"},
        {"Cincinnati Publication", "Ci 20 671"},
        {"Geneva Identification System", "GEN# +1.00103847"},
        {"Smithsonian Astrophysical Observation", "SAO 82073"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.37155136),
        dec: Angle.Degrees(+19.98377097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -385.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15954"},
        {"Hipparcos Number", "HIP 11968"},
        {"Smithsonian Astrophysical Observation", "SAO 93005"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.59768799),
        dec: Angle.Degrees(+19.98477047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60046"},
        {"Smithsonian Astrophysical Observation", "SAO 82233"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.71813570),
        dec: Angle.Degrees(+19.98554907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48532"},
        {"Hipparcos Number", "HIP 32302"},
        {"Geneva Identification System", "GEN# +1.00048532"},
        {"Smithsonian Astrophysical Observation", "SAO 78694"},
        {"Wilson Evans Batten Catalogue", "WEB 6513"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.16051505),
        dec: Angle.Degrees(+19.98762000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138788"},
        {"Hipparcos Number", "HIP 76188"},
        {"Smithsonian Astrophysical Observation", "SAO 83881"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.42082011),
        dec: Angle.Degrees(+19.98983386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18508"},
        {"Hipparcos Number", "HIP 13913"},
        {"Geneva Identification System", "GEN# +1.00018508"},
        {"Smithsonian Astrophysical Observation", "SAO 93221"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.79318633),
        dec: Angle.Degrees(+19.98990007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49784"},
        {"Hipparcos Number", "HIP 32852"},
        {"Smithsonian Astrophysical Observation", "SAO 78793"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.70948002),
        dec: Angle.Degrees(+19.99055834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118389"},
        {"Hipparcos Number", "HIP 66370"},
        {"Geneva Identification System", "GEN# +1.00118389"},
        {"Smithsonian Astrophysical Observation", "SAO 82896"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.08529139),
        dec: Angle.Degrees(+19.99060309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190608"},
        {"Hipparcos Number", "HIP 98920"},
        {"Fundamental Katalog 5th Edition", "FK5 3609"},
        {"Geneva Identification System", "GEN# +1.00190608"},
        {"Smithsonian Astrophysical Observation", "SAO 105659"},
        {"Wilson Evans Batten Catalogue", "WEB 17563"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.28947757),
        dec: Angle.Degrees(+19.99087704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40531"},
        {"Hipparcos Number", "HIP 28425"},
        {"Celescope Catalog", "CEL 1055"},
        {"Geneva Identification System", "GEN# +1.00040531"},
        {"Smithsonian Astrophysical Observation", "SAO 95098"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.04070998),
        dec: Angle.Degrees(+19.99093248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153289"},
        {"Hipparcos Number", "HIP 83004"},
        {"Smithsonian Astrophysical Observation", "SAO 84721"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.42436948),
        dec: Angle.Degrees(+19.99259183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243781"},
        {"Hipparcos Number", "HIP 25510"},
        {"Smithsonian Astrophysical Observation", "SAO 94555"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.82319964),
        dec: Angle.Degrees(+19.99600767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187218"},
        {"Hipparcos Number", "HIP 97429"},
        {"Smithsonian Astrophysical Observation", "SAO 105275"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.03036503),
        dec: Angle.Degrees(+19.99672980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220900"},
        {"Hipparcos Number", "HIP 115783"},
        {"Smithsonian Astrophysical Observation", "SAO 108616"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.85030010),
        dec: Angle.Degrees(+19.99741193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1510"},
        {"Hipparcos Number", "HIP 1559"},
        {"Smithsonian Astrophysical Observation", "SAO 91846"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.84766146),
        dec: Angle.Degrees(+19.99907595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35216"},
        {"Hipparcos Number", "HIP 25250"},
        {"Geneva Identification System", "GEN# +1.00035216"},
        {"Smithsonian Astrophysical Observation", "SAO 94517"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.98775109),
        dec: Angle.Degrees(+19.99936879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284908"},
        {"Hipparcos Number", "HIP 22684"},
        {"Geneva Identification System", "GEN# +5.20250145J"},
        {"Smithsonian Astrophysical Observation", "SAO 94178"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.17484140),
        dec: Angle.Degrees(+20.00065643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58071"},
        {"Hipparcos Number", "HIP 35969"},
        {"Smithsonian Astrophysical Observation", "SAO 79370"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20701915),
        dec: Angle.Degrees(+20.00086514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19593"},
        {"Hipparcos Number", "HIP 14689"},
        {"Smithsonian Astrophysical Observation", "SAO 93309"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.44018143),
        dec: Angle.Degrees(+20.00111317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99303"},
        {"Hipparcos Number", "HIP 55772"},
        {"Geneva Identification System", "GEN# +1.00099303"},
        {"Smithsonian Astrophysical Observation", "SAO 81817"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.41697587),
        dec: Angle.Degrees(+20.00235289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31338"},
        {"Hipparcos Number", "HIP 22906"},
        {"Cincinnati Publication", "Ci 18 628"},
        {"Geneva Identification System", "GEN# +1.00031338"},
        {"Smithsonian Astrophysical Observation", "SAO 94210"},
        {"Wilson Evans Batten Catalogue", "WEB 4444"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.92316948),
        dec: Angle.Degrees(+20.00292146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50425",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7714 AB"},
        {"Henry Draper", "HD 89196"},
        {"Hipparcos Number", "HIP 50425"},
        {"Geneva Identification System", "GEN# +1.00089196J"},
        {"Smithsonian Astrophysical Observation", "SAO 81274"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.44030256),
        dec: Angle.Degrees(+20.00342791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49664"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.08324257),
        dec: Angle.Degrees(+20.00374630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82309"},
        {"Hipparcos Number", "HIP 46751"},
        {"Geneva Identification System", "GEN# +1.00082309"},
        {"Smithsonian Astrophysical Observation", "SAO 80886"},
        {"Wilson Evans Batten Catalogue", "WEB 8818"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.93346348),
        dec: Angle.Degrees(+20.00574676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202781"},
        {"Hipparcos Number", "HIP 105124"},
        {"Smithsonian Astrophysical Observation", "SAO 106999"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.42323056),
        dec: Angle.Degrees(+20.00613795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114282"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.20541609),
        dec: Angle.Degrees(+20.00626876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171873"},
        {"Hipparcos Number", "HIP 91205"},
        {"Smithsonian Astrophysical Observation", "SAO 103895"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.08529838),
        dec: Angle.Degrees(+20.00678729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73665"},
        {"Hipparcos Number", "HIP 42516"},
        {"Geneva Identification System", "GEN# +2.26320253"},
        {"Smithsonian Astrophysical Observation", "SAO 80333"},
        {"Wilson Evans Batten Catalogue", "WEB 8193"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.02683455),
        dec: Angle.Degrees(+20.00781645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93716"},
        {"Hipparcos Number", "HIP 52934"},
        {"Smithsonian Astrophysical Observation", "SAO 81539"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.38305693),
        dec: Angle.Degrees(+20.00906125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188345"},
        {"Hipparcos Number", "HIP 97918"},
        {"Geneva Identification System", "GEN# +1.00188345"},
        {"Smithsonian Astrophysical Observation", "SAO 105397"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.49857378),
        dec: Angle.Degrees(+20.00963227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17435"},
        {"Hipparcos Number", "HIP 13094"},
        {"Fundamental Katalog 5th Edition", "FK5 4257"},
        {"Geneva Identification System", "GEN# +1.00017435"},
        {"Smithsonian Astrophysical Observation", "SAO 93114"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.08339466),
        dec: Angle.Degrees(+20.01021458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2062 A"},
        {"Henry Draper", "HD 16811"},
        {"Hipparcos Number", "HIP 12640"},
        {"Geneva Identification System", "GEN# +1.00016811"},
        {"Smithsonian Astrophysical Observation", "SAO 93062"},
        {"Wilson Evans Batten Catalogue", "WEB 2573"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.59134429),
        dec: Angle.Degrees(+20.01157690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119082"},
        {"Hipparcos Number", "HIP 66729"},
        {"Geneva Identification System", "GEN# +1.00119082"},
        {"Renson", "Renson 34380"},
        {"Smithsonian Astrophysical Observation", "SAO 82943"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.17026116),
        dec: Angle.Degrees(+20.01355215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203536"},
        {"Hipparcos Number", "HIP 105517"},
        {"Geneva Identification System", "GEN# +1.00203536"},
        {"Smithsonian Astrophysical Observation", "SAO 107078"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.56702660),
        dec: Angle.Degrees(+20.01594213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8596"},
        {"Hipparcos Number", "HIP 6642"},
        {"Geneva Identification System", "GEN# +1.00008596"},
        {"Smithsonian Astrophysical Observation", "SAO 92427"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.30102664),
        dec: Angle.Degrees(+20.01602138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351972"},
        {"Hipparcos Number", "HIP 100130"},
        {"Geneva Identification System", "GEN# +1.00351972"},
        {"Smithsonian Astrophysical Observation", "SAO 105952"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.68704472),
        dec: Angle.Degrees(+20.01641294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41098",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6776 AB"},
        {"Henry Draper", "HD 70492"},
        {"Hipparcos Number", "HIP 41098"},
        {"Smithsonian Astrophysical Observation", "SAO 80143"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.76546772),
        dec: Angle.Degrees(+20.01825165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44921"},
        {"Smithsonian Astrophysical Observation", "SAO 80662"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.26543895),
        dec: Angle.Degrees(+20.02193226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74655"},
        {"Hipparcos Number", "HIP 43004"},
        {"Geneva Identification System", "GEN# +1.00074655"},
        {"Smithsonian Astrophysical Observation", "SAO 80405"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.45852513),
        dec: Angle.Degrees(+20.02243389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151409"},
        {"Hipparcos Number", "HIP 82115"},
        {"Smithsonian Astrophysical Observation", "SAO 84592"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.60546857),
        dec: Angle.Degrees(+20.02312880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176760"},
        {"Hipparcos Number", "HIP 93365"},
        {"Smithsonian Astrophysical Observation", "SAO 104360"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.25546129),
        dec: Angle.Degrees(+20.02357908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124533"},
        {"Hipparcos Number", "HIP 69511"},
        {"Smithsonian Astrophysical Observation", "SAO 83233"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44776774),
        dec: Angle.Degrees(+20.03034907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245875"},
        {"Hipparcos Number", "HIP 26568"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.73223392),
        dec: Angle.Degrees(+20.03063437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97643"},
        {"Hipparcos Number", "HIP 54895"},
        {"Geneva Identification System", "GEN# +1.00097643"},
        {"Smithsonian Astrophysical Observation", "SAO 81728"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.60180207),
        dec: Angle.Degrees(+20.03084278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102428"},
        {"Hipparcos Number", "HIP 57529"},
        {"Smithsonian Astrophysical Observation", "SAO 81994"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.86831957),
        dec: Angle.Degrees(+20.03368703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350204"},
        {"Hipparcos Number", "HIP 96692"},
        {"Smithsonian Astrophysical Observation", "SAO 105106"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.85995135),
        dec: Angle.Degrees(+20.03471649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245790"},
        {"Hipparcos Number", "HIP 26539"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.66172757),
        dec: Angle.Degrees(+20.03512694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56712"},
        {"Smithsonian Astrophysical Observation", "SAO 81908"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.41589301),
        dec: Angle.Degrees(+20.03531979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26018",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4139 AB"},
        {"Henry Draper", "HD 36524"},
        {"Hipparcos Number", "HIP 26018"},
        {"Cincinnati Publication", "Ci 18 707"},
        {"Geneva Identification System", "GEN# +1.00036524"},
        {"Smithsonian Astrophysical Observation", "SAO 77247"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.27907033),
        dec: Angle.Degrees(+20.03628221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -296.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7"},
        {"Cincinnati Publication", "Ci 18 3148"},
        {"Smithsonian Astrophysical Observation", "SAO 108952"},
        {"Wilson Evans Batten Catalogue", "WEB 3"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.02254891),
        dec: Angle.Degrees(+20.03660216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142979"},
        {"Hipparcos Number", "HIP 78110"},
        {"Smithsonian Astrophysical Observation", "SAO 84090"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.24036160),
        dec: Angle.Degrees(+20.03833666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285213"},
        {"Hipparcos Number", "HIP 23587"},
        {"Wilson Evans Batten Catalogue", "WEB 4599"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.08006044),
        dec: Angle.Degrees(+20.03936953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187751"},
        {"Hipparcos Number", "HIP 97659"},
        {"Geneva Identification System", "GEN# +1.00187751"},
        {"Renson", "Renson 51790"},
        {"Smithsonian Astrophysical Observation", "SAO 105339"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.72069595),
        dec: Angle.Degrees(+20.03946324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200907"},
        {"Hipparcos Number", "HIP 104131"},
        {"Geneva Identification System", "GEN# +1.00200907"},
        {"Smithsonian Astrophysical Observation", "SAO 106830"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.46298968),
        dec: Angle.Degrees(+20.04127060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214825"},
        {"Hipparcos Number", "HIP 111943"},
        {"Geneva Identification System", "GEN# +1.00214825"},
        {"Smithsonian Astrophysical Observation", "SAO 108089"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.12769386),
        dec: Angle.Degrees(+20.04151625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7415 B"},
        {"Hipparcos Number", "HIP 46783"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.00834919),
        dec: Angle.Degrees(+20.04288764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134852"},
        {"Hipparcos Number", "HIP 74333"},
        {"Geneva Identification System", "GEN# +1.00134852"},
        {"Smithsonian Astrophysical Observation", "SAO 83708"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.89264333),
        dec: Angle.Degrees(+20.04343034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166230"},
        {"Hipparcos Number", "HIP 88899"},
        {"Geneva Identification System", "GEN# +1.00166230"},
        {"Smithsonian Astrophysical Observation", "SAO 85770"},
        {"Wilson Evans Batten Catalogue", "WEB 15079"},
    },
    visualMagnitude: 5.10,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22024304),
        dec: Angle.Degrees(+20.04528382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83005"},
        {"Hipparcos Number", "HIP 47104"},
        {"Smithsonian Astrophysical Observation", "SAO 80918"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.00886026),
        dec: Angle.Degrees(+20.04556927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7415 A"},
        {"Henry Draper", "HD 82372"},
        {"Hipparcos Number", "HIP 46781"},
        {"Smithsonian Astrophysical Observation", "SAO 80890"},
        {"Wilson Evans Batten Catalogue", "WEB 8820"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.00632327),
        dec: Angle.Degrees(+20.04703273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154357"},
        {"Hipparcos Number", "HIP 83531"},
        {"Smithsonian Astrophysical Observation", "SAO 84802"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.07885999),
        dec: Angle.Degrees(+20.04807489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25726"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.40293370),
        dec: Angle.Degrees(+20.05081866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103558"},
        {"Smithsonian Astrophysical Observation", "SAO 106729"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.72767261),
        dec: Angle.Degrees(+20.05129828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12266",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1993 AB"},
        {"Henry Draper", "HD 16352"},
        {"Hipparcos Number", "HIP 12266"},
        {"Smithsonian Astrophysical Observation", "SAO 93031"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.47973795),
        dec: Angle.Degrees(+20.05268876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52371"},
        {"Hipparcos Number", "HIP 33861"},
        {"Smithsonian Astrophysical Observation", "SAO 78986"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.44202605),
        dec: Angle.Degrees(+20.05482312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350165"},
        {"Hipparcos Number", "HIP 96304"},
        {"Geneva Identification System", "GEN# +1.00350165"},
        {"Smithsonian Astrophysical Observation", "SAO 105000"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.71601575),
        dec: Angle.Degrees(+20.05486872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45121"},
        {"Hipparcos Number", "HIP 30647"},
        {"Smithsonian Astrophysical Observation", "SAO 78370"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.60373271),
        dec: Angle.Degrees(+20.05529633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34031"},
        {"Hipparcos Number", "HIP 24480"},
        {"Geneva Identification System", "GEN# +0.01900876"},
        {"Geneva Identification System 2", "GEN# +1.00034031"},
        {"Smithsonian Astrophysical Observation", "SAO 77054"},
        {"Wilson Evans Batten Catalogue", "WEB 4743"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.79819344),
        dec: Angle.Degrees(+20.05617857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37684"},
        {"Hipparcos Number", "HIP 26770"},
        {"Smithsonian Astrophysical Observation", "SAO 77395"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.29872150),
        dec: Angle.Degrees(+20.06253118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3855"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.32088326),
        dec: Angle.Degrees(+20.06304103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77541"},
        {"Hipparcos Number", "HIP 44477"},
        {"Smithsonian Astrophysical Observation", "SAO 80605"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.93363367),
        dec: Angle.Degrees(+20.06316237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216370"},
        {"Hipparcos Number", "HIP 112927"},
        {"Smithsonian Astrophysical Observation", "SAO 108219"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.06127968),
        dec: Angle.Degrees(+20.06430518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107382"},
        {"Hipparcos Number", "HIP 60193"},
        {"Geneva Identification System", "GEN# +1.00107382"},
        {"Smithsonian Astrophysical Observation", "SAO 82252"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.16075612),
        dec: Angle.Degrees(+20.06487110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347861"},
        {"Hipparcos Number", "HIP 88570"},
        {"Smithsonian Astrophysical Observation", "SAO 85710"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.26917728),
        dec: Angle.Degrees(+20.06550779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84249"},
        {"Smithsonian Astrophysical Observation", "SAO 84927"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.32420931),
        dec: Angle.Degrees(+20.06618308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99688"},
        {"Hipparcos Number", "HIP 55973"},
        {"Geneva Identification System", "GEN# +1.00099688"},
        {"Smithsonian Astrophysical Observation", "SAO 81842"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.04950535),
        dec: Angle.Degrees(+20.06701686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22328"},
        {"Hipparcos Number", "HIP 16813"},
        {"Geneva Identification System", "GEN# +1.00022328"},
        {"Smithsonian Astrophysical Observation", "SAO 93507"},
        {"Wilson Evans Batten Catalogue", "WEB 3199"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10118235),
        dec: Angle.Degrees(+20.06773445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14515 AB"},
        {"Henry Draper", "HD 199940"},
        {"Hipparcos Number", "HIP 103630"},
        {"Smithsonian Astrophysical Observation", "SAO 106739"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.95150886),
        dec: Angle.Degrees(+20.06923818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42707"},
        {"Hipparcos Number", "HIP 29501"},
        {"Geneva Identification System", "GEN# +1.00042707"},
        {"Smithsonian Astrophysical Observation", "SAO 78111"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24285555),
        dec: Angle.Degrees(+20.07053808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2034"},
        {"Hipparcos Number", "HIP 1956"},
        {"Smithsonian Astrophysical Observation", "SAO 91882"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.18645629),
        dec: Angle.Degrees(+20.07083674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8733"},
        {"Hipparcos Number", "HIP 6714"},
        {"Geneva Identification System", "GEN# +1.00008733"},
        {"Smithsonian Astrophysical Observation", "SAO 92439"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.59817582),
        dec: Angle.Degrees(+20.07090163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246693"},
        {"Hipparcos Number", "HIP 26951"},
        {"Smithsonian Astrophysical Observation", "SAO 77448"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.78257793),
        dec: Angle.Degrees(+20.07298087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79680"},
        {"Hipparcos Number", "HIP 45483"},
        {"Smithsonian Astrophysical Observation", "SAO 80729"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.01843556),
        dec: Angle.Degrees(+20.07319329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172501"},
        {"Hipparcos Number", "HIP 91522"},
        {"Smithsonian Astrophysical Observation", "SAO 86297"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.96226170),
        dec: Angle.Degrees(+20.07468719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147443"},
        {"Hipparcos Number", "HIP 80124"},
        {"Geneva Identification System", "GEN# +1.00147443"},
        {"Smithsonian Astrophysical Observation", "SAO 84318"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.32902088),
        dec: Angle.Degrees(+20.07659551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5224"},
        {"Hipparcos Number", "HIP 4243"},
        {"Geneva Identification System", "GEN# +1.00005224"},
        {"Smithsonian Astrophysical Observation", "SAO 92143"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.53862909),
        dec: Angle.Degrees(+20.08004142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349896"},
        {"Hipparcos Number", "HIP 94509"},
        {"Smithsonian Astrophysical Observation", "SAO 104630"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.53167778),
        dec: Angle.Degrees(+20.08029956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214838"},
        {"Hipparcos Number", "HIP 111956"},
        {"Smithsonian Astrophysical Observation", "SAO 108091"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.16707330),
        dec: Angle.Degrees(+20.08056765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68232"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.51837935),
        dec: Angle.Degrees(+20.08079139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158148"},
        {"Hipparcos Number", "HIP 85385"},
        {"Fundamental Katalog 5th Edition", "FK5 3388"},
        {"Geneva Identification System", "GEN# +1.00158148"},
        {"Smithsonian Astrophysical Observation", "SAO 85095"},
        {"Wilson Evans Batten Catalogue", "WEB 14419"},
    },
    visualMagnitude: 5.52,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.70469683),
        dec: Angle.Degrees(+20.08093784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10697"},
        {"Hipparcos Number", "HIP 8159"},
        {"Geneva Identification System", "GEN# +1.00010697"},
        {"Smithsonian Astrophysical Observation", "SAO 92611"},
        {"Wilson Evans Batten Catalogue", "WEB 1742"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.23271918),
        dec: Angle.Degrees(+20.08340568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24761"},
        {"Hipparcos Number", "HIP 18473"},
        {"Smithsonian Astrophysical Observation", "SAO 93681"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.21969756),
        dec: Angle.Degrees(+20.08364522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1876"},
        {"Hipparcos Number", "HIP 1829"},
        {"Geneva Identification System", "GEN# +1.00001876"},
        {"Smithsonian Astrophysical Observation", "SAO 91871"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.79985831),
        dec: Angle.Degrees(+20.08594679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195217"},
        {"Hipparcos Number", "HIP 101070"},
        {"Geneva Identification System", "GEN# +1.00195217"},
        {"Renson", "Renson 54410"},
        {"Smithsonian Astrophysical Observation", "SAO 106156"},
        {"Wilson Evans Batten Catalogue", "WEB 18252"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.33814442),
        dec: Angle.Degrees(+20.08771449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220462"},
        {"Hipparcos Number", "HIP 115502"},
        {"Smithsonian Astrophysical Observation", "SAO 108589"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.96317485),
        dec: Angle.Degrees(+20.08908971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260752"},
        {"Hipparcos Number", "HIP 31680"},
        {"Smithsonian Astrophysical Observation", "SAO 78564"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42747676),
        dec: Angle.Degrees(+20.09679659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351151"},
        {"Hipparcos Number", "HIP 120148"},
        {"Wilson Evans Batten Catalogue", "WEB 17469"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.75339969),
        dec: Angle.Degrees(+20.09716077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4927"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.80724267),
        dec: Angle.Degrees(+20.09773584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 671.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182919"},
        {"Hipparcos Number", "HIP 95560"},
        {"Celescope Catalog", "CEL 4749"},
        {"Geneva Identification System", "GEN# +1.00182919"},
        {"Smithsonian Astrophysical Observation", "SAO 104831"},
        {"Wilson Evans Batten Catalogue", "WEB 16708"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.55518356),
        dec: Angle.Degrees(+20.09782036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115364"},
        {"Hipparcos Number", "HIP 64776"},
        {"Smithsonian Astrophysical Observation", "SAO 82749"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.12848431),
        dec: Angle.Degrees(+20.09793619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101135"},
        {"Hipparcos Number", "HIP 56780"},
        {"Geneva Identification System", "GEN# +1.00101135"},
        {"Smithsonian Astrophysical Observation", "SAO 81917"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.61573393),
        dec: Angle.Degrees(+20.10053707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61301"},
        {"Smithsonian Astrophysical Observation", "SAO 82379"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40287653),
        dec: Angle.Degrees(+20.10309908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21663"},
        {"Hipparcos Number", "HIP 16329"},
        {"Smithsonian Astrophysical Observation", "SAO 93462"},
        {"Wilson Evans Batten Catalogue", "WEB 3119"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.62638571),
        dec: Angle.Degrees(+20.10341671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30936"},
        {"Hipparcos Number", "HIP 22672"},
        {"Smithsonian Astrophysical Observation", "SAO 76801"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.14668754),
        dec: Angle.Degrees(+20.10479701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28958",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4686 AB"},
        {"Henry Draper", "HD 41565"},
        {"Hipparcos Number", "HIP 28958"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.67591758),
        dec: Angle.Degrees(+20.10511739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63149"},
        {"Smithsonian Astrophysical Observation", "SAO 82576"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.09086733),
        dec: Angle.Degrees(+20.10529983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100761"},
        {"Hipparcos Number", "HIP 56565"},
        {"Smithsonian Astrophysical Observation", "SAO 81890"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.94814356),
        dec: Angle.Degrees(+20.10651747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204416"},
        {"Hipparcos Number", "HIP 105982"},
        {"Smithsonian Astrophysical Observation", "SAO 107155"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.96809946),
        dec: Angle.Degrees(+20.10840175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110082"},
        {"Smithsonian Astrophysical Observation", "SAO 107804"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.46456985),
        dec: Angle.Degrees(+20.10877603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195053"},
        {"Hipparcos Number", "HIP 100971"},
        {"Smithsonian Astrophysical Observation", "SAO 106143"},
        {"Wilson Evans Batten Catalogue", "WEB 18240"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.08684598),
        dec: Angle.Degrees(+20.11282765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174079"},
        {"Hipparcos Number", "HIP 92253"},
        {"Smithsonian Astrophysical Observation", "SAO 86448"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.01072092),
        dec: Angle.Degrees(+20.11285029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57070"},
        {"Hipparcos Number", "HIP 35573"},
        {"Smithsonian Astrophysical Observation", "SAO 79298"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.12663856),
        dec: Angle.Degrees(+20.11522560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86045"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.76913624),
        dec: Angle.Degrees(+20.11661698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34260"},
        {"Hipparcos Number", "HIP 24619"},
        {"Geneva Identification System", "GEN# +1.00034260"},
        {"Smithsonian Astrophysical Observation", "SAO 77076"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.20565869),
        dec: Angle.Degrees(+20.11834255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88403"},
        {"Hipparcos Number", "HIP 49966"},
        {"Geneva Identification System", "GEN# +1.00088403"},
        {"Smithsonian Astrophysical Observation", "SAO 81225"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.01223963),
        dec: Angle.Degrees(+20.11858046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67564"},
        {"Hipparcos Number", "HIP 39934"},
        {"Smithsonian Astrophysical Observation", "SAO 79979"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.32982611),
        dec: Angle.Degrees(+20.11878348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78029"},
        {"Hipparcos Number", "HIP 44705"},
        {"Smithsonian Astrophysical Observation", "SAO 80631"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63504536),
        dec: Angle.Degrees(+20.11930051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125040"},
        {"Hipparcos Number", "HIP 69751"},
        {"Geneva Identification System", "GEN# +1.00125040"},
        {"Smithsonian Astrophysical Observation", "SAO 83259"},
        {"Wilson Evans Batten Catalogue", "WEB 12147"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.13719831),
        dec: Angle.Degrees(+20.12207637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197990"},
        {"Hipparcos Number", "HIP 102535"},
        {"Geneva Identification System", "GEN# +1.00197990"},
        {"Smithsonian Astrophysical Observation", "SAO 106481"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.68391437),
        dec: Angle.Degrees(+20.12308717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17870"},
        {"Hipparcos Number", "HIP 13418"},
        {"Smithsonian Astrophysical Observation", "SAO 93159"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.19536025),
        dec: Angle.Degrees(+20.12501879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50239"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.87477967),
        dec: Angle.Degrees(+20.12677941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14379 AB"},
        {"Henry Draper", "HD 198810"},
        {"Henry Draper 2", "HD 198811"},
        {"Hipparcos Number", "HIP 103028"},
        {"Smithsonian Astrophysical Observation", "SAO 106598"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.09101108),
        dec: Angle.Degrees(+20.12821085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8094"},
        {"Henry Draper", "HD 97561"},
        {"Hipparcos Number", "HIP 54844"},
        {"Cincinnati Publication", "Ci 20 619"},
        {"Geneva Identification System", "GEN# +1.00097561"},
        {"Smithsonian Astrophysical Observation", "SAO 81725"},
        {"Wilson Evans Batten Catalogue", "WEB 9896"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.42173688),
        dec: Angle.Degrees(+20.12913087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -387.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155657"},
        {"Hipparcos Number", "HIP 84146"},
        {"Geneva Identification System", "GEN# +1.00155657"},
        {"Smithsonian Astrophysical Observation", "SAO 84912"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.05476235),
        dec: Angle.Degrees(+20.12924782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90568"},
        {"Hipparcos Number", "HIP 51219"},
        {"Smithsonian Astrophysical Observation", "SAO 81360"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.92934690),
        dec: Angle.Degrees(+20.12969910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73277"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.64263868),
        dec: Angle.Degrees(+20.13144831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24663",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3866 A"},
        {"Henry Draper", "HD 34335"},
        {"Hipparcos Number", "HIP 24663"},
        {"Geneva Identification System", "GEN# +1.00034335A"},
        {"Smithsonian Astrophysical Observation", "SAO 77084"},
        {"Wilson Evans Batten Catalogue", "WEB 4772"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.37983989),
        dec: Angle.Degrees(+20.13207090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28593"},
        {"Hipparcos Number", "HIP 21099"},
        {"Geneva Identification System", "GEN# +5.20250087"},
        {"Smithsonian Astrophysical Observation", "SAO 76638"},
        {"Wilson Evans Batten Catalogue", "WEB 4058"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.81511694),
        dec: Angle.Degrees(+20.13326396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114325"},
        {"Hipparcos Number", "HIP 64220"},
        {"Geneva Identification System", "GEN# +1.00114325"},
        {"Smithsonian Astrophysical Observation", "SAO 82683"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.42800333),
        dec: Angle.Degrees(+20.13395767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3894 A"},
        {"Henry Draper", "HD 34579"},
        {"Hipparcos Number", "HIP 24820"},
        {"Geneva Identification System", "GEN# +1.00034579A"},
        {"Smithsonian Astrophysical Observation", "SAO 77098"},
        {"Wilson Evans Batten Catalogue", "WEB 4800"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.81130353),
        dec: Angle.Degrees(+20.13466050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3894"},
        {"Hipparcos Number", "HIP 3272"},
        {"Geneva Identification System", "GEN# +1.00003894"},
        {"Smithsonian Astrophysical Observation", "SAO 92031"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.42475955),
        dec: Angle.Degrees(+20.13722011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186001"},
        {"Hipparcos Number", "HIP 96843"},
        {"Geneva Identification System", "GEN# +1.00186001"},
        {"Smithsonian Astrophysical Observation", "SAO 87567"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.27992047),
        dec: Angle.Degrees(+20.13744939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41117"},
        {"Hipparcos Number", "HIP 28716"},
        {"Celescope Catalog", "CEL 1068"},
        {"Geneva Identification System", "GEN# +1.00041117"},
        {"Smithsonian Astrophysical Observation", "SAO 77911"},
        {"Wilson Evans Batten Catalogue", "WEB 5616"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.97993150),
        dec: Angle.Degrees(+20.13845865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3990 A"},
        {"Henry Draper", "HD 35268"},
        {"Hipparcos Number", "HIP 25268"},
        {"Smithsonian Astrophysical Observation", "SAO 77146"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.06522676),
        dec: Angle.Degrees(+20.14011089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70827"},
        {"Hipparcos Number", "HIP 41231"},
        {"Smithsonian Astrophysical Observation", "SAO 80162"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.20270583),
        dec: Angle.Degrees(+20.14283346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43552"},
        {"Geneva Identification System", "GEN# +9.80009029"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.04601410),
        dec: Angle.Degrees(+20.14378526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164731"},
        {"Hipparcos Number", "HIP 88296"},
        {"Smithsonian Astrophysical Observation", "SAO 85658"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.46686443),
        dec: Angle.Degrees(+20.14470892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80845"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.64284589),
        dec: Angle.Degrees(+20.14477172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153374"},
        {"Hipparcos Number", "HIP 83068"},
        {"Smithsonian Astrophysical Observation", "SAO 84730"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.60331022),
        dec: Angle.Degrees(+20.14524027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84943"},
        {"Smithsonian Astrophysical Observation", "SAO 85026"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.39909789),
        dec: Angle.Degrees(+20.14558701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2191"},
        {"Hipparcos Number", "HIP 2058"},
        {"Geneva Identification System", "GEN# +1.00002191"},
        {"Smithsonian Astrophysical Observation", "SAO 91892"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.51535429),
        dec: Angle.Degrees(+20.14683498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72293"},
        {"Hipparcos Number", "HIP 41903"},
        {"Smithsonian Astrophysical Observation", "SAO 80242"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.16434354),
        dec: Angle.Degrees(+20.14714846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59333"},
        {"Smithsonian Astrophysical Observation", "SAO 82162"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.56972704),
        dec: Angle.Degrees(+20.14752334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61272"},
        {"Hipparcos Number", "HIP 37278"},
        {"Geneva Identification System", "GEN# +1.00061272"},
        {"Smithsonian Astrophysical Observation", "SAO 79583"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.82425646),
        dec: Angle.Degrees(+20.14852778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107743"},
        {"Hipparcos Number", "HIP 60368"},
        {"Geneva Identification System", "GEN# +1.00107743"},
        {"Smithsonian Astrophysical Observation", "SAO 82277"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.67546560),
        dec: Angle.Degrees(+20.14896784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23028"},
        {"Hipparcos Number", "HIP 17325"},
        {"Smithsonian Astrophysical Observation", "SAO 93560"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.62439998),
        dec: Angle.Degrees(+20.15009930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6613"},
        {"Hipparcos Number", "HIP 5248"},
        {"Geneva Identification System", "GEN# +1.00006613"},
        {"Smithsonian Astrophysical Observation", "SAO 92256"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.77994394),
        dec: Angle.Degrees(+20.15107026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71134"},
        {"Smithsonian Astrophysical Observation", "SAO 83396"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.21865386),
        dec: Angle.Degrees(+20.15235778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8766"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.20107412),
        dec: Angle.Degrees(+20.15279224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70826"},
        {"Hipparcos Number", "HIP 41232"},
        {"Geneva Identification System", "GEN# +1.00070826"},
        {"Renson", "Renson 19550"},
        {"Smithsonian Astrophysical Observation", "SAO 80164"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.20492584),
        dec: Angle.Degrees(+20.15300634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130024"},
        {"Hipparcos Number", "HIP 72137"},
        {"Smithsonian Astrophysical Observation", "SAO 83504"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33433188),
        dec: Angle.Degrees(+20.15618190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60820"},
        {"Hipparcos Number", "HIP 37072"},
        {"Smithsonian Astrophysical Observation", "SAO 79553"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.27275147),
        dec: Angle.Degrees(+20.15707707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61586"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.29842373),
        dec: Angle.Degrees(+20.15724754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176803"},
        {"Hipparcos Number", "HIP 93379"},
        {"Celescope Catalog", "CEL 4686"},
        {"Geneva Identification System", "GEN# +1.00176803J"},
        {"Smithsonian Astrophysical Observation", "SAO 86699"},
        {"Wilson Evans Batten Catalogue", "WEB 16191"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.28681702),
        dec: Angle.Degrees(+20.15754317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9477"},
        {"Smithsonian Astrophysical Observation", "SAO 92757"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.47669603),
        dec: Angle.Degrees(+20.15796688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8542"},
        {"Hipparcos Number", "HIP 6601"},
        {"Fundamental Katalog 5th Edition", "FK5 4129"},
        {"Geneva Identification System", "GEN# +1.00008542"},
        {"Smithsonian Astrophysical Observation", "SAO 92421"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.19489313),
        dec: Angle.Degrees(+20.15873497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348963"},
        {"Hipparcos Number", "HIP 91350"},
        {"Smithsonian Astrophysical Observation", "SAO 86261"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48150678),
        dec: Angle.Degrees(+20.16193164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78369"},
        {"Smithsonian Astrophysical Observation", "SAO 84131"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.99599651),
        dec: Angle.Degrees(+20.16430253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85361"},
        {"Hipparcos Number", "HIP 48386"},
        {"Smithsonian Astrophysical Observation", "SAO 81053"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.95587368),
        dec: Angle.Degrees(+20.16471917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160955"},
        {"Hipparcos Number", "HIP 86634"},
        {"Geneva Identification System", "GEN# +1.00160955"},
        {"Smithsonian Astrophysical Observation", "SAO 85332"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.52507582),
        dec: Angle.Degrees(+20.16622579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108208"},
        {"Smithsonian Astrophysical Observation", "SAO 107506"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83480908),
        dec: Angle.Degrees(+20.16909347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113519"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.86183597),
        dec: Angle.Degrees(+20.16962268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42896"},
        {"Hipparcos Number", "HIP 29587"},
        {"Celescope Catalog", "CEL 1130"},
        {"Geneva Identification System", "GEN# +1.00042896"},
        {"Smithsonian Astrophysical Observation", "SAO 78124"},
        {"Wilson Evans Batten Catalogue", "WEB 5818"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.52579641),
        dec: Angle.Degrees(+20.16971207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111843"},
        {"Hipparcos Number", "HIP 62792"},
        {"Geneva Identification System", "GEN# +1.00111843"},
        {"Smithsonian Astrophysical Observation", "SAO 82540"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.00656818),
        dec: Angle.Degrees(+20.16982348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86261"},
        {"Hipparcos Number", "HIP 48837"},
        {"Smithsonian Astrophysical Observation", "SAO 81111"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.42897540),
        dec: Angle.Degrees(+20.17087533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186344"},
        {"Hipparcos Number", "HIP 97020"},
        {"Smithsonian Astrophysical Observation", "SAO 87616"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.77309397),
        dec: Angle.Degrees(+20.17201870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351148"},
        {"Hipparcos Number", "HIP 98725"},
        {"Geneva Identification System", "GEN# +1.00351148"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.76433932),
        dec: Angle.Degrees(+20.17269622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9639"},
        {"Hipparcos Number", "HIP 7358"},
        {"Smithsonian Astrophysical Observation", "SAO 92519"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.70417590),
        dec: Angle.Degrees(+20.17283590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67571"},
        {"Smithsonian Astrophysical Observation", "SAO 83027"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.70070530),
        dec: Angle.Degrees(+20.17342244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38465"},
        {"Hipparcos Number", "HIP 27266"},
        {"Geneva Identification System", "GEN# +1.00038465"},
        {"Smithsonian Astrophysical Observation", "SAO 77544"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69080059),
        dec: Angle.Degrees(+20.17358765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28041",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gore's Nova"},
        {"Henry Draper", "HD 39816"},
        {"Hipparcos Number", "HIP 28041"},
        {"Geneva Identification System", "GEN# +1.00039816"},
        {"Smithsonian Astrophysical Observation", "SAO 77730"},
        {"Wilson Evans Batten Catalogue", "WEB 5491"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.95490586),
        dec: Angle.Degrees(+20.17520582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16505"},
        {"Smithsonian Astrophysical Observation", "SAO 75982"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.11320533),
        dec: Angle.Degrees(+20.17552271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38501"},
        {"Smithsonian Astrophysical Observation", "SAO 79770"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.26953102),
        dec: Angle.Degrees(+20.17865097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70085"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.13059198),
        dec: Angle.Degrees(+20.17936641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95608"},
        {"Hipparcos Number", "HIP 53954"},
        {"Fundamental Katalog 5th Edition", "FK5 2880"},
        {"Geneva Identification System", "GEN# +1.00095608"},
        {"Renson", "Renson 27540"},
        {"Smithsonian Astrophysical Observation", "SAO 81637"},
        {"Wilson Evans Batten Catalogue", "WEB 9762"},
    },
    visualMagnitude: 4.42,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.58242155),
        dec: Angle.Degrees(+20.17974575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71592"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.63020558),
        dec: Angle.Degrees(+20.18353206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158918"},
        {"Hipparcos Number", "HIP 85730"},
        {"Smithsonian Astrophysical Observation", "SAO 85166"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.78837132),
        dec: Angle.Degrees(+20.18708447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67431"},
        {"Wilson Evans Batten Catalogue", "WEB 11861"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.29825061),
        dec: Angle.Degrees(+20.19009864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 864"},
        {"Hipparcos Number", "HIP 1051"},
        {"Smithsonian Astrophysical Observation", "SAO 91778"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.27473682),
        dec: Angle.Degrees(+20.19040549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140299"},
        {"Hipparcos Number", "HIP 76905"},
        {"Geneva Identification System", "GEN# +1.00140299"},
        {"Smithsonian Astrophysical Observation", "SAO 83952"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.54961458),
        dec: Angle.Degrees(+20.19172422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266225"},
        {"Hipparcos Number", "HIP 33286"},
        {"Smithsonian Astrophysical Observation", "SAO 78869"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.86136206),
        dec: Angle.Degrees(+20.19244898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181025"},
        {"Hipparcos Number", "HIP 94847"},
        {"Smithsonian Astrophysical Observation", "SAO 87042"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.49120142),
        dec: Angle.Degrees(+20.19269610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84124"},
        {"Hipparcos Number", "HIP 47684"},
        {"Smithsonian Astrophysical Observation", "SAO 80988"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.84360154),
        dec: Angle.Degrees(+20.19321046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71052"},
        {"Hipparcos Number", "HIP 41334"},
        {"Smithsonian Astrophysical Observation", "SAO 80179"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.49691605),
        dec: Angle.Degrees(+20.19345733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170112"},
        {"Hipparcos Number", "HIP 90424"},
        {"Smithsonian Astrophysical Observation", "SAO 86065"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.74993717),
        dec: Angle.Degrees(+20.19401219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23191",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3585 AB"},
        {"Henry Draper", "HD 31797"},
        {"Hipparcos Number", "HIP 23191"},
        {"Smithsonian Astrophysical Observation", "SAO 76873"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.85688350),
        dec: Angle.Degrees(+20.19408648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162231"},
        {"Hipparcos Number", "HIP 87222"},
        {"Smithsonian Astrophysical Observation", "SAO 85441"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.29911320),
        dec: Angle.Degrees(+20.19715114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25230"},
        {"Hipparcos Number", "HIP 18762"},
        {"Geneva Identification System", "GEN# +1.00025230"},
        {"Smithsonian Astrophysical Observation", "SAO 76393"},
        {"Wilson Evans Batten Catalogue", "WEB 3611"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.27900089),
        dec: Angle.Degrees(+20.19935098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68957"},
        {"Smithsonian Astrophysical Observation", "SAO 83171"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.73866077),
        dec: Angle.Degrees(+20.19972469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76462"},
        {"Hipparcos Number", "HIP 43935"},
        {"Geneva Identification System", "GEN# +1.00076462"},
        {"Smithsonian Astrophysical Observation", "SAO 80527"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.23833189),
        dec: Angle.Degrees(+20.19984802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109740"},
        {"Smithsonian Astrophysical Observation", "SAO 107748"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.43891691),
        dec: Angle.Degrees(+20.20020789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198727"},
        {"Hipparcos Number", "HIP 102973"},
        {"Smithsonian Astrophysical Observation", "SAO 89219"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.94149640),
        dec: Angle.Degrees(+20.20025795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62346"},
        {"Hipparcos Number", "HIP 37722"},
        {"Geneva Identification System", "GEN# +1.00062346"},
        {"Smithsonian Astrophysical Observation", "SAO 79652"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.05773153),
        dec: Angle.Degrees(+20.20172783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87084"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.91644181),
        dec: Angle.Degrees(+20.20272847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180242"},
        {"Hipparcos Number", "HIP 94598"},
        {"Geneva Identification System", "GEN# +1.00180242"},
        {"Smithsonian Astrophysical Observation", "SAO 86981"},
        {"Wilson Evans Batten Catalogue", "WEB 16484"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.76120242),
        dec: Angle.Degrees(+20.20315025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151626"},
        {"Hipparcos Number", "HIP 82219"},
        {"Smithsonian Astrophysical Observation", "SAO 84610"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.94812854),
        dec: Angle.Degrees(+20.20520356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1013"},
        {"Hipparcos Number", "HIP 1168"},
        {"Fundamental Katalog 5th Edition", "FK5 1004"},
        {"Geneva Identification System", "GEN# +1.00001013"},
        {"Smithsonian Astrophysical Observation", "SAO 91792"},
        {"Wilson Evans Batten Catalogue", "WEB 207"},
    },
    visualMagnitude: 4.79,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.65045047),
        dec: Angle.Degrees(+20.20669720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249829"},
        {"Hipparcos Number", "HIP 28294"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.69802367),
        dec: Angle.Degrees(+20.20670544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18165"},
        {"Smithsonian Astrophysical Observation", "SAO 76297"},
        {"Wilson Evans Batten Catalogue", "WEB 3504"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.25680819),
        dec: Angle.Degrees(+20.20803636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104472"},
        {"Geneva Identification System", "GEN# +0.01904635"},
        {"Smithsonian Astrophysical Observation", "SAO 89494"},
    },
    visualMagnitude: 9.54,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.44741803),
        dec: Angle.Degrees(+20.20813531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142830"},
        {"Hipparcos Number", "HIP 78033"},
        {"Smithsonian Astrophysical Observation", "SAO 84083"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.99993416),
        dec: Angle.Degrees(+20.20850186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224259"},
        {"Hipparcos Number", "HIP 118016"},
        {"Smithsonian Astrophysical Observation", "SAO 108917"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.08283656),
        dec: Angle.Degrees(+20.20901374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349790"},
        {"Hipparcos Number", "HIP 93999"},
        {"Geneva Identification System", "GEN# +1.00349790"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08296332),
        dec: Angle.Degrees(+20.21009542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187730"},
        {"Hipparcos Number", "HIP 97647"},
        {"Smithsonian Astrophysical Observation", "SAO 87804"},
        {"Wilson Evans Batten Catalogue", "WEB 17171"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.68783227),
        dec: Angle.Degrees(+20.21139870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30883",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5103 A"},
        {"Henry Draper", "HD 45542"},
        {"Hipparcos Number", "HIP 30883"},
        {"Fundamental Katalog 5th Edition", "FK5 1173"},
        {"Geneva Identification System", "GEN# +1.00045542"},
        {"Smithsonian Astrophysical Observation", "SAO 78423"},
        {"Wilson Evans Batten Catalogue", "WEB 6154"},
    },
    visualMagnitude: 4.13,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.24079361),
        dec: Angle.Degrees(+20.21216720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4421"},
        {"Hipparcos Number", "HIP 3636"},
        {"Smithsonian Astrophysical Observation", "SAO 92074"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.65555914),
        dec: Angle.Degrees(+20.21267632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4654"},
        {"Hipparcos Number", "HIP 3800"},
        {"Smithsonian Astrophysical Observation", "SAO 92096"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.20147651),
        dec: Angle.Degrees(+20.21477033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108984"},
        {"Hipparcos Number", "HIP 61099"},
        {"Smithsonian Astrophysical Observation", "SAO 82349"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.82627565),
        dec: Angle.Degrees(+20.21822902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34592"},
        {"Hipparcos Number", "HIP 24835"},
        {"Smithsonian Astrophysical Observation", "SAO 77101"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.85899495),
        dec: Angle.Degrees(+20.21846765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102509"},
        {"Hipparcos Number", "HIP 57565"},
        {"Fundamental Katalog 5th Edition", "FK5 1304"},
        {"Geneva Identification System", "GEN# +1.00102509"},
        {"Smithsonian Astrophysical Observation", "SAO 81998"},
        {"Wilson Evans Batten Catalogue", "WEB 10337"},
    },
    visualMagnitude: 4.50,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.99677650),
        dec: Angle.Degrees(+20.21894121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191260"},
        {"Hipparcos Number", "HIP 99201"},
        {"Geneva Identification System", "GEN# +1.00191260"},
        {"Smithsonian Astrophysical Observation", "SAO 88230"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.08748531),
        dec: Angle.Degrees(+20.21989284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12097"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.97146537),
        dec: Angle.Degrees(+20.22022530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112076"},
        {"Smithsonian Astrophysical Observation", "SAO 108113"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.52062541),
        dec: Angle.Degrees(+20.22030977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119497"},
        {"Hipparcos Number", "HIP 66955"},
        {"Geneva Identification System", "GEN# +1.00119497"},
        {"Smithsonian Astrophysical Observation", "SAO 82962"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.84714037),
        dec: Angle.Degrees(+20.22317949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144084"},
        {"Hipparcos Number", "HIP 78651"},
        {"Smithsonian Astrophysical Observation", "SAO 84166"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.83895514),
        dec: Angle.Degrees(+20.22361509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104958"},
        {"Hipparcos Number", "HIP 58935"},
        {"Smithsonian Astrophysical Observation", "SAO 82124"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.26777335),
        dec: Angle.Degrees(+20.22422866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1364"},
        {"Hipparcos Number", "HIP 1429"},
        {"Smithsonian Astrophysical Observation", "SAO 91826"},
        {"Wilson Evans Batten Catalogue", "WEB 261"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.46346784),
        dec: Angle.Degrees(+20.22702318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154714"},
        {"Hipparcos Number", "HIP 83698"},
        {"Smithsonian Astrophysical Observation", "SAO 84836"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.59131548),
        dec: Angle.Degrees(+20.22754101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213617"},
        {"Hipparcos Number", "HIP 111278"},
        {"Fundamental Katalog 5th Edition", "FK5 3804"},
        {"Geneva Identification System", "GEN# +1.00213617"},
        {"Smithsonian Astrophysical Observation", "SAO 107986"},
        {"Wilson Evans Batten Catalogue", "WEB 19908"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.14740682),
        dec: Angle.Degrees(+20.22994480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43701"},
        {"Smithsonian Astrophysical Observation", "SAO 80493"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50223234),
        dec: Angle.Degrees(+20.23040784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12688",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2072 AB"},
        {"Henry Draper", "HD 16883"},
        {"Hipparcos Number", "HIP 12688"},
        {"Smithsonian Astrophysical Observation", "SAO 75531"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.75430367),
        dec: Angle.Degrees(+20.23062236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66551"},
        {"Hipparcos Number", "HIP 39548"},
        {"Smithsonian Astrophysical Observation", "SAO 79919"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.21936478),
        dec: Angle.Degrees(+20.23308037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16950"},
        {"Smithsonian Astrophysical Observation", "SAO 76038"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.52015763),
        dec: Angle.Degrees(+20.23396256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 804"},
        {"Hipparcos Number", "HIP 996"},
        {"Geneva Identification System", "GEN# +1.00000804"},
        {"Smithsonian Astrophysical Observation", "SAO 91771"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.11749211),
        dec: Angle.Degrees(+20.23439937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65944"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.79306133),
        dec: Angle.Degrees(+20.23715992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109741"},
        {"Hipparcos Number", "HIP 61560"},
        {"Geneva Identification System", "GEN# +1.00109741"},
        {"Smithsonian Astrophysical Observation", "SAO 82401"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.20306429),
        dec: Angle.Degrees(+20.23772994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349931"},
        {"Hipparcos Number", "HIP 94838"},
        {"Smithsonian Astrophysical Observation", "SAO 87038"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.46028065),
        dec: Angle.Degrees(+20.23853478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218172"},
        {"Hipparcos Number", "HIP 114034"},
        {"Geneva Identification System", "GEN# +1.00218172"},
        {"Smithsonian Astrophysical Observation", "SAO 108395"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.39717802),
        dec: Angle.Degrees(+20.24088581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108409",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15491 AB"},
        {"Hipparcos Number", "HIP 108409"},
        {"Smithsonian Astrophysical Observation", "SAO 90132"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.42989743),
        dec: Angle.Degrees(+20.24165075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202145"},
        {"Hipparcos Number", "HIP 104757"},
        {"Smithsonian Astrophysical Observation", "SAO 89538"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.34053091),
        dec: Angle.Degrees(+20.24169784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84006"},
        {"Smithsonian Astrophysical Observation", "SAO 84888"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.58083504),
        dec: Angle.Degrees(+20.24255257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15996",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2529 AB"},
        {"Henry Draper", "HD 21213"},
        {"Hipparcos Number", "HIP 15996"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51381770),
        dec: Angle.Degrees(+20.24558780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352627"},
        {"Hipparcos Number", "HIP 101767"},
        {"Smithsonian Astrophysical Observation", "SAO 88909"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.38297046),
        dec: Angle.Degrees(+20.24734867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183261"},
        {"Hipparcos Number", "HIP 95700"},
        {"Celescope Catalog", "CEL 4764"},
        {"Geneva Identification System", "GEN# +1.00183261"},
        {"Smithsonian Astrophysical Observation", "SAO 87240"},
        {"Wilson Evans Batten Catalogue", "WEB 16741"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.97526054),
        dec: Angle.Degrees(+20.24740333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142109"},
        {"Hipparcos Number", "HIP 77723"},
        {"Smithsonian Astrophysical Observation", "SAO 84044"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.01591317),
        dec: Angle.Degrees(+20.24820206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178890"},
        {"Hipparcos Number", "HIP 94118"},
        {"Smithsonian Astrophysical Observation", "SAO 86875"},
        {"Wilson Evans Batten Catalogue", "WEB 16392"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.39141315),
        dec: Angle.Degrees(+20.25714077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58579"},
        {"Hipparcos Number", "HIP 36156"},
        {"Geneva Identification System", "GEN# +1.00058579"},
        {"Smithsonian Astrophysical Observation", "SAO 79391"},
        {"Wilson Evans Batten Catalogue", "WEB 7201"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.73470421),
        dec: Angle.Degrees(+20.25758199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160056"},
        {"Hipparcos Number", "HIP 86215"},
        {"Geneva Identification System", "GEN# +1.00160056"},
        {"Smithsonian Astrophysical Observation", "SAO 85249"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.26830936),
        dec: Angle.Degrees(+20.25881860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182972"},
        {"Hipparcos Number", "HIP 95584"},
        {"Celescope Catalog", "CEL 4750"},
        {"Geneva Identification System", "GEN# +1.00182972"},
        {"Smithsonian Astrophysical Observation", "SAO 87209"},
        {"Wilson Evans Batten Catalogue", "WEB 16719"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.62749539),
        dec: Angle.Degrees(+20.25901017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54871"},
        {"Hipparcos Number", "HIP 34723"},
        {"Geneva Identification System", "GEN# +1.00054871"},
        {"Smithsonian Astrophysical Observation", "SAO 79143"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.84764075),
        dec: Angle.Degrees(+20.25921317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177393"},
        {"Hipparcos Number", "HIP 93604"},
        {"Smithsonian Astrophysical Observation", "SAO 86752"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.92716086),
        dec: Angle.Degrees(+20.26206639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167653"},
        {"Hipparcos Number", "HIP 89466"},
        {"Smithsonian Astrophysical Observation", "SAO 85865"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.87073315),
        dec: Angle.Degrees(+20.26387188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182422"},
        {"Hipparcos Number", "HIP 95340"},
        {"Celescope Catalog", "CEL 4742"},
        {"Geneva Identification System", "GEN# +1.00182422"},
        {"Smithsonian Astrophysical Observation", "SAO 87148"},
        {"Wilson Evans Batten Catalogue", "WEB 16663"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.94553232),
        dec: Angle.Degrees(+20.26435487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10494"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.82062504),
        dec: Angle.Degrees(+20.26529195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206043"},
        {"Hipparcos Number", "HIP 106897"},
        {"Geneva Identification System", "GEN# +1.00206043"},
        {"Smithsonian Astrophysical Observation", "SAO 89871"},
        {"Wilson Evans Batten Catalogue", "WEB 19317"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.75463604),
        dec: Angle.Degrees(+20.26545357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209599"},
        {"Hipparcos Number", "HIP 108947"},
        {"Smithsonian Astrophysical Observation", "SAO 90203"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.08229500),
        dec: Angle.Degrees(+20.26587989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 387"},
        {"Hipparcos Number", "HIP 693"},
        {"Smithsonian Astrophysical Observation", "SAO 91728"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.13025860),
        dec: Angle.Degrees(+20.26736526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10476"},
        {"Hipparcos Number", "HIP 7981"},
        {"Cincinnati Publication", "Ci 20 120"},
        {"Geneva Identification System", "GEN# +1.00010476"},
        {"Smithsonian Astrophysical Observation", "SAO 74883"},
        {"Wilson Evans Batten Catalogue", "WEB 1710"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.62479083),
        dec: Angle.Degrees(+20.27015091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -302.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -677.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82264"},
        {"Hipparcos Number", "HIP 46739"},
        {"Smithsonian Astrophysical Observation", "SAO 80882"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.89581324),
        dec: Angle.Degrees(+20.27066897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182761"},
        {"Hipparcos Number", "HIP 95487"},
        {"Celescope Catalog", "CEL 4747"},
        {"Geneva Identification System", "GEN# +1.00182761"},
        {"Smithsonian Astrophysical Observation", "SAO 87186"},
        {"Wilson Evans Batten Catalogue", "WEB 16694"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.34331486),
        dec: Angle.Degrees(+20.27176831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96529"},
        {"Hipparcos Number", "HIP 54381"},
        {"Geneva Identification System", "GEN# +1.00096529"},
        {"Smithsonian Astrophysical Observation", "SAO 81680"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.89594459),
        dec: Angle.Degrees(+20.27180576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87693"},
        {"Geneva Identification System", "GEN# +0.02003603"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.68070643),
        dec: Angle.Degrees(+20.27208367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -350.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117030"},
        {"Hipparcos Number", "HIP 65629"},
        {"Geneva Identification System", "GEN# +1.00117030"},
        {"Smithsonian Astrophysical Observation", "SAO 82847"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.83141179),
        dec: Angle.Degrees(+20.27225423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214128"},
        {"Hipparcos Number", "HIP 111541"},
        {"Smithsonian Astrophysical Observation", "SAO 90628"},
        {"Wilson Evans Batten Catalogue", "WEB 19938"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.95702027),
        dec: Angle.Degrees(+20.27456012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110614"},
        {"Smithsonian Astrophysical Observation", "SAO 90478"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.13895615),
        dec: Angle.Degrees(+20.27624176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39587"},
        {"Hipparcos Number", "HIP 27913"},
        {"Geneva Identification System", "GEN# +1.00039587"},
        {"Smithsonian Astrophysical Observation", "SAO 77705"},
        {"Wilson Evans Batten Catalogue", "WEB 5465"},
    },
    visualMagnitude: 4.39,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.59618305),
        dec: Angle.Degrees(+20.27641498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167350"},
        {"Hipparcos Number", "HIP 89352"},
        {"Smithsonian Astrophysical Observation", "SAO 85845"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.49593296),
        dec: Angle.Degrees(+20.27712071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20628"},
        {"Hipparcos Number", "HIP 15509"},
        {"Smithsonian Astrophysical Observation", "SAO 75865"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.96753536),
        dec: Angle.Degrees(+20.27719123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182293"},
        {"Hipparcos Number", "HIP 95291"},
        {"Geneva Identification System", "GEN# +1.00182293"},
        {"Smithsonian Astrophysical Observation", "SAO 87140"},
        {"Wilson Evans Batten Catalogue", "WEB 16654"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.80091793),
        dec: Angle.Degrees(+20.27770330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62650"},
        {"Smithsonian Astrophysical Observation", "SAO 82522"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.55702495),
        dec: Angle.Degrees(+20.27836467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94028"},
        {"Hipparcos Number", "HIP 53070"},
        {"Cincinnati Publication", "Ci 20 592"},
        {"Cincinnati Publication 2", "Ci 18 1307"},
        {"Geneva Identification System", "GEN# +1.00094028"},
        {"Smithsonian Astrophysical Observation", "SAO 81555"},
        {"Wilson Evans Batten Catalogue", "WEB 9645"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.86786449),
        dec: Angle.Degrees(+20.27859935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -456.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88077"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.82464496),
        dec: Angle.Degrees(+20.27935391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183537"},
        {"Hipparcos Number", "HIP 95818"},
        {"Celescope Catalog", "CEL 4772"},
        {"Geneva Identification System", "GEN# +1.00183537"},
        {"Smithsonian Astrophysical Observation", "SAO 87269"},
        {"Wilson Evans Batten Catalogue", "WEB 16772"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.33706776),
        dec: Angle.Degrees(+20.27977762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15028"},
        {"Hipparcos Number", "HIP 11329"},
        {"Geneva Identification System", "GEN# +1.00015028"},
        {"Smithsonian Astrophysical Observation", "SAO 75359"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.44602288),
        dec: Angle.Degrees(+20.28026824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68503"},
        {"Hipparcos Number", "HIP 40270"},
        {"Geneva Identification System", "GEN# +1.00068503"},
        {"Smithsonian Astrophysical Observation", "SAO 80019"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34553811),
        dec: Angle.Degrees(+20.28066452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38477"},
        {"Hipparcos Number", "HIP 27287"},
        {"Smithsonian Astrophysical Observation", "SAO 77547"},
        {"Wilson Evans Batten Catalogue", "WEB 5361"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.73630002),
        dec: Angle.Degrees(+20.28184685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84840"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.09674483),
        dec: Angle.Degrees(+20.28303437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40399"},
        {"Smithsonian Astrophysical Observation", "SAO 80038"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.71618475),
        dec: Angle.Degrees(+20.28507071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102780"},
        {"Hipparcos Number", "HIP 57714"},
        {"Geneva Identification System", "GEN# +1.00102780"},
        {"Smithsonian Astrophysical Observation", "SAO 82010"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.53348757),
        dec: Angle.Degrees(+20.28705591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195808"},
        {"Hipparcos Number", "HIP 101391"},
        {"Smithsonian Astrophysical Observation", "SAO 88819"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.22474805),
        dec: Angle.Degrees(+20.28804443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204907"},
        {"Hipparcos Number", "HIP 106249"},
        {"Smithsonian Astrophysical Observation", "SAO 89770"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.80143670),
        dec: Angle.Degrees(+20.28839660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72725",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9420 AB"},
        {"Henry Draper", "HD 131265"},
        {"Hipparcos Number", "HIP 72725"},
        {"Renson", "Renson 37300"},
        {"Smithsonian Astrophysical Observation", "SAO 83560"},
        {"Wilson Evans Batten Catalogue", "WEB 12501"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.03094991),
        dec: Angle.Degrees(+20.29068282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60433"},
        {"Cincinnati Publication", "Ci 20 702"},
        {"Geneva Identification System", "GEN# +0.02102415"},
        {"Smithsonian Astrophysical Observation", "SAO 82281"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86291935),
        dec: Angle.Degrees(+20.29103476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -408.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5891"},
        {"Hipparcos Number", "HIP 4715"},
        {"Geneva Identification System", "GEN# +1.00005891"},
        {"Smithsonian Astrophysical Observation", "SAO 74428"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13829403),
        dec: Angle.Degrees(+20.29258513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2568",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 452 A"},
        {"Henry Draper", "HD 2910"},
        {"Hipparcos Number", "HIP 2568"},
        {"Fundamental Katalog 5th Edition", "FK5 2033"},
        {"Geneva Identification System", "GEN# +1.00002910"},
        {"Smithsonian Astrophysical Observation", "SAO 74084"},
        {"Wilson Evans Batten Catalogue", "WEB 470"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.14750345),
        dec: Angle.Degrees(+20.29443334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13165 AB"},
        {"Henry Draper", "HD 189068"},
        {"Hipparcos Number", "HIP 98216"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.38450006),
        dec: Angle.Degrees(+20.29448581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104762"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.35444133),
        dec: Angle.Degrees(+20.29503985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110771"},
        {"Smithsonian Astrophysical Observation", "SAO 90508"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.62486860),
        dec: Angle.Degrees(+20.29527164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16937 AB"},
        {"Henry Draper", "HD 222610"},
        {"Hipparcos Number", "HIP 116926"},
        {"Smithsonian Astrophysical Observation", "SAO 91425"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.50887835),
        dec: Angle.Degrees(+20.29646842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54620"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.68557632),
        dec: Angle.Degrees(+20.29694516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83434"},
        {"Hipparcos Number", "HIP 47352"},
        {"Geneva Identification System", "GEN# +1.00083434"},
        {"Smithsonian Astrophysical Observation", "SAO 80950"},
        {"Wilson Evans Batten Catalogue", "WEB 8895"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.72780080),
        dec: Angle.Degrees(+20.29759483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58612"},
        {"Smithsonian Astrophysical Observation", "SAO 82103"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.29741058),
        dec: Angle.Degrees(+20.29887475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39417"},
        {"Hipparcos Number", "HIP 27829"},
        {"Geneva Identification System", "GEN# +1.00039417"},
        {"Smithsonian Astrophysical Observation", "SAO 77680"},
        {"Wilson Evans Batten Catalogue", "WEB 5452"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.32926601),
        dec: Angle.Degrees(+20.29913129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80333"},
        {"Smithsonian Astrophysical Observation", "SAO 84349"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.00113967),
        dec: Angle.Degrees(+20.30073256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122730"},
        {"Hipparcos Number", "HIP 68652"},
        {"Geneva Identification System", "GEN# +1.00122730"},
        {"Smithsonian Astrophysical Observation", "SAO 83140"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.79118180),
        dec: Angle.Degrees(+20.30123255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 404 AB"},
        {"Hipparcos Number", "HIP 2327"},
        {"Geneva Identification System", "GEN# +0.01900075J"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.42764334),
        dec: Angle.Degrees(+20.30144884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5329"},
        {"Hipparcos Number", "HIP 4316"},
        {"Smithsonian Astrophysical Observation", "SAO 74366"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.81098762),
        dec: Angle.Degrees(+20.30169148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186261"},
        {"Hipparcos Number", "HIP 96961"},
        {"Smithsonian Astrophysical Observation", "SAO 87600"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64423268),
        dec: Angle.Degrees(+20.30218165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81446"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.51885063),
        dec: Angle.Degrees(+20.30224004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208702"},
        {"Hipparcos Number", "HIP 108401"},
        {"Geneva Identification System", "GEN# +1.00208702"},
        {"Smithsonian Astrophysical Observation", "SAO 90131"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.41388685),
        dec: Angle.Degrees(+20.30240382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284149"},
        {"Hipparcos Number", "HIP 19176"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.66165858),
        dec: Angle.Degrees(+20.30313041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18721"},
        {"Smithsonian Astrophysical Observation", "SAO 76385"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.16643846),
        dec: Angle.Degrees(+20.30334561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91455"},
        {"Hipparcos Number", "HIP 51701"},
        {"Geneva Identification System", "GEN# +1.00091455"},
        {"Smithsonian Astrophysical Observation", "SAO 81416"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.46045362),
        dec: Angle.Degrees(+20.30413333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8412"},
        {"Smithsonian Astrophysical Observation", "SAO 74944"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.12864325),
        dec: Angle.Degrees(+20.30560364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74457"},
        {"Smithsonian Astrophysical Observation", "SAO 83718"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.23905155),
        dec: Angle.Degrees(+20.30769996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8221"},
        {"Geneva Identification System", "GEN# +0.01900284"},
        {"Smithsonian Astrophysical Observation", "SAO 74915"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.46455989),
        dec: Angle.Degrees(+20.30846309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142574"},
        {"Hipparcos Number", "HIP 77902"},
        {"Fundamental Katalog 5th Edition", "FK5 3257"},
        {"Geneva Identification System", "GEN# +1.00142574"},
        {"Smithsonian Astrophysical Observation", "SAO 84070"},
        {"Wilson Evans Batten Catalogue", "WEB 13172"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.64443288),
        dec: Angle.Degrees(+20.31086363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85915"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.35752730),
        dec: Angle.Degrees(+20.31086443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284713"},
        {"Hipparcos Number", "HIP 22026"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.02790487),
        dec: Angle.Degrees(+20.31191605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31620"},
        {"Hipparcos Number", "HIP 23082"},
        {"Smithsonian Astrophysical Observation", "SAO 76863"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.51473361),
        dec: Angle.Degrees(+20.31371632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31280"},
        {"Hipparcos Number", "HIP 22872"},
        {"Smithsonian Astrophysical Observation", "SAO 76836"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.79725533),
        dec: Angle.Degrees(+20.31385569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112776"},
        {"Smithsonian Astrophysical Observation", "SAO 90818"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.58520231),
        dec: Angle.Degrees(+20.31460842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62510"},
        {"Hipparcos Number", "HIP 37811"},
        {"Geneva Identification System", "GEN# +1.00062510"},
        {"Renson", "Renson 17130"},
        {"Smithsonian Astrophysical Observation", "SAO 79665"},
        {"Wilson Evans Batten Catalogue", "WEB 7469"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.28890605),
        dec: Angle.Degrees(+20.31604867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60440"},
        {"Hipparcos Number", "HIP 36894"},
        {"Smithsonian Astrophysical Observation", "SAO 79526"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.78233223),
        dec: Angle.Degrees(+20.31829810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102243"},
        {"Hipparcos Number", "HIP 57410"},
        {"Geneva Identification System", "GEN# +1.00102243"},
        {"Smithsonian Astrophysical Observation", "SAO 81978"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.54027607),
        dec: Angle.Degrees(+20.31923390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351276"},
        {"Hipparcos Number", "HIP 98784"},
        {"Geneva Identification System", "GEN# +1.00351276"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.93408659),
        dec: Angle.Degrees(+20.32333144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284562"},
        {"Hipparcos Number", "HIP 21314"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.64285787),
        dec: Angle.Degrees(+20.32491900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188212"},
        {"Hipparcos Number", "HIP 97879"},
        {"Geneva Identification System", "GEN# +1.00188212"},
        {"Renson", "Renson 51980"},
        {"Smithsonian Astrophysical Observation", "SAO 87876"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.35113662),
        dec: Angle.Degrees(+20.32740952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194072"},
        {"Hipparcos Number", "HIP 100519"},
        {"Geneva Identification System", "GEN# +1.00194072"},
        {"Smithsonian Astrophysical Observation", "SAO 88607"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.74446985),
        dec: Angle.Degrees(+20.32892720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111036"},
        {"Smithsonian Astrophysical Observation", "SAO 90548"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.42613815),
        dec: Angle.Degrees(+20.33022177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224406"},
        {"Hipparcos Number", "HIP 118125"},
        {"Fundamental Katalog 5th Edition", "FK5 6123"},
        {"Geneva Identification System", "GEN# +1.00224406"},
        {"Smithsonian Astrophysical Observation", "SAO 91608"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.40238093),
        dec: Angle.Degrees(+20.33036255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49747",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7662 AB"},
        {"Henry Draper", "HD 88022"},
        {"Henry Draper 2", "HD 88021"},
        {"Hipparcos Number", "HIP 49747"},
        {"Geneva Identification System", "GEN# +1.00088021J"},
        {"Renson", "Renson 25190"},
        {"Smithsonian Astrophysical Observation", "SAO 81208"},
        {"Wilson Evans Batten Catalogue", "WEB 9170"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.33179602),
        dec: Angle.Degrees(+20.33239439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185059"},
        {"Hipparcos Number", "HIP 96458"},
        {"Geneva Identification System", "GEN# +1.00185059"},
        {"Smithsonian Astrophysical Observation", "SAO 87447"},
        {"Wilson Evans Batten Catalogue", "WEB 16921"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.15720106),
        dec: Angle.Degrees(+20.33294892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113133",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16358 A"},
        {"Henry Draper", "HD 216671"},
        {"Henry Draper 2", "HD 216671A"},
        {"Hipparcos Number", "HIP 113133"},
        {"Geneva Identification System", "GEN# +1.00216671"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.65248869),
        dec: Angle.Degrees(+20.33315434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157934"},
        {"Hipparcos Number", "HIP 85282"},
        {"Smithsonian Astrophysical Observation", "SAO 85073"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.38906548),
        dec: Angle.Degrees(+20.33370376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140068"},
        {"Hipparcos Number", "HIP 76817"},
        {"Smithsonian Astrophysical Observation", "SAO 83940"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.25745087),
        dec: Angle.Degrees(+20.33444305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99527"},
        {"Geneva Identification System", "GEN# +8.02200019"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.98358039),
        dec: Angle.Degrees(+20.33456744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49969"},
        {"Hipparcos Number", "HIP 32956"},
        {"Smithsonian Astrophysical Observation", "SAO 78812"},
    },
    visualMagnitude: 8.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.96275453),
        dec: Angle.Degrees(+20.33558045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58008",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8342 AB"},
        {"Henry Draper", "HD 103310"},
        {"Hipparcos Number", "HIP 58008"},
        {"Smithsonian Astrophysical Observation", "SAO 82037"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.46703979),
        dec: Angle.Degrees(+20.33621925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18917"},
        {"Hipparcos Number", "HIP 14203"},
        {"Smithsonian Astrophysical Observation", "SAO 75708"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.78983827),
        dec: Angle.Degrees(+20.33622538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40813"},
        {"Smithsonian Astrophysical Observation", "SAO 80101"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.94263704),
        dec: Angle.Degrees(+20.33692256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188211"},
        {"Hipparcos Number", "HIP 97876"},
        {"Geneva Identification System", "GEN# +1.00188211"},
        {"Smithsonian Astrophysical Observation", "SAO 87874"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.34430918),
        dec: Angle.Degrees(+20.33720786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196543"},
        {"Hipparcos Number", "HIP 101766"},
        {"Smithsonian Astrophysical Observation", "SAO 88910"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.38287319),
        dec: Angle.Degrees(+20.33770313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75119"},
        {"Hipparcos Number", "HIP 43254"},
        {"Smithsonian Astrophysical Observation", "SAO 80439"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.17195516),
        dec: Angle.Degrees(+20.33779836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156455"},
        {"Hipparcos Number", "HIP 84536"},
        {"Smithsonian Astrophysical Observation", "SAO 84969"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.23498630),
        dec: Angle.Degrees(+20.33786021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116213"},
        {"Geneva Identification System", "GEN# +9.80068026"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.20060828),
        dec: Angle.Degrees(+20.33804826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 490.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66287"},
        {"Hipparcos Number", "HIP 39428"},
        {"Geneva Identification System", "GEN# +1.00066287"},
        {"Smithsonian Astrophysical Observation", "SAO 79899"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.89218974),
        dec: Angle.Degrees(+20.33859250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141849"},
        {"Hipparcos Number", "HIP 77596"},
        {"Smithsonian Astrophysical Observation", "SAO 84028"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.62952358),
        dec: Angle.Degrees(+20.34023934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15100"},
        {"Smithsonian Astrophysical Observation", "SAO 75809"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.69673738),
        dec: Angle.Degrees(+20.34134565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72942"},
        {"Hipparcos Number", "HIP 42201"},
        {"Geneva Identification System", "GEN# +2.26320534"},
        {"Renson", "Renson 20220"},
        {"Smithsonian Astrophysical Observation", "SAO 80278"},
        {"Wilson Evans Batten Catalogue", "WEB 8110"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.07276843),
        dec: Angle.Degrees(+20.34153725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163908"},
        {"Hipparcos Number", "HIP 87934"},
        {"Smithsonian Astrophysical Observation", "SAO 85583"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.44220649),
        dec: Angle.Degrees(+20.34586084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13237"},
        {"Hipparcos Number", "HIP 10088"},
        {"Smithsonian Astrophysical Observation", "SAO 75175"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.42818255),
        dec: Angle.Degrees(+20.34813163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8612"},
        {"Hipparcos Number", "HIP 6648"},
        {"Smithsonian Astrophysical Observation", "SAO 74705"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.32911091),
        dec: Angle.Degrees(+20.34958651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144601"},
        {"Hipparcos Number", "HIP 78871"},
        {"Smithsonian Astrophysical Observation", "SAO 84195"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.50260181),
        dec: Angle.Degrees(+20.35019841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74259",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9528 AB"},
        {"Hipparcos Number", "HIP 74259"},
        {"Smithsonian Astrophysical Observation", "SAO 83701"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.64639957),
        dec: Angle.Degrees(+20.35268877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92541"},
        {"Hipparcos Number", "HIP 52314"},
        {"Smithsonian Astrophysical Observation", "SAO 81471"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.34001069),
        dec: Angle.Degrees(+20.35403183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108546"},
        {"Hipparcos Number", "HIP 60834"},
        {"Geneva Identification System", "GEN# +1.00108546"},
        {"Smithsonian Astrophysical Observation", "SAO 82324"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.02419629),
        dec: Angle.Degrees(+20.35441374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62031"},
        {"Geneva Identification System", "GEN# +0.02102448"},
        {"Smithsonian Astrophysical Observation", "SAO 82451"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.71830680),
        dec: Angle.Degrees(+20.35454804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83868"},
        {"Smithsonian Astrophysical Observation", "SAO 84867"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.10541253),
        dec: Angle.Degrees(+20.35524953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217660"},
        {"Hipparcos Number", "HIP 113739"},
        {"Smithsonian Astrophysical Observation", "SAO 90961"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.52371241),
        dec: Angle.Degrees(+20.35597298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245480"},
        {"Hipparcos Number", "HIP 26387"},
        {"Smithsonian Astrophysical Observation", "SAO 77326"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26961989),
        dec: Angle.Degrees(+20.35947756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284820"},
        {"Hipparcos Number", "HIP 22356"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.18765003),
        dec: Angle.Degrees(+20.35963261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175405"},
        {"Hipparcos Number", "HIP 92785"},
        {"Fundamental Katalog 5th Edition", "FK5 5667"},
        {"Geneva Identification System", "GEN# +1.00175405"},
        {"Smithsonian Astrophysical Observation", "SAO 86561"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.61747546),
        dec: Angle.Degrees(+20.35987985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248297"},
        {"Hipparcos Number", "HIP 27626"},
        {"Smithsonian Astrophysical Observation", "SAO 77631"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.73527813),
        dec: Angle.Degrees(+20.36034869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284338"},
        {"Hipparcos Number", "HIP 20084"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.58650052),
        dec: Angle.Degrees(+20.36048023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3116"},
        {"Smithsonian Astrophysical Observation", "SAO 74178"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.91048798),
        dec: Angle.Degrees(+20.36058407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349625"},
        {"Hipparcos Number", "HIP 93106"},
        {"Smithsonian Astrophysical Observation", "SAO 86631"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.50947647),
        dec: Angle.Degrees(+20.36280493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81040"},
        {"Hipparcos Number", "HIP 46076"},
        {"Fundamental Katalog 5th Edition", "FK5 4836"},
        {"Geneva Identification System", "GEN# +1.00081040"},
        {"Smithsonian Astrophysical Observation", "SAO 80800"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.94658926),
        dec: Angle.Degrees(+20.36436667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116838",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16923 AB"},
        {"Henry Draper", "HD 222474"},
        {"Hipparcos Number", "HIP 116838"},
        {"Cincinnati Publication", "Ci 18 3106"},
        {"Geneva Identification System", "GEN# +1.00222474J"},
        {"Smithsonian Astrophysical Observation", "SAO 91418"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.21377651),
        dec: Angle.Degrees(+20.36573335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 222.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205824"},
        {"Hipparcos Number", "HIP 106753"},
        {"Smithsonian Astrophysical Observation", "SAO 89851"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.36685457),
        dec: Angle.Degrees(+20.36791326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61043"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.66152668),
        dec: Angle.Degrees(+20.36965894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101817"},
        {"Hipparcos Number", "HIP 57151"},
        {"Geneva Identification System", "GEN# +1.00101817"},
        {"Smithsonian Astrophysical Observation", "SAO 81954"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.81718977),
        dec: Angle.Degrees(+20.37050733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38082"},
        {"Cincinnati Publication", "Ci 20 441"},
        {"Geneva Identification System", "GEN# +9.80091011"},
        {"Geneva Identification System 2", "GEN# +6.10010289"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.06451337),
        dec: Angle.Degrees(+20.37053697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1451.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -989.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132599"},
        {"Hipparcos Number", "HIP 73355"},
        {"Fundamental Katalog 5th Edition", "FK5 5331"},
        {"Smithsonian Astrophysical Observation", "SAO 83606"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.86661453),
        dec: Angle.Degrees(+20.37113116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79016",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9929 B"},
        {"Hipparcos Number", "HIP 79016"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93068920),
        dec: Angle.Degrees(+20.37191673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18066"},
        {"Hipparcos Number", "HIP 13571"},
        {"Geneva Identification System", "GEN# +1.00018066"},
        {"Smithsonian Astrophysical Observation", "SAO 75633"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.70756811),
        dec: Angle.Degrees(+20.37307929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80604"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.87086472),
        dec: Angle.Degrees(+20.37394054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22115"},
        {"Hipparcos Number", "HIP 16662"},
        {"Smithsonian Astrophysical Observation", "SAO 76000"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.60551340),
        dec: Angle.Degrees(+20.37411721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50164"},
        {"Hipparcos Number", "HIP 33026"},
        {"Smithsonian Astrophysical Observation", "SAO 78825"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.21138399),
        dec: Angle.Degrees(+20.37435371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9929 A"},
        {"Henry Draper", "HD 144957"},
        {"Hipparcos Number", "HIP 79017"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93320835),
        dec: Angle.Degrees(+20.37435465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138482"},
        {"Hipparcos Number", "HIP 76039"},
        {"Geneva Identification System", "GEN# +1.00138482"},
        {"Smithsonian Astrophysical Observation", "SAO 83866"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.93892113),
        dec: Angle.Degrees(+20.37744086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18719"},
        {"Geneva Identification System", "GEN# +5.20250009"},
        {"Smithsonian Astrophysical Observation", "SAO 76384"},
        {"Wilson Evans Batten Catalogue", "WEB 3602"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.16437746),
        dec: Angle.Degrees(+20.38061015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81388"},
        {"Hipparcos Number", "HIP 46249"},
        {"Smithsonian Astrophysical Observation", "SAO 80827"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.43820928),
        dec: Angle.Degrees(+20.38076045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77770"},
        {"Smithsonian Astrophysical Observation", "SAO 84054"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.21255668),
        dec: Angle.Degrees(+20.38135468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1055"},
        {"Geneva Identification System", "GEN# +0.01900020"},
        {"Wilson Evans Batten Catalogue", "WEB 182"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.28763586),
        dec: Angle.Degrees(+20.38241602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224087"},
        {"Hipparcos Number", "HIP 117918"},
        {"Smithsonian Astrophysical Observation", "SAO 91580"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.76669676),
        dec: Angle.Degrees(+20.38480128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284215"},
        {"Hipparcos Number", "HIP 19367"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.23072852),
        dec: Angle.Degrees(+20.38612173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37820"},
        {"Smithsonian Astrophysical Observation", "SAO 79668"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.31825222),
        dec: Angle.Degrees(+20.38794756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72410"},
        {"Hipparcos Number", "HIP 41978"},
        {"Smithsonian Astrophysical Observation", "SAO 80249"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.34605383),
        dec: Angle.Degrees(+20.39011644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44597"},
        {"Hipparcos Number", "HIP 30393"},
        {"Geneva Identification System", "GEN# +1.00044597"},
        {"Smithsonian Astrophysical Observation", "SAO 78316"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.86890678),
        dec: Angle.Degrees(+20.39213316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
