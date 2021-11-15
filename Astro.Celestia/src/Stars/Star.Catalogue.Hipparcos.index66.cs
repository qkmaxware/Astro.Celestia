using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_66() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133876"},
        {"Hipparcos Number", "HIP 73943"},
        {"Smithsonian Astrophysical Observation", "SAO 120841"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.65391599),
        dec: Angle.Degrees(+05.77496690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108962"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.12874728),
        dec: Angle.Degrees(+05.77598056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71108"},
        {"Geneva Identification System", "GEN# +6.20030721"},
        {"Geneva Identification System 2", "GEN# +9.80065056"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12745069),
        dec: Angle.Degrees(+05.77684443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 323.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15096"},
        {"Hipparcos Number", "HIP 11349"},
        {"Cincinnati Publication", "Ci 18 315"},
        {"Geneva Identification System", "GEN# +1.00015096"},
        {"Smithsonian Astrophysical Observation", "SAO 110531"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.50644941),
        dec: Angle.Degrees(+05.77943598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 352.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109248"},
        {"Hipparcos Number", "HIP 61261"},
        {"Smithsonian Astrophysical Observation", "SAO 119464"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.31907820),
        dec: Angle.Degrees(+05.78152169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187059"},
        {"Hipparcos Number", "HIP 97398"},
        {"Smithsonian Astrophysical Observation", "SAO 125074"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.94222882),
        dec: Angle.Degrees(+05.78199774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216279"},
        {"Hipparcos Number", "HIP 112879"},
        {"Smithsonian Astrophysical Observation", "SAO 127804"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.88769597),
        dec: Angle.Degrees(+05.78301997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72040"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.03986741),
        dec: Angle.Degrees(+05.78472422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30365"},
        {"Hipparcos Number", "HIP 22245"},
        {"Smithsonian Astrophysical Observation", "SAO 112077"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.82464509),
        dec: Angle.Degrees(+05.78826410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86707"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.75278347),
        dec: Angle.Degrees(+05.78947598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15847 A"},
        {"Henry Draper", "HD 211924"},
        {"Hipparcos Number", "HIP 110298"},
        {"Geneva Identification System", "GEN# +1.00211924J"},
        {"Smithsonian Astrophysical Observation", "SAO 127453"},
        {"Wilson Evans Batten Catalogue", "WEB 19786"},
    },
    visualMagnitude: 5.37,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.11485393),
        dec: Angle.Degrees(+05.78949288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4014"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.86791446),
        dec: Angle.Degrees(+05.79111292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20936"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.33618872),
        dec: Angle.Degrees(+05.79464875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95980"},
        {"Hipparcos Number", "HIP 54109"},
        {"Geneva Identification System", "GEN# +1.00095980"},
        {"Smithsonian Astrophysical Observation", "SAO 118645"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.07962790),
        dec: Angle.Degrees(+05.79555998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -300.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21643"},
        {"Hipparcos Number", "HIP 16269"},
        {"Smithsonian Astrophysical Observation", "SAO 111221"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.43881213),
        dec: Angle.Degrees(+05.80041625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153477"},
        {"Hipparcos Number", "HIP 83151"},
        {"Smithsonian Astrophysical Observation", "SAO 121981"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.89372690),
        dec: Angle.Degrees(+05.80155396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40700"},
        {"Hipparcos Number", "HIP 28478"},
        {"Geneva Identification System", "GEN# +1.00040700"},
        {"Smithsonian Astrophysical Observation", "SAO 113359"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.18200775),
        dec: Angle.Degrees(+05.80286259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105219"},
        {"Hipparcos Number", "HIP 59080"},
        {"Geneva Identification System", "GEN# +1.00105219"},
        {"Smithsonian Astrophysical Observation", "SAO 119223"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.73488018),
        dec: Angle.Degrees(+05.80400811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123979"},
        {"Hipparcos Number", "HIP 69262"},
        {"Geneva Identification System", "GEN# +1.00123979"},
        {"Smithsonian Astrophysical Observation", "SAO 120327"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.68693520),
        dec: Angle.Degrees(+05.80459496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165313"},
        {"Hipparcos Number", "HIP 88576"},
        {"Smithsonian Astrophysical Observation", "SAO 123102"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.28613494),
        dec: Angle.Degrees(+05.80553790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106832"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.56443877),
        dec: Angle.Degrees(+05.80574347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105702"},
        {"Hipparcos Number", "HIP 59309"},
        {"Fundamental Katalog 5th Edition", "FK5 2973"},
        {"Geneva Identification System", "GEN# +1.00105702"},
        {"Renson", "Renson 30590"},
        {"Smithsonian Astrophysical Observation", "SAO 119249"},
        {"Wilson Evans Batten Catalogue", "WEB 10551"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.51463175),
        dec: Angle.Degrees(+05.80696343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91686"},
        {"Hipparcos Number", "HIP 51829"},
        {"Smithsonian Astrophysical Observation", "SAO 118383"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.83041755),
        dec: Angle.Degrees(+05.80707839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147410"},
        {"Hipparcos Number", "HIP 80157"},
        {"Smithsonian Astrophysical Observation", "SAO 121532"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.42561000),
        dec: Angle.Degrees(+05.80738096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221013"},
        {"Hipparcos Number", "HIP 115865"},
        {"Fundamental Katalog 5th Edition", "FK5 6074"},
        {"Smithsonian Astrophysical Observation", "SAO 128200"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.11925664),
        dec: Angle.Degrees(+05.80767306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5214"},
        {"Hipparcos Number", "HIP 4231"},
        {"Geneva Identification System", "GEN# +1.00005214"},
        {"Smithsonian Astrophysical Observation", "SAO 109527"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.49252197),
        dec: Angle.Degrees(+05.80914251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102201"},
        {"Smithsonian Astrophysical Observation", "SAO 126122"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.62022495),
        dec: Angle.Degrees(+05.81138667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63217"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.29223809),
        dec: Angle.Degrees(+05.81278241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15397"},
        {"Smithsonian Astrophysical Observation", "SAO 111113"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.62722231),
        dec: Angle.Degrees(+05.81389935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59537"},
        {"Hipparcos Number", "HIP 36505"},
        {"Geneva Identification System", "GEN# +1.00059537"},
        {"Smithsonian Astrophysical Observation", "SAO 115536"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.65757496),
        dec: Angle.Degrees(+05.81411153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199465"},
        {"Hipparcos Number", "HIP 103431"},
        {"Geneva Identification System", "GEN# +1.00199465"},
        {"Smithsonian Astrophysical Observation", "SAO 126402"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.32867573),
        dec: Angle.Degrees(+05.81455032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205702"},
        {"Hipparcos Number", "HIP 106707"},
        {"Geneva Identification System", "GEN# +1.00205702"},
        {"Smithsonian Astrophysical Observation", "SAO 126926"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.22232731),
        dec: Angle.Degrees(+05.81514299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117179"},
        {"Smithsonian Astrophysical Observation", "SAO 128366"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.35688592),
        dec: Angle.Degrees(+05.81547567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79283"},
        {"Hipparcos Number", "HIP 45252"},
        {"Smithsonian Astrophysical Observation", "SAO 117506"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.34532863),
        dec: Angle.Degrees(+05.81552898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51280"},
        {"Geneva Identification System", "GEN# +9.80043053"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.11365720),
        dec: Angle.Degrees(+05.81580764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54806"},
        {"Hipparcos Number", "HIP 34651"},
        {"Smithsonian Astrophysical Observation", "SAO 115033"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.64215489),
        dec: Angle.Degrees(+05.81766197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55922"},
        {"Hipparcos Number", "HIP 35077"},
        {"Smithsonian Astrophysical Observation", "SAO 115144"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.81245524),
        dec: Angle.Degrees(+05.81846404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103546"},
        {"Hipparcos Number", "HIP 58141"},
        {"Smithsonian Astrophysical Observation", "SAO 119117"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86761345),
        dec: Angle.Degrees(+05.81989473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126248"},
        {"Hipparcos Number", "HIP 70400"},
        {"Fundamental Katalog 5th Edition", "FK5 1375"},
        {"Geneva Identification System", "GEN# +1.00126248"},
        {"Smithsonian Astrophysical Observation", "SAO 120434"},
        {"Wilson Evans Batten Catalogue", "WEB 12217"},
    },
    visualMagnitude: 5.10,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.04745973),
        dec: Angle.Degrees(+05.82011481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35241"},
        {"Hipparcos Number", "HIP 25209"},
        {"Geneva Identification System", "GEN# +1.00035241"},
        {"Smithsonian Astrophysical Observation", "SAO 112709"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.89350839),
        dec: Angle.Degrees(+05.82191776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11160 AB"},
        {"Henry Draper", "HD 166958"},
        {"Hipparcos Number", "HIP 89252"},
        {"Smithsonian Astrophysical Observation", "SAO 123254"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.20417154),
        dec: Angle.Degrees(+05.82249814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40317"},
        {"Hipparcos Number", "HIP 28261"},
        {"Smithsonian Astrophysical Observation", "SAO 113310"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.57108103),
        dec: Angle.Degrees(+05.82261922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126201"},
        {"Hipparcos Number", "HIP 70383"},
        {"Geneva Identification System", "GEN# +1.00126201"},
        {"Smithsonian Astrophysical Observation", "SAO 120432"},
        {"Wilson Evans Batten Catalogue", "WEB 12215"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.00305678),
        dec: Angle.Degrees(+05.82293096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36953"},
        {"Hipparcos Number", "HIP 26252"},
        {"Smithsonian Astrophysical Observation", "SAO 112932"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.87167641),
        dec: Angle.Degrees(+05.82422076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64885"},
        {"Hipparcos Number", "HIP 38781"},
        {"Smithsonian Astrophysical Observation", "SAO 116138"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.06802122),
        dec: Angle.Degrees(+05.82455837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 538"},
        {"Geneva Identification System", "GEN# +9.80031025"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.63200384),
        dec: Angle.Degrees(+05.82530112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116174"},
        {"Hipparcos Number", "HIP 65204"},
        {"Smithsonian Astrophysical Observation", "SAO 119900"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.44781720),
        dec: Angle.Degrees(+05.82596203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66801"},
        {"Hipparcos Number", "HIP 39591"},
        {"Smithsonian Astrophysical Observation", "SAO 116324"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.35184162),
        dec: Angle.Degrees(+05.82750830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71979"},
        {"Cincinnati Publication", "Ci 20 879"},
        {"Geneva Identification System", "GEN# +0.00602932J"},
        {"Wilson Evans Batten Catalogue", "WEB 12393"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.82707017),
        dec: Angle.Degrees(+05.82770994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -898.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32350"},
        {"Hipparcos Number", "HIP 23469"},
        {"Smithsonian Astrophysical Observation", "SAO 112354"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68142087),
        dec: Angle.Degrees(+05.83049446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10153"},
    },
    visualMagnitude: 11.89,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.64987617),
        dec: Angle.Degrees(+05.83250344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7496 AB"},
        {"Hipparcos Number", "HIP 47639"},
        {"Smithsonian Astrophysical Observation", "SAO 117867"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.69579002),
        dec: Angle.Degrees(+05.83485856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18461"},
        {"Smithsonian Astrophysical Observation", "SAO 111515"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.17664710),
        dec: Angle.Degrees(+05.83611516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7006 A"},
        {"Henry Draper", "HD 75137"},
        {"Hipparcos Number", "HIP 43234"},
        {"Geneva Identification System", "GEN# +1.00075137J"},
        {"Smithsonian Astrophysical Observation", "SAO 117146"},
        {"Wilson Evans Batten Catalogue", "WEB 8335"},
    },
    visualMagnitude: 4.35,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.10825351),
        dec: Angle.Degrees(+05.83788486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96349"},
        {"Smithsonian Astrophysical Observation", "SAO 124824"},
    },
    visualMagnitude: 10.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.85051265),
        dec: Angle.Degrees(+05.83829713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193316"},
        {"Hipparcos Number", "HIP 100210"},
        {"Geneva Identification System", "GEN# +1.00193316"},
        {"Smithsonian Astrophysical Observation", "SAO 125680"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.87690796),
        dec: Angle.Degrees(+05.83900598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15157"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.84107042),
        dec: Angle.Degrees(+05.84071290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49932"},
        {"Hipparcos Number", "HIP 32872"},
        {"Geneva Identification System", "GEN# +1.00049932"},
        {"Smithsonian Astrophysical Observation", "SAO 114502"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74804224),
        dec: Angle.Degrees(+05.84239571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1133"},
        {"Hipparcos Number", "HIP 1249"},
        {"Smithsonian Astrophysical Observation", "SAO 109091"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.91083205),
        dec: Angle.Degrees(+05.84383899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107677"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.18141498),
        dec: Angle.Degrees(+05.84405840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186718"},
        {"Hipparcos Number", "HIP 97249"},
        {"Smithsonian Astrophysical Observation", "SAO 125035"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.47779765),
        dec: Angle.Degrees(+05.84601844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3492"},
        {"Hipparcos Number", "HIP 2991"},
        {"Smithsonian Astrophysical Observation", "SAO 109324"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.50538468),
        dec: Angle.Degrees(+05.84762092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94515"},
        {"Hipparcos Number", "HIP 53362"},
        {"Smithsonian Astrophysical Observation", "SAO 118571"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.68992521),
        dec: Angle.Degrees(+05.84784787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48393"},
        {"Hipparcos Number", "HIP 32212"},
        {"Smithsonian Astrophysical Observation", "SAO 114321"},
        {"Wilson Evans Batten Catalogue", "WEB 6495"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.86208883),
        dec: Angle.Degrees(+05.84879751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49104"},
        {"Smithsonian Astrophysical Observation", "SAO 118055"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.32698989),
        dec: Angle.Degrees(+05.84994165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117877"},
        {"Hipparcos Number", "HIP 66113"},
        {"Geneva Identification System", "GEN# +1.00117877"},
        {"Smithsonian Astrophysical Observation", "SAO 119993"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.28823140),
        dec: Angle.Degrees(+05.85301792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152466"},
        {"Hipparcos Number", "HIP 82612"},
        {"Geneva Identification System", "GEN# +1.00152466"},
        {"Smithsonian Astrophysical Observation", "SAO 121924"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.33095329),
        dec: Angle.Degrees(+05.85334601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95921"},
        {"Hipparcos Number", "HIP 54093"},
        {"Smithsonian Astrophysical Observation", "SAO 118642"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.02855752),
        dec: Angle.Degrees(+05.85510020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48284"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.66562681),
        dec: Angle.Degrees(+05.85842547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63774"},
        {"Hipparcos Number", "HIP 38301"},
        {"Smithsonian Astrophysical Observation", "SAO 116013"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.70244133),
        dec: Angle.Degrees(+05.85924245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39773"},
        {"Hipparcos Number", "HIP 27962"},
        {"Celescope Catalog", "CEL 1032"},
        {"Geneva Identification System", "GEN# +1.00039773J"},
        {"Smithsonian Astrophysical Observation", "SAO 113267"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73104621),
        dec: Angle.Degrees(+05.86081431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53054"},
        {"Hipparcos Number", "HIP 34056"},
        {"Fundamental Katalog 5th Edition", "FK5 4637"},
        {"Geneva Identification System", "GEN# +1.00053054"},
        {"Smithsonian Astrophysical Observation", "SAO 114849"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.96794232),
        dec: Angle.Degrees(+05.86092119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60803"},
        {"Hipparcos Number", "HIP 37031"},
        {"Geneva Identification System", "GEN# +1.00060803"},
        {"Smithsonian Astrophysical Observation", "SAO 115693"},
        {"Wilson Evans Batten Catalogue", "WEB 7346"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.14487545),
        dec: Angle.Degrees(+05.86210427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100436"},
        {"Hipparcos Number", "HIP 56384"},
        {"Smithsonian Astrophysical Observation", "SAO 118921"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.37591832),
        dec: Angle.Degrees(+05.86211971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90279"},
        {"Hipparcos Number", "HIP 51023"},
        {"Geneva Identification System", "GEN# +1.00090279"},
        {"Smithsonian Astrophysical Observation", "SAO 118290"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.35188288),
        dec: Angle.Degrees(+05.86572807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 854 AB"},
        {"Henry Draper", "HD 6094"},
        {"Hipparcos Number", "HIP 4841"},
        {"Geneva Identification System", "GEN# +1.00006094J"},
        {"Smithsonian Astrophysical Observation", "SAO 109616"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.57312996),
        dec: Angle.Degrees(+05.86663381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45910"},
        {"Hipparcos Number", "HIP 31019"},
        {"Celescope Catalog", "CEL 1268"},
        {"Geneva Identification System", "GEN# +1.00045910"},
        {"Smithsonian Astrophysical Observation", "SAO 113974"},
        {"Wilson Evans Batten Catalogue", "WEB 6174"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.63723923),
        dec: Angle.Degrees(+05.86700418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110414"},
        {"Hipparcos Number", "HIP 61952"},
        {"Smithsonian Astrophysical Observation", "SAO 119537"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.45691864),
        dec: Angle.Degrees(+05.86800736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21440"},
        {"Hipparcos Number", "HIP 16108"},
        {"Smithsonian Astrophysical Observation", "SAO 111200"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.88311351),
        dec: Angle.Degrees(+05.87053873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30124"},
        {"Hipparcos Number", "HIP 22084"},
        {"Smithsonian Astrophysical Observation", "SAO 112040"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.26649533),
        dec: Angle.Degrees(+05.87171959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5614"},
        {"Hipparcos Number", "HIP 4518"},
        {"Smithsonian Astrophysical Observation", "SAO 109559"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.47524990),
        dec: Angle.Degrees(+05.87180502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11321"},
        {"Hipparcos Number", "HIP 8648"},
        {"Smithsonian Astrophysical Observation", "SAO 110172"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.86897233),
        dec: Angle.Degrees(+05.87267706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106076"},
        {"Hipparcos Number", "HIP 59510"},
        {"Smithsonian Astrophysical Observation", "SAO 119270"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.07361782),
        dec: Angle.Degrees(+05.87291700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124898"},
        {"Hipparcos Number", "HIP 69708"},
        {"Smithsonian Astrophysical Observation", "SAO 120374"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.02323247),
        dec: Angle.Degrees(+05.87685555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108816"},
        {"Hipparcos Number", "HIP 61004"},
        {"Geneva Identification System", "GEN# +1.00108816"},
        {"Smithsonian Astrophysical Observation", "SAO 119432"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.54687321),
        dec: Angle.Degrees(+05.87701720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258857"},
        {"Hipparcos Number", "HIP 31069"},
        {"Smithsonian Astrophysical Observation", "SAO 113987"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.79655734),
        dec: Angle.Degrees(+05.87708409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145230"},
        {"Hipparcos Number", "HIP 79178"},
        {"Smithsonian Astrophysical Observation", "SAO 121399"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.40858215),
        dec: Angle.Degrees(+05.87709740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96531"},
        {"Hipparcos Number", "HIP 54378"},
        {"Smithsonian Astrophysical Observation", "SAO 118673"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.88305389),
        dec: Angle.Degrees(+05.87716794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82524"},
        {"Hipparcos Number", "HIP 46834"},
        {"Smithsonian Astrophysical Observation", "SAO 117756"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.15847936),
        dec: Angle.Degrees(+05.87818818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132297"},
        {"Hipparcos Number", "HIP 73243"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.53938387),
        dec: Angle.Degrees(+05.87866652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215860"},
        {"Hipparcos Number", "HIP 112586"},
        {"Geneva Identification System", "GEN# +1.00215860"},
        {"Smithsonian Astrophysical Observation", "SAO 127771"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.03895100),
        dec: Angle.Degrees(+05.87918120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152897"},
        {"Hipparcos Number", "HIP 82862"},
        {"Geneva Identification System", "GEN# +1.00152897"},
        {"Smithsonian Astrophysical Observation", "SAO 121947"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.00813582),
        dec: Angle.Degrees(+05.87969255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197737"},
        {"Hipparcos Number", "HIP 102439"},
        {"Smithsonian Astrophysical Observation", "SAO 126179"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.36670759),
        dec: Angle.Degrees(+05.88145473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172046"},
        {"Hipparcos Number", "HIP 91338"},
        {"Geneva Identification System", "GEN# +3.47560062"},
        {"Smithsonian Astrophysical Observation", "SAO 123726"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.45187477),
        dec: Angle.Degrees(+05.88346889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38659"},
        {"Hipparcos Number", "HIP 27362"},
        {"Smithsonian Astrophysical Observation", "SAO 113147"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.92422471),
        dec: Angle.Degrees(+05.88377023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191160"},
        {"Hipparcos Number", "HIP 99195"},
        {"Geneva Identification System", "GEN# +1.00191160"},
        {"Smithsonian Astrophysical Observation", "SAO 125487"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.07768860),
        dec: Angle.Degrees(+05.88379412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7782"},
        {"Hipparcos Number", "HIP 6040"},
        {"Geneva Identification System", "GEN# +1.00007782"},
        {"Smithsonian Astrophysical Observation", "SAO 109791"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.39803600),
        dec: Angle.Degrees(+05.88436641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219905"},
        {"Hipparcos Number", "HIP 115149"},
        {"Smithsonian Astrophysical Observation", "SAO 128114"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.86889439),
        dec: Angle.Degrees(+05.88487409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71438"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.13362158),
        dec: Angle.Degrees(+05.88658859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257154"},
        {"Hipparcos Number", "HIP 30600"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.46057144),
        dec: Angle.Degrees(+05.88675167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191282"},
        {"Hipparcos Number", "HIP 99263"},
        {"Smithsonian Astrophysical Observation", "SAO 125499"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.24927646),
        dec: Angle.Degrees(+05.88732548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215778"},
        {"Hipparcos Number", "HIP 112521"},
        {"Geneva Identification System", "GEN# +1.00215778"},
        {"Smithsonian Astrophysical Observation", "SAO 127764"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.87414216),
        dec: Angle.Degrees(+05.88833941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189355"},
        {"Hipparcos Number", "HIP 98394"},
        {"Smithsonian Astrophysical Observation", "SAO 125314"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.87208589),
        dec: Angle.Degrees(+05.88931906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34984"},
        {"Smithsonian Astrophysical Observation", "SAO 115117"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.57445316),
        dec: Angle.Degrees(+05.88939837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3460"},
    },
    visualMagnitude: 12.01,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.06863501),
        dec: Angle.Degrees(+05.89285419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177625"},
        {"Hipparcos Number", "HIP 93744"},
        {"Smithsonian Astrophysical Observation", "SAO 124247"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.33340553),
        dec: Angle.Degrees(+05.89378465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265698"},
        {"Hipparcos Number", "HIP 33031"},
        {"Smithsonian Astrophysical Observation", "SAO 114560"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.22879607),
        dec: Angle.Degrees(+05.89387720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76631"},
        {"Hipparcos Number", "HIP 44004"},
        {"Geneva Identification System", "GEN# +1.00076631"},
        {"Smithsonian Astrophysical Observation", "SAO 117299"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.40092945),
        dec: Angle.Degrees(+05.89588358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125488"},
        {"Hipparcos Number", "HIP 70020"},
        {"Geneva Identification System", "GEN# +1.00125488"},
        {"Smithsonian Astrophysical Observation", "SAO 120401"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.90738650),
        dec: Angle.Degrees(+05.89634069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146084"},
        {"Hipparcos Number", "HIP 79581"},
        {"Geneva Identification System", "GEN# +1.00146084"},
        {"Smithsonian Astrophysical Observation", "SAO 121443"},
        {"Wilson Evans Batten Catalogue", "WEB 13465"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.55658859),
        dec: Angle.Degrees(+05.90189736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155501"},
        {"Hipparcos Number", "HIP 84120"},
        {"Smithsonian Astrophysical Observation", "SAO 122165"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.96207978),
        dec: Angle.Degrees(+05.90220542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66662"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.99373188),
        dec: Angle.Degrees(+05.90410933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81834"},
        {"Hipparcos Number", "HIP 46437"},
        {"Smithsonian Astrophysical Observation", "SAO 117713"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.06049395),
        dec: Angle.Degrees(+05.90496087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167306"},
        {"Hipparcos Number", "HIP 89385"},
        {"Smithsonian Astrophysical Observation", "SAO 123282"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.60904413),
        dec: Angle.Degrees(+05.90643917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16128 A"},
        {"Henry Draper", "HD 214423"},
        {"Hipparcos Number", "HIP 111724"},
        {"Smithsonian Astrophysical Observation", "SAO 127645"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.47036556),
        dec: Angle.Degrees(+05.90715043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14731"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.56476606),
        dec: Angle.Degrees(+05.91011097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -551.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50867"},
        {"Hipparcos Number", "HIP 33275"},
        {"Geneva Identification System", "GEN# +1.00050867"},
        {"Smithsonian Astrophysical Observation", "SAO 114620"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.82264667),
        dec: Angle.Degrees(+05.91045955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176029"},
        {"Hipparcos Number", "HIP 93101"},
        {"Cincinnati Publication", "Ci 18 2475"},
        {"Cincinnati Publication 2", "Ci 20 1120"},
        {"Geneva Identification System", "GEN# +1.00176029"},
        {"Smithsonian Astrophysical Observation", "SAO 124104"},
        {"Wilson Evans Batten Catalogue", "WEB 16126"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.50104782),
        dec: Angle.Degrees(+05.91108971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1221.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142862"},
        {"Hipparcos Number", "HIP 78088"},
        {"Smithsonian Astrophysical Observation", "SAO 121273"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.17236546),
        dec: Angle.Degrees(+05.91121366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107153",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15236"},
        {"Aitken 2", "ADS 15236 AB"},
        {"Henry Draper", "HD 206512"},
        {"Hipparcos Number", "HIP 107153"},
        {"Smithsonian Astrophysical Observation", "SAO 127003"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.57686981),
        dec: Angle.Degrees(+05.91194340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92151"},
        {"Hipparcos Number", "HIP 52075"},
        {"Smithsonian Astrophysical Observation", "SAO 118407"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.61507695),
        dec: Angle.Degrees(+05.91366284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107728"},
        {"Hipparcos Number", "HIP 60366"},
        {"Smithsonian Astrophysical Observation", "SAO 119362"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.67096856),
        dec: Angle.Degrees(+05.91495874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221993"},
        {"Hipparcos Number", "HIP 116521"},
        {"Smithsonian Astrophysical Observation", "SAO 128283"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.20218304),
        dec: Angle.Degrees(+05.91661598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58924"},
        {"Hipparcos Number", "HIP 36253"},
        {"Smithsonian Astrophysical Observation", "SAO 115473"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.97373687),
        dec: Angle.Degrees(+05.91791854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54539"},
        {"Hipparcos Number", "HIP 34550"},
        {"Geneva Identification System", "GEN# +1.00054539"},
        {"Smithsonian Astrophysical Observation", "SAO 115001"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.36878682),
        dec: Angle.Degrees(+05.92064792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122366"},
        {"Hipparcos Number", "HIP 68509"},
        {"Smithsonian Astrophysical Observation", "SAO 120231"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.36604385),
        dec: Angle.Degrees(+05.92090004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45507"},
        {"Hipparcos Number", "HIP 30781"},
        {"Geneva Identification System", "GEN# +1.00045507"},
        {"Smithsonian Astrophysical Observation", "SAO 113922"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.01204473),
        dec: Angle.Degrees(+05.92254653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19749"},
        {"Smithsonian Astrophysical Observation", "SAO 111676"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.50334798),
        dec: Angle.Degrees(+05.92450890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1847"},
        {"Smithsonian Astrophysical Observation", "SAO 109171"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.83422956),
        dec: Angle.Degrees(+05.92540540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115385"},
        {"Hipparcos Number", "HIP 64795"},
        {"Smithsonian Astrophysical Observation", "SAO 119848"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.20670516),
        dec: Angle.Degrees(+05.92584442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168699"},
        {"Hipparcos Number", "HIP 89923"},
        {"Smithsonian Astrophysical Observation", "SAO 123379"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.23330139),
        dec: Angle.Degrees(+05.92682553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100510"},
        {"Hipparcos Number", "HIP 56421"},
        {"Smithsonian Astrophysical Observation", "SAO 118928"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.52248624),
        dec: Angle.Degrees(+05.92687772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121372"},
        {"Hipparcos Number", "HIP 67939"},
        {"Geneva Identification System", "GEN# +1.00121372"},
        {"Smithsonian Astrophysical Observation", "SAO 120167"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.70140041),
        dec: Angle.Degrees(+05.92694232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67715"},
        {"Hipparcos Number", "HIP 39954"},
        {"Geneva Identification System", "GEN# +1.00067715"},
        {"Smithsonian Astrophysical Observation", "SAO 116414"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.38449829),
        dec: Angle.Degrees(+05.92709585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224091"},
        {"Hipparcos Number", "HIP 117914"},
        {"Smithsonian Astrophysical Observation", "SAO 128465"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.75643213),
        dec: Angle.Degrees(+05.92834770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39050"},
        {"Hipparcos Number", "HIP 27565"},
        {"Smithsonian Astrophysical Observation", "SAO 113188"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.56939937),
        dec: Angle.Degrees(+05.92896739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43528"},
        {"Hipparcos Number", "HIP 29837"},
        {"Smithsonian Astrophysical Observation", "SAO 113672"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.23658591),
        dec: Angle.Degrees(+05.93127993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160725"},
        {"Hipparcos Number", "HIP 86553"},
        {"Smithsonian Astrophysical Observation", "SAO 122641"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.31932809),
        dec: Angle.Degrees(+05.93262764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126647"},
        {"Hipparcos Number", "HIP 70616"},
        {"Smithsonian Astrophysical Observation", "SAO 120464"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.67591015),
        dec: Angle.Degrees(+05.93519729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21243"},
        {"Hipparcos Number", "HIP 15978"},
        {"Geneva Identification System", "GEN# +1.00021243"},
        {"Smithsonian Astrophysical Observation", "SAO 111181"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.43429052),
        dec: Angle.Degrees(+05.93548347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18058"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.89740953),
        dec: Angle.Degrees(+05.93872762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108439",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15493 A"},
        {"Henry Draper", "HD 208718"},
        {"Hipparcos Number", "HIP 108439"},
        {"Renson", "Renson 58040"},
        {"Smithsonian Astrophysical Observation", "SAO 127196"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.50602049),
        dec: Angle.Degrees(+05.94038755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15493 B"},
        {"Hipparcos Number", "HIP 108441"},
        {"Smithsonian Astrophysical Observation", "SAO 127198"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.50852903),
        dec: Angle.Degrees(+05.94206981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76294"},
        {"Hipparcos Number", "HIP 43813"},
        {"Fundamental Katalog 5th Edition", "FK5 334"},
        {"Geneva Identification System", "GEN# +1.00076294"},
        {"Smithsonian Astrophysical Observation", "SAO 117264"},
        {"Wilson Evans Batten Catalogue", "WEB 8426"},
    },
    visualMagnitude: 3.11,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.84868687),
        dec: Angle.Degrees(+05.94552770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25813",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4115 AB"},
        {"Henry Draper", "HD 36267"},
        {"Hipparcos Number", "HIP 25813"},
        {"Celescope Catalog", "CEL 742"},
        {"Geneva Identification System", "GEN# +1.00036267J"},
        {"Smithsonian Astrophysical Observation", "SAO 112849"},
        {"Wilson Evans Batten Catalogue", "WEB 5015"},
    },
    visualMagnitude: 4.20,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.69603301),
        dec: Angle.Degrees(+05.94821792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198741"},
        {"Hipparcos Number", "HIP 103021"},
        {"Geneva Identification System", "GEN# +1.00198741"},
        {"Renson", "Renson 55310"},
        {"Smithsonian Astrophysical Observation", "SAO 126318"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.07968805),
        dec: Angle.Degrees(+05.94906414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111133"},
        {"Hipparcos Number", "HIP 62376"},
        {"Geneva Identification System", "GEN# +1.00111133"},
        {"Renson", "Renson 32310"},
        {"Smithsonian Astrophysical Observation", "SAO 119585"},
        {"Wilson Evans Batten Catalogue", "WEB 11076"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.75953626),
        dec: Angle.Degrees(+05.95050840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137426"},
        {"Hipparcos Number", "HIP 75537"},
        {"Smithsonian Astrophysical Observation", "SAO 120996"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.47493090),
        dec: Angle.Degrees(+05.95082934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215461"},
        {"Hipparcos Number", "HIP 112335"},
        {"Smithsonian Astrophysical Observation", "SAO 127731"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.30213466),
        dec: Angle.Degrees(+05.95100155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10855"},
        {"Hipparcos Number", "HIP 8267"},
        {"Smithsonian Astrophysical Observation", "SAO 110120"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.62716561),
        dec: Angle.Degrees(+05.95352578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259657"},
        {"Hipparcos Number", "HIP 31281"},
        {"Smithsonian Astrophysical Observation", "SAO 114046"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.41098305),
        dec: Angle.Degrees(+05.95396475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72447",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9392 AB"},
        {"Henry Draper", "HD 130604"},
        {"Hipparcos Number", "HIP 72447"},
        {"Geneva Identification System", "GEN# +1.00130604"},
        {"Smithsonian Astrophysical Observation", "SAO 120673"},
        {"Wilson Evans Batten Catalogue", "WEB 12450"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.22186546),
        dec: Angle.Degrees(+05.95461619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141693"},
        {"Hipparcos Number", "HIP 77570"},
        {"Fundamental Katalog 5th Edition", "FK5 5401"},
        {"Smithsonian Astrophysical Observation", "SAO 121214"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.54949912),
        dec: Angle.Degrees(+05.95483639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113324"},
        {"Hipparcos Number", "HIP 63663"},
        {"Smithsonian Astrophysical Observation", "SAO 119737"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.71758744),
        dec: Angle.Degrees(+05.95498736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2477"},
        {"Smithsonian Astrophysical Observation", "SAO 109250"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.86361146),
        dec: Angle.Degrees(+05.95506002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113923"},
        {"Hipparcos Number", "HIP 64008"},
        {"Smithsonian Astrophysical Observation", "SAO 119769"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.74018625),
        dec: Angle.Degrees(+05.95528784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224689"},
        {"Hipparcos Number", "HIP 118320"},
        {"Fundamental Katalog 5th Edition", "FK5 6125"},
        {"Smithsonian Astrophysical Observation", "SAO 128521"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.97605747),
        dec: Angle.Degrees(+05.95663786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3089"},
        {"Hipparcos Number", "HIP 2688"},
        {"Geneva Identification System", "GEN# +1.00003089"},
        {"Smithsonian Astrophysical Observation", "SAO 109282"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.53455921),
        dec: Angle.Degrees(+05.95782025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212380"},
        {"Hipparcos Number", "HIP 110544"},
        {"Smithsonian Astrophysical Observation", "SAO 127503"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.91108475),
        dec: Angle.Degrees(+05.95819416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200790"},
        {"Hipparcos Number", "HIP 104101"},
        {"Geneva Identification System", "GEN# +1.00200790"},
        {"Smithsonian Astrophysical Observation", "SAO 126535"},
        {"Wilson Evans Batten Catalogue", "WEB 18960"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.36162027),
        dec: Angle.Degrees(+05.95848857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85709"},
        {"Hipparcos Number", "HIP 48519"},
        {"Geneva Identification System", "GEN# +1.00085709"},
        {"Smithsonian Astrophysical Observation", "SAO 117975"},
        {"Wilson Evans Batten Catalogue", "WEB 9040"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.42886212),
        dec: Angle.Degrees(+05.95856912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108678"},
        {"Hipparcos Number", "HIP 60915"},
        {"Geneva Identification System", "GEN# +1.00108678"},
        {"Smithsonian Astrophysical Observation", "SAO 119424"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.26601961),
        dec: Angle.Degrees(+05.96066124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126697"},
        {"Hipparcos Number", "HIP 70651"},
        {"Smithsonian Astrophysical Observation", "SAO 120469"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.75633461),
        dec: Angle.Degrees(+05.96227099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70457"},
        {"Hipparcos Number", "HIP 41020"},
        {"Smithsonian Astrophysical Observation", "SAO 116681"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.56494522),
        dec: Angle.Degrees(+05.96249750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81386"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.31818704),
        dec: Angle.Degrees(+05.96263550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97645"},
        {"Hipparcos Number", "HIP 54887"},
        {"Smithsonian Astrophysical Observation", "SAO 118736"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.57837479),
        dec: Angle.Degrees(+05.96475565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61369",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8598 AB"},
        {"Henry Draper", "HD 109427"},
        {"Hipparcos Number", "HIP 61369"},
        {"Smithsonian Astrophysical Observation", "SAO 119480"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.63625847),
        dec: Angle.Degrees(+05.96585575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209776"},
        {"Hipparcos Number", "HIP 109069"},
        {"Smithsonian Astrophysical Observation", "SAO 127287"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.42346067),
        dec: Angle.Degrees(+05.96649281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122328"},
        {"Hipparcos Number", "HIP 68484"},
        {"Smithsonian Astrophysical Observation", "SAO 120227"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.31094574),
        dec: Angle.Degrees(+05.97010000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148711"},
        {"Hipparcos Number", "HIP 80797"},
        {"Geneva Identification System", "GEN# +1.00148711"},
        {"Smithsonian Astrophysical Observation", "SAO 121646"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.46296261),
        dec: Angle.Degrees(+05.97077586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175057"},
        {"Hipparcos Number", "HIP 92706"},
        {"Smithsonian Astrophysical Observation", "SAO 124012"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.35197372),
        dec: Angle.Degrees(+05.97147675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107937"},
        {"Hipparcos Number", "HIP 60500"},
        {"Fundamental Katalog 5th Edition", "FK5 5094"},
        {"Geneva Identification System", "GEN# +1.00107937"},
        {"Smithsonian Astrophysical Observation", "SAO 119372"},
        {"Wilson Evans Batten Catalogue", "WEB 10759"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.04788363),
        dec: Angle.Degrees(+05.97160900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95400"},
        {"Hipparcos Number", "HIP 53845"},
        {"Smithsonian Astrophysical Observation", "SAO 118616"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.22708580),
        dec: Angle.Degrees(+05.97162030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69701"},
        {"Hipparcos Number", "HIP 40689"},
        {"Smithsonian Astrophysical Observation", "SAO 116604"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59565339),
        dec: Angle.Degrees(+05.97169800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209077"},
        {"Hipparcos Number", "HIP 108641"},
        {"Geneva Identification System", "GEN# +1.00209077"},
        {"Smithsonian Astrophysical Observation", "SAO 127228"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.13981778),
        dec: Angle.Degrees(+05.97187440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202110"},
        {"Hipparcos Number", "HIP 104784"},
        {"Smithsonian Astrophysical Observation", "SAO 126631"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.41369505),
        dec: Angle.Degrees(+05.97217401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9212"},
        {"Hipparcos Number", "HIP 7046"},
        {"Smithsonian Astrophysical Observation", "SAO 109935"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.70906231),
        dec: Angle.Degrees(+05.97359761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89069"},
        {"Smithsonian Astrophysical Observation", "SAO 123216"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.67895620),
        dec: Angle.Degrees(+05.97945658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114301"},
        {"Hipparcos Number", "HIP 64211"},
        {"Geneva Identification System", "GEN# +1.00114301"},
        {"Smithsonian Astrophysical Observation", "SAO 119796"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.40524536),
        dec: Angle.Degrees(+05.97973963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195467"},
        {"Hipparcos Number", "HIP 101247"},
        {"Geneva Identification System", "GEN# +1.00195467"},
        {"Smithsonian Astrophysical Observation", "SAO 125892"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.84113887),
        dec: Angle.Degrees(+05.97994453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68541"},
        {"Smithsonian Astrophysical Observation", "SAO 120242"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.47829174),
        dec: Angle.Degrees(+05.98186219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102352"},
    },
    visualMagnitude: 12.39,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.06869542),
        dec: Angle.Degrees(+05.98301018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13042"},
        {"Hipparcos Number", "HIP 9926"},
        {"Smithsonian Astrophysical Observation", "SAO 110355"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.94673753),
        dec: Angle.Degrees(+05.98489843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16178"},
        {"Smithsonian Astrophysical Observation", "SAO 111211"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.10175956),
        dec: Angle.Degrees(+05.98588317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13227"},
        {"Hipparcos Number", "HIP 10047"},
        {"Geneva Identification System", "GEN# +1.00013227"},
        {"Smithsonian Astrophysical Observation", "SAO 110371"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.34283847),
        dec: Angle.Degrees(+05.98611407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18702"},
        {"Hipparcos Number", "HIP 14023"},
        {"Cincinnati Publication", "Ci 18 388"},
        {"Cincinnati Publication 2", "Ci 20 200"},
        {"Geneva Identification System", "GEN# +1.00018702"},
        {"Smithsonian Astrophysical Observation", "SAO 110900"},
        {"Wilson Evans Batten Catalogue", "WEB 2763"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.14869976),
        dec: Angle.Degrees(+05.98644696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 698.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97275"},
        {"Geneva Identification System", "GEN# +0.00504285"},
        {"Smithsonian Astrophysical Observation", "SAO 125038"},
        {"Wilson Evans Batten Catalogue", "WEB 17085"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.55649835),
        dec: Angle.Degrees(+05.98813926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12545"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.35767390),
        dec: Angle.Degrees(+05.98858085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25490"},
        {"Hipparcos Number", "HIP 18907"},
        {"Fundamental Katalog 5th Edition", "FK5 151"},
        {"Geneva Identification System", "GEN# +1.00025490"},
        {"Smithsonian Astrophysical Observation", "SAO 111579"},
        {"Wilson Evans Batten Catalogue", "WEB 3639"},
    },
    visualMagnitude: 3.91,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.78907003),
        dec: Angle.Degrees(+05.98930909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73194"},
        {"Hipparcos Number", "HIP 42283"},
        {"Geneva Identification System", "GEN# +1.00073194"},
        {"Smithsonian Astrophysical Observation", "SAO 116957"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.31961496),
        dec: Angle.Degrees(+05.99126262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112930"},
        {"Hipparcos Number", "HIP 63454"},
        {"Smithsonian Astrophysical Observation", "SAO 119708"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.03442851),
        dec: Angle.Degrees(+05.99220948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97698"},
        {"Hipparcos Number", "HIP 54904"},
        {"Smithsonian Astrophysical Observation", "SAO 118742"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.63568214),
        dec: Angle.Degrees(+05.99279683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177177"},
        {"Hipparcos Number", "HIP 93565"},
        {"Smithsonian Astrophysical Observation", "SAO 124202"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.85675960),
        dec: Angle.Degrees(+05.99436274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24728"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54410647),
        dec: Angle.Degrees(+05.99500551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180103"},
        {"Hipparcos Number", "HIP 94597"},
        {"Smithsonian Astrophysical Observation", "SAO 124436"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.75818473),
        dec: Angle.Degrees(+05.99671090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2387"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.61429932),
        dec: Angle.Degrees(+05.99760510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11132"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.81166674),
        dec: Angle.Degrees(+05.99843725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18270"},
        {"Hipparcos Number", "HIP 13687"},
        {"Geneva Identification System", "GEN# +1.00018270"},
        {"Smithsonian Astrophysical Observation", "SAO 110853"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.07285669),
        dec: Angle.Degrees(+05.99871789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39635"},
        {"Smithsonian Astrophysical Observation", "SAO 116340"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.49599572),
        dec: Angle.Degrees(+06.00015407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120896"},
        {"Hipparcos Number", "HIP 67705"},
        {"Geneva Identification System", "GEN# +1.00120896"},
        {"Smithsonian Astrophysical Observation", "SAO 120143"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.03879820),
        dec: Angle.Degrees(+06.00134148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256518"},
        {"Hipparcos Number", "HIP 30421"},
        {"Smithsonian Astrophysical Observation", "SAO 113808"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94343443),
        dec: Angle.Degrees(+06.00657350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11286"},
        {"Hipparcos Number", "HIP 8597"},
        {"Smithsonian Astrophysical Observation", "SAO 110166"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.73524501),
        dec: Angle.Degrees(+06.00694031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12661 A"},
        {"Henry Draper", "HD 184853"},
        {"Hipparcos Number", "HIP 96423"},
        {"Smithsonian Astrophysical Observation", "SAO 124835"},
        {"Wilson Evans Batten Catalogue", "WEB 16917"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.05255778),
        dec: Angle.Degrees(+06.00744919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163097"},
        {"Hipparcos Number", "HIP 87654"},
        {"Smithsonian Astrophysical Observation", "SAO 122903"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.55854475),
        dec: Angle.Degrees(+06.00819508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102633",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14293 A"},
        {"Henry Draper", "HD 198069"},
        {"Hipparcos Number", "HIP 102633"},
        {"Geneva Identification System", "GEN# +1.00198069"},
        {"Smithsonian Astrophysical Observation", "SAO 126222"},
        {"Wilson Evans Batten Catalogue", "WEB 18597"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.95136711),
        dec: Angle.Degrees(+06.00824104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36001"},
        {"Hipparcos Number", "HIP 25656"},
        {"Geneva Identification System", "GEN# +1.00036001"},
        {"Smithsonian Astrophysical Observation", "SAO 112811"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.20722827),
        dec: Angle.Degrees(+06.00927641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13762"},
        {"Hipparcos Number", "HIP 10419"},
        {"Smithsonian Astrophysical Observation", "SAO 110421"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.56467874),
        dec: Angle.Degrees(+06.00974847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87327"},
        {"Hipparcos Number", "HIP 49342"},
        {"Geneva Identification System", "GEN# +1.00087327"},
        {"Smithsonian Astrophysical Observation", "SAO 118090"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.09751524),
        dec: Angle.Degrees(+06.01118780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144171"},
        {"Hipparcos Number", "HIP 78728"},
        {"Smithsonian Astrophysical Observation", "SAO 121349"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.08179185),
        dec: Angle.Degrees(+06.01135927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58448"},
        {"Smithsonian Astrophysical Observation", "SAO 119148"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.77710985),
        dec: Angle.Degrees(+06.01186277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117405"},
        {"Hipparcos Number", "HIP 65855"},
        {"Geneva Identification System", "GEN# +1.00117405"},
        {"Smithsonian Astrophysical Observation", "SAO 119961"},
        {"Wilson Evans Batten Catalogue", "WEB 11653"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.49020371),
        dec: Angle.Degrees(+06.01338823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86013",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10638 C"},
        {"Henry Draper", "HD 159482"},
        {"Hipparcos Number", "HIP 86013"},
        {"Cincinnati Publication", "Ci 20 1045"},
        {"Geneva Identification System", "GEN# +1.00159482"},
        {"Smithsonian Astrophysical Observation", "SAO 122527"},
        {"Wilson Evans Batten Catalogue", "WEB 14511"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.68058815),
        dec: Angle.Degrees(+06.01341530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -478.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 373.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208800"},
        {"Hipparcos Number", "HIP 108485"},
        {"Smithsonian Astrophysical Observation", "SAO 127205"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.65237580),
        dec: Angle.Degrees(+06.01389777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175176"},
        {"Hipparcos Number", "HIP 92743"},
        {"Smithsonian Astrophysical Observation", "SAO 124019"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.49516313),
        dec: Angle.Degrees(+06.01437487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109953"},
        {"Smithsonian Astrophysical Observation", "SAO 127422"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.03214611),
        dec: Angle.Degrees(+06.01499228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73004"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.79765385),
        dec: Angle.Degrees(+06.01513959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42787"},
        {"Hipparcos Number", "HIP 29509"},
        {"Geneva Identification System", "GEN# +1.00042787"},
        {"Smithsonian Astrophysical Observation", "SAO 113592"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24819350),
        dec: Angle.Degrees(+06.01628978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31168"},
        {"Hipparcos Number", "HIP 22756"},
        {"Geneva Identification System", "GEN# +1.00031168"},
        {"Smithsonian Astrophysical Observation", "SAO 112185"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.42425712),
        dec: Angle.Degrees(+06.01689121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216420"},
        {"Hipparcos Number", "HIP 112955"},
        {"Smithsonian Astrophysical Observation", "SAO 127814"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14689243),
        dec: Angle.Degrees(+06.02060222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175868"},
        {"Hipparcos Number", "HIP 93045"},
        {"Smithsonian Astrophysical Observation", "SAO 124088"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.30222396),
        dec: Angle.Degrees(+06.02145862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3556"},
        {"Hipparcos Number", "HIP 3033"},
        {"Geneva Identification System", "GEN# +1.00003556"},
        {"Smithsonian Astrophysical Observation", "SAO 109339"},
        {"Wilson Evans Batten Catalogue", "WEB 545"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.64337184),
        dec: Angle.Degrees(+06.02198658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184133"},
        {"Hipparcos Number", "HIP 96135"},
        {"Smithsonian Astrophysical Observation", "SAO 124766"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.20910919),
        dec: Angle.Degrees(+06.02220229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68171"},
        {"Hipparcos Number", "HIP 40099"},
        {"Geneva Identification System", "GEN# +1.00068171"},
        {"Smithsonian Astrophysical Observation", "SAO 116454"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.87407777),
        dec: Angle.Degrees(+06.02315687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41568"},
        {"Hipparcos Number", "HIP 28907"},
        {"Celescope Catalog", "CEL 1076"},
        {"Smithsonian Astrophysical Observation", "SAO 113445"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.53249291),
        dec: Angle.Degrees(+06.02401564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86024",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10638 A"},
        {"Henry Draper", "HD 159481"},
        {"Hipparcos Number", "HIP 86024"},
        {"Geneva Identification System", "GEN# +1.00159481A"},
        {"Smithsonian Astrophysical Observation", "SAO 122529"},
        {"Wilson Evans Batten Catalogue", "WEB 14514"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.70217819),
        dec: Angle.Degrees(+06.02402475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197685"},
        {"Hipparcos Number", "HIP 102407"},
        {"Smithsonian Astrophysical Observation", "SAO 126173"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.28640300),
        dec: Angle.Degrees(+06.02442687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98664"},
        {"Hipparcos Number", "HIP 55434"},
        {"Fundamental Katalog 5th Edition", "FK5 427"},
        {"Geneva Identification System", "GEN# +1.00098664"},
        {"Renson", "Renson 28450"},
        {"Smithsonian Astrophysical Observation", "SAO 118804"},
        {"Wilson Evans Batten Catalogue", "WEB 9974"},
    },
    visualMagnitude: 4.05,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28436733),
        dec: Angle.Degrees(+06.02935289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31522"},
        {"Hipparcos Number", "HIP 23003"},
        {"Smithsonian Astrophysical Observation", "SAO 112243"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.21800887),
        dec: Angle.Degrees(+06.03009607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74419"},
        {"Geneva Identification System", "GEN# +9.80015013"},
    },
    visualMagnitude: 12.31,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.13622162),
        dec: Angle.Degrees(+06.03057890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -449.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -659.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114470"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.74052095),
        dec: Angle.Degrees(+06.03092365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132758"},
        {"Hipparcos Number", "HIP 73456"},
        {"Fundamental Katalog 5th Edition", "FK5 5335"},
        {"Smithsonian Astrophysical Observation", "SAO 120791"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.17016873),
        dec: Angle.Degrees(+06.03167390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3724"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.95185721),
        dec: Angle.Degrees(+06.03199049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100279"},
        {"Geneva Identification System", "GEN# +0.00504481"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.10224752),
        dec: Angle.Degrees(+06.03222452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -364.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146414"},
        {"Hipparcos Number", "HIP 79703"},
        {"Smithsonian Astrophysical Observation", "SAO 121461"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.99534309),
        dec: Angle.Degrees(+06.03431187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225027"},
        {"Hipparcos Number", "HIP 219"},
        {"Smithsonian Astrophysical Observation", "SAO 108982"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.69022925),
        dec: Angle.Degrees(+06.03445242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12203"},
        {"Hipparcos Number", "HIP 9343"},
        {"Geneva Identification System", "GEN# +1.00012203"},
        {"Smithsonian Astrophysical Observation", "SAO 110264"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.99321111),
        dec: Angle.Degrees(+06.03553246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46179"},
        {"Hipparcos Number", "HIP 31147"},
        {"Celescope Catalog", "CEL 1286"},
        {"Geneva Identification System", "GEN# +1.00046179"},
        {"Smithsonian Astrophysical Observation", "SAO 114013"},
        {"Wilson Evans Batten Catalogue", "WEB 6212"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.02976030),
        dec: Angle.Degrees(+06.03565323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105373"},
        {"Hipparcos Number", "HIP 59170"},
        {"Smithsonian Astrophysical Observation", "SAO 119235"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.01085485),
        dec: Angle.Degrees(+06.03636765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145913"},
        {"Hipparcos Number", "HIP 79493"},
        {"Geneva Identification System", "GEN# +1.00145913"},
        {"Smithsonian Astrophysical Observation", "SAO 121432"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.32808277),
        dec: Angle.Degrees(+06.03767357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16663"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.61059027),
        dec: Angle.Degrees(+06.03806839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179491"},
        {"Hipparcos Number", "HIP 94383"},
        {"Geneva Identification System", "GEN# +1.00179491"},
        {"Smithsonian Astrophysical Observation", "SAO 124388"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.15417708),
        dec: Angle.Degrees(+06.03953720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24817"},
        {"Hipparcos Number", "HIP 18481"},
        {"Geneva Identification System", "GEN# +1.00024817"},
        {"Smithsonian Astrophysical Observation", "SAO 111516"},
        {"Wilson Evans Batten Catalogue", "WEB 3561"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.25706793),
        dec: Angle.Degrees(+06.04013209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107238"},
        {"Hipparcos Number", "HIP 60120"},
        {"Smithsonian Astrophysical Observation", "SAO 119333"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.94738773),
        dec: Angle.Degrees(+06.04117484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171835"},
        {"Hipparcos Number", "HIP 91244"},
        {"Smithsonian Astrophysical Observation", "SAO 123695"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.17210343),
        dec: Angle.Degrees(+06.04242417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81988"},
        {"Geneva Identification System", "GEN# +9.80017034"},
        {"Geneva Identification System 2", "GEN# +1.00151090B"},
        {"Wilson Evans Batten Catalogue", "WEB 13843"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.24205071),
        dec: Angle.Degrees(+06.04427024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79617"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.69815234),
        dec: Angle.Degrees(+06.04455358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90199"},
        {"Wilson Evans Batten Catalogue", "WEB 15428"},
    },
    visualMagnitude: 11.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.07553581),
        dec: Angle.Degrees(+06.04593054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36471"},
        {"Hipparcos Number", "HIP 25938"},
        {"Celescope Catalog", "CEL 765"},
        {"Geneva Identification System", "GEN# +1.00036471"},
        {"Smithsonian Astrophysical Observation", "SAO 112879"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.03083759),
        dec: Angle.Degrees(+06.04703002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155679"},
        {"Hipparcos Number", "HIP 84209"},
        {"Smithsonian Astrophysical Observation", "SAO 122184"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.20954841),
        dec: Angle.Degrees(+06.04831589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180028"},
        {"Hipparcos Number", "HIP 94564"},
        {"Geneva Identification System", "GEN# +1.00180028"},
        {"Smithsonian Astrophysical Observation", "SAO 124432"},
        {"Wilson Evans Batten Catalogue", "WEB 16480"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.68629555),
        dec: Angle.Degrees(+06.04855459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136927"},
        {"Hipparcos Number", "HIP 75303"},
        {"Geneva Identification System", "GEN# +1.00136927"},
        {"Smithsonian Astrophysical Observation", "SAO 120972"},
        {"Wilson Evans Batten Catalogue", "WEB 12847"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.78819758),
        dec: Angle.Degrees(+06.04926824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17563",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2750 A"},
        {"Henry Draper", "HD 23466"},
        {"Hipparcos Number", "HIP 17563"},
        {"Fundamental Katalog 5th Edition", "FK5 1104"},
        {"Geneva Identification System", "GEN# +1.00023466A"},
        {"Smithsonian Astrophysical Observation", "SAO 111400"},
        {"Wilson Evans Batten Catalogue", "WEB 3335"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.41846008),
        dec: Angle.Degrees(+06.05002905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90461"},
        {"Hipparcos Number", "HIP 51122"},
        {"Geneva Identification System", "GEN# +1.00090461"},
        {"Smithsonian Astrophysical Observation", "SAO 118303"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.66496639),
        dec: Angle.Degrees(+06.05211168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144151"},
        {"Hipparcos Number", "HIP 78717"},
        {"Smithsonian Astrophysical Observation", "SAO 121344"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.04240890),
        dec: Angle.Degrees(+06.05318209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20705"},
        {"Smithsonian Astrophysical Observation", "SAO 111816"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.53668911),
        dec: Angle.Degrees(+06.05455490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47633"},
        {"Hipparcos Number", "HIP 31881"},
        {"Geneva Identification System", "GEN# +1.00047633"},
        {"Renson", "Renson 12790"},
        {"Smithsonian Astrophysical Observation", "SAO 114232"},
        {"Wilson Evans Batten Catalogue", "WEB 6407"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.97160877),
        dec: Angle.Degrees(+06.05694340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139018"},
        {"Hipparcos Number", "HIP 76338"},
        {"Geneva Identification System", "GEN# +1.00139018"},
        {"Smithsonian Astrophysical Observation", "SAO 121080"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.89074040),
        dec: Angle.Degrees(+06.05783175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101242"},
        {"Hipparcos Number", "HIP 56832"},
        {"Cincinnati Publication", "Ci 18 1438"},
        {"Geneva Identification System", "GEN# +1.00101242"},
        {"Smithsonian Astrophysical Observation", "SAO 118971"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.75499150),
        dec: Angle.Degrees(+06.05819431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -336.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67038"},
        {"Smithsonian Astrophysical Observation", "SAO 120091"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.07486267),
        dec: Angle.Degrees(+06.06015263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37605"},
        {"Hipparcos Number", "HIP 26664"},
        {"Geneva Identification System", "GEN# +1.00037605"},
        {"Smithsonian Astrophysical Observation", "SAO 113015"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.00707298),
        dec: Angle.Degrees(+06.06117663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87788"},
        {"Hipparcos Number", "HIP 49601"},
        {"Smithsonian Astrophysical Observation", "SAO 118117"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.87104158),
        dec: Angle.Degrees(+06.06441646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106091"},
        {"Hipparcos Number", "HIP 59520"},
        {"Smithsonian Astrophysical Observation", "SAO 119271"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.09641970),
        dec: Angle.Degrees(+06.06515632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43285"},
        {"Hipparcos Number", "HIP 29728"},
        {"Celescope Catalog", "CEL 1147"},
        {"Geneva Identification System", "GEN# +1.00043285"},
        {"Smithsonian Astrophysical Observation", "SAO 113650"},
        {"Wilson Evans Batten Catalogue", "WEB 5866"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91740586),
        dec: Angle.Degrees(+06.06620795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5111"},
        {"Smithsonian Astrophysical Observation", "SAO 109662"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.37959130),
        dec: Angle.Degrees(+06.07088415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191770"},
        {"Hipparcos Number", "HIP 99488"},
        {"Smithsonian Astrophysical Observation", "SAO 125541"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.86116024),
        dec: Angle.Degrees(+06.07186269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50112"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.46347245),
        dec: Angle.Degrees(+06.07283062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184176"},
        {"Hipparcos Number", "HIP 96150"},
        {"Smithsonian Astrophysical Observation", "SAO 124770"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.24706470),
        dec: Angle.Degrees(+06.07304977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178596"},
        {"Hipparcos Number", "HIP 94068"},
        {"Fundamental Katalog 5th Edition", "FK5 3530"},
        {"Geneva Identification System", "GEN# +1.00178596"},
        {"Smithsonian Astrophysical Observation", "SAO 124318"},
        {"Wilson Evans Batten Catalogue", "WEB 16376"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.24965607),
        dec: Angle.Degrees(+06.07339716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220990"},
        {"Hipparcos Number", "HIP 115851"},
        {"Geneva Identification System", "GEN# +1.00220990"},
        {"Smithsonian Astrophysical Observation", "SAO 128198"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.06842162),
        dec: Angle.Degrees(+06.07456725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60868"},
        {"Hipparcos Number", "HIP 37048"},
        {"Geneva Identification System", "GEN# +1.00060868"},
        {"Smithsonian Astrophysical Observation", "SAO 115701"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.19926237),
        dec: Angle.Degrees(+06.07469531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146815"},
        {"Hipparcos Number", "HIP 79853"},
        {"Geneva Identification System", "GEN# +1.00146815"},
        {"Smithsonian Astrophysical Observation", "SAO 121480"},
        {"Wilson Evans Batten Catalogue", "WEB 13519"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.50495626),
        dec: Angle.Degrees(+06.07866071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124929"},
        {"Hipparcos Number", "HIP 69723"},
        {"Smithsonian Astrophysical Observation", "SAO 120375"},
        {"Wilson Evans Batten Catalogue", "WEB 12139"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.08452779),
        dec: Angle.Degrees(+06.08110515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46966"},
        {"Hipparcos Number", "HIP 31567"},
        {"Celescope Catalog", "CEL 1315"},
        {"Geneva Identification System", "GEN# +1.00046966"},
        {"Smithsonian Astrophysical Observation", "SAO 114120"},
        {"Wilson Evans Batten Catalogue", "WEB 6315"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.10787109),
        dec: Angle.Degrees(+06.08318783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198271"},
        {"Hipparcos Number", "HIP 102739"},
        {"Smithsonian Astrophysical Observation", "SAO 126248"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.26892532),
        dec: Angle.Degrees(+06.08393603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208190"},
        {"Hipparcos Number", "HIP 108130"},
        {"Smithsonian Astrophysical Observation", "SAO 127147"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.60377077),
        dec: Angle.Degrees(+06.08428235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156697"},
        {"Hipparcos Number", "HIP 84704"},
        {"Geneva Identification System", "GEN# +1.00156697"},
        {"Smithsonian Astrophysical Observation", "SAO 122270"},
        {"Wilson Evans Batten Catalogue", "WEB 14303"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71992002),
        dec: Angle.Degrees(+06.08543157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151090"},
        {"Hipparcos Number", "HIP 81991"},
        {"Geneva Identification System", "GEN# +1.00151090A"},
        {"Smithsonian Astrophysical Observation", "SAO 121831"},
        {"Wilson Evans Batten Catalogue", "WEB 13842"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.25046052),
        dec: Angle.Degrees(+06.08878583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -257.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77798"},
    },
    visualMagnitude: 11.98,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.29078962),
        dec: Angle.Degrees(+06.09056615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2246"},
        {"Hipparcos Number", "HIP 2083"},
        {"Smithsonian Astrophysical Observation", "SAO 109207"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.57641422),
        dec: Angle.Degrees(+06.09441096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99835"},
        {"Hipparcos Number", "HIP 56048"},
        {"Smithsonian Astrophysical Observation", "SAO 118888"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.30662137),
        dec: Angle.Degrees(+06.09833648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162917"},
        {"Hipparcos Number", "HIP 87558"},
        {"Fundamental Katalog 5th Edition", "FK5 3420"},
        {"Geneva Identification System", "GEN# +1.00162917"},
        {"Smithsonian Astrophysical Observation", "SAO 122880"},
        {"Wilson Evans Batten Catalogue", "WEB 14768"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.30941640),
        dec: Angle.Degrees(+06.10125423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75682",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9647 AB"},
        {"Henry Draper", "HD 137761"},
        {"Hipparcos Number", "HIP 75682"},
        {"Smithsonian Astrophysical Observation", "SAO 121013"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92558257),
        dec: Angle.Degrees(+06.10134736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216902"},
        {"Hipparcos Number", "HIP 113313"},
        {"Smithsonian Astrophysical Observation", "SAO 127856"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.22241149),
        dec: Angle.Degrees(+06.10143532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53824",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8019 A"},
        {"Henry Draper", "HD 95382"},
        {"Hipparcos Number", "HIP 53824"},
        {"Geneva Identification System", "GEN# +1.00095382"},
        {"Smithsonian Astrophysical Observation", "SAO 118615"},
        {"Wilson Evans Batten Catalogue", "WEB 9750"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.18680144),
        dec: Angle.Degrees(+06.10150342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20319"},
        {"Geneva Identification System", "GEN# +9.80082013"},
    },
    visualMagnitude: 11.86,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.29092122),
        dec: Angle.Degrees(+06.10361752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 669.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17185"},
    },
    visualMagnitude: 12.27,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.20529596),
        dec: Angle.Degrees(+06.10456845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52283"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.25349043),
        dec: Angle.Degrees(+06.10636475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100872"},
        {"Hipparcos Number", "HIP 56618"},
        {"Smithsonian Astrophysical Observation", "SAO 118946"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.14258464),
        dec: Angle.Degrees(+06.10670480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224072"},
        {"Hipparcos Number", "HIP 117900"},
        {"Smithsonian Astrophysical Observation", "SAO 128461"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.71898289),
        dec: Angle.Degrees(+06.10701019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74997"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86877858),
        dec: Angle.Degrees(+06.10826834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99252"},
        {"Hipparcos Number", "HIP 55750"},
        {"Smithsonian Astrophysical Observation", "SAO 118840"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.34766920),
        dec: Angle.Degrees(+06.10844306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185822"},
        {"Hipparcos Number", "HIP 96824"},
        {"Smithsonian Astrophysical Observation", "SAO 124927"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.20605558),
        dec: Angle.Degrees(+06.10951942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47984"},
        {"Hipparcos Number", "HIP 32034"},
        {"Geneva Identification System", "GEN# +1.00047984"},
        {"Smithsonian Astrophysical Observation", "SAO 114277"},
        {"Wilson Evans Batten Catalogue", "WEB 6463"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.37428220),
        dec: Angle.Degrees(+06.11082616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140953"},
        {"Hipparcos Number", "HIP 77237"},
        {"Smithsonian Astrophysical Observation", "SAO 121182"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.55715281),
        dec: Angle.Degrees(+06.11120465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8031"},
    },
    visualMagnitude: 11.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.79195613),
        dec: Angle.Degrees(+06.11130466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107342"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.11200272),
        dec: Angle.Degrees(+06.11136940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16647"},
        {"Hipparcos Number", "HIP 12447"},
        {"Geneva Identification System", "GEN# +1.00016647"},
        {"Smithsonian Astrophysical Observation", "SAO 110673"},
        {"Wilson Evans Batten Catalogue", "WEB 2546"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.06526184),
        dec: Angle.Degrees(+06.11195277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37271"},
        {"Hipparcos Number", "HIP 26444"},
        {"Geneva Identification System", "GEN# +1.00037271"},
        {"Smithsonian Astrophysical Observation", "SAO 112970"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40429072),
        dec: Angle.Degrees(+06.11222256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86444"},
        {"Hipparcos Number", "HIP 48918"},
        {"Smithsonian Astrophysical Observation", "SAO 118028"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.68707577),
        dec: Angle.Degrees(+06.11474633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5374 AB"},
        {"Henry Draper", "HD 48347"},
        {"Hipparcos Number", "HIP 32196"},
        {"Smithsonian Astrophysical Observation", "SAO 114314"},
        {"Wilson Evans Batten Catalogue", "WEB 6493"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.81358365),
        dec: Angle.Degrees(+06.11700947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19219"},
        {"Hipparcos Number", "HIP 14390"},
        {"Smithsonian Astrophysical Observation", "SAO 110960"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.41025881),
        dec: Angle.Degrees(+06.11744651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128079"},
        {"Hipparcos Number", "HIP 71294"},
        {"Smithsonian Astrophysical Observation", "SAO 120540"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.70614321),
        dec: Angle.Degrees(+06.11902814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10448"},
        {"Smithsonian Astrophysical Observation", "SAO 110423"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.66437990),
        dec: Angle.Degrees(+06.11904820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17680"},
        {"Smithsonian Astrophysical Observation", "SAO 111418"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.81688064),
        dec: Angle.Degrees(+06.11928025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53644"},
        {"Hipparcos Number", "HIP 34260"},
        {"Geneva Identification System", "GEN# +1.00053644"},
        {"Smithsonian Astrophysical Observation", "SAO 114913"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.52215177),
        dec: Angle.Degrees(+06.11977605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161660"},
        {"Hipparcos Number", "HIP 86993"},
        {"Geneva Identification System", "GEN# +3.46650072"},
        {"Renson", "Renson 45570"},
        {"Smithsonian Astrophysical Observation", "SAO 122734"},
        {"Wilson Evans Batten Catalogue", "WEB 14674"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.65176034),
        dec: Angle.Degrees(+06.12064347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71639"},
        {"Hipparcos Number", "HIP 41584"},
        {"Smithsonian Astrophysical Observation", "SAO 116803"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.17723599),
        dec: Angle.Degrees(+06.12510345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36823"},
        {"Hipparcos Number", "HIP 26161"},
        {"Smithsonian Astrophysical Observation", "SAO 112910"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.66007171),
        dec: Angle.Degrees(+06.12694883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196124"},
        {"Hipparcos Number", "HIP 101579"},
        {"Cincinnati Publication", "Ci 18 2668"},
        {"Cincinnati Publication 2", "Ci 20 1216"},
        {"Geneva Identification System", "GEN# +1.00196124"},
        {"Smithsonian Astrophysical Observation", "SAO 125986"},
        {"Wilson Evans Batten Catalogue", "WEB 18354"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.80198556),
        dec: Angle.Degrees(+06.12756365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 390.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105201"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.64913653),
        dec: Angle.Degrees(+06.12875629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32662"},
        {"Hipparcos Number", "HIP 23662"},
        {"Geneva Identification System", "GEN# +1.00032662"},
        {"Smithsonian Astrophysical Observation", "SAO 112399"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.27709995),
        dec: Angle.Degrees(+06.13023779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27497"},
        {"Hipparcos Number", "HIP 20268"},
        {"Fundamental Katalog 5th Edition", "FK5 2320"},
        {"Geneva Identification System", "GEN# +1.00027497"},
        {"Smithsonian Astrophysical Observation", "SAO 111756"},
        {"Wilson Evans Batten Catalogue", "WEB 3874"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.17188935),
        dec: Angle.Degrees(+06.13090686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19019"},
        {"Hipparcos Number", "HIP 14258"},
        {"Geneva Identification System", "GEN# +1.00019019"},
        {"Smithsonian Astrophysical Observation", "SAO 110937"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.96116153),
        dec: Angle.Degrees(+06.13318019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31646",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Plaskett's star"},
        {"Common Name 2", "Plaskett star"},
        {"Henry Draper", "HD 47129"},
        {"Hipparcos Number", "HIP 31646"},
        {"Celescope Catalog", "CEL 1319"},
        {"Geneva Identification System", "GEN# +1.00047129"},
        {"Smithsonian Astrophysical Observation", "SAO 114146"},
        {"Wilson Evans Batten Catalogue", "WEB 6338"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.35017866),
        dec: Angle.Degrees(+06.13538051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76920"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.59074387),
        dec: Angle.Degrees(+06.13669814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205584"},
        {"Hipparcos Number", "HIP 106660"},
        {"Geneva Identification System", "GEN# +1.00205584"},
        {"Smithsonian Astrophysical Observation", "SAO 126918"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.05846108),
        dec: Angle.Degrees(+06.13724395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53771"},
        {"Hipparcos Number", "HIP 34292"},
        {"Smithsonian Astrophysical Observation", "SAO 114924"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.63770653),
        dec: Angle.Degrees(+06.14099767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9138"},
        {"Hipparcos Number", "HIP 7007"},
        {"Fundamental Katalog 5th Edition", "FK5 2099"},
        {"Geneva Identification System", "GEN# +1.00009138"},
        {"Smithsonian Astrophysical Observation", "SAO 109926"},
        {"Wilson Evans Batten Catalogue", "WEB 1515"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.54559597),
        dec: Angle.Degrees(+06.14393314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 293.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88965",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11110 AB"},
        {"Henry Draper", "HD 166257"},
        {"Hipparcos Number", "HIP 88965"},
        {"Smithsonian Astrophysical Observation", "SAO 123189"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.39261609),
        dec: Angle.Degrees(+06.14579783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75839"},
        {"Geneva Identification System", "GEN# +9.80015023"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.38248365),
        dec: Angle.Degrees(+06.14816712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -389.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158449"},
        {"Hipparcos Number", "HIP 85564"},
        {"Smithsonian Astrophysical Observation", "SAO 122426"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.28982398),
        dec: Angle.Degrees(+06.14841018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58121"},
        {"Hipparcos Number", "HIP 35935"},
        {"Geneva Identification System", "GEN# +1.00058121"},
        {"Smithsonian Astrophysical Observation", "SAO 115397"},
        {"Wilson Evans Batten Catalogue", "WEB 7157"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.11849635),
        dec: Angle.Degrees(+06.15025757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217217"},
        {"Hipparcos Number", "HIP 113502"},
        {"Geneva Identification System", "GEN# +1.00217217"},
        {"Smithsonian Astrophysical Observation", "SAO 127879"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.79649147),
        dec: Angle.Degrees(+06.15056411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43831"},
        {"Smithsonian Astrophysical Observation", "SAO 117269"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.90725249),
        dec: Angle.Degrees(+06.15138033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93130"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.58363371),
        dec: Angle.Degrees(+06.15148923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108472"},
        {"Hipparcos Number", "HIP 60800"},
        {"Geneva Identification System", "GEN# +1.00108472"},
        {"Smithsonian Astrophysical Observation", "SAO 119411"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.91486692),
        dec: Angle.Degrees(+06.15438553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176399"},
        {"Hipparcos Number", "HIP 93260"},
        {"Geneva Identification System", "GEN# +1.00176399"},
        {"Smithsonian Astrophysical Observation", "SAO 124135"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.96483817),
        dec: Angle.Degrees(+06.15723907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21462"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.13876422),
        dec: Angle.Degrees(+06.15811796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131916"},
        {"Hipparcos Number", "HIP 73092"},
        {"Smithsonian Astrophysical Observation", "SAO 120744"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.06724732),
        dec: Angle.Degrees(+06.15906838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8019"},
        {"Hipparcos Number", "HIP 6220"},
        {"Smithsonian Astrophysical Observation", "SAO 109810"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.93615018),
        dec: Angle.Degrees(+06.16189140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178190"},
        {"Hipparcos Number", "HIP 93920"},
        {"Smithsonian Astrophysical Observation", "SAO 124294"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.86047966),
        dec: Angle.Degrees(+06.16260981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68951"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.72450258),
        dec: Angle.Degrees(+06.16568126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51620"},
        {"Hipparcos Number", "HIP 33550"},
        {"Geneva Identification System", "GEN# +1.00051620"},
        {"Smithsonian Astrophysical Observation", "SAO 114704"},
        {"Wilson Evans Batten Catalogue", "WEB 6746"},
    },
    visualMagnitude: 7.35,
    bvColour: 2.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.58955662),
        dec: Angle.Degrees(+06.16707163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121813"},
        {"Hipparcos Number", "HIP 68199"},
        {"Smithsonian Astrophysical Observation", "SAO 120195"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.43761476),
        dec: Angle.Degrees(+06.16739388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88331"},
        {"Hipparcos Number", "HIP 49888"},
        {"Smithsonian Astrophysical Observation", "SAO 118151"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79673637),
        dec: Angle.Degrees(+06.16803343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181305"},
        {"Hipparcos Number", "HIP 94996"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.95597797),
        dec: Angle.Degrees(+06.16822078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68200"},
        {"Hipparcos Number", "HIP 40117"},
        {"Geneva Identification System", "GEN# +1.00068200"},
        {"Smithsonian Astrophysical Observation", "SAO 116460"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.90876972),
        dec: Angle.Degrees(+06.16910803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151828"},
        {"Hipparcos Number", "HIP 82349"},
        {"Geneva Identification System", "GEN# +1.00151828"},
        {"Smithsonian Astrophysical Observation", "SAO 121887"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.39265911),
        dec: Angle.Degrees(+06.16936253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45366"},
        {"Smithsonian Astrophysical Observation", "SAO 117531"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.67999570),
        dec: Angle.Degrees(+06.17022161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88048"},
        {"Hipparcos Number", "HIP 49739"},
        {"Smithsonian Astrophysical Observation", "SAO 118135"},
        {"Wilson Evans Batten Catalogue", "WEB 9168"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.31199282),
        dec: Angle.Degrees(+06.17090869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197079"},
        {"Hipparcos Number", "HIP 102075"},
        {"Smithsonian Astrophysical Observation", "SAO 126102"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.29993357),
        dec: Angle.Degrees(+06.17248917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110167"},
        {"Hipparcos Number", "HIP 61821"},
        {"Smithsonian Astrophysical Observation", "SAO 119521"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.03687342),
        dec: Angle.Degrees(+06.17273511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163642"},
        {"Hipparcos Number", "HIP 87861"},
        {"Smithsonian Astrophysical Observation", "SAO 122948"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.22724765),
        dec: Angle.Degrees(+06.17388538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30897"},
        {"Hipparcos Number", "HIP 22601"},
        {"Smithsonian Astrophysical Observation", "SAO 112153"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.93906650),
        dec: Angle.Degrees(+06.17430545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18258"},
        {"Hipparcos Number", "HIP 13671"},
        {"Smithsonian Astrophysical Observation", "SAO 110849"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.01732576),
        dec: Angle.Degrees(+06.17494222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57463"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.68684374),
        dec: Angle.Degrees(+06.17804464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21401"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.91294370),
        dec: Angle.Degrees(+06.17843351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112153"},
        {"Hipparcos Number", "HIP 62980"},
        {"Geneva Identification System", "GEN# +1.00112153"},
        {"Smithsonian Astrophysical Observation", "SAO 119655"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.57384404),
        dec: Angle.Degrees(+06.17871099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219401"},
        {"Hipparcos Number", "HIP 114812"},
        {"Smithsonian Astrophysical Observation", "SAO 128067"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.85536155),
        dec: Angle.Degrees(+06.17934852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 907"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.80966423),
        dec: Angle.Degrees(+06.18052792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100512"},
        {"Smithsonian Astrophysical Observation", "SAO 125743"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.72449201),
        dec: Angle.Degrees(+06.18263400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139088"},
        {"Hipparcos Number", "HIP 76383"},
        {"Smithsonian Astrophysical Observation", "SAO 121084"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.01454580),
        dec: Angle.Degrees(+06.18351932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94705"},
        {"Hipparcos Number", "HIP 53449"},
        {"Geneva Identification System", "GEN# +1.00094705"},
        {"Smithsonian Astrophysical Observation", "SAO 118576"},
        {"Wilson Evans Batten Catalogue", "WEB 9700"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.00617929),
        dec: Angle.Degrees(+06.18538415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186206"},
        {"Hipparcos Number", "HIP 96996"},
        {"Smithsonian Astrophysical Observation", "SAO 124972"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.71566445),
        dec: Angle.Degrees(+06.18577789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66665"},
        {"Hipparcos Number", "HIP 39540"},
        {"Geneva Identification System", "GEN# +1.00066665"},
        {"Smithsonian Astrophysical Observation", "SAO 116308"},
        {"Wilson Evans Batten Catalogue", "WEB 7729"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.19938674),
        dec: Angle.Degrees(+06.18605604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220529"},
        {"Hipparcos Number", "HIP 115551"},
        {"Smithsonian Astrophysical Observation", "SAO 128162"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.09075708),
        dec: Angle.Degrees(+06.18627683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19859",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3085 A"},
        {"Henry Draper", "HD 26923"},
        {"Hipparcos Number", "HIP 19859"},
        {"Geneva Identification System", "GEN# +1.00026923"},
        {"Smithsonian Astrophysical Observation", "SAO 111698"},
        {"Wilson Evans Batten Catalogue", "WEB 3794"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.87027030),
        dec: Angle.Degrees(+06.18712133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21755"},
        {"Hipparcos Number", "HIP 16358"},
        {"Fundamental Katalog 5th Edition", "FK5 2247"},
        {"Geneva Identification System", "GEN# +1.00021755"},
        {"Smithsonian Astrophysical Observation", "SAO 111230"},
        {"Wilson Evans Batten Catalogue", "WEB 3127"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.68914607),
        dec: Angle.Degrees(+06.18874381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98451"},
        {"Hipparcos Number", "HIP 55323"},
        {"Smithsonian Astrophysical Observation", "SAO 118791"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.93502444),
        dec: Angle.Degrees(+06.19076844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183104"},
        {"Hipparcos Number", "HIP 95683"},
        {"Smithsonian Astrophysical Observation", "SAO 124649"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.92705652),
        dec: Angle.Degrees(+06.19183965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23479"},
        {"Smithsonian Astrophysical Observation", "SAO 112355"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.69737013),
        dec: Angle.Degrees(+06.19185515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210631"},
        {"Hipparcos Number", "HIP 109563"},
        {"Geneva Identification System", "GEN# +1.00210631"},
        {"Smithsonian Astrophysical Observation", "SAO 127360"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.91344073),
        dec: Angle.Degrees(+06.19328054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170200"},
        {"Hipparcos Number", "HIP 90497"},
        {"Geneva Identification System", "GEN# +2.66330102"},
        {"Smithsonian Astrophysical Observation", "SAO 123516"},
        {"Wilson Evans Batten Catalogue", "WEB 15502"},
        {"New General Catalogue", "NGC 6633 102"},
    },
    visualMagnitude: 5.71,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.99489066),
        dec: Angle.Degrees(+06.19416039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144581"},
        {"Hipparcos Number", "HIP 78905"},
        {"Geneva Identification System", "GEN# +1.00144581"},
        {"Smithsonian Astrophysical Observation", "SAO 121369"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.60790480),
        dec: Angle.Degrees(+06.19421030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60501"},
        {"Hipparcos Number", "HIP 36888"},
        {"Smithsonian Astrophysical Observation", "SAO 115661"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.76246124),
        dec: Angle.Degrees(+06.19439524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14384"},
        {"Smithsonian Astrophysical Observation", "SAO 110956"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.38887173),
        dec: Angle.Degrees(+06.19555148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96522"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.33901796),
        dec: Angle.Degrees(+06.19611177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89487"},
        {"Hipparcos Number", "HIP 50563"},
        {"Smithsonian Astrophysical Observation", "SAO 118223"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.92819692),
        dec: Angle.Degrees(+06.19613515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109427",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Biham"},
        {"Henry Draper", "HD 210418"},
        {"Hipparcos Number", "HIP 109427"},
        {"Fundamental Katalog 5th Edition", "FK5 834"},
        {"Geneva Identification System", "GEN# +1.00210418"},
        {"Smithsonian Astrophysical Observation", "SAO 127340"},
        {"Wilson Evans Batten Catalogue", "WEB 19660"},
    },
    visualMagnitude: 3.52,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.54924902),
        dec: Angle.Degrees(+06.19778900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119551"},
        {"Hipparcos Number", "HIP 66989"},
        {"Smithsonian Astrophysical Observation", "SAO 120089"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.93057192),
        dec: Angle.Degrees(+06.19968254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3085 B"},
        {"Henry Draper", "HD 26913"},
        {"Hipparcos Number", "HIP 19855"},
        {"Fundamental Katalog 5th Edition", "FK5 4389"},
        {"Geneva Identification System", "GEN# +1.00026913"},
        {"Smithsonian Astrophysical Observation", "SAO 111695"},
        {"Wilson Evans Batten Catalogue", "WEB 3791"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.85769567),
        dec: Angle.Degrees(+06.19992550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258078"},
        {"Hipparcos Number", "HIP 30864"},
        {"Smithsonian Astrophysical Observation", "SAO 113933"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.19773046),
        dec: Angle.Degrees(+06.20038409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222278"},
        {"Hipparcos Number", "HIP 116715"},
        {"Geneva Identification System", "GEN# +1.00222278"},
        {"Smithsonian Astrophysical Observation", "SAO 128304"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.79310485),
        dec: Angle.Degrees(+06.20122363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56227"},
        {"Hipparcos Number", "HIP 35199"},
        {"Geneva Identification System", "GEN# +1.00056227"},
        {"Smithsonian Astrophysical Observation", "SAO 115178"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.11387091),
        dec: Angle.Degrees(+06.20169574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212426"},
        {"Hipparcos Number", "HIP 110574"},
        {"Smithsonian Astrophysical Observation", "SAO 127506"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.00539111),
        dec: Angle.Degrees(+06.20295007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52224"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.05402767),
        dec: Angle.Degrees(+06.20309072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5858"},
        {"Hipparcos Number", "HIP 4686"},
        {"Smithsonian Astrophysical Observation", "SAO 109589"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.04844234),
        dec: Angle.Degrees(+06.20325934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266432"},
        {"Hipparcos Number", "HIP 33312"},
        {"Smithsonian Astrophysical Observation", "SAO 114632"},
    },
    visualMagnitude: 9.76,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.93161720),
        dec: Angle.Degrees(+06.20407397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238"},
        {"Hipparcos Number", "HIP 593"},
        {"Smithsonian Astrophysical Observation", "SAO 109017"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.80243855),
        dec: Angle.Degrees(+06.20432213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105457"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.41223459),
        dec: Angle.Degrees(+06.20550569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166303"},
        {"Hipparcos Number", "HIP 88980"},
        {"Fundamental Katalog 5th Edition", "FK5 5601"},
        {"Smithsonian Astrophysical Observation", "SAO 123196"},
        {"Wilson Evans Batten Catalogue", "WEB 15092"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.42976354),
        dec: Angle.Degrees(+06.20639992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162248"},
        {"Hipparcos Number", "HIP 87265"},
        {"Smithsonian Astrophysical Observation", "SAO 122802"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.47520912),
        dec: Angle.Degrees(+06.20645269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47696",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7499 AB"},
        {"Henry Draper", "HD 84196"},
        {"Hipparcos Number", "HIP 47696"},
        {"Smithsonian Astrophysical Observation", "SAO 117872"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.87255042),
        dec: Angle.Degrees(+06.20782719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39374"},
        {"Hipparcos Number", "HIP 27751"},
        {"Geneva Identification System", "GEN# +1.00039374"},
        {"Smithsonian Astrophysical Observation", "SAO 113219"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11201429),
        dec: Angle.Degrees(+06.20947432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153113"},
        {"Hipparcos Number", "HIP 82971"},
        {"Smithsonian Astrophysical Observation", "SAO 121959"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.33446121),
        dec: Angle.Degrees(+06.21130150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49367"},
        {"Hipparcos Number", "HIP 32631"},
        {"Geneva Identification System", "GEN# +1.00049367"},
        {"Smithsonian Astrophysical Observation", "SAO 114438"},
        {"Wilson Evans Batten Catalogue", "WEB 6579"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09993316),
        dec: Angle.Degrees(+06.21302206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160158"},
        {"Hipparcos Number", "HIP 86310"},
        {"Geneva Identification System", "GEN# +1.00160158"},
        {"Smithsonian Astrophysical Observation", "SAO 122585"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.53464652),
        dec: Angle.Degrees(+06.21377326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20702"},
        {"Hipparcos Number", "HIP 15542"},
        {"Smithsonian Astrophysical Observation", "SAO 111133"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.06402532),
        dec: Angle.Degrees(+06.22152577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92416"},
        {"Smithsonian Astrophysical Observation", "SAO 123953"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.50253752),
        dec: Angle.Degrees(+06.22188784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106715"},
        {"Hipparcos Number", "HIP 59840"},
        {"Smithsonian Astrophysical Observation", "SAO 119299"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.06420701),
        dec: Angle.Degrees(+06.22316681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1857 A"},
        {"Henry Draper", "HD 15210"},
        {"Hipparcos Number", "HIP 11411"},
        {"Smithsonian Astrophysical Observation", "SAO 110534"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.76427746),
        dec: Angle.Degrees(+06.22658953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18995"},
        {"Hipparcos Number", "HIP 14228"},
        {"Geneva Identification System", "GEN# +1.00018995"},
        {"Smithsonian Astrophysical Observation", "SAO 110934"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.86738428),
        dec: Angle.Degrees(+06.22682425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111592"},
        {"Hipparcos Number", "HIP 62660"},
        {"Geneva Identification System", "GEN# +1.00111592"},
        {"Smithsonian Astrophysical Observation", "SAO 119619"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.58546774),
        dec: Angle.Degrees(+06.22719650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15395"},
        {"Smithsonian Astrophysical Observation", "SAO 111112"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.61659349),
        dec: Angle.Degrees(+06.22761205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58958"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.34433879),
        dec: Angle.Degrees(+06.23126907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125322"},
        {"Hipparcos Number", "HIP 69930"},
        {"Smithsonian Astrophysical Observation", "SAO 120390"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.66001232),
        dec: Angle.Degrees(+06.23264852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7380 AB"},
        {"Henry Draper", "HD 81670"},
        {"Hipparcos Number", "HIP 46367"},
        {"Smithsonian Astrophysical Observation", "SAO 117704"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.82005046),
        dec: Angle.Degrees(+06.23317488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184570"},
        {"Hipparcos Number", "HIP 96309"},
        {"Smithsonian Astrophysical Observation", "SAO 124815"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.73242279),
        dec: Angle.Degrees(+06.23392191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69632"},
        {"Hipparcos Number", "HIP 40658"},
        {"Smithsonian Astrophysical Observation", "SAO 116597"},
        {"Wilson Evans Batten Catalogue", "WEB 7900"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.49732070),
        dec: Angle.Degrees(+06.23407073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161638"},
        {"Hipparcos Number", "HIP 86977"},
        {"Geneva Identification System", "GEN# +3.46650069"},
        {"Smithsonian Astrophysical Observation", "SAO 122732"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.61917916),
        dec: Angle.Degrees(+06.23563553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214058"},
        {"Hipparcos Number", "HIP 111524"},
        {"Smithsonian Astrophysical Observation", "SAO 127622"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.92126980),
        dec: Angle.Degrees(+06.23668817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62231"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.31307213),
        dec: Angle.Degrees(+06.23670712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57313"},
        {"Hipparcos Number", "HIP 35614"},
        {"Geneva Identification System", "GEN# +1.00057313"},
        {"Smithsonian Astrophysical Observation", "SAO 115307"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.24015845),
        dec: Angle.Degrees(+06.23761108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37749"},
        {"Smithsonian Astrophysical Observation", "SAO 115868"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.13845685),
        dec: Angle.Degrees(+06.23975739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139552"},
        {"Hipparcos Number", "HIP 76601"},
        {"Smithsonian Astrophysical Observation", "SAO 121105"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.66565490),
        dec: Angle.Degrees(+06.23990353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176095"},
        {"Hipparcos Number", "HIP 93138"},
        {"Geneva Identification System", "GEN# +1.00176095"},
        {"Smithsonian Astrophysical Observation", "SAO 124112"},
        {"Wilson Evans Batten Catalogue", "WEB 16136"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.59879391),
        dec: Angle.Degrees(+06.24018925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131476"},
        {"Hipparcos Number", "HIP 72869"},
        {"Fundamental Katalog 5th Edition", "FK5 1388"},
        {"Geneva Identification System", "GEN# +1.00131476"},
        {"Smithsonian Astrophysical Observation", "SAO 120719"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.41595568),
        dec: Angle.Degrees(+06.24178874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173587"},
        {"Hipparcos Number", "HIP 92068"},
        {"Smithsonian Astrophysical Observation", "SAO 123898"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.47745463),
        dec: Angle.Degrees(+06.24419196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69523"},
        {"Hipparcos Number", "HIP 40626"},
        {"Smithsonian Astrophysical Observation", "SAO 116587"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.40778745),
        dec: Angle.Degrees(+06.24498661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214590"},
        {"Hipparcos Number", "HIP 111835"},
        {"Smithsonian Astrophysical Observation", "SAO 127664"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.79194152),
        dec: Angle.Degrees(+06.24759999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18774"},
        {"Hipparcos Number", "HIP 14075"},
        {"Geneva Identification System", "GEN# +1.00018774"},
        {"Smithsonian Astrophysical Observation", "SAO 110906"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.34444094),
        dec: Angle.Degrees(+06.24934253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7604 A"},
        {"Henry Draper", "HD 86683"},
        {"Hipparcos Number", "HIP 49030"},
        {"Geneva Identification System", "GEN# +1.00086683A"},
        {"Smithsonian Astrophysical Observation", "SAO 118045"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.05511496),
        dec: Angle.Degrees(+06.25056589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39529"},
        {"Hipparcos Number", "HIP 27839"},
        {"Geneva Identification System", "GEN# +1.00039529"},
        {"Smithsonian Astrophysical Observation", "SAO 113239"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.36020334),
        dec: Angle.Degrees(+06.25567111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49711"},
        {"Hipparcos Number", "HIP 32781"},
        {"Smithsonian Astrophysical Observation", "SAO 114484"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.52441984),
        dec: Angle.Degrees(+06.25631586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121411"},
        {"Hipparcos Number", "HIP 67963"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.76918216),
        dec: Angle.Degrees(+06.25688485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81373"},
        {"Hipparcos Number", "HIP 46217"},
        {"Fundamental Katalog 5th Edition", "FK5 4839"},
        {"Smithsonian Astrophysical Observation", "SAO 117678"},
        {"Wilson Evans Batten Catalogue", "WEB 8744"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.34435376),
        dec: Angle.Degrees(+06.25831673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8598"},
        {"Hipparcos Number", "HIP 6621"},
        {"Smithsonian Astrophysical Observation", "SAO 109874"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.24697965),
        dec: Angle.Degrees(+06.25861247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17010"},
        {"Hipparcos Number", "HIP 12745"},
        {"Smithsonian Astrophysical Observation", "SAO 110712"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.96476762),
        dec: Angle.Degrees(+06.25869412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44704"},
        {"Smithsonian Astrophysical Observation", "SAO 117425"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63483556),
        dec: Angle.Degrees(+06.26004834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62569"},
        {"Hipparcos Number", "HIP 37786"},
        {"Geneva Identification System", "GEN# +1.00062569"},
        {"Smithsonian Astrophysical Observation", "SAO 115875"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.22636935),
        dec: Angle.Degrees(+06.26065255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188289"},
        {"Hipparcos Number", "HIP 97934"},
        {"Smithsonian Astrophysical Observation", "SAO 125208"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.55461321),
        dec: Angle.Degrees(+06.26467899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111677"},
        {"Hipparcos Number", "HIP 62702"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.73359752),
        dec: Angle.Degrees(+06.26581806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103080"},
        {"Smithsonian Astrophysical Observation", "SAO 126332"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.28290078),
        dec: Angle.Degrees(+06.26814198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164432"},
        {"Hipparcos Number", "HIP 88213"},
        {"Fundamental Katalog 5th Edition", "FK5 3432"},
        {"Geneva Identification System", "GEN# +1.00164432"},
        {"Geneva Identification System 2", "GEN# +5.13590009"},
        {"Smithsonian Astrophysical Observation", "SAO 123017"},
        {"Wilson Evans Batten Catalogue", "WEB 14906"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.22024348),
        dec: Angle.Degrees(+06.26831149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134028"},
        {"Hipparcos Number", "HIP 74018"},
        {"Smithsonian Astrophysical Observation", "SAO 120849"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.89289286),
        dec: Angle.Degrees(+06.26928623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90650"},
        {"Hipparcos Number", "HIP 51251"},
        {"Smithsonian Astrophysical Observation", "SAO 118318"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.02668674),
        dec: Angle.Degrees(+06.26955608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100974"},
        {"Hipparcos Number", "HIP 56679"},
        {"Smithsonian Astrophysical Observation", "SAO 118952"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.32440612),
        dec: Angle.Degrees(+06.27001298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172230"},
        {"Hipparcos Number", "HIP 91440"},
        {"Geneva Identification System", "GEN# +3.47560111"},
        {"Smithsonian Astrophysical Observation", "SAO 123760"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.72895011),
        dec: Angle.Degrees(+06.27076966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80598"},
        {"Smithsonian Astrophysical Observation", "SAO 121610"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.83890339),
        dec: Angle.Degrees(+06.27078162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40839"},
        {"Geneva Identification System", "GEN# +9.80050028"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00979010),
        dec: Angle.Degrees(+06.27124844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161940"},
        {"Hipparcos Number", "HIP 87132"},
        {"Geneva Identification System", "GEN# +3.46650102"},
        {"Smithsonian Astrophysical Observation", "SAO 122763"},
        {"Wilson Evans Batten Catalogue", "WEB 14700"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.04265521),
        dec: Angle.Degrees(+06.27152673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24124"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.71851399),
        dec: Angle.Degrees(+06.27441398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150538"},
        {"Hipparcos Number", "HIP 81715"},
        {"Smithsonian Astrophysical Observation", "SAO 121789"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.37123351),
        dec: Angle.Degrees(+06.27593685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188823"},
        {"Hipparcos Number", "HIP 98153"},
        {"Smithsonian Astrophysical Observation", "SAO 125264"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.20579171),
        dec: Angle.Degrees(+06.27644065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84963"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.48306393),
        dec: Angle.Degrees(+06.27694785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104010"},
        {"Geneva Identification System", "GEN# +6.20156506"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.08349676),
        dec: Angle.Degrees(+06.27832279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196136"},
        {"Hipparcos Number", "HIP 101583"},
        {"Smithsonian Astrophysical Observation", "SAO 125988"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.81183282),
        dec: Angle.Degrees(+06.27955746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152973"},
        {"Hipparcos Number", "HIP 82900"},
        {"Smithsonian Astrophysical Observation", "SAO 121951"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.11651670),
        dec: Angle.Degrees(+06.28130025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48568"},
        {"Hipparcos Number", "HIP 32287"},
        {"Geneva Identification System", "GEN# +1.00048568"},
        {"Smithsonian Astrophysical Observation", "SAO 114344"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.10508473),
        dec: Angle.Degrees(+06.28192184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62322"},
        {"Hipparcos Number", "HIP 37656"},
        {"Smithsonian Astrophysical Observation", "SAO 115855"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.90621934),
        dec: Angle.Degrees(+06.28485427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16445"},
        {"Hipparcos Number", "HIP 12304"},
        {"Smithsonian Astrophysical Observation", "SAO 110654"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.61543824),
        dec: Angle.Degrees(+06.28594058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98430"},
    },
    visualMagnitude: 11.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.99181844),
        dec: Angle.Degrees(+19.17908132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127825"},
        {"Hipparcos Number", "HIP 71177"},
        {"Geneva Identification System", "GEN# +1.00127825"},
        {"Smithsonian Astrophysical Observation", "SAO 120524"},
        {"Wilson Evans Batten Catalogue", "WEB 12302"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.35607775),
        dec: Angle.Degrees(+06.28621205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178638"},
        {"Hipparcos Number", "HIP 94088"},
        {"Smithsonian Astrophysical Observation", "SAO 124323"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.30952621),
        dec: Angle.Degrees(+06.28998597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133600"},
        {"Hipparcos Number", "HIP 73815"},
        {"Cincinnati Publication", "Ci 18 2000"},
        {"Smithsonian Astrophysical Observation", "SAO 120828"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.30520912),
        dec: Angle.Degrees(+06.29051291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210669"},
        {"Hipparcos Number", "HIP 109576"},
        {"Geneva Identification System", "GEN# +1.00210669"},
        {"Smithsonian Astrophysical Observation", "SAO 127361"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.96243060),
        dec: Angle.Degrees(+06.29093671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1585"},
        {"Hipparcos Number", "HIP 1602"},
        {"Smithsonian Astrophysical Observation", "SAO 109145"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.02110167),
        dec: Angle.Degrees(+06.29261994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15115"},
        {"Hipparcos Number", "HIP 11360"},
        {"Fundamental Katalog 5th Edition", "FK5 2166"},
        {"Geneva Identification System", "GEN# +1.00015115"},
        {"Smithsonian Astrophysical Observation", "SAO 110532"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.56747573),
        dec: Angle.Degrees(+06.29267404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87823"},
        {"Hipparcos Number", "HIP 49626"},
        {"Geneva Identification System", "GEN# +1.00087823"},
        {"Smithsonian Astrophysical Observation", "SAO 118121"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.92379145),
        dec: Angle.Degrees(+06.29276893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49246"},
        {"Hipparcos Number", "HIP 32569"},
        {"Geneva Identification System", "GEN# +1.00049246"},
        {"Smithsonian Astrophysical Observation", "SAO 114418"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.94395355),
        dec: Angle.Degrees(+06.29698208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80846"},
        {"Hipparcos Number", "HIP 45950"},
        {"Geneva Identification System", "GEN# +1.00080846"},
        {"Smithsonian Astrophysical Observation", "SAO 117628"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.57414457),
        dec: Angle.Degrees(+06.29758278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38350"},
        {"Hipparcos Number", "HIP 27157"},
        {"Celescope Catalog", "CEL 964"},
        {"Geneva Identification System", "GEN# +1.00038350"},
        {"Smithsonian Astrophysical Observation", "SAO 113107"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.35606224),
        dec: Angle.Degrees(+06.29787308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17817"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.19008277),
        dec: Angle.Degrees(+06.30078090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68705"},
        {"Hipparcos Number", "HIP 40308"},
        {"Smithsonian Astrophysical Observation", "SAO 116503"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.46620258),
        dec: Angle.Degrees(+06.30331282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18203"},
        {"Hipparcos Number", "HIP 13632"},
        {"Smithsonian Astrophysical Observation", "SAO 110842"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.88395742),
        dec: Angle.Degrees(+06.30704489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160781"},
        {"Hipparcos Number", "HIP 86575"},
        {"Geneva Identification System", "GEN# +1.00160781"},
        {"Smithsonian Astrophysical Observation", "SAO 122646"},
        {"Wilson Evans Batten Catalogue", "WEB 14600"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.38468625),
        dec: Angle.Degrees(+06.31316423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63125"},
        {"Hipparcos Number", "HIP 38025"},
        {"Smithsonian Astrophysical Observation", "SAO 115935"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.89268910),
        dec: Angle.Degrees(+06.31508984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67291"},
        {"Cincinnati Publication", "Ci 20 808"},
        {"Geneva Identification System", "GEN# +0.00702692"},
        {"Wilson Evans Batten Catalogue", "WEB 11842"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.87124457),
        dec: Angle.Degrees(+06.31592692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -507.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42299"},
        {"Hipparcos Number", "HIP 29261"},
        {"Smithsonian Astrophysical Observation", "SAO 113536"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.54188183),
        dec: Angle.Degrees(+06.32016573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99819"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.80539090),
        dec: Angle.Degrees(+06.32089997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66446"},
        {"Hipparcos Number", "HIP 39453"},
        {"Smithsonian Astrophysical Observation", "SAO 116287"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.96723774),
        dec: Angle.Degrees(+06.32353670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99549"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02924298),
        dec: Angle.Degrees(+06.32931564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1940 AB"},
        {"Henry Draper", "HD 15804"},
        {"Hipparcos Number", "HIP 11829"},
        {"Smithsonian Astrophysical Observation", "SAO 110599"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)32, 39.5300),
        dec: Angle.DegreesMinutesSeconds((int)+06, (int)19, 48.300)
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
    primaryId: "HIP 103327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199269"},
        {"Hipparcos Number", "HIP 103327"},
        {"Smithsonian Astrophysical Observation", "SAO 126382"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.00783180),
        dec: Angle.Degrees(+06.33258306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224996"},
        {"Hipparcos Number", "HIP 188"},
        {"Smithsonian Astrophysical Observation", "SAO 128545"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.60250452),
        dec: Angle.Degrees(+06.33313676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6494 AB"},
        {"Henry Draper", "HD 65477"},
        {"Hipparcos Number", "HIP 39025"},
        {"Wilson Evans Batten Catalogue", "WEB 7650"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.77514665),
        dec: Angle.Degrees(+06.33678145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48790"},
        {"Smithsonian Astrophysical Observation", "SAO 118008"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.26889871),
        dec: Angle.Degrees(+06.33716302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18581"},
        {"Hipparcos Number", "HIP 13932"},
        {"Smithsonian Astrophysical Observation", "SAO 110886"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.87791532),
        dec: Angle.Degrees(+06.33972770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171196"},
        {"Hipparcos Number", "HIP 90947"},
        {"Smithsonian Astrophysical Observation", "SAO 123627"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.28309207),
        dec: Angle.Degrees(+06.34389938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120448"},
        {"Hipparcos Number", "HIP 67461"},
        {"Smithsonian Astrophysical Observation", "SAO 120127"},
        {"Wilson Evans Batten Catalogue", "WEB 11864"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.37221642),
        dec: Angle.Degrees(+06.34390880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185209"},
        {"Hipparcos Number", "HIP 96559"},
        {"Smithsonian Astrophysical Observation", "SAO 124869"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.45850463),
        dec: Angle.Degrees(+06.34393215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42550"},
        {"Hipparcos Number", "HIP 29381"},
        {"Geneva Identification System", "GEN# +1.00042550"},
        {"Smithsonian Astrophysical Observation", "SAO 113566"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88751654),
        dec: Angle.Degrees(+06.34447125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102898"},
        {"Hipparcos Number", "HIP 57769"},
        {"Smithsonian Astrophysical Observation", "SAO 119078"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.70315989),
        dec: Angle.Degrees(+06.34522621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65248"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.57269269),
        dec: Angle.Degrees(+06.34528161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48099"},
        {"Hipparcos Number", "HIP 32067"},
        {"Geneva Identification System", "GEN# +1.00048099"},
        {"Smithsonian Astrophysical Observation", "SAO 114293"},
        {"Wilson Evans Batten Catalogue", "WEB 6473"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.49679354),
        dec: Angle.Degrees(+06.34541897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93431"},
        {"Hipparcos Number", "HIP 52763"},
        {"Smithsonian Astrophysical Observation", "SAO 118493"},
        {"Wilson Evans Batten Catalogue", "WEB 9602"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.82993702),
        dec: Angle.Degrees(+06.34629403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6323"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.29209093),
        dec: Angle.Degrees(+06.34678165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27088"},
        {"Hipparcos Number", "HIP 19977"},
        {"Smithsonian Astrophysical Observation", "SAO 111717"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.26268929),
        dec: Angle.Degrees(+06.34746351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76961"},
        {"Hipparcos Number", "HIP 44155"},
        {"Smithsonian Astrophysical Observation", "SAO 117324"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.89285483),
        dec: Angle.Degrees(+06.34771182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191707"},
        {"Hipparcos Number", "HIP 99456"},
        {"Smithsonian Astrophysical Observation", "SAO 125533"},
        {"Wilson Evans Batten Catalogue", "WEB 17774"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.79015987),
        dec: Angle.Degrees(+06.34857825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98959"},
        {"Hipparcos Number", "HIP 55599"},
        {"Smithsonian Astrophysical Observation", "SAO 118826"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.84605992),
        dec: Angle.Degrees(+06.34953490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25336",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bellatrix"},
        {"Henry Draper", "HD 35468"},
        {"Hipparcos Number", "HIP 25336"},
        {"Fundamental Katalog 5th Edition", "FK5 201"},
        {"Geneva Identification System", "GEN# +1.00035438"},
        {"Geneva Identification System 2", "GEN# +1.00035468"},
        {"Smithsonian Astrophysical Observation", "SAO 112740"},
        {"Wilson Evans Batten Catalogue", "WEB 4913"},
    },
    visualMagnitude: 1.64,
    bvColour: -0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.28278416),
        dec: Angle.Degrees(+06.34973451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7352 AB"},
        {"Henry Draper", "HD 81212"},
        {"Hipparcos Number", "HIP 46134"},
        {"Smithsonian Astrophysical Observation", "SAO 117661"},
        {"Wilson Evans Batten Catalogue", "WEB 8735"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.11947782),
        dec: Angle.Degrees(+06.35019131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38291"},
        {"Hipparcos Number", "HIP 27115"},
        {"Celescope Catalog", "CEL 961"},
        {"Geneva Identification System", "GEN# +1.00038291"},
        {"Smithsonian Astrophysical Observation", "SAO 113097"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.25211612),
        dec: Angle.Degrees(+06.35042821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9079"},
        {"Smithsonian Astrophysical Observation", "SAO 110244"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.22506942),
        dec: Angle.Degrees(+06.35047864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120066"},
        {"Hipparcos Number", "HIP 67246"},
        {"Cincinnati Publication", "Ci 20 805"},
        {"Geneva Identification System", "GEN# +1.00120066A"},
        {"Smithsonian Astrophysical Observation", "SAO 120108"},
        {"Wilson Evans Batten Catalogue", "WEB 11833"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.73925975),
        dec: Angle.Degrees(+06.35064241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -511.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56919"},
        {"Hipparcos Number", "HIP 35458"},
        {"Smithsonian Astrophysical Observation", "SAO 115254"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.80124336),
        dec: Angle.Degrees(+06.35117805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78888"},
        {"Hipparcos Number", "HIP 45066"},
        {"Smithsonian Astrophysical Observation", "SAO 117476"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.68863140),
        dec: Angle.Degrees(+06.35295212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117762"},
        {"Hipparcos Number", "HIP 66033"},
        {"Smithsonian Astrophysical Observation", "SAO 119988"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.07315092),
        dec: Angle.Degrees(+06.35343825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158836"},
        {"Hipparcos Number", "HIP 85735"},
        {"Smithsonian Astrophysical Observation", "SAO 122464"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.80401058),
        dec: Angle.Degrees(+06.35444048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195449"},
        {"Hipparcos Number", "HIP 101238"},
        {"Smithsonian Astrophysical Observation", "SAO 125890"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.81343988),
        dec: Angle.Degrees(+06.35570424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69205"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.53149281),
        dec: Angle.Degrees(+06.35750090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5867 AB"},
        {"Henry Draper", "HD 55163"},
        {"Hipparcos Number", "HIP 34783"},
        {"Smithsonian Astrophysical Observation", "SAO 115064"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.01838465),
        dec: Angle.Degrees(+06.35947985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3269"},
        {"Hipparcos Number", "HIP 2831"},
        {"Smithsonian Astrophysical Observation", "SAO 109304"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.97630506),
        dec: Angle.Degrees(+06.36264126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108058"},
        {"Hipparcos Number", "HIP 60562"},
        {"Smithsonian Astrophysical Observation", "SAO 119384"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.21758521),
        dec: Angle.Degrees(+06.36366940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17581"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.48953243),
        dec: Angle.Degrees(+06.36414884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211986"},
        {"Hipparcos Number", "HIP 110348"},
        {"Smithsonian Astrophysical Observation", "SAO 127463"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25178459),
        dec: Angle.Degrees(+06.36454901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113382"},
        {"Hipparcos Number", "HIP 63696"},
        {"Smithsonian Astrophysical Observation", "SAO 119739"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.80266028),
        dec: Angle.Degrees(+06.36521376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84312",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10409 AB"},
        {"Henry Draper", "HD 155925"},
        {"Hipparcos Number", "HIP 84312"},
        {"Smithsonian Astrophysical Observation", "SAO 122200"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.55908083),
        dec: Angle.Degrees(+06.36633127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91411"},
        {"Hipparcos Number", "HIP 51667"},
        {"Smithsonian Astrophysical Observation", "SAO 118357"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.33187304),
        dec: Angle.Degrees(+06.36652516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47756"},
        {"Hipparcos Number", "HIP 31945"},
        {"Celescope Catalog", "CEL 1346"},
        {"Geneva Identification System", "GEN# +1.00047756"},
        {"Renson", "Renson 12840"},
        {"Smithsonian Astrophysical Observation", "SAO 114244"},
        {"Wilson Evans Batten Catalogue", "WEB 6422"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.13311612),
        dec: Angle.Degrees(+06.37125090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57746"},
        {"Hipparcos Number", "HIP 35788"},
        {"Geneva Identification System", "GEN# +1.00057746"},
        {"Smithsonian Astrophysical Observation", "SAO 115361"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.72410061),
        dec: Angle.Degrees(+06.37314910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93244"},
        {"Hipparcos Number", "HIP 52660"},
        {"Fundamental Katalog 5th Edition", "FK5 1278"},
        {"Geneva Identification System", "GEN# +1.00093244"},
        {"Smithsonian Astrophysical Observation", "SAO 118483"},
        {"Wilson Evans Batten Catalogue", "WEB 9589"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.52368605),
        dec: Angle.Degrees(+06.37327206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76599"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.66320135),
        dec: Angle.Degrees(+06.37531098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129817"},
        {"Hipparcos Number", "HIP 72071"},
        {"Smithsonian Astrophysical Observation", "SAO 120630"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.13010710),
        dec: Angle.Degrees(+06.37558352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24841"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.88192543),
        dec: Angle.Degrees(+06.37602511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70008"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.87255702),
        dec: Angle.Degrees(+06.37878404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27821"},
        {"Hipparcos Number", "HIP 20515"},
        {"Geneva Identification System", "GEN# +1.00027821"},
        {"Smithsonian Astrophysical Observation", "SAO 111789"},
        {"Wilson Evans Batten Catalogue", "WEB 3925"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.94082667),
        dec: Angle.Degrees(+06.37895229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220954"},
        {"Hipparcos Number", "HIP 115830"},
        {"Fundamental Katalog 5th Edition", "FK5 1614"},
        {"Geneva Identification System", "GEN# +1.00220954"},
        {"Smithsonian Astrophysical Observation", "SAO 128196"},
        {"Wilson Evans Batten Catalogue", "WEB 20494"},
    },
    visualMagnitude: 4.27,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.99236589),
        dec: Angle.Degrees(+06.37909727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109402"},
        {"Hipparcos Number", "HIP 61354"},
        {"Smithsonian Astrophysical Observation", "SAO 119478"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.58678742),
        dec: Angle.Degrees(+06.37915300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7454"},
    },
    visualMagnitude: 12.13,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.00913192),
        dec: Angle.Degrees(+06.37969372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156166"},
        {"Hipparcos Number", "HIP 84433"},
        {"Smithsonian Astrophysical Observation", "SAO 122217"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.93092001),
        dec: Angle.Degrees(+06.38001063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16909"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.39730034),
        dec: Angle.Degrees(+06.38033845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145148"},
        {"Hipparcos Number", "HIP 79137"},
        {"Cincinnati Publication", "Ci 20 969"},
        {"Fundamental Katalog 5th Edition", "FK5 1422"},
        {"Geneva Identification System", "GEN# +1.00145148"},
        {"Smithsonian Astrophysical Observation", "SAO 121392"},
        {"Wilson Evans Batten Catalogue", "WEB 13379"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.29609713),
        dec: Angle.Degrees(+06.38050993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -746.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223392"},
        {"Hipparcos Number", "HIP 117467"},
        {"Geneva Identification System", "GEN# +1.00223392"},
        {"Smithsonian Astrophysical Observation", "SAO 128396"},
        {"Wilson Evans Batten Catalogue", "WEB 20689"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.27281649),
        dec: Angle.Degrees(+06.38240883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101783"},
        {"Hipparcos Number", "HIP 57136"},
        {"Smithsonian Astrophysical Observation", "SAO 119008"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.72369015),
        dec: Angle.Degrees(+06.38323141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10214"},
        {"Hipparcos Number", "HIP 7774"},
        {"Smithsonian Astrophysical Observation", "SAO 110040"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.01605149),
        dec: Angle.Degrees(+06.38612653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40166"},
        {"Hipparcos Number", "HIP 28196"},
        {"Smithsonian Astrophysical Observation", "SAO 113294"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.37567991),
        dec: Angle.Degrees(+06.39118300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195037"},
        {"Hipparcos Number", "HIP 101015"},
        {"Smithsonian Astrophysical Observation", "SAO 125852"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.18861797),
        dec: Angle.Degrees(+06.39379042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53531"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.28302577),
        dec: Angle.Degrees(+06.39641835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161885"},
        {"Hipparcos Number", "HIP 87107"},
        {"Geneva Identification System", "GEN# +3.46650099"},
        {"Smithsonian Astrophysical Observation", "SAO 122757"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.96985919),
        dec: Angle.Degrees(+06.40257335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215460"},
        {"Hipparcos Number", "HIP 112336"},
        {"Geneva Identification System", "GEN# +1.00215460"},
        {"Smithsonian Astrophysical Observation", "SAO 127733"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.30614474),
        dec: Angle.Degrees(+06.40264269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83620"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34896191),
        dec: Angle.Degrees(+06.40267132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64937"},
        {"Hipparcos Number", "HIP 38807"},
        {"Smithsonian Astrophysical Observation", "SAO 116148"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.13216586),
        dec: Angle.Degrees(+06.40642327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4760"},
        {"Hipparcos Number", "HIP 3869"},
        {"Smithsonian Astrophysical Observation", "SAO 109485"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.41630759),
        dec: Angle.Degrees(+06.40714131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98036",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alshain"},
        {"Aitken", "ADS 13110 A"},
        {"Henry Draper", "HD 188512"},
        {"Hipparcos Number", "HIP 98036"},
        {"Cincinnati Publication", "Ci 20 1173"},
        {"Fundamental Katalog 5th Edition", "FK5 749"},
        {"Geneva Identification System", "GEN# +1.00188512"},
        {"Smithsonian Astrophysical Observation", "SAO 125235"},
        {"Wilson Evans Batten Catalogue", "WEB 17267"},
    },
    visualMagnitude: 3.71,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.82819233),
        dec: Angle.Degrees(+06.40793334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -481.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33851"},
        {"Cincinnati Publication", "Ci 20 409"},
    },
    visualMagnitude: 11.88,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.40363851),
        dec: Angle.Degrees(+06.40964140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -673.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126142"},
        {"Hipparcos Number", "HIP 70348"},
        {"Geneva Identification System", "GEN# +1.00126142"},
        {"Smithsonian Astrophysical Observation", "SAO 120428"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.89309848),
        dec: Angle.Degrees(+06.41035606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165672"},
        {"Hipparcos Number", "HIP 88724"},
        {"Geneva Identification System", "GEN# +1.00165672"},
        {"Smithsonian Astrophysical Observation", "SAO 123130"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.70338505),
        dec: Angle.Degrees(+06.41065358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224577"},
        {"Hipparcos Number", "HIP 118242"},
        {"Smithsonian Astrophysical Observation", "SAO 128510"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.74770288),
        dec: Angle.Degrees(+06.41351914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170293"},
        {"Hipparcos Number", "HIP 90534"},
        {"Geneva Identification System", "GEN# +2.66330125"},
        {"Smithsonian Astrophysical Observation", "SAO 123534"},
        {"New General Catalogue", "NGC 6633 125"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.09578550),
        dec: Angle.Degrees(+06.41389233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208027"},
        {"Hipparcos Number", "HIP 108038"},
        {"Smithsonian Astrophysical Observation", "SAO 127134"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.32942769),
        dec: Angle.Degrees(+06.41471628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89241"},
        {"Hipparcos Number", "HIP 50423"},
        {"Smithsonian Astrophysical Observation", "SAO 118202"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.43927454),
        dec: Angle.Degrees(+06.41585946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8857"},
        {"Hipparcos Number", "HIP 6792"},
        {"Smithsonian Astrophysical Observation", "SAO 109901"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.85614303),
        dec: Angle.Degrees(+06.41593266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225262"},
        {"Hipparcos Number", "HIP 388"},
        {"Smithsonian Astrophysical Observation", "SAO 108998"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.21025761),
        dec: Angle.Degrees(+06.41668139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22211"},
        {"Hipparcos Number", "HIP 16695"},
        {"Geneva Identification System", "GEN# +1.00022211"},
        {"Smithsonian Astrophysical Observation", "SAO 111273"},
        {"Wilson Evans Batten Catalogue", "WEB 3180"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.70456368),
        dec: Angle.Degrees(+06.41773268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43109",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ashlesha"},
        {"Aitken", "ADS 6993 AB"},
        {"Henry Draper", "HD 74874"},
        {"Hipparcos Number", "HIP 43109"},
        {"Smithsonian Astrophysical Observation", "SAO 117112"},
        {"Wilson Evans Batten Catalogue", "WEB 8321"},
    },
    visualMagnitude: 3.38,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.69435930),
        dec: Angle.Degrees(+06.41890691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70342"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.87834384),
        dec: Angle.Degrees(+06.41894525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164115"},
        {"Hipparcos Number", "HIP 88088"},
        {"Geneva Identification System", "GEN# +1.00164115"},
        {"Smithsonian Astrophysical Observation", "SAO 122988"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.86278388),
        dec: Angle.Degrees(+06.41897908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116877"},
    },
    visualMagnitude: 12.13,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.36291483),
        dec: Angle.Degrees(+06.41925113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15222 AB"},
        {"Henry Draper", "HD 206387"},
        {"Hipparcos Number", "HIP 107107"},
        {"Smithsonian Astrophysical Observation", "SAO 126991"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.43200845),
        dec: Angle.Degrees(+06.42083178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54639"},
        {"Cincinnati Publication", "Ci 20 614"},
        {"Geneva Identification System", "GEN# +9.80010004"},
        {"Wilson Evans Batten Catalogue", "WEB 9863"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.75138060),
        dec: Angle.Degrees(+06.42110067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -565.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -509.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32909"},
        {"Hipparcos Number", "HIP 23795"},
        {"Geneva Identification System", "GEN# +1.00032909"},
        {"Smithsonian Astrophysical Observation", "SAO 112424"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.69090304),
        dec: Angle.Degrees(+06.42166683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116893"},
        {"Hipparcos Number", "HIP 65563"},
        {"Smithsonian Astrophysical Observation", "SAO 119926"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.63454967),
        dec: Angle.Degrees(+06.42314956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14996"},
        {"Smithsonian Astrophysical Observation", "SAO 111055"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.31721758),
        dec: Angle.Degrees(+06.42401887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106408"},
        {"Geneva Identification System", "GEN# +0.00504809"},
        {"Smithsonian Astrophysical Observation", "SAO 126885"},
    },
    visualMagnitude: 9.84,
    bvColour: 2.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.29049727),
        dec: Angle.Degrees(+06.42443407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221248"},
        {"Hipparcos Number", "HIP 116015"},
        {"Smithsonian Astrophysical Observation", "SAO 128214"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.59088265),
        dec: Angle.Degrees(+06.42535427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77070",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Unukalhai"},
        {"Aitken", "ADS 9765 A"},
        {"Henry Draper", "HD 140573"},
        {"Hipparcos Number", "HIP 77070"},
        {"Fundamental Katalog 5th Edition", "FK5 582"},
        {"Geneva Identification System", "GEN# +1.00140573"},
        {"Smithsonian Astrophysical Observation", "SAO 121157"},
        {"Wilson Evans Batten Catalogue", "WEB 13072"},
    },
    visualMagnitude: 2.63,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.06664914),
        dec: Angle.Degrees(+06.42551971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157808"},
        {"Hipparcos Number", "HIP 85251"},
        {"Smithsonian Astrophysical Observation", "SAO 122362"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.31140107),
        dec: Angle.Degrees(+06.42932981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7730 AB"},
        {"Henry Draper", "HD 89619"},
        {"Hipparcos Number", "HIP 50637"},
        {"Geneva Identification System", "GEN# +1.00089619J"},
        {"Smithsonian Astrophysical Observation", "SAO 118241"},
        {"Wilson Evans Batten Catalogue", "WEB 9284"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.13466633),
        dec: Angle.Degrees(+06.42987675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67653"},
        {"Geneva Identification System", "GEN# +0.00702708"},
        {"Wilson Evans Batten Catalogue", "WEB 11899"},
    },
    visualMagnitude: 11.38,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.92005882),
        dec: Angle.Degrees(+06.43095190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16189"},
        {"Hipparcos Number", "HIP 12113"},
        {"Geneva Identification System", "GEN# +1.00016189"},
        {"Smithsonian Astrophysical Observation", "SAO 110637"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.01046481),
        dec: Angle.Degrees(+06.43251160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15593"},
        {"Smithsonian Astrophysical Observation", "SAO 111137"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.20609014),
        dec: Angle.Degrees(+06.43326495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165173"},
        {"Hipparcos Number", "HIP 88511"},
        {"Geneva Identification System", "GEN# +1.00165173"},
        {"Smithsonian Astrophysical Observation", "SAO 123089"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.10994854),
        dec: Angle.Degrees(+06.43622072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50640",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.44,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)20, 33.9300),
        dec: Angle.DegreesMinutesSeconds((int)+06, (int)26, 11.500)
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
    primaryId: "HIP 13198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13198"},
    },
    visualMagnitude: 12.19,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.46567789),
        dec: Angle.Degrees(+06.46746958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11730"},
        {"Hipparcos Number", "HIP 8951"},
        {"Geneva Identification System", "GEN# +1.00011730"},
        {"Smithsonian Astrophysical Observation", "SAO 110228"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.82649081),
        dec: Angle.Degrees(+06.43725415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76224"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.56489289),
        dec: Angle.Degrees(+06.44046012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242018"},
        {"Hipparcos Number", "HIP 24473"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.78417271),
        dec: Angle.Degrees(+06.44120214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159972"},
        {"Hipparcos Number", "HIP 86225"},
        {"Geneva Identification System", "GEN# +1.00159972"},
        {"Smithsonian Astrophysical Observation", "SAO 122573"},
        {"Wilson Evans Batten Catalogue", "WEB 14541"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.31033118),
        dec: Angle.Degrees(+06.44217886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113881"},
        {"Hipparcos Number", "HIP 63984"},
        {"Smithsonian Astrophysical Observation", "SAO 119766"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.66816089),
        dec: Angle.Degrees(+06.44538581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83424"},
        {"Hipparcos Number", "HIP 47314"},
        {"Smithsonian Astrophysical Observation", "SAO 117822"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.62202763),
        dec: Angle.Degrees(+06.44559036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117459"},
        {"Geneva Identification System", "GEN# +9.80029067"},
    },
    visualMagnitude: 12.30,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.24348683),
        dec: Angle.Degrees(+06.44811162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 283.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118160"},
        {"Hipparcos Number", "HIP 66270"},
        {"Smithsonian Astrophysical Observation", "SAO 120017"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.73633341),
        dec: Angle.Degrees(+06.45239458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4390 AB"},
        {"Henry Draper", "HD 38710"},
        {"Hipparcos Number", "HIP 27386"},
        {"Celescope Catalog", "CEL 974"},
        {"Geneva Identification System", "GEN# +1.00038710J"},
        {"Smithsonian Astrophysical Observation", "SAO 113150"},
        {"Wilson Evans Batten Catalogue", "WEB 5381"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.00096600),
        dec: Angle.Degrees(+06.45421020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153781"},
        {"Hipparcos Number", "HIP 83277"},
        {"Smithsonian Astrophysical Observation", "SAO 122006"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.29674472),
        dec: Angle.Degrees(+06.45746043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11420 AB"},
        {"Henry Draper", "HD 170881"},
        {"Hipparcos Number", "HIP 90807"},
        {"Geneva Identification System", "GEN# +2.66330177"},
        {"Smithsonian Astrophysical Observation", "SAO 123602"},
        {"New General Catalogue", "NGC 6633 177"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.86041996),
        dec: Angle.Degrees(+06.46032443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244484"},
        {"Hipparcos Number", "HIP 25846"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.76352982),
        dec: Angle.Degrees(+06.46072099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171427"},
        {"Hipparcos Number", "HIP 91063"},
        {"Smithsonian Astrophysical Observation", "SAO 123652"},
        {"Wilson Evans Batten Catalogue", "WEB 15628"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.63042300),
        dec: Angle.Degrees(+06.46232949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71824"},
        {"Geneva Identification System", "GEN# +9.80066020"},
    },
    visualMagnitude: 12.03,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.38828476),
        dec: Angle.Degrees(+06.46376984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135615"},
        {"Hipparcos Number", "HIP 74695"},
        {"Smithsonian Astrophysical Observation", "SAO 120923"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.97321305),
        dec: Angle.Degrees(+06.46488638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240629"},
        {"Hipparcos Number", "HIP 23701"},
        {"Smithsonian Astrophysical Observation", "SAO 112412"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.41806930),
        dec: Angle.Degrees(+06.46516704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2647"},
        {"Hipparcos Number", "HIP 2356"},
        {"Smithsonian Astrophysical Observation", "SAO 109237"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.53079372),
        dec: Angle.Degrees(+06.46764663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216588"},
        {"Hipparcos Number", "HIP 113079"},
        {"Smithsonian Astrophysical Observation", "SAO 127828"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.52286271),
        dec: Angle.Degrees(+06.46791201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43233"},
        {"Cincinnati Publication", "Ci 20 489"},
        {"Geneva Identification System", "GEN# +0.00702031"},
        {"Wilson Evans Batten Catalogue", "WEB 8336"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.10846028),
        dec: Angle.Degrees(+06.46942020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -436.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44320"},
        {"Hipparcos Number", "HIP 30219"},
        {"Geneva Identification System", "GEN# +1.00044320"},
        {"Smithsonian Astrophysical Observation", "SAO 113757"},
        {"Wilson Evans Batten Catalogue", "WEB 6008"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.35960237),
        dec: Angle.Degrees(+06.47016500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85475"},
        {"Hipparcos Number", "HIP 48404"},
        {"Smithsonian Astrophysical Observation", "SAO 117955"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.03306105),
        dec: Angle.Degrees(+06.47124433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15880 A"},
        {"Henry Draper", "HD 212226"},
        {"Hipparcos Number", "HIP 110465"},
        {"Smithsonian Astrophysical Observation", "SAO 127485"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.64290329),
        dec: Angle.Degrees(+06.47333149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13408",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2193 AB"},
        {"Henry Draper", "HD 17907"},
        {"Hipparcos Number", "HIP 13408"},
        {"Smithsonian Astrophysical Observation", "SAO 110807"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.16514420),
        dec: Angle.Degrees(+06.47484549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182473"},
        {"Hipparcos Number", "HIP 95418"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.14754861),
        dec: Angle.Degrees(+06.47512217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22627"},
        {"Geneva Identification System", "GEN# +9.80082052"},
        {"Geneva Identification System 2", "GEN# +6.10010179"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.02350646),
        dec: Angle.Degrees(+06.47729317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -310.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107809"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.61158559),
        dec: Angle.Degrees(+06.48054252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186325"},
        {"Hipparcos Number", "HIP 97058"},
        {"Geneva Identification System", "GEN# +1.00186325"},
        {"Smithsonian Astrophysical Observation", "SAO 124992"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.87535460),
        dec: Angle.Degrees(+06.48149390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5820"},
        {"Hipparcos Number", "HIP 4655"},
        {"Geneva Identification System", "GEN# +1.00005820"},
        {"Smithsonian Astrophysical Observation", "SAO 109581"},
        {"Wilson Evans Batten Catalogue", "WEB 873"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.95697840),
        dec: Angle.Degrees(+06.48323806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160140"},
        {"Hipparcos Number", "HIP 86299"},
        {"Smithsonian Astrophysical Observation", "SAO 122584"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.50230424),
        dec: Angle.Degrees(+06.48328200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8523"},
        {"Hipparcos Number", "HIP 6572"},
        {"Geneva Identification System", "GEN# +1.00008523"},
        {"Smithsonian Astrophysical Observation", "SAO 109864"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.10544233),
        dec: Angle.Degrees(+06.48430897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92128"},
        {"Hipparcos Number", "HIP 52060"},
        {"Smithsonian Astrophysical Observation", "SAO 118404"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.57365683),
        dec: Angle.Degrees(+06.48446295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20501"},
        {"Hipparcos Number", "HIP 15362"},
        {"Smithsonian Astrophysical Observation", "SAO 111107"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.51872063),
        dec: Angle.Degrees(+06.48459585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83557"},
        {"Hipparcos Number", "HIP 47396"},
        {"Smithsonian Astrophysical Observation", "SAO 117827"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86105509),
        dec: Angle.Degrees(+06.48531550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163641"},
        {"Hipparcos Number", "HIP 87866"},
        {"Geneva Identification System", "GEN# +1.00163641"},
        {"Smithsonian Astrophysical Observation", "SAO 122949"},
        {"Wilson Evans Batten Catalogue", "WEB 14833"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.23318538),
        dec: Angle.Degrees(+06.48773401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36664"},
        {"Smithsonian Astrophysical Observation", "SAO 115586"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.14400145),
        dec: Angle.Degrees(+06.48969532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41261"},
        {"Hipparcos Number", "HIP 28750"},
        {"Smithsonian Astrophysical Observation", "SAO 113417"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.07066650),
        dec: Angle.Degrees(+06.49114546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21526"},
        {"Smithsonian Astrophysical Observation", "SAO 111927"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.33160676),
        dec: Angle.Degrees(+06.49381570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30266"},
        {"Hipparcos Number", "HIP 22184"},
        {"Smithsonian Astrophysical Observation", "SAO 112059"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.59282204),
        dec: Angle.Degrees(+06.49554798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257546"},
        {"Hipparcos Number", "HIP 30725"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.82795583),
        dec: Angle.Degrees(+06.49606355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77278"},
        {"Hipparcos Number", "HIP 44341"},
        {"Geneva Identification System", "GEN# +1.00077278"},
        {"Smithsonian Astrophysical Observation", "SAO 117358"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.44782447),
        dec: Angle.Degrees(+06.49799708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8443"},
        {"Hipparcos Number", "HIP 6521"},
        {"Geneva Identification System", "GEN# +1.00008443"},
        {"Smithsonian Astrophysical Observation", "SAO 109856"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.94524486),
        dec: Angle.Degrees(+06.49911684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101164"},
        {"Hipparcos Number", "HIP 56787"},
        {"Smithsonian Astrophysical Observation", "SAO 118966"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.63674445),
        dec: Angle.Degrees(+06.50004114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111131"},
        {"Smithsonian Astrophysical Observation", "SAO 127566"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.69681422),
        dec: Angle.Degrees(+06.50042908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196484"},
        {"Hipparcos Number", "HIP 101771"},
        {"Smithsonian Astrophysical Observation", "SAO 126031"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.39080330),
        dec: Angle.Degrees(+06.50094961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153033"},
        {"Hipparcos Number", "HIP 82929"},
        {"Geneva Identification System", "GEN# +1.00153033"},
        {"Smithsonian Astrophysical Observation", "SAO 121954"},
        {"Wilson Evans Batten Catalogue", "WEB 14022"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.21300190),
        dec: Angle.Degrees(+06.50133099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115322"},
        {"Hipparcos Number", "HIP 64768"},
        {"Geneva Identification System", "GEN# +1.00115322"},
        {"Smithsonian Astrophysical Observation", "SAO 119843"},
        {"Wilson Evans Batten Catalogue", "WEB 11447"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.09975050),
        dec: Angle.Degrees(+06.50474518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120406"},
        {"Hipparcos Number", "HIP 67430"},
        {"Geneva Identification System", "GEN# +1.00120406"},
        {"Smithsonian Astrophysical Observation", "SAO 120123"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.29793331),
        dec: Angle.Degrees(+06.50533615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8724 A"},
        {"Henry Draper", "HD 112815"},
        {"Hipparcos Number", "HIP 63386"},
        {"Geneva Identification System", "GEN# +1.00112815"},
        {"Smithsonian Astrophysical Observation", "SAO 119696"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.83406273),
        dec: Angle.Degrees(+06.50590291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104407"},
        {"Hipparcos Number", "HIP 58638"},
        {"Smithsonian Astrophysical Observation", "SAO 119170"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.36540015),
        dec: Angle.Degrees(+06.50604152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103421"},
        {"Hipparcos Number", "HIP 58065"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.62995724),
        dec: Angle.Degrees(+06.50626213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197196"},
        {"Hipparcos Number", "HIP 102166"},
        {"Smithsonian Astrophysical Observation", "SAO 126116"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.52447923),
        dec: Angle.Degrees(+06.50761491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63383",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8724 B"},
        {"Hipparcos Number", "HIP 63383"},
        {"Smithsonian Astrophysical Observation", "SAO 119695"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.82917337),
        dec: Angle.Degrees(+06.50937754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66297"},
        {"Smithsonian Astrophysical Observation", "SAO 120022"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.81248355),
        dec: Angle.Degrees(+06.50961873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21920"},
        {"Smithsonian Astrophysical Observation", "SAO 111999"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.70535377),
        dec: Angle.Degrees(+06.50980527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45355"},
        {"Hipparcos Number", "HIP 30719"},
        {"Smithsonian Astrophysical Observation", "SAO 113899"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.81269372),
        dec: Angle.Degrees(+06.51065398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40300"},
        {"Hipparcos Number", "HIP 28254"},
        {"Geneva Identification System", "GEN# +1.00040300"},
        {"Smithsonian Astrophysical Observation", "SAO 113309"},
        {"Wilson Evans Batten Catalogue", "WEB 5527"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.55469271),
        dec: Angle.Degrees(+06.51137103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214182"},
        {"Hipparcos Number", "HIP 111593"},
        {"Smithsonian Astrophysical Observation", "SAO 127631"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.11747872),
        dec: Angle.Degrees(+06.51222319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64815"},
        {"Hipparcos Number", "HIP 38750"},
        {"Geneva Identification System", "GEN# +1.00064815"},
        {"Smithsonian Astrophysical Observation", "SAO 116135"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.00215563),
        dec: Angle.Degrees(+06.51248148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74848"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.43062048),
        dec: Angle.Degrees(+06.51516980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38164"},
        {"Hipparcos Number", "HIP 27036"},
        {"Geneva Identification System", "GEN# +1.00038164"},
        {"Smithsonian Astrophysical Observation", "SAO 113089"},
        {"Wilson Evans Batten Catalogue", "WEB 5324"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.01370435),
        dec: Angle.Degrees(+06.51565537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4856 AB"},
        {"Henry Draper", "HD 43212"},
        {"Hipparcos Number", "HIP 29685"},
        {"Smithsonian Astrophysical Observation", "SAO 113638"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.80679479),
        dec: Angle.Degrees(+06.51594970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158168"},
        {"Hipparcos Number", "HIP 85428"},
        {"Smithsonian Astrophysical Observation", "SAO 122399"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.84898041),
        dec: Angle.Degrees(+06.51698130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218056"},
        {"Hipparcos Number", "HIP 113977"},
        {"Smithsonian Astrophysical Observation", "SAO 127954"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.24118538),
        dec: Angle.Degrees(+06.51742063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195633"},
        {"Hipparcos Number", "HIP 101346"},
        {"Geneva Identification System", "GEN# +1.00195633"},
        {"Smithsonian Astrophysical Observation", "SAO 125916"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.09978364),
        dec: Angle.Degrees(+06.51751703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170054"},
        {"Hipparcos Number", "HIP 90443"},
        {"Geneva Identification System", "GEN# +2.66330077"},
        {"Renson", "Renson 47660"},
        {"Smithsonian Astrophysical Observation", "SAO 123501"},
        {"New General Catalogue", "NGC 6633 77"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.81121460),
        dec: Angle.Degrees(+06.51859976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157686"},
        {"Hipparcos Number", "HIP 85177"},
        {"Geneva Identification System", "GEN# +1.00157686"},
        {"Smithsonian Astrophysical Observation", "SAO 122353"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.10566243),
        dec: Angle.Degrees(+06.51978797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159413"},
        {"Hipparcos Number", "HIP 85982"},
        {"Smithsonian Astrophysical Observation", "SAO 122519"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.59549643),
        dec: Angle.Degrees(+06.52141901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100728"},
        {"Hipparcos Number", "HIP 56537"},
        {"Smithsonian Astrophysical Observation", "SAO 118934"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.89215203),
        dec: Angle.Degrees(+06.52172597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225242"},
        {"Hipparcos Number", "HIP 376"},
        {"Smithsonian Astrophysical Observation", "SAO 108996"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.17156400),
        dec: Angle.Degrees(+06.52258527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102732"},
        {"Hipparcos Number", "HIP 57676"},
        {"Geneva Identification System", "GEN# +1.00102732"},
        {"Smithsonian Astrophysical Observation", "SAO 119066"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.43587916),
        dec: Angle.Degrees(+06.52346706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25368"},
        {"Hipparcos Number", "HIP 18826"},
        {"Smithsonian Astrophysical Observation", "SAO 111570"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.51660842),
        dec: Angle.Degrees(+06.52387136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21321"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.65309596),
        dec: Angle.Degrees(+06.52396135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188126"},
        {"Hipparcos Number", "HIP 97882"},
        {"Geneva Identification System", "GEN# +1.00188126"},
        {"Smithsonian Astrophysical Observation", "SAO 125184"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.35694122),
        dec: Angle.Degrees(+06.52507401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114588"},
        {"Geneva Identification System", "GEN# +0.00505147"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.20612818),
        dec: Angle.Degrees(+06.52693019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111947",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16165 AB"},
        {"Henry Draper", "HD 214809"},
        {"Hipparcos Number", "HIP 111947"},
        {"Geneva Identification System", "GEN# +1.00214809J"},
        {"Smithsonian Astrophysical Observation", "SAO 127684"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.14470186),
        dec: Angle.Degrees(+06.52857567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11271"},
        {"Hipparcos Number", "HIP 8587"},
        {"Geneva Identification System", "GEN# +1.00011271"},
        {"Smithsonian Astrophysical Observation", "SAO 110164"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.71678664),
        dec: Angle.Degrees(+06.52881351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173193"},
        {"Hipparcos Number", "HIP 91877"},
        {"Smithsonian Astrophysical Observation", "SAO 123857"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.95287648),
        dec: Angle.Degrees(+06.52896135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14070"},
        {"Hipparcos Number", "HIP 10616"},
        {"Smithsonian Astrophysical Observation", "SAO 110445"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.16898990),
        dec: Angle.Degrees(+06.52941061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157278"},
        {"Hipparcos Number", "HIP 84974"},
        {"Smithsonian Astrophysical Observation", "SAO 122317"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.51138924),
        dec: Angle.Degrees(+06.52979886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102212"},
        {"Hipparcos Number", "HIP 57380"},
        {"Fundamental Katalog 5th Edition", "FK5 1302"},
        {"Geneva Identification System", "GEN# +1.00102212"},
        {"Smithsonian Astrophysical Observation", "SAO 119035"},
        {"Wilson Evans Batten Catalogue", "WEB 10313"},
    },
    visualMagnitude: 4.04,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.46487734),
        dec: Angle.Degrees(+06.52981394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46306",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7371 AB"},
        {"Henry Draper", "HD 81566"},
        {"Hipparcos Number", "HIP 46306"},
        {"Smithsonian Astrophysical Observation", "SAO 117695"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.64817631),
        dec: Angle.Degrees(+06.53042899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145289"},
        {"Hipparcos Number", "HIP 79218"},
        {"Smithsonian Astrophysical Observation", "SAO 121402"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.50947377),
        dec: Angle.Degrees(+06.53055098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2176"},
        {"Hipparcos Number", "HIP 2039"},
        {"Smithsonian Astrophysical Observation", "SAO 109198"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.46969267),
        dec: Angle.Degrees(+06.53144491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170135"},
        {"Hipparcos Number", "HIP 90472"},
        {"Geneva Identification System", "GEN# +2.66330092"},
        {"Smithsonian Astrophysical Observation", "SAO 123509"},
        {"New General Catalogue", "NGC 6633 92"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.91296052),
        dec: Angle.Degrees(+06.53215704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204908"},
        {"Hipparcos Number", "HIP 106279"},
        {"Geneva Identification System", "GEN# +1.00204908"},
        {"Smithsonian Astrophysical Observation", "SAO 126864"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.89272650),
        dec: Angle.Degrees(+06.53408820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245778"},
        {"Hipparcos Number", "HIP 26492"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.52240328),
        dec: Angle.Degrees(+06.53451831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24263"},
        {"Hipparcos Number", "HIP 18089"},
        {"Fundamental Katalog 5th Edition", "FK5 2275"},
        {"Geneva Identification System", "GEN# +1.00024263"},
        {"Smithsonian Astrophysical Observation", "SAO 111469"},
        {"Wilson Evans Batten Catalogue", "WEB 3490"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.00093529),
        dec: Angle.Degrees(+06.53491424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99343"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.45374417),
        dec: Angle.Degrees(+06.53546346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111529"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.93675120),
        dec: Angle.Degrees(+06.53558373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43338"},
        {"Hipparcos Number", "HIP 29758"},
        {"Geneva Identification System", "GEN# +1.00043338"},
        {"Smithsonian Astrophysical Observation", "SAO 113658"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.00415501),
        dec: Angle.Degrees(+06.53591501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10822"},
        {"Hipparcos Number", "HIP 8254"},
        {"Smithsonian Astrophysical Observation", "SAO 110117"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.55793181),
        dec: Angle.Degrees(+06.53615326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79747"},
        {"Hipparcos Number", "HIP 45471"},
        {"Smithsonian Astrophysical Observation", "SAO 117546"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.98472719),
        dec: Angle.Degrees(+06.54085120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169912"},
        {"Hipparcos Number", "HIP 90392"},
        {"Geneva Identification System", "GEN# +2.66330052"},
        {"New General Catalogue", "NGC 6633 52"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.65812462),
        dec: Angle.Degrees(+06.54130626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212367"},
        {"Hipparcos Number", "HIP 110531"},
        {"Smithsonian Astrophysical Observation", "SAO 127499"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.87877494),
        dec: Angle.Degrees(+06.54207496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89962"},
        {"Hipparcos Number", "HIP 50851"},
        {"Geneva Identification System", "GEN# +1.00089962"},
        {"Smithsonian Astrophysical Observation", "SAO 118269"},
        {"Wilson Evans Batten Catalogue", "WEB 9304"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.75190360),
        dec: Angle.Degrees(+06.54288350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203141"},
        {"Hipparcos Number", "HIP 105348"},
        {"Smithsonian Astrophysical Observation", "SAO 126712"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.07337622),
        dec: Angle.Degrees(+06.54313505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168606"},
        {"Hipparcos Number", "HIP 89875"},
        {"Geneva Identification System", "GEN# +1.00168606"},
        {"Smithsonian Astrophysical Observation", "SAO 123371"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.09564484),
        dec: Angle.Degrees(+06.54422480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69571"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.60621549),
        dec: Angle.Degrees(+06.54453983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70751"},
    },
    visualMagnitude: 11.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.04105846),
        dec: Angle.Degrees(+06.54553626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130146"},
        {"Hipparcos Number", "HIP 72230"},
        {"Smithsonian Astrophysical Observation", "SAO 120652"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.58025732),
        dec: Angle.Degrees(+06.54629202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147446"},
        {"Hipparcos Number", "HIP 80172"},
        {"Smithsonian Astrophysical Observation", "SAO 121538"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.48322164),
        dec: Angle.Degrees(+06.54647925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4488 AB"},
        {"Henry Draper", "HD 39591"},
        {"Hipparcos Number", "HIP 27869"},
        {"Smithsonian Astrophysical Observation", "SAO 113248"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.46214691),
        dec: Angle.Degrees(+06.54694212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12029 AB"},
        {"Henry Draper", "HD 177749"},
        {"Hipparcos Number", "HIP 93772"},
        {"Smithsonian Astrophysical Observation", "SAO 124257"},
        {"Wilson Evans Batten Catalogue", "WEB 16296"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.44874842),
        dec: Angle.Degrees(+06.54699563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75390"},
        {"Hipparcos Number", "HIP 43362"},
        {"Smithsonian Astrophysical Observation", "SAO 117175"},
        {"Wilson Evans Batten Catalogue", "WEB 8355"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.48945019),
        dec: Angle.Degrees(+06.54722275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119008"},
        {"Hipparcos Number", "HIP 66719"},
        {"Geneva Identification System", "GEN# +1.00119008"},
        {"Smithsonian Astrophysical Observation", "SAO 120061"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.14702675),
        dec: Angle.Degrees(+06.54803032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51506"},
        {"Hipparcos Number", "HIP 33509"},
        {"Geneva Identification System", "GEN# +1.00051506"},
        {"Smithsonian Astrophysical Observation", "SAO 114689"},
        {"Wilson Evans Batten Catalogue", "WEB 6738"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.48329158),
        dec: Angle.Degrees(+06.54914736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212769"},
        {"Hipparcos Number", "HIP 110782"},
        {"Smithsonian Astrophysical Observation", "SAO 127530"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.65071295),
        dec: Angle.Degrees(+06.55039750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156893"},
        {"Hipparcos Number", "HIP 84781"},
        {"Cincinnati Publication", "Ci 18 2309"},
        {"Geneva Identification System", "GEN# +1.00156893"},
        {"Smithsonian Astrophysical Observation", "SAO 122281"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.94394441),
        dec: Angle.Degrees(+06.55351048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36839"},
        {"Hipparcos Number", "HIP 26170"},
        {"Smithsonian Astrophysical Observation", "SAO 112913"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.69045461),
        dec: Angle.Degrees(+06.55379491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164257"},
        {"Hipparcos Number", "HIP 88132"},
        {"Smithsonian Astrophysical Observation", "SAO 123001"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.03048362),
        dec: Angle.Degrees(+06.55393792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114294"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21848141),
        dec: Angle.Degrees(+06.56121108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215706"},
        {"Hipparcos Number", "HIP 112481"},
        {"Smithsonian Astrophysical Observation", "SAO 127757"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.75596869),
        dec: Angle.Degrees(+06.56223675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160558"},
        {"Hipparcos Number", "HIP 86483"},
        {"Smithsonian Astrophysical Observation", "SAO 122630"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.08330769),
        dec: Angle.Degrees(+06.56465703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73764"},
        {"Hipparcos Number", "HIP 42528"},
        {"Smithsonian Astrophysical Observation", "SAO 117006"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.05560467),
        dec: Angle.Degrees(+06.56553392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9511"},
        {"Hipparcos Number", "HIP 7259"},
        {"Smithsonian Astrophysical Observation", "SAO 109970"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.38637922),
        dec: Angle.Degrees(+06.56664823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4078"},
        {"Hipparcos Number", "HIP 3393"},
        {"Smithsonian Astrophysical Observation", "SAO 109405"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.81813702),
        dec: Angle.Degrees(+06.56974771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99950"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.19386833),
        dec: Angle.Degrees(+06.57097442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75160"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.39139621),
        dec: Angle.Degrees(+06.57117508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107417"},
        {"Hipparcos Number", "HIP 60220"},
        {"Smithsonian Astrophysical Observation", "SAO 119343"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.23130083),
        dec: Angle.Degrees(+06.57191849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8068 A"},
        {"Henry Draper", "HD 96658"},
        {"Hipparcos Number", "HIP 54423"},
        {"Smithsonian Astrophysical Observation", "SAO 118678"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.05642938),
        dec: Angle.Degrees(+06.57353091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121713"},
        {"Hipparcos Number", "HIP 68137"},
        {"Smithsonian Astrophysical Observation", "SAO 120191"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.24810012),
        dec: Angle.Degrees(+06.57468475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75190"},
        {"Hipparcos Number", "HIP 43255"},
        {"Smithsonian Astrophysical Observation", "SAO 117152"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.17406169),
        dec: Angle.Degrees(+06.57588377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192343"},
        {"Hipparcos Number", "HIP 99727"},
        {"Geneva Identification System", "GEN# +1.00192343"},
        {"Smithsonian Astrophysical Observation", "SAO 125595"},
        {"Wilson Evans Batten Catalogue", "WEB 17894"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.53856223),
        dec: Angle.Degrees(+06.57735961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197447"},
        {"Hipparcos Number", "HIP 102297"},
        {"Smithsonian Astrophysical Observation", "SAO 126140"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.91245652),
        dec: Angle.Degrees(+06.57821376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1095",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 167 AB"},
        {"Henry Draper", "HD 921"},
        {"Hipparcos Number", "HIP 1095"},
        {"Smithsonian Astrophysical Observation", "SAO 109075"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.41861197),
        dec: Angle.Degrees(+06.58042142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204603"},
        {"Hipparcos Number", "HIP 106103"},
        {"Smithsonian Astrophysical Observation", "SAO 126834"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.39372478),
        dec: Angle.Degrees(+06.58138694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59227"},
        {"Hipparcos Number", "HIP 36389"},
        {"Geneva Identification System", "GEN# +1.00059227"},
        {"Smithsonian Astrophysical Observation", "SAO 115513"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32856320),
        dec: Angle.Degrees(+06.58209095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153653"},
        {"Hipparcos Number", "HIP 83223"},
        {"Fundamental Katalog 5th Edition", "FK5 3352"},
        {"Geneva Identification System", "GEN# +1.00153653"},
        {"Smithsonian Astrophysical Observation", "SAO 121995"},
        {"Wilson Evans Batten Catalogue", "WEB 14068"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.12240034),
        dec: Angle.Degrees(+06.58381251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23320"},
        {"Smithsonian Astrophysical Observation", "SAO 112312"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.23042665),
        dec: Angle.Degrees(+06.58465074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98947"},
        {"Hipparcos Number", "HIP 55589"},
        {"Fundamental Katalog 5th Edition", "FK5 5002"},
        {"Geneva Identification System", "GEN# +1.00098947"},
        {"Smithsonian Astrophysical Observation", "SAO 118823"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.81314960),
        dec: Angle.Degrees(+06.58584916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9648"},
        {"Hipparcos Number", "HIP 7352"},
        {"Geneva Identification System", "GEN# +1.00009648"},
        {"Smithsonian Astrophysical Observation", "SAO 109988"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.69227143),
        dec: Angle.Degrees(+06.58640513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114891"},
        {"Geneva Identification System", "GEN# +0.00505152"},
        {"Smithsonian Astrophysical Observation", "SAO 128073"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.08134175),
        dec: Angle.Degrees(+06.58900116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192344"},
        {"Hipparcos Number", "HIP 99729"},
        {"Cincinnati Publication", "Ci 18 2642"},
        {"Geneva Identification System", "GEN# +1.00192344"},
        {"Smithsonian Astrophysical Observation", "SAO 125597"},
        {"Wilson Evans Batten Catalogue", "WEB 17895"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.54103840),
        dec: Angle.Degrees(+06.58912020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66120"},
        {"Hipparcos Number", "HIP 39322"},
        {"Geneva Identification System", "GEN# +1.00066120"},
        {"Smithsonian Astrophysical Observation", "SAO 116261"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.59325951),
        dec: Angle.Degrees(+06.59037042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211985"},
        {"Hipparcos Number", "HIP 110349"},
        {"Smithsonian Astrophysical Observation", "SAO 127462"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25241562),
        dec: Angle.Degrees(+06.59093038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189259"},
        {"Hipparcos Number", "HIP 98348"},
        {"Geneva Identification System", "GEN# +1.00189259"},
        {"Smithsonian Astrophysical Observation", "SAO 125302"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.72713011),
        dec: Angle.Degrees(+06.59122651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221973"},
        {"Hipparcos Number", "HIP 116511"},
        {"Smithsonian Astrophysical Observation", "SAO 128282"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.14952167),
        dec: Angle.Degrees(+06.59156704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138832"},
        {"Hipparcos Number", "HIP 76240"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.59980057),
        dec: Angle.Degrees(+06.59206568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7217"},
        {"Hipparcos Number", "HIP 5655"},
        {"Smithsonian Astrophysical Observation", "SAO 109729"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.16272822),
        dec: Angle.Degrees(+06.59354306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65516"},
        {"Smithsonian Astrophysical Observation", "SAO 119921"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.44899196),
        dec: Angle.Degrees(+06.59399098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180504"},
        {"Hipparcos Number", "HIP 94733"},
        {"Smithsonian Astrophysical Observation", "SAO 124457"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.14451130),
        dec: Angle.Degrees(+06.59668984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174766"},
        {"Hipparcos Number", "HIP 92588"},
        {"Geneva Identification System", "GEN# +1.00174766"},
        {"Smithsonian Astrophysical Observation", "SAO 123990"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.99772449),
        dec: Angle.Degrees(+06.59868949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51522"},
        {"Smithsonian Astrophysical Observation", "SAO 118346"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.84260255),
        dec: Angle.Degrees(+06.59959672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114207",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16523 C"},
        {"Hipparcos Number", "HIP 114207"},
        {"Smithsonian Astrophysical Observation", "SAO 127981"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.92813889),
        dec: Angle.Degrees(+06.59967738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19701"},
        {"Geneva Identification System", "GEN# +0.00600648"},
        {"Smithsonian Astrophysical Observation", "SAO 111667"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.30456255),
        dec: Angle.Degrees(+06.60058458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8500 AB"},
        {"Henry Draper", "HD 106877"},
        {"Hipparcos Number", "HIP 59916"},
        {"Geneva Identification System", "GEN# +1.00106877J"},
        {"Smithsonian Astrophysical Observation", "SAO 119308"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.36243755),
        dec: Angle.Degrees(+06.60118573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14819"},
        {"Hipparcos Number", "HIP 11151"},
        {"Smithsonian Astrophysical Observation", "SAO 110508"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.86072039),
        dec: Angle.Degrees(+06.60178529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151556"},
        {"Hipparcos Number", "HIP 82225"},
        {"Geneva Identification System", "GEN# +1.00151556"},
        {"Smithsonian Astrophysical Observation", "SAO 121867"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.96230309),
        dec: Angle.Degrees(+06.60364858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153402"},
        {"Hipparcos Number", "HIP 83120"},
        {"Smithsonian Astrophysical Observation", "SAO 121976"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.79204554),
        dec: Angle.Degrees(+06.60406775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12087"},
        {"Geneva Identification System", "GEN# +0.00500364"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.94820330),
        dec: Angle.Degrees(+06.60427191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 302.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107587"},
        {"Geneva Identification System", "GEN# +0.00504868"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.86000985),
        dec: Angle.Degrees(+06.60460285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132425"},
        {"Hipparcos Number", "HIP 73314"},
        {"Smithsonian Astrophysical Observation", "SAO 120771"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.73045030),
        dec: Angle.Degrees(+06.60460414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16523 A"},
        {"Henry Draper", "HD 218408"},
        {"Hipparcos Number", "HIP 114209"},
        {"Smithsonian Astrophysical Observation", "SAO 127982"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.93060085),
        dec: Angle.Degrees(+06.60476050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218951"},
        {"Hipparcos Number", "HIP 114548"},
        {"Smithsonian Astrophysical Observation", "SAO 128028"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.04679126),
        dec: Angle.Degrees(+06.60554057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50082"},
        {"Hipparcos Number", "HIP 32960"},
        {"Geneva Identification System", "GEN# +1.00050082"},
        {"Smithsonian Astrophysical Observation", "SAO 114534"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.97479482),
        dec: Angle.Degrees(+06.60679953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153869"},
        {"Hipparcos Number", "HIP 83322"},
        {"Smithsonian Astrophysical Observation", "SAO 122019"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.44519767),
        dec: Angle.Degrees(+06.60993530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149199"},
        {"Hipparcos Number", "HIP 81033"},
        {"Geneva Identification System", "GEN# +1.00149199"},
        {"Smithsonian Astrophysical Observation", "SAO 121685"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.25264794),
        dec: Angle.Degrees(+06.61137484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216278"},
        {"Hipparcos Number", "HIP 112877"},
        {"Smithsonian Astrophysical Observation", "SAO 127802"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.87520543),
        dec: Angle.Degrees(+06.61159886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28238"},
        {"Hipparcos Number", "HIP 20816"},
        {"Renson", "Renson 7210"},
        {"Smithsonian Astrophysical Observation", "SAO 111833"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.89984824),
        dec: Angle.Degrees(+06.61200967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104321"},
        {"Hipparcos Number", "HIP 58590"},
        {"Fundamental Katalog 5th Edition", "FK5 1311"},
        {"Geneva Identification System", "GEN# +1.00104321"},
        {"Renson", "Renson 30187"},
        {"Smithsonian Astrophysical Observation", "SAO 119164"},
        {"Wilson Evans Batten Catalogue", "WEB 10455"},
    },
    visualMagnitude: 4.65,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.21829289),
        dec: Angle.Degrees(+06.61439464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175515"},
        {"Hipparcos Number", "HIP 92872"},
        {"Fundamental Katalog 5th Edition", "FK5 3509"},
        {"Geneva Identification System", "GEN# +1.00175515"},
        {"Smithsonian Astrophysical Observation", "SAO 124050"},
        {"Wilson Evans Batten Catalogue", "WEB 16081"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.86434313),
        dec: Angle.Degrees(+06.61550576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114539"},
        {"Hipparcos Number", "HIP 64330"},
        {"Smithsonian Astrophysical Observation", "SAO 119803"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.78180805),
        dec: Angle.Degrees(+06.61571227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217926"},
        {"Hipparcos Number", "HIP 113904"},
        {"Geneva Identification System", "GEN# +1.00217926"},
        {"Smithsonian Astrophysical Observation", "SAO 127937"},
        {"Wilson Evans Batten Catalogue", "WEB 20231"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.00331290),
        dec: Angle.Degrees(+06.61632017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 377"},
        {"Hipparcos Number", "HIP 682"},
        {"Geneva Identification System", "GEN# +1.00000377"},
        {"Smithsonian Astrophysical Observation", "SAO 109027"},
        {"Wilson Evans Batten Catalogue", "WEB 114"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.10705914),
        dec: Angle.Degrees(+06.61680730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91098"},
        {"Hipparcos Number", "HIP 51505"},
        {"Smithsonian Astrophysical Observation", "SAO 118345"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.77714233),
        dec: Angle.Degrees(+06.61820600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15147 A"},
        {"Henry Draper", "HD 205811"},
        {"Hipparcos Number", "HIP 106783"},
        {"Geneva Identification System", "GEN# +1.00205811A"},
        {"Smithsonian Astrophysical Observation", "SAO 126940"},
        {"Wilson Evans Batten Catalogue", "WEB 19304"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.43171388),
        dec: Angle.Degrees(+06.61839615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150891"},
        {"Hipparcos Number", "HIP 81890"},
        {"Geneva Identification System", "GEN# +1.00150891"},
        {"Smithsonian Astrophysical Observation", "SAO 121816"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.91173730),
        dec: Angle.Degrees(+06.61858305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9238"},
        {"Hipparcos Number", "HIP 7069"},
        {"Smithsonian Astrophysical Observation", "SAO 109940"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.77705021),
        dec: Angle.Degrees(+06.61942598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42172",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6886 A"},
        {"Henry Draper", "HD 72945"},
        {"Hipparcos Number", "HIP 42172"},
        {"Geneva Identification System", "GEN# +1.00072945A"},
        {"Smithsonian Astrophysical Observation", "SAO 116929"},
        {"Wilson Evans Batten Catalogue", "WEB 8105"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96272402),
        dec: Angle.Degrees(+06.62053814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24053"},
        {"Henry Draper 2", "HD 24053A"},
        {"Hipparcos Number", "HIP 17936"},
        {"Geneva Identification System", "GEN# +1.00024053"},
        {"Smithsonian Astrophysical Observation", "SAO 111446"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.53688447),
        dec: Angle.Degrees(+06.62078655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55975"},
        {"Hipparcos Number", "HIP 35103"},
        {"Smithsonian Astrophysical Observation", "SAO 115155"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87869391),
        dec: Angle.Degrees(+06.62093398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194154"},
        {"Hipparcos Number", "HIP 100581"},
        {"Geneva Identification System", "GEN# +1.00194154"},
        {"Smithsonian Astrophysical Observation", "SAO 125759"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.95208299),
        dec: Angle.Degrees(+06.62285484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6886 B"},
        {"Henry Draper", "HD 72946"},
        {"Hipparcos Number", "HIP 42173"},
        {"Geneva Identification System", "GEN# +1.00072946"},
        {"Smithsonian Astrophysical Observation", "SAO 116931"},
        {"Wilson Evans Batten Catalogue", "WEB 8106"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96392686),
        dec: Angle.Degrees(+06.62309980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61664"},
        {"Hipparcos Number", "HIP 37398"},
        {"Geneva Identification System", "GEN# +1.00061664"},
        {"Smithsonian Astrophysical Observation", "SAO 115786"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.17283155),
        dec: Angle.Degrees(+06.62425689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91030"},
        {"Hipparcos Number", "HIP 51458"},
        {"Smithsonian Astrophysical Observation", "SAO 118342"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.65089108),
        dec: Angle.Degrees(+06.62577105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40757"},
        {"Hipparcos Number", "HIP 28522"},
        {"Smithsonian Astrophysical Observation", "SAO 113368"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.31161229),
        dec: Angle.Degrees(+06.62602349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1729 AB"},
        {"Henry Draper", "HD 13959"},
        {"Hipparcos Number", "HIP 10552"},
        {"Geneva Identification System", "GEN# +1.00013959J"},
        {"Smithsonian Astrophysical Observation", "SAO 110435"},
        {"Wilson Evans Batten Catalogue", "WEB 2218"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.97279846),
        dec: Angle.Degrees(+06.62646403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15147 B"},
        {"Henry Draper", "HD 205811B"},
        {"Hipparcos Number", "HIP 106781"},
        {"Geneva Identification System", "GEN# +1.00205811B"},
        {"Geneva Identification System 2", "GEN# +1.20205811"},
        {"Geneva Identification System 3", "GEN# +0.00504829"},
        {"Smithsonian Astrophysical Observation", "SAO 126939"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42951284),
        dec: Angle.Degrees(+06.62904329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60547"},
        {"Smithsonian Astrophysical Observation", "SAO 119383"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.17776713),
        dec: Angle.Degrees(+06.63099849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18856"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.63686993),
        dec: Angle.Degrees(+06.63115012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21810"},
        {"Smithsonian Astrophysical Observation", "SAO 111976"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.27539602),
        dec: Angle.Degrees(+06.63133128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98697"},
        {"Hipparcos Number", "HIP 55455"},
        {"Geneva Identification System", "GEN# +1.00098697"},
        {"Smithsonian Astrophysical Observation", "SAO 118806"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.36234197),
        dec: Angle.Degrees(+06.63495737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -290.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23389"},
        {"Hipparcos Number", "HIP 17520"},
        {"Smithsonian Astrophysical Observation", "SAO 111391"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.26154487),
        dec: Angle.Degrees(+06.63662960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32483"},
        {"Hipparcos Number", "HIP 23542"},
        {"Smithsonian Astrophysical Observation", "SAO 112370"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.94000917),
        dec: Angle.Degrees(+06.64040581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194453"},
        {"Hipparcos Number", "HIP 100734"},
        {"Smithsonian Astrophysical Observation", "SAO 125791"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.35593936),
        dec: Angle.Degrees(+06.64181321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107317"},
        {"Geneva Identification System", "GEN# +9.80093033"},
    },
    visualMagnitude: 12.06,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.05491855),
        dec: Angle.Degrees(+06.64186705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -326.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211229"},
        {"Hipparcos Number", "HIP 109898"},
        {"Geneva Identification System", "GEN# +1.00211229"},
        {"Smithsonian Astrophysical Observation", "SAO 127413"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.89144956),
        dec: Angle.Degrees(+06.64242837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16541"},
        {"Smithsonian Astrophysical Observation", "SAO 111250"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.25054687),
        dec: Angle.Degrees(+06.64303569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70909"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.51149105),
        dec: Angle.Degrees(+06.64438729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145070"},
        {"Hipparcos Number", "HIP 79103"},
        {"Smithsonian Astrophysical Observation", "SAO 121388"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.19714438),
        dec: Angle.Degrees(+06.64611415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37089"},
        {"Hipparcos Number", "HIP 26313"},
        {"Smithsonian Astrophysical Observation", "SAO 112948"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.06041504),
        dec: Angle.Degrees(+06.64619177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13509"},
        {"Hipparcos Number", "HIP 10261"},
        {"Smithsonian Astrophysical Observation", "SAO 110400"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.00660651),
        dec: Angle.Degrees(+06.64715071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13803"},
        {"Hipparcos Number", "HIP 10442"},
        {"Smithsonian Astrophysical Observation", "SAO 110422"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.63538992),
        dec: Angle.Degrees(+06.65107220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179739"},
        {"Hipparcos Number", "HIP 94456"},
        {"Smithsonian Astrophysical Observation", "SAO 124405"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.37762559),
        dec: Angle.Degrees(+06.65154007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2261 AB"},
        {"Henry Draper", "HD 18570"},
        {"Hipparcos Number", "HIP 13923"},
        {"Smithsonian Astrophysical Observation", "SAO 110883"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.84352788),
        dec: Angle.Degrees(+06.65220186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53296"},
        {"Hipparcos Number", "HIP 34144"},
        {"Smithsonian Astrophysical Observation", "SAO 114878"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.20127141),
        dec: Angle.Degrees(+06.65576549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173452"},
        {"Hipparcos Number", "HIP 92002"},
        {"Smithsonian Astrophysical Observation", "SAO 123883"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.28199886),
        dec: Angle.Degrees(+06.65628805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173985"},
        {"Hipparcos Number", "HIP 92255"},
        {"Smithsonian Astrophysical Observation", "SAO 123930"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.01198037),
        dec: Angle.Degrees(+06.65842447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16050"},
        {"Smithsonian Astrophysical Observation", "SAO 111193"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.67963859),
        dec: Angle.Degrees(+06.65979516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19927"},
        {"Henry Draper 2", "HD 19926"},
        {"Hipparcos Number", "HIP 14915"},
        {"Fundamental Katalog 5th Edition", "FK5 2226"},
        {"Geneva Identification System", "GEN# +1.00019926"},
        {"Smithsonian Astrophysical Observation", "SAO 111044"},
        {"Wilson Evans Batten Catalogue", "WEB 2881"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10987466),
        dec: Angle.Degrees(+06.66088598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59296"},
        {"Hipparcos Number", "HIP 36417"},
        {"Smithsonian Astrophysical Observation", "SAO 115516"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.38530642),
        dec: Angle.Degrees(+06.66128612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21996"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.92100217),
        dec: Angle.Degrees(+06.66223444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17154 AB"},
        {"Henry Draper", "HD 224660"},
        {"Hipparcos Number", "HIP 118310"},
        {"Smithsonian Astrophysical Observation", "SAO 128518"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.94925671),
        dec: Angle.Degrees(+06.66456539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147369"},
        {"Hipparcos Number", "HIP 80134"},
        {"Smithsonian Astrophysical Observation", "SAO 121527"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.34744266),
        dec: Angle.Degrees(+06.66527516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6572"},
        {"Hipparcos Number", "HIP 5218"},
        {"Smithsonian Astrophysical Observation", "SAO 109680"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.68216137),
        dec: Angle.Degrees(+06.66678534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88486"},
        {"Hipparcos Number", "HIP 49999"},
        {"Geneva Identification System", "GEN# +1.00088486"},
        {"Smithsonian Astrophysical Observation", "SAO 118158"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.11204125),
        dec: Angle.Degrees(+06.66678720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1771"},
        {"Geneva Identification System", "GEN# +0.00500043"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.60455120),
        dec: Angle.Degrees(+06.66810871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55124"},
        {"Smithsonian Astrophysical Observation", "SAO 118763"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.29075941),
        dec: Angle.Degrees(+06.66897434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92718"},
        {"Hipparcos Number", "HIP 52389"},
        {"Smithsonian Astrophysical Observation", "SAO 118442"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.62596615),
        dec: Angle.Degrees(+06.66992174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11496 A"},
        {"Henry Draper", "HD 171834"},
        {"Hipparcos Number", "HIP 91237"},
        {"Geneva Identification System", "GEN# +1.00171834"},
        {"Smithsonian Astrophysical Observation", "SAO 123693"},
        {"Wilson Evans Batten Catalogue", "WEB 15673"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.16288632),
        dec: Angle.Degrees(+06.67215598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150192"},
        {"Hipparcos Number", "HIP 81531"},
        {"Smithsonian Astrophysical Observation", "SAO 121760"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.79173019),
        dec: Angle.Degrees(+06.67329361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12102"},
        {"Hipparcos Number", "HIP 9253"},
        {"Smithsonian Astrophysical Observation", "SAO 110253"},
        {"Wilson Evans Batten Catalogue", "WEB 1943"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.73524115),
        dec: Angle.Degrees(+06.67412409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82696"},
        {"Smithsonian Astrophysical Observation", "SAO 121934"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.56029627),
        dec: Angle.Degrees(+06.67506900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183538"},
        {"Hipparcos Number", "HIP 95870"},
        {"Smithsonian Astrophysical Observation", "SAO 124694"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48099510),
        dec: Angle.Degrees(+06.67570375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12825"},
        {"Hipparcos Number", "HIP 9790"},
        {"Geneva Identification System", "GEN# +1.00012825"},
        {"Smithsonian Astrophysical Observation", "SAO 110334"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.47915382),
        dec: Angle.Degrees(+06.67752722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89365"},
        {"Hipparcos Number", "HIP 50501"},
        {"Smithsonian Astrophysical Observation", "SAO 118214"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.68690681),
        dec: Angle.Degrees(+06.67766340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99205"},
        {"Geneva Identification System", "GEN# +0.00604450"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.10111045),
        dec: Angle.Degrees(+06.67832582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105868"},
        {"Hipparcos Number", "HIP 59401"},
        {"Smithsonian Astrophysical Observation", "SAO 119257"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.78343641),
        dec: Angle.Degrees(+06.67867877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184025"},
        {"Hipparcos Number", "HIP 96093"},
        {"Geneva Identification System", "GEN# +1.00184025"},
        {"Smithsonian Astrophysical Observation", "SAO 124746"},
        {"Wilson Evans Batten Catalogue", "WEB 16830"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.05542083),
        dec: Angle.Degrees(+06.68095333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56446"},
        {"Hipparcos Number", "HIP 35278"},
        {"Geneva Identification System", "GEN# +1.00056446"},
        {"Smithsonian Astrophysical Observation", "SAO 115204"},
        {"Wilson Evans Batten Catalogue", "WEB 7043"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.32416101),
        dec: Angle.Degrees(+06.68099495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146011"},
        {"Hipparcos Number", "HIP 79536"},
        {"Smithsonian Astrophysical Observation", "SAO 121436"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.45473546),
        dec: Angle.Degrees(+06.68229946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47239"},
        {"Hipparcos Number", "HIP 31694"},
        {"Smithsonian Astrophysical Observation", "SAO 114159"},
        {"Wilson Evans Batten Catalogue", "WEB 6356"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.46454977),
        dec: Angle.Degrees(+06.68327136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50557"},
        {"Hipparcos Number", "HIP 33147"},
        {"Geneva Identification System", "GEN# +1.00050557"},
        {"Smithsonian Astrophysical Observation", "SAO 114580"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.52523012),
        dec: Angle.Degrees(+06.68774914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50581"},
        {"Hipparcos Number", "HIP 33167"},
        {"Smithsonian Astrophysical Observation", "SAO 114586"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.55765727),
        dec: Angle.Degrees(+06.68800574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80821"},
        {"Hipparcos Number", "HIP 45943"},
        {"Smithsonian Astrophysical Observation", "SAO 117623"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.53730531),
        dec: Angle.Degrees(+06.68925472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127520"},
        {"Hipparcos Number", "HIP 71052"},
        {"Smithsonian Astrophysical Observation", "SAO 120514"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95740935),
        dec: Angle.Degrees(+06.69318739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108905"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.90586406),
        dec: Angle.Degrees(+06.69334585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46557"},
        {"Hipparcos Number", "HIP 31347"},
        {"Celescope Catalog", "CEL 1301"},
        {"Geneva Identification System", "GEN# +1.00046557"},
        {"Smithsonian Astrophysical Observation", "SAO 114071"},
        {"Wilson Evans Batten Catalogue", "WEB 6269"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.59433021),
        dec: Angle.Degrees(+06.69516610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13037"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.88375456),
        dec: Angle.Degrees(+06.69529059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -351.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96419"},
        {"Hipparcos Number", "HIP 54331"},
        {"Smithsonian Astrophysical Observation", "SAO 118667"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.71587300),
        dec: Angle.Degrees(+06.69819695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64190"},
        {"Hipparcos Number", "HIP 38491"},
        {"Geneva Identification System", "GEN# +1.00064190"},
        {"Smithsonian Astrophysical Observation", "SAO 116071"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.24585311),
        dec: Angle.Degrees(+06.69834021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223853"},
        {"Hipparcos Number", "HIP 117781"},
        {"Smithsonian Astrophysical Observation", "SAO 128440"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.28398346),
        dec: Angle.Degrees(+06.69900201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75566"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.56135911),
        dec: Angle.Degrees(+06.70004759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71557"},
        {"Hipparcos Number", "HIP 41550"},
        {"Smithsonian Astrophysical Observation", "SAO 116797"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.08855944),
        dec: Angle.Degrees(+06.70071094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165741"},
        {"Hipparcos Number", "HIP 88764"},
        {"Smithsonian Astrophysical Observation", "SAO 123139"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.82114942),
        dec: Angle.Degrees(+06.70165328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117177"},
        {"Hipparcos Number", "HIP 65736"},
        {"Smithsonian Astrophysical Observation", "SAO 119945"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11912288),
        dec: Angle.Degrees(+06.70237760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213805"},
        {"Hipparcos Number", "HIP 111388"},
        {"Smithsonian Astrophysical Observation", "SAO 127606"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.49592390),
        dec: Angle.Degrees(+06.70320221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14244"},
        {"Hipparcos Number", "HIP 10747"},
        {"Smithsonian Astrophysical Observation", "SAO 110458"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.56862826),
        dec: Angle.Degrees(+06.70376458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19638"},
        {"Hipparcos Number", "HIP 14702"},
        {"Geneva Identification System", "GEN# +1.00019638"},
        {"Smithsonian Astrophysical Observation", "SAO 111017"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.48469841),
        dec: Angle.Degrees(+06.70496098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84542"},
        {"Hipparcos Number", "HIP 47943"},
        {"Fundamental Katalog 5th Edition", "FK5 2781"},
        {"Geneva Identification System", "GEN# +1.00084542"},
        {"Smithsonian Astrophysical Observation", "SAO 117898"},
        {"Wilson Evans Batten Catalogue", "WEB 8966"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.54183697),
        dec: Angle.Degrees(+06.70861426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24779"},
        {"Hipparcos Number", "HIP 18449"},
        {"Geneva Identification System", "GEN# +1.00024779"},
        {"Smithsonian Astrophysical Observation", "SAO 111512"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.15022304),
        dec: Angle.Degrees(+06.71069689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58431"},
        {"Hipparcos Number", "HIP 36059"},
        {"Geneva Identification System", "GEN# +1.00058431"},
        {"Smithsonian Astrophysical Observation", "SAO 115432"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.47097582),
        dec: Angle.Degrees(+06.71332863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91419"},
    },
    visualMagnitude: 11.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.66924231),
        dec: Angle.Degrees(+06.71390923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151702"},
        {"Hipparcos Number", "HIP 82282"},
        {"Smithsonian Astrophysical Observation", "SAO 121876"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.19104516),
        dec: Angle.Degrees(+06.71661424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15771"},
        {"Hipparcos Number", "HIP 11798"},
        {"Smithsonian Astrophysical Observation", "SAO 110596"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.05071344),
        dec: Angle.Degrees(+06.71734449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209008"},
        {"Hipparcos Number", "HIP 108612"},
        {"Fundamental Katalog 5th Edition", "FK5 3759"},
        {"Geneva Identification System", "GEN# +1.00209008"},
        {"Smithsonian Astrophysical Observation", "SAO 127219"},
        {"Wilson Evans Batten Catalogue", "WEB 19543"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.03299605),
        dec: Angle.Degrees(+06.71743570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87996"},
        {"Hipparcos Number", "HIP 49704"},
        {"Geneva Identification System", "GEN# +1.00087996"},
        {"Smithsonian Astrophysical Observation", "SAO 118132"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.20138843),
        dec: Angle.Degrees(+06.71756134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140368"},
        {"Hipparcos Number", "HIP 76965"},
        {"Smithsonian Astrophysical Observation", "SAO 121147"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.73779145),
        dec: Angle.Degrees(+06.71763422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9882"},
        {"Hipparcos Number", "HIP 7502"},
        {"Smithsonian Astrophysical Observation", "SAO 110009"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.17193070),
        dec: Angle.Degrees(+06.71807958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26425"},
        {"Hipparcos Number", "HIP 19538"},
        {"Geneva Identification System", "GEN# +1.00026425"},
        {"Smithsonian Astrophysical Observation", "SAO 111645"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.77469821),
        dec: Angle.Degrees(+06.71856635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104397"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.24193933),
        dec: Angle.Degrees(+06.72180303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19511"},
        {"Hipparcos Number", "HIP 14590"},
        {"Geneva Identification System", "GEN# +1.00019511"},
        {"Smithsonian Astrophysical Observation", "SAO 110999"},
        {"Wilson Evans Batten Catalogue", "WEB 2837"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.10356361),
        dec: Angle.Degrees(+06.72340657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201364"},
        {"Hipparcos Number", "HIP 104399"},
        {"Smithsonian Astrophysical Observation", "SAO 126576"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.24849969),
        dec: Angle.Degrees(+06.72346067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50725"},
        {"Hipparcos Number", "HIP 33206"},
        {"Smithsonian Astrophysical Observation", "SAO 114596"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.66720340),
        dec: Angle.Degrees(+06.72406136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11310"},
        {"Hipparcos Number", "HIP 8617"},
        {"Smithsonian Astrophysical Observation", "SAO 110169"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.78542689),
        dec: Angle.Degrees(+06.72514386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26256"},
        {"Hipparcos Number", "HIP 19411"},
        {"Smithsonian Astrophysical Observation", "SAO 111631"},
        {"Wilson Evans Batten Catalogue", "WEB 3730"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.36336613),
        dec: Angle.Degrees(+06.72518832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68515"},
        {"Smithsonian Astrophysical Observation", "SAO 120237"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.39533166),
        dec: Angle.Degrees(+06.72546200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43856"},
        {"Hipparcos Number", "HIP 29991"},
        {"Geneva Identification System", "GEN# +1.00043856"},
        {"Smithsonian Astrophysical Observation", "SAO 113712"},
        {"Wilson Evans Batten Catalogue", "WEB 5951"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.70135441),
        dec: Angle.Degrees(+06.72560923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101856"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.60177220),
        dec: Angle.Degrees(+06.72562694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104636"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.92609165),
        dec: Angle.Degrees(+06.72780598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73229"},
        {"Hipparcos Number", "HIP 42308"},
        {"Smithsonian Astrophysical Observation", "SAO 116962"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.38546635),
        dec: Angle.Degrees(+06.72828627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162691"},
        {"Hipparcos Number", "HIP 87435"},
        {"Geneva Identification System", "GEN# +1.00162691"},
        {"Smithsonian Astrophysical Observation", "SAO 122850"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00359822),
        dec: Angle.Degrees(+06.72964143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63650"},
        {"Hipparcos Number", "HIP 38260"},
        {"Smithsonian Astrophysical Observation", "SAO 116002"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.57390101),
        dec: Angle.Degrees(+06.73044737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41641"},
        {"Hipparcos Number", "HIP 28955"},
        {"Geneva Identification System", "GEN# +1.00041641"},
        {"Smithsonian Astrophysical Observation", "SAO 113456"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.66907370),
        dec: Angle.Degrees(+06.73051876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190343"},
        {"Hipparcos Number", "HIP 98840"},
        {"Smithsonian Astrophysical Observation", "SAO 125408"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.08032220),
        dec: Angle.Degrees(+06.73264719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90663"},
        {"Hipparcos Number", "HIP 51254"},
        {"Geneva Identification System", "GEN# +1.00090663"},
        {"Smithsonian Astrophysical Observation", "SAO 118321"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.04345320),
        dec: Angle.Degrees(+06.73433015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 326.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215309"},
        {"Hipparcos Number", "HIP 112240"},
        {"Geneva Identification System", "GEN# +1.00215309"},
        {"Smithsonian Astrophysical Observation", "SAO 127717"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02066379),
        dec: Angle.Degrees(+06.73650710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22723"},
        {"Hipparcos Number", "HIP 17066"},
        {"Smithsonian Astrophysical Observation", "SAO 111328"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.86887672),
        dec: Angle.Degrees(+06.73660449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8404"},
        {"Hipparcos Number", "HIP 6490"},
        {"Smithsonian Astrophysical Observation", "SAO 109850"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.84840103),
        dec: Angle.Degrees(+06.74088391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4526"},
        {"Hipparcos Number", "HIP 3697"},
        {"Geneva Identification System", "GEN# +1.00004526"},
        {"Smithsonian Astrophysical Observation", "SAO 109461"},
        {"Wilson Evans Batten Catalogue", "WEB 657"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.84843074),
        dec: Angle.Degrees(+06.74098135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93718"},
        {"Hipparcos Number", "HIP 52917"},
        {"Geneva Identification System", "GEN# +1.00093718"},
        {"Smithsonian Astrophysical Observation", "SAO 118517"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.34230296),
        dec: Angle.Degrees(+06.74103379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160911"},
        {"Hipparcos Number", "HIP 86649"},
        {"Smithsonian Astrophysical Observation", "SAO 122655"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.56627744),
        dec: Angle.Degrees(+06.74275356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34536"},
        {"Hipparcos Number", "HIP 24753"},
        {"Smithsonian Astrophysical Observation", "SAO 112609"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.61609019),
        dec: Angle.Degrees(+06.74656411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204925"},
        {"Hipparcos Number", "HIP 106295"},
        {"Geneva Identification System", "GEN# +1.00204925"},
        {"Smithsonian Astrophysical Observation", "SAO 126867"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.92929567),
        dec: Angle.Degrees(+06.75042506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89365"},
        {"Smithsonian Astrophysical Observation", "SAO 123278"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.54456088),
        dec: Angle.Degrees(+06.75056681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7004"},
        {"Hipparcos Number", "HIP 5511"},
        {"Smithsonian Astrophysical Observation", "SAO 109714"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.64314001),
        dec: Angle.Degrees(+06.75063710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88586",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11042 AB"},
        {"Henry Draper", "HD 165340"},
        {"Hipparcos Number", "HIP 88586"},
        {"Smithsonian Astrophysical Observation", "SAO 123103"},
    },
    visualMagnitude: 8.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.30996409),
        dec: Angle.Degrees(+06.75083849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125078"},
        {"Hipparcos Number", "HIP 69804"},
        {"Geneva Identification System", "GEN# +1.00125078"},
        {"Smithsonian Astrophysical Observation", "SAO 120384"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.29155169),
        dec: Angle.Degrees(+06.75267210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132795"},
        {"Hipparcos Number", "HIP 73462"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.20957573),
        dec: Angle.Degrees(+06.75695235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156485"},
        {"Hipparcos Number", "HIP 84592"},
        {"Smithsonian Astrophysical Observation", "SAO 122245"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39000235),
        dec: Angle.Degrees(+06.76159617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112099"},
        {"Hipparcos Number", "HIP 62942"},
        {"Fundamental Katalog 5th Edition", "FK5 5139"},
        {"Geneva Identification System", "GEN# +1.00112099"},
        {"Smithsonian Astrophysical Observation", "SAO 119652"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.47723043),
        dec: Angle.Degrees(+06.76267282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36934"},
        {"Hipparcos Number", "HIP 26238"},
        {"Geneva Identification System", "GEN# +1.00036934"},
        {"Smithsonian Astrophysical Observation", "SAO 112928"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.84977226),
        dec: Angle.Degrees(+06.76478371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4978",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 874 AB"},
        {"Henry Draper", "HD 6277"},
        {"Hipparcos Number", "HIP 4978"},
        {"Smithsonian Astrophysical Observation", "SAO 109642"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.94642121),
        dec: Angle.Degrees(+06.76486693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162753"},
        {"Hipparcos Number", "HIP 87474"},
        {"Smithsonian Astrophysical Observation", "SAO 122856"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.08774121),
        dec: Angle.Degrees(+06.76761595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100776"},
        {"Hipparcos Number", "HIP 56574"},
        {"Smithsonian Astrophysical Observation", "SAO 118938"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.98492181),
        dec: Angle.Degrees(+06.76819650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40533"},
        {"Hipparcos Number", "HIP 28384"},
        {"Geneva Identification System", "GEN# +1.00040533"},
        {"Smithsonian Astrophysical Observation", "SAO 113333"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.94053467),
        dec: Angle.Degrees(+06.76965596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105335"},
        {"Hipparcos Number", "HIP 59147"},
        {"Smithsonian Astrophysical Observation", "SAO 119232"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.92515343),
        dec: Angle.Degrees(+06.77026632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163509"},
        {"Hipparcos Number", "HIP 87806"},
        {"Smithsonian Astrophysical Observation", "SAO 122937"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.05681502),
        dec: Angle.Degrees(+06.77308160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78841"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.41127053),
        dec: Angle.Degrees(+06.77478077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61581"},
        {"Hipparcos Number", "HIP 37370"},
        {"Smithsonian Astrophysical Observation", "SAO 115776"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.06383617),
        dec: Angle.Degrees(+06.77739712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36266"},
        {"Hipparcos Number", "HIP 25825"},
        {"Geneva Identification System", "GEN# +1.00036266"},
        {"Smithsonian Astrophysical Observation", "SAO 112853"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.71541443),
        dec: Angle.Degrees(+06.77849915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90851",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11432 AB"},
        {"Henry Draper", "HD 170987"},
        {"Hipparcos Number", "HIP 90851"},
        {"Smithsonian Astrophysical Observation", "SAO 123609"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.00728382),
        dec: Angle.Degrees(+06.78030939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26173"},
        {"Hipparcos Number", "HIP 19355"},
        {"Smithsonian Astrophysical Observation", "SAO 111625"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.19633948),
        dec: Angle.Degrees(+06.78151991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156842"},
        {"Hipparcos Number", "HIP 84764"},
        {"Smithsonian Astrophysical Observation", "SAO 122276"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.88720362),
        dec: Angle.Degrees(+06.78164949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42618"},
        {"Hipparcos Number", "HIP 29432"},
        {"Cincinnati Publication", "Ci 18 772"},
        {"Geneva Identification System", "GEN# +1.00042618"},
        {"Smithsonian Astrophysical Observation", "SAO 113580"},
        {"Wilson Evans Batten Catalogue", "WEB 5784"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.00187959),
        dec: Angle.Degrees(+06.78369045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131786"},
        {"Hipparcos Number", "HIP 73019"},
        {"Smithsonian Astrophysical Observation", "SAO 120739"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.84519206),
        dec: Angle.Degrees(+06.78479170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63283"},
        {"Hipparcos Number", "HIP 38093"},
        {"Smithsonian Astrophysical Observation", "SAO 115955"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.09531862),
        dec: Angle.Degrees(+06.78507130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108046"},
        {"Smithsonian Astrophysical Observation", "SAO 127135"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.34198546),
        dec: Angle.Degrees(+06.78550017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46122"},
        {"Hipparcos Number", "HIP 31118"},
        {"Geneva Identification System", "GEN# +1.00046122"},
        {"Smithsonian Astrophysical Observation", "SAO 114005"},
        {"Wilson Evans Batten Catalogue", "WEB 6203"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.94203939),
        dec: Angle.Degrees(+06.78555702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114608"},
        {"Hipparcos Number", "HIP 64364"},
        {"Smithsonian Astrophysical Observation", "SAO 119807"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87870236),
        dec: Angle.Degrees(+06.78840658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100291"},
    },
    visualMagnitude: 11.33,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.12227031),
        dec: Angle.Degrees(+06.78867215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93568"},
        {"Hipparcos Number", "HIP 52837"},
        {"Geneva Identification System", "GEN# +1.00093568"},
        {"Smithsonian Astrophysical Observation", "SAO 118504"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.05365678),
        dec: Angle.Degrees(+06.79025344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224875"},
        {"Hipparcos Number", "HIP 109"},
        {"Geneva Identification System", "GEN# +1.00224875"},
        {"Smithsonian Astrophysical Observation", "SAO 128535"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.34660201),
        dec: Angle.Degrees(+06.79149102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28630"},
        {"Hipparcos Number", "HIP 21078"},
        {"Smithsonian Astrophysical Observation", "SAO 111863"},
    },
    visualMagnitude: 6.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.76715913),
        dec: Angle.Degrees(+06.79154883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18947"},
        {"Smithsonian Astrophysical Observation", "SAO 111582"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91218183),
        dec: Angle.Degrees(+06.79293687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83744"},
        {"Smithsonian Astrophysical Observation", "SAO 122089"},
        {"Wilson Evans Batten Catalogue", "WEB 14161"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.73661598),
        dec: Angle.Degrees(+06.79695589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15738"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.69567985),
        dec: Angle.Degrees(+06.79959292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20402"},
        {"Hipparcos Number", "HIP 15279"},
        {"Geneva Identification System", "GEN# +1.00020402"},
        {"Smithsonian Astrophysical Observation", "SAO 111096"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.28739736),
        dec: Angle.Degrees(+06.79996605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171833"},
        {"Hipparcos Number", "HIP 91241"},
        {"Smithsonian Astrophysical Observation", "SAO 123694"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.16708834),
        dec: Angle.Degrees(+06.80100795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154734"},
        {"Hipparcos Number", "HIP 83747"},
        {"Smithsonian Astrophysical Observation", "SAO 122090"},
        {"Wilson Evans Batten Catalogue", "WEB 14162"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.73966799),
        dec: Angle.Degrees(+06.80104404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135026"},
        {"Hipparcos Number", "HIP 74444"},
        {"Smithsonian Astrophysical Observation", "SAO 120894"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.19900962),
        dec: Angle.Degrees(+06.80205287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4067"},
    },
    visualMagnitude: 11.80,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.03892102),
        dec: Angle.Degrees(+06.80306437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99834"},
        {"Hipparcos Number", "HIP 56046"},
        {"Smithsonian Astrophysical Observation", "SAO 118887"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.30456842),
        dec: Angle.Degrees(+06.80323735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23526"},
        {"Hipparcos Number", "HIP 17595"},
        {"Geneva Identification System", "GEN# +1.00023526"},
        {"Smithsonian Astrophysical Observation", "SAO 111407"},
        {"Wilson Evans Batten Catalogue", "WEB 3351"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.53901620),
        dec: Angle.Degrees(+06.80365522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141866"},
        {"Hipparcos Number", "HIP 77647"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.78317402),
        dec: Angle.Degrees(+06.80401209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138919"},
        {"Hipparcos Number", "HIP 76280"},
        {"Geneva Identification System", "GEN# +1.00138919"},
        {"Smithsonian Astrophysical Observation", "SAO 121070"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.70949346),
        dec: Angle.Degrees(+06.80425111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216872"},
        {"Hipparcos Number", "HIP 113294"},
        {"Geneva Identification System", "GEN# +1.00216872"},
        {"Smithsonian Astrophysical Observation", "SAO 127851"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.13343895),
        dec: Angle.Degrees(+06.80545608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8633 A"},
        {"Henry Draper", "HD 110423"},
        {"Hipparcos Number", "HIP 61968"},
        {"Geneva Identification System", "GEN# +1.00110423"},
        {"Smithsonian Astrophysical Observation", "SAO 119538"},
        {"Wilson Evans Batten Catalogue", "WEB 11021"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.48816539),
        dec: Angle.Degrees(+06.80664416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57071"},
        {"Smithsonian Astrophysical Observation", "SAO 118998"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.48876408),
        dec: Angle.Degrees(+06.80711091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165866"},
        {"Hipparcos Number", "HIP 88822"},
        {"Smithsonian Astrophysical Observation", "SAO 123151"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.96946957),
        dec: Angle.Degrees(+06.80864975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190974"},
        {"Hipparcos Number", "HIP 99113"},
        {"Smithsonian Astrophysical Observation", "SAO 125468"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.82814145),
        dec: Angle.Degrees(+06.80976295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53020"},
        {"Cincinnati Publication", "Ci 20 591"},
        {"Geneva Identification System", "GEN# +6.10010402"},
        {"Wilson Evans Batten Catalogue", "WEB 9640"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.71890470),
        dec: Angle.Degrees(+06.81011677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -804.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -809.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14920 A"},
        {"Henry Draper", "HD 203562"},
        {"Hipparcos Number", "HIP 105570"},
        {"Geneva Identification System", "GEN# +1.00203562"},
        {"Smithsonian Astrophysical Observation", "SAO 126749"},
        {"Wilson Evans Batten Catalogue", "WEB 19167"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.72325739),
        dec: Angle.Degrees(+06.81111338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4046"},
        {"Hipparcos Number", "HIP 3382"},
        {"Smithsonian Astrophysical Observation", "SAO 109401"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.74408373),
        dec: Angle.Degrees(+06.81161896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7700"},
        {"Hipparcos Number", "HIP 5980"},
        {"Geneva Identification System", "GEN# +1.00007700"},
        {"Smithsonian Astrophysical Observation", "SAO 109778"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.22945505),
        dec: Angle.Degrees(+06.81165232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70689"},
        {"Hipparcos Number", "HIP 41129"},
        {"Smithsonian Astrophysical Observation", "SAO 116705"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.87567742),
        dec: Angle.Degrees(+06.81323719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143469"},
        {"Hipparcos Number", "HIP 78390"},
        {"Smithsonian Astrophysical Observation", "SAO 121308"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.06001342),
        dec: Angle.Degrees(+06.81364550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11563"},
        {"Smithsonian Astrophysical Observation", "SAO 110557"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.24198224),
        dec: Angle.Degrees(+06.81411059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198023"},
        {"Hipparcos Number", "HIP 102592"},
        {"Geneva Identification System", "GEN# +1.00198023"},
        {"Smithsonian Astrophysical Observation", "SAO 126213"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.86768779),
        dec: Angle.Degrees(+06.81493050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130871"},
        {"Hipparcos Number", "HIP 72577"},
        {"Cincinnati Publication", "Ci 20 886"},
        {"Geneva Identification System", "GEN# +1.00130871"},
        {"Smithsonian Astrophysical Observation", "SAO 120688"},
        {"Wilson Evans Batten Catalogue", "WEB 12478"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.58883198),
        dec: Angle.Degrees(+06.81509159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -621.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77518"},
        {"Hipparcos Number", "HIP 44437"},
        {"Smithsonian Astrophysical Observation", "SAO 117374"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.81087746),
        dec: Angle.Degrees(+06.81594544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63119"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.99415371),
        dec: Angle.Degrees(+06.81615004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130743"},
        {"Hipparcos Number", "HIP 72535"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.45259464),
        dec: Angle.Degrees(+06.81644560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29480"},
        {"Hipparcos Number", "HIP 21633"},
        {"Smithsonian Astrophysical Observation", "SAO 111950"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.69254939),
        dec: Angle.Degrees(+06.82033236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206115"},
        {"Hipparcos Number", "HIP 106962"},
        {"Smithsonian Astrophysical Observation", "SAO 126968"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.95403943),
        dec: Angle.Degrees(+06.82042417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109890"},
        {"Geneva Identification System", "GEN# +0.00604990"},
        {"Wilson Evans Batten Catalogue", "WEB 19730"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.85677555),
        dec: Angle.Degrees(+06.82262369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44614"},
        {"Smithsonian Astrophysical Observation", "SAO 117414"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.35957961),
        dec: Angle.Degrees(+06.82307742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187657"},
        {"Hipparcos Number", "HIP 97664"},
        {"Renson", "Renson 51744"},
        {"Smithsonian Astrophysical Observation", "SAO 125127"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.72988263),
        dec: Angle.Degrees(+06.82362316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42647",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6933 AB"},
        {"Hipparcos Number", "HIP 42647"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.36409590),
        dec: Angle.Degrees(+06.82414708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76100"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.13880007),
        dec: Angle.Degrees(+06.82886939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195776"},
        {"Hipparcos Number", "HIP 101414"},
        {"Geneva Identification System", "GEN# +1.00195776"},
        {"Smithsonian Astrophysical Observation", "SAO 125938"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.28055571),
        dec: Angle.Degrees(+06.83024149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8968 AB"},
        {"Henry Draper", "HD 118430"},
        {"Hipparcos Number", "HIP 66392"},
        {"Smithsonian Astrophysical Observation", "SAO 120030"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.18901920),
        dec: Angle.Degrees(+06.83212171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45901"},
        {"Smithsonian Astrophysical Observation", "SAO 117616"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.37331121),
        dec: Angle.Degrees(+06.83525015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170291"},
        {"Hipparcos Number", "HIP 90532"},
        {"Geneva Identification System", "GEN# +2.66330123"},
        {"Smithsonian Astrophysical Observation", "SAO 123533"},
        {"Wilson Evans Batten Catalogue", "WEB 15506"},
        {"New General Catalogue", "NGC 6633 123"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.09177411),
        dec: Angle.Degrees(+06.83526411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83240"},
        {"Hipparcos Number", "HIP 47205"},
        {"Fundamental Katalog 5th Edition", "FK5 2767"},
        {"Geneva Identification System", "GEN# +1.00083240"},
        {"Smithsonian Astrophysical Observation", "SAO 117807"},
        {"Wilson Evans Batten Catalogue", "WEB 8878"},
    },
    visualMagnitude: 5.00,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.30295211),
        dec: Angle.Degrees(+06.83577519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113394"},
        {"Hipparcos Number", "HIP 63700"},
        {"Smithsonian Astrophysical Observation", "SAO 119740"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.81630918),
        dec: Angle.Degrees(+06.83647216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176054"},
        {"Hipparcos Number", "HIP 93115"},
        {"Geneva Identification System", "GEN# +1.00176054"},
        {"Smithsonian Astrophysical Observation", "SAO 124105"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.52822621),
        dec: Angle.Degrees(+06.83797787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33645"},
        {"Hipparcos Number", "HIP 24217"},
        {"Smithsonian Astrophysical Observation", "SAO 112511"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.00519039),
        dec: Angle.Degrees(+06.83808792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78254"},
        {"Hipparcos Number", "HIP 44765"},
        {"Smithsonian Astrophysical Observation", "SAO 117435"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.85156100),
        dec: Angle.Degrees(+06.83850361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210596"},
        {"Hipparcos Number", "HIP 109530"},
        {"Smithsonian Astrophysical Observation", "SAO 127357"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.81055006),
        dec: Angle.Degrees(+06.83887487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163610"},
        {"Hipparcos Number", "HIP 87835"},
        {"Smithsonian Astrophysical Observation", "SAO 122943"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.16863729),
        dec: Angle.Degrees(+06.84039438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118206"},
        {"Hipparcos Number", "HIP 66283"},
        {"Smithsonian Astrophysical Observation", "SAO 120020"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.77657554),
        dec: Angle.Degrees(+06.84118286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44929"},
        {"Hipparcos Number", "HIP 30506"},
        {"Smithsonian Astrophysical Observation", "SAO 113836"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.19080843),
        dec: Angle.Degrees(+06.84157184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22197"},
        {"Hipparcos Number", "HIP 16689"},
        {"Smithsonian Astrophysical Observation", "SAO 111270"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.67851621),
        dec: Angle.Degrees(+06.84341374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156179"},
        {"Hipparcos Number", "HIP 84443"},
        {"Smithsonian Astrophysical Observation", "SAO 122221"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.95841774),
        dec: Angle.Degrees(+06.84343605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56143"},
        {"Smithsonian Astrophysical Observation", "SAO 118897"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.61309797),
        dec: Angle.Degrees(+06.84388050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5654"},
        {"Hipparcos Number", "HIP 4559"},
        {"Fundamental Katalog 5th Edition", "FK5 4089"},
        {"Geneva Identification System", "GEN# +1.00005654"},
        {"Smithsonian Astrophysical Observation", "SAO 109563"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.58098414),
        dec: Angle.Degrees(+06.84432756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102731"},
        {"Hipparcos Number", "HIP 57675"},
        {"Smithsonian Astrophysical Observation", "SAO 119065"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.43519403),
        dec: Angle.Degrees(+06.84580255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54568"},
        {"Hipparcos Number", "HIP 34570"},
        {"Smithsonian Astrophysical Observation", "SAO 115007"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.40631197),
        dec: Angle.Degrees(+06.84626204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149505"},
        {"Hipparcos Number", "HIP 81189"},
        {"Geneva Identification System", "GEN# +1.00149505"},
        {"Smithsonian Astrophysical Observation", "SAO 121709"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.75681827),
        dec: Angle.Degrees(+06.84948376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65121"},
        {"Hipparcos Number", "HIP 38884"},
        {"Geneva Identification System", "GEN# +1.00065121"},
        {"Smithsonian Astrophysical Observation", "SAO 116168"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.35641869),
        dec: Angle.Degrees(+06.85169007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5336"},
        {"Hipparcos Number", "HIP 4323"},
        {"Smithsonian Astrophysical Observation", "SAO 109533"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.83138281),
        dec: Angle.Degrees(+06.85422733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116239"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.29276480),
        dec: Angle.Degrees(+06.85468687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110777"},
        {"Hipparcos Number", "HIP 62156"},
        {"Smithsonian Astrophysical Observation", "SAO 119564"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.08391486),
        dec: Angle.Degrees(+06.85477323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169842"},
        {"Hipparcos Number", "HIP 90367"},
        {"Geneva Identification System", "GEN# +2.66330039"},
        {"Renson", "Renson 47540"},
        {"New General Catalogue", "NGC 6633 39"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.59285235),
        dec: Angle.Degrees(+06.85712987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65040"},
        {"Geneva Identification System", "GEN# +0.00702634"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.98123315),
        dec: Angle.Degrees(+06.85766972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90349"},
        {"Hipparcos Number", "HIP 51058"},
        {"Smithsonian Astrophysical Observation", "SAO 118295"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.48699005),
        dec: Angle.Degrees(+06.85826800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81026"},
        {"Wilson Evans Batten Catalogue", "WEB 13705"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.23143921),
        dec: Angle.Degrees(+06.85827264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183960"},
        {"Hipparcos Number", "HIP 96050"},
        {"Smithsonian Astrophysical Observation", "SAO 124735"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.93699272),
        dec: Angle.Degrees(+06.85874933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33662"},
        {"Hipparcos Number", "HIP 24229"},
        {"Smithsonian Astrophysical Observation", "SAO 112512"},
        {"Wilson Evans Batten Catalogue", "WEB 4704"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.03250261),
        dec: Angle.Degrees(+06.85984271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18224"},
        {"Smithsonian Astrophysical Observation", "SAO 111482"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.44783884),
        dec: Angle.Degrees(+06.86052936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221939"},
        {"Hipparcos Number", "HIP 116486"},
        {"Smithsonian Astrophysical Observation", "SAO 128278"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.06278267),
        dec: Angle.Degrees(+06.86081736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111181"},
        {"Hipparcos Number", "HIP 62404"},
        {"Geneva Identification System", "GEN# +1.00111181"},
        {"Smithsonian Astrophysical Observation", "SAO 119594"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.83273693),
        dec: Angle.Degrees(+06.86115177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93949"},
        {"Hipparcos Number", "HIP 53019"},
        {"Smithsonian Astrophysical Observation", "SAO 118527"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.71271937),
        dec: Angle.Degrees(+06.86230344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58165"},
        {"Smithsonian Astrophysical Observation", "SAO 119119"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.93040487),
        dec: Angle.Degrees(+06.86280482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224617"},
        {"Hipparcos Number", "HIP 118268"},
        {"Fundamental Katalog 5th Edition", "FK5 902"},
        {"Geneva Identification System", "GEN# +1.00224617"},
        {"Smithsonian Astrophysical Observation", "SAO 128513"},
        {"Wilson Evans Batten Catalogue", "WEB 20787"},
    },
    visualMagnitude: 4.03,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.82750994),
        dec: Angle.Degrees(+06.86359373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208110"},
        {"Hipparcos Number", "HIP 108090"},
        {"Geneva Identification System", "GEN# +1.00208110"},
        {"Smithsonian Astrophysical Observation", "SAO 127141"},
        {"Wilson Evans Batten Catalogue", "WEB 19488"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.49050038),
        dec: Angle.Degrees(+06.86477025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108677"},
        {"Hipparcos Number", "HIP 60916"},
        {"Smithsonian Astrophysical Observation", "SAO 119425"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.27149984),
        dec: Angle.Degrees(+06.86522981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19772"},
        {"Hipparcos Number", "HIP 14802"},
        {"Smithsonian Astrophysical Observation", "SAO 111032"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.78989500),
        dec: Angle.Degrees(+06.86705474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95528"},
        {"Hipparcos Number", "HIP 53904"},
        {"Smithsonian Astrophysical Observation", "SAO 118623"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.44258911),
        dec: Angle.Degrees(+06.86779700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35656"},
        {"Hipparcos Number", "HIP 25453"},
        {"Geneva Identification System", "GEN# +1.00035656"},
        {"Smithsonian Astrophysical Observation", "SAO 112767"},
        {"Wilson Evans Batten Catalogue", "WEB 4931"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.66176734),
        dec: Angle.Degrees(+06.86873694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220008"},
        {"Hipparcos Number", "HIP 115223"},
        {"Geneva Identification System", "GEN# +1.00220008"},
        {"Smithsonian Astrophysical Observation", "SAO 128125"},
        {"Wilson Evans Batten Catalogue", "WEB 20411"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.07622720),
        dec: Angle.Degrees(+06.87234676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167515"},
        {"Hipparcos Number", "HIP 89451"},
        {"Smithsonian Astrophysical Observation", "SAO 123295"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.83295743),
        dec: Angle.Degrees(+06.87273489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24887"},
        {"Hipparcos Number", "HIP 18521"},
        {"Smithsonian Astrophysical Observation", "SAO 111523"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.40859160),
        dec: Angle.Degrees(+06.87382433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29462"},
        {"Hipparcos Number", "HIP 21629"},
        {"Geneva Identification System", "GEN# +1.00029462"},
        {"Smithsonian Astrophysical Observation", "SAO 111948"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.66207912),
        dec: Angle.Degrees(+06.87484466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231"},
        {"Hipparcos Number", "HIP 581"},
        {"Geneva Identification System", "GEN# +1.00000231"},
        {"Smithsonian Astrophysical Observation", "SAO 109014"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.76733158),
        dec: Angle.Degrees(+06.87560716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102999"},
        {"Hipparcos Number", "HIP 57829"},
        {"Smithsonian Astrophysical Observation", "SAO 119080"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.89210000),
        dec: Angle.Degrees(+06.87663303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101526",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14017 AB"},
        {"Henry Draper", "HD 196025"},
        {"Hipparcos Number", "HIP 101526"},
        {"Geneva Identification System", "GEN# +1.00196025J"},
        {"Renson", "Renson 54652"},
        {"Smithsonian Astrophysical Observation", "SAO 125969"},
        {"Wilson Evans Batten Catalogue", "WEB 18347"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.63253690),
        dec: Angle.Degrees(+06.87809164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1130"},
        {"Smithsonian Astrophysical Observation", "SAO 109081"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.52293095),
        dec: Angle.Degrees(+06.87814069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204602"},
        {"Hipparcos Number", "HIP 106110"},
        {"Smithsonian Astrophysical Observation", "SAO 126836"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.40595120),
        dec: Angle.Degrees(+06.87967256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16823"},
        {"Hipparcos Number", "HIP 12607"},
        {"Smithsonian Astrophysical Observation", "SAO 110693"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.52446789),
        dec: Angle.Degrees(+06.88059957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37543"},
        {"Hipparcos Number", "HIP 26631"},
        {"Geneva Identification System", "GEN# +1.00037543"},
        {"Smithsonian Astrophysical Observation", "SAO 113008"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.90053092),
        dec: Angle.Degrees(+06.88249518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16160"},
        {"Hipparcos Number", "HIP 12114"},
        {"Cincinnati Publication", "Ci 20 174"},
        {"Fundamental Katalog 5th Edition", "FK5 1073"},
        {"Geneva Identification System", "GEN# +1.00016160A"},
        {"Smithsonian Astrophysical Observation", "SAO 110636"},
        {"Wilson Evans Batten Catalogue", "WEB 2492"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.01596864),
        dec: Angle.Degrees(+06.88336423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1806.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1442.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140346"},
        {"Hipparcos Number", "HIP 76959"},
        {"Smithsonian Astrophysical Observation", "SAO 121144"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.71528610),
        dec: Angle.Degrees(+06.88393239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38108"},
        {"Hipparcos Number", "HIP 26992"},
        {"Celescope Catalog", "CEL 946"},
        {"Geneva Identification System", "GEN# +1.00038108"},
        {"Smithsonian Astrophysical Observation", "SAO 113080"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.90229157),
        dec: Angle.Degrees(+06.88851411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177959"},
        {"Hipparcos Number", "HIP 93833"},
        {"Smithsonian Astrophysical Observation", "SAO 124270"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64000537),
        dec: Angle.Degrees(+06.89045685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127640"},
        {"Hipparcos Number", "HIP 71102"},
        {"Smithsonian Astrophysical Observation", "SAO 120517"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.10119461),
        dec: Angle.Degrees(+06.89079865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148930"},
        {"Hipparcos Number", "HIP 80900"},
        {"Geneva Identification System", "GEN# +1.00148930"},
        {"Smithsonian Astrophysical Observation", "SAO 121663"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.81768793),
        dec: Angle.Degrees(+06.89182612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104099"},
        {"Hipparcos Number", "HIP 58473"},
        {"Smithsonian Astrophysical Observation", "SAO 119152"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.86677524),
        dec: Angle.Degrees(+06.89336295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112415"},
        {"Hipparcos Number", "HIP 63147"},
        {"Smithsonian Astrophysical Observation", "SAO 119676"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.08859730),
        dec: Angle.Degrees(+06.89337609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15716 A"},
        {"Henry Draper", "HD 210686"},
        {"Hipparcos Number", "HIP 109582"},
        {"Geneva Identification System", "GEN# +1.00210686"},
        {"Smithsonian Astrophysical Observation", "SAO 127363"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.97792827),
        dec: Angle.Degrees(+06.89631128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199584"},
        {"Hipparcos Number", "HIP 103490"},
        {"Smithsonian Astrophysical Observation", "SAO 126418"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.51250848),
        dec: Angle.Degrees(+06.89690781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161425"},
        {"Hipparcos Number", "HIP 86891"},
        {"Smithsonian Astrophysical Observation", "SAO 122701"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.31495679),
        dec: Angle.Degrees(+06.89977873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4898"},
        {"Hipparcos Number", "HIP 3972"},
        {"Geneva Identification System", "GEN# +1.00004898"},
        {"Smithsonian Astrophysical Observation", "SAO 109505"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.76572802),
        dec: Angle.Degrees(+06.89982260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47417"},
        {"Hipparcos Number", "HIP 31787"},
        {"Celescope Catalog", "CEL 1332"},
        {"Fundamental Katalog 5th Edition", "FK5 4604"},
        {"Geneva Identification System", "GEN# +1.00047417A"},
        {"Smithsonian Astrophysical Observation", "SAO 114192"},
        {"Wilson Evans Batten Catalogue", "WEB 6381"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.69969717),
        dec: Angle.Degrees(+06.90188322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240984"},
        {"Hipparcos Number", "HIP 23961"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.25398149),
        dec: Angle.Degrees(+06.90459594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132307"},
        {"Hipparcos Number", "HIP 73245"},
        {"Geneva Identification System", "GEN# +1.00132307"},
        {"Smithsonian Astrophysical Observation", "SAO 120766"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.54572761),
        dec: Angle.Degrees(+06.90472995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89579"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.19103823),
        dec: Angle.Degrees(+06.90505404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87669"},
        {"Hipparcos Number", "HIP 49519"},
        {"Smithsonian Astrophysical Observation", "SAO 118110"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.65628705),
        dec: Angle.Degrees(+06.90572261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62517"},
        {"Smithsonian Astrophysical Observation", "SAO 119604"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.17899672),
        dec: Angle.Degrees(+06.90648221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174900"},
        {"Hipparcos Number", "HIP 92647"},
        {"Smithsonian Astrophysical Observation", "SAO 123999"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.16781466),
        dec: Angle.Degrees(+06.90780650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75785"},
        {"Hipparcos Number", "HIP 43555"},
        {"Smithsonian Astrophysical Observation", "SAO 117210"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.06100881),
        dec: Angle.Degrees(+06.90878161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204247"},
        {"Hipparcos Number", "HIP 105922"},
        {"Smithsonian Astrophysical Observation", "SAO 126802"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.79403223),
        dec: Angle.Degrees(+06.91129833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38154"},
        {"Hipparcos Number", "HIP 27029"},
        {"Celescope Catalog", "CEL 949"},
        {"Geneva Identification System", "GEN# +1.00038154"},
        {"Smithsonian Astrophysical Observation", "SAO 113086"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.99794517),
        dec: Angle.Degrees(+06.91519561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12233"},
        {"Hipparcos Number", "HIP 9355"},
        {"Smithsonian Astrophysical Observation", "SAO 110268"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.05304428),
        dec: Angle.Degrees(+06.91806414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106313"},
        {"Hipparcos Number", "HIP 59643"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.47339582),
        dec: Angle.Degrees(+06.91992282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99969"},
        {"Geneva Identification System", "GEN# +0.00604489"},
        {"Wilson Evans Batten Catalogue", "WEB 17998"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23051420),
        dec: Angle.Degrees(+06.92173932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137911"},
        {"Hipparcos Number", "HIP 75759"},
        {"Geneva Identification System", "GEN# +1.00137911"},
        {"Smithsonian Astrophysical Observation", "SAO 121021"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.15416974),
        dec: Angle.Degrees(+06.92208864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88950"},
        {"Hipparcos Number", "HIP 50255"},
        {"Smithsonian Astrophysical Observation", "SAO 118189"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.92597685),
        dec: Angle.Degrees(+06.92577769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22074"},
        {"Hipparcos Number", "HIP 16606"},
        {"Geneva Identification System", "GEN# +1.00022074"},
        {"Smithsonian Astrophysical Observation", "SAO 111259"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.43670505),
        dec: Angle.Degrees(+06.92601855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52456"},
        {"Hipparcos Number", "HIP 33848"},
        {"Geneva Identification System", "GEN# +1.00052456"},
        {"Smithsonian Astrophysical Observation", "SAO 114791"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.39825472),
        dec: Angle.Degrees(+06.92677437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140345"},
        {"Hipparcos Number", "HIP 76964"},
        {"Smithsonian Astrophysical Observation", "SAO 121146"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.72751118),
        dec: Angle.Degrees(+06.92707158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101365"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.17259721),
        dec: Angle.Degrees(+06.92801163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267429"},
        {"Hipparcos Number", "HIP 33606"},
        {"Smithsonian Astrophysical Observation", "SAO 114719"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.74294549),
        dec: Angle.Degrees(+06.92984205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95132"},
        {"Hipparcos Number", "HIP 53697"},
        {"Smithsonian Astrophysical Observation", "SAO 118602"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.79267973),
        dec: Angle.Degrees(+06.93107043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246287"},
        {"Hipparcos Number", "HIP 26719"},
        {"Smithsonian Astrophysical Observation", "SAO 113027"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.17538964),
        dec: Angle.Degrees(+06.93313609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127741"},
        {"Hipparcos Number", "HIP 71142"},
        {"Smithsonian Astrophysical Observation", "SAO 120521"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.24203557),
        dec: Angle.Degrees(+06.93314562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164282"},
        {"Hipparcos Number", "HIP 88134"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.03528603),
        dec: Angle.Degrees(+06.93644085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187095"},
        {"Hipparcos Number", "HIP 97404"},
        {"Geneva Identification System", "GEN# +1.00187095"},
        {"Smithsonian Astrophysical Observation", "SAO 125075"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.96281177),
        dec: Angle.Degrees(+06.94037544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45194"},
        {"Smithsonian Astrophysical Observation", "SAO 117498"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.14714167),
        dec: Angle.Degrees(+06.94143352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36265",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6101 A"},
        {"Henry Draper", "HD 58923"},
        {"Hipparcos Number", "HIP 36265"},
        {"Geneva Identification System", "GEN# +1.00058923"},
        {"Smithsonian Astrophysical Observation", "SAO 115477"},
        {"Wilson Evans Batten Catalogue", "WEB 7223"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.00865288),
        dec: Angle.Degrees(+06.94207694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102211"},
        {"Hipparcos Number", "HIP 57378"},
        {"Geneva Identification System", "GEN# +1.00102211"},
        {"Smithsonian Astrophysical Observation", "SAO 119034"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.45356187),
        dec: Angle.Degrees(+06.94259276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189478"},
        {"Hipparcos Number", "HIP 98433"},
        {"Geneva Identification System", "GEN# +1.00189478"},
        {"Smithsonian Astrophysical Observation", "SAO 125326"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.99840556),
        dec: Angle.Degrees(+06.94288500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16466"},
        {"Hipparcos Number", "HIP 12323"},
        {"Smithsonian Astrophysical Observation", "SAO 110656"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.67006805),
        dec: Angle.Degrees(+06.94673923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196182"},
        {"Hipparcos Number", "HIP 101607"},
        {"Smithsonian Astrophysical Observation", "SAO 125996"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.87349275),
        dec: Angle.Degrees(+06.94707061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147869"},
        {"Hipparcos Number", "HIP 80351"},
        {"Fundamental Katalog 5th Edition", "FK5 1429"},
        {"Geneva Identification System", "GEN# +1.00147869"},
        {"Renson", "Renson 41690"},
        {"Smithsonian Astrophysical Observation", "SAO 121568"},
        {"Wilson Evans Batten Catalogue", "WEB 13596"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.04511352),
        dec: Angle.Degrees(+06.94817146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211961"},
        {"Hipparcos Number", "HIP 110330"},
        {"Smithsonian Astrophysical Observation", "SAO 127456"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.19810862),
        dec: Angle.Degrees(+06.94957871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85749"},
        {"Hipparcos Number", "HIP 48542"},
        {"Geneva Identification System", "GEN# +1.00085749"},
        {"Smithsonian Astrophysical Observation", "SAO 117977"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.49927699),
        dec: Angle.Degrees(+06.94969451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13449"},
    },
    visualMagnitude: 11.97,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.29858898),
        dec: Angle.Degrees(+06.94975463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30714"},
        {"Hipparcos Number", "HIP 22490"},
        {"Smithsonian Astrophysical Observation", "SAO 112117"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.57209124),
        dec: Angle.Degrees(+06.94990190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70729"},
        {"Smithsonian Astrophysical Observation", "SAO 120476"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.97972833),
        dec: Angle.Degrees(+06.95171456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91612"},
        {"Hipparcos Number", "HIP 51775"},
        {"Fundamental Katalog 5th Edition", "FK5 2846"},
        {"Geneva Identification System", "GEN# +1.00091612"},
        {"Smithsonian Astrophysical Observation", "SAO 118376"},
        {"Wilson Evans Batten Catalogue", "WEB 9431"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70030655),
        dec: Angle.Degrees(+06.95361136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2548",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 449 A"},
        {"Henry Draper", "HD 2913"},
        {"Hipparcos Number", "HIP 2548"},
        {"Fundamental Katalog 5th Edition", "FK5 2032"},
        {"Geneva Identification System", "GEN# +1.00002913A"},
        {"Smithsonian Astrophysical Observation", "SAO 109262"},
        {"Wilson Evans Batten Catalogue", "WEB 469"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.09897908),
        dec: Angle.Degrees(+06.95545461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73512"},
        {"Hipparcos Number", "HIP 42418"},
        {"Smithsonian Astrophysical Observation", "SAO 116990"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.75127025),
        dec: Angle.Degrees(+06.95617207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
