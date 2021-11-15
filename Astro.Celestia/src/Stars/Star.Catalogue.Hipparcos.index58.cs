using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_58() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79756"},
        {"Smithsonian Astrophysical Observation", "SAO 141073"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18373191),
        dec: Angle.Degrees(-03.38354164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6450"},
        {"Hipparcos Number", "HIP 5102"},
        {"Smithsonian Astrophysical Observation", "SAO 129112"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.34971258),
        dec: Angle.Degrees(-03.38311991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29611"},
        {"Hipparcos Number", "HIP 21714"},
        {"Smithsonian Astrophysical Observation", "SAO 131391"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.93234704),
        dec: Angle.Degrees(-03.38164182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 853"},
        {"Hipparcos Number", "HIP 1033"},
        {"Smithsonian Astrophysical Observation", "SAO 128642"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.22974594),
        dec: Angle.Degrees(-03.38151830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294518"},
        {"Hipparcos Number", "HIP 28269"},
        {"Smithsonian Astrophysical Observation", "SAO 132704"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.59983401),
        dec: Angle.Degrees(-03.37895708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116802"},
        {"Hipparcos Number", "HIP 65531"},
        {"Geneva Identification System", "GEN# +1.00116802"},
        {"Smithsonian Astrophysical Observation", "SAO 139335"},
        {"Wilson Evans Batten Catalogue", "WEB 11569"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.50831335),
        dec: Angle.Degrees(-03.37873334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99776"},
        {"Hipparcos Number", "HIP 56006"},
        {"Smithsonian Astrophysical Observation", "SAO 138226"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.16207521),
        dec: Angle.Degrees(-03.37730914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87502"},
        {"Hipparcos Number", "HIP 49426"},
        {"Smithsonian Astrophysical Observation", "SAO 137344"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.33696505),
        dec: Angle.Degrees(-03.37433024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197756"},
        {"Hipparcos Number", "HIP 102462"},
        {"Smithsonian Astrophysical Observation", "SAO 144778"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.44191181),
        dec: Angle.Degrees(-03.37377510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116107"},
        {"Smithsonian Astrophysical Observation", "SAO 146754"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.88421353),
        dec: Angle.Degrees(-03.37342188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54219"},
        {"Hipparcos Number", "HIP 34385"},
        {"Geneva Identification System", "GEN# +1.00054219"},
        {"Smithsonian Astrophysical Observation", "SAO 134228"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.94574930),
        dec: Angle.Degrees(-03.37102249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47798"},
        {"Hipparcos Number", "HIP 31930"},
        {"Smithsonian Astrophysical Observation", "SAO 133551"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.09164834),
        dec: Angle.Degrees(-03.36923230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63494",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8732 AB"},
        {"Henry Draper", "HD 112992"},
        {"Hipparcos Number", "HIP 63494"},
        {"Geneva Identification System", "GEN# +1.00112992"},
        {"Smithsonian Astrophysical Observation", "SAO 139096"},
        {"Wilson Evans Batten Catalogue", "WEB 11235"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.14982714),
        dec: Angle.Degrees(-03.36860790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60757"},
        {"Hipparcos Number", "HIP 36969"},
        {"Geneva Identification System", "GEN# +1.00060757"},
        {"Smithsonian Astrophysical Observation", "SAO 134872"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.99082392),
        dec: Angle.Degrees(-03.36830303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12262"},
        {"Hipparcos Number", "HIP 9358"},
        {"Renson", "Renson 3110"},
        {"Smithsonian Astrophysical Observation", "SAO 129622"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.06178693),
        dec: Angle.Degrees(-03.36827572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77266"},
        {"Hipparcos Number", "HIP 44306"},
        {"Geneva Identification System", "GEN# +1.00077266"},
        {"Smithsonian Astrophysical Observation", "SAO 136498"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.34612488),
        dec: Angle.Degrees(-03.36811900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21303"},
        {"Hipparcos Number", "HIP 15995"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51268520),
        dec: Angle.Degrees(-03.36803099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34195"},
        {"Hipparcos Number", "HIP 24503"},
        {"Geneva Identification System", "GEN# +1.00034195"},
        {"Smithsonian Astrophysical Observation", "SAO 131918"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.84882854),
        dec: Angle.Degrees(-03.36596186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135298"},
        {"Hipparcos Number", "HIP 74595"},
        {"Smithsonian Astrophysical Observation", "SAO 140403"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.61937880),
        dec: Angle.Degrees(-03.36440887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20404"},
        {"Hipparcos Number", "HIP 15251"},
        {"Geneva Identification System", "GEN# +1.00020404"},
        {"Smithsonian Astrophysical Observation", "SAO 130397"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.18496585),
        dec: Angle.Degrees(-03.36397480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69502"},
        {"Hipparcos Number", "HIP 40581"},
        {"Smithsonian Astrophysical Observation", "SAO 135724"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.29003345),
        dec: Angle.Degrees(-03.36369739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129755"},
        {"Hipparcos Number", "HIP 72069"},
        {"Geneva Identification System", "GEN# +1.00129755"},
        {"Smithsonian Astrophysical Observation", "SAO 140107"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.12764680),
        dec: Angle.Degrees(-03.36331773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57454"},
        {"Hipparcos Number", "HIP 35631"},
        {"Smithsonian Astrophysical Observation", "SAO 134558"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.28801251),
        dec: Angle.Degrees(-03.36261540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40732"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.69787249),
        dec: Angle.Degrees(-03.36157257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84230"},
        {"Hipparcos Number", "HIP 47702"},
        {"Smithsonian Astrophysical Observation", "SAO 137080"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.89159092),
        dec: Angle.Degrees(-03.35978428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194939"},
        {"Hipparcos Number", "HIP 100977"},
        {"Geneva Identification System", "GEN# +1.00194939"},
        {"Smithsonian Astrophysical Observation", "SAO 144468"},
        {"Wilson Evans Batten Catalogue", "WEB 18241"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.10370567),
        dec: Angle.Degrees(-03.35774231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11205 AB"},
        {"Henry Draper", "HD 167517"},
        {"Hipparcos Number", "HIP 89489"},
        {"Smithsonian Astrophysical Observation", "SAO 142184"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.92686721),
        dec: Angle.Degrees(-03.35766117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195778"},
        {"Hipparcos Number", "HIP 101435"},
        {"Geneva Identification System", "GEN# +1.00195778"},
        {"Smithsonian Astrophysical Observation", "SAO 144566"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.35539859),
        dec: Angle.Degrees(-03.35665436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198518"},
        {"Hipparcos Number", "HIP 102904"},
        {"Smithsonian Astrophysical Observation", "SAO 144869"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.70574340),
        dec: Angle.Degrees(-03.35552845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224499"},
        {"Hipparcos Number", "HIP 118186"},
        {"Smithsonian Astrophysical Observation", "SAO 147006"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59834320),
        dec: Angle.Degrees(-03.35458892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29248"},
        {"Hipparcos Number", "HIP 21444"},
        {"Celescope Catalog", "CEL 442"},
        {"Fundamental Katalog 5th Edition", "FK5 169"},
        {"Geneva Identification System", "GEN# +1.00029248"},
        {"Smithsonian Astrophysical Observation", "SAO 131346"},
        {"Wilson Evans Batten Catalogue", "WEB 4116"},
    },
    visualMagnitude: 3.93,
    bvColour: -0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.07975243),
        dec: Angle.Degrees(-03.35244800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155458"},
        {"Hipparcos Number", "HIP 84116"},
        {"Geneva Identification System", "GEN# +1.00155458"},
        {"Smithsonian Astrophysical Observation", "SAO 141552"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.95192246),
        dec: Angle.Degrees(-03.34846387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144308"},
        {"Hipparcos Number", "HIP 78813"},
        {"Smithsonian Astrophysical Observation", "SAO 140941"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.33848852),
        dec: Angle.Degrees(-03.34844027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13281 A"},
        {"Henry Draper", "HD 189923"},
        {"Hipparcos Number", "HIP 98685"},
        {"Geneva Identification System", "GEN# +1.00189923"},
        {"Smithsonian Astrophysical Observation", "SAO 144017"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.65786912),
        dec: Angle.Degrees(-03.34235717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41756"},
        {"Hipparcos Number", "HIP 28981"},
        {"Celescope Catalog", "CEL 1081"},
        {"Fundamental Katalog 5th Edition", "FK5 4559"},
        {"Geneva Identification System", "GEN# +1.00041756"},
        {"Smithsonian Astrophysical Observation", "SAO 132845"},
        {"Wilson Evans Batten Catalogue", "WEB 5671"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73441662),
        dec: Angle.Degrees(-03.34118116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178515"},
        {"Hipparcos Number", "HIP 94066"},
        {"Geneva Identification System", "GEN# +1.00178515"},
        {"Smithsonian Astrophysical Observation", "SAO 143074"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.24518261),
        dec: Angle.Degrees(-03.34117248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25697"},
        {"Hipparcos Number", "HIP 19027"},
        {"Geneva Identification System", "GEN# +1.00025697"},
        {"Smithsonian Astrophysical Observation", "SAO 130918"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.13401672),
        dec: Angle.Degrees(-03.33953963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9144"},
        {"Henry Draper", "HD 124054"},
        {"Hipparcos Number", "HIP 69328"},
        {"Smithsonian Astrophysical Observation", "SAO 139777"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.83528475),
        dec: Angle.Degrees(-03.33809449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108754"},
        {"Hipparcos Number", "HIP 60956"},
        {"Cincinnati Publication", "Ci 20 712"},
        {"Geneva Identification System", "GEN# +1.00108754"},
        {"Smithsonian Astrophysical Observation", "SAO 138815"},
        {"Wilson Evans Batten Catalogue", "WEB 10847"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.42886106),
        dec: Angle.Degrees(-03.33160201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -328.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -562.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37642"},
        {"Hipparcos Number", "HIP 26656"},
        {"Celescope Catalog", "CEL 909"},
        {"Geneva Identification System", "GEN# +1.00037642"},
        {"Renson", "Renson 10150"},
        {"Smithsonian Astrophysical Observation", "SAO 132429"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.98092009),
        dec: Angle.Degrees(-03.33049059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104077"},
        {"Hipparcos Number", "HIP 58457"},
        {"Smithsonian Astrophysical Observation", "SAO 138520"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.81077343),
        dec: Angle.Degrees(-03.32263240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138885"},
        {"Hipparcos Number", "HIP 76292"},
        {"Smithsonian Astrophysical Observation", "SAO 140622"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.77017466),
        dec: Angle.Degrees(-03.32228640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82356"},
        {"Hipparcos Number", "HIP 46708"},
        {"Smithsonian Astrophysical Observation", "SAO 136922"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.82888876),
        dec: Angle.Degrees(-03.32157915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 688"},
        {"Hipparcos Number", "HIP 906"},
        {"Geneva Identification System", "GEN# +1.00000688"},
        {"Smithsonian Astrophysical Observation", "SAO 128628"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.79012709),
        dec: Angle.Degrees(-03.32135959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196161"},
        {"Hipparcos Number", "HIP 101619"},
        {"Smithsonian Astrophysical Observation", "SAO 144610"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.92796263),
        dec: Angle.Degrees(-03.32010027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107148"},
        {"Hipparcos Number", "HIP 60081"},
        {"Geneva Identification System", "GEN# +1.00107148"},
        {"Smithsonian Astrophysical Observation", "SAO 138714"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.80634504),
        dec: Angle.Degrees(-03.31967354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124292"},
        {"Hipparcos Number", "HIP 69414"},
        {"Cincinnati Publication", "Ci 18 1864"},
        {"Geneva Identification System", "GEN# +1.00124292"},
        {"Smithsonian Astrophysical Observation", "SAO 139790"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.18888983),
        dec: Angle.Degrees(-03.31930138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -322.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101427"},
        {"Hipparcos Number", "HIP 56932"},
        {"Smithsonian Astrophysical Observation", "SAO 138335"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.07286477),
        dec: Angle.Degrees(-03.31845241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199681"},
        {"Hipparcos Number", "HIP 103554"},
        {"Geneva Identification System", "GEN# +1.00199681"},
        {"Smithsonian Astrophysical Observation", "SAO 144997"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.70642252),
        dec: Angle.Degrees(-03.31805541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174589"},
        {"Hipparcos Number", "HIP 92524"},
        {"Fundamental Katalog 5th Edition", "FK5 3500"},
        {"Geneva Identification System", "GEN# +1.00174589"},
        {"Smithsonian Astrophysical Observation", "SAO 142706"},
        {"Wilson Evans Batten Catalogue", "WEB 16003"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84232175),
        dec: Angle.Degrees(-03.31780480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37056"},
        {"Hipparcos Number", "HIP 26271"},
        {"Geneva Identification System", "GEN# +1.00037056"},
        {"Smithsonian Astrophysical Observation", "SAO 132335"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.91604515),
        dec: Angle.Degrees(-03.31608036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67099",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9010 A"},
        {"Henry Draper", "HD 119750"},
        {"Hipparcos Number", "HIP 67099"},
        {"Geneva Identification System", "GEN# +1.00119750A"},
        {"Smithsonian Astrophysical Observation", "SAO 139530"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.29354764),
        dec: Angle.Degrees(-03.31517194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7347"},
        {"Hipparcos Number", "HIP 5715"},
        {"Smithsonian Astrophysical Observation", "SAO 129184"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.38298274),
        dec: Angle.Degrees(-03.31418126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21985"},
        {"Hipparcos Number", "HIP 16496"},
        {"Geneva Identification System", "GEN# +1.00021985"},
        {"Smithsonian Astrophysical Observation", "SAO 130554"},
        {"Wilson Evans Batten Catalogue", "WEB 3152"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.10476633),
        dec: Angle.Degrees(-03.31325807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222774"},
        {"Hipparcos Number", "HIP 117043"},
        {"Smithsonian Astrophysical Observation", "SAO 146868"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.90085865),
        dec: Angle.Degrees(-03.31302130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1689"},
        {"Hipparcos Number", "HIP 1691"},
        {"Geneva Identification System", "GEN# +1.00001689"},
        {"Smithsonian Astrophysical Observation", "SAO 128710"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.30461937),
        dec: Angle.Degrees(-03.31197662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33056"},
        {"Hipparcos Number", "HIP 23837"},
        {"Geneva Identification System", "GEN# +1.00033056"},
        {"Smithsonian Astrophysical Observation", "SAO 131789"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.87246035),
        dec: Angle.Degrees(-03.31136214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38915"},
        {"Hipparcos Number", "HIP 27466"},
        {"Geneva Identification System", "GEN# +1.00038915"},
        {"Smithsonian Astrophysical Observation", "SAO 132563"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.25095295),
        dec: Angle.Degrees(-03.31128946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109957"},
        {"Hipparcos Number", "HIP 61695"},
        {"Renson", "Renson 31913"},
        {"Smithsonian Astrophysical Observation", "SAO 138887"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.69852432),
        dec: Angle.Degrees(-03.30906415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4078"},
        {"Henry Draper", "HD 36058"},
        {"Hipparcos Number", "HIP 25667"},
        {"Celescope Catalog", "CEL 730"},
        {"Geneva Identification System", "GEN# +1.00036058J"},
        {"Smithsonian Astrophysical Observation", "SAO 132157"},
        {"Wilson Evans Batten Catalogue", "WEB 4980"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.23713070),
        dec: Angle.Degrees(-03.30741204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27467"},
    },
    visualMagnitude: 12.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.25293870),
        dec: Angle.Degrees(-03.30687237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18176"},
        {"Hipparcos Number", "HIP 13582"},
        {"Smithsonian Astrophysical Observation", "SAO 130184"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.74124049),
        dec: Angle.Degrees(-03.30685732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213874"},
        {"Hipparcos Number", "HIP 111446"},
        {"Geneva Identification System", "GEN# +1.00213874"},
        {"Smithsonian Astrophysical Observation", "SAO 146166"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.65879803),
        dec: Angle.Degrees(-03.30651655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224776"},
        {"Hipparcos Number", "HIP 44"},
        {"Smithsonian Astrophysical Observation", "SAO 147026"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.13272230),
        dec: Angle.Degrees(-03.30636174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33223"},
        {"Hipparcos Number", "HIP 23935"},
        {"Geneva Identification System", "GEN# +1.00033223"},
        {"Smithsonian Astrophysical Observation", "SAO 131812"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.15698276),
        dec: Angle.Degrees(-03.30585385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48253"},
        {"Hipparcos Number", "HIP 32116"},
        {"Smithsonian Astrophysical Observation", "SAO 133595"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.62131773),
        dec: Angle.Degrees(-03.30502816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138670"},
        {"Hipparcos Number", "HIP 76183"},
        {"Smithsonian Astrophysical Observation", "SAO 140605"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.41199784),
        dec: Angle.Degrees(-03.30452742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15432 A"},
        {"Henry Draper", "HD 208177"},
        {"Hipparcos Number", "HIP 108144"},
        {"Geneva Identification System", "GEN# +1.00208177"},
        {"Smithsonian Astrophysical Observation", "SAO 145735"},
        {"Wilson Evans Batten Catalogue", "WEB 19494"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.64957986),
        dec: Angle.Degrees(-03.30119185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20166"},
        {"Smithsonian Astrophysical Observation", "SAO 131111"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.82902937),
        dec: Angle.Degrees(-03.29694765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17403"},
        {"Hipparcos Number", "HIP 13024"},
        {"Smithsonian Astrophysical Observation", "SAO 130114"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.85567343),
        dec: Angle.Degrees(-03.29679511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93285"},
        {"Smithsonian Astrophysical Observation", "SAO 142896"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00906743),
        dec: Angle.Degrees(-03.29678881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24457"},
        {"Hipparcos Number", "HIP 18177"},
        {"Smithsonian Astrophysical Observation", "SAO 130797"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.31526032),
        dec: Angle.Degrees(-03.29652124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36338"},
        {"Geneva Identification System", "GEN# +9.80112021"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.18825996),
        dec: Angle.Degrees(-03.29622688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 435.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -794.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136889"},
        {"Hipparcos Number", "HIP 75316"},
        {"Geneva Identification System", "GEN# +1.00136889"},
        {"Smithsonian Astrophysical Observation", "SAO 140498"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.81477483),
        dec: Angle.Degrees(-03.29514425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38726"},
        {"Smithsonian Astrophysical Observation", "SAO 135265"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.92557798),
        dec: Angle.Degrees(-03.29434844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99005"},
        {"Hipparcos Number", "HIP 55609"},
        {"Smithsonian Astrophysical Observation", "SAO 138179"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.89473470),
        dec: Angle.Degrees(-03.28921643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57498"},
        {"Hipparcos Number", "HIP 35649"},
        {"Smithsonian Astrophysical Observation", "SAO 134562"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.34367190),
        dec: Angle.Degrees(-03.28859272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108385"},
        {"Hipparcos Number", "HIP 60757"},
        {"Smithsonian Astrophysical Observation", "SAO 138790"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.79286562),
        dec: Angle.Degrees(-03.28749628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9005"},
        {"Smithsonian Astrophysical Observation", "SAO 129571"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.98560526),
        dec: Angle.Degrees(-03.28647945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87742"},
        {"Hipparcos Number", "HIP 49545"},
        {"Smithsonian Astrophysical Observation", "SAO 137355"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.74559275),
        dec: Angle.Degrees(-03.28400332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61174"},
        {"Hipparcos Number", "HIP 37142"},
        {"Smithsonian Astrophysical Observation", "SAO 134917"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.47719681),
        dec: Angle.Degrees(-03.27781957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44701"},
        {"Hipparcos Number", "HIP 30351"},
        {"Celescope Catalog", "CEL 1208"},
        {"Geneva Identification System", "GEN# +1.00044701"},
        {"Smithsonian Astrophysical Observation", "SAO 133189"},
        {"Wilson Evans Batten Catalogue", "WEB 6039"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.75612646),
        dec: Angle.Degrees(-03.27698260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1420"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.44599594),
        dec: Angle.Degrees(-03.27426689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82997"},
        {"Hipparcos Number", "HIP 47047"},
        {"Fundamental Katalog 5th Edition", "FK5 4851"},
        {"Geneva Identification System", "GEN# +1.00082997"},
        {"Smithsonian Astrophysical Observation", "SAO 136979"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.81896133),
        dec: Angle.Degrees(-03.27138533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67962"},
        {"Hipparcos Number", "HIP 40008"},
        {"Smithsonian Astrophysical Observation", "SAO 135581"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.55752058),
        dec: Angle.Degrees(-03.26864251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136865"},
        {"Hipparcos Number", "HIP 75309"},
        {"Smithsonian Astrophysical Observation", "SAO 140496"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.79486461),
        dec: Angle.Degrees(-03.26759384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38591"},
        {"Hipparcos Number", "HIP 27273"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69911008),
        dec: Angle.Degrees(-03.26465972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174532"},
        {"Hipparcos Number", "HIP 92501"},
        {"Smithsonian Astrophysical Observation", "SAO 142696"},
        {"Wilson Evans Batten Catalogue", "WEB 15993"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.77266353),
        dec: Angle.Degrees(-03.26099582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294369"},
        {"Hipparcos Number", "HIP 27269"},
        {"Smithsonian Astrophysical Observation", "SAO 132526"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69395531),
        dec: Angle.Degrees(-03.26009997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26503"},
        {"Hipparcos Number", "HIP 19565"},
        {"Smithsonian Astrophysical Observation", "SAO 131011"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.86669420),
        dec: Angle.Degrees(-03.25575629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93638"},
        {"Hipparcos Number", "HIP 52857"},
        {"Geneva Identification System", "GEN# +1.00093638"},
        {"Smithsonian Astrophysical Observation", "SAO 137795"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.13411861),
        dec: Angle.Degrees(-03.25533673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30211"},
        {"Hipparcos Number", "HIP 22109"},
        {"Fundamental Katalog 5th Edition", "FK5 176"},
        {"Geneva Identification System", "GEN# +1.00030211"},
        {"Smithsonian Astrophysical Observation", "SAO 131468"},
        {"Wilson Evans Batten Catalogue", "WEB 4249"},
    },
    visualMagnitude: 4.01,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.37558764),
        dec: Angle.Degrees(-03.25462465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152037"},
        {"Hipparcos Number", "HIP 82462"},
        {"Smithsonian Astrophysical Observation", "SAO 141402"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.78266504),
        dec: Angle.Degrees(-03.25443784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37055"},
        {"Hipparcos Number", "HIP 26263"},
        {"Celescope Catalog", "CEL 843"},
        {"Geneva Identification System", "GEN# +1.00037055J"},
        {"Smithsonian Astrophysical Observation", "SAO 132332"},
        {"Wilson Evans Batten Catalogue", "WEB 5149"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.89960025),
        dec: Angle.Degrees(-03.25283754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144623"},
        {"Hipparcos Number", "HIP 78945"},
        {"Smithsonian Astrophysical Observation", "SAO 140965"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.74296663),
        dec: Angle.Degrees(-03.25266188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52432"},
        {"Hipparcos Number", "HIP 33794"},
        {"Geneva Identification System", "GEN# +1.00052432"},
        {"Smithsonian Astrophysical Observation", "SAO 134049"},
        {"Wilson Evans Batten Catalogue", "WEB 6783"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.25815356),
        dec: Angle.Degrees(-03.25253088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62513"},
        {"Hipparcos Number", "HIP 37712"},
        {"Geneva Identification System", "GEN# +1.00062513"},
        {"Smithsonian Astrophysical Observation", "SAO 135042"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04557462),
        dec: Angle.Degrees(-03.25132731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8120"},
        {"Hipparcos Number", "HIP 6283"},
        {"Geneva Identification System", "GEN# +1.00008120"},
        {"Smithsonian Astrophysical Observation", "SAO 129239"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.14405465),
        dec: Angle.Degrees(-03.24700031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113331",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16392 A"},
        {"Henry Draper", "HD 216931"},
        {"Hipparcos Number", "HIP 113331"},
        {"Geneva Identification System", "GEN# +1.00216931J"},
        {"Renson", "Renson 59880"},
        {"Smithsonian Astrophysical Observation", "SAO 146402"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.27850265),
        dec: Angle.Degrees(-03.24525360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102572"},
        {"Hipparcos Number", "HIP 57593"},
        {"Geneva Identification System", "GEN# +1.00102572"},
        {"Smithsonian Astrophysical Observation", "SAO 138418"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.10903613),
        dec: Angle.Degrees(-03.23889270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14905"},
        {"Hipparcos Number", "HIP 11200"},
        {"Smithsonian Astrophysical Observation", "SAO 129874"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.05535666),
        dec: Angle.Degrees(-03.23801370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10967"},
        {"Hipparcos Number", "HIP 8349"},
        {"Smithsonian Astrophysical Observation", "SAO 129504"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91672078),
        dec: Angle.Degrees(-03.23777029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199467"},
        {"Hipparcos Number", "HIP 103447"},
        {"Smithsonian Astrophysical Observation", "SAO 144977"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.37162706),
        dec: Angle.Degrees(-03.23664032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118559"},
        {"Hipparcos Number", "HIP 66482"},
        {"Fundamental Katalog 5th Edition", "FK5 5201"},
        {"Smithsonian Astrophysical Observation", "SAO 139449"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.44564351),
        dec: Angle.Degrees(-03.23595269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106694"},
        {"Hipparcos Number", "HIP 59843"},
        {"Geneva Identification System", "GEN# +1.00106694"},
        {"Smithsonian Astrophysical Observation", "SAO 138685"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.06946566),
        dec: Angle.Degrees(-03.23538224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216242"},
        {"Hipparcos Number", "HIP 112866"},
        {"Smithsonian Astrophysical Observation", "SAO 146356"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.84567084),
        dec: Angle.Degrees(-03.23497222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19630"},
        {"Hipparcos Number", "HIP 14664"},
        {"Smithsonian Astrophysical Observation", "SAO 130309"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.36466369),
        dec: Angle.Degrees(-03.23425802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165610"},
        {"Hipparcos Number", "HIP 88740"},
        {"Geneva Identification System", "GEN# +1.00165610"},
        {"Smithsonian Astrophysical Observation", "SAO 142092"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.73258879),
        dec: Angle.Degrees(-03.23368132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92023",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11636 A"},
        {"Henry Draper", "HD 173437"},
        {"Hipparcos Number", "HIP 92023"},
        {"Smithsonian Astrophysical Observation", "SAO 142588"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.36152896),
        dec: Angle.Degrees(-03.23152135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213122"},
        {"Hipparcos Number", "HIP 111004"},
        {"Geneva Identification System", "GEN# +1.00213122"},
        {"Smithsonian Astrophysical Observation", "SAO 146115"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.33793738),
        dec: Angle.Degrees(-03.22871478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17370"},
        {"Hipparcos Number", "HIP 12999"},
        {"Smithsonian Astrophysical Observation", "SAO 130111"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.78435339),
        dec: Angle.Degrees(-03.22648761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40523",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6707 A"},
        {"Henry Draper", "HD 69351"},
        {"Hipparcos Number", "HIP 40523"},
        {"Smithsonian Astrophysical Observation", "SAO 135709"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.11055707),
        dec: Angle.Degrees(-03.22611876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31297"},
        {"Hipparcos Number", "HIP 22812"},
        {"Smithsonian Astrophysical Observation", "SAO 131587"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.61649922),
        dec: Angle.Degrees(-03.22591308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21202"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.18689815),
        dec: Angle.Degrees(-03.22516527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121627"},
        {"Hipparcos Number", "HIP 68121"},
        {"Smithsonian Astrophysical Observation", "SAO 139644"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.19275593),
        dec: Angle.Degrees(-03.22086334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198729"},
        {"Hipparcos Number", "HIP 103026"},
        {"Smithsonian Astrophysical Observation", "SAO 144892"},
        {"Wilson Evans Batten Catalogue", "WEB 18701"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.08984132),
        dec: Angle.Degrees(-03.22047760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78725"},
        {"Smithsonian Astrophysical Observation", "SAO 140928"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.07105716),
        dec: Angle.Degrees(-03.21885214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113448"},
        {"Hipparcos Number", "HIP 63746"},
        {"Geneva Identification System", "GEN# +1.00113448"},
        {"Smithsonian Astrophysical Observation", "SAO 139130"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.97108230),
        dec: Angle.Degrees(-03.21781354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15032"},
        {"Hipparcos Number", "HIP 11276"},
        {"Smithsonian Astrophysical Observation", "SAO 129891"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.30473056),
        dec: Angle.Degrees(-03.21746004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100428"},
        {"Geneva Identification System", "GEN# -0.00304864"},
        {"Smithsonian Astrophysical Observation", "SAO 144342"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.47827510),
        dec: Angle.Degrees(-03.21714455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36457"},
        {"Hipparcos Number", "HIP 25902"},
        {"Geneva Identification System", "GEN# +1.00036457"},
        {"Smithsonian Astrophysical Observation", "SAO 132217"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.93196721),
        dec: Angle.Degrees(-03.21646378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22879"},
        {"Hipparcos Number", "HIP 17147"},
        {"Cincinnati Publication", "Ci 20 250"},
        {"Geneva Identification System", "GEN# +1.00022879"},
        {"Smithsonian Astrophysical Observation", "SAO 130649"},
        {"Wilson Evans Batten Catalogue", "WEB 3250"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.09025656),
        dec: Angle.Degrees(-03.21646054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 689.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220385"},
        {"Hipparcos Number", "HIP 115464"},
        {"Smithsonian Astrophysical Observation", "SAO 146680"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.84619361),
        dec: Angle.Degrees(-03.21527132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21570"},
        {"Hipparcos Number", "HIP 16198"},
        {"Geneva Identification System", "GEN# +1.00021570"},
        {"Smithsonian Astrophysical Observation", "SAO 130512"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.17014494),
        dec: Angle.Degrees(-03.21482516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16824"},
        {"Hipparcos Number", "HIP 12584"},
        {"Geneva Identification System", "GEN# +1.00016824"},
        {"Smithsonian Astrophysical Observation", "SAO 130061"},
        {"Wilson Evans Batten Catalogue", "WEB 2568"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.45138697),
        dec: Angle.Degrees(-03.21377678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84664"},
        {"Hipparcos Number", "HIP 47974"},
        {"Geneva Identification System", "GEN# +1.00084664"},
        {"Smithsonian Astrophysical Observation", "SAO 137117"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.68004909),
        dec: Angle.Degrees(-03.21150227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209656"},
        {"Hipparcos Number", "HIP 109011"},
        {"Smithsonian Astrophysical Observation", "SAO 145856"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.27183420),
        dec: Angle.Degrees(-03.21029796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28843"},
        {"Hipparcos Number", "HIP 21192"},
        {"Celescope Catalog", "CEL 427"},
        {"Geneva Identification System", "GEN# +1.00028843"},
        {"Renson", "Renson 7380"},
        {"Smithsonian Astrophysical Observation", "SAO 131279"},
        {"Wilson Evans Batten Catalogue", "WEB 4073"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.15642848),
        dec: Angle.Degrees(-03.20950026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39776"},
        {"Hipparcos Number", "HIP 27931"},
        {"Smithsonian Astrophysical Observation", "SAO 132636"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.65145339),
        dec: Angle.Degrees(-03.20883579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13190"},
        {"Hipparcos Number", "HIP 10003"},
        {"Smithsonian Astrophysical Observation", "SAO 129720"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.20314860),
        dec: Angle.Degrees(-03.20568528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15643"},
        {"Hipparcos Number", "HIP 11689"},
        {"Smithsonian Astrophysical Observation", "SAO 129949"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.69724456),
        dec: Angle.Degrees(-03.20444489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76781"},
        {"Smithsonian Astrophysical Observation", "SAO 140693"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.15531213),
        dec: Angle.Degrees(-03.20203531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203347"},
        {"Hipparcos Number", "HIP 105469"},
        {"Smithsonian Astrophysical Observation", "SAO 145329"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.44372008),
        dec: Angle.Degrees(-03.19935297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124931"},
        {"Hipparcos Number", "HIP 69747"},
        {"Geneva Identification System", "GEN# +1.00124931"},
        {"Smithsonian Astrophysical Observation", "SAO 139830"},
        {"Wilson Evans Batten Catalogue", "WEB 12143"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.12574343),
        dec: Angle.Degrees(-03.19622588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82127",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10204 AB"},
        {"Henry Draper", "HD 151307"},
        {"Hipparcos Number", "HIP 82127"},
        {"Renson", "Renson 42793"},
        {"Smithsonian Astrophysical Observation", "SAO 141357"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.65972683),
        dec: Angle.Degrees(-03.19563769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91394",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11520 AB"},
        {"Henry Draper", "HD 172088"},
        {"Hipparcos Number", "HIP 91394"},
        {"Geneva Identification System", "GEN# +1.00172088J"},
        {"Smithsonian Astrophysical Observation", "SAO 142461"},
        {"Wilson Evans Batten Catalogue", "WEB 15707"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.59914723),
        dec: Angle.Degrees(-03.19372155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86829"},
        {"Hipparcos Number", "HIP 49077"},
        {"Smithsonian Astrophysical Observation", "SAO 137290"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.24674314),
        dec: Angle.Degrees(-03.18928356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92929"},
        {"Hipparcos Number", "HIP 52482"},
        {"Smithsonian Astrophysical Observation", "SAO 137754"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.94287738),
        dec: Angle.Degrees(-03.18789650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196575"},
        {"Hipparcos Number", "HIP 101853"},
        {"Smithsonian Astrophysical Observation", "SAO 144648"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58876743),
        dec: Angle.Degrees(-03.18764391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295631"},
        {"Hipparcos Number", "HIP 33004"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.16209710),
        dec: Angle.Degrees(-03.18716963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57609"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.17139451),
        dec: Angle.Degrees(-03.18587479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183565"},
        {"Hipparcos Number", "HIP 95909"},
        {"Smithsonian Astrophysical Observation", "SAO 143476"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.57284623),
        dec: Angle.Degrees(-03.18213310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72430"},
        {"Hipparcos Number", "HIP 41901"},
        {"Renson", "Renson 20047"},
        {"Smithsonian Astrophysical Observation", "SAO 136018"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.15965817),
        dec: Angle.Degrees(-03.17898239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55415"},
        {"Hipparcos Number", "HIP 34848"},
        {"Smithsonian Astrophysical Observation", "SAO 134359"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.17604194),
        dec: Angle.Degrees(-03.17794384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222878"},
        {"Hipparcos Number", "HIP 117112"},
        {"Geneva Identification System", "GEN# +1.00222878"},
        {"Smithsonian Astrophysical Observation", "SAO 146877"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.13542428),
        dec: Angle.Degrees(-03.17536110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51150"},
        {"Hipparcos Number", "HIP 33339"},
        {"Geneva Identification System", "GEN# +1.00051150"},
        {"Smithsonian Astrophysical Observation", "SAO 133908"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.00184446),
        dec: Angle.Degrees(-03.17477328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207888"},
        {"Hipparcos Number", "HIP 107962"},
        {"Smithsonian Astrophysical Observation", "SAO 145716"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.08848698),
        dec: Angle.Degrees(-03.17463312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31021"},
        {"Hipparcos Number", "HIP 22652"},
        {"Smithsonian Astrophysical Observation", "SAO 131557"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.09218637),
        dec: Angle.Degrees(-03.17289144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185442"},
        {"Hipparcos Number", "HIP 96668"},
        {"Geneva Identification System", "GEN# +1.00185442"},
        {"Smithsonian Astrophysical Observation", "SAO 143651"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.80447143),
        dec: Angle.Degrees(-03.17271419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127989"},
        {"Hipparcos Number", "HIP 71270"},
        {"Smithsonian Astrophysical Observation", "SAO 140008"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.63733362),
        dec: Angle.Degrees(-03.17123270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83352"},
        {"Hipparcos Number", "HIP 47242"},
        {"Smithsonian Astrophysical Observation", "SAO 137007"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.44142337),
        dec: Angle.Degrees(-03.17060829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10776"},
        {"Hipparcos Number", "HIP 8196"},
        {"Smithsonian Astrophysical Observation", "SAO 129485"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.33925150),
        dec: Angle.Degrees(-03.16902086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168275"},
        {"Hipparcos Number", "HIP 89757"},
        {"Geneva Identification System", "GEN# +1.00168275"},
        {"Smithsonian Astrophysical Observation", "SAO 142220"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.75480562),
        dec: Angle.Degrees(-03.16856708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133213"},
        {"Hipparcos Number", "HIP 73664"},
        {"Smithsonian Astrophysical Observation", "SAO 140289"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.86872686),
        dec: Angle.Degrees(-03.16827813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39160"},
        {"Hipparcos Number", "HIP 27589"},
        {"Smithsonian Astrophysical Observation", "SAO 132581"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.63376825),
        dec: Angle.Degrees(-03.16799161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30057"},
        {"Hipparcos Number", "HIP 22025"},
        {"Smithsonian Astrophysical Observation", "SAO 131450"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.02715282),
        dec: Angle.Degrees(-03.16657730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82030"},
        {"Hipparcos Number", "HIP 46522"},
        {"Geneva Identification System", "GEN# +1.00082030"},
        {"Renson", "Renson 23320"},
        {"Smithsonian Astrophysical Observation", "SAO 136897"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.32694312),
        dec: Angle.Degrees(-03.16545717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9479 A"},
        {"Henry Draper", "HD 132883"},
        {"Hipparcos Number", "HIP 73518"},
        {"Geneva Identification System", "GEN# +1.00132883A"},
        {"Smithsonian Astrophysical Observation", "SAO 140278"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.39723513),
        dec: Angle.Degrees(-03.16403704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82795"},
        {"Hipparcos Number", "HIP 46953"},
        {"Geneva Identification System", "GEN# +1.00082795"},
        {"Smithsonian Astrophysical Observation", "SAO 136958"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.56069708),
        dec: Angle.Degrees(-03.15761441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164674"},
        {"Hipparcos Number", "HIP 88342"},
        {"Geneva Identification System", "GEN# +1.00164674"},
        {"Smithsonian Astrophysical Observation", "SAO 142043"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.61894061),
        dec: Angle.Degrees(-03.15732448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216983"},
        {"Hipparcos Number", "HIP 113355"},
        {"Geneva Identification System", "GEN# +1.00216983"},
        {"Smithsonian Astrophysical Observation", "SAO 146405"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.35789594),
        dec: Angle.Degrees(-03.15712887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16287"},
        {"Hipparcos Number", "HIP 12158"},
        {"Cincinnati Publication", "Ci 18 338"},
        {"Geneva Identification System", "GEN# +1.00016287"},
        {"Smithsonian Astrophysical Observation", "SAO 130011"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.17322260),
        dec: Angle.Degrees(-03.15627771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 322.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223825"},
        {"Hipparcos Number", "HIP 117761"},
        {"Smithsonian Astrophysical Observation", "SAO 146954"},
        {"Wilson Evans Batten Catalogue", "WEB 20722"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.23133386),
        dec: Angle.Degrees(-03.15537813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60779"},
        {"Hipparcos Number", "HIP 36976"},
        {"Geneva Identification System", "GEN# +1.00060779"},
        {"Smithsonian Astrophysical Observation", "SAO 134875"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.00663856),
        dec: Angle.Degrees(-03.15204314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186610"},
        {"Hipparcos Number", "HIP 97215"},
        {"Geneva Identification System", "GEN# +1.00186610"},
        {"Smithsonian Astrophysical Observation", "SAO 143770"},
        {"Wilson Evans Batten Catalogue", "WEB 17068"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.36382200),
        dec: Angle.Degrees(-03.15183906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71886"},
        {"Hipparcos Number", "HIP 41665"},
        {"Geneva Identification System", "GEN# +1.00071886"},
        {"Smithsonian Astrophysical Observation", "SAO 135975"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.42497514),
        dec: Angle.Degrees(-03.15151373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72614"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.70477873),
        dec: Angle.Degrees(-03.15048408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76334"},
        {"Hipparcos Number", "HIP 43810"},
        {"Smithsonian Astrophysical Observation", "SAO 136405"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.84477606),
        dec: Angle.Degrees(-03.14764140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80296"},
        {"Hipparcos Number", "HIP 45689"},
        {"Smithsonian Astrophysical Observation", "SAO 136749"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.71158579),
        dec: Angle.Degrees(-03.14573694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30899"},
        {"Hipparcos Number", "HIP 22575"},
        {"Geneva Identification System", "GEN# +1.00030899"},
        {"Smithsonian Astrophysical Observation", "SAO 131544"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.87267226),
        dec: Angle.Degrees(-03.14514556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70901"},
        {"Hipparcos Number", "HIP 41192"},
        {"Smithsonian Astrophysical Observation", "SAO 135873"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.08705355),
        dec: Angle.Degrees(-03.14357688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79081"},
        {"Hipparcos Number", "HIP 45134"},
        {"Smithsonian Astrophysical Observation", "SAO 136649"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.94495939),
        dec: Angle.Degrees(-03.14355469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128704"},
        {"Hipparcos Number", "HIP 71591"},
        {"Smithsonian Astrophysical Observation", "SAO 140047"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.62888690),
        dec: Angle.Degrees(-03.14346922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4965"},
        {"Hipparcos Number", "HIP 4021"},
        {"Geneva Identification System", "GEN# +1.00004965"},
        {"Smithsonian Astrophysical Observation", "SAO 128991"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.88616298),
        dec: Angle.Degrees(-03.14310731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132487"},
        {"Hipparcos Number", "HIP 73358"},
        {"Fundamental Katalog 5th Edition", "FK5 5332"},
        {"Geneva Identification System", "GEN# +1.00132487"},
        {"Smithsonian Astrophysical Observation", "SAO 140261"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.87527543),
        dec: Angle.Degrees(-03.14086789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116735"},
        {"Smithsonian Astrophysical Observation", "SAO 146827"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.85413729),
        dec: Angle.Degrees(-03.14008933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116244"},
        {"Smithsonian Astrophysical Observation", "SAO 146772"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.30120272),
        dec: Angle.Degrees(-03.13574766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58385"},
        {"Hipparcos Number", "HIP 36004"},
        {"Geneva Identification System", "GEN# +1.00058385"},
        {"Smithsonian Astrophysical Observation", "SAO 134642"},
        {"Wilson Evans Batten Catalogue", "WEB 7171"},
    },
    visualMagnitude: 8.66,
    bvColour: 2.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.30444410),
        dec: Angle.Degrees(-03.13426625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202836"},
        {"Hipparcos Number", "HIP 105203"},
        {"Smithsonian Astrophysical Observation", "SAO 145284"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.65547746),
        dec: Angle.Degrees(-03.13230869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105089"},
        {"Hipparcos Number", "HIP 59010"},
        {"Fundamental Katalog 5th Edition", "FK5 2967"},
        {"Geneva Identification System", "GEN# +1.00105089"},
        {"Smithsonian Astrophysical Observation", "SAO 138585"},
        {"Wilson Evans Batten Catalogue", "WEB 10510"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.49929442),
        dec: Angle.Degrees(-03.13154264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105342"},
        {"Hipparcos Number", "HIP 59150"},
        {"Smithsonian Astrophysical Observation", "SAO 138599"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.95450983),
        dec: Angle.Degrees(-03.13045342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203458"},
        {"Hipparcos Number", "HIP 105534"},
        {"Geneva Identification System", "GEN# +1.00203458"},
        {"Smithsonian Astrophysical Observation", "SAO 145341"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.61151034),
        dec: Angle.Degrees(-03.13009634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99332"},
        {"Smithsonian Astrophysical Observation", "SAO 144121"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.42136042),
        dec: Angle.Degrees(-03.12890765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76768"},
        {"Hipparcos Number", "HIP 44040"},
        {"Smithsonian Astrophysical Observation", "SAO 136453"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.52438256),
        dec: Angle.Degrees(-03.12863839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105993"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.00544335),
        dec: Angle.Degrees(-03.12797719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24722"},
        {"Hipparcos Number", "HIP 18369"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.90891584),
        dec: Angle.Degrees(-03.12566510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158149"},
        {"Hipparcos Number", "HIP 85449"},
        {"Smithsonian Astrophysical Observation", "SAO 141676"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.93301210),
        dec: Angle.Degrees(-03.12523673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7400 AB"},
        {"Hipparcos Number", "HIP 46552"},
        {"Smithsonian Astrophysical Observation", "SAO 136903"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.40173201),
        dec: Angle.Degrees(-03.12241734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157467"},
        {"Hipparcos Number", "HIP 85090"},
        {"Geneva Identification System", "GEN# +1.00157467"},
        {"Smithsonian Astrophysical Observation", "SAO 141645"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.86266907),
        dec: Angle.Degrees(-03.12204842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24889"},
        {"Hipparcos Number", "HIP 18498"},
        {"Smithsonian Astrophysical Observation", "SAO 130839"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.31526092),
        dec: Angle.Degrees(-03.12159086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63876"},
        {"Hipparcos Number", "HIP 38313"},
        {"Smithsonian Astrophysical Observation", "SAO 135173"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.74683248),
        dec: Angle.Degrees(-03.12098297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14725 A"},
        {"Henry Draper", "HD 201719"},
        {"Hipparcos Number", "HIP 104622"},
        {"Smithsonian Astrophysical Observation", "SAO 145185"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.90195392),
        dec: Angle.Degrees(-03.12019461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172654"},
        {"Hipparcos Number", "HIP 91665"},
        {"Smithsonian Astrophysical Observation", "SAO 142508"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.39349220),
        dec: Angle.Degrees(-03.11848621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5705 A"},
        {"Henry Draper", "HD 52533"},
        {"Hipparcos Number", "HIP 33836"},
        {"Geneva Identification System", "GEN# +1.00052533J"},
        {"Smithsonian Astrophysical Observation", "SAO 134061"},
        {"Wilson Evans Batten Catalogue", "WEB 6793"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.36270620),
        dec: Angle.Degrees(-03.11758015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53851"},
        {"Hipparcos Number", "HIP 34283"},
        {"Geneva Identification System", "GEN# +1.00053851"},
        {"Renson", "Renson 14780"},
        {"Smithsonian Astrophysical Observation", "SAO 134190"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.61526335),
        dec: Angle.Degrees(-03.11573557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10908"},
        {"Hipparcos Number", "HIP 8302"},
        {"Geneva Identification System", "GEN# +1.00010908"},
        {"Smithsonian Astrophysical Observation", "SAO 129496"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.76567396),
        dec: Angle.Degrees(-03.11537538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56719"},
        {"Hipparcos Number", "HIP 35343"},
        {"Smithsonian Astrophysical Observation", "SAO 134481"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.51272705),
        dec: Angle.Degrees(-03.11465426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188042"},
        {"Henry Draper 2", "HD 188041"},
        {"Hipparcos Number", "HIP 97871"},
        {"Fundamental Katalog 5th Edition", "FK5 1519"},
        {"Geneva Identification System", "GEN# +1.00188041"},
        {"Renson", "Renson 51900"},
        {"Smithsonian Astrophysical Observation", "SAO 143883"},
        {"Wilson Evans Batten Catalogue", "WEB 17217"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.32801307),
        dec: Angle.Degrees(-03.11449682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180127"},
        {"Hipparcos Number", "HIP 94638"},
        {"Smithsonian Astrophysical Observation", "SAO 143185"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.86198681),
        dec: Angle.Degrees(-03.11388644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115246"},
        {"Hipparcos Number", "HIP 64721"},
        {"Smithsonian Astrophysical Observation", "SAO 139249"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.98980588),
        dec: Angle.Degrees(-03.11264472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106682"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.12511008),
        dec: Angle.Degrees(-03.11193211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33837",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5705 C"},
        {"Hipparcos Number", "HIP 33837"},
        {"Smithsonian Astrophysical Observation", "SAO 134062"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.36339897),
        dec: Angle.Degrees(-03.11131028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36985"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.02940164),
        dec: Angle.Degrees(-03.11016346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127306"},
        {"Hipparcos Number", "HIP 70947"},
        {"Smithsonian Astrophysical Observation", "SAO 139976"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.67675961),
        dec: Angle.Degrees(-03.10948686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36696"},
        {"Hipparcos Number", "HIP 26061"},
        {"Smithsonian Astrophysical Observation", "SAO 132257"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.37774172),
        dec: Angle.Degrees(-03.10947268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20792"},
        {"Hipparcos Number", "HIP 15594"},
        {"Geneva Identification System", "GEN# +1.00020792"},
        {"Smithsonian Astrophysical Observation", "SAO 130431"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.20765594),
        dec: Angle.Degrees(-03.10841065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295525"},
        {"Hipparcos Number", "HIP 32573"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.95184308),
        dec: Angle.Degrees(-03.10824164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84544"},
        {"Hipparcos Number", "HIP 47916"},
        {"Smithsonian Astrophysical Observation", "SAO 137109"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49171813),
        dec: Angle.Degrees(-03.10796676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174026"},
        {"Hipparcos Number", "HIP 92293"},
        {"Smithsonian Astrophysical Observation", "SAO 142641"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.15796684),
        dec: Angle.Degrees(-03.10682934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168744"},
        {"Hipparcos Number", "HIP 89967"},
        {"Geneva Identification System", "GEN# +1.00168744"},
        {"Smithsonian Astrophysical Observation", "SAO 142242"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.34531395),
        dec: Angle.Degrees(-03.10641600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209778"},
        {"Hipparcos Number", "HIP 109103"},
        {"Smithsonian Astrophysical Observation", "SAO 145865"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.50989731),
        dec: Angle.Degrees(-03.10613316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81558",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10139 A"},
        {"Henry Draper", "HD 150161"},
        {"Hipparcos Number", "HIP 81558"},
        {"Smithsonian Astrophysical Observation", "SAO 141296"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.85028037),
        dec: Angle.Degrees(-03.10576463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14938"},
        {"Hipparcos Number", "HIP 11218"},
        {"Geneva Identification System", "GEN# +1.00014938"},
        {"Smithsonian Astrophysical Observation", "SAO 129879"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.09699867),
        dec: Angle.Degrees(-03.10376850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66024"},
        {"Smithsonian Astrophysical Observation", "SAO 139392"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.04586998),
        dec: Angle.Degrees(-03.10070467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218883"},
        {"Hipparcos Number", "HIP 114510"},
        {"Smithsonian Astrophysical Observation", "SAO 146551"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.90490183),
        dec: Angle.Degrees(-03.10065413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151375"},
        {"Hipparcos Number", "HIP 82160"},
        {"Smithsonian Astrophysical Observation", "SAO 141358"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.76911223),
        dec: Angle.Degrees(-03.09746687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94014"},
        {"Hipparcos Number", "HIP 53035"},
        {"Geneva Identification System", "GEN# +1.00094014"},
        {"Smithsonian Astrophysical Observation", "SAO 137834"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.77266696),
        dec: Angle.Degrees(-03.09264065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141851"},
        {"Hipparcos Number", "HIP 77660"},
        {"Geneva Identification System", "GEN# +1.00141851"},
        {"Smithsonian Astrophysical Observation", "SAO 140801"},
        {"Wilson Evans Batten Catalogue", "WEB 13141"},
    },
    visualMagnitude: 5.09,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.81519764),
        dec: Angle.Degrees(-03.09042957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106116"},
        {"Hipparcos Number", "HIP 59532"},
        {"Cincinnati Publication", "Ci 20 688"},
        {"Geneva Identification System", "GEN# +1.00106116"},
        {"Smithsonian Astrophysical Observation", "SAO 138647"},
        {"Wilson Evans Batten Catalogue", "WEB 10584"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12165417),
        dec: Angle.Degrees(-03.08549214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -607.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 419.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102432"},
        {"Hipparcos Number", "HIP 57519"},
        {"Smithsonian Astrophysical Observation", "SAO 138404"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.83771529),
        dec: Angle.Degrees(-03.08522868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49818"},
        {"Smithsonian Astrophysical Observation", "SAO 137387"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.55103940),
        dec: Angle.Degrees(-03.08503559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151061"},
        {"Hipparcos Number", "HIP 82011"},
        {"Geneva Identification System", "GEN# +1.00151061"},
        {"Smithsonian Astrophysical Observation", "SAO 141344"},
        {"Wilson Evans Batten Catalogue", "WEB 13847"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.29771222),
        dec: Angle.Degrees(-03.08492236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3685"},
        {"Hipparcos Number", "HIP 3115"},
        {"Geneva Identification System", "GEN# +1.00003685"},
        {"Smithsonian Astrophysical Observation", "SAO 128878"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.90931680),
        dec: Angle.Degrees(-03.08305962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35318"},
        {"Hipparcos Number", "HIP 25244"},
        {"Smithsonian Astrophysical Observation", "SAO 132065"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.97203740),
        dec: Angle.Degrees(-03.08296940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146027"},
        {"Hipparcos Number", "HIP 79583"},
        {"Smithsonian Astrophysical Observation", "SAO 141049"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56239713),
        dec: Angle.Degrees(-03.08217742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215338"},
        {"Hipparcos Number", "HIP 112271"},
        {"Smithsonian Astrophysical Observation", "SAO 146286"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.12010344),
        dec: Angle.Degrees(-03.08088462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4136"},
        {"Hipparcos Number", "HIP 3435"},
        {"Smithsonian Astrophysical Observation", "SAO 128922"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.95843507),
        dec: Angle.Degrees(-03.07934237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 717"},
        {"Hipparcos Number", "HIP 931"},
        {"Smithsonian Astrophysical Observation", "SAO 128631"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.89634295),
        dec: Angle.Degrees(-03.07799719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171732"},
        {"Hipparcos Number", "HIP 91226"},
        {"Geneva Identification System", "GEN# +1.00171732"},
        {"Smithsonian Astrophysical Observation", "SAO 142423"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.13792626),
        dec: Angle.Degrees(-03.07766638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35658"},
        {"Hipparcos Number", "HIP 25427"},
        {"Smithsonian Astrophysical Observation", "SAO 132103"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56790005),
        dec: Angle.Degrees(-03.07608065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86579"},
        {"Hipparcos Number", "HIP 48963"},
        {"Geneva Identification System", "GEN# +1.00086579"},
        {"Smithsonian Astrophysical Observation", "SAO 137269"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.82724021),
        dec: Angle.Degrees(-03.07480824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3900 A"},
        {"Henry Draper", "HD 34673"},
        {"Henry Draper 2", "HD 34673A"},
        {"Hipparcos Number", "HIP 24819"},
        {"Cincinnati Publication", "Ci 20 327"},
        {"Geneva Identification System", "GEN# +1.00034673"},
        {"Smithsonian Astrophysical Observation", "SAO 131977"},
        {"Wilson Evans Batten Catalogue", "WEB 4802"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.80103751),
        dec: Angle.Degrees(-03.07414077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 702.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46644"},
        {"Hipparcos Number", "HIP 31344"},
        {"Smithsonian Astrophysical Observation", "SAO 133424"},
        {"Wilson Evans Batten Catalogue", "WEB 6272"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.59026776),
        dec: Angle.Degrees(-03.07410498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40657"},
        {"Hipparcos Number", "HIP 28413"},
        {"Fundamental Katalog 5th Edition", "FK5 2457"},
        {"Geneva Identification System", "GEN# +1.00040657"},
        {"Smithsonian Astrophysical Observation", "SAO 132732"},
        {"Wilson Evans Batten Catalogue", "WEB 5556"},
    },
    visualMagnitude: 4.53,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.01393918),
        dec: Angle.Degrees(-03.07407681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9864 AB"},
        {"Henry Draper", "HD 143144"},
        {"Hipparcos Number", "HIP 78268"},
        {"Smithsonian Astrophysical Observation", "SAO 140875"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.72056467),
        dec: Angle.Degrees(-03.07320583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -241.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41347"},
        {"Hipparcos Number", "HIP 28766"},
        {"Smithsonian Astrophysical Observation", "SAO 132796"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.12365692),
        dec: Angle.Degrees(-03.07151082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58973"},
        {"Hipparcos Number", "HIP 36235"},
        {"Geneva Identification System", "GEN# +1.00058973"},
        {"Smithsonian Astrophysical Observation", "SAO 134698"},
        {"Wilson Evans Batten Catalogue", "WEB 7216"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.92852275),
        dec: Angle.Degrees(-03.07145346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4536 AB"},
        {"Henry Draper", "HD 40134"},
        {"Hipparcos Number", "HIP 28140"},
        {"Smithsonian Astrophysical Observation", "SAO 132678"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.20603444),
        dec: Angle.Degrees(-03.07144740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64965"},
        {"Cincinnati Publication", "Ci 20 770"},
        {"Geneva Identification System", "GEN# +9.80014045"},
        {"Geneva Identification System 2", "GEN# +6.10029438"},
        {"Wilson Evans Batten Catalogue", "WEB 11482"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.73786887),
        dec: Angle.Degrees(-03.07136216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -638.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110123"},
        {"Hipparcos Number", "HIP 61791"},
        {"Smithsonian Astrophysical Observation", "SAO 138898"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.97326774),
        dec: Angle.Degrees(-03.06632370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179192"},
        {"Hipparcos Number", "HIP 94300"},
        {"Smithsonian Astrophysical Observation", "SAO 143116"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.91473632),
        dec: Angle.Degrees(-03.06532988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50301"},
        {"Hipparcos Number", "HIP 32998"},
        {"Smithsonian Astrophysical Observation", "SAO 133809"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.12008474),
        dec: Angle.Degrees(-03.06360322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28571"},
        {"Hipparcos Number", "HIP 20984"},
        {"Geneva Identification System", "GEN# +1.00028571A"},
        {"Smithsonian Astrophysical Observation", "SAO 131251"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.50873159),
        dec: Angle.Degrees(-03.06273589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123713"},
        {"Hipparcos Number", "HIP 69152"},
        {"Smithsonian Astrophysical Observation", "SAO 139760"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.34251879),
        dec: Angle.Degrees(-03.06245617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129818"},
        {"Hipparcos Number", "HIP 72091"},
        {"Smithsonian Astrophysical Observation", "SAO 140111"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.21483410),
        dec: Angle.Degrees(-03.06204447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1936"},
        {"Hipparcos Number", "HIP 1873"},
        {"Geneva Identification System", "GEN# +1.00001936"},
        {"Smithsonian Astrophysical Observation", "SAO 128734"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.91589248),
        dec: Angle.Degrees(-03.05778739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3964"},
        {"Hipparcos Number", "HIP 3311"},
        {"Geneva Identification System", "GEN# +1.00003964"},
        {"Smithsonian Astrophysical Observation", "SAO 128909"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.54039926),
        dec: Angle.Degrees(-03.05603153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39760"},
        {"Hipparcos Number", "HIP 27921"},
        {"Smithsonian Astrophysical Observation", "SAO 132633"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.62461924),
        dec: Angle.Degrees(-03.05557617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159307"},
        {"Hipparcos Number", "HIP 85963"},
        {"Geneva Identification System", "GEN# +1.00159307"},
        {"Smithsonian Astrophysical Observation", "SAO 141736"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.53518904),
        dec: Angle.Degrees(-03.05552898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141657"},
        {"Hipparcos Number", "HIP 77581"},
        {"Smithsonian Astrophysical Observation", "SAO 140794"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.59841530),
        dec: Angle.Degrees(-03.05529178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169417"},
        {"Hipparcos Number", "HIP 90228"},
        {"Smithsonian Astrophysical Observation", "SAO 142286"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.14837713),
        dec: Angle.Degrees(-03.05510124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38410",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6421 AB"},
        {"Henry Draper", "HD 64110"},
        {"Hipparcos Number", "HIP 38410"},
        {"Smithsonian Astrophysical Observation", "SAO 135190"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.03535241),
        dec: Angle.Degrees(-03.05415117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1539"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.80171527),
        dec: Angle.Degrees(-03.05308512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95031"},
        {"Geneva Identification System", "GEN# -0.00304564"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.03547694),
        dec: Angle.Degrees(-03.05186366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94293"},
        {"Hipparcos Number", "HIP 53207"},
        {"Smithsonian Astrophysical Observation", "SAO 137859"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.23707568),
        dec: Angle.Degrees(-03.05116998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178243"},
        {"Hipparcos Number", "HIP 93958"},
        {"Smithsonian Astrophysical Observation", "SAO 143055"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.97209305),
        dec: Angle.Degrees(-03.05075537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5752 AB"},
        {"Henry Draper", "HD 53299"},
        {"Hipparcos Number", "HIP 34110"},
        {"Geneva Identification System", "GEN# +1.00053299J"},
        {"Smithsonian Astrophysical Observation", "SAO 134140"},
        {"Wilson Evans Batten Catalogue", "WEB 6839"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.08717956),
        dec: Angle.Degrees(-03.05062038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117515"},
        {"Hipparcos Number", "HIP 65920"},
        {"Smithsonian Astrophysical Observation", "SAO 139376"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.71429441),
        dec: Angle.Degrees(-03.04991311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74157"},
        {"Hipparcos Number", "HIP 42700"},
        {"Smithsonian Astrophysical Observation", "SAO 136193"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.53903711),
        dec: Angle.Degrees(-03.04989585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38523"},
        {"Smithsonian Astrophysical Observation", "SAO 135216"},
        {"Wilson Evans Batten Catalogue", "WEB 7571"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.33229536),
        dec: Angle.Degrees(-03.04199083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57077"},
        {"Smithsonian Astrophysical Observation", "SAO 138356"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.50928853),
        dec: Angle.Degrees(-03.04194206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32686"},
        {"Hipparcos Number", "HIP 23643"},
        {"Fundamental Katalog 5th Edition", "FK5 2378"},
        {"Geneva Identification System", "GEN# +1.00032686"},
        {"Smithsonian Astrophysical Observation", "SAO 131742"},
        {"Wilson Evans Batten Catalogue", "WEB 4610"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.22719050),
        dec: Angle.Degrees(-03.03967236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295522"},
        {"Hipparcos Number", "HIP 32600"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.01796229),
        dec: Angle.Degrees(-03.03908675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137646"},
        {"Hipparcos Number", "HIP 75651"},
        {"Smithsonian Astrophysical Observation", "SAO 140543"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.83432117),
        dec: Angle.Degrees(-03.03871349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3777 AB"},
        {"Henry Draper", "HD 33766"},
        {"Hipparcos Number", "HIP 24261"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.11318090),
        dec: Angle.Degrees(-03.03722031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186540"},
        {"Hipparcos Number", "HIP 97183"},
        {"Smithsonian Astrophysical Observation", "SAO 143760"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.29023866),
        dec: Angle.Degrees(-03.03550620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79218"},
        {"Hipparcos Number", "HIP 45203"},
        {"Smithsonian Astrophysical Observation", "SAO 136665"},
        {"Wilson Evans Batten Catalogue", "WEB 8620"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.17233257),
        dec: Angle.Degrees(-03.03299818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13728"},
        {"Henry Draper 2", "HD 13729"},
        {"Hipparcos Number", "HIP 10382"},
        {"Geneva Identification System", "GEN# +1.00013728"},
        {"Renson", "Renson 3530"},
        {"Smithsonian Astrophysical Observation", "SAO 129762"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.42587949),
        dec: Angle.Degrees(-03.03197006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133112"},
        {"Hipparcos Number", "HIP 73608"},
        {"Geneva Identification System", "GEN# +1.00133112"},
        {"Renson", "Renson 37810"},
        {"Smithsonian Astrophysical Observation", "SAO 140286"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.68707311),
        dec: Angle.Degrees(-03.03132767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165222"},
        {"Hipparcos Number", "HIP 88574"},
        {"Geneva Identification System", "GEN# +1.00165222"},
        {"Smithsonian Astrophysical Observation", "SAO 142072"},
        {"Wilson Evans Batten Catalogue", "WEB 14999"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.28019098),
        dec: Angle.Degrees(-03.03051102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 570.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -332.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19848"},
        {"Hipparcos Number", "HIP 14823"},
        {"Smithsonian Astrophysical Observation", "SAO 130332"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.84522430),
        dec: Angle.Degrees(-03.03037229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142197"},
        {"Hipparcos Number", "HIP 77816"},
        {"Geneva Identification System", "GEN# +1.00142197"},
        {"Smithsonian Astrophysical Observation", "SAO 140822"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.34465193),
        dec: Angle.Degrees(-03.02911715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221425"},
        {"Hipparcos Number", "HIP 116159"},
        {"Smithsonian Astrophysical Observation", "SAO 146757"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.03597608),
        dec: Angle.Degrees(-03.02834924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65081"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.09859988),
        dec: Angle.Degrees(-03.02782141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224926"},
        {"Hipparcos Number", "HIP 145"},
        {"Geneva Identification System", "GEN# +1.00224926"},
        {"Renson", "Renson 61680"},
        {"Smithsonian Astrophysical Observation", "SAO 147041"},
        {"Wilson Evans Batten Catalogue", "WEB 24"},
    },
    visualMagnitude: 5.13,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.45598912),
        dec: Angle.Degrees(-03.02747891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1063"},
        {"Hipparcos Number", "HIP 1192"},
        {"Smithsonian Astrophysical Observation", "SAO 128661"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.73247890),
        dec: Angle.Degrees(-03.02735083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13868"},
        {"Smithsonian Astrophysical Observation", "SAO 130213"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.65009475),
        dec: Angle.Degrees(-03.02630577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219701"},
        {"Hipparcos Number", "HIP 115037"},
        {"Smithsonian Astrophysical Observation", "SAO 146623"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.48504554),
        dec: Angle.Degrees(-03.02597730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214549"},
        {"Hipparcos Number", "HIP 111818"},
        {"Geneva Identification System", "GEN# +1.00214549"},
        {"Smithsonian Astrophysical Observation", "SAO 146221"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73541715),
        dec: Angle.Degrees(-03.02582434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53056"},
        {"Hipparcos Number", "HIP 34007"},
        {"Geneva Identification System", "GEN# +1.00053056"},
        {"Renson", "Renson 14576"},
        {"Smithsonian Astrophysical Observation", "SAO 134119"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.85581174),
        dec: Angle.Degrees(-03.02534113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147099"},
        {"Hipparcos Number", "HIP 80012"},
        {"Smithsonian Astrophysical Observation", "SAO 141103"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.99503695),
        dec: Angle.Degrees(-03.02492999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162671"},
        {"Hipparcos Number", "HIP 87471"},
        {"Smithsonian Astrophysical Observation", "SAO 141919"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.08050203),
        dec: Angle.Degrees(-03.02428586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33568",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5640 AB"},
        {"Henry Draper", "HD 51756"},
        {"Hipparcos Number", "HIP 33568"},
        {"Geneva Identification System", "GEN# +1.00051756J"},
        {"Smithsonian Astrophysical Observation", "SAO 133972"},
        {"Wilson Evans Batten Catalogue", "WEB 6750"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61734563),
        dec: Angle.Degrees(-03.02371673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107036"},
        {"Hipparcos Number", "HIP 60021"},
        {"Smithsonian Astrophysical Observation", "SAO 138708"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.64348329),
        dec: Angle.Degrees(-03.02225567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45974"},
        {"Hipparcos Number", "HIP 31010"},
        {"Geneva Identification System", "GEN# +1.00045974"},
        {"Smithsonian Astrophysical Observation", "SAO 133347"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.61174071),
        dec: Angle.Degrees(-03.02209283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86535"},
        {"Hipparcos Number", "HIP 48935"},
        {"Geneva Identification System", "GEN# +1.00086535"},
        {"Smithsonian Astrophysical Observation", "SAO 137267"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.75777765),
        dec: Angle.Degrees(-03.02153871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20719"},
        {"Hipparcos Number", "HIP 15533"},
        {"Geneva Identification System", "GEN# +1.00020719"},
        {"Smithsonian Astrophysical Observation", "SAO 130425"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.02833252),
        dec: Angle.Degrees(-03.01847663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221530"},
        {"Hipparcos Number", "HIP 116225"},
        {"Smithsonian Astrophysical Observation", "SAO 146765"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.23098178),
        dec: Angle.Degrees(-03.01666677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153116"},
        {"Hipparcos Number", "HIP 82999"},
        {"Smithsonian Astrophysical Observation", "SAO 141457"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.40994635),
        dec: Angle.Degrees(-03.01665866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106680"},
        {"Hipparcos Number", "HIP 59828"},
        {"Geneva Identification System", "GEN# +1.00106680"},
        {"Smithsonian Astrophysical Observation", "SAO 138683"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.02881263),
        dec: Angle.Degrees(-03.01642036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109568"},
        {"Hipparcos Number", "HIP 61464"},
        {"Smithsonian Astrophysical Observation", "SAO 138864"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.92961175),
        dec: Angle.Degrees(-03.01619681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140539"},
        {"Hipparcos Number", "HIP 77080"},
        {"Smithsonian Astrophysical Observation", "SAO 140727"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.08659817),
        dec: Angle.Degrees(-03.01231798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33208"},
        {"Hipparcos Number", "HIP 23930"},
        {"Geneva Identification System", "GEN# +1.00033208"},
        {"Smithsonian Astrophysical Observation", "SAO 131810"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.13870309),
        dec: Angle.Degrees(-03.00963740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16193"},
        {"Hipparcos Number", "HIP 12094"},
        {"Smithsonian Astrophysical Observation", "SAO 129999"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.97060813),
        dec: Angle.Degrees(-03.00798447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167768"},
        {"Hipparcos Number", "HIP 89587"},
        {"Geneva Identification System", "GEN# +1.00167768"},
        {"Smithsonian Astrophysical Observation", "SAO 142189"},
        {"Wilson Evans Batten Catalogue", "WEB 15255"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.22121187),
        dec: Angle.Degrees(-03.00673658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121250"},
        {"Hipparcos Number", "HIP 67894"},
        {"Smithsonian Astrophysical Observation", "SAO 139611"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.58497856),
        dec: Angle.Degrees(-03.00495037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126846"},
        {"Hipparcos Number", "HIP 70747"},
        {"Fundamental Katalog 5th Edition", "FK5 5279"},
        {"Smithsonian Astrophysical Observation", "SAO 139948"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.01973670),
        dec: Angle.Degrees(-03.00394036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99998"},
        {"Hipparcos Number", "HIP 56127"},
        {"Fundamental Katalog 5th Edition", "FK5 2917"},
        {"Geneva Identification System", "GEN# +1.00099998"},
        {"Smithsonian Astrophysical Observation", "SAO 138238"},
        {"Wilson Evans Batten Catalogue", "WEB 10076"},
    },
    visualMagnitude: 4.77,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.57867422),
        dec: Angle.Degrees(-03.00345887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19973"},
        {"Hipparcos Number", "HIP 14921"},
        {"Smithsonian Astrophysical Observation", "SAO 130348"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.12108572),
        dec: Angle.Degrees(-03.00244571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102274"},
        {"Hipparcos Number", "HIP 57419"},
        {"Geneva Identification System", "GEN# +1.00102274"},
        {"Smithsonian Astrophysical Observation", "SAO 138395"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.58162387),
        dec: Angle.Degrees(-03.00242628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62160"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.09316691),
        dec: Angle.Degrees(-03.00144534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85548"},
        {"Hipparcos Number", "HIP 48434"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.12039668),
        dec: Angle.Degrees(-02.99893034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18976"},
        {"Hipparcos Number", "HIP 14191"},
        {"Smithsonian Astrophysical Observation", "SAO 130255"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.73832224),
        dec: Angle.Degrees(-02.99799214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17808"},
        {"Hipparcos Number", "HIP 13316"},
        {"Smithsonian Astrophysical Observation", "SAO 130145"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.84351812),
        dec: Angle.Degrees(-02.99741896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208176"},
        {"Hipparcos Number", "HIP 108145"},
        {"Smithsonian Astrophysical Observation", "SAO 145736"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.64922785),
        dec: Angle.Degrees(-02.99708854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99604",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13511 AB"},
        {"Henry Draper", "HD 192007"},
        {"Hipparcos Number", "HIP 99604"},
        {"Smithsonian Astrophysical Observation", "SAO 144173"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.19717475),
        dec: Angle.Degrees(-02.99595343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96938"},
        {"Hipparcos Number", "HIP 54546"},
        {"Smithsonian Astrophysical Observation", "SAO 138019"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.43345790),
        dec: Angle.Degrees(-02.99525294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45139"},
        {"Hipparcos Number", "HIP 30575"},
        {"Geneva Identification System", "GEN# +1.00045139"},
        {"Smithsonian Astrophysical Observation", "SAO 133234"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.39484185),
        dec: Angle.Degrees(-02.99144623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142863"},
        {"Hipparcos Number", "HIP 78116"},
        {"Geneva Identification System", "GEN# +1.00142863"},
        {"Smithsonian Astrophysical Observation", "SAO 140850"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.26213588),
        dec: Angle.Degrees(-02.98868524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39863",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6617 A"},
        {"Henry Draper", "HD 67594"},
        {"Hipparcos Number", "HIP 39863"},
        {"Geneva Identification System", "GEN# +1.00067594J"},
        {"Smithsonian Astrophysical Observation", "SAO 135551"},
        {"Wilson Evans Batten Catalogue", "WEB 7771"},
    },
    visualMagnitude: 4.36,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.14857362),
        dec: Angle.Degrees(-02.98377649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32465"},
        {"Hipparcos Number", "HIP 23514"},
        {"Smithsonian Astrophysical Observation", "SAO 131726"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.83999002),
        dec: Angle.Degrees(-02.98242915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66122"},
        {"Hipparcos Number", "HIP 39291"},
        {"Smithsonian Astrophysical Observation", "SAO 135396"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.51119800),
        dec: Angle.Degrees(-02.98055645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166122"},
        {"Hipparcos Number", "HIP 88944"},
        {"Smithsonian Astrophysical Observation", "SAO 142122"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.32436285),
        dec: Angle.Degrees(-02.98042819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224038"},
        {"Hipparcos Number", "HIP 117875"},
        {"Smithsonian Astrophysical Observation", "SAO 146969"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.64493270),
        dec: Angle.Degrees(-02.97960816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293764"},
        {"Hipparcos Number", "HIP 23533"},
        {"Renson", "Renson 8270"},
        {"Smithsonian Astrophysical Observation", "SAO 131727"},
    },
    visualMagnitude: 9.55,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.89406620),
        dec: Angle.Degrees(-02.97942707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21745"},
        {"Hipparcos Number", "HIP 16313"},
        {"Smithsonian Astrophysical Observation", "SAO 130526"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.56148896),
        dec: Angle.Degrees(-02.97936109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57708"},
        {"Hipparcos Number", "HIP 35737"},
        {"Geneva Identification System", "GEN# +1.00057708"},
        {"Smithsonian Astrophysical Observation", "SAO 134585"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.57746520),
        dec: Angle.Degrees(-02.97915985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72565"},
        {"Hipparcos Number", "HIP 41991"},
        {"Smithsonian Astrophysical Observation", "SAO 136035"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.38239140),
        dec: Angle.Degrees(-02.97723017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10826",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mira"},
        {"Common Name 2", "Mira A"},
        {"Aitken", "ADS 1778 A"},
        {"Henry Draper", "HD 14386"},
        {"Hipparcos Number", "HIP 10826"},
        {"Geneva Identification System", "GEN# +1.00014386"},
        {"Smithsonian Astrophysical Observation", "SAO 129825"},
        {"Wilson Evans Batten Catalogue", "WEB 2282"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.83661103),
        dec: Angle.Degrees(-02.97706055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147752"},
        {"Hipparcos Number", "HIP 80315"},
        {"Geneva Identification System", "GEN# +1.00147752"},
        {"Smithsonian Astrophysical Observation", "SAO 141146"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.95806571),
        dec: Angle.Degrees(-02.97476088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96048"},
        {"Hipparcos Number", "HIP 54156"},
        {"Smithsonian Astrophysical Observation", "SAO 137977"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.17629343),
        dec: Angle.Degrees(-02.97221962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124245"},
        {"Hipparcos Number", "HIP 69402"},
        {"Geneva Identification System", "GEN# +1.00124245"},
        {"Smithsonian Astrophysical Observation", "SAO 139786"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.13034969),
        dec: Angle.Degrees(-02.97202526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166439"},
        {"Hipparcos Number", "HIP 89068"},
        {"Smithsonian Astrophysical Observation", "SAO 142137"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.67503201),
        dec: Angle.Degrees(-02.97013329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43193"},
        {"Hipparcos Number", "HIP 29640"},
        {"Smithsonian Astrophysical Observation", "SAO 133009"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.69317213),
        dec: Angle.Degrees(-02.96820539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26502"},
        {"Hipparcos Number", "HIP 19555"},
        {"Smithsonian Astrophysical Observation", "SAO 131010"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.83631133),
        dec: Angle.Degrees(-02.96466981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113366"},
        {"Hipparcos Number", "HIP 63703"},
        {"Smithsonian Astrophysical Observation", "SAO 139125"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.82136942),
        dec: Angle.Degrees(-02.96408513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35079"},
        {"Hipparcos Number", "HIP 25066"},
        {"Celescope Catalog", "CEL 650"},
        {"Fundamental Katalog 5th Edition", "FK5 4491"},
        {"Geneva Identification System", "GEN# +1.00035079"},
        {"Smithsonian Astrophysical Observation", "SAO 132032"},
        {"Wilson Evans Batten Catalogue", "WEB 4861"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.49284825),
        dec: Angle.Degrees(-02.96371123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14627"},
        {"Hipparcos Number", "HIP 10987"},
        {"Geneva Identification System", "GEN# +1.00014627"},
        {"Smithsonian Astrophysical Observation", "SAO 129847"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.40415459),
        dec: Angle.Degrees(-02.96165107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161305"},
        {"Hipparcos Number", "HIP 86864"},
        {"Smithsonian Astrophysical Observation", "SAO 141848"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.21753500),
        dec: Angle.Degrees(-02.96133648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221980"},
        {"Hipparcos Number", "HIP 116520"},
        {"Geneva Identification System", "GEN# +1.00221980"},
        {"Smithsonian Astrophysical Observation", "SAO 146804"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.19016888),
        dec: Angle.Degrees(-02.96118928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222232"},
        {"Hipparcos Number", "HIP 116689"},
        {"Smithsonian Astrophysical Observation", "SAO 146820"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.70682350),
        dec: Angle.Degrees(-02.95991095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10428"},
        {"Hipparcos Number", "HIP 7904"},
        {"Geneva Identification System", "GEN# +1.00010428"},
        {"Smithsonian Astrophysical Observation", "SAO 129452"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.40754313),
        dec: Angle.Degrees(-02.95959819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206528"},
        {"Hipparcos Number", "HIP 107200"},
        {"Smithsonian Astrophysical Observation", "SAO 145610"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.69449909),
        dec: Angle.Degrees(-02.95889113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77429"},
        {"Smithsonian Astrophysical Observation", "SAO 140768"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09806613),
        dec: Angle.Degrees(-02.95778654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132721"},
        {"Hipparcos Number", "HIP 73459"},
        {"Geneva Identification System", "GEN# +1.00132721"},
        {"Smithsonian Astrophysical Observation", "SAO 140268"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.19003275),
        dec: Angle.Degrees(-02.95752428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70829"},
        {"Hipparcos Number", "HIP 41169"},
        {"Smithsonian Astrophysical Observation", "SAO 135864"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.00054066),
        dec: Angle.Degrees(-02.95675673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100085"},
        {"Hipparcos Number", "HIP 56187"},
        {"Smithsonian Astrophysical Observation", "SAO 138244"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.76110192),
        dec: Angle.Degrees(-02.95506514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2850 AB"},
        {"Hipparcos Number", "HIP 18255"},
        {"Geneva Identification System", "GEN# +1.00024555"},
    },
    visualMagnitude: 4.46,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.57286091),
        dec: Angle.Degrees(-02.95473348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30321"},
        {"Hipparcos Number", "HIP 22189"},
        {"Geneva Identification System", "GEN# +1.00030321"},
        {"Smithsonian Astrophysical Observation", "SAO 131481"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.60063178),
        dec: Angle.Degrees(-02.95439840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191318"},
        {"Hipparcos Number", "HIP 99297"},
        {"Smithsonian Astrophysical Observation", "SAO 144114"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.34670319),
        dec: Angle.Degrees(-02.95379332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206916"},
        {"Hipparcos Number", "HIP 107424"},
        {"Geneva Identification System", "GEN# +1.00206916"},
        {"Smithsonian Astrophysical Observation", "SAO 145643"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37066193),
        dec: Angle.Degrees(-02.95009876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30938"},
        {"Hipparcos Number", "HIP 22585"},
        {"Smithsonian Astrophysical Observation", "SAO 131546"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.90483963),
        dec: Angle.Degrees(-02.94980987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44131"},
        {"Hipparcos Number", "HIP 30093"},
        {"Geneva Identification System", "GEN# +1.00044131"},
        {"Smithsonian Astrophysical Observation", "SAO 133118"},
        {"Wilson Evans Batten Catalogue", "WEB 5986"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.99835160),
        dec: Angle.Degrees(-02.94449028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10234"},
        {"Hipparcos Number", "HIP 7769"},
        {"Smithsonian Astrophysical Observation", "SAO 129432"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.00006337),
        dec: Angle.Degrees(-02.94219601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138808"},
        {"Hipparcos Number", "HIP 76249"},
        {"Geneva Identification System", "GEN# +1.00138808"},
        {"Smithsonian Astrophysical Observation", "SAO 140617"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.63005158),
        dec: Angle.Degrees(-02.94169955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18873"},
        {"Hipparcos Number", "HIP 14114"},
        {"Geneva Identification System", "GEN# +1.00018873"},
        {"Smithsonian Astrophysical Observation", "SAO 130248"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.50253991),
        dec: Angle.Degrees(-02.94025000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118313"},
        {"Hipparcos Number", "HIP 66369"},
        {"Geneva Identification System", "GEN# +1.00118313"},
        {"Renson", "Renson 34140"},
        {"Smithsonian Astrophysical Observation", "SAO 139438"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.07770423),
        dec: Angle.Degrees(-02.93883062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72265"},
        {"Smithsonian Astrophysical Observation", "SAO 140132"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.67603069),
        dec: Angle.Degrees(-02.93580173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35220"},
        {"Hipparcos Number", "HIP 25173"},
        {"Smithsonian Astrophysical Observation", "SAO 132044"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.77034977),
        dec: Angle.Degrees(-02.93313701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104303"},
        {"Hipparcos Number", "HIP 58573"},
        {"Smithsonian Astrophysical Observation", "SAO 138529"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.17457477),
        dec: Angle.Degrees(-02.93087381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83471"},
        {"Hipparcos Number", "HIP 47312"},
        {"Geneva Identification System", "GEN# +1.00083471"},
        {"Smithsonian Astrophysical Observation", "SAO 137021"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.61865999),
        dec: Angle.Degrees(-02.92836865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119201"},
        {"Hipparcos Number", "HIP 66833"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.45671131),
        dec: Angle.Degrees(-02.92706915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19247"},
        {"Hipparcos Number", "HIP 14397"},
        {"Smithsonian Astrophysical Observation", "SAO 130280"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.43525913),
        dec: Angle.Degrees(-02.92584149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60174"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.09087067),
        dec: Angle.Degrees(-02.92333170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171917"},
        {"Hipparcos Number", "HIP 91308"},
        {"Smithsonian Astrophysical Observation", "SAO 142439"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.37392015),
        dec: Angle.Degrees(-02.92004179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39290"},
        {"Hipparcos Number", "HIP 27668"},
        {"Smithsonian Astrophysical Observation", "SAO 132592"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86650832),
        dec: Angle.Degrees(-02.91709664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121968"},
        {"Hipparcos Number", "HIP 68297"},
        {"Geneva Identification System", "GEN# +1.00121968"},
    },
    visualMagnitude: 10.26,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.71318934),
        dec: Angle.Degrees(-02.91457572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10956"},
        {"Hipparcos Number", "HIP 8339"},
        {"Smithsonian Astrophysical Observation", "SAO 129501"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.88946015),
        dec: Angle.Degrees(-02.91192687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38272"},
        {"Hipparcos Number", "HIP 27074"},
        {"Smithsonian Astrophysical Observation", "SAO 132501"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.11728061),
        dec: Angle.Degrees(-02.91180071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213428"},
        {"Hipparcos Number", "HIP 111171"},
        {"Fundamental Katalog 5th Edition", "FK5 3802"},
        {"Geneva Identification System", "GEN# +1.00213428"},
        {"Smithsonian Astrophysical Observation", "SAO 146136"},
        {"Wilson Evans Batten Catalogue", "WEB 19893"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.82677055),
        dec: Angle.Degrees(-02.91118194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1679"},
        {"Hipparcos Number", "HIP 1684"},
        {"Smithsonian Astrophysical Observation", "SAO 128707"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.26761523),
        dec: Angle.Degrees(-02.90961019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30257"},
        {"Hipparcos Number", "HIP 22137"},
        {"Geneva Identification System", "GEN# +1.00030257"},
        {"Smithsonian Astrophysical Observation", "SAO 131472"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.45795467),
        dec: Angle.Degrees(-02.90867809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86903"},
        {"Hipparcos Number", "HIP 49126"},
        {"Smithsonian Astrophysical Observation", "SAO 137295"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.40136217),
        dec: Angle.Degrees(-02.90746377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165965"},
        {"Hipparcos Number", "HIP 88878"},
        {"Geneva Identification System", "GEN# +1.00165965"},
        {"Smithsonian Astrophysical Observation", "SAO 142115"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.16348946),
        dec: Angle.Degrees(-02.90743307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19996"},
        {"Hipparcos Number", "HIP 14952"},
        {"Smithsonian Astrophysical Observation", "SAO 130354"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.18282375),
        dec: Angle.Degrees(-02.90718148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46614"},
        {"Hipparcos Number", "HIP 31342"},
        {"Geneva Identification System", "GEN# +1.00046614"},
        {"Renson", "Renson 12476"},
        {"Smithsonian Astrophysical Observation", "SAO 133422"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.58542208),
        dec: Angle.Degrees(-02.90564321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14109"},
        {"Hipparcos Number", "HIP 10630"},
        {"Smithsonian Astrophysical Observation", "SAO 129795"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.20756802),
        dec: Angle.Degrees(-02.90438086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112696"},
        {"Hipparcos Number", "HIP 63328"},
        {"Geneva Identification System", "GEN# +1.00112696"},
        {"Smithsonian Astrophysical Observation", "SAO 139072"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.66651124),
        dec: Angle.Degrees(-02.90360395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14951"},
    },
    visualMagnitude: 9.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)12, 43.5600),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)54, 07.000)
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
    primaryId: "HIP 62733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62733"},
        {"Smithsonian Astrophysical Observation", "SAO 139001"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.82600928),
        dec: Angle.Degrees(-02.90011585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214425"},
        {"Hipparcos Number", "HIP 111741"},
        {"Geneva Identification System", "GEN# +1.00214425"},
        {"Smithsonian Astrophysical Observation", "SAO 146214"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.52785628),
        dec: Angle.Degrees(-02.89853681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98575"},
        {"Hipparcos Number", "HIP 55390"},
        {"Renson", "Renson 28390"},
        {"Smithsonian Astrophysical Observation", "SAO 138142"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.13352132),
        dec: Angle.Degrees(-02.89814248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168723"},
        {"Hipparcos Number", "HIP 89962"},
        {"Cincinnati Publication", "Ci 20 1084"},
        {"Fundamental Katalog 5th Edition", "FK5 688"},
        {"Geneva Identification System", "GEN# +1.00168723"},
        {"Smithsonian Astrophysical Observation", "SAO 142241"},
        {"Wilson Evans Batten Catalogue", "WEB 15365"},
    },
    visualMagnitude: 3.23,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.32883578),
        dec: Angle.Degrees(-02.89712200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -547.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -700.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4279 AB"},
        {"Henry Draper", "HD 37904"},
        {"Hipparcos Number", "HIP 26820"},
        {"Geneva Identification System", "GEN# +1.00037904"},
        {"Smithsonian Astrophysical Observation", "SAO 132465"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.41795123),
        dec: Angle.Degrees(-02.89651493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94722"},
        {"Hipparcos Number", "HIP 53443"},
        {"Smithsonian Astrophysical Observation", "SAO 137894"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.99483361),
        dec: Angle.Degrees(-02.89261668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100996"},
        {"Hipparcos Number", "HIP 56689"},
        {"Smithsonian Astrophysical Observation", "SAO 138305"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.35658234),
        dec: Angle.Degrees(-02.89216006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159545"},
        {"Hipparcos Number", "HIP 86081"},
        {"Geneva Identification System", "GEN# +1.00159545"},
        {"Renson", "Renson 44900"},
        {"Smithsonian Astrophysical Observation", "SAO 141747"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.88048112),
        dec: Angle.Degrees(-02.89171114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71533"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.46296273),
        dec: Angle.Degrees(-02.88731752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35299"},
        {"Smithsonian Astrophysical Observation", "SAO 134470"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.38100077),
        dec: Angle.Degrees(-02.88722035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74648"},
        {"Smithsonian Astrophysical Observation", "SAO 140414"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.79715205),
        dec: Angle.Degrees(-02.88678617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295189"},
        {"Hipparcos Number", "HIP 31628"},
        {"Smithsonian Astrophysical Observation", "SAO 133485"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.27278779),
        dec: Angle.Degrees(-02.88668250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5405",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 943 A"},
        {"Henry Draper", "HD 6865"},
        {"Hipparcos Number", "HIP 5405"},
        {"Smithsonian Astrophysical Observation", "SAO 129144"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.29331536),
        dec: Angle.Degrees(-02.88573328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40521"},
        {"Smithsonian Astrophysical Observation", "SAO 135708"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.10590836),
        dec: Angle.Degrees(-02.88564152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217248"},
        {"Hipparcos Number", "HIP 113523"},
        {"Smithsonian Astrophysical Observation", "SAO 146429"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.87183296),
        dec: Angle.Degrees(-02.88554258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195135"},
        {"Hipparcos Number", "HIP 101101"},
        {"Fundamental Katalog 5th Edition", "FK5 1533"},
        {"Geneva Identification System", "GEN# +1.00195135"},
        {"Smithsonian Astrophysical Observation", "SAO 144495"},
        {"Wilson Evans Batten Catalogue", "WEB 18259"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.41232775),
        dec: Angle.Degrees(-02.88547630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204404"},
        {"Hipparcos Number", "HIP 106015"},
        {"Smithsonian Astrophysical Observation", "SAO 145421"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.09021278),
        dec: Angle.Degrees(-02.88531429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186660"},
        {"Hipparcos Number", "HIP 97244"},
        {"Fundamental Katalog 5th Edition", "FK5 3579"},
        {"Geneva Identification System", "GEN# +1.00186660"},
        {"Smithsonian Astrophysical Observation", "SAO 143776"},
        {"Wilson Evans Batten Catalogue", "WEB 17075"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.46764026),
        dec: Angle.Degrees(-02.88344929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182014"},
        {"Hipparcos Number", "HIP 95257"},
        {"Smithsonian Astrophysical Observation", "SAO 143336"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.70756240),
        dec: Angle.Degrees(-02.88290384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29770",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4882 AB"},
        {"Henry Draper", "HD 43462"},
        {"Hipparcos Number", "HIP 29770"},
        {"Smithsonian Astrophysical Observation", "SAO 133044"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.03167308),
        dec: Angle.Degrees(-02.88217484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59018"},
        {"Hipparcos Number", "HIP 36260"},
        {"Smithsonian Astrophysical Observation", "SAO 134707"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.99891299),
        dec: Angle.Degrees(-02.88214576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65875"},
        {"Hipparcos Number", "HIP 39172"},
        {"Geneva Identification System", "GEN# +1.00065875"},
        {"Smithsonian Astrophysical Observation", "SAO 135368"},
        {"Wilson Evans Batten Catalogue", "WEB 7679"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.18390745),
        dec: Angle.Degrees(-02.88192476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36827"},
        {"Hipparcos Number", "HIP 26120"},
        {"Celescope Catalog", "CEL 795"},
        {"Geneva Identification System", "GEN# +1.00036827"},
        {"Smithsonian Astrophysical Observation", "SAO 132274"},
        {"Wilson Evans Batten Catalogue", "WEB 5086"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.56211160),
        dec: Angle.Degrees(-02.88166059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18760"},
        {"Hipparcos Number", "HIP 14040"},
        {"Geneva Identification System", "GEN# +1.00018760"},
        {"Smithsonian Astrophysical Observation", "SAO 130242"},
        {"Wilson Evans Batten Catalogue", "WEB 2766"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.21198090),
        dec: Angle.Degrees(-02.87864142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202999"},
        {"Hipparcos Number", "HIP 105302"},
        {"Geneva Identification System", "GEN# +1.00202999"},
        {"Smithsonian Astrophysical Observation", "SAO 145297"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.92606990),
        dec: Angle.Degrees(-02.87848361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85430"},
        {"Hipparcos Number", "HIP 48365"},
        {"Geneva Identification System", "GEN# +1.00085430"},
        {"Smithsonian Astrophysical Observation", "SAO 137189"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.90266350),
        dec: Angle.Degrees(-02.87838853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88832"},
        {"Hipparcos Number", "HIP 50187"},
        {"Geneva Identification System", "GEN# +1.00088832"},
        {"Smithsonian Astrophysical Observation", "SAO 137435"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.67741494),
        dec: Angle.Degrees(-02.87583442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159891"},
        {"Hipparcos Number", "HIP 86232"},
        {"Geneva Identification System", "GEN# +1.00159891"},
        {"Smithsonian Astrophysical Observation", "SAO 141766"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.33621745),
        dec: Angle.Degrees(-02.87397592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156317"},
        {"Hipparcos Number", "HIP 84537"},
        {"Smithsonian Astrophysical Observation", "SAO 141587"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.23669877),
        dec: Angle.Degrees(-02.87322877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70309"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.77784057),
        dec: Angle.Degrees(-02.86784085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154697"},
        {"Hipparcos Number", "HIP 83770"},
        {"Geneva Identification System", "GEN# +1.00154697"},
        {"Smithsonian Astrophysical Observation", "SAO 141524"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.80981395),
        dec: Angle.Degrees(-02.86674375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91183"},
        {"Hipparcos Number", "HIP 51535"},
        {"Smithsonian Astrophysical Observation", "SAO 137620"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.89072410),
        dec: Angle.Degrees(-02.86654762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160522"},
        {"Hipparcos Number", "HIP 86494"},
        {"Smithsonian Astrophysical Observation", "SAO 141800"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.12970758),
        dec: Angle.Degrees(-02.86459016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22783"},
        {"Hipparcos Number", "HIP 17072"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.88269078),
        dec: Angle.Degrees(-02.86295311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23827"},
        {"Hipparcos Number", "HIP 17744"},
        {"Smithsonian Astrophysical Observation", "SAO 130730"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.99528444),
        dec: Angle.Degrees(-02.86142225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161605"},
        {"Hipparcos Number", "HIP 86987"},
        {"Smithsonian Astrophysical Observation", "SAO 141861"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.63583680),
        dec: Angle.Degrees(-02.86119965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187620"},
        {"Hipparcos Number", "HIP 97676"},
        {"Geneva Identification System", "GEN# +1.00187620"},
        {"Smithsonian Astrophysical Observation", "SAO 143848"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.75599970),
        dec: Angle.Degrees(-02.86075491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34966"},
        {"Hipparcos Number", "HIP 24997"},
        {"Smithsonian Astrophysical Observation", "SAO 132018"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.29799281),
        dec: Angle.Degrees(-02.85985129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222503"},
        {"Hipparcos Number", "HIP 116859"},
        {"Smithsonian Astrophysical Observation", "SAO 146845"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.30598101),
        dec: Angle.Degrees(-02.85930046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32579"},
        {"Hipparcos Number", "HIP 23567"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.00520607),
        dec: Angle.Degrees(-02.85781421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216600"},
        {"Hipparcos Number", "HIP 113101"},
        {"Smithsonian Astrophysical Observation", "SAO 146380"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.57127746),
        dec: Angle.Degrees(-02.85708700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217320"},
        {"Hipparcos Number", "HIP 113555"},
        {"Smithsonian Astrophysical Observation", "SAO 146435"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.99551775),
        dec: Angle.Degrees(-02.85671012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150433"},
        {"Hipparcos Number", "HIP 81681"},
        {"Cincinnati Publication", "Ci 20 1006"},
        {"Geneva Identification System", "GEN# +1.00150433"},
        {"Smithsonian Astrophysical Observation", "SAO 141309"},
        {"Wilson Evans Batten Catalogue", "WEB 13794"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.28429271),
        dec: Angle.Degrees(-02.85619761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -444.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133332"},
        {"Hipparcos Number", "HIP 73708"},
        {"Geneva Identification System", "GEN# +1.00133332"},
        {"Wilson Evans Batten Catalogue", "WEB 12599"},
    },
    visualMagnitude: 10.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.00215559),
        dec: Angle.Degrees(-02.85142012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8599"},
        {"Hipparcos Number", "HIP 6605"},
        {"Fundamental Katalog 5th Edition", "FK5 1037"},
        {"Geneva Identification System", "GEN# +1.00008599"},
        {"Smithsonian Astrophysical Observation", "SAO 129280"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20281063),
        dec: Angle.Degrees(-02.84852187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75559"},
        {"Hipparcos Number", "HIP 43415"},
        {"Smithsonian Astrophysical Observation", "SAO 136326"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.64765478),
        dec: Angle.Degrees(-02.84814230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23030"},
        {"Hipparcos Number", "HIP 17253"},
        {"Geneva Identification System", "GEN# +1.00023030"},
        {"Smithsonian Astrophysical Observation", "SAO 130669"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.42279032),
        dec: Angle.Degrees(-02.84743897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94539"},
        {"Hipparcos Number", "HIP 53369"},
        {"Geneva Identification System", "GEN# +1.00094539"},
        {"Smithsonian Astrophysical Observation", "SAO 137880"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.70470325),
        dec: Angle.Degrees(-02.84709027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129136"},
        {"Hipparcos Number", "HIP 71778"},
        {"Geneva Identification System", "GEN# +1.00129136"},
        {"Smithsonian Astrophysical Observation", "SAO 140066"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.24687095),
        dec: Angle.Degrees(-02.84491028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224639"},
        {"Hipparcos Number", "HIP 118286"},
        {"Geneva Identification System", "GEN# +1.00224639"},
        {"Smithsonian Astrophysical Observation", "SAO 147015"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.88043173),
        dec: Angle.Degrees(-02.84380029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20619"},
        {"Hipparcos Number", "HIP 15442"},
        {"Geneva Identification System", "GEN# +1.00020619"},
        {"Smithsonian Astrophysical Observation", "SAO 130415"},
        {"Wilson Evans Batten Catalogue", "WEB 2969"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.75727628),
        dec: Angle.Degrees(-02.84294728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110746"},
        {"Hipparcos Number", "HIP 62141"},
        {"Fundamental Katalog 5th Edition", "FK5 5124"},
        {"Geneva Identification System", "GEN# +1.00110746"},
        {"Smithsonian Astrophysical Observation", "SAO 138942"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.04674130),
        dec: Angle.Degrees(-02.84253956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41062"},
        {"Hipparcos Number", "HIP 28630"},
        {"Geneva Identification System", "GEN# +1.00041062"},
        {"Smithsonian Astrophysical Observation", "SAO 132770"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.66655327),
        dec: Angle.Degrees(-02.84057016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120297"},
        {"Hipparcos Number", "HIP 67385"},
        {"Geneva Identification System", "GEN# +1.00120297"},
        {"Smithsonian Astrophysical Observation", "SAO 139564"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.16192501),
        dec: Angle.Degrees(-02.84045381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2612"},
        {"Hipparcos Number", "HIP 2323"},
        {"Smithsonian Astrophysical Observation", "SAO 128787"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.41255565),
        dec: Angle.Degrees(-02.84032635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83535"},
        {"Hipparcos Number", "HIP 47369"},
        {"Smithsonian Astrophysical Observation", "SAO 137026"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.76704122),
        dec: Angle.Degrees(-02.83946797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79378"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.01137265),
        dec: Angle.Degrees(-02.83865440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176287"},
        {"Hipparcos Number", "HIP 93245"},
        {"Smithsonian Astrophysical Observation", "SAO 142890"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.90643796),
        dec: Angle.Degrees(-02.83535267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40961"},
        {"Smithsonian Astrophysical Observation", "SAO 135808"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.39303352),
        dec: Angle.Degrees(-02.83127636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144979"},
        {"Hipparcos Number", "HIP 79099"},
        {"Smithsonian Astrophysical Observation", "SAO 140986"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.18404433),
        dec: Angle.Degrees(-02.83127164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139539"},
        {"Hipparcos Number", "HIP 76620"},
        {"Geneva Identification System", "GEN# +1.00139539"},
        {"Smithsonian Astrophysical Observation", "SAO 140677"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.70727384),
        dec: Angle.Degrees(-02.82880045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158738"},
        {"Hipparcos Number", "HIP 85722"},
        {"Smithsonian Astrophysical Observation", "SAO 141713"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.75935103),
        dec: Angle.Degrees(-02.82673219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75867"},
        {"Smithsonian Astrophysical Observation", "SAO 140567"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.45357273),
        dec: Angle.Degrees(-02.82557313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215794"},
        {"Hipparcos Number", "HIP 112550"},
        {"Renson", "Renson 59610"},
        {"Smithsonian Astrophysical Observation", "SAO 146313"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93587071),
        dec: Angle.Degrees(-02.82556012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37744"},
        {"Hipparcos Number", "HIP 26713"},
        {"Celescope Catalog", "CEL 919"},
        {"Geneva Identification System", "GEN# +1.00037744"},
        {"Smithsonian Astrophysical Observation", "SAO 132441"},
        {"Wilson Evans Batten Catalogue", "WEB 5267"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.15539545),
        dec: Angle.Degrees(-02.82524120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33207"},
        {"Hipparcos Number", "HIP 23929"},
        {"Geneva Identification System", "GEN# +1.00033207"},
        {"Smithsonian Astrophysical Observation", "SAO 131809"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.13351636),
        dec: Angle.Degrees(-02.82446724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175446"},
        {"Hipparcos Number", "HIP 92878"},
        {"Smithsonian Astrophysical Observation", "SAO 142801"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.87112656),
        dec: Angle.Degrees(-02.82360717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5924 AB"},
        {"Henry Draper", "HD 55951"},
        {"Hipparcos Number", "HIP 35060"},
        {"Smithsonian Astrophysical Observation", "SAO 134409"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.75265311),
        dec: Angle.Degrees(-02.82348524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216083"},
        {"Hipparcos Number", "HIP 112742"},
        {"Smithsonian Astrophysical Observation", "SAO 146338"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.48402080),
        dec: Angle.Degrees(-02.82164431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171278"},
        {"Hipparcos Number", "HIP 91012"},
        {"Geneva Identification System", "GEN# +1.00171278"},
        {"Smithsonian Astrophysical Observation", "SAO 142389"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.48455550),
        dec: Angle.Degrees(-02.82064556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224959"},
        {"Hipparcos Number", "HIP 168"},
        {"Geneva Identification System", "GEN# +1.00224959"},
        {"Wilson Evans Batten Catalogue", "WEB 29"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.53352192),
        dec: Angle.Degrees(-02.81984528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178169"},
        {"Hipparcos Number", "HIP 93935"},
        {"Smithsonian Astrophysical Observation", "SAO 143048"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.90748924),
        dec: Angle.Degrees(-02.81875816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117529"},
        {"Hipparcos Number", "HIP 65934"},
        {"Smithsonian Astrophysical Observation", "SAO 139379"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.75505247),
        dec: Angle.Degrees(-02.81671366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22454"},
        {"Hipparcos Number", "HIP 16833"},
        {"Smithsonian Astrophysical Observation", "SAO 130606"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.14198002),
        dec: Angle.Degrees(-02.81646942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35502"},
        {"Hipparcos Number", "HIP 25327"},
        {"Celescope Catalog", "CEL 684"},
        {"Geneva Identification System", "GEN# +1.00035502"},
        {"Renson", "Renson 9120"},
        {"Smithsonian Astrophysical Observation", "SAO 132081"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.25500127),
        dec: Angle.Degrees(-02.81546808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30920"},
        {"Cincinnati Publication", "Ci 20 390"},
        {"Geneva Identification System", "GEN# +6.10010234D"},
        {"Wilson Evans Batten Catalogue", "WEB 6159"},
    },
    visualMagnitude: 11.12,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.34581300),
        dec: Angle.Degrees(-02.81247539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 694.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -618.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123235"},
        {"Hipparcos Number", "HIP 68906"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.61335171),
        dec: Angle.Degrees(-02.81139871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156635"},
        {"Hipparcos Number", "HIP 84696"},
        {"Geneva Identification System", "GEN# +1.00156635"},
        {"Smithsonian Astrophysical Observation", "SAO 141602"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71042739),
        dec: Angle.Degrees(-02.81037371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95824"},
        {"Smithsonian Astrophysical Observation", "SAO 143458"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.35000225),
        dec: Angle.Degrees(-02.80745947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114961"},
        {"Hipparcos Number", "HIP 64569"},
        {"Geneva Identification System", "GEN# +1.00114961"},
        {"Smithsonian Astrophysical Observation", "SAO 139236"},
        {"Wilson Evans Batten Catalogue", "WEB 11419"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.51835457),
        dec: Angle.Degrees(-02.80697766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80824"},
        {"Hipparcos Number", "HIP 45931"},
        {"Smithsonian Astrophysical Observation", "SAO 136786"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.48030075),
        dec: Angle.Degrees(-02.80652943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8720"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.04380989),
        dec: Angle.Degrees(-02.80444349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50890"},
        {"Hipparcos Number", "HIP 33243"},
        {"Geneva Identification System", "GEN# +1.00050890"},
        {"Smithsonian Astrophysical Observation", "SAO 133890"},
        {"Wilson Evans Batten Catalogue", "WEB 6687"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.74550117),
        dec: Angle.Degrees(-02.80358713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136047"},
        {"Hipparcos Number", "HIP 74924"},
        {"Geneva Identification System", "GEN# +1.00136047"},
        {"Smithsonian Astrophysical Observation", "SAO 140448"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.66204022),
        dec: Angle.Degrees(-02.80055132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194454"},
        {"Hipparcos Number", "HIP 100758"},
        {"Geneva Identification System", "GEN# +1.00194454"},
        {"Smithsonian Astrophysical Observation", "SAO 144412"},
        {"Wilson Evans Batten Catalogue", "WEB 18208"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.42719925),
        dec: Angle.Degrees(-02.80028034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39989"},
        {"Hipparcos Number", "HIP 28057"},
        {"Smithsonian Astrophysical Observation", "SAO 132665"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.98966626),
        dec: Angle.Degrees(-02.79992658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152210"},
        {"Hipparcos Number", "HIP 82527"},
        {"Smithsonian Astrophysical Observation", "SAO 141410"},
        {"Wilson Evans Batten Catalogue", "WEB 13935"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.03223650),
        dec: Angle.Degrees(-02.79832665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89114"},
        {"Hipparcos Number", "HIP 50343"},
        {"Geneva Identification System", "GEN# +1.00089114"},
        {"Smithsonian Astrophysical Observation", "SAO 137455"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.19490884),
        dec: Angle.Degrees(-02.79749602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120687"},
        {"Hipparcos Number", "HIP 67599"},
        {"Geneva Identification System", "GEN# +1.00120687"},
        {"Smithsonian Astrophysical Observation", "SAO 139586"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.77204080),
        dec: Angle.Degrees(-02.79675991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16063"},
        {"Hipparcos Number", "HIP 11998"},
        {"Smithsonian Astrophysical Observation", "SAO 129983"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66861200),
        dec: Angle.Degrees(-02.79427007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80796"},
        {"Hipparcos Number", "HIP 45916"},
        {"Geneva Identification System", "GEN# +1.00080796"},
        {"Smithsonian Astrophysical Observation", "SAO 136784"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.43667070),
        dec: Angle.Degrees(-02.79288809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76366"},
        {"Hipparcos Number", "HIP 43837"},
        {"Geneva Identification System", "GEN# +1.00076366"},
        {"Smithsonian Astrophysical Observation", "SAO 136413"},
        {"Wilson Evans Batten Catalogue", "WEB 8433"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.91934187),
        dec: Angle.Degrees(-02.79083501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183630"},
        {"Hipparcos Number", "HIP 95937"},
        {"Fundamental Katalog 5th Edition", "FK5 1509"},
        {"Geneva Identification System", "GEN# +1.00183630"},
        {"Smithsonian Astrophysical Observation", "SAO 143482"},
        {"Wilson Evans Batten Catalogue", "WEB 16801"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.66593316),
        dec: Angle.Degrees(-02.78886135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212695"},
        {"Hipparcos Number", "HIP 110753"},
        {"Geneva Identification System", "GEN# +1.00212695"},
        {"Smithsonian Astrophysical Observation", "SAO 146084"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.56024970),
        dec: Angle.Degrees(-02.78878019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177089"},
        {"Hipparcos Number", "HIP 93554"},
        {"Smithsonian Astrophysical Observation", "SAO 142964"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.82484100),
        dec: Angle.Degrees(-02.78837421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18543"},
        {"Hipparcos Number", "HIP 13874"},
        {"Geneva Identification System", "GEN# +1.00018543"},
        {"Smithsonian Astrophysical Observation", "SAO 130215"},
        {"Wilson Evans Batten Catalogue", "WEB 2740"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.67538999),
        dec: Angle.Degrees(-02.78272383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46226"},
        {"Hipparcos Number", "HIP 31136"},
        {"Smithsonian Astrophysical Observation", "SAO 133371"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.99080933),
        dec: Angle.Degrees(-02.78246023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33962"},
        {"Hipparcos Number", "HIP 24371"},
        {"Geneva Identification System", "GEN# +1.00033962"},
        {"Smithsonian Astrophysical Observation", "SAO 131890"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.43911394),
        dec: Angle.Degrees(-02.78188952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15004"},
        {"Hipparcos Number", "HIP 11261"},
        {"Geneva Identification System", "GEN# +1.00015004"},
        {"Smithsonian Astrophysical Observation", "SAO 129888"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.24328387),
        dec: Angle.Degrees(-02.78001486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67049"},
        {"Hipparcos Number", "HIP 39646"},
        {"Smithsonian Astrophysical Observation", "SAO 135496"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.52719491),
        dec: Angle.Degrees(-02.77987754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56989",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8267 AB"},
        {"Henry Draper", "HD 101515"},
        {"Hipparcos Number", "HIP 56989"},
        {"Smithsonian Astrophysical Observation", "SAO 138347"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.23447178),
        dec: Angle.Degrees(-02.77950364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103720"},
        {"Hipparcos Number", "HIP 58237"},
        {"Geneva Identification System", "GEN# +1.00103720"},
        {"Smithsonian Astrophysical Observation", "SAO 138494"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.17176162),
        dec: Angle.Degrees(-02.77884995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83161"},
        {"Hipparcos Number", "HIP 47150"},
        {"Geneva Identification System", "GEN# +1.00083161"},
        {"Smithsonian Astrophysical Observation", "SAO 136993"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.11558549),
        dec: Angle.Degrees(-02.77786521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90601"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.31115064),
        dec: Angle.Degrees(-02.77626884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208334"},
        {"Hipparcos Number", "HIP 108244"},
        {"Smithsonian Astrophysical Observation", "SAO 145747"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.92847578),
        dec: Angle.Degrees(-02.77622831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107659"},
        {"Hipparcos Number", "HIP 60341"},
        {"Smithsonian Astrophysical Observation", "SAO 138740"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.58628470),
        dec: Angle.Degrees(-02.77616318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36089"},
        {"Hipparcos Number", "HIP 25675"},
        {"Geneva Identification System", "GEN# +1.00036089"},
        {"Renson", "Renson 9320"},
        {"Smithsonian Astrophysical Observation", "SAO 132161"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.25581909),
        dec: Angle.Degrees(-02.77558251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163365"},
        {"Hipparcos Number", "HIP 87779"},
        {"Smithsonian Astrophysical Observation", "SAO 141963"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.97090498),
        dec: Angle.Degrees(-02.77258341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170395"},
        {"Hipparcos Number", "HIP 90602"},
        {"Smithsonian Astrophysical Observation", "SAO 142344"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.31401211),
        dec: Angle.Degrees(-02.77253735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32006"},
        {"Hipparcos Number", "HIP 23241"},
        {"Smithsonian Astrophysical Observation", "SAO 131670"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.00942837),
        dec: Angle.Degrees(-02.77202049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168672"},
        {"Hipparcos Number", "HIP 89944"},
        {"Smithsonian Astrophysical Observation", "SAO 142237"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.28336572),
        dec: Angle.Degrees(-02.77047831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3731"},
        {"Hipparcos Number", "HIP 3152"},
        {"Smithsonian Astrophysical Observation", "SAO 128883"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.02148275),
        dec: Angle.Degrees(-02.76987984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81997"},
        {"Hipparcos Number", "HIP 46509"},
        {"Geneva Identification System", "GEN# +1.00081997A"},
        {"Smithsonian Astrophysical Observation", "SAO 136895"},
        {"Wilson Evans Batten Catalogue", "WEB 8777"},
    },
    visualMagnitude: 4.59,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.28682816),
        dec: Angle.Degrees(-02.76895627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75311"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.79831844),
        dec: Angle.Degrees(-02.76680581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224945"},
        {"Hipparcos Number", "HIP 159"},
        {"Smithsonian Astrophysical Observation", "SAO 147045"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.51081115),
        dec: Angle.Degrees(-02.76616306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116682"},
        {"Smithsonian Astrophysical Observation", "SAO 146819"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.69195882),
        dec: Angle.Degrees(-02.76533501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161355"},
        {"Hipparcos Number", "HIP 86890"},
        {"Smithsonian Astrophysical Observation", "SAO 141853"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.30662644),
        dec: Angle.Degrees(-02.76214356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223252"},
        {"Hipparcos Number", "HIP 117375"},
        {"Fundamental Katalog 5th Edition", "FK5 1623"},
        {"Geneva Identification System", "GEN# +1.00223252"},
        {"Smithsonian Astrophysical Observation", "SAO 146915"},
        {"Wilson Evans Batten Catalogue", "WEB 20676"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.98536110),
        dec: Angle.Degrees(-02.76161103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60046"},
        {"Hipparcos Number", "HIP 36665"},
        {"Smithsonian Astrophysical Observation", "SAO 134814"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.14800915),
        dec: Angle.Degrees(-02.76152629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85933"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.42435915),
        dec: Angle.Degrees(-02.76030561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212381"},
        {"Hipparcos Number", "HIP 110563"},
        {"Smithsonian Astrophysical Observation", "SAO 146066"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.96972713),
        dec: Angle.Degrees(-02.75770268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17975"},
        {"Hipparcos Number", "HIP 13452"},
        {"Smithsonian Astrophysical Observation", "SAO 130163"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.30354565),
        dec: Angle.Degrees(-02.75541551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75685"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92772509),
        dec: Angle.Degrees(-02.75511707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132833"},
        {"Hipparcos Number", "HIP 73497"},
        {"Fundamental Katalog 5th Edition", "FK5 3183"},
        {"Geneva Identification System", "GEN# +1.00132833"},
        {"Smithsonian Astrophysical Observation", "SAO 140276"},
        {"Wilson Evans Batten Catalogue", "WEB 12577"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.33254143),
        dec: Angle.Degrees(-02.75487208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72782"},
        {"Hipparcos Number", "HIP 42081"},
        {"Geneva Identification System", "GEN# +1.00072782"},
        {"Smithsonian Astrophysical Observation", "SAO 136059"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.65680629),
        dec: Angle.Degrees(-02.75453938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208720"},
        {"Hipparcos Number", "HIP 108459"},
        {"Smithsonian Astrophysical Observation", "SAO 145780"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.57779991),
        dec: Angle.Degrees(-02.75352355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202129"},
        {"Hipparcos Number", "HIP 104813"},
        {"Smithsonian Astrophysical Observation", "SAO 145219"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.52266023),
        dec: Angle.Degrees(-02.75164898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48435"},
        {"Hipparcos Number", "HIP 32191"},
        {"Smithsonian Astrophysical Observation", "SAO 133613"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80775395),
        dec: Angle.Degrees(-02.75142218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110394"},
        {"Hipparcos Number", "HIP 61953"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.45830345),
        dec: Angle.Degrees(-02.75053071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156715"},
        {"Hipparcos Number", "HIP 84742"},
        {"Smithsonian Astrophysical Observation", "SAO 141606"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.83873864),
        dec: Angle.Degrees(-02.74913672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53946"},
        {"Hipparcos Number", "HIP 34313"},
        {"Smithsonian Astrophysical Observation", "SAO 134201"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.71004986),
        dec: Angle.Degrees(-02.74794067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211250"},
        {"Hipparcos Number", "HIP 109934"},
        {"Smithsonian Astrophysical Observation", "SAO 145982"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.98912939),
        dec: Angle.Degrees(-02.74497758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6700"},
        {"Hipparcos Number", "HIP 5290"},
        {"Renson", "Renson 1730"},
        {"Smithsonian Astrophysical Observation", "SAO 129135"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.92298024),
        dec: Angle.Degrees(-02.74345797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108644"},
        {"Geneva Identification System", "GEN# -0.00305357"},
        {"Smithsonian Astrophysical Observation", "SAO 145804"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.15166355),
        dec: Angle.Degrees(-02.74076496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106775"},
        {"Hipparcos Number", "HIP 59872"},
        {"Geneva Identification System", "GEN# +1.00106775"},
        {"Smithsonian Astrophysical Observation", "SAO 138691"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.18373536),
        dec: Angle.Degrees(-02.73951857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90882"},
        {"Hipparcos Number", "HIP 51362"},
        {"Fundamental Katalog 5th Edition", "FK5 1270"},
        {"Geneva Identification System", "GEN# +1.00090882"},
        {"Smithsonian Astrophysical Observation", "SAO 137600"},
        {"Wilson Evans Batten Catalogue", "WEB 9378"},
    },
    visualMagnitude: 5.19,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.36971129),
        dec: Angle.Degrees(-02.73904701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71296"},
        {"Hipparcos Number", "HIP 41379"},
        {"Geneva Identification System", "GEN# +1.00071296"},
        {"Smithsonian Astrophysical Observation", "SAO 135917"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.62082138),
        dec: Angle.Degrees(-02.73831145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104373"},
        {"Smithsonian Astrophysical Observation", "SAO 145136"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.16636322),
        dec: Angle.Degrees(-02.73673057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204156"},
        {"Hipparcos Number", "HIP 105899"},
        {"Smithsonian Astrophysical Observation", "SAO 145401"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.71493881),
        dec: Angle.Degrees(-02.73623402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3031"},
        {"Hipparcos Number", "HIP 2654"},
        {"Geneva Identification System", "GEN# +1.00003031"},
        {"Smithsonian Astrophysical Observation", "SAO 128824"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.40869883),
        dec: Angle.Degrees(-02.73521576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210843"},
        {"Hipparcos Number", "HIP 109707"},
        {"Smithsonian Astrophysical Observation", "SAO 145945"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.32821748),
        dec: Angle.Degrees(-02.73368403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36032"},
        {"Hipparcos Number", "HIP 25643"},
        {"Geneva Identification System", "GEN# +1.00036032"},
        {"Smithsonian Astrophysical Observation", "SAO 132150"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.16820504),
        dec: Angle.Degrees(-02.73367865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66350"},
        {"Hipparcos Number", "HIP 39375"},
        {"Geneva Identification System", "GEN# +1.00066350"},
        {"Renson", "Renson 18320"},
        {"Smithsonian Astrophysical Observation", "SAO 135418"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.75508737),
        dec: Angle.Degrees(-02.73049568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5506"},
        {"Hipparcos Number", "HIP 4439"},
        {"Geneva Identification System", "GEN# +1.00005506"},
        {"Smithsonian Astrophysical Observation", "SAO 129044"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.19528285),
        dec: Angle.Degrees(-02.72981211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99835"},
        {"Smithsonian Astrophysical Observation", "SAO 144220"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84317323),
        dec: Angle.Degrees(-02.72964818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114495"},
        {"Hipparcos Number", "HIP 64318"},
        {"Geneva Identification System", "GEN# +1.00114495"},
        {"Smithsonian Astrophysical Observation", "SAO 139201"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.74077241),
        dec: Angle.Degrees(-02.72899858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166642"},
        {"Hipparcos Number", "HIP 89148"},
        {"Smithsonian Astrophysical Observation", "SAO 142145"},
        {"Wilson Evans Batten Catalogue", "WEB 15141"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.92085148),
        dec: Angle.Degrees(-02.72617656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9357"},
        {"Hipparcos Number", "HIP 7144"},
        {"Smithsonian Astrophysical Observation", "SAO 129354"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.02258611),
        dec: Angle.Degrees(-02.72372228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138776"},
        {"Hipparcos Number", "HIP 76228"},
        {"Smithsonian Astrophysical Observation", "SAO 140612"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.57072680),
        dec: Angle.Degrees(-02.72371726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15276"},
        {"Hipparcos Number", "HIP 11435"},
        {"Smithsonian Astrophysical Observation", "SAO 129914"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.86933668),
        dec: Angle.Degrees(-02.72202670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32264"},
        {"Hipparcos Number", "HIP 23386"},
        {"Smithsonian Astrophysical Observation", "SAO 131704"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.41068420),
        dec: Angle.Degrees(-02.72066861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7544"},
        {"Smithsonian Astrophysical Observation", "SAO 129405"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.29709410),
        dec: Angle.Degrees(-02.71836206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96796"},
        {"Hipparcos Number", "HIP 54489"},
        {"Smithsonian Astrophysical Observation", "SAO 138011"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.22298561),
        dec: Angle.Degrees(-02.71793103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37806"},
        {"Hipparcos Number", "HIP 26752"},
        {"Geneva Identification System", "GEN# +1.00037806"},
        {"Smithsonian Astrophysical Observation", "SAO 132452"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.25954349),
        dec: Angle.Degrees(-02.71686724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197915"},
        {"Hipparcos Number", "HIP 102547"},
        {"Smithsonian Astrophysical Observation", "SAO 144801"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.70927943),
        dec: Angle.Degrees(-02.71481021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84971"},
        {"Hipparcos Number", "HIP 48128"},
        {"Geneva Identification System", "GEN# +1.00084971"},
        {"Smithsonian Astrophysical Observation", "SAO 137150"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.18534913),
        dec: Angle.Degrees(-02.71357347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90652"},
        {"Hipparcos Number", "HIP 51240"},
        {"Geneva Identification System", "GEN# +1.00090652"},
        {"Smithsonian Astrophysical Observation", "SAO 137582"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.98555067),
        dec: Angle.Degrees(-02.71289698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12667"},
        {"Hipparcos Number", "HIP 9641"},
        {"Geneva Identification System", "GEN# +1.00012667"},
        {"Smithsonian Astrophysical Observation", "SAO 129670"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.97737635),
        dec: Angle.Degrees(-02.71242043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215708"},
        {"Hipparcos Number", "HIP 112494"},
        {"Geneva Identification System", "GEN# +1.00215708"},
        {"Smithsonian Astrophysical Observation", "SAO 146307"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.80281616),
        dec: Angle.Degrees(-02.70964189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110804"},
        {"Hipparcos Number", "HIP 62185"},
        {"Smithsonian Astrophysical Observation", "SAO 138946"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.16797283),
        dec: Angle.Degrees(-02.70777641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112943"},
        {"Hipparcos Number", "HIP 63467"},
        {"Cincinnati Publication", "Ci 20 753"},
        {"Geneva Identification System", "GEN# +1.00112943"},
        {"Smithsonian Astrophysical Observation", "SAO 139091"},
        {"Wilson Evans Batten Catalogue", "WEB 11228"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.07277382),
        dec: Angle.Degrees(-02.70480346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -804.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54490"},
        {"Hipparcos Number", "HIP 34494"},
        {"Smithsonian Astrophysical Observation", "SAO 134251"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.21254344),
        dec: Angle.Degrees(-02.70358819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295151"},
        {"Hipparcos Number", "HIP 31351"},
        {"Smithsonian Astrophysical Observation", "SAO 133426"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.61274680),
        dec: Angle.Degrees(-02.70290706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185092"},
        {"Hipparcos Number", "HIP 96541"},
        {"Fundamental Katalog 5th Edition", "FK5 5724"},
        {"Smithsonian Astrophysical Observation", "SAO 143613"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.40217485),
        dec: Angle.Degrees(-02.69899704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105900"},
        {"Hipparcos Number", "HIP 59423"},
        {"Geneva Identification System", "GEN# +1.00105900"},
        {"Smithsonian Astrophysical Observation", "SAO 138637"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84176728),
        dec: Angle.Degrees(-02.69893600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36352"},
        {"Hipparcos Number", "HIP 25833"},
        {"Geneva Identification System", "GEN# +1.00036352"},
        {"Smithsonian Astrophysical Observation", "SAO 132201"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.73306642),
        dec: Angle.Degrees(-02.69889407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42776",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6949 AB"},
        {"Henry Draper", "HD 74262"},
        {"Hipparcos Number", "HIP 42776"},
        {"Smithsonian Astrophysical Observation", "SAO 136206"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.73825907),
        dec: Angle.Degrees(-02.69630410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172507"},
        {"Hipparcos Number", "HIP 91587"},
        {"Geneva Identification System", "GEN# +1.00172507"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.17512663),
        dec: Angle.Degrees(-02.69611788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101541"},
        {"Smithsonian Astrophysical Observation", "SAO 144586"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.68163700),
        dec: Angle.Degrees(-02.69551185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102810"},
        {"Smithsonian Astrophysical Observation", "SAO 144847"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.42133352),
        dec: Angle.Degrees(-02.69521064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50748"},
        {"Smithsonian Astrophysical Observation", "SAO 137514"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.43214742),
        dec: Angle.Degrees(-02.69269687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38255"},
        {"Smithsonian Astrophysical Observation", "SAO 135156"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.54615013),
        dec: Angle.Degrees(-02.69201745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126700"},
        {"Hipparcos Number", "HIP 70665"},
        {"Smithsonian Astrophysical Observation", "SAO 139940"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.80806482),
        dec: Angle.Degrees(-02.69093322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57472"},
        {"Hipparcos Number", "HIP 35634"},
        {"Smithsonian Astrophysical Observation", "SAO 134560"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.30294266),
        dec: Angle.Degrees(-02.68804461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3023 A"},
        {"Henry Draper", "HD 26215"},
        {"Hipparcos Number", "HIP 19342"},
        {"Smithsonian Astrophysical Observation", "SAO 130978"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.16302204),
        dec: Angle.Degrees(-02.68736689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7688"},
        {"Hipparcos Number", "HIP 5958"},
        {"Smithsonian Astrophysical Observation", "SAO 129206"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.16342555),
        dec: Angle.Degrees(-02.68637180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217605"},
        {"Hipparcos Number", "HIP 113727"},
        {"Smithsonian Astrophysical Observation", "SAO 146458"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.48084087),
        dec: Angle.Degrees(-02.68602462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87927"},
        {"Smithsonian Astrophysical Observation", "SAO 141985"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.42530365),
        dec: Angle.Degrees(-02.68432560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62198"},
        {"Hipparcos Number", "HIP 37569"},
        {"Geneva Identification System", "GEN# +1.00062198"},
        {"Smithsonian Astrophysical Observation", "SAO 135014"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66089091),
        dec: Angle.Degrees(-02.68411870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19338",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3023 B"},
        {"Hipparcos Number", "HIP 19338"},
        {"Smithsonian Astrophysical Observation", "SAO 130977"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.15605467),
        dec: Angle.Degrees(-02.68370644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215112"},
        {"Hipparcos Number", "HIP 112149"},
        {"Geneva Identification System", "GEN# +1.00215112"},
        {"Smithsonian Astrophysical Observation", "SAO 146268"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74025642),
        dec: Angle.Degrees(-02.68254839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5261"},
        {"Hipparcos Number", "HIP 4260"},
        {"Geneva Identification System", "GEN# +1.00005261"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.58485085),
        dec: Angle.Degrees(-02.68032780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114125"},
        {"Hipparcos Number", "HIP 64120"},
        {"Geneva Identification System", "GEN# +1.00114125"},
        {"Renson", "Renson 33030"},
        {"Smithsonian Astrophysical Observation", "SAO 139174"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.12470167),
        dec: Angle.Degrees(-02.67904969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69289",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9140 AB"},
        {"Henry Draper", "HD 124002"},
        {"Hipparcos Number", "HIP 69289"},
        {"Smithsonian Astrophysical Observation", "SAO 139774"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.74375063),
        dec: Angle.Degrees(-02.67447236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63661"},
        {"Geneva Identification System", "GEN# +9.80014025"},
    },
    visualMagnitude: 11.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.71478995),
        dec: Angle.Degrees(-02.67404734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -314.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30198"},
        {"Hipparcos Number", "HIP 22100"},
        {"Geneva Identification System", "GEN# +1.00030198"},
        {"Smithsonian Astrophysical Observation", "SAO 131467"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.33276826),
        dec: Angle.Degrees(-02.67360210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83569"},
        {"Hipparcos Number", "HIP 47392"},
        {"Smithsonian Astrophysical Observation", "SAO 137030"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.84097609),
        dec: Angle.Degrees(-02.67066812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180359"},
        {"Hipparcos Number", "HIP 94707"},
        {"Geneva Identification System", "GEN# +1.00180359"},
        {"Smithsonian Astrophysical Observation", "SAO 143204"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.06694693),
        dec: Angle.Degrees(-02.66572199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174814"},
        {"Hipparcos Number", "HIP 92634"},
        {"Smithsonian Astrophysical Observation", "SAO 142735"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11756022),
        dec: Angle.Degrees(-02.66428460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149756"},
        {"Hipparcos Number", "HIP 81365"},
        {"Smithsonian Astrophysical Observation", "SAO 141277"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.25061236),
        dec: Angle.Degrees(-02.66269547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112326",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16235 A"},
        {"Hipparcos Number", "HIP 112326"},
        {"Smithsonian Astrophysical Observation", "SAO 146295"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.27022210),
        dec: Angle.Degrees(-02.66173313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81391"},
        {"Hipparcos Number", "HIP 46209"},
        {"Smithsonian Astrophysical Observation", "SAO 136825"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.32071913),
        dec: Angle.Degrees(-02.66039676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45515"},
        {"Hipparcos Number", "HIP 30754"},
        {"Celescope Catalog", "CEL 1248"},
        {"Geneva Identification System", "GEN# +1.00045515"},
        {"Smithsonian Astrophysical Observation", "SAO 133280"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.93918017),
        dec: Angle.Degrees(-02.65980363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112325",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16235 BC"},
        {"Henry Draper", "HD 215415"},
        {"Hipparcos Number", "HIP 112325"},
        {"Smithsonian Astrophysical Observation", "SAO 146293"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.26847060),
        dec: Angle.Degrees(-02.65644157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122303"},
        {"Hipparcos Number", "HIP 68469"},
        {"Geneva Identification System", "GEN# +1.00122303"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.26529157),
        dec: Angle.Degrees(-02.65632082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -824.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 599.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196870"},
        {"Hipparcos Number", "HIP 101998"},
        {"Smithsonian Astrophysical Observation", "SAO 144681"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05217080),
        dec: Angle.Degrees(-02.65491098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151900"},
        {"Hipparcos Number", "HIP 82405"},
        {"Geneva Identification System", "GEN# +1.00151900"},
        {"Smithsonian Astrophysical Observation", "SAO 141393"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.59270693),
        dec: Angle.Degrees(-02.65424668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221001"},
        {"Hipparcos Number", "HIP 115862"},
        {"Smithsonian Astrophysical Observation", "SAO 146720"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.11263978),
        dec: Angle.Degrees(-02.65354492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18591",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2909 BC"},
        {"Hipparcos Number", "HIP 18591"},
    },
    visualMagnitude: 10.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.67458751),
        dec: Angle.Degrees(-02.65187807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18583",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2909 A"},
        {"Henry Draper", "HD 25040"},
        {"Hipparcos Number", "HIP 18583"},
        {"Geneva Identification System", "GEN# +1.00025040"},
        {"Smithsonian Astrophysical Observation", "SAO 130858"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.65843073),
        dec: Angle.Degrees(-02.65142329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144764"},
        {"Hipparcos Number", "HIP 79003"},
        {"Smithsonian Astrophysical Observation", "SAO 140971"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90061006),
        dec: Angle.Degrees(-02.65023059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37525"},
        {"Henry Draper 2", "HD 37525Ab"},
        {"Hipparcos Number", "HIP 26579"},
        {"Celescope Catalog", "CEL 896"},
        {"Geneva Identification System", "GEN# +1.00037525"},
        {"Renson", "Renson 10110"},
        {"Smithsonian Astrophysical Observation", "SAO 132412"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.75621698),
        dec: Angle.Degrees(-02.64898798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29405"},
        {"Hipparcos Number", "HIP 21557"},
        {"Smithsonian Astrophysical Observation", "SAO 131361"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.42842799),
        dec: Angle.Degrees(-02.64644583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40260"},
        {"Hipparcos Number", "HIP 28203"},
        {"Geneva Identification System", "GEN# +1.00040260"},
        {"Smithsonian Astrophysical Observation", "SAO 132689"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.39165525),
        dec: Angle.Degrees(-02.64519273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5105"},
        {"Hipparcos Number", "HIP 4130"},
        {"Smithsonian Astrophysical Observation", "SAO 129006"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.22307204),
        dec: Angle.Degrees(-02.64491757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127855"},
        {"Hipparcos Number", "HIP 71210"},
        {"Smithsonian Astrophysical Observation", "SAO 139998"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.44483102),
        dec: Angle.Degrees(-02.64044879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179079"},
        {"Hipparcos Number", "HIP 94256"},
        {"Geneva Identification System", "GEN# +1.00179079"},
        {"Smithsonian Astrophysical Observation", "SAO 143111"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.79127953),
        dec: Angle.Degrees(-02.63816763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11351"},
        {"Hipparcos Number", "HIP 8661"},
        {"Geneva Identification System", "GEN# +1.00011351"},
        {"Smithsonian Astrophysical Observation", "SAO 129537"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90140442),
        dec: Angle.Degrees(-02.63777825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220859"},
        {"Hipparcos Number", "HIP 115767"},
        {"Cincinnati Publication", "Ci 18 3076"},
        {"Smithsonian Astrophysical Observation", "SAO 146712"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.81068188),
        dec: Angle.Degrees(-02.63670929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95740"},
        {"Hipparcos Number", "HIP 54013"},
        {"Geneva Identification System", "GEN# +1.00095740"},
        {"Smithsonian Astrophysical Observation", "SAO 137957"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.74150985),
        dec: Angle.Degrees(-02.63533961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208333"},
        {"Hipparcos Number", "HIP 108245"},
        {"Smithsonian Astrophysical Observation", "SAO 145748"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.93023645),
        dec: Angle.Degrees(-02.63500828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16613 AB"},
        {"Henry Draper", "HD 219200"},
        {"Hipparcos Number", "HIP 114700"},
        {"Renson", "Renson 60250"},
        {"Smithsonian Astrophysical Observation", "SAO 146580"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.52663909),
        dec: Angle.Degrees(-02.63493253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139993"},
        {"Hipparcos Number", "HIP 76842"},
        {"Smithsonian Astrophysical Observation", "SAO 140700"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.35259976),
        dec: Angle.Degrees(-02.63487117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70167"},
        {"Hipparcos Number", "HIP 40874"},
        {"Smithsonian Astrophysical Observation", "SAO 135788"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09847141),
        dec: Angle.Degrees(-02.63320267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150875"},
        {"Hipparcos Number", "HIP 81920"},
        {"Geneva Identification System", "GEN# +1.00150875"},
        {"Smithsonian Astrophysical Observation", "SAO 141333"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.98625426),
        dec: Angle.Degrees(-02.63086640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27498"},
        {"Hipparcos Number", "HIP 20243"},
        {"Geneva Identification System", "GEN# +1.00027498"},
        {"Smithsonian Astrophysical Observation", "SAO 131122"},
        {"Wilson Evans Batten Catalogue", "WEB 3864"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.06370360),
        dec: Angle.Degrees(-02.62854176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33917"},
        {"Hipparcos Number", "HIP 24342"},
        {"Renson", "Renson 8650"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.36181727),
        dec: Angle.Degrees(-02.62702576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216401"},
        {"Hipparcos Number", "HIP 112967"},
        {"Geneva Identification System", "GEN# +1.00216401"},
        {"Smithsonian Astrophysical Observation", "SAO 146363"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.16678771),
        dec: Angle.Degrees(-02.62588155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167261"},
        {"Hipparcos Number", "HIP 89387"},
        {"Smithsonian Astrophysical Observation", "SAO 142174"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.61284405),
        dec: Angle.Degrees(-02.62558557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10315"},
        {"Hipparcos Number", "HIP 7832"},
        {"Geneva Identification System", "GEN# +1.00010315"},
        {"Smithsonian Astrophysical Observation", "SAO 129442"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.19315221),
        dec: Angle.Degrees(-02.62177612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90184"},
        {"Hipparcos Number", "HIP 50963"},
        {"Smithsonian Astrophysical Observation", "SAO 137543"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.14742998),
        dec: Angle.Degrees(-02.62031672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85845"},
        {"Hipparcos Number", "HIP 48588"},
        {"Smithsonian Astrophysical Observation", "SAO 137216"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.63718651),
        dec: Angle.Degrees(-02.61755631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141072"},
        {"Hipparcos Number", "HIP 77332"},
        {"Smithsonian Astrophysical Observation", "SAO 140759"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.81813942),
        dec: Angle.Degrees(-02.61713706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224333"},
        {"Hipparcos Number", "HIP 118073"},
        {"Smithsonian Astrophysical Observation", "SAO 146993"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.26793872),
        dec: Angle.Degrees(-02.61434380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96673"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.81079525),
        dec: Angle.Degrees(-02.61206202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204391"},
        {"Hipparcos Number", "HIP 106011"},
        {"Smithsonian Astrophysical Observation", "SAO 145420"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.07843571),
        dec: Angle.Degrees(-02.61195395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99030"},
        {"Hipparcos Number", "HIP 55632"},
        {"Smithsonian Astrophysical Observation", "SAO 138180"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.95218835),
        dec: Angle.Degrees(-02.60758201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68201"},
        {"Hipparcos Number", "HIP 40087"},
        {"Geneva Identification System", "GEN# +1.00068201"},
        {"Smithsonian Astrophysical Observation", "SAO 135606"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.82548086),
        dec: Angle.Degrees(-02.60488961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167279"},
        {"Hipparcos Number", "HIP 89397"},
        {"Geneva Identification System", "GEN# +1.00167279"},
        {"Smithsonian Astrophysical Observation", "SAO 142176"},
    },
    visualMagnitude: 7.38,
    bvColour: 2.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.65300917),
        dec: Angle.Degrees(-02.60280359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89087"},
        {"Hipparcos Number", "HIP 50322"},
        {"Smithsonian Astrophysical Observation", "SAO 137454"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.14436908),
        dec: Angle.Degrees(-02.60192090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6977 AB"},
        {"Henry Draper", "HD 74688"},
        {"Hipparcos Number", "HIP 42951"},
        {"Geneva Identification System", "GEN# +1.00074688J"},
        {"Smithsonian Astrophysical Observation", "SAO 136243"},
        {"Wilson Evans Batten Catalogue", "WEB 8302"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.33652137),
        dec: Angle.Degrees(-02.60102981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191317"},
        {"Hipparcos Number", "HIP 99289"},
        {"Geneva Identification System", "GEN# +1.00191317"},
        {"Smithsonian Astrophysical Observation", "SAO 144112"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.33424569),
        dec: Angle.Degrees(-02.60057427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26549",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4241 AB"},
        {"Henry Draper", "HD 37468"},
        {"Hipparcos Number", "HIP 26549"},
        {"Celescope Catalog", "CEL 890"},
        {"Geneva Identification System", "GEN# +1.00037468J"},
        {"Smithsonian Astrophysical Observation", "SAO 132406"},
        {"Wilson Evans Batten Catalogue", "WEB 5232"},
    },
    visualMagnitude: 3.77,
    bvColour: -0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.68652211),
        dec: Angle.Degrees(-02.60006791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78143"},
        {"Hipparcos Number", "HIP 44696"},
        {"Geneva Identification System", "GEN# +1.00078143"},
        {"Smithsonian Astrophysical Observation", "SAO 136580"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.62414186),
        dec: Angle.Degrees(-02.59976036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26551",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4241 D"},
        {"Henry Draper", "HD 37468D"},
        {"Hipparcos Number", "HIP 26551"},
        {"Geneva Identification System", "GEN# +1.00037468D"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.69010095),
        dec: Angle.Degrees(-02.59969173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6232 AB"},
        {"Henry Draper", "HD 61151"},
        {"Hipparcos Number", "HIP 37134"},
        {"Smithsonian Astrophysical Observation", "SAO 134913"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.45398369),
        dec: Angle.Degrees(-02.59700063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195381"},
        {"Hipparcos Number", "HIP 101224"},
        {"Smithsonian Astrophysical Observation", "SAO 144525"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.77662180),
        dec: Angle.Degrees(-02.59303119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84563"},
        {"Hipparcos Number", "HIP 47932"},
        {"Geneva Identification System", "GEN# +1.00084563"},
        {"Smithsonian Astrophysical Observation", "SAO 137110"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.51709473),
        dec: Angle.Degrees(-02.59192505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27114"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.25151220),
        dec: Angle.Degrees(-02.59095447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -371.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170565"},
        {"Hipparcos Number", "HIP 90680"},
        {"Renson", "Renson 47790"},
        {"Smithsonian Astrophysical Observation", "SAO 142352"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.53450426),
        dec: Angle.Degrees(-02.59086365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172013"},
        {"Hipparcos Number", "HIP 91355"},
        {"Smithsonian Astrophysical Observation", "SAO 142452"},
        {"Wilson Evans Batten Catalogue", "WEB 15696"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48785649),
        dec: Angle.Degrees(-02.59046918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65270"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.65568567),
        dec: Angle.Degrees(-02.59031539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35843"},
        {"Smithsonian Astrophysical Observation", "SAO 134605"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.86754159),
        dec: Angle.Degrees(-02.58775672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16536"},
        {"Hipparcos Number", "HIP 12347"},
        {"Smithsonian Astrophysical Observation", "SAO 130033"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.74426816),
        dec: Angle.Degrees(-02.58690366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186105"},
        {"Hipparcos Number", "HIP 96965"},
        {"Smithsonian Astrophysical Observation", "SAO 143717"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.65072455),
        dec: Angle.Degrees(-02.58416389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20403"},
        {"Hipparcos Number", "HIP 15256"},
        {"Geneva Identification System", "GEN# +1.00020403"},
        {"Smithsonian Astrophysical Observation", "SAO 130398"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.19606865),
        dec: Angle.Degrees(-02.58394809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154186"},
        {"Hipparcos Number", "HIP 83510"},
        {"Smithsonian Astrophysical Observation", "SAO 141504"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.00487281),
        dec: Angle.Degrees(-02.58384437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12459"},
        {"Hipparcos Number", "HIP 9489"},
        {"Smithsonian Astrophysical Observation", "SAO 129641"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.51790261),
        dec: Angle.Degrees(-02.58280404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34430"},
        {"Hipparcos Number", "HIP 24635"},
        {"Smithsonian Astrophysical Observation", "SAO 131945"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.29096583),
        dec: Angle.Degrees(-02.57990911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162812"},
        {"Hipparcos Number", "HIP 87538"},
        {"Geneva Identification System", "GEN# +1.00162812"},
        {"Smithsonian Astrophysical Observation", "SAO 141939"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.26392356),
        dec: Angle.Degrees(-02.57924962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164377"},
        {"Hipparcos Number", "HIP 88216"},
        {"Smithsonian Astrophysical Observation", "SAO 142032"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.23827408),
        dec: Angle.Degrees(-02.57882208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116936"},
        {"Geneva Identification System", "GEN# -0.00305691"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.54473674),
        dec: Angle.Degrees(-02.57623383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55337"},
        {"Hipparcos Number", "HIP 34815"},
        {"Smithsonian Astrophysical Observation", "SAO 134346"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.10070434),
        dec: Angle.Degrees(-02.57432396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5656"},
        {"Hipparcos Number", "HIP 4549"},
        {"Smithsonian Astrophysical Observation", "SAO 129053"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.55210427),
        dec: Angle.Degrees(-02.57407481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118182"},
        {"Hipparcos Number", "HIP 66293"},
        {"Smithsonian Astrophysical Observation", "SAO 139425"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.80572768),
        dec: Angle.Degrees(-02.57329115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202316"},
        {"Hipparcos Number", "HIP 104911"},
        {"Smithsonian Astrophysical Observation", "SAO 145237"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.76606801),
        dec: Angle.Degrees(-02.57194842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200411"},
        {"Hipparcos Number", "HIP 103926"},
        {"Geneva Identification System", "GEN# +1.00200411"},
        {"Smithsonian Astrophysical Observation", "SAO 145055"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.84957725),
        dec: Angle.Degrees(-02.57078008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295892"},
        {"Hipparcos Number", "HIP 33562"},
        {"Smithsonian Astrophysical Observation", "SAO 133971"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61127286),
        dec: Angle.Degrees(-02.56811444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23794"},
        {"Hipparcos Number", "HIP 17727"},
        {"Smithsonian Astrophysical Observation", "SAO 130723"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.93999610),
        dec: Angle.Degrees(-02.56587611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78902"},
        {"Smithsonian Astrophysical Observation", "SAO 140956"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.59905723),
        dec: Angle.Degrees(-02.56497208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192589"},
        {"Hipparcos Number", "HIP 99869"},
        {"Fundamental Katalog 5th Edition", "FK5 5786"},
        {"Smithsonian Astrophysical Observation", "SAO 144225"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.92943500),
        dec: Angle.Degrees(-02.56438096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112991"},
        {"Hipparcos Number", "HIP 63496"},
        {"Geneva Identification System", "GEN# +1.00112991"},
        {"Smithsonian Astrophysical Observation", "SAO 139097"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.16167501),
        dec: Angle.Degrees(-02.56285356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77236"},
        {"Hipparcos Number", "HIP 44293"},
        {"Geneva Identification System", "GEN# +1.00077236"},
        {"Smithsonian Astrophysical Observation", "SAO 136495"},
        {"Wilson Evans Batten Catalogue", "WEB 8494"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.31195870),
        dec: Angle.Degrees(-02.56144139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 545"},
        {"Hipparcos Number", "HIP 803"},
        {"Geneva Identification System", "GEN# +1.00000545"},
        {"Smithsonian Astrophysical Observation", "SAO 128618"},
        {"Wilson Evans Batten Catalogue", "WEB 136"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.47924356),
        dec: Angle.Degrees(-02.56122960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55388"},
        {"Hipparcos Number", "HIP 34837"},
        {"Geneva Identification System", "GEN# +1.00055388"},
        {"Smithsonian Astrophysical Observation", "SAO 134352"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14330184),
        dec: Angle.Degrees(-02.55990391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22629"},
        {"Hipparcos Number", "HIP 16971"},
        {"Smithsonian Astrophysical Observation", "SAO 130622"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.57209068),
        dec: Angle.Degrees(-02.55850695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113674"},
        {"Hipparcos Number", "HIP 63876"},
        {"Geneva Identification System", "GEN# +1.00113674"},
        {"Smithsonian Astrophysical Observation", "SAO 139144"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36419861),
        dec: Angle.Degrees(-02.55748729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8823 A"},
        {"Henry Draper", "HD 114842"},
        {"Hipparcos Number", "HIP 64498"},
        {"Geneva Identification System", "GEN# +1.00114842"},
        {"Smithsonian Astrophysical Observation", "SAO 139227"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30756408),
        dec: Angle.Degrees(-02.55563145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16183 AB"},
        {"Henry Draper", "HD 214909"},
        {"Hipparcos Number", "HIP 112043"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.41129285),
        dec: Angle.Degrees(-02.55257654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7321"},
        {"Hipparcos Number", "HIP 5704"},
        {"Smithsonian Astrophysical Observation", "SAO 129182"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.34630151),
        dec: Angle.Degrees(-02.55077663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218568"},
        {"Hipparcos Number", "HIP 114313"},
        {"Cincinnati Publication", "Ci 18 3027"},
        {"Geneva Identification System", "GEN# +1.00218568"},
        {"Smithsonian Astrophysical Observation", "SAO 146531"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.26631187),
        dec: Angle.Degrees(-02.55054058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16583"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.37400169),
        dec: Angle.Degrees(-02.54995459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196321"},
        {"Hipparcos Number", "HIP 101692"},
        {"Fundamental Katalog 5th Edition", "FK5 3648"},
        {"Geneva Identification System", "GEN# +1.00196321"},
        {"Smithsonian Astrophysical Observation", "SAO 144624"},
        {"Wilson Evans Batten Catalogue", "WEB 18367"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.18177937),
        dec: Angle.Degrees(-02.54991814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315"},
        {"Hipparcos Number", "HIP 635"},
        {"Geneva Identification System", "GEN# +1.00000315"},
        {"Renson", "Renson 30"},
        {"Smithsonian Astrophysical Observation", "SAO 128595"},
        {"Wilson Evans Batten Catalogue", "WEB 106"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.93373158),
        dec: Angle.Degrees(-02.54868621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56690"},
        {"Hipparcos Number", "HIP 35340"},
        {"Smithsonian Astrophysical Observation", "SAO 134480"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.50826742),
        dec: Angle.Degrees(-02.54861659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77069"},
        {"Hipparcos Number", "HIP 44179"},
        {"Smithsonian Astrophysical Observation", "SAO 136478"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.99032147),
        dec: Angle.Degrees(-02.54818260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47420"},
        {"Hipparcos Number", "HIP 31733"},
        {"Geneva Identification System", "GEN# +1.00047420"},
        {"Smithsonian Astrophysical Observation", "SAO 133511"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.58526906),
        dec: Angle.Degrees(-02.54391246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22094"},
        {"Hipparcos Number", "HIP 16582"},
        {"Smithsonian Astrophysical Observation", "SAO 130569"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.37415233),
        dec: Angle.Degrees(-02.54288400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3650 A"},
        {"Henry Draper", "HD 32526"},
        {"Hipparcos Number", "HIP 23539"},
        {"Smithsonian Astrophysical Observation", "SAO 131731"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.92847221),
        dec: Angle.Degrees(-02.54000800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158809"},
        {"Hipparcos Number", "HIP 85757"},
        {"Cincinnati Publication", "Ci 18 2336"},
        {"Geneva Identification System", "GEN# +1.00158809"},
        {"Smithsonian Astrophysical Observation", "SAO 141716"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.85651162),
        dec: Angle.Degrees(-02.53855082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -273.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177088"},
        {"Hipparcos Number", "HIP 93550"},
        {"Geneva Identification System", "GEN# +1.00177088"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.82251251),
        dec: Angle.Degrees(-02.53676184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34582"},
        {"Hipparcos Number", "HIP 24747"},
        {"Smithsonian Astrophysical Observation", "SAO 131965"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.60138035),
        dec: Angle.Degrees(-02.53541569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17001"},
        {"Hipparcos Number", "HIP 12720"},
        {"Smithsonian Astrophysical Observation", "SAO 130079"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.87043285),
        dec: Angle.Degrees(-02.53149459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115711"},
        {"Hipparcos Number", "HIP 64963"},
        {"Geneva Identification System", "GEN# +1.00115711"},
        {"Smithsonian Astrophysical Observation", "SAO 139274"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.73005407),
        dec: Angle.Degrees(-02.53145597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71195"},
    },
    visualMagnitude: 10.96,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.41037127),
        dec: Angle.Degrees(-02.53087896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118760"},
        {"Hipparcos Number", "HIP 66581"},
        {"Smithsonian Astrophysical Observation", "SAO 139465"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.72666459),
        dec: Angle.Degrees(-02.53073845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36206"},
        {"Smithsonian Astrophysical Observation", "SAO 134695"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.84761965),
        dec: Angle.Degrees(-02.52487308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72172"},
        {"Hipparcos Number", "HIP 41799"},
        {"Geneva Identification System", "GEN# +1.00072172"},
        {"Smithsonian Astrophysical Observation", "SAO 135997"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.83540977),
        dec: Angle.Degrees(-02.52265088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87888"},
        {"Hipparcos Number", "HIP 49643"},
        {"Smithsonian Astrophysical Observation", "SAO 137367"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.98691934),
        dec: Angle.Degrees(-02.52265033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33278"},
        {"Hipparcos Number", "HIP 23955"},
        {"Smithsonian Astrophysical Observation", "SAO 131817"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.22966005),
        dec: Angle.Degrees(-02.52131594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75193"},
        {"Hipparcos Number", "HIP 43235"},
        {"Geneva Identification System", "GEN# +1.00075193"},
        {"Smithsonian Astrophysical Observation", "SAO 136292"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.10921052),
        dec: Angle.Degrees(-02.52087817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223620"},
        {"Hipparcos Number", "HIP 117614"},
        {"Smithsonian Astrophysical Observation", "SAO 146935"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.79100384),
        dec: Angle.Degrees(-02.52036489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10199"},
        {"Hipparcos Number", "HIP 7736"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.91090110),
        dec: Angle.Degrees(-02.51711562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41564",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6828 AB"},
        {"Henry Draper", "HD 71663"},
        {"Hipparcos Number", "HIP 41564"},
        {"Geneva Identification System", "GEN# +1.00071663"},
        {"Renson", "Renson 19780"},
        {"Smithsonian Astrophysical Observation", "SAO 135958"},
        {"Wilson Evans Batten Catalogue", "WEB 8023"},
        {"Wilson Evans Batten Catalogue 2", "WEB 8022"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.12149299),
        dec: Angle.Degrees(-02.51710024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139076"},
        {"Hipparcos Number", "HIP 76399"},
        {"Smithsonian Astrophysical Observation", "SAO 140635"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.05335639),
        dec: Angle.Degrees(-02.51664060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206187"},
        {"Hipparcos Number", "HIP 107024"},
        {"Fundamental Katalog 5th Edition", "FK5 5913"},
        {"Smithsonian Astrophysical Observation", "SAO 145581"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.13314994),
        dec: Angle.Degrees(-02.51650618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200081"},
        {"Hipparcos Number", "HIP 103744"},
        {"Geneva Identification System", "GEN# +1.00200081"},
        {"Smithsonian Astrophysical Observation", "SAO 145033"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.34339593),
        dec: Angle.Degrees(-02.51397884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2474"},
        {"Hipparcos Number", "HIP 2242"},
        {"Smithsonian Astrophysical Observation", "SAO 128774"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.11821783),
        dec: Angle.Degrees(-02.51331148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54158",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dingolay"},
        {"Henry Draper", "HD 96063"},
        {"Hipparcos Number", "HIP 54158"},
        {"Smithsonian Astrophysical Observation", "SAO 137979"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.18516017),
        dec: Angle.Degrees(-02.51317528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26633"},
        {"Hipparcos Number", "HIP 19644"},
        {"Smithsonian Astrophysical Observation", "SAO 131028"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.13741762),
        dec: Angle.Degrees(-02.51271408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22584"},
        {"Hipparcos Number", "HIP 16933"},
        {"Geneva Identification System", "GEN# +1.00022584A"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.47635992),
        dec: Angle.Degrees(-02.51170645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10551"},
        {"Smithsonian Astrophysical Observation", "SAO 129785"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.97273038),
        dec: Angle.Degrees(-02.51157803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45708"},
        {"Hipparcos Number", "HIP 30871"},
        {"Smithsonian Astrophysical Observation", "SAO 133314"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.21398142),
        dec: Angle.Degrees(-02.50948020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106439"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.38067138),
        dec: Angle.Degrees(-02.50575502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129655"},
        {"Hipparcos Number", "HIP 72015"},
        {"Geneva Identification System", "GEN# +1.00129655"},
        {"Smithsonian Astrophysical Observation", "SAO 140097"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.94359092),
        dec: Angle.Degrees(-02.50548929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42824"},
        {"Hipparcos Number", "HIP 29487"},
        {"Geneva Identification System", "GEN# +1.00042824"},
        {"Smithsonian Astrophysical Observation", "SAO 132965"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.18587167),
        dec: Angle.Degrees(-02.50481180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155968"},
        {"Hipparcos Number", "HIP 84374"},
        {"Geneva Identification System", "GEN# +1.00155968"},
        {"Smithsonian Astrophysical Observation", "SAO 141574"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.74209277),
        dec: Angle.Degrees(-02.50317980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174108"},
        {"Hipparcos Number", "HIP 92320"},
        {"Smithsonian Astrophysical Observation", "SAO 142651"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.23384444),
        dec: Angle.Degrees(-02.50221304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38352"},
        {"Hipparcos Number", "HIP 27117"},
        {"Geneva Identification System", "GEN# +1.00038352"},
        {"Smithsonian Astrophysical Observation", "SAO 132507"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.25548534),
        dec: Angle.Degrees(-02.50170032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7672"},
        {"Hipparcos Number", "HIP 5951"},
        {"Geneva Identification System", "GEN# +1.00007672"},
        {"Smithsonian Astrophysical Observation", "SAO 129204"},
        {"Wilson Evans Batten Catalogue", "WEB 1355"},
    },
    visualMagnitude: 5.42,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.15144476),
        dec: Angle.Degrees(-02.50021280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42094"},
        {"Hipparcos Number", "HIP 29133"},
        {"Smithsonian Astrophysical Observation", "SAO 132878"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.17934057),
        dec: Angle.Degrees(-02.49987463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102272"},
        {"Smithsonian Astrophysical Observation", "SAO 144736"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.83495141),
        dec: Angle.Degrees(-02.49899001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25293",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4007 AB"},
        {"Henry Draper", "HD 35456"},
        {"Hipparcos Number", "HIP 25293"},
        {"Geneva Identification System", "GEN# +1.00035456J"},
        {"Renson", "Renson 9070"},
        {"Smithsonian Astrophysical Observation", "SAO 132075"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.16825637),
        dec: Angle.Degrees(-02.49784438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125673"},
        {"Hipparcos Number", "HIP 70138"},
        {"Smithsonian Astrophysical Observation", "SAO 139880"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.27432862),
        dec: Angle.Degrees(-02.49745179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73891"},
        {"Hipparcos Number", "HIP 42565"},
        {"Smithsonian Astrophysical Observation", "SAO 136159"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.14844580),
        dec: Angle.Degrees(-02.49626707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12356"},
        {"Hipparcos Number", "HIP 9423"},
        {"Geneva Identification System", "GEN# +1.00012356"},
        {"Smithsonian Astrophysical Observation", "SAO 129633"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.26752977),
        dec: Angle.Degrees(-02.49539903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63860"},
        {"Hipparcos Number", "HIP 38305"},
        {"Geneva Identification System", "GEN# +1.00063860"},
        {"Smithsonian Astrophysical Observation", "SAO 135171"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.71948038),
        dec: Angle.Degrees(-02.49508330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90306"},
        {"Hipparcos Number", "HIP 51027"},
        {"Smithsonian Astrophysical Observation", "SAO 137555"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.36805445),
        dec: Angle.Degrees(-02.49315750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131456"},
        {"Hipparcos Number", "HIP 72889"},
        {"Smithsonian Astrophysical Observation", "SAO 140207"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.46175484),
        dec: Angle.Degrees(-02.49249201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100629"},
        {"Hipparcos Number", "HIP 56482"},
        {"Geneva Identification System", "GEN# +1.00100629"},
        {"Smithsonian Astrophysical Observation", "SAO 138280"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.69772202),
        dec: Angle.Degrees(-02.49108965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8083"},
        {"Hipparcos Number", "HIP 6246"},
        {"Geneva Identification System", "GEN# +1.00008083"},
        {"Smithsonian Astrophysical Observation", "SAO 129238"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.03385784),
        dec: Angle.Degrees(-02.49082888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33608"},
        {"Hipparcos Number", "HIP 24162"},
        {"Fundamental Katalog 5th Edition", "FK5 2390"},
        {"Geneva Identification System", "GEN# +1.00033608"},
        {"Smithsonian Astrophysical Observation", "SAO 131852"},
        {"Wilson Evans Batten Catalogue", "WEB 4693"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.82970507),
        dec: Angle.Degrees(-02.49078592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173246"},
        {"Hipparcos Number", "HIP 91925"},
        {"Smithsonian Astrophysical Observation", "SAO 142565"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.09301957),
        dec: Angle.Degrees(-02.48922594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19520"},
        {"Smithsonian Astrophysical Observation", "SAO 131006"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.73046346),
        dec: Angle.Degrees(-02.48875403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147907"},
        {"Hipparcos Number", "HIP 80398"},
        {"Fundamental Katalog 5th Edition", "FK5 5447"},
        {"Geneva Identification System", "GEN# +1.00147907"},
        {"Smithsonian Astrophysical Observation", "SAO 141154"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.16445126),
        dec: Angle.Degrees(-02.48805836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82152"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.74881267),
        dec: Angle.Degrees(-02.48687290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197954"},
        {"Hipparcos Number", "HIP 102561"},
        {"Geneva Identification System", "GEN# +1.00197954"},
        {"Smithsonian Astrophysical Observation", "SAO 144802"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.76488906),
        dec: Angle.Degrees(-02.48685951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95578"},
        {"Hipparcos Number", "HIP 53907"},
        {"Fundamental Katalog 5th Edition", "FK5 2879"},
        {"Geneva Identification System", "GEN# +1.00095578"},
        {"Smithsonian Astrophysical Observation", "SAO 137947"},
        {"Wilson Evans Batten Catalogue", "WEB 9759"},
    },
    visualMagnitude: 4.73,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.45695372),
        dec: Angle.Degrees(-02.48449705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181714"},
        {"Hipparcos Number", "HIP 95158"},
        {"Smithsonian Astrophysical Observation", "SAO 143308"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.40307887),
        dec: Angle.Degrees(-02.48313812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50933"},
        {"Hipparcos Number", "HIP 33257"},
        {"Geneva Identification System", "GEN# +1.00050933"},
        {"Smithsonian Astrophysical Observation", "SAO 133894"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.78633526),
        dec: Angle.Degrees(-02.48124242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21517"},
        {"Hipparcos Number", "HIP 16151"},
        {"Smithsonian Astrophysical Observation", "SAO 130506"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.03642947),
        dec: Angle.Degrees(-02.47962447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1567"},
        {"Hipparcos Number", "HIP 1587"},
        {"Geneva Identification System", "GEN# +1.00001567"},
        {"Smithsonian Astrophysical Observation", "SAO 128698"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.96199830),
        dec: Angle.Degrees(-02.47897217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209348"},
        {"Hipparcos Number", "HIP 108827"},
        {"Fundamental Katalog 5th Edition", "FK5 5948"},
        {"Geneva Identification System", "GEN# +1.00209348"},
        {"Smithsonian Astrophysical Observation", "SAO 145830"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.70178630),
        dec: Angle.Degrees(-02.47870284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41176"},
        {"Hipparcos Number", "HIP 28681"},
        {"Geneva Identification System", "GEN# +1.00041176"},
        {"Smithsonian Astrophysical Observation", "SAO 132782"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.82950933),
        dec: Angle.Degrees(-02.47865265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115294"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.24908327),
        dec: Angle.Degrees(-02.47841538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30716"},
        {"Hipparcos Number", "HIP 22454"},
        {"Geneva Identification System", "GEN# +1.00030716"},
        {"Smithsonian Astrophysical Observation", "SAO 131528"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.47866312),
        dec: Angle.Degrees(-02.47738232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78421"},
        {"Hipparcos Number", "HIP 44820"},
        {"Geneva Identification System", "GEN# +1.00078421"},
        {"Smithsonian Astrophysical Observation", "SAO 136597"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.00642233),
        dec: Angle.Degrees(-02.47611440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181421"},
        {"Hipparcos Number", "HIP 95076"},
        {"Smithsonian Astrophysical Observation", "SAO 143291"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.15499542),
        dec: Angle.Degrees(-02.47558844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93034"},
        {"Hipparcos Number", "HIP 52543"},
        {"Geneva Identification System", "GEN# +1.00093034"},
        {"Smithsonian Astrophysical Observation", "SAO 137760"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.14293420),
        dec: Angle.Degrees(-02.47430346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53085"},
        {"Hipparcos Number", "HIP 34032"},
        {"Geneva Identification System", "GEN# +1.00053085"},
        {"Smithsonian Astrophysical Observation", "SAO 134123"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.90491871),
        dec: Angle.Degrees(-02.47417196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21547",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3350 A"},
        {"Henry Draper", "HD 29391"},
        {"Hipparcos Number", "HIP 21547"},
        {"Celescope Catalog", "CEL 446"},
        {"Geneva Identification System", "GEN# +1.00029391"},
        {"Smithsonian Astrophysical Observation", "SAO 131358"},
        {"Wilson Evans Batten Catalogue", "WEB 4136"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.40044421),
        dec: Angle.Degrees(-02.47339212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106127"},
        {"Hipparcos Number", "HIP 59545"},
        {"Smithsonian Astrophysical Observation", "SAO 138648"},
        {"Wilson Evans Batten Catalogue", "WEB 10585"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.17542066),
        dec: Angle.Degrees(-02.47262071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8543"},
        {"Hipparcos Number", "HIP 6565"},
        {"Smithsonian Astrophysical Observation", "SAO 129276"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.08622984),
        dec: Angle.Degrees(-02.47201220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99689"},
        {"Hipparcos Number", "HIP 55961"},
        {"Smithsonian Astrophysical Observation", "SAO 138221"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.01587890),
        dec: Angle.Degrees(-02.47200394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143839"},
        {"Hipparcos Number", "HIP 78593"},
        {"Fundamental Katalog 5th Edition", "FK5 5417"},
        {"Smithsonian Astrophysical Observation", "SAO 140915"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.70104717),
        dec: Angle.Degrees(-02.47013112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119373"},
        {"Hipparcos Number", "HIP 66922"},
        {"Smithsonian Astrophysical Observation", "SAO 139500"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.72636633),
        dec: Angle.Degrees(-02.46841028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94100"},
        {"Hipparcos Number", "HIP 53094"},
        {"Geneva Identification System", "GEN# +1.00094100"},
        {"Smithsonian Astrophysical Observation", "SAO 137843"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.92987602),
        dec: Angle.Degrees(-02.46735475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108733"},
        {"Smithsonian Astrophysical Observation", "SAO 145815"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.38898779),
        dec: Angle.Degrees(-02.46702303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18633"},
        {"Hipparcos Number", "HIP 13951"},
        {"Fundamental Katalog 5th Edition", "FK5 2209"},
        {"Geneva Identification System", "GEN# +1.00018633"},
        {"Smithsonian Astrophysical Observation", "SAO 130228"},
        {"Wilson Evans Batten Catalogue", "WEB 2753"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.92151015),
        dec: Angle.Degrees(-02.46490094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105076"},
        {"Hipparcos Number", "HIP 59005"},
        {"Geneva Identification System", "GEN# +1.00105076"},
        {"Smithsonian Astrophysical Observation", "SAO 138584"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.47781133),
        dec: Angle.Degrees(-02.46323092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16130"},
        {"Hipparcos Number", "HIP 12054"},
        {"Geneva Identification System", "GEN# +1.00016130"},
        {"Smithsonian Astrophysical Observation", "SAO 129993"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.84695517),
        dec: Angle.Degrees(-02.46241660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53875"},
        {"Smithsonian Astrophysical Observation", "SAO 137942"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.33400486),
        dec: Angle.Degrees(-02.46230190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187660"},
        {"Hipparcos Number", "HIP 97687"},
        {"Geneva Identification System", "GEN# +1.00187660"},
        {"Smithsonian Astrophysical Observation", "SAO 143853"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.79625917),
        dec: Angle.Degrees(-02.46088946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21072"},
        {"Hipparcos Number", "HIP 15829"},
        {"Smithsonian Astrophysical Observation", "SAO 130460"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.97771504),
        dec: Angle.Degrees(-02.45972699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33014"},
    },
    visualMagnitude: 11.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.19238139),
        dec: Angle.Degrees(-02.45822990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80340"},
        {"Hipparcos Number", "HIP 45710"},
        {"Geneva Identification System", "GEN# +1.00080340"},
        {"Smithsonian Astrophysical Observation", "SAO 136750"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.78139490),
        dec: Angle.Degrees(-02.45796738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131025"},
        {"Hipparcos Number", "HIP 72663"},
        {"Geneva Identification System", "GEN# +1.00131025"},
        {"Smithsonian Astrophysical Observation", "SAO 140182"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.85836192),
        dec: Angle.Degrees(-02.45706086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176469"},
        {"Hipparcos Number", "HIP 93317"},
        {"Smithsonian Astrophysical Observation", "SAO 142904"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.10519454),
        dec: Angle.Degrees(-02.45639301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35524"},
        {"Hipparcos Number", "HIP 25335"},
        {"Smithsonian Astrophysical Observation", "SAO 132082"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.28249068),
        dec: Angle.Degrees(-02.45583667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184701"},
        {"Hipparcos Number", "HIP 96392"},
        {"Geneva Identification System", "GEN# +1.00184701"},
        {"Smithsonian Astrophysical Observation", "SAO 143575"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.96158504),
        dec: Angle.Degrees(-02.45559690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152778"},
        {"Hipparcos Number", "HIP 82831"},
        {"Smithsonian Astrophysical Observation", "SAO 141442"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89845835),
        dec: Angle.Degrees(-02.45362495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5754"},
        {"Hipparcos Number", "HIP 4609"},
        {"Smithsonian Astrophysical Observation", "SAO 129059"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.76270900),
        dec: Angle.Degrees(-02.45341041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28968"},
        {"Hipparcos Number", "HIP 21263"},
        {"Smithsonian Astrophysical Observation", "SAO 131300"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.42997396),
        dec: Angle.Degrees(-02.45290387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218567"},
        {"Hipparcos Number", "HIP 114315"},
        {"Geneva Identification System", "GEN# +1.00218567"},
        {"Smithsonian Astrophysical Observation", "SAO 146532"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.26731931),
        dec: Angle.Degrees(-02.45264573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21835"},
        {"Smithsonian Astrophysical Observation", "SAO 131412"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.40275162),
        dec: Angle.Degrees(-02.45116463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197421"},
        {"Hipparcos Number", "HIP 102304"},
        {"Smithsonian Astrophysical Observation", "SAO 144739"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.92924453),
        dec: Angle.Degrees(-02.44996296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220966"},
        {"Hipparcos Number", "HIP 115845"},
        {"Smithsonian Astrophysical Observation", "SAO 146717"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.03514833),
        dec: Angle.Degrees(-02.44819079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352"},
        {"Hipparcos Number", "HIP 664"},
        {"Fundamental Katalog 5th Edition", "FK5 2006"},
        {"Geneva Identification System", "GEN# +1.00000352"},
        {"Smithsonian Astrophysical Observation", "SAO 128602"},
        {"Wilson Evans Batten Catalogue", "WEB 111"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.05038298),
        dec: Angle.Degrees(-02.44769895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58791",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8403 AB"},
        {"Henry Draper", "HD 104711"},
        {"Hipparcos Number", "HIP 58791"},
        {"Smithsonian Astrophysical Observation", "SAO 138555"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.88246068),
        dec: Angle.Degrees(-02.44693966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37333"},
        {"Hipparcos Number", "HIP 26456"},
        {"Geneva Identification System", "GEN# +1.00037333"},
        {"Renson", "Renson 10010"},
        {"Smithsonian Astrophysical Observation", "SAO 132379"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.41865187),
        dec: Angle.Degrees(-02.44355660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120086"},
        {"Hipparcos Number", "HIP 67279"},
        {"Geneva Identification System", "GEN# +1.00120086"},
        {"Smithsonian Astrophysical Observation", "SAO 139546"},
        {"Wilson Evans Batten Catalogue", "WEB 11836"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.82998685),
        dec: Angle.Degrees(-02.44350064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93275"},
        {"Hipparcos Number", "HIP 52669"},
        {"Smithsonian Astrophysical Observation", "SAO 137772"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.54857523),
        dec: Angle.Degrees(-02.44349527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149996"},
        {"Hipparcos Number", "HIP 81461"},
        {"Cincinnati Publication", "Ci 18 2218"},
        {"Geneva Identification System", "GEN# +1.00149996"},
        {"Smithsonian Astrophysical Observation", "SAO 141287"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.57289217),
        dec: Angle.Degrees(-02.44147270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217286"},
        {"Hipparcos Number", "HIP 113547"},
        {"Geneva Identification System", "GEN# +1.00217286"},
        {"Smithsonian Astrophysical Observation", "SAO 146434"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.95595641),
        dec: Angle.Degrees(-02.43984639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101154"},
        {"Hipparcos Number", "HIP 56775"},
        {"Geneva Identification System", "GEN# +1.00101154J"},
        {"Smithsonian Astrophysical Observation", "SAO 138314"},
        {"Wilson Evans Batten Catalogue", "WEB 10216"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.60037890),
        dec: Angle.Degrees(-02.43593788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37699"},
        {"Hipparcos Number", "HIP 26694"},
        {"Celescope Catalog", "CEL 913"},
        {"Geneva Identification System", "GEN# +1.00037699"},
        {"Smithsonian Astrophysical Observation", "SAO 132438"},
        {"Wilson Evans Batten Catalogue", "WEB 5262"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.08412191),
        dec: Angle.Degrees(-02.43561781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52263"},
        {"Hipparcos Number", "HIP 33724"},
        {"Geneva Identification System", "GEN# +1.00052263"},
        {"Smithsonian Astrophysical Observation", "SAO 134032"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.09338726),
        dec: Angle.Degrees(-02.43208259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48665"},
        {"Hipparcos Number", "HIP 32286"},
        {"Geneva Identification System", "GEN# +2.22860007"},
        {"Smithsonian Astrophysical Observation", "SAO 133627"},
        {"New General Catalogue", "NGC 2286 7"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.10312521),
        dec: Angle.Degrees(-02.43071654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108680"},
        {"Hipparcos Number", "HIP 60924"},
        {"Fundamental Katalog 5th Edition", "FK5 5100"},
        {"Geneva Identification System", "GEN# +1.00108680"},
        {"Smithsonian Astrophysical Observation", "SAO 138813"},
        {"Wilson Evans Batten Catalogue", "WEB 10842"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.29042975),
        dec: Angle.Degrees(-02.42955232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97678"},
        {"Hipparcos Number", "HIP 54898"},
        {"Smithsonian Astrophysical Observation", "SAO 138078"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.60560872),
        dec: Angle.Degrees(-02.42801113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204325"},
        {"Hipparcos Number", "HIP 105985"},
        {"Smithsonian Astrophysical Observation", "SAO 145417"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.97569233),
        dec: Angle.Degrees(-02.42800478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25752"},
        {"Hipparcos Number", "HIP 19049"},
        {"Smithsonian Astrophysical Observation", "SAO 130925"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.22249249),
        dec: Angle.Degrees(-02.42708433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66097",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8938 A"},
        {"Henry Draper", "HD 117832"},
        {"Hipparcos Number", "HIP 66097"},
        {"Geneva Identification System", "GEN# +1.00117832"},
        {"Smithsonian Astrophysical Observation", "SAO 139402"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.23839537),
        dec: Angle.Degrees(-02.42423912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15245 AB"},
        {"Henry Draper", "HD 206558"},
        {"Hipparcos Number", "HIP 107212"},
        {"Smithsonian Astrophysical Observation", "SAO 145611"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.72458670),
        dec: Angle.Degrees(-02.42413184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160868"},
        {"Hipparcos Number", "HIP 86671"},
        {"Geneva Identification System", "GEN# +1.00160868"},
        {"Smithsonian Astrophysical Observation", "SAO 141820"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.62314133),
        dec: Angle.Degrees(-02.42381757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129135"},
        {"Hipparcos Number", "HIP 71785"},
        {"Geneva Identification System", "GEN# +1.00129135"},
        {"Smithsonian Astrophysical Observation", "SAO 140068"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.26011515),
        dec: Angle.Degrees(-02.42323856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70881"},
        {"Hipparcos Number", "HIP 41190"},
        {"Smithsonian Astrophysical Observation", "SAO 135872"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.08206274),
        dec: Angle.Degrees(-02.42292617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213038"},
        {"Hipparcos Number", "HIP 110955"},
        {"Geneva Identification System", "GEN# +1.00213038"},
        {"Smithsonian Astrophysical Observation", "SAO 146106"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.19918157),
        dec: Angle.Degrees(-02.42041843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57740",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8318 AB"},
        {"Henry Draper", "HD 102844"},
        {"Hipparcos Number", "HIP 57740"},
        {"Smithsonian Astrophysical Observation", "SAO 138437"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.60998138),
        dec: Angle.Degrees(-02.41849065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170857"},
        {"Hipparcos Number", "HIP 90832"},
        {"Geneva Identification System", "GEN# +1.00170857"},
        {"Smithsonian Astrophysical Observation", "SAO 142368"},
        {"Wilson Evans Batten Catalogue", "WEB 15571"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.94242835),
        dec: Angle.Degrees(-02.41848588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135206"},
        {"Hipparcos Number", "HIP 74554"},
        {"Smithsonian Astrophysical Observation", "SAO 140395"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.49799593),
        dec: Angle.Degrees(-02.41681875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88332"},
        {"Hipparcos Number", "HIP 49871"},
        {"Geneva Identification System", "GEN# +1.00088332"},
        {"Smithsonian Astrophysical Observation", "SAO 137396"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.75550979),
        dec: Angle.Degrees(-02.41504863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135386"},
        {"Hipparcos Number", "HIP 74633"},
        {"Smithsonian Astrophysical Observation", "SAO 140410"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.74036880),
        dec: Angle.Degrees(-02.41468273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88990"},
        {"Hipparcos Number", "HIP 50275"},
        {"Smithsonian Astrophysical Observation", "SAO 137446"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.97917873),
        dec: Angle.Degrees(-02.41437694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28488"},
        {"Hipparcos Number", "HIP 20944"},
        {"Smithsonian Astrophysical Observation", "SAO 131243"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.35920870),
        dec: Angle.Degrees(-02.41390621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196712"},
        {"Hipparcos Number", "HIP 101921"},
        {"Geneva Identification System", "GEN# +1.00196712"},
        {"Smithsonian Astrophysical Observation", "SAO 144666"},
        {"Wilson Evans Batten Catalogue", "WEB 18417"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.80519224),
        dec: Angle.Degrees(-02.41298335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136442"},
        {"Hipparcos Number", "HIP 75101"},
        {"Cincinnati Publication", "Ci 18 2047"},
        {"Geneva Identification System", "GEN# +1.00136442"},
        {"Smithsonian Astrophysical Observation", "SAO 140473"},
        {"Wilson Evans Batten Catalogue", "WEB 12808"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.19655500),
        dec: Angle.Degrees(-02.41291700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7162 AB"},
        {"Henry Draper", "HD 77625"},
        {"Hipparcos Number", "HIP 44470"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.90367350),
        dec: Angle.Degrees(-02.40874234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50134"},
        {"Hipparcos Number", "HIP 32936"},
        {"Geneva Identification System", "GEN# +1.00050134"},
        {"Smithsonian Astrophysical Observation", "SAO 133785"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.92173507),
        dec: Angle.Degrees(-02.40271589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27273"},
        {"Hipparcos Number", "HIP 20078"},
        {"Smithsonian Astrophysical Observation", "SAO 131102"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.57729787),
        dec: Angle.Degrees(-02.40191028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3100"},
        {"Hipparcos Number", "HIP 2698"},
        {"Smithsonian Astrophysical Observation", "SAO 128828"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.56457940),
        dec: Angle.Degrees(-02.39796493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25281",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4002 AB"},
        {"Henry Draper", "HD 35411"},
        {"Hipparcos Number", "HIP 25281"},
        {"Celescope Catalog", "CEL 676"},
        {"Geneva Identification System", "GEN# +1.00035411J"},
        {"Smithsonian Astrophysical Observation", "SAO 132071"},
        {"Wilson Evans Batten Catalogue", "WEB 4903"},
        {"Wilson Evans Batten Catalogue 2", "WEB 4904"},
    },
    visualMagnitude: 3.35,
    bvColour: -0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.11923774),
        dec: Angle.Degrees(-02.39713844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66268"},
        {"Hipparcos Number", "HIP 39354"},
        {"Geneva Identification System", "GEN# +1.00066268"},
        {"Smithsonian Astrophysical Observation", "SAO 135413"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.66774013),
        dec: Angle.Degrees(-02.39713612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57429"},
        {"Hipparcos Number", "HIP 35629"},
        {"Fundamental Katalog 5th Edition", "FK5 4663"},
        {"Smithsonian Astrophysical Observation", "SAO 134550"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.28144548),
        dec: Angle.Degrees(-02.39693738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217107"},
        {"Hipparcos Number", "HIP 113421"},
        {"Fundamental Katalog 5th Edition", "FK5 3836"},
        {"Geneva Identification System", "GEN# +1.00217107"},
        {"Smithsonian Astrophysical Observation", "SAO 146412"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.56477026),
        dec: Angle.Degrees(-02.39534611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15553"},
        {"Hipparcos Number", "HIP 11630"},
        {"Smithsonian Astrophysical Observation", "SAO 129940"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.52082075),
        dec: Angle.Degrees(-02.39519019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87706"},
        {"Hipparcos Number", "HIP 49528"},
        {"Smithsonian Astrophysical Observation", "SAO 137353"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.68613129),
        dec: Angle.Degrees(-02.39469916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67111"},
        {"Hipparcos Number", "HIP 39672"},
        {"Geneva Identification System", "GEN# +1.00067111"},
        {"Smithsonian Astrophysical Observation", "SAO 135502"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.60969618),
        dec: Angle.Degrees(-02.39381856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10305",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1703 A"},
        {"Henry Draper", "HD 13612"},
        {"Hipparcos Number", "HIP 10305"},
        {"Geneva Identification System", "GEN# +1.00013612A"},
        {"Geneva Identification System 2", "GEN# +1.10013612"},
        {"Smithsonian Astrophysical Observation", "SAO 129752"},
        {"Wilson Evans Batten Catalogue", "WEB 2150"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.19717997),
        dec: Angle.Degrees(-02.39345960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 374.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85386"},
        {"Geneva Identification System", "GEN# -0.00204354"},
        {"Wilson Evans Batten Catalogue", "WEB 14422"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.70472059),
        dec: Angle.Degrees(-02.39340707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158068"},
        {"Hipparcos Number", "HIP 85418"},
        {"Smithsonian Astrophysical Observation", "SAO 141671"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.82069077),
        dec: Angle.Degrees(-02.39315266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79356"},
        {"Hipparcos Number", "HIP 45267"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.38472248),
        dec: Angle.Degrees(-02.39291034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50548"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.87148569),
        dec: Angle.Degrees(-02.39255057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191342"},
        {"Hipparcos Number", "HIP 99320"},
        {"Smithsonian Astrophysical Observation", "SAO 144120"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.39680393),
        dec: Angle.Degrees(-02.39129606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13323"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.86969206),
        dec: Angle.Degrees(-02.38967024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98785"},
        {"Hipparcos Number", "HIP 55510"},
        {"Smithsonian Astrophysical Observation", "SAO 138162"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.53367270),
        dec: Angle.Degrees(-02.38907964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157347"},
        {"Hipparcos Number", "HIP 85042"},
        {"Geneva Identification System", "GEN# +1.00157347"},
        {"Smithsonian Astrophysical Observation", "SAO 141642"},
        {"Wilson Evans Batten Catalogue", "WEB 14362"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.71358055),
        dec: Angle.Degrees(-02.38791454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21380"},
        {"Hipparcos Number", "HIP 16056"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.69740843),
        dec: Angle.Degrees(-02.38653083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43389"},
        {"Hipparcos Number", "HIP 29740"},
        {"Geneva Identification System", "GEN# +1.00043389"},
        {"Smithsonian Astrophysical Observation", "SAO 133038"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.94614484),
        dec: Angle.Degrees(-02.38557484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125754"},
        {"Hipparcos Number", "HIP 70188"},
        {"Smithsonian Astrophysical Observation", "SAO 139885"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.39571938),
        dec: Angle.Degrees(-02.38557061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36826"},
        {"Hipparcos Number", "HIP 26130"},
        {"Celescope Catalog", "CEL 796"},
        {"Geneva Identification System", "GEN# +1.00036826"},
        {"Smithsonian Astrophysical Observation", "SAO 132275"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.57337254),
        dec: Angle.Degrees(-02.38536702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108474"},
        {"Hipparcos Number", "HIP 60806"},
        {"Geneva Identification System", "GEN# +1.00108474"},
        {"Smithsonian Astrophysical Observation", "SAO 138796"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.94347925),
        dec: Angle.Degrees(-02.38490284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79670"},
        {"Geneva Identification System", "GEN# -0.00204146"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.89826528),
        dec: Angle.Degrees(-02.38469918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99184"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03726974),
        dec: Angle.Degrees(-02.38264019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36997"},
        {"Hipparcos Number", "HIP 26216"},
        {"Geneva Identification System", "GEN# +1.00036997"},
        {"Renson", "Renson 9810"},
        {"Smithsonian Astrophysical Observation", "SAO 132309"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.80758441),
        dec: Angle.Degrees(-02.38120483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74549"},
        {"Hipparcos Number", "HIP 42898"},
        {"Smithsonian Astrophysical Observation", "SAO 136231"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.12827577),
        dec: Angle.Degrees(-02.38065064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71991"},
        {"Hipparcos Number", "HIP 41707"},
        {"Geneva Identification System", "GEN# +1.00071991"},
        {"Smithsonian Astrophysical Observation", "SAO 135985"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.57919149),
        dec: Angle.Degrees(-02.38032120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121322"},
        {"Hipparcos Number", "HIP 67946"},
        {"Smithsonian Astrophysical Observation", "SAO 139615"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.71609144),
        dec: Angle.Degrees(-02.38031630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12538"},
        {"Hipparcos Number", "HIP 9563"},
        {"Smithsonian Astrophysical Observation", "SAO 129649"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.71771388),
        dec: Angle.Degrees(-02.37772132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27074"},
        {"Hipparcos Number", "HIP 19937"},
        {"Smithsonian Astrophysical Observation", "SAO 131082"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.14724420),
        dec: Angle.Degrees(-02.37653946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100297"},
        {"Smithsonian Astrophysical Observation", "SAO 144316"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.12897664),
        dec: Angle.Degrees(-02.37589433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122575"},
        {"Hipparcos Number", "HIP 68626"},
        {"Smithsonian Astrophysical Observation", "SAO 139696"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71571650),
        dec: Angle.Degrees(-02.37549493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103476"},
        {"Hipparcos Number", "HIP 58096"},
        {"Smithsonian Astrophysical Observation", "SAO 138478"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.72790324),
        dec: Angle.Degrees(-02.37511423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76526"},
        {"Hipparcos Number", "HIP 43907"},
        {"Fundamental Katalog 5th Edition", "FK5 4798"},
        {"Smithsonian Astrophysical Observation", "SAO 136423"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.17281021),
        dec: Angle.Degrees(-02.37475788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118939"},
        {"Hipparcos Number", "HIP 66686"},
        {"Smithsonian Astrophysical Observation", "SAO 139477"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.05473758),
        dec: Angle.Degrees(-02.37175490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86159"},
        {"Smithsonian Astrophysical Observation", "SAO 141755"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.09734338),
        dec: Angle.Degrees(-02.36988698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205176"},
        {"Hipparcos Number", "HIP 106461"},
        {"Geneva Identification System", "GEN# +1.00205176"},
        {"Smithsonian Astrophysical Observation", "SAO 145489"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.43717895),
        dec: Angle.Degrees(-02.36949443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26053"},
        {"Hipparcos Number", "HIP 19235"},
        {"Smithsonian Astrophysical Observation", "SAO 130959"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.84314748),
        dec: Angle.Degrees(-02.36721823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36341"},
        {"Hipparcos Number", "HIP 25820"},
        {"Geneva Identification System", "GEN# +1.00036341"},
        {"Smithsonian Astrophysical Observation", "SAO 132199"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.70530510),
        dec: Angle.Degrees(-02.36642907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6348"},
        {"Hipparcos Number", "HIP 5031"},
        {"Geneva Identification System", "GEN# +1.00006348"},
        {"Smithsonian Astrophysical Observation", "SAO 129106"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.11080178),
        dec: Angle.Degrees(-02.36626356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77447"},
        {"Hipparcos Number", "HIP 44379"},
        {"Geneva Identification System", "GEN# +1.00077447"},
        {"Smithsonian Astrophysical Observation", "SAO 136521"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.60076132),
        dec: Angle.Degrees(-02.36580103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168671"},
        {"Hipparcos Number", "HIP 89948"},
        {"Smithsonian Astrophysical Observation", "SAO 142238"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.28956205),
        dec: Angle.Degrees(-02.36502237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25542"},
        {"Hipparcos Number", "HIP 18919"},
        {"Geneva Identification System", "GEN# +1.00025542"},
        {"Smithsonian Astrophysical Observation", "SAO 130899"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.82671963),
        dec: Angle.Degrees(-02.36248957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47760"},
        {"Hipparcos Number", "HIP 31904"},
        {"Geneva Identification System", "GEN# +1.00047760"},
        {"Smithsonian Astrophysical Observation", "SAO 133543"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.02308526),
        dec: Angle.Degrees(-02.36166858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23161"},
        {"Hipparcos Number", "HIP 17349"},
        {"Smithsonian Astrophysical Observation", "SAO 130679"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.69402779),
        dec: Angle.Degrees(-02.36071171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35777"},
        {"Hipparcos Number", "HIP 25480"},
        {"Celescope Catalog", "CEL 709"},
        {"Geneva Identification System", "GEN# +1.00035777"},
        {"Smithsonian Astrophysical Observation", "SAO 132116"},
        {"Wilson Evans Batten Catalogue", "WEB 4938"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.74651337),
        dec: Angle.Degrees(-02.36064646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19911"},
        {"Hipparcos Number", "HIP 14878"},
        {"Smithsonian Astrophysical Observation", "SAO 130340"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.01673371),
        dec: Angle.Degrees(-02.36044322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37792"},
        {"Smithsonian Astrophysical Observation", "SAO 135060"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.24337691),
        dec: Angle.Degrees(-02.36034011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65714"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.08746000),
        dec: Angle.Degrees(-02.35910065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -486.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120897"},
        {"Hipparcos Number", "HIP 67723"},
        {"Smithsonian Astrophysical Observation", "SAO 139599"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.10536896),
        dec: Angle.Degrees(-02.35543494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105758"},
        {"Hipparcos Number", "HIP 59345"},
        {"Geneva Identification System", "GEN# +1.00105758"},
        {"Smithsonian Astrophysical Observation", "SAO 138624"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.60909570),
        dec: Angle.Degrees(-02.35531241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112310"},
        {"Cincinnati Publication", "Ci 20 1378"},
        {"Geneva Identification System", "GEN# +9.80027045"},
    },
    visualMagnitude: 11.50,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.23281631),
        dec: Angle.Degrees(-02.35296207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 736.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16886"},
        {"Hipparcos Number", "HIP 12631"},
        {"Smithsonian Astrophysical Observation", "SAO 130065"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.57821729),
        dec: Angle.Degrees(-02.35188843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84741"},
        {"Geneva Identification System", "GEN# -0.00204333J"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.83534715),
        dec: Angle.Degrees(-02.35002418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48056"},
        {"Hipparcos Number", "HIP 32024"},
        {"Geneva Identification System", "GEN# +1.00048056"},
        {"Smithsonian Astrophysical Observation", "SAO 133573"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.34697432),
        dec: Angle.Degrees(-02.34969077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92324"},
        {"Hipparcos Number", "HIP 52176"},
        {"Smithsonian Astrophysical Observation", "SAO 137712"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.89434533),
        dec: Angle.Degrees(-02.34694195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101919"},
        {"Hipparcos Number", "HIP 57208"},
        {"Smithsonian Astrophysical Observation", "SAO 138374"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.95940202),
        dec: Angle.Degrees(-02.34693325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38249"},
        {"Hipparcos Number", "HIP 27056"},
        {"Smithsonian Astrophysical Observation", "SAO 132497"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.07054719),
        dec: Angle.Degrees(-02.34340061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126273"},
        {"Hipparcos Number", "HIP 70439"},
        {"Geneva Identification System", "GEN# +1.00126273"},
        {"Smithsonian Astrophysical Observation", "SAO 139916"},
        {"Wilson Evans Batten Catalogue", "WEB 12222"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.14940364),
        dec: Angle.Degrees(-02.34288416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40548"},
        {"Hipparcos Number", "HIP 28351"},
        {"Geneva Identification System", "GEN# +1.00040548"},
        {"Smithsonian Astrophysical Observation", "SAO 132720"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.85765658),
        dec: Angle.Degrees(-02.34117920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10868"},
        {"Hipparcos Number", "HIP 8269"},
        {"Smithsonian Astrophysical Observation", "SAO 129494"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.63306333),
        dec: Angle.Degrees(-02.34068059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145994"},
        {"Hipparcos Number", "HIP 79562"},
        {"Smithsonian Astrophysical Observation", "SAO 141047"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.51926826),
        dec: Angle.Degrees(-02.33878906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108060"},
        {"Hipparcos Number", "HIP 60572"},
        {"Smithsonian Astrophysical Observation", "SAO 138761"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.23953824),
        dec: Angle.Degrees(-02.33782547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31439"},
        {"Hipparcos Number", "HIP 22908"},
        {"Geneva Identification System", "GEN# +1.00031439"},
        {"Smithsonian Astrophysical Observation", "SAO 131606"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.93980505),
        dec: Angle.Degrees(-02.33779384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18463"},
        {"Hipparcos Number", "HIP 13830"},
        {"Geneva Identification System", "GEN# +1.00018463"},
        {"Smithsonian Astrophysical Observation", "SAO 130210"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.49818146),
        dec: Angle.Degrees(-02.33667654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40591"},
        {"Hipparcos Number", "HIP 28381"},
        {"Geneva Identification System", "GEN# +1.00040591"},
        {"Smithsonian Astrophysical Observation", "SAO 132726"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.93091506),
        dec: Angle.Degrees(-02.33579412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294046"},
        {"Hipparcos Number", "HIP 25394"},
        {"Geneva Identification System", "GEN# +1.00294046"},
        {"Renson", "Renson 9190"},
        {"Smithsonian Astrophysical Observation", "SAO 132094"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.48281206),
        dec: Angle.Degrees(-02.33551824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9716"},
        {"Hipparcos Number", "HIP 7382"},
        {"Fundamental Katalog 5th Edition", "FK5 4143"},
        {"Smithsonian Astrophysical Observation", "SAO 129389"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.77643372),
        dec: Angle.Degrees(-02.33533710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146212"},
        {"Hipparcos Number", "HIP 79650"},
        {"Geneva Identification System", "GEN# +1.00146212"},
        {"Smithsonian Astrophysical Observation", "SAO 141063"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81224672),
        dec: Angle.Degrees(-02.33484715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16329"},
        {"Hipparcos Number", "HIP 12202"},
        {"Geneva Identification System", "GEN# +1.00016329"},
        {"Smithsonian Astrophysical Observation", "SAO 130020"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.28362485),
        dec: Angle.Degrees(-02.33417501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7085"},
        {"Smithsonian Astrophysical Observation", "SAO 129347"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.81672122),
        dec: Angle.Degrees(-02.33311675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20196"},
        {"Hipparcos Number", "HIP 15089"},
        {"Smithsonian Astrophysical Observation", "SAO 130374"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.65059063),
        dec: Angle.Degrees(-02.33282602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22918"},
        {"Hipparcos Number", "HIP 17183"},
        {"Cincinnati Publication", "Ci 20 251"},
        {"Cincinnati Publication 2", "Ci 18 490"},
        {"Geneva Identification System", "GEN# +1.00022918"},
        {"Smithsonian Astrophysical Observation", "SAO 130653"},
        {"Wilson Evans Batten Catalogue", "WEB 3254"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.19672534),
        dec: Angle.Degrees(-02.33214712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 374.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13228"},
        {"Hipparcos Number", "HIP 10033"},
        {"Geneva Identification System", "GEN# +1.00013228"},
        {"Smithsonian Astrophysical Observation", "SAO 129722"},
        {"Wilson Evans Batten Catalogue", "WEB 2102"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.28827186),
        dec: Angle.Degrees(-02.33184994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139782"},
        {"Hipparcos Number", "HIP 76738"},
        {"Smithsonian Astrophysical Observation", "SAO 140687"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.05851749),
        dec: Angle.Degrees(-02.32849876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24031"},
        {"Hipparcos Number", "HIP 17895"},
        {"Geneva Identification System", "GEN# +1.00024031"},
        {"Smithsonian Astrophysical Observation", "SAO 130752"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.41117660),
        dec: Angle.Degrees(-02.32846723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24383"},
        {"Hipparcos Number", "HIP 18135"},
        {"Smithsonian Astrophysical Observation", "SAO 130786"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.15926763),
        dec: Angle.Degrees(-02.32844943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197233"},
        {"Hipparcos Number", "HIP 102198"},
        {"Smithsonian Astrophysical Observation", "SAO 144726"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.61414573),
        dec: Angle.Degrees(-02.32689497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149661"},
        {"Hipparcos Number", "HIP 81300"},
        {"Cincinnati Publication", "Ci 20 1002"},
        {"Fundamental Katalog 5th Edition", "FK5 1433"},
        {"Geneva Identification System", "GEN# +1.00149661"},
        {"Smithsonian Astrophysical Observation", "SAO 141269"},
        {"Wilson Evans Batten Catalogue", "WEB 13740"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.08826456),
        dec: Angle.Degrees(-02.32383592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 455.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293959"},
        {"Hipparcos Number", "HIP 24842"},
        {"Smithsonian Astrophysical Observation", "SAO 131982"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.88946502),
        dec: Angle.Degrees(-02.32233071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200435"},
        {"Hipparcos Number", "HIP 103932"},
        {"Smithsonian Astrophysical Observation", "SAO 145057"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.87297142),
        dec: Angle.Degrees(-02.32212439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4565"},
        {"Hipparcos Number", "HIP 3708"},
        {"Smithsonian Astrophysical Observation", "SAO 128957"},
        {"Wilson Evans Batten Catalogue", "WEB 658"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.90371340),
        dec: Angle.Degrees(-02.32187676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109756"},
        {"Hipparcos Number", "HIP 61578"},
        {"Geneva Identification System", "GEN# +1.00109756"},
        {"Smithsonian Astrophysical Observation", "SAO 138876"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.27807435),
        dec: Angle.Degrees(-02.32174859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121814"},
        {"Hipparcos Number", "HIP 68210"},
        {"Smithsonian Astrophysical Observation", "SAO 139651"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.47150159),
        dec: Angle.Degrees(-02.31848557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117635"},
        {"Hipparcos Number", "HIP 65982"},
        {"Cincinnati Publication", "Ci 20 785"},
        {"Geneva Identification System", "GEN# +1.00117635"},
        {"Smithsonian Astrophysical Observation", "SAO 139384"},
        {"Wilson Evans Batten Catalogue", "WEB 11669"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.91848492),
        dec: Angle.Degrees(-02.31804600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -854.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 267.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18163"},
        {"Hipparcos Number", "HIP 13576"},
        {"Smithsonian Astrophysical Observation", "SAO 130183"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.72058300),
        dec: Angle.Degrees(-02.31549330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116544"},
        {"Hipparcos Number", "HIP 65411"},
        {"Smithsonian Astrophysical Observation", "SAO 139320"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.10050191),
        dec: Angle.Degrees(-02.31491397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185842"},
        {"Hipparcos Number", "HIP 96851"},
        {"Geneva Identification System", "GEN# +1.00185842"},
        {"Renson", "Renson 51256"},
        {"Smithsonian Astrophysical Observation", "SAO 143695"},
        {"Wilson Evans Batten Catalogue", "WEB 16999"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.29994723),
        dec: Angle.Degrees(-02.31344307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38087"},
        {"Hipparcos Number", "HIP 26939"},
        {"Geneva Identification System", "GEN# +1.00038087"},
        {"Smithsonian Astrophysical Observation", "SAO 132478"},
        {"Wilson Evans Batten Catalogue", "WEB 5313"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.75237544),
        dec: Angle.Degrees(-02.31261304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148476"},
        {"Hipparcos Number", "HIP 80694"},
        {"Smithsonian Astrophysical Observation", "SAO 141194"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14248226),
        dec: Angle.Degrees(-02.31004007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41218"},
        {"Smithsonian Astrophysical Observation", "SAO 135879"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.15866983),
        dec: Angle.Degrees(-02.30897604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82607"},
        {"Hipparcos Number", "HIP 46865"},
        {"Smithsonian Astrophysical Observation", "SAO 136944"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.24325956),
        dec: Angle.Degrees(-02.30849849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175445"},
        {"Hipparcos Number", "HIP 92884"},
        {"Geneva Identification System", "GEN# +1.00175445"},
        {"Smithsonian Astrophysical Observation", "SAO 142803"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.88866556),
        dec: Angle.Degrees(-02.30653816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164286"},
        {"Hipparcos Number", "HIP 88183"},
        {"Smithsonian Astrophysical Observation", "SAO 142028"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.13866867),
        dec: Angle.Degrees(-02.30600311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216514"},
        {"Hipparcos Number", "HIP 113037"},
        {"Smithsonian Astrophysical Observation", "SAO 146372"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.38619310),
        dec: Angle.Degrees(-02.30564495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37805"},
        {"Hipparcos Number", "HIP 26756"},
        {"Geneva Identification System", "GEN# +1.00037805"},
        {"Smithsonian Astrophysical Observation", "SAO 132451"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.26111588),
        dec: Angle.Degrees(-02.30481561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148818"},
        {"Hipparcos Number", "HIP 80872"},
        {"Smithsonian Astrophysical Observation", "SAO 141215"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.70436645),
        dec: Angle.Degrees(-02.30466645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153850"},
        {"Hipparcos Number", "HIP 83351"},
        {"Smithsonian Astrophysical Observation", "SAO 141494"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.51693194),
        dec: Angle.Degrees(-02.30308262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205855"},
        {"Hipparcos Number", "HIP 106825"},
        {"Cincinnati Publication", "Ci 18 2808"},
        {"Cincinnati Publication 2", "Ci 20 1298"},
        {"Geneva Identification System", "GEN# +1.00205855"},
        {"Smithsonian Astrophysical Observation", "SAO 145546"},
        {"Wilson Evans Batten Catalogue", "WEB 19312"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.53622873),
        dec: Angle.Degrees(-02.30246874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -464.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212337"},
        {"Hipparcos Number", "HIP 110536"},
        {"Geneva Identification System", "GEN# +1.00212337"},
        {"Smithsonian Astrophysical Observation", "SAO 146063"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.88743020),
        dec: Angle.Degrees(-02.30150800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97917"},
        {"Hipparcos Number", "HIP 55011"},
        {"Geneva Identification System", "GEN# +1.00097917"},
        {"Smithsonian Astrophysical Observation", "SAO 138091"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.95136576),
        dec: Angle.Degrees(-02.29930574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130952"},
        {"Hipparcos Number", "HIP 72631"},
        {"Geneva Identification System", "GEN# +1.00130952"},
        {"Smithsonian Astrophysical Observation", "SAO 140176"},
        {"Wilson Evans Batten Catalogue", "WEB 12485"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.75425052),
        dec: Angle.Degrees(-02.29884995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206513"},
        {"Hipparcos Number", "HIP 107190"},
        {"Geneva Identification System", "GEN# +1.00206513"},
        {"Smithsonian Astrophysical Observation", "SAO 145608"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.66717317),
        dec: Angle.Degrees(-02.29805490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133893"},
        {"Hipparcos Number", "HIP 73972"},
        {"Smithsonian Astrophysical Observation", "SAO 140329"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.75186677),
        dec: Angle.Degrees(-02.29754651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9944"},
        {"Smithsonian Astrophysical Observation", "SAO 129709"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.99979772),
        dec: Angle.Degrees(-02.29314287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207150"},
        {"Hipparcos Number", "HIP 107564"},
        {"Geneva Identification System", "GEN# +1.00207150"},
        {"Smithsonian Astrophysical Observation", "SAO 145664"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.78332435),
        dec: Angle.Degrees(-02.29224738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109205"},
        {"Hipparcos Number", "HIP 61245"},
        {"Geneva Identification System", "GEN# +1.00109205"},
        {"Smithsonian Astrophysical Observation", "SAO 138840"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.26195142),
        dec: Angle.Degrees(-02.29065496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33190"},
        {"Hipparcos Number", "HIP 23919"},
        {"Geneva Identification System", "GEN# +1.00033190"},
        {"Smithsonian Astrophysical Observation", "SAO 131803"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.08925534),
        dec: Angle.Degrees(-02.28961038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62602"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.42611237),
        dec: Angle.Degrees(-02.28927649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86170"},
        {"Hipparcos Number", "HIP 48760"},
        {"Geneva Identification System", "GEN# +1.00086170"},
        {"Renson", "Renson 24620"},
        {"Smithsonian Astrophysical Observation", "SAO 137242"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.18829160),
        dec: Angle.Degrees(-02.28902409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178484"},
        {"Hipparcos Number", "HIP 94053"},
        {"Geneva Identification System", "GEN# +1.00178484"},
        {"Smithsonian Astrophysical Observation", "SAO 143070"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.21766714),
        dec: Angle.Degrees(-02.28723715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154637"},
        {"Hipparcos Number", "HIP 83736"},
        {"Smithsonian Astrophysical Observation", "SAO 141521"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.70958408),
        dec: Angle.Degrees(-02.28602982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72094"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.22663984),
        dec: Angle.Degrees(-02.28550830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39438"},
        {"Hipparcos Number", "HIP 27758"},
        {"Geneva Identification System", "GEN# +1.00039438"},
        {"Smithsonian Astrophysical Observation", "SAO 132608"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.12282384),
        dec: Angle.Degrees(-02.28531335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66121"},
        {"Hipparcos Number", "HIP 39292"},
        {"Smithsonian Astrophysical Observation", "SAO 135397"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.51534367),
        dec: Angle.Degrees(-02.28260589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73982",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9504 AB"},
        {"Henry Draper", "HD 133928"},
        {"Hipparcos Number", "HIP 73982"},
        {"Geneva Identification System", "GEN# +1.00133928"},
        {"Smithsonian Astrophysical Observation", "SAO 140332"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.78588082),
        dec: Angle.Degrees(-02.28068517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7727"},
        {"Hipparcos Number", "HIP 5985"},
        {"Fundamental Katalog 5th Edition", "FK5 4114"},
        {"Geneva Identification System", "GEN# +1.00007727"},
        {"Smithsonian Astrophysical Observation", "SAO 129210"},
        {"Wilson Evans Batten Catalogue", "WEB 1357"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.24522939),
        dec: Angle.Degrees(-02.27881800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 259.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142011"},
        {"Hipparcos Number", "HIP 77728"},
        {"Smithsonian Astrophysical Observation", "SAO 140809"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.05217697),
        dec: Angle.Degrees(-02.27838623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212110"},
        {"Hipparcos Number", "HIP 110426"},
        {"Geneva Identification System", "GEN# +1.00212110"},
        {"Smithsonian Astrophysical Observation", "SAO 146049"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.50598586),
        dec: Angle.Degrees(-02.27775093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290327"},
        {"Hipparcos Number", "HIP 25191"},
        {"Smithsonian Astrophysical Observation", "SAO 132049"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.83977021),
        dec: Angle.Degrees(-02.27738354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90080"},
        {"Hipparcos Number", "HIP 50914"},
        {"Geneva Identification System", "GEN# +1.00090080"},
        {"Smithsonian Astrophysical Observation", "SAO 137537"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.95372297),
        dec: Angle.Degrees(-02.27603986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15167"},
        {"Hipparcos Number", "HIP 11368"},
        {"Smithsonian Astrophysical Observation", "SAO 129902"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.61067428),
        dec: Angle.Degrees(-02.27345778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9992 B"},
        {"Henry Draper", "HD 146773"},
        {"Hipparcos Number", "HIP 79869"},
        {"Smithsonian Astrophysical Observation", "SAO 141084"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.54458886),
        dec: Angle.Degrees(-02.27345146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49643"},
        {"Hipparcos Number", "HIP 32698"},
        {"Fundamental Katalog 5th Edition", "FK5 1179"},
        {"Geneva Identification System", "GEN# +2.22861571"},
        {"Smithsonian Astrophysical Observation", "SAO 133718"},
        {"Wilson Evans Batten Catalogue", "WEB 6588"},
        {"New General Catalogue", "NGC 2286 1571"},
    },
    visualMagnitude: 5.75,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31839228),
        dec: Angle.Degrees(-02.27202783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86947"},
        {"Hipparcos Number", "HIP 49151"},
        {"Smithsonian Astrophysical Observation", "SAO 137299"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.46726310),
        dec: Angle.Degrees(-02.27101616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9992 A"},
        {"Hipparcos Number", "HIP 79868"},
        {"Smithsonian Astrophysical Observation", "SAO 141085"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.54429502),
        dec: Angle.Degrees(-02.27048051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186844"},
        {"Hipparcos Number", "HIP 97333"},
        {"Smithsonian Astrophysical Observation", "SAO 143793"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.73684668),
        dec: Angle.Degrees(-02.27035303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11606",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1900 AB"},
        {"Henry Draper", "HD 15513"},
        {"Hipparcos Number", "HIP 11606"},
        {"Smithsonian Astrophysical Observation", "SAO 129936"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.42881367),
        dec: Angle.Degrees(-02.26714567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155611"},
        {"Hipparcos Number", "HIP 84211"},
        {"Smithsonian Astrophysical Observation", "SAO 141559"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.21308151),
        dec: Angle.Degrees(-02.26704132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125454"},
        {"Hipparcos Number", "HIP 70012"},
        {"Fundamental Katalog 5th Edition", "FK5 3134"},
        {"Geneva Identification System", "GEN# +1.00125454"},
        {"Smithsonian Astrophysical Observation", "SAO 139866"},
        {"Wilson Evans Batten Catalogue", "WEB 12175"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.88562263),
        dec: Angle.Degrees(-02.26534352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147738"},
        {"Hipparcos Number", "HIP 80306"},
        {"Smithsonian Astrophysical Observation", "SAO 141144"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.93215327),
        dec: Angle.Degrees(-02.26508516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114783"},
        {"Hipparcos Number", "HIP 64457"},
        {"Geneva Identification System", "GEN# +1.00114783"},
        {"Smithsonian Astrophysical Observation", "SAO 139218"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.18277753),
        dec: Angle.Degrees(-02.26506302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117557"},
        {"Hipparcos Number", "HIP 65943"},
        {"Smithsonian Astrophysical Observation", "SAO 139380"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.79307487),
        dec: Angle.Degrees(-02.26220824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198666"},
        {"Hipparcos Number", "HIP 102996"},
        {"Smithsonian Astrophysical Observation", "SAO 144887"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.00762206),
        dec: Angle.Degrees(-02.26131943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77185"},
        {"Geneva Identification System", "GEN# +9.80016008"},
    },
    visualMagnitude: 11.61,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.41338729),
        dec: Angle.Degrees(-02.26116200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -286.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114322",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ebla"},
        {"Henry Draper", "HD 218566"},
        {"Hipparcos Number", "HIP 114322"},
        {"Cincinnati Publication", "Ci 20 1403"},
        {"Geneva Identification System", "GEN# +1.00218566"},
        {"Smithsonian Astrophysical Observation", "SAO 146533"},
        {"Wilson Evans Batten Catalogue", "WEB 20296"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.29316016),
        dec: Angle.Degrees(-02.26050792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 632.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10859 B"},
        {"Hipparcos Number", "HIP 87537"},
    },
    visualMagnitude: 10.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.25207898),
        dec: Angle.Degrees(-02.26050356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10095 AB"},
        {"Henry Draper", "HD 148943"},
        {"Hipparcos Number", "HIP 80949"},
        {"Geneva Identification System", "GEN# +1.00148943J"},
        {"Smithsonian Astrophysical Observation", "SAO 141224"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.93786662),
        dec: Angle.Degrees(-02.25998617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134737"},
        {"Hipparcos Number", "HIP 74338"},
        {"Geneva Identification System", "GEN# +1.00134737"},
        {"Smithsonian Astrophysical Observation", "SAO 140368"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.89622052),
        dec: Angle.Degrees(-02.25997288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37903"},
        {"Hipparcos Number", "HIP 26816"},
        {"Celescope Catalog", "CEL 935"},
        {"Geneva Identification System", "GEN# +1.00037903"},
        {"Smithsonian Astrophysical Observation", "SAO 132464"},
        {"Wilson Evans Batten Catalogue", "WEB 5286"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.40995419),
        dec: Angle.Degrees(-02.25902182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37141"},
        {"Hipparcos Number", "HIP 26312"},
        {"Geneva Identification System", "GEN# +1.00037141"},
        {"Smithsonian Astrophysical Observation", "SAO 132348"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.05868879),
        dec: Angle.Degrees(-02.25883118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87536",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10859 A"},
        {"Hipparcos Number", "HIP 87536"},
        {"Smithsonian Astrophysical Observation", "SAO 141938"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.24744657),
        dec: Angle.Degrees(-02.25745016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213999"},
        {"Hipparcos Number", "HIP 111495"},
        {"Fundamental Katalog 5th Edition", "FK5 5992"},
        {"Smithsonian Astrophysical Observation", "SAO 146180"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.83467197),
        dec: Angle.Degrees(-02.25722399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7967 A"},
        {"Henry Draper", "HD 94363"},
        {"Hipparcos Number", "HIP 53240"},
        {"Geneva Identification System", "GEN# +1.00094363A"},
        {"Smithsonian Astrophysical Observation", "SAO 137863"},
        {"Wilson Evans Batten Catalogue", "WEB 9663"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35433053),
        dec: Angle.Degrees(-02.25500952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33555"},
        {"Hipparcos Number", "HIP 24130"},
        {"Geneva Identification System", "GEN# +1.00033555"},
        {"Smithsonian Astrophysical Observation", "SAO 131847"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.74156183),
        dec: Angle.Degrees(-02.25374808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42959"},
        {"Hipparcos Number", "HIP 29551"},
        {"Celescope Catalog", "CEL 1129"},
        {"Geneva Identification System", "GEN# +1.00042959"},
        {"Smithsonian Astrophysical Observation", "SAO 132986"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.39924539),
        dec: Angle.Degrees(-02.25331278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44937"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.30293910),
        dec: Angle.Degrees(-02.25278691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64709"},
        {"Hipparcos Number", "HIP 38674"},
        {"Geneva Identification System", "GEN# +1.00064709"},
        {"Smithsonian Astrophysical Observation", "SAO 135251"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.77227115),
        dec: Angle.Degrees(-02.25276538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110536"},
        {"Hipparcos Number", "HIP 62036"},
        {"Geneva Identification System", "GEN# +1.00110536A"},
        {"Smithsonian Astrophysical Observation", "SAO 138927"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.73418368),
        dec: Angle.Degrees(-02.25123327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7147"},
        {"Hipparcos Number", "HIP 5594"},
        {"Geneva Identification System", "GEN# +1.00007147"},
        {"Smithsonian Astrophysical Observation", "SAO 129169"},
        {"Wilson Evans Batten Catalogue", "WEB 1250"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.93142731),
        dec: Angle.Degrees(-02.25102487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58556"},
        {"Hipparcos Number", "HIP 36071"},
        {"Geneva Identification System", "GEN# +1.00058556"},
        {"Smithsonian Astrophysical Observation", "SAO 134655"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48844330),
        dec: Angle.Degrees(-02.24835274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193330"},
        {"Hipparcos Number", "HIP 100246"},
        {"Smithsonian Astrophysical Observation", "SAO 144303"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.96947493),
        dec: Angle.Degrees(-02.24750695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21837"},
        {"Hipparcos Number", "HIP 16390"},
        {"Smithsonian Astrophysical Observation", "SAO 130539"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.77030655),
        dec: Angle.Degrees(-02.24737539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72574"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.58328193),
        dec: Angle.Degrees(-02.24535531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198815"},
        {"Hipparcos Number", "HIP 103072"},
        {"Smithsonian Astrophysical Observation", "SAO 144902"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.25486991),
        dec: Angle.Degrees(-02.24465048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221629"},
        {"Hipparcos Number", "HIP 116290"},
        {"Smithsonian Astrophysical Observation", "SAO 146776"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.42299721),
        dec: Angle.Degrees(-02.24448168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27752"},
        {"Hipparcos Number", "HIP 20438"},
        {"Smithsonian Astrophysical Observation", "SAO 131157"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.67708788),
        dec: Angle.Degrees(-02.24418609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207773"},
        {"Hipparcos Number", "HIP 107878"},
        {"Smithsonian Astrophysical Observation", "SAO 145706"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.86234114),
        dec: Angle.Degrees(-02.24290090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46871"},
        {"Hipparcos Number", "HIP 31480"},
        {"Geneva Identification System", "GEN# +1.00046871"},
        {"Smithsonian Astrophysical Observation", "SAO 133445"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89908421),
        dec: Angle.Degrees(-02.24269380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141694"},
        {"Hipparcos Number", "HIP 77594"},
        {"Geneva Identification System", "GEN# +1.00141694"},
        {"Smithsonian Astrophysical Observation", "SAO 140795"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.62656392),
        dec: Angle.Degrees(-02.24185617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100245"},
        {"Smithsonian Astrophysical Observation", "SAO 144301"},
    },
    visualMagnitude: 9.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)19, 52.2200),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)14, 29.500)
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
    primaryId: "HIP 47649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84126"},
        {"Hipparcos Number", "HIP 47649"},
        {"Smithsonian Astrophysical Observation", "SAO 137071"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.71894077),
        dec: Angle.Degrees(-02.24069527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95102"},
        {"Hipparcos Number", "HIP 53668"},
        {"Geneva Identification System", "GEN# +1.00095102"},
        {"Smithsonian Astrophysical Observation", "SAO 137919"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.70862292),
        dec: Angle.Degrees(-02.23614740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149476"},
        {"Hipparcos Number", "HIP 81206"},
        {"Smithsonian Astrophysical Observation", "SAO 141257"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.80128449),
        dec: Angle.Degrees(-02.23590652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79080"},
        {"Hipparcos Number", "HIP 45142"},
        {"Fundamental Katalog 5th Edition", "FK5 4820"},
        {"Smithsonian Astrophysical Observation", "SAO 136650"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.96400688),
        dec: Angle.Degrees(-02.23527323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137227"},
        {"Hipparcos Number", "HIP 75456"},
        {"Smithsonian Astrophysical Observation", "SAO 140517"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.22974888),
        dec: Angle.Degrees(-02.23519516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20673",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3214 AB"},
        {"Henry Draper", "HD 28072"},
        {"Hipparcos Number", "HIP 20673"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.42420639),
        dec: Angle.Degrees(-02.23245765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13178 AB"},
        {"Henry Draper", "HD 189073"},
        {"Hipparcos Number", "HIP 98301"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.59497533),
        dec: Angle.Degrees(-02.23187235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290976"},
        {"Hipparcos Number", "HIP 27985"},
        {"Smithsonian Astrophysical Observation", "SAO 132644"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.77791037),
        dec: Angle.Degrees(-02.23163046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29226"},
        {"Hipparcos Number", "HIP 21429"},
        {"Celescope Catalog", "CEL 437"},
        {"Geneva Identification System", "GEN# +1.00029226"},
        {"Smithsonian Astrophysical Observation", "SAO 131343"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.00801558),
        dec: Angle.Degrees(-02.23027780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100645"},
        {"Hipparcos Number", "HIP 56493"},
        {"Smithsonian Astrophysical Observation", "SAO 138283"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.71989117),
        dec: Angle.Degrees(-02.23025247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28624"},
        {"Hipparcos Number", "HIP 21033"},
        {"Geneva Identification System", "GEN# +1.00028624"},
        {"Smithsonian Astrophysical Observation", "SAO 131256"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.64266682),
        dec: Angle.Degrees(-02.22966510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13598"},
        {"Hipparcos Number", "HIP 10298"},
        {"Smithsonian Astrophysical Observation", "SAO 129750"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.17329812),
        dec: Angle.Degrees(-02.22806048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70755",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Elgafar"},
        {"Aitken", "ADS 9273 A"},
        {"Aitken 2", "ADS 9273 AB"},
        {"Henry Draper", "HD 126868"},
        {"Hipparcos Number", "HIP 70755"},
        {"Fundamental Katalog 5th Edition", "FK5 533"},
        {"Geneva Identification System", "GEN# +1.00126868"},
        {"Smithsonian Astrophysical Observation", "SAO 139951"},
        {"Wilson Evans Batten Catalogue", "WEB 12257"},
    },
    visualMagnitude: 4.81,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.05091806),
        dec: Angle.Degrees(-02.22795009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14427"},
        {"Hipparcos Number", "HIP 10863"},
        {"Smithsonian Astrophysical Observation", "SAO 129832"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.94612557),
        dec: Angle.Degrees(-02.22531667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116680"},
        {"Hipparcos Number", "HIP 65478"},
        {"Smithsonian Astrophysical Observation", "SAO 139331"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.30744218),
        dec: Angle.Degrees(-02.22529242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 406"},
        {"Hipparcos Number", "HIP 700"},
        {"Geneva Identification System", "GEN# +1.00000406"},
        {"Smithsonian Astrophysical Observation", "SAO 128607"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.17953436),
        dec: Angle.Degrees(-02.22257211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22897"},
        {"Hipparcos Number", "HIP 17165"},
        {"Geneva Identification System", "GEN# +1.00022897"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.14302139),
        dec: Angle.Degrees(-02.21995947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2023"},
        {"Hipparcos Number", "HIP 1939"},
        {"Fundamental Katalog 5th Edition", "FK5 2021"},
        {"Geneva Identification System", "GEN# +1.00002023"},
        {"Smithsonian Astrophysical Observation", "SAO 128743"},
        {"Wilson Evans Batten Catalogue", "WEB 363"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.12362201),
        dec: Angle.Degrees(-02.21896140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43521"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.96328031),
        dec: Angle.Degrees(-02.21644047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207076"},
        {"Hipparcos Number", "HIP 107516"},
        {"Fundamental Katalog 5th Edition", "FK5 3740"},
        {"Geneva Identification System", "GEN# +1.00207076"},
        {"Smithsonian Astrophysical Observation", "SAO 145652"},
        {"Wilson Evans Batten Catalogue", "WEB 19406"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.63263740),
        dec: Angle.Degrees(-02.21280602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3570 A"},
        {"Henry Draper", "HD 31739"},
        {"Hipparcos Number", "HIP 23092"},
        {"Geneva Identification System", "GEN# +1.00031739"},
        {"Smithsonian Astrophysical Observation", "SAO 131640"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54543641),
        dec: Angle.Degrees(-02.21276853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99210"},
        {"Hipparcos Number", "HIP 55713"},
        {"Geneva Identification System", "GEN# +1.00099210"},
        {"Renson", "Renson 28580"},
        {"Smithsonian Astrophysical Observation", "SAO 138190"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24258512),
        dec: Angle.Degrees(-02.21227763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77838"},
        {"Hipparcos Number", "HIP 44564"},
        {"Smithsonian Astrophysical Observation", "SAO 136555"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.19911786),
        dec: Angle.Degrees(-02.20817235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82043"},
        {"Hipparcos Number", "HIP 46529"},
        {"Geneva Identification System", "GEN# +1.00082043"},
        {"Smithsonian Astrophysical Observation", "SAO 136899"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.35196411),
        dec: Angle.Degrees(-02.20517624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90969"},
        {"Hipparcos Number", "HIP 51409"},
        {"Smithsonian Astrophysical Observation", "SAO 137605"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.50838338),
        dec: Angle.Degrees(-02.20324638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8734"},
        {"Hipparcos Number", "HIP 6700"},
        {"Geneva Identification System", "GEN# +1.00008734"},
        {"Smithsonian Astrophysical Observation", "SAO 129294"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.52602270),
        dec: Angle.Degrees(-02.20091250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 999"},
        {"Hipparcos Number", "HIP 1153"},
        {"Smithsonian Astrophysical Observation", "SAO 128654"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.60195560),
        dec: Angle.Degrees(-02.19792352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36617"},
        {"Hipparcos Number", "HIP 25992"},
        {"Geneva Identification System", "GEN# +1.00036617"},
        {"Smithsonian Astrophysical Observation", "SAO 132240"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.20732963),
        dec: Angle.Degrees(-02.19702426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161961"},
        {"Hipparcos Number", "HIP 87170"},
        {"Geneva Identification System", "GEN# +1.00161961"},
        {"Smithsonian Astrophysical Observation", "SAO 141889"},
        {"Wilson Evans Batten Catalogue", "WEB 14707"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.15356845),
        dec: Angle.Degrees(-02.19619517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96325"},
        {"Smithsonian Astrophysical Observation", "SAO 143557"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.77200240),
        dec: Angle.Degrees(-02.19597200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44639"},
        {"Hipparcos Number", "HIP 30326"},
        {"Geneva Identification System", "GEN# +1.00044639"},
        {"Smithsonian Astrophysical Observation", "SAO 133182"},
        {"Wilson Evans Batten Catalogue", "WEB 6030"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.68157840),
        dec: Angle.Degrees(-02.19533937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122530"},
        {"Hipparcos Number", "HIP 68595"},
        {"Geneva Identification System", "GEN# +1.00122530"},
        {"Smithsonian Astrophysical Observation", "SAO 139692"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63437869),
        dec: Angle.Degrees(-02.19506959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40009"},
        {"Hipparcos Number", "HIP 28069"},
        {"Renson", "Renson 10666"},
        {"Smithsonian Astrophysical Observation", "SAO 132667"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.01001817),
        dec: Angle.Degrees(-02.19104819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64793"},
        {"Hipparcos Number", "HIP 38714"},
        {"Geneva Identification System", "GEN# +1.00064793"},
        {"Smithsonian Astrophysical Observation", "SAO 135260"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.88870700),
        dec: Angle.Degrees(-02.18998353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92788"},
        {"Hipparcos Number", "HIP 52409"},
        {"Geneva Identification System", "GEN# +1.00092788"},
        {"Smithsonian Astrophysical Observation", "SAO 137743"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.70223359),
        dec: Angle.Degrees(-02.18321454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47160"},
        {"Hipparcos Number", "HIP 31629"},
        {"Geneva Identification System", "GEN# +1.00047160"},
        {"Smithsonian Astrophysical Observation", "SAO 133484"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.27395341),
        dec: Angle.Degrees(-02.17902968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96551"},
        {"Hipparcos Number", "HIP 54371"},
        {"Geneva Identification System", "GEN# +1.00096551"},
        {"Smithsonian Astrophysical Observation", "SAO 137996"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.86347430),
        dec: Angle.Degrees(-02.17890570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67811"},
        {"Hipparcos Number", "HIP 39962"},
        {"Geneva Identification System", "GEN# +1.00067811"},
        {"Smithsonian Astrophysical Observation", "SAO 135567"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.40068818),
        dec: Angle.Degrees(-02.17767263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50170"},
        {"Hipparcos Number", "HIP 32957"},
        {"Geneva Identification System", "GEN# +1.00050170"},
        {"Smithsonian Astrophysical Observation", "SAO 133789"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.96592783),
        dec: Angle.Degrees(-02.17603329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18045"},
        {"Hipparcos Number", "HIP 13497"},
        {"Smithsonian Astrophysical Observation", "SAO 130177"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.45843851),
        dec: Angle.Degrees(-02.17135219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39458"},
        {"Hipparcos Number", "HIP 27772"},
        {"Smithsonian Astrophysical Observation", "SAO 132610"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.15425120),
        dec: Angle.Degrees(-02.16857708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141308"},
        {"Hipparcos Number", "HIP 77439"},
        {"Geneva Identification System", "GEN# +1.00141308"},
        {"Smithsonian Astrophysical Observation", "SAO 140770"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.12422568),
        dec: Angle.Degrees(-02.16766646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136161"},
        {"Hipparcos Number", "HIP 74972"},
        {"Geneva Identification System", "GEN# +1.00136161"},
        {"Smithsonian Astrophysical Observation", "SAO 140455"},
        {"Wilson Evans Batten Catalogue", "WEB 12789"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.81094223),
        dec: Angle.Degrees(-02.16709318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40145"},
        {"Hipparcos Number", "HIP 28158"},
        {"Geneva Identification System", "GEN# +1.00040145"},
        {"Smithsonian Astrophysical Observation", "SAO 132681"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.25397152),
        dec: Angle.Degrees(-02.16672284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36541",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6147 AB"},
        {"Henry Draper", "HD 59690"},
        {"Hipparcos Number", "HIP 36541"},
        {"Smithsonian Astrophysical Observation", "SAO 134776"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.74629585),
        dec: Angle.Degrees(-02.16487602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142661"},
        {"Hipparcos Number", "HIP 78024"},
        {"Smithsonian Astrophysical Observation", "SAO 140842"},
        {"Wilson Evans Batten Catalogue", "WEB 13194"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.97765449),
        dec: Angle.Degrees(-02.16425957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 292151"},
        {"Hipparcos Number", "HIP 32046"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.43024393),
        dec: Angle.Degrees(-02.16281347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28206"},
        {"Hipparcos Number", "HIP 20764"},
        {"Smithsonian Astrophysical Observation", "SAO 131216"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.73171624),
        dec: Angle.Degrees(-02.16251285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10506"},
        {"Hipparcos Number", "HIP 7971"},
        {"Geneva Identification System", "GEN# +1.00010506"},
        {"Smithsonian Astrophysical Observation", "SAO 129461"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.60454913),
        dec: Angle.Degrees(-02.16034152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209409"},
        {"Hipparcos Number", "HIP 108874"},
        {"Celescope Catalog", "CEL 5423"},
        {"Fundamental Katalog 5th Edition", "FK5 3765"},
        {"Geneva Identification System", "GEN# +1.00209409"},
        {"Smithsonian Astrophysical Observation", "SAO 145837"},
        {"Wilson Evans Batten Catalogue", "WEB 19582"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.82845686),
        dec: Angle.Degrees(-02.15533588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293022"},
        {"Hipparcos Number", "HIP 33822"},
        {"Smithsonian Astrophysical Observation", "SAO 134055"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.31834477),
        dec: Angle.Degrees(-02.15517292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222294"},
        {"Hipparcos Number", "HIP 116732"},
        {"Smithsonian Astrophysical Observation", "SAO 146825"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.84736895),
        dec: Angle.Degrees(-02.15457187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293018"},
        {"Hipparcos Number", "HIP 33834"},
        {"Smithsonian Astrophysical Observation", "SAO 134059"},
    },
    visualMagnitude: 9.96,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.35371173),
        dec: Angle.Degrees(-02.15439113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187818"},
        {"Hipparcos Number", "HIP 97768"},
        {"Smithsonian Astrophysical Observation", "SAO 143863"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.01643258),
        dec: Angle.Degrees(-02.15324213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163793"},
        {"Hipparcos Number", "HIP 87972"},
        {"Smithsonian Astrophysical Observation", "SAO 141993"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.54502151),
        dec: Angle.Degrees(-02.15320781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160471"},
        {"Hipparcos Number", "HIP 86476"},
        {"Geneva Identification System", "GEN# +1.00160471"},
        {"Smithsonian Astrophysical Observation", "SAO 141798"},
        {"Wilson Evans Batten Catalogue", "WEB 14586"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.04977730),
        dec: Angle.Degrees(-02.15227627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72660"},
        {"Hipparcos Number", "HIP 42028"},
        {"Fundamental Katalog 5th Edition", "FK5 2669"},
        {"Geneva Identification System", "GEN# +1.00072660"},
        {"Renson", "Renson 20145"},
        {"Smithsonian Astrophysical Observation", "SAO 136044"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.50682149),
        dec: Angle.Degrees(-02.15160482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82996"},
        {"Hipparcos Number", "HIP 47052"},
        {"Smithsonian Astrophysical Observation", "SAO 136981"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.82836883),
        dec: Angle.Degrees(-02.15036031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37294"},
    },
    visualMagnitude: 11.25,
    bvColour: 2.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86270101),
        dec: Angle.Degrees(-02.15026450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35195"},
        {"Hipparcos Number", "HIP 25152"},
        {"Smithsonian Astrophysical Observation", "SAO 132040"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.74083029),
        dec: Angle.Degrees(-02.14967986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223205"},
        {"Hipparcos Number", "HIP 117333"},
        {"Smithsonian Astrophysical Observation", "SAO 146907"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.87286250),
        dec: Angle.Degrees(-02.14950903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201718"},
        {"Hipparcos Number", "HIP 104618"},
        {"Renson", "Renson 56260"},
        {"Smithsonian Astrophysical Observation", "SAO 145182"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.88947282),
        dec: Angle.Degrees(-02.14908484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35899"},
        {"Hipparcos Number", "HIP 25557"},
        {"Geneva Identification System", "GEN# +1.00035899"},
        {"Smithsonian Astrophysical Observation", "SAO 132135"},
        {"Wilson Evans Batten Catalogue", "WEB 4961"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.94068661),
        dec: Angle.Degrees(-02.14546955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58433"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.71693147),
        dec: Angle.Degrees(-02.14531997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150539"},
        {"Hipparcos Number", "HIP 81742"},
        {"Geneva Identification System", "GEN# +1.00150539"},
        {"Smithsonian Astrophysical Observation", "SAO 141315"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.44960871),
        dec: Angle.Degrees(-02.14456194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108138"},
        {"Hipparcos Number", "HIP 60625"},
        {"Smithsonian Astrophysical Observation", "SAO 138771"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.37562502),
        dec: Angle.Degrees(-02.14333690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21324"},
        {"Hipparcos Number", "HIP 16023"},
        {"Smithsonian Astrophysical Observation", "SAO 130489"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.58364508),
        dec: Angle.Degrees(-02.14252522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202752"},
        {"Hipparcos Number", "HIP 105155"},
        {"Smithsonian Astrophysical Observation", "SAO 145276"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.51942043),
        dec: Angle.Degrees(-02.14182872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26845"},
        {"Hipparcos Number", "HIP 19800"},
        {"Smithsonian Astrophysical Observation", "SAO 131050"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.65424650),
        dec: Angle.Degrees(-02.13979225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123473"},
        {"Hipparcos Number", "HIP 69044"},
        {"Smithsonian Astrophysical Observation", "SAO 139745"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.99007083),
        dec: Angle.Degrees(-02.13814513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
