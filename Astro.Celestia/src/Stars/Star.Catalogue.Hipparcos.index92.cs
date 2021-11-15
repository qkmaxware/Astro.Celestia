using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_92() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75579"},
        {"Smithsonian Astrophysical Observation", "SAO 64704"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.60903479),
        dec: Angle.Degrees(+35.37218740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115475"},
        {"Smithsonian Astrophysical Observation", "SAO 73217"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.87921410),
        dec: Angle.Degrees(+35.37458542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4072 AB"},
        {"Henry Draper", "HD 35921"},
        {"Hipparcos Number", "HIP 25733"},
        {"Celescope Catalog", "CEL 728"},
        {"Geneva Identification System", "GEN# +1.00035921J"},
        {"Smithsonian Astrophysical Observation", "SAO 58105"},
        {"Wilson Evans Batten Catalogue", "WEB 4993"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.42771060),
        dec: Angle.Degrees(+35.37502840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37818"},
        {"Hipparcos Number", "HIP 26921"},
        {"Geneva Identification System", "GEN# +1.00037818"},
        {"Smithsonian Astrophysical Observation", "SAO 58357"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.71318515),
        dec: Angle.Degrees(+35.37922856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75247"},
        {"Hipparcos Number", "HIP 43368"},
        {"Smithsonian Astrophysical Observation", "SAO 61069"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.50421527),
        dec: Angle.Degrees(+35.37990370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105862"},
        {"Hipparcos Number", "HIP 59385"},
        {"Geneva Identification System", "GEN# +1.00105862"},
        {"Smithsonian Astrophysical Observation", "SAO 62882"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75089463),
        dec: Angle.Degrees(+35.38057166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84156"},
        {"Smithsonian Astrophysical Observation", "SAO 65861"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08204778),
        dec: Angle.Degrees(+35.38225824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7823 AB"},
        {"Henry Draper", "HD 91276"},
        {"Hipparcos Number", "HIP 51637"},
        {"Geneva Identification System", "GEN# +1.00091276J"},
        {"Smithsonian Astrophysical Observation", "SAO 62115"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.23909956),
        dec: Angle.Degrees(+35.38238304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190967"},
        {"Hipparcos Number", "HIP 99021"},
        {"Geneva Identification System", "GEN# +1.00190967"},
        {"Smithsonian Astrophysical Observation", "SAO 69410"},
        {"Wilson Evans Batten Catalogue", "WEB 17602"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.54146114),
        dec: Angle.Degrees(+35.38602017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41330"},
        {"Hipparcos Number", "HIP 28908"},
        {"Geneva Identification System", "GEN# +1.00041330"},
        {"Smithsonian Astrophysical Observation", "SAO 58739"},
        {"Wilson Evans Batten Catalogue", "WEB 5655"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.53593305),
        dec: Angle.Degrees(+35.38845807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162644"},
        {"Hipparcos Number", "HIP 87320"},
        {"Geneva Identification System", "GEN# +1.00162644"},
        {"Smithsonian Astrophysical Observation", "SAO 66372"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.63761943),
        dec: Angle.Degrees(+35.39006120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197054"},
        {"Hipparcos Number", "HIP 101974"},
        {"Smithsonian Astrophysical Observation", "SAO 70343"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.98084763),
        dec: Angle.Degrees(+35.39063708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17624"},
        {"Hipparcos Number", "HIP 13275"},
        {"Smithsonian Astrophysical Observation", "SAO 55936"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.71993396),
        dec: Angle.Degrees(+35.39390349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137072"},
        {"Hipparcos Number", "HIP 75268"},
        {"Geneva Identification System", "GEN# +1.00137072"},
        {"Smithsonian Astrophysical Observation", "SAO 64668"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.68218487),
        dec: Angle.Degrees(+35.39471813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76130"},
        {"Smithsonian Astrophysical Observation", "SAO 64772"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.23708529),
        dec: Angle.Degrees(+35.39499562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94082"},
        {"Smithsonian Astrophysical Observation", "SAO 67880"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.28106489),
        dec: Angle.Degrees(+35.39827416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21904"},
        {"Hipparcos Number", "HIP 16552"},
        {"Geneva Identification System", "GEN# +1.00021904"},
        {"Smithsonian Astrophysical Observation", "SAO 56533"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.28233073),
        dec: Angle.Degrees(+35.39892715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3421"},
        {"Hipparcos Number", "HIP 2942"},
        {"Geneva Identification System", "GEN# +1.00003421"},
        {"Smithsonian Astrophysical Observation", "SAO 54038"},
        {"Wilson Evans Batten Catalogue", "WEB 534"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.33844167),
        dec: Angle.Degrees(+35.39951013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25308"},
        {"Hipparcos Number", "HIP 18867"},
        {"Geneva Identification System", "GEN# +1.00025308"},
        {"Smithsonian Astrophysical Observation", "SAO 56920"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.67400629),
        dec: Angle.Degrees(+35.39959514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219512"},
        {"Hipparcos Number", "HIP 114868"},
        {"Geneva Identification System", "GEN# +1.00219512"},
        {"Renson", "Renson 60280"},
        {"Smithsonian Astrophysical Observation", "SAO 73122"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.00311475),
        dec: Angle.Degrees(+35.39982572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8838"},
        {"Hipparcos Number", "HIP 6817"},
        {"Smithsonian Astrophysical Observation", "SAO 54709"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.92667779),
        dec: Angle.Degrees(+35.40181850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137028"},
        {"Hipparcos Number", "HIP 75246"},
        {"Smithsonian Astrophysical Observation", "SAO 64664"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.63842984),
        dec: Angle.Degrees(+35.40229246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80506"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.51725395),
        dec: Angle.Degrees(+35.40260472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56516",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8225 AB"},
        {"Henry Draper", "HD 100654"},
        {"Hipparcos Number", "HIP 56516"},
        {"Geneva Identification System", "GEN# +1.00100654J"},
        {"Renson", "Renson 28930"},
        {"Smithsonian Astrophysical Observation", "SAO 62613"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.80255034),
        dec: Angle.Degrees(+35.40578327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214457"},
        {"Hipparcos Number", "HIP 111721"},
        {"Smithsonian Astrophysical Observation", "SAO 72552"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.46063866),
        dec: Angle.Degrees(+35.40687742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87987"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.59618785),
        dec: Angle.Degrees(+35.40774745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124243"},
        {"Hipparcos Number", "HIP 69347"},
        {"Geneva Identification System", "GEN# +1.00124243"},
        {"Smithsonian Astrophysical Observation", "SAO 63982"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.89570293),
        dec: Angle.Degrees(+35.40848333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204484"},
        {"Hipparcos Number", "HIP 105984"},
        {"Smithsonian Astrophysical Observation", "SAO 71368"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.97361500),
        dec: Angle.Degrees(+35.40915429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197641"},
        {"Hipparcos Number", "HIP 102311"},
        {"Smithsonian Astrophysical Observation", "SAO 70429"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.94993565),
        dec: Angle.Degrees(+35.40995763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64491"},
        {"Hipparcos Number", "HIP 38723"},
        {"Fundamental Katalog 5th Edition", "FK5 2613"},
        {"Geneva Identification System", "GEN# +1.00064491"},
        {"Smithsonian Astrophysical Observation", "SAO 60453"},
        {"Wilson Evans Batten Catalogue", "WEB 7592"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.92028680),
        dec: Angle.Degrees(+35.41274781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78573"},
        {"Hipparcos Number", "HIP 45017"},
        {"Geneva Identification System", "GEN# +1.00078573"},
        {"Smithsonian Astrophysical Observation", "SAO 61300"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.53578794),
        dec: Angle.Degrees(+35.41282763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65801"},
        {"Hipparcos Number", "HIP 39279"},
        {"Geneva Identification System", "GEN# +1.00065801"},
        {"Smithsonian Astrophysical Observation", "SAO 60523"},
        {"Wilson Evans Batten Catalogue", "WEB 7697"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.47999582),
        dec: Angle.Degrees(+35.41308517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154356"},
        {"Hipparcos Number", "HIP 83462"},
        {"Geneva Identification System", "GEN# +1.00154356"},
        {"Smithsonian Astrophysical Observation", "SAO 65761"},
        {"Wilson Evans Batten Catalogue", "WEB 14108"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.87580951),
        dec: Angle.Degrees(+35.41415358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50050"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.28270999),
        dec: Angle.Degrees(+35.41769853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 975"},
        {"Hipparcos Number", "HIP 1137"},
        {"Geneva Identification System", "GEN# +1.00000975"},
        {"Smithsonian Astrophysical Observation", "SAO 53745"},
        {"Wilson Evans Batten Catalogue", "WEB 201"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.55448927),
        dec: Angle.Degrees(+35.41805038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176937"},
        {"Hipparcos Number", "HIP 93380"},
        {"Geneva Identification System", "GEN# +1.00176937"},
        {"Smithsonian Astrophysical Observation", "SAO 67707"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.28747217),
        dec: Angle.Degrees(+35.41990303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66214"},
        {"Hipparcos Number", "HIP 39456"},
        {"Smithsonian Astrophysical Observation", "SAO 60535"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.97366784),
        dec: Angle.Degrees(+35.42062873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60561"},
        {"Hipparcos Number", "HIP 37021"},
        {"Geneva Identification System", "GEN# +1.00060561"},
        {"Smithsonian Astrophysical Observation", "SAO 60219"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13002785),
        dec: Angle.Degrees(+35.42361789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90250"},
        {"Hipparcos Number", "HIP 51047"},
        {"Geneva Identification System", "GEN# +1.00090250"},
        {"Smithsonian Astrophysical Observation", "SAO 62037"},
        {"Wilson Evans Batten Catalogue", "WEB 9332"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.43749608),
        dec: Angle.Degrees(+35.42557117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16509"},
        {"Hipparcos Number", "HIP 12423"},
        {"Smithsonian Astrophysical Observation", "SAO 55763"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.97384140),
        dec: Angle.Degrees(+35.42828870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45085"},
        {"Hipparcos Number", "HIP 30699"},
        {"Smithsonian Astrophysical Observation", "SAO 59088"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.75217502),
        dec: Angle.Degrees(+35.42931267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200842"},
        {"Hipparcos Number", "HIP 104064"},
        {"Geneva Identification System", "GEN# +1.00200842"},
        {"Smithsonian Astrophysical Observation", "SAO 70876"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.24051501),
        dec: Angle.Degrees(+35.42942390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77046"},
        {"Smithsonian Astrophysical Observation", "SAO 64872"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.99216157),
        dec: Angle.Degrees(+35.43000595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155978"},
        {"Hipparcos Number", "HIP 84254"},
        {"Smithsonian Astrophysical Observation", "SAO 65877"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.34486556),
        dec: Angle.Degrees(+35.43092928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25599"},
        {"Geneva Identification System", "GEN# +2.19070254"},
        {"New General Catalogue", "NGC 1907 254"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.05120862),
        dec: Angle.Degrees(+35.43112712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212545"},
        {"Hipparcos Number", "HIP 110603"},
        {"Geneva Identification System", "GEN# +1.00212545"},
        {"Smithsonian Astrophysical Observation", "SAO 72303"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.11419714),
        dec: Angle.Degrees(+35.43318474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7723"},
        {"Hipparcos Number", "HIP 6033"},
        {"Smithsonian Astrophysical Observation", "SAO 54582"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.37318925),
        dec: Angle.Degrees(+35.43457125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196628"},
        {"Hipparcos Number", "HIP 101748"},
        {"Smithsonian Astrophysical Observation", "SAO 70279"},
        {"Wilson Evans Batten Catalogue", "WEB 18376"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.33387971),
        dec: Angle.Degrees(+35.43623481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10832 AB"},
        {"Henry Draper", "HD 162623"},
        {"Hipparcos Number", "HIP 87309"},
        {"Smithsonian Astrophysical Observation", "SAO 66369"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.59668191),
        dec: Angle.Degrees(+35.43742113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213721"},
        {"Hipparcos Number", "HIP 111307"},
        {"Geneva Identification System", "GEN# +1.00213721"},
        {"Renson", "Renson 59280"},
        {"Smithsonian Astrophysical Observation", "SAO 72452"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.24098595),
        dec: Angle.Degrees(+35.43785318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11045"},
        {"Hipparcos Number", "HIP 8476"},
        {"Geneva Identification System", "GEN# +1.00011045"},
        {"Smithsonian Astrophysical Observation", "SAO 55002"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.31711859),
        dec: Angle.Degrees(+35.44062284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14735"},
        {"Hipparcos Number", "HIP 11153"},
        {"Geneva Identification System", "GEN# +1.00014735"},
        {"Smithsonian Astrophysical Observation", "SAO 55505"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.86991016),
        dec: Angle.Degrees(+35.44107812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16693 AB"},
        {"Henry Draper", "HD 220149"},
        {"Hipparcos Number", "HIP 115307"},
        {"Smithsonian Astrophysical Observation", "SAO 73195"},
        {"Wilson Evans Batten Catalogue", "WEB 20424"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.30509007),
        dec: Angle.Degrees(+35.44430961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98186"},
        {"Hipparcos Number", "HIP 55192"},
        {"Smithsonian Astrophysical Observation", "SAO 62482"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.50195755),
        dec: Angle.Degrees(+35.44488037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115197"},
        {"Hipparcos Number", "HIP 64648"},
        {"Geneva Identification System", "GEN# +1.00115197"},
        {"Smithsonian Astrophysical Observation", "SAO 63429"},
        {"Wilson Evans Batten Catalogue", "WEB 11434"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.78594822),
        dec: Angle.Degrees(+35.44578805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124033"},
        {"Hipparcos Number", "HIP 69223"},
        {"Geneva Identification System", "GEN# +1.00124033"},
        {"Smithsonian Astrophysical Observation", "SAO 63966"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.58323221),
        dec: Angle.Degrees(+35.44808949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58208",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8355 ABP"},
        {"Henry Draper", "HD 103659"},
        {"Hipparcos Number", "HIP 58208"},
        {"Geneva Identification System", "GEN# +1.00103659"},
        {"Smithsonian Astrophysical Observation", "SAO 62763"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.07184489),
        dec: Angle.Degrees(+35.44814052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17148"},
        {"Hipparcos Number", "HIP 12915"},
        {"Smithsonian Astrophysical Observation", "SAO 55855"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.51270973),
        dec: Angle.Degrees(+35.45056258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225700"},
        {"Hipparcos Number", "HIP 97259"},
        {"Smithsonian Astrophysical Observation", "SAO 68818"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.49946144),
        dec: Angle.Degrees(+35.45204634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127506"},
        {"Hipparcos Number", "HIP 70950"},
        {"Cincinnati Publication", "Ci 20 868"},
        {"Geneva Identification System", "GEN# +1.00127506"},
        {"Smithsonian Astrophysical Observation", "SAO 64191"},
        {"Wilson Evans Batten Catalogue", "WEB 12280"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.68884229),
        dec: Angle.Degrees(+35.45326727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -480.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 199.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278959"},
        {"Hipparcos Number", "HIP 17649"},
        {"Fundamental Katalog 5th Edition", "FK5 4344"},
        {"Smithsonian Astrophysical Observation", "SAO 56696"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.71076064),
        dec: Angle.Degrees(+35.45373244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67587"},
        {"Hipparcos Number", "HIP 40001"},
        {"Fundamental Katalog 5th Edition", "FK5 1214"},
        {"Geneva Identification System", "GEN# +1.00067587"},
        {"Smithsonian Astrophysical Observation", "SAO 60611"},
        {"Wilson Evans Batten Catalogue", "WEB 7800"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.54718590),
        dec: Angle.Degrees(+35.45556187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11269"},
        {"Hipparcos Number", "HIP 8640"},
        {"Geneva Identification System", "GEN# +1.00011269"},
        {"Smithsonian Astrophysical Observation", "SAO 55036"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.85678249),
        dec: Angle.Degrees(+35.45571426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131949"},
        {"Hipparcos Number", "HIP 73034"},
        {"Smithsonian Astrophysical Observation", "SAO 64402"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.88987361),
        dec: Angle.Degrees(+35.45597104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197419"},
        {"Hipparcos Number", "HIP 102195"},
        {"Celescope Catalog", "CEL 5148"},
        {"Geneva Identification System", "GEN# +1.00197419"},
        {"Smithsonian Astrophysical Observation", "SAO 70406"},
        {"Wilson Evans Batten Catalogue", "WEB 18492"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.59301818),
        dec: Angle.Degrees(+35.45621350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121781"},
        {"Hipparcos Number", "HIP 68120"},
        {"Geneva Identification System", "GEN# +1.00121781"},
        {"Smithsonian Astrophysical Observation", "SAO 63848"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.19266950),
        dec: Angle.Degrees(+35.45627245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25633"},
        {"Geneva Identification System", "GEN# +2.19070253"},
        {"New General Catalogue", "NGC 1907 253"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.12708028),
        dec: Angle.Degrees(+35.45683603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35519"},
        {"Hipparcos Number", "HIP 25476"},
        {"Fundamental Katalog 5th Edition", "FK5 2408"},
        {"Geneva Identification System", "GEN# +2.19070251"},
        {"Smithsonian Astrophysical Observation", "SAO 58029"},
        {"Wilson Evans Batten Catalogue", "WEB 4934"},
        {"New General Catalogue", "NGC 1907 251"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.72636668),
        dec: Angle.Degrees(+35.45730160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115992"},
        {"Smithsonian Astrophysical Observation", "SAO 73300"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.51384556),
        dec: Angle.Degrees(+35.45779682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14615",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2364 AB"},
        {"Henry Draper", "HD 19444"},
        {"Hipparcos Number", "HIP 14615"},
        {"Smithsonian Astrophysical Observation", "SAO 56196"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.19118289),
        dec: Angle.Degrees(+35.45876615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186454"},
        {"Hipparcos Number", "HIP 97011"},
        {"Celescope Catalog", "CEL 4825"},
        {"Geneva Identification System", "GEN# +1.00186454"},
        {"Smithsonian Astrophysical Observation", "SAO 68743"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.75893652),
        dec: Angle.Degrees(+35.46040989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21856"},
        {"Hipparcos Number", "HIP 16518"},
        {"Fundamental Katalog 5th Edition", "FK5 1098"},
        {"Geneva Identification System", "GEN# +1.00021856"},
        {"Smithsonian Astrophysical Observation", "SAO 56531"},
        {"Wilson Evans Batten Catalogue", "WEB 3156"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.16675711),
        dec: Angle.Degrees(+35.46172039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70880"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.43010204),
        dec: Angle.Degrees(+35.46800761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192990"},
        {"Hipparcos Number", "HIP 99943"},
        {"Celescope Catalog", "CEL 5008"},
        {"Geneva Identification System", "GEN# +1.00192990"},
        {"Smithsonian Astrophysical Observation", "SAO 69735"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.16563995),
        dec: Angle.Degrees(+35.46845898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47575"},
        {"Smithsonian Astrophysical Observation", "SAO 61637"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.50842251),
        dec: Angle.Degrees(+35.46869102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69787"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.25881852),
        dec: Angle.Degrees(+35.46887824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4990",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 873 AB"},
        {"Henry Draper", "HD 6264"},
        {"Hipparcos Number", "HIP 4990"},
        {"Smithsonian Astrophysical Observation", "SAO 54390"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.99477699),
        dec: Angle.Degrees(+35.46946291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153929"},
        {"Hipparcos Number", "HIP 83248"},
        {"Smithsonian Astrophysical Observation", "SAO 65724"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.22892027),
        dec: Angle.Degrees(+35.47158243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204815"},
        {"Hipparcos Number", "HIP 106151"},
        {"Fundamental Katalog 5th Edition", "FK5 5897"},
        {"Renson", "Renson 57030"},
        {"Smithsonian Astrophysical Observation", "SAO 71402"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.52517212),
        dec: Angle.Degrees(+35.47242636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28844"},
        {"Geneva Identification System", "GEN# +0.03501332"},
        {"Smithsonian Astrophysical Observation", "SAO 58718"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.32185392),
        dec: Angle.Degrees(+35.47454700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199970"},
        {"Hipparcos Number", "HIP 103593"},
        {"Renson", "Renson 55690"},
        {"Smithsonian Astrophysical Observation", "SAO 70763"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.84343547),
        dec: Angle.Degrees(+35.47462148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134112"},
        {"Hipparcos Number", "HIP 73965"},
        {"Smithsonian Astrophysical Observation", "SAO 64507"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.73264559),
        dec: Angle.Degrees(+35.47621929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26544"},
        {"Hipparcos Number", "HIP 19713"},
        {"Geneva Identification System", "GEN# +1.00026544"},
        {"Smithsonian Astrophysical Observation", "SAO 57075"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.34676822),
        dec: Angle.Degrees(+35.47675918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175172"},
        {"Hipparcos Number", "HIP 92651"},
        {"Smithsonian Astrophysical Observation", "SAO 67507"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.17852836),
        dec: Angle.Degrees(+35.47960442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22159"},
        {"Hipparcos Number", "HIP 16747"},
        {"Smithsonian Astrophysical Observation", "SAO 56566"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.86007132),
        dec: Angle.Degrees(+35.47992243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51640"},
        {"Hipparcos Number", "HIP 33679"},
        {"Geneva Identification System", "GEN# +1.00051640"},
        {"Smithsonian Astrophysical Observation", "SAO 59673"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.94928926),
        dec: Angle.Degrees(+35.48190045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78917"},
        {"Hipparcos Number", "HIP 45148"},
        {"Smithsonian Astrophysical Observation", "SAO 61324"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.97994564),
        dec: Angle.Degrees(+35.48217531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13429 AB"},
        {"Hipparcos Number", "HIP 99283"},
        {"Celescope Catalog", "CEL 4950"},
        {"Geneva Identification System", "GEN# +4.08020131"},
        {"Smithsonian Astrophysical Observation", "SAO 69512"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.30967488),
        dec: Angle.Degrees(+35.48386703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40972"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42216029),
        dec: Angle.Degrees(+35.48807381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98317"},
        {"Hipparcos Number", "HIP 55243"},
        {"Geneva Identification System", "GEN# +1.00098317"},
        {"Smithsonian Astrophysical Observation", "SAO 62488"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.70157762),
        dec: Angle.Degrees(+35.48935676)
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
    primaryId: "HIP 82532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152495"},
        {"Hipparcos Number", "HIP 82532"},
        {"Geneva Identification System", "GEN# +1.00152495"},
        {"Smithsonian Astrophysical Observation", "SAO 65618"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.04735299),
        dec: Angle.Degrees(+35.48960457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202184"},
        {"Hipparcos Number", "HIP 104745"},
        {"Celescope Catalog", "CEL 5275"},
        {"Geneva Identification System", "GEN# +1.00202184"},
        {"Smithsonian Astrophysical Observation", "SAO 71079"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.30872914),
        dec: Angle.Degrees(+35.48966382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73160",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9449 A"},
        {"Henry Draper", "HD 132276"},
        {"Hipparcos Number", "HIP 73160"},
        {"Geneva Identification System", "GEN# +1.00132276"},
        {"Smithsonian Astrophysical Observation", "SAO 64418"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.27857659),
        dec: Angle.Degrees(+35.49030203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36197"},
        {"Hipparcos Number", "HIP 25901"},
        {"Smithsonian Astrophysical Observation", "SAO 58144"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.93064433),
        dec: Angle.Degrees(+35.49122692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92307"},
        {"Hipparcos Number", "HIP 52214"},
        {"Geneva Identification System", "GEN# +1.00092307"},
        {"Smithsonian Astrophysical Observation", "SAO 62189"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.02181968),
        dec: Angle.Degrees(+35.49254972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57701"},
        {"Hipparcos Number", "HIP 35880"},
        {"Geneva Identification System", "GEN# +1.00057701"},
        {"Smithsonian Astrophysical Observation", "SAO 60044"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.96551152),
        dec: Angle.Degrees(+35.49405856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115541"},
        {"Smithsonian Astrophysical Observation", "SAO 73230"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.06222133),
        dec: Angle.Degrees(+35.49627494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49111"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.34772698),
        dec: Angle.Degrees(+35.49746865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189474"},
        {"Hipparcos Number", "HIP 98343"},
        {"Celescope Catalog", "CEL 4894"},
        {"Geneva Identification System", "GEN# +1.00189474"},
        {"Smithsonian Astrophysical Observation", "SAO 69199"},
        {"Wilson Evans Batten Catalogue", "WEB 17352"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.71509524),
        dec: Angle.Degrees(+35.49773654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102237"},
        {"Cincinnati Publication", "Ci 20 1224"},
        {"Wilson Evans Batten Catalogue", "WEB 18500"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.75045430),
        dec: Angle.Degrees(+35.49812937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -569.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112712"},
        {"Smithsonian Astrophysical Observation", "SAO 72758"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.38083232),
        dec: Angle.Degrees(+35.49945430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149558"},
        {"Hipparcos Number", "HIP 81131"},
        {"Smithsonian Astrophysical Observation", "SAO 65394"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.53426764),
        dec: Angle.Degrees(+35.49995288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58427"},
        {"Hipparcos Number", "HIP 36183"},
        {"Smithsonian Astrophysical Observation", "SAO 60083"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.77552071),
        dec: Angle.Degrees(+35.50279644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78102",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9856 A"},
        {"Henry Draper", "HD 143062"},
        {"Hipparcos Number", "HIP 78102"},
        {"Geneva Identification System", "GEN# +1.00143062"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.20351526),
        dec: Angle.Degrees(+35.50414132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26290"},
        {"Smithsonian Astrophysical Observation", "SAO 58221"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.98010072),
        dec: Angle.Degrees(+35.50760551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125351"},
        {"Hipparcos Number", "HIP 69879"},
        {"Fundamental Katalog 5th Edition", "FK5 1370"},
        {"Geneva Identification System", "GEN# +1.00125351"},
        {"Smithsonian Astrophysical Observation", "SAO 64053"},
        {"Wilson Evans Batten Catalogue", "WEB 12157"},
    },
    visualMagnitude: 4.80,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.49923373),
        dec: Angle.Degrees(+35.50947085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206570"},
        {"Hipparcos Number", "HIP 107129"},
        {"Geneva Identification System", "GEN# +1.00206570"},
        {"Smithsonian Astrophysical Observation", "SAO 71613"},
        {"Wilson Evans Batten Catalogue", "WEB 19351"},
    },
    visualMagnitude: 5.98,
    bvColour: 2.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.50450032),
        dec: Angle.Degrees(+35.51019572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22194"},
        {"Hipparcos Number", "HIP 16764"},
        {"Smithsonian Astrophysical Observation", "SAO 56570"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.93212495),
        dec: Angle.Degrees(+35.51081899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150462"},
        {"Hipparcos Number", "HIP 81590"},
        {"Geneva Identification System", "GEN# +1.00150462"},
        {"Smithsonian Astrophysical Observation", "SAO 65467"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.93821034),
        dec: Angle.Degrees(+35.51544570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4788 AB"},
        {"Henry Draper", "HD 42366"},
        {"Hipparcos Number", "HIP 29428"},
        {"Geneva Identification System", "GEN# +1.00042366J"},
        {"Smithsonian Astrophysical Observation", "SAO 58844"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.99328827),
        dec: Angle.Degrees(+35.51558537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6469"},
        {"Hipparcos Number", "HIP 5172"},
        {"Geneva Identification System", "GEN# +1.00006469"},
        {"Smithsonian Astrophysical Observation", "SAO 54420"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.53495201),
        dec: Angle.Degrees(+35.51606264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166537"},
        {"Hipparcos Number", "HIP 88968"},
        {"Smithsonian Astrophysical Observation", "SAO 66695"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.40207248),
        dec: Angle.Degrees(+35.51733045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73395"},
        {"Hipparcos Number", "HIP 42465"},
        {"Geneva Identification System", "GEN# +1.00073395"},
        {"Smithsonian Astrophysical Observation", "SAO 60960"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.86384784),
        dec: Angle.Degrees(+35.51977790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84043"},
        {"Smithsonian Astrophysical Observation", "SAO 65849"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.72681141),
        dec: Angle.Degrees(+35.52005478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44390"},
        {"Hipparcos Number", "HIP 30373"},
        {"Geneva Identification System", "GEN# +1.00044390"},
        {"Smithsonian Astrophysical Observation", "SAO 59028"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.80475272),
        dec: Angle.Degrees(+35.52032170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127413"},
        {"Hipparcos Number", "HIP 70930"},
        {"Smithsonian Astrophysical Observation", "SAO 64185"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.58609002),
        dec: Angle.Degrees(+35.52256780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85416"},
        {"Hipparcos Number", "HIP 48436"},
        {"Smithsonian Astrophysical Observation", "SAO 61728"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.12556573),
        dec: Angle.Degrees(+35.52461974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164808"},
        {"Hipparcos Number", "HIP 88255"},
        {"Geneva Identification System", "GEN# +1.00164808"},
        {"Smithsonian Astrophysical Observation", "SAO 66560"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.33279134),
        dec: Angle.Degrees(+35.52704306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52955"},
        {"Hipparcos Number", "HIP 34140"},
        {"Geneva Identification System", "GEN# +1.00052955"},
        {"Smithsonian Astrophysical Observation", "SAO 59747"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.18790735),
        dec: Angle.Degrees(+35.53060581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108712"},
        {"Hipparcos Number", "HIP 60928"},
        {"Geneva Identification System", "GEN# +1.00108712"},
        {"Smithsonian Astrophysical Observation", "SAO 63021"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.31366426),
        dec: Angle.Degrees(+35.53202600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150392"},
        {"Hipparcos Number", "HIP 81551"},
        {"Smithsonian Astrophysical Observation", "SAO 65462"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83493805),
        dec: Angle.Degrees(+35.53228493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53636"},
        {"Hipparcos Number", "HIP 34359"},
        {"Geneva Identification System", "GEN# +1.00053636"},
        {"Smithsonian Astrophysical Observation", "SAO 59793"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84412974),
        dec: Angle.Degrees(+35.53296853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59927"},
        {"Geneva Identification System", "GEN# +0.03602257"},
        {"Smithsonian Astrophysical Observation", "SAO 62937"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.38576950),
        dec: Angle.Degrees(+35.53300581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22962"},
        {"Hipparcos Number", "HIP 17326"},
        {"Cincinnati Publication", "Ci 18 492"},
        {"Smithsonian Astrophysical Observation", "SAO 56649"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.62990975),
        dec: Angle.Degrees(+35.53315430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32364"},
        {"Geneva Identification System", "GEN# +0.03501484"},
        {"Smithsonian Astrophysical Observation", "SAO 59446"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.34121710),
        dec: Angle.Degrees(+35.53508655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222230"},
        {"Hipparcos Number", "HIP 116671"},
        {"Smithsonian Astrophysical Observation", "SAO 73400"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.66269109),
        dec: Angle.Degrees(+35.53523813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53111"},
        {"Smithsonian Astrophysical Observation", "SAO 62285"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.98979940),
        dec: Angle.Degrees(+35.53532011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98369",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13204 AB"},
        {"Henry Draper", "HD 189528"},
        {"Hipparcos Number", "HIP 98369"},
        {"Smithsonian Astrophysical Observation", "SAO 69205"},
        {"Wilson Evans Batten Catalogue", "WEB 17357"},
    },
    visualMagnitude: 8.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.78110669),
        dec: Angle.Degrees(+35.53615247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1794"},
        {"Hipparcos Number", "HIP 1769"},
        {"Smithsonian Astrophysical Observation", "SAO 53844"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.59838913),
        dec: Angle.Degrees(+35.53635910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82371"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.47290710),
        dec: Angle.Degrees(+35.53657120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197701"},
        {"Hipparcos Number", "HIP 102347"},
        {"Geneva Identification System", "GEN# +1.00197701"},
        {"Smithsonian Astrophysical Observation", "SAO 70439"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.05420874),
        dec: Angle.Degrees(+35.53680233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189085"},
        {"Hipparcos Number", "HIP 98157"},
        {"Geneva Identification System", "GEN# +1.00189085"},
        {"Renson", "Renson 52310"},
        {"Smithsonian Astrophysical Observation", "SAO 69132"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.22225281),
        dec: Angle.Degrees(+35.53683695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12328 A"},
        {"Henry Draper", "HD 181658"},
        {"Hipparcos Number", "HIP 95001"},
        {"Smithsonian Astrophysical Observation", "SAO 68150"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.97011807),
        dec: Angle.Degrees(+35.53793809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38053"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98950613),
        dec: Angle.Degrees(+35.53802095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75896"},
        {"Hipparcos Number", "HIP 43685"},
        {"Fundamental Katalog 5th Edition", "FK5 2704"},
        {"Geneva Identification System", "GEN# +1.00075896"},
        {"Smithsonian Astrophysical Observation", "SAO 61117"},
        {"Wilson Evans Batten Catalogue", "WEB 8410"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48208292),
        dec: Angle.Degrees(+35.53833749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12328 B"},
        {"Henry Draper", "HD 181657"},
        {"Hipparcos Number", "HIP 95000"},
        {"Geneva Identification System", "GEN# +1.00181657"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.96751610),
        dec: Angle.Degrees(+35.54006905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102489"},
        {"Celescope Catalog", "CEL 5162"},
        {"Geneva Identification System", "GEN# +0.03504258J"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.55273974),
        dec: Angle.Degrees(+35.54044222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124711"},
        {"Hipparcos Number", "HIP 69566"},
        {"Smithsonian Astrophysical Observation", "SAO 64016"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58981411),
        dec: Angle.Degrees(+35.54167926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179984"},
        {"Hipparcos Number", "HIP 94442"},
        {"Renson", "Renson 49950"},
        {"Smithsonian Astrophysical Observation", "SAO 67994"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31921339),
        dec: Angle.Degrees(+35.54295244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154048"},
        {"Hipparcos Number", "HIP 83314"},
        {"Smithsonian Astrophysical Observation", "SAO 65737"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.40315797),
        dec: Angle.Degrees(+35.54328784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11621 B"},
        {"Hipparcos Number", "HIP 91828"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.84069504),
        dec: Angle.Degrees(+35.54560033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55354"},
        {"Hipparcos Number", "HIP 34969"},
        {"Smithsonian Astrophysical Observation", "SAO 59902"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.53641335),
        dec: Angle.Degrees(+35.54752794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216398"},
        {"Hipparcos Number", "HIP 112921"},
        {"Smithsonian Astrophysical Observation", "SAO 72798"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.03367884),
        dec: Angle.Degrees(+35.54770259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3362"},
        {"Geneva Identification System", "GEN# +0.03400106"},
        {"Wilson Evans Batten Catalogue", "WEB 600"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.70025783),
        dec: Angle.Degrees(+35.54860264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11621 A"},
        {"Henry Draper", "HD 173366"},
        {"Hipparcos Number", "HIP 91829"},
        {"Smithsonian Astrophysical Observation", "SAO 67286"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.84137213),
        dec: Angle.Degrees(+35.54868993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20444"},
        {"Hipparcos Number", "HIP 15403"},
        {"Geneva Identification System", "GEN# +1.00020444"},
        {"Smithsonian Astrophysical Observation", "SAO 56336"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.65412584),
        dec: Angle.Degrees(+35.54875970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144285"},
        {"Hipparcos Number", "HIP 78679"},
        {"Geneva Identification System", "GEN# +1.00144285"},
        {"Smithsonian Astrophysical Observation", "SAO 65054"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.92722506),
        dec: Angle.Degrees(+35.54900345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145286"},
        {"Hipparcos Number", "HIP 79104"},
        {"Geneva Identification System", "GEN# +1.00145286"},
        {"Smithsonian Astrophysical Observation", "SAO 65106"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20000744),
        dec: Angle.Degrees(+35.54986413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81207"},
        {"Smithsonian Astrophysical Observation", "SAO 65406"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.80554808),
        dec: Angle.Degrees(+35.55026403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221589"},
        {"Hipparcos Number", "HIP 116238"},
        {"Smithsonian Astrophysical Observation", "SAO 73333"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.29151691),
        dec: Angle.Degrees(+35.55067414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79518"},
        {"Smithsonian Astrophysical Observation", "SAO 65160"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.40192571),
        dec: Angle.Degrees(+35.55078381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69028"},
        {"Hipparcos Number", "HIP 40522"},
        {"Smithsonian Astrophysical Observation", "SAO 60695"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.10788771),
        dec: Angle.Degrees(+35.55079098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24300"},
        {"Hipparcos Number", "HIP 18182"},
        {"Geneva Identification System", "GEN# +1.00024300"},
        {"Smithsonian Astrophysical Observation", "SAO 56787"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.34297067),
        dec: Angle.Degrees(+35.55294106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12983"},
        {"Hipparcos Number", "HIP 9934"},
        {"Geneva Identification System", "GEN# +1.00012983"},
        {"Smithsonian Astrophysical Observation", "SAO 55281"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.97000887),
        dec: Angle.Degrees(+35.55385912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12990",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2117 AB"},
        {"Henry Draper", "HD 17240"},
        {"Hipparcos Number", "HIP 12990"},
        {"Smithsonian Astrophysical Observation", "SAO 55872"},
        {"Wilson Evans Batten Catalogue", "WEB 2626"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.76501143),
        dec: Angle.Degrees(+35.55481358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27361"},
        {"Smithsonian Astrophysical Observation", "SAO 58437"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.92347514),
        dec: Angle.Degrees(+35.55685639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214822"},
        {"Hipparcos Number", "HIP 111922"},
        {"Smithsonian Astrophysical Observation", "SAO 72605"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.07303994),
        dec: Angle.Degrees(+35.55782352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280320"},
        {"Hipparcos Number", "HIP 23212"},
        {"Smithsonian Astrophysical Observation", "SAO 57555"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.92448331),
        dec: Angle.Degrees(+35.55875739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47506"},
        {"Hipparcos Number", "HIP 31953"},
        {"Geneva Identification System", "GEN# +1.00047506"},
        {"Smithsonian Astrophysical Observation", "SAO 59349"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.15908823),
        dec: Angle.Degrees(+35.55904755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67220"},
        {"Geneva Identification System", "GEN# +0.03602408"},
        {"Smithsonian Astrophysical Observation", "SAO 63737"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61845837),
        dec: Angle.Degrees(+35.56059416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13875"},
        {"Cincinnati Publication", "Ci 18 384"},
        {"Smithsonian Astrophysical Observation", "SAO 56048"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.67612092),
        dec: Angle.Degrees(+35.56095677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167191"},
        {"Hipparcos Number", "HIP 89227"},
        {"Geneva Identification System", "GEN# +1.00167191"},
        {"Smithsonian Astrophysical Observation", "SAO 66748"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.12588355),
        dec: Angle.Degrees(+35.56096552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32673"},
        {"Hipparcos Number", "HIP 23765"},
        {"Geneva Identification System", "GEN# +1.00032673"},
        {"Smithsonian Astrophysical Observation", "SAO 57639"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.62437788),
        dec: Angle.Degrees(+35.56252798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198437"},
        {"Hipparcos Number", "HIP 102755"},
        {"Fundamental Katalog 5th Edition", "FK5 5837"},
        {"Geneva Identification System", "GEN# +1.00198437"},
        {"Smithsonian Astrophysical Observation", "SAO 70544"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.30022478),
        dec: Angle.Degrees(+35.56363726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211339"},
        {"Hipparcos Number", "HIP 109916"},
        {"Smithsonian Astrophysical Observation", "SAO 72184"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.92674442),
        dec: Angle.Degrees(+35.56448231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59775"},
        {"Geneva Identification System", "GEN# +0.03602250"},
        {"Smithsonian Astrophysical Observation", "SAO 62921"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.85778170),
        dec: Angle.Degrees(+35.56730149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104862"},
        {"Hipparcos Number", "HIP 58891"},
        {"Geneva Identification System", "GEN# +1.00104862"},
        {"Smithsonian Astrophysical Observation", "SAO 62826"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16887174),
        dec: Angle.Degrees(+35.56743196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130461"},
        {"Hipparcos Number", "HIP 72318"},
        {"Smithsonian Astrophysical Observation", "SAO 64330"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.83828037),
        dec: Angle.Degrees(+35.56782903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17"},
        {"Hipparcos Number", "HIP 432"},
        {"Geneva Identification System", "GEN# +1.00000017"},
        {"Smithsonian Astrophysical Observation", "SAO 53630"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.30417878),
        dec: Angle.Degrees(+35.57110311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6542"},
        {"Hipparcos Number", "HIP 5223"},
        {"Smithsonian Astrophysical Observation", "SAO 54430"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.69550692),
        dec: Angle.Degrees(+35.57226164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91899"},
        {"Hipparcos Number", "HIP 51990"},
        {"Smithsonian Astrophysical Observation", "SAO 62160"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.33146228),
        dec: Angle.Degrees(+35.57234127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49640"},
        {"Smithsonian Astrophysical Observation", "SAO 61878"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.97878905),
        dec: Angle.Degrees(+35.57730654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126990"},
        {"Hipparcos Number", "HIP 70735"},
        {"Geneva Identification System", "GEN# +1.00126990"},
        {"Smithsonian Astrophysical Observation", "SAO 64153"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99207226),
        dec: Angle.Degrees(+35.57741660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80698"},
        {"Hipparcos Number", "HIP 45948"},
        {"Smithsonian Astrophysical Observation", "SAO 61427"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.55735016),
        dec: Angle.Degrees(+35.57748598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214200"},
        {"Hipparcos Number", "HIP 111567"},
        {"Geneva Identification System", "GEN# +1.00214200"},
        {"Smithsonian Astrophysical Observation", "SAO 72517"},
        {"Wilson Evans Batten Catalogue", "WEB 19944"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.03290831),
        dec: Angle.Degrees(+35.57764581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5955"},
        {"Hipparcos Number", "HIP 4783"},
        {"Smithsonian Astrophysical Observation", "SAO 54349"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.35451650),
        dec: Angle.Degrees(+35.57872312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39864"},
        {"Hipparcos Number", "HIP 28151"},
        {"Geneva Identification System", "GEN# +1.00039864"},
        {"Smithsonian Astrophysical Observation", "SAO 58596"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.22848534),
        dec: Angle.Degrees(+35.57899116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52936"},
        {"Hipparcos Number", "HIP 34136"},
        {"Smithsonian Astrophysical Observation", "SAO 59744"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.16823089),
        dec: Angle.Degrees(+35.57931262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71193",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9312 AB"},
        {"Henry Draper", "HD 128041"},
        {"Hipparcos Number", "HIP 71193"},
        {"Geneva Identification System", "GEN# +1.00128041"},
        {"Smithsonian Astrophysical Observation", "SAO 64213"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.40189113),
        dec: Angle.Degrees(+35.58556383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2342"},
        {"Hipparcos Number", "HIP 2180"},
        {"Geneva Identification System", "GEN# +1.00002342"},
        {"Wilson Evans Batten Catalogue", "WEB 404"},
    },
    visualMagnitude: 7.67,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.88202932),
        dec: Angle.Degrees(+35.58739276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197572"},
        {"Hipparcos Number", "HIP 102276"},
        {"Geneva Identification System", "GEN# +1.00197572"},
        {"Smithsonian Astrophysical Observation", "SAO 70423"},
        {"Wilson Evans Batten Catalogue", "WEB 18513"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.85082082),
        dec: Angle.Degrees(+35.58780930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80271"},
        {"Smithsonian Astrophysical Observation", "SAO 65267"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78834364),
        dec: Angle.Degrees(+35.58842145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12545"},
        {"Hipparcos Number", "HIP 9630"},
        {"Geneva Identification System", "GEN# +1.00012545"},
        {"Smithsonian Astrophysical Observation", "SAO 55233"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.94646921),
        dec: Angle.Degrees(+35.59133059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78559"},
        {"Smithsonian Astrophysical Observation", "SAO 65035"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.60786798),
        dec: Angle.Degrees(+35.59136816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179216"},
        {"Hipparcos Number", "HIP 94177"},
        {"Geneva Identification System", "GEN# +1.00179216"},
        {"Smithsonian Astrophysical Observation", "SAO 67911"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.56739652),
        dec: Angle.Degrees(+35.59468073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56799"},
        {"Smithsonian Astrophysical Observation", "SAO 62637"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.65893538),
        dec: Angle.Degrees(+35.59661158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145183"},
        {"Hipparcos Number", "HIP 79053"},
        {"Smithsonian Astrophysical Observation", "SAO 65102"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.03757813),
        dec: Angle.Degrees(+35.59765438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203246"},
        {"Hipparcos Number", "HIP 105335"},
        {"Geneva Identification System", "GEN# +1.00203246"},
        {"Smithsonian Astrophysical Observation", "SAO 71215"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.04112491),
        dec: Angle.Degrees(+35.59900955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83067"},
        {"Hipparcos Number", "HIP 47182"},
        {"Geneva Identification System", "GEN# +1.00083067"},
        {"Smithsonian Astrophysical Observation", "SAO 61596"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.22354568),
        dec: Angle.Degrees(+35.59945060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28474"},
        {"Hipparcos Number", "HIP 21069"},
        {"Geneva Identification System", "GEN# +1.00028474"},
        {"Smithsonian Astrophysical Observation", "SAO 57274"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.74566439),
        dec: Angle.Degrees(+35.59953010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192383"},
        {"Hipparcos Number", "HIP 99646"},
        {"Smithsonian Astrophysical Observation", "SAO 69628"},
        {"Wilson Evans Batten Catalogue", "WEB 17857"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33503725),
        dec: Angle.Degrees(+35.59989190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279021"},
        {"Hipparcos Number", "HIP 17911"},
        {"Geneva Identification System", "GEN# +1.00279021"},
        {"Renson", "Renson 6120"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.45377385),
        dec: Angle.Degrees(+35.60024120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18758"},
        {"Hipparcos Number", "HIP 14123"},
        {"Smithsonian Astrophysical Observation", "SAO 56102"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.53369962),
        dec: Angle.Degrees(+35.60024134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124459"},
        {"Hipparcos Number", "HIP 69434"},
        {"Geneva Identification System", "GEN# +1.00124459"},
        {"Smithsonian Astrophysical Observation", "SAO 63990"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.24049964),
        dec: Angle.Degrees(+35.60061920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59557"},
        {"Hipparcos Number", "HIP 36632"},
        {"Smithsonian Astrophysical Observation", "SAO 60152"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.00498472),
        dec: Angle.Degrees(+35.60294941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124696"},
        {"Hipparcos Number", "HIP 69546"},
        {"Geneva Identification System", "GEN# +1.00124696"},
        {"Smithsonian Astrophysical Observation", "SAO 64012"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.54799055),
        dec: Angle.Degrees(+35.60362276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37146"},
        {"Hipparcos Number", "HIP 26482"},
        {"Smithsonian Astrophysical Observation", "SAO 58265"},
        {"Wilson Evans Batten Catalogue", "WEB 5221"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.48952782),
        dec: Angle.Degrees(+35.60418804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74693"},
        {"Smithsonian Astrophysical Observation", "SAO 64595"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.97084110),
        dec: Angle.Degrees(+35.60670560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 843"},
        {"Hipparcos Number", "HIP 1035"},
        {"Smithsonian Astrophysical Observation", "SAO 53726"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.23695832),
        dec: Angle.Degrees(+35.60720337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54165"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.20059914),
        dec: Angle.Degrees(+35.60739862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98976",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13361 A"},
        {"Henry Draper", "HD 190864"},
        {"Hipparcos Number", "HIP 98976"},
        {"Celescope Catalog", "CEL 4926"},
        {"Geneva Identification System", "GEN# +2.68710004"},
        {"Smithsonian Astrophysical Observation", "SAO 69391"},
        {"Wilson Evans Batten Catalogue", "WEB 17579"},
        {"New General Catalogue", "NGC 6871 4"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.41585197),
        dec: Angle.Degrees(+35.60779177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9500"},
        {"Hipparcos Number", "HIP 7289"},
        {"Geneva Identification System", "GEN# +1.00009500"},
        {"Smithsonian Astrophysical Observation", "SAO 54785"},
        {"Wilson Evans Batten Catalogue", "WEB 1573"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.47634787),
        dec: Angle.Degrees(+35.60821238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206914"},
        {"Hipparcos Number", "HIP 107340"},
        {"Smithsonian Astrophysical Observation", "SAO 71657"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.10613672),
        dec: Angle.Degrees(+35.60955889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6099"},
        {"Hipparcos Number", "HIP 4881"},
        {"Geneva Identification System", "GEN# +1.00006099"},
        {"Smithsonian Astrophysical Observation", "SAO 54370"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.67972572),
        dec: Angle.Degrees(+35.61082514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226228"},
        {"Hipparcos Number", "HIP 97744"},
        {"Smithsonian Astrophysical Observation", "SAO 68981"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.94425998),
        dec: Angle.Degrees(+35.61175025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147925"},
        {"Hipparcos Number", "HIP 80281"},
        {"Smithsonian Astrophysical Observation", "SAO 65270"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.82339145),
        dec: Angle.Degrees(+35.61186550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45577"},
        {"Hipparcos Number", "HIP 30963"},
        {"Smithsonian Astrophysical Observation", "SAO 59148"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.49019016),
        dec: Angle.Degrees(+35.61294138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65543"},
        {"Hipparcos Number", "HIP 39159"},
        {"Smithsonian Astrophysical Observation", "SAO 60512"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.13597117),
        dec: Angle.Degrees(+35.61374679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15093"},
        {"Hipparcos Number", "HIP 11395"},
        {"Geneva Identification System", "GEN# +1.00015093"},
        {"Smithsonian Astrophysical Observation", "SAO 55560"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.70169463),
        dec: Angle.Degrees(+35.61430596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9843"},
        {"Hipparcos Number", "HIP 7501"},
        {"Geneva Identification System", "GEN# +1.00009843"},
        {"Renson", "Renson 2410"},
        {"Smithsonian Astrophysical Observation", "SAO 54831"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.16990857),
        dec: Angle.Degrees(+35.61622147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27155"},
        {"Smithsonian Astrophysical Observation", "SAO 58402"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.34823148),
        dec: Angle.Degrees(+35.61798133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5447",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "MIRACH"},
        {"Aitken", "ADS 949 A"},
        {"Henry Draper", "HD 6860"},
        {"Hipparcos Number", "HIP 5447"},
        {"Fundamental Katalog 5th Edition", "FK5 42"},
        {"Geneva Identification System", "GEN# +1.00006860"},
        {"Smithsonian Astrophysical Observation", "SAO 54471"},
        {"Wilson Evans Batten Catalogue", "WEB 1192"},
    },
    visualMagnitude: 2.07,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.43248991),
        dec: Angle.Degrees(+35.62083048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110347"},
        {"Smithsonian Astrophysical Observation", "SAO 72254"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25097819),
        dec: Angle.Degrees(+35.62191980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192605"},
        {"Hipparcos Number", "HIP 99757"},
        {"Geneva Identification System", "GEN# +1.00192605"},
        {"Smithsonian Astrophysical Observation", "SAO 69672"},
        {"Wilson Evans Batten Catalogue", "WEB 17911"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60515082),
        dec: Angle.Degrees(+35.62231802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210102"},
        {"Hipparcos Number", "HIP 109192"},
        {"Smithsonian Astrophysical Observation", "SAO 72045"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.80136679),
        dec: Angle.Degrees(+35.62332604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177005"},
        {"Hipparcos Number", "HIP 93389"},
        {"Geneva Identification System", "GEN# +1.00177005"},
        {"Smithsonian Astrophysical Observation", "SAO 67708"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.31141795),
        dec: Angle.Degrees(+35.62372640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67066"},
        {"Hipparcos Number", "HIP 39778"},
        {"Geneva Identification System", "GEN# +1.00067066"},
        {"Smithsonian Astrophysical Observation", "SAO 60579"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.93598762),
        dec: Angle.Degrees(+35.62531629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96338"},
        {"Geneva Identification System", "GEN# +0.03503693"},
        {"Smithsonian Astrophysical Observation", "SAO 68537"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.79266643),
        dec: Angle.Degrees(+35.62847123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8874 A"},
        {"Henry Draper", "HD 116273"},
        {"Hipparcos Number", "HIP 65227"},
        {"Geneva Identification System", "GEN# +1.00116273"},
        {"Smithsonian Astrophysical Observation", "SAO 63498"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.51206758),
        dec: Angle.Degrees(+35.63050054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10203 AB"},
        {"Henry Draper", "HD 151428"},
        {"Hipparcos Number", "HIP 82068"},
        {"Geneva Identification System", "GEN# +1.00151428"},
        {"Smithsonian Astrophysical Observation", "SAO 65537"},
        {"Wilson Evans Batten Catalogue", "WEB 13859"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.45060179),
        dec: Angle.Degrees(+35.63069758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45795"},
        {"Smithsonian Astrophysical Observation", "SAO 61406"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.06045541),
        dec: Angle.Degrees(+35.63130369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37670"},
        {"Hipparcos Number", "HIP 26838"},
        {"Geneva Identification System", "GEN# +1.00037670"},
        {"Smithsonian Astrophysical Observation", "SAO 58343"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.48634612),
        dec: Angle.Degrees(+35.63133030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164251"},
        {"Hipparcos Number", "HIP 88017"},
        {"Smithsonian Astrophysical Observation", "SAO 66530"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66882346),
        dec: Angle.Degrees(+35.63187168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58577"},
        {"Hipparcos Number", "HIP 36233"},
        {"Smithsonian Astrophysical Observation", "SAO 60093"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.92762150),
        dec: Angle.Degrees(+35.63196798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36292"},
        {"Hipparcos Number", "HIP 25957"},
        {"Geneva Identification System", "GEN# +1.00036292"},
        {"Smithsonian Astrophysical Observation", "SAO 58155"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.07148492),
        dec: Angle.Degrees(+35.63246047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109827"},
        {"Smithsonian Astrophysical Observation", "SAO 72169"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.66625311),
        dec: Angle.Degrees(+35.63284524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11772"},
        {"Smithsonian Astrophysical Observation", "SAO 55633"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.97826496),
        dec: Angle.Degrees(+35.63353961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148802"},
        {"Hipparcos Number", "HIP 80748"},
        {"Smithsonian Astrophysical Observation", "SAO 65333"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.30048778),
        dec: Angle.Degrees(+35.63386942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280165"},
        {"Hipparcos Number", "HIP 22328"},
        {"Smithsonian Astrophysical Observation", "SAO 57435"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.14067812),
        dec: Angle.Degrees(+35.63508868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218365"},
        {"Hipparcos Number", "HIP 114152"},
        {"Fundamental Katalog 5th Edition", "FK5 3849"},
        {"Geneva Identification System", "GEN# +1.00218365"},
        {"Smithsonian Astrophysical Observation", "SAO 73007"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.77079924),
        dec: Angle.Degrees(+35.63646521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17841"},
        {"Hipparcos Number", "HIP 13438"},
        {"Cincinnati Publication", "Ci 18 370"},
        {"Smithsonian Astrophysical Observation", "SAO 55970"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.25515860),
        dec: Angle.Degrees(+35.63754732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 335.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279019"},
        {"Hipparcos Number", "HIP 17813"},
        {"Geneva Identification System", "GEN# +1.00279019"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.17690081),
        dec: Angle.Degrees(+35.63760855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22961"},
        {"Hipparcos Number", "HIP 17323"},
        {"Geneva Identification System", "GEN# +1.00022961"},
        {"Renson", "Renson 5850"},
        {"Smithsonian Astrophysical Observation", "SAO 56648"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.62255240),
        dec: Angle.Degrees(+35.63916563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85711"},
        {"Smithsonian Astrophysical Observation", "SAO 66105"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.72625369),
        dec: Angle.Degrees(+35.63919185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93214"},
        {"Hipparcos Number", "HIP 52675"},
        {"Geneva Identification System", "GEN# +1.00093214"},
        {"Smithsonian Astrophysical Observation", "SAO 62243"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.56266600),
        dec: Angle.Degrees(+35.63976381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146621"},
        {"Hipparcos Number", "HIP 79677"},
        {"Smithsonian Astrophysical Observation", "SAO 65180"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.92624908),
        dec: Angle.Degrees(+35.64095180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190113"},
        {"Hipparcos Number", "HIP 98638"},
        {"Geneva Identification System", "GEN# +1.00190113"},
        {"Smithsonian Astrophysical Observation", "SAO 69288"},
        {"Wilson Evans Batten Catalogue", "WEB 17447"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.51190019),
        dec: Angle.Degrees(+35.64113279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110854"},
        {"Hipparcos Number", "HIP 62194"},
        {"Geneva Identification System", "GEN# +1.00110854"},
        {"Smithsonian Astrophysical Observation", "SAO 63174"},
        {"Wilson Evans Batten Catalogue", "WEB 11050"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.20426008),
        dec: Angle.Degrees(+35.64297034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2635"},
        {"Hipparcos Number", "HIP 2366"},
        {"Geneva Identification System", "GEN# +1.00002635"},
        {"Smithsonian Astrophysical Observation", "SAO 53941"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.54962734),
        dec: Angle.Degrees(+35.64354375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195559"},
        {"Hipparcos Number", "HIP 101208"},
        {"Smithsonian Astrophysical Observation", "SAO 70133"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.72580987),
        dec: Angle.Degrees(+35.64372403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201968"},
        {"Hipparcos Number", "HIP 104661"},
        {"Smithsonian Astrophysical Observation", "SAO 71052"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.99986007),
        dec: Angle.Degrees(+35.64490382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98683"},
        {"Hipparcos Number", "HIP 55462"},
        {"Smithsonian Astrophysical Observation", "SAO 62508"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.37356358),
        dec: Angle.Degrees(+35.64553852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9060"},
        {"Smithsonian Astrophysical Observation", "SAO 55116"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.16295962),
        dec: Angle.Degrees(+35.64664265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42470"},
        {"Smithsonian Astrophysical Observation", "SAO 60962"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.87658827),
        dec: Angle.Degrees(+35.64695375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104973"},
        {"Smithsonian Astrophysical Observation", "SAO 71132"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.93591987),
        dec: Angle.Degrees(+35.64823315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126029"},
        {"Hipparcos Number", "HIP 70235"},
        {"Fundamental Katalog 5th Edition", "FK5 5269"},
        {"Geneva Identification System", "GEN# +1.00126029"},
        {"Smithsonian Astrophysical Observation", "SAO 64100"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.55785090),
        dec: Angle.Degrees(+35.64874215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33329"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97599920),
        dec: Angle.Degrees(+35.64922218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86037"},
        {"Smithsonian Astrophysical Observation", "SAO 66153"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.74857908),
        dec: Angle.Degrees(+35.65031859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223893"},
        {"Hipparcos Number", "HIP 117793"},
        {"Smithsonian Astrophysical Observation", "SAO 73588"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.31970885),
        dec: Angle.Degrees(+35.65097386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76696"},
        {"Smithsonian Astrophysical Observation", "SAO 64836"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.91447311),
        dec: Angle.Degrees(+35.65171553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214313"},
        {"Hipparcos Number", "HIP 111627"},
        {"Fundamental Katalog 5th Edition", "FK5 3812"},
        {"Geneva Identification System", "GEN# +1.00214313"},
        {"Smithsonian Astrophysical Observation", "SAO 72535"},
        {"Wilson Evans Batten Catalogue", "WEB 19953"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.20285766),
        dec: Angle.Degrees(+35.65242306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33671"},
        {"Hipparcos Number", "HIP 24350"},
        {"Celescope Catalog", "CEL 567"},
        {"Geneva Identification System", "GEN# +1.00033671"},
        {"Smithsonian Astrophysical Observation", "SAO 57760"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38245344),
        dec: Angle.Degrees(+35.65306006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130555"},
        {"Hipparcos Number", "HIP 72369"},
        {"Geneva Identification System", "GEN# +1.00130555"},
        {"Smithsonian Astrophysical Observation", "SAO 64331"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.95818340),
        dec: Angle.Degrees(+35.65447980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142091"},
        {"Hipparcos Number", "HIP 77655"},
        {"Fundamental Katalog 5th Edition", "FK5 1414"},
        {"Geneva Identification System", "GEN# +1.00142091"},
        {"Smithsonian Astrophysical Observation", "SAO 64948"},
        {"Wilson Evans Batten Catalogue", "WEB 13138"},
    },
    visualMagnitude: 4.79,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.80807231),
        dec: Angle.Degrees(+35.65822638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -347.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3203"},
        {"Hipparcos Number", "HIP 2783"},
        {"Geneva Identification System", "GEN# +1.00003203"},
        {"Smithsonian Astrophysical Observation", "SAO 54005"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.87676895),
        dec: Angle.Degrees(+35.65908196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21847"},
        {"Hipparcos Number", "HIP 16517"},
        {"Geneva Identification System", "GEN# +1.00021847"},
        {"Smithsonian Astrophysical Observation", "SAO 56530"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.16592590),
        dec: Angle.Degrees(+35.65943530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91311"},
        {"Fundamental Katalog 5th Edition", "FK5 5638"},
        {"Smithsonian Astrophysical Observation", "SAO 67179"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.38227295),
        dec: Angle.Degrees(+35.65978922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179145"},
        {"Hipparcos Number", "HIP 94156"},
        {"Geneva Identification System", "GEN# +1.00179145"},
        {"Smithsonian Astrophysical Observation", "SAO 67899"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.48480235),
        dec: Angle.Degrees(+35.66100779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117492"},
        {"Cincinnati Publication", "Ci 18 3125"},
        {"Geneva Identification System", "GEN# +0.03405013"},
        {"Smithsonian Astrophysical Observation", "SAO 73531"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.36991190),
        dec: Angle.Degrees(+35.66439900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11293"},
        {"Hipparcos Number", "HIP 8673"},
        {"Geneva Identification System", "GEN# +1.00011293"},
        {"Smithsonian Astrophysical Observation", "SAO 55040"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91788544),
        dec: Angle.Degrees(+35.66608766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84688"},
        {"Smithsonian Astrophysical Observation", "SAO 65935"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.69268695),
        dec: Angle.Degrees(+35.66998827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103303"},
        {"Smithsonian Astrophysical Observation", "SAO 70676"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.92356214),
        dec: Angle.Degrees(+35.67048749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29036"},
        {"Hipparcos Number", "HIP 21415"},
        {"Geneva Identification System", "GEN# +1.00029036"},
        {"Smithsonian Astrophysical Observation", "SAO 57329"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.94266628),
        dec: Angle.Degrees(+35.67066590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215619"},
        {"Hipparcos Number", "HIP 112402"},
        {"Fundamental Katalog 5th Edition", "FK5 6007"},
        {"Geneva Identification System", "GEN# +1.00215619"},
        {"Smithsonian Astrophysical Observation", "SAO 72701"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.50747237),
        dec: Angle.Degrees(+35.67186214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190919"},
        {"Hipparcos Number", "HIP 98999"},
        {"Celescope Catalog", "CEL 4928"},
        {"Geneva Identification System", "GEN# +2.68710002"},
        {"Smithsonian Astrophysical Observation", "SAO 69399"},
        {"Wilson Evans Batten Catalogue", "WEB 17589"},
        {"New General Catalogue", "NGC 6871 2"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.48401339),
        dec: Angle.Degrees(+35.67209752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163218"},
        {"Hipparcos Number", "HIP 87586"},
        {"Smithsonian Astrophysical Observation", "SAO 66438"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.38276301),
        dec: Angle.Degrees(+35.67249159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13102"},
        {"Hipparcos Number", "HIP 10022"},
        {"Smithsonian Astrophysical Observation", "SAO 55302"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.25860437),
        dec: Angle.Degrees(+35.67487013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87902",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10932 A"},
        {"Henry Draper", "HD 163991"},
        {"Hipparcos Number", "HIP 87902"},
        {"Smithsonian Astrophysical Observation", "SAO 66507"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.33758056),
        dec: Angle.Degrees(+35.67488283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8031 A"},
        {"Henry Draper", "HD 95658"},
        {"Hipparcos Number", "HIP 54011"},
        {"Geneva Identification System", "GEN# +1.00095658"},
        {"Renson", "Renson 27550"},
        {"Smithsonian Astrophysical Observation", "SAO 62374"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.73488027),
        dec: Angle.Degrees(+35.67701513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121048"},
        {"Hipparcos Number", "HIP 67729"},
        {"Geneva Identification System", "GEN# +1.00121048"},
        {"Renson", "Renson 34810"},
        {"Smithsonian Astrophysical Observation", "SAO 63804"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.11935269),
        dec: Angle.Degrees(+35.67948167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83141"},
        {"Smithsonian Astrophysical Observation", "SAO 65702"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.85665888),
        dec: Angle.Degrees(+35.68061784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -299.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 233.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133142"},
        {"Hipparcos Number", "HIP 73530"},
        {"Smithsonian Astrophysical Observation", "SAO 64466"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.43867788),
        dec: Angle.Degrees(+35.68156176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80116"},
        {"Hipparcos Number", "HIP 45702"},
        {"Smithsonian Astrophysical Observation", "SAO 61395"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.74902713),
        dec: Angle.Degrees(+35.68248520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100820"},
        {"Smithsonian Astrophysical Observation", "SAO 70027"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.63672913),
        dec: Angle.Degrees(+35.68337380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215858"},
        {"Hipparcos Number", "HIP 112539"},
        {"Smithsonian Astrophysical Observation", "SAO 72726"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.91582921),
        dec: Angle.Degrees(+35.68393374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97594"},
        {"Wilson Evans Batten Catalogue", "WEB 17161"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.54931678),
        dec: Angle.Degrees(+35.68417458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157165"},
        {"Hipparcos Number", "HIP 84819"},
        {"Smithsonian Astrophysical Observation", "SAO 65956"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.03131075),
        dec: Angle.Degrees(+35.68422702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112840"},
        {"Smithsonian Astrophysical Observation", "SAO 72780"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.77796442),
        dec: Angle.Degrees(+35.68617755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55179"},
        {"Hipparcos Number", "HIP 34916"},
        {"Geneva Identification System", "GEN# +1.00055179"},
        {"Smithsonian Astrophysical Observation", "SAO 59893"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.36433424),
        dec: Angle.Degrees(+35.68890939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110754"},
        {"Smithsonian Astrophysical Observation", "SAO 72335"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.56915118),
        dec: Angle.Degrees(+35.69096022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5831"},
        {"Hipparcos Number", "HIP 4695"},
        {"Smithsonian Astrophysical Observation", "SAO 54337"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.08235042),
        dec: Angle.Degrees(+35.69101956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79105"},
        {"Smithsonian Astrophysical Observation", "SAO 65107"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20105852),
        dec: Angle.Degrees(+35.69129285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93168"},
        {"Hipparcos Number", "HIP 52657"},
        {"Smithsonian Astrophysical Observation", "SAO 62241"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.51495685),
        dec: Angle.Degrees(+35.69273910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194208"},
        {"Hipparcos Number", "HIP 100540"},
        {"Geneva Identification System", "GEN# +1.00194208"},
        {"Smithsonian Astrophysical Observation", "SAO 69934"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.79345595),
        dec: Angle.Degrees(+35.69306163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24360",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13, 36.2200),
        dec: Angle.DegreesMinutesSeconds((int)+35, (int)41, 39.100)
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
    primaryId: "HIP 113262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216870"},
        {"Hipparcos Number", "HIP 113262"},
        {"Smithsonian Astrophysical Observation", "SAO 72859"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.03482697),
        dec: Angle.Degrees(+35.69442751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38152"},
        {"Hipparcos Number", "HIP 27144"},
        {"Smithsonian Astrophysical Observation", "SAO 58399"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.32064929),
        dec: Angle.Degrees(+35.69495783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83036"},
        {"Hipparcos Number", "HIP 47162"},
        {"Smithsonian Astrophysical Observation", "SAO 61593"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.15978382),
        dec: Angle.Degrees(+35.69653586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174810"},
        {"Hipparcos Number", "HIP 92481"},
        {"Smithsonian Astrophysical Observation", "SAO 67467"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.71933671),
        dec: Angle.Degrees(+35.69721751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147005"},
        {"Hipparcos Number", "HIP 79845"},
        {"Smithsonian Astrophysical Observation", "SAO 65209"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.46351716),
        dec: Angle.Degrees(+35.69956856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33688"},
        {"Hipparcos Number", "HIP 24356"},
        {"Celescope Catalog", "CEL 568"},
        {"Geneva Identification System", "GEN# +1.00033688"},
        {"Smithsonian Astrophysical Observation", "SAO 57762"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.39830884),
        dec: Angle.Degrees(+35.70084999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41562"},
        {"Hipparcos Number", "HIP 29032"},
        {"Smithsonian Astrophysical Observation", "SAO 58764"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.87915642),
        dec: Angle.Degrees(+35.70185297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67482"},
        {"Hipparcos Number", "HIP 39966"},
        {"Smithsonian Astrophysical Observation", "SAO 60606"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.41564053),
        dec: Angle.Degrees(+35.70247654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114539"},
        {"Smithsonian Astrophysical Observation", "SAO 73078"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.00159365),
        dec: Angle.Degrees(+35.70356196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60176"},
        {"Geneva Identification System", "GEN# +0.03602261"},
        {"Smithsonian Astrophysical Observation", "SAO 62954"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.09790701),
        dec: Angle.Degrees(+35.70413459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81386"},
        {"Hipparcos Number", "HIP 46282"},
        {"Smithsonian Astrophysical Observation", "SAO 61488"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.57492872),
        dec: Angle.Degrees(+35.70507207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184906"},
        {"Hipparcos Number", "HIP 96340"},
        {"Celescope Catalog", "CEL 4791"},
        {"Geneva Identification System", "GEN# +1.00184906"},
        {"Smithsonian Astrophysical Observation", "SAO 68539"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.79554945),
        dec: Angle.Degrees(+35.70550380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139324"},
        {"Hipparcos Number", "HIP 76398"},
        {"Geneva Identification System", "GEN# +1.00139324"},
        {"Smithsonian Astrophysical Observation", "SAO 64802"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.05328206),
        dec: Angle.Degrees(+35.70557943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11806",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1927 AB"},
        {"Henry Draper", "HD 15671"},
        {"Hipparcos Number", "HIP 11806"},
        {"Geneva Identification System", "GEN# +1.00015671"},
        {"Smithsonian Astrophysical Observation", "SAO 55638"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.06641726),
        dec: Angle.Degrees(+35.70788921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34986"},
        {"Hipparcos Number", "HIP 25178"},
        {"Celescope Catalog", "CEL 655"},
        {"Geneva Identification System", "GEN# +1.00034986"},
        {"Smithsonian Astrophysical Observation", "SAO 57958"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.79193880),
        dec: Angle.Degrees(+35.70897080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279082"},
        {"Hipparcos Number", "HIP 18073"},
        {"Smithsonian Astrophysical Observation", "SAO 56757"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.94636800),
        dec: Angle.Degrees(+35.70927551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81057"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.32173392),
        dec: Angle.Degrees(+35.71178176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59252"},
        {"Geneva Identification System", "GEN# +0.03602242"},
        {"Smithsonian Astrophysical Observation", "SAO 62865"},
        {"Wilson Evans Batten Catalogue", "WEB 10540"},
    },
    visualMagnitude: 9.93,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.31598842),
        dec: Angle.Degrees(+35.71192301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10713"},
        {"Hipparcos Number", "HIP 8194"},
        {"Geneva Identification System", "GEN# +1.00010713"},
        {"Smithsonian Astrophysical Observation", "SAO 54950"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.33531596),
        dec: Angle.Degrees(+35.71247762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170198"},
        {"Hipparcos Number", "HIP 90395"},
        {"Smithsonian Astrophysical Observation", "SAO 66979"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.66317631),
        dec: Angle.Degrees(+35.71352055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43419"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.65714859),
        dec: Angle.Degrees(+35.71403232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159221"},
        {"Hipparcos Number", "HIP 85808"},
        {"Smithsonian Astrophysical Observation", "SAO 66116"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.99735576),
        dec: Angle.Degrees(+35.71444619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119616"},
        {"Hipparcos Number", "HIP 66979"},
        {"Geneva Identification System", "GEN# +1.00119616"},
        {"Smithsonian Astrophysical Observation", "SAO 63711"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.91010789),
        dec: Angle.Degrees(+35.71488546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67680"},
        {"Geneva Identification System", "GEN# +0.03602418"},
        {"Smithsonian Astrophysical Observation", "SAO 63795"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.97700136),
        dec: Angle.Degrees(+35.71542937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66459"},
        {"Geneva Identification System", "GEN# +0.03602393"},
        {"Smithsonian Astrophysical Observation", "SAO 63647"},
        {"Wilson Evans Batten Catalogue", "WEB 11733"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.36891163),
        dec: Angle.Degrees(+35.71790527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227828"},
        {"Hipparcos Number", "HIP 99166"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.99071391),
        dec: Angle.Degrees(+35.71819873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99122",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13405 AB"},
        {"Henry Draper", "HD 191201"},
        {"Hipparcos Number", "HIP 99122"},
        {"Celescope Catalog", "CEL 4936"},
        {"Geneva Identification System", "GEN# +1.00191201"},
        {"Smithsonian Astrophysical Observation", "SAO 69446"},
        {"Wilson Evans Batten Catalogue", "WEB 17635"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.84869766),
        dec: Angle.Degrees(+35.71831196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158404"},
        {"Hipparcos Number", "HIP 85432"},
        {"Smithsonian Astrophysical Observation", "SAO 66067"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.87224456),
        dec: Angle.Degrees(+35.72039245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92389"},
        {"Hipparcos Number", "HIP 52252"},
        {"Smithsonian Astrophysical Observation", "SAO 62192"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.14546327),
        dec: Angle.Degrees(+35.72352062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2422 AB"},
        {"Henry Draper", "HD 20098"},
        {"Hipparcos Number", "HIP 15124"},
        {"Smithsonian Astrophysical Observation", "SAO 56280"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.75109839),
        dec: Angle.Degrees(+35.72392639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212202"},
        {"Hipparcos Number", "HIP 110407"},
        {"Smithsonian Astrophysical Observation", "SAO 72262"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.44848594),
        dec: Angle.Degrees(+35.72513521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213272"},
        {"Hipparcos Number", "HIP 111041"},
        {"Geneva Identification System", "GEN# +1.00213272"},
        {"Smithsonian Astrophysical Observation", "SAO 72399"},
        {"Wilson Evans Batten Catalogue", "WEB 19879"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.43352871),
        dec: Angle.Degrees(+35.72572490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111628"},
        {"Hipparcos Number", "HIP 62654"},
        {"Geneva Identification System", "GEN# +1.00111628"},
        {"Smithsonian Astrophysical Observation", "SAO 63219"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.57501399),
        dec: Angle.Degrees(+35.72582415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117099"},
        {"Hipparcos Number", "HIP 65640"},
        {"Cincinnati Publication", "Ci 20 779"},
        {"Cincinnati Publication 2", "Ci 18 1740"},
        {"Geneva Identification System", "GEN# +1.00117099"},
        {"Smithsonian Astrophysical Observation", "SAO 63548"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.86406148),
        dec: Angle.Degrees(+35.72696301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -323.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90708"},
        {"Smithsonian Astrophysical Observation", "SAO 67043"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.60684559),
        dec: Angle.Degrees(+35.72731329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104573"},
        {"Hipparcos Number", "HIP 58723"},
        {"Geneva Identification System", "GEN# +1.00104573"},
        {"Smithsonian Astrophysical Observation", "SAO 62811"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.66708978),
        dec: Angle.Degrees(+35.72734382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69330"},
        {"Hipparcos Number", "HIP 40645"},
        {"Geneva Identification System", "GEN# +1.00069330"},
        {"Smithsonian Astrophysical Observation", "SAO 60706"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.45985061),
        dec: Angle.Degrees(+35.72841777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57736"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.59248128),
        dec: Angle.Degrees(+35.72844172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54772"},
        {"Geneva Identification System", "GEN# +0.03602165"},
        {"Wilson Evans Batten Catalogue", "WEB 9887"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.19978634),
        dec: Angle.Degrees(+35.73009835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -508.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45334"},
        {"Smithsonian Astrophysical Observation", "SAO 61344"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.58725790),
        dec: Angle.Degrees(+35.73043860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197293"},
        {"Hipparcos Number", "HIP 102110"},
        {"Celescope Catalog", "CEL 5143"},
        {"Geneva Identification System", "GEN# +1.00197293"},
        {"Smithsonian Astrophysical Observation", "SAO 70380"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.39099100),
        dec: Angle.Degrees(+35.73097500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8561"},
        {"Hipparcos Number", "HIP 6636"},
        {"Fundamental Katalog 5th Edition", "FK5 4130"},
        {"Geneva Identification System", "GEN# +1.00008561"},
        {"Smithsonian Astrophysical Observation", "SAO 54679"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.28469367),
        dec: Angle.Degrees(+35.73315404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39846"},
        {"Hipparcos Number", "HIP 28145"},
        {"Smithsonian Astrophysical Observation", "SAO 58594"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.21545211),
        dec: Angle.Degrees(+35.73337114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191612"},
        {"Hipparcos Number", "HIP 99308"},
        {"Celescope Catalog", "CEL 4952"},
        {"Geneva Identification System", "GEN# +1.00191612"},
        {"Smithsonian Astrophysical Observation", "SAO 69520"},
        {"Wilson Evans Batten Catalogue", "WEB 17713"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.36921682),
        dec: Angle.Degrees(+35.73370815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198879"},
        {"Hipparcos Number", "HIP 103013"},
        {"Smithsonian Astrophysical Observation", "SAO 70610"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.06114700),
        dec: Angle.Degrees(+35.73461117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50464"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.55191634),
        dec: Angle.Degrees(+35.73573398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89794"},
        {"Smithsonian Astrophysical Observation", "SAO 66861"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.87550633),
        dec: Angle.Degrees(+35.73579686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47860"},
        {"Smithsonian Astrophysical Observation", "SAO 61667"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31917151),
        dec: Angle.Degrees(+35.73582244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203470"},
        {"Hipparcos Number", "HIP 105437"},
        {"Smithsonian Astrophysical Observation", "SAO 71239"},
        {"Wilson Evans Batten Catalogue", "WEB 19151"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34826638),
        dec: Angle.Degrees(+35.73628978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112114"},
        {"Hipparcos Number", "HIP 62927"},
        {"Fundamental Katalog 5th Edition", "FK5 5138"},
        {"Geneva Identification System", "GEN# +1.00112114"},
        {"Smithsonian Astrophysical Observation", "SAO 63239"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.43508562),
        dec: Angle.Degrees(+35.73693102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31605"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.22017807),
        dec: Angle.Degrees(+35.73743760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7851"},
        {"Smithsonian Astrophysical Observation", "SAO 54898"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.24249812),
        dec: Angle.Degrees(+35.73763301)
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
    primaryId: "HIP 81979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10193 AB"},
        {"Henry Draper", "HD 151254"},
        {"Hipparcos Number", "HIP 81979"},
        {"Smithsonian Astrophysical Observation", "SAO 65522"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.19674793),
        dec: Angle.Degrees(+35.73798473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160951"},
        {"Hipparcos Number", "HIP 86549"},
        {"Smithsonian Astrophysical Observation", "SAO 66253"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.30706924),
        dec: Angle.Degrees(+35.73823640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4581"},
        {"Hipparcos Number", "HIP 3751"},
        {"Smithsonian Astrophysical Observation", "SAO 54155"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.03910416),
        dec: Angle.Degrees(+35.73833631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4350"},
        {"Smithsonian Astrophysical Observation", "SAO 54268"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.94236758),
        dec: Angle.Degrees(+35.73922166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20707",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3209 AB"},
        {"Henry Draper", "HD 279822"},
        {"Hipparcos Number", "HIP 20707"},
        {"Smithsonian Astrophysical Observation", "SAO 57228"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.55152162),
        dec: Angle.Degrees(+35.73950246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85228"},
        {"Smithsonian Astrophysical Observation", "SAO 66025"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.22655483),
        dec: Angle.Degrees(+35.74002199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18307"},
        {"Hipparcos Number", "HIP 13796"},
        {"Geneva Identification System", "GEN# +1.00018307"},
        {"Smithsonian Astrophysical Observation", "SAO 56033"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.40521022),
        dec: Angle.Degrees(+35.74168356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84831"},
        {"Hipparcos Number", "HIP 48136"},
        {"Smithsonian Astrophysical Observation", "SAO 61695"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.20269838),
        dec: Angle.Degrees(+35.74283459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93596",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12002 AB"},
        {"Henry Draper", "HD 177543"},
        {"Hipparcos Number", "HIP 93596"},
        {"Smithsonian Astrophysical Observation", "SAO 67752"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.91533838),
        dec: Angle.Degrees(+35.74326734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 614"},
        {"Smithsonian Astrophysical Observation", "SAO 53655"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.88011435),
        dec: Angle.Degrees(+35.74574814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61589"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.30749098),
        dec: Angle.Degrees(+35.74582653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225482"},
        {"Hipparcos Number", "HIP 96995"},
        {"Geneva Identification System", "GEN# +1.00225482"},
        {"Smithsonian Astrophysical Observation", "SAO 68736"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.71326080),
        dec: Angle.Degrees(+35.75016100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74"},
        {"Smithsonian Astrophysical Observation", "SAO 73680"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.22187281),
        dec: Angle.Degrees(+35.75272213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45883"},
        {"Smithsonian Astrophysical Observation", "SAO 61422"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.33642545),
        dec: Angle.Degrees(+35.75363178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63481",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8734 AB"},
        {"Henry Draper", "HD 113001"},
        {"Hipparcos Number", "HIP 63481"},
        {"Geneva Identification System", "GEN# +1.00113001J"},
        {"Renson", "Renson 32820"},
        {"Smithsonian Astrophysical Observation", "SAO 63291"},
    },
    visualMagnitude: 9.56,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.10908588),
        dec: Angle.Degrees(+35.75574943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205419"},
        {"Hipparcos Number", "HIP 106498"},
        {"Geneva Identification System", "GEN# +1.00205419"},
        {"Smithsonian Astrophysical Observation", "SAO 71470"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.56911402),
        dec: Angle.Degrees(+35.75697439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91829"},
        {"Hipparcos Number", "HIP 51951"},
        {"Smithsonian Astrophysical Observation", "SAO 62152"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.19342257),
        dec: Angle.Degrees(+35.75755824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209655"},
        {"Hipparcos Number", "HIP 108934"},
        {"Smithsonian Astrophysical Observation", "SAO 71992"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.03428286),
        dec: Angle.Degrees(+35.75957337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114642"},
        {"Smithsonian Astrophysical Observation", "SAO 73093"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.36110975),
        dec: Angle.Degrees(+35.76203605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20962"},
        {"Hipparcos Number", "HIP 15849"},
        {"Geneva Identification System", "GEN# +1.00020962"},
        {"Smithsonian Astrophysical Observation", "SAO 56413"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.04160259),
        dec: Angle.Degrees(+35.76221637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8460 AB"},
        {"Henry Draper", "HD 106114"},
        {"Hipparcos Number", "HIP 59540"},
        {"Geneva Identification System", "GEN# +1.00106114J"},
        {"Smithsonian Astrophysical Observation", "SAO 62894"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.14165794),
        dec: Angle.Degrees(+35.76247855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200891"},
        {"Hipparcos Number", "HIP 104082"},
        {"Smithsonian Astrophysical Observation", "SAO 70883"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.29901342),
        dec: Angle.Degrees(+35.76352652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205200"},
        {"Hipparcos Number", "HIP 106379"},
        {"Geneva Identification System", "GEN# +1.00205200"},
        {"Smithsonian Astrophysical Observation", "SAO 71447"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.19293108),
        dec: Angle.Degrees(+35.76529401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85371",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10558 AB"},
        {"Henry Draper", "HD 158249"},
        {"Hipparcos Number", "HIP 85371"},
        {"Smithsonian Astrophysical Observation", "SAO 66053"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.66871535),
        dec: Angle.Degrees(+35.76576132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43024"},
        {"Smithsonian Astrophysical Observation", "SAO 61039"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.50814164),
        dec: Angle.Degrees(+35.76724273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8651 AB"},
        {"Henry Draper", "HD 110787"},
        {"Hipparcos Number", "HIP 62140"},
        {"Geneva Identification System", "GEN# +1.00110787J"},
        {"Renson", "Renson 32220"},
        {"Smithsonian Astrophysical Observation", "SAO 63165"},
        {"Wilson Evans Batten Catalogue", "WEB 11044"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.03675690),
        dec: Angle.Degrees(+35.76868797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14822 ABC"},
        {"Henry Draper", "HD 202768"},
        {"Hipparcos Number", "HIP 105072"},
        {"Smithsonian Astrophysical Observation", "SAO 71153"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.27841582),
        dec: Angle.Degrees(+35.76953936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99503"},
        {"Hipparcos Number", "HIP 55872"},
        {"Smithsonian Astrophysical Observation", "SAO 62558"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.78527788),
        dec: Angle.Degrees(+35.76966360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223521"},
        {"Hipparcos Number", "HIP 117527"},
        {"Geneva Identification System", "GEN# +1.00223521"},
        {"Smithsonian Astrophysical Observation", "SAO 73541"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.52490843),
        dec: Angle.Degrees(+35.77129102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217454"},
        {"Hipparcos Number", "HIP 113594"},
        {"Fundamental Katalog 5th Edition", "FK5 6037"},
        {"Smithsonian Astrophysical Observation", "SAO 72922"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.10321459),
        dec: Angle.Degrees(+35.77199143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6903"},
        {"Smithsonian Astrophysical Observation", "SAO 54725"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.22068627),
        dec: Angle.Degrees(+35.77239430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127763"},
        {"Hipparcos Number", "HIP 71081"},
        {"Smithsonian Astrophysical Observation", "SAO 64204"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.04555047),
        dec: Angle.Degrees(+35.77255072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222241"},
        {"Hipparcos Number", "HIP 116681"},
        {"Wilson Evans Batten Catalogue", "WEB 20592"},
    },
    visualMagnitude: 9.74,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.68805751),
        dec: Angle.Degrees(+35.77257398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175442"},
        {"Hipparcos Number", "HIP 92737"},
        {"Smithsonian Astrophysical Observation", "SAO 67540"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.46853072),
        dec: Angle.Degrees(+35.77272942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159303"},
        {"Hipparcos Number", "HIP 85841"},
        {"Smithsonian Astrophysical Observation", "SAO 66124"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.11172778),
        dec: Angle.Degrees(+35.77312776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199548"},
        {"Hipparcos Number", "HIP 103387"},
        {"Smithsonian Astrophysical Observation", "SAO 70701"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.19240397),
        dec: Angle.Degrees(+35.77454449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39938"},
        {"Hipparcos Number", "HIP 28194"},
        {"Geneva Identification System", "GEN# +1.00039938"},
        {"Smithsonian Astrophysical Observation", "SAO 58609"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.37256174),
        dec: Angle.Degrees(+35.77708769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69961"},
        {"Hipparcos Number", "HIP 40901"},
        {"Geneva Identification System", "GEN# +1.00069961"},
        {"Smithsonian Astrophysical Observation", "SAO 60744"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.19979807),
        dec: Angle.Degrees(+35.77886073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6176"},
        {"Smithsonian Astrophysical Observation", "SAO 54596"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.80882614),
        dec: Angle.Degrees(+35.77902190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154200"},
        {"Hipparcos Number", "HIP 83385"},
        {"Smithsonian Astrophysical Observation", "SAO 65747"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.63484511),
        dec: Angle.Degrees(+35.77995524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278458"},
        {"Hipparcos Number", "HIP 15222"},
        {"Smithsonian Astrophysical Observation", "SAO 56300"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.06149031),
        dec: Angle.Degrees(+35.78228709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3305"},
        {"Hipparcos Number", "HIP 2871"},
        {"Smithsonian Astrophysical Observation", "SAO 54025"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.10081015),
        dec: Angle.Degrees(+35.78247158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177644"},
        {"Hipparcos Number", "HIP 93640"},
        {"Smithsonian Astrophysical Observation", "SAO 67766"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.02985546),
        dec: Angle.Degrees(+35.78436612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75942"},
        {"Wilson Evans Batten Catalogue", "WEB 12915"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.66350834),
        dec: Angle.Degrees(+35.78455846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34577"},
        {"Hipparcos Number", "HIP 24892"},
        {"Geneva Identification System", "GEN# +1.00034577"},
        {"Smithsonian Astrophysical Observation", "SAO 57908"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.03420315),
        dec: Angle.Degrees(+35.78600748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71796"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.28804755),
        dec: Angle.Degrees(+35.78684864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46766"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.97749883),
        dec: Angle.Degrees(+35.78718340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50056"},
        {"Hipparcos Number", "HIP 33044"},
        {"Geneva Identification System", "GEN# +1.00050056"},
        {"Smithsonian Astrophysical Observation", "SAO 59574"},
        {"Wilson Evans Batten Catalogue", "WEB 6655"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.26475164),
        dec: Angle.Degrees(+35.78800835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194760"},
        {"Hipparcos Number", "HIP 100791"},
        {"Smithsonian Astrophysical Observation", "SAO 70016"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.54707987),
        dec: Angle.Degrees(+35.78807138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13374 A"},
        {"Henry Draper", "HD 190918"},
        {"Hipparcos Number", "HIP 99002"},
        {"Celescope Catalog", "CEL 4929"},
        {"Geneva Identification System", "GEN# +2.68710001"},
        {"Smithsonian Astrophysical Observation", "SAO 69402"},
        {"Wilson Evans Batten Catalogue", "WEB 17592"},
        {"New General Catalogue", "NGC 6871 1"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.48886108),
        dec: Angle.Degrees(+35.78839095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9380"},
        {"Geneva Identification System", "GEN# +0.03500386"},
        {"Smithsonian Astrophysical Observation", "SAO 55184"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.13171792),
        dec: Angle.Degrees(+35.78911868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13374 D"},
        {"Hipparcos Number", "HIP 99001"},
        {"Geneva Identification System", "GEN# +2.68710068"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.48551867),
        dec: Angle.Degrees(+35.78996769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188969"},
        {"Hipparcos Number", "HIP 98116"},
        {"Geneva Identification System", "GEN# +1.00188969"},
        {"Smithsonian Astrophysical Observation", "SAO 69119"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.10262882),
        dec: Angle.Degrees(+35.79007877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18614",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Menkhib"},
        {"Common Name 2", "Menkib"},
        {"Henry Draper", "HD 24912"},
        {"Hipparcos Number", "HIP 18614"},
        {"Celescope Catalog", "CEL 374"},
        {"Fundamental Katalog 5th Edition", "FK5 148"},
        {"Geneva Identification System", "GEN# +1.00024912"},
        {"Smithsonian Astrophysical Observation", "SAO 56856"},
        {"Wilson Evans Batten Catalogue", "WEB 3587"},
    },
    visualMagnitude: 3.98,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.74124892),
        dec: Angle.Degrees(+35.79102701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34467"},
        {"Hipparcos Number", "HIP 24815"},
        {"Geneva Identification System", "GEN# +1.00034467A"},
        {"Wilson Evans Batten Catalogue", "WEB 4799"},
    },
    visualMagnitude: 9.08,
    bvColour: 2.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.79252501),
        dec: Angle.Degrees(+35.79234971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131666"},
        {"Hipparcos Number", "HIP 72892"},
        {"Smithsonian Astrophysical Observation", "SAO 64385"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.46648329),
        dec: Angle.Degrees(+35.79481951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170617"},
        {"Hipparcos Number", "HIP 90569"},
        {"Smithsonian Astrophysical Observation", "SAO 67015"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.21318330),
        dec: Angle.Degrees(+35.79709219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99005",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13374 F"},
        {"Hipparcos Number", "HIP 99005"},
        {"Geneva Identification System", "GEN# +2.68710003"},
        {"Smithsonian Astrophysical Observation", "SAO 69403"},
        {"Wilson Evans Batten Catalogue", "WEB 17596"},
        {"New General Catalogue", "NGC 6871 3"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.49463941),
        dec: Angle.Degrees(+35.79720548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202126"},
        {"Hipparcos Number", "HIP 104728"},
        {"Geneva Identification System", "GEN# +1.00202126"},
        {"Smithsonian Astrophysical Observation", "SAO 71073"},
        {"Wilson Evans Batten Catalogue", "WEB 19048"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.22243236),
        dec: Angle.Degrees(+35.79771906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72341"},
        {"Hipparcos Number", "HIP 41996"},
        {"Smithsonian Astrophysical Observation", "SAO 60899"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.40172578),
        dec: Angle.Degrees(+35.79838959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113797"},
        {"Hipparcos Number", "HIP 63901"},
        {"Fundamental Katalog 5th Edition", "FK5 1337"},
        {"Geneva Identification System", "GEN# +1.00113797"},
        {"Smithsonian Astrophysical Observation", "SAO 63338"},
        {"Wilson Evans Batten Catalogue", "WEB 11293"},
    },
    visualMagnitude: 5.20,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.43526005),
        dec: Angle.Degrees(+35.79885169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160245"},
        {"Hipparcos Number", "HIP 86234"},
        {"Geneva Identification System", "GEN# +1.00160245"},
        {"Smithsonian Astrophysical Observation", "SAO 66189"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.33702494),
        dec: Angle.Degrees(+35.79903815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5787"},
        {"Smithsonian Astrophysical Observation", "SAO 54538"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.56098141),
        dec: Angle.Degrees(+35.79907592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222032"},
        {"Hipparcos Number", "HIP 116534"},
        {"Fundamental Katalog 5th Edition", "FK5 6090"},
        {"Smithsonian Astrophysical Observation", "SAO 73374"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.26159921),
        dec: Angle.Degrees(+35.79947427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27369"},
        {"Hipparcos Number", "HIP 20272"},
        {"Smithsonian Astrophysical Observation", "SAO 57173"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.18295307),
        dec: Angle.Degrees(+35.80014327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157464"},
        {"Hipparcos Number", "HIP 84953"},
        {"Smithsonian Astrophysical Observation", "SAO 65983"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.44864917),
        dec: Angle.Degrees(+35.80067817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76595"},
        {"Hipparcos Number", "HIP 44064"},
        {"Geneva Identification System", "GEN# +1.00076595"},
        {"Smithsonian Astrophysical Observation", "SAO 61161"},
        {"Wilson Evans Batten Catalogue", "WEB 8466"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.61411444),
        dec: Angle.Degrees(+35.80265692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3488 AB"},
        {"Henry Draper", "HD 30884"},
        {"Hipparcos Number", "HIP 22704"},
        {"Smithsonian Astrophysical Observation", "SAO 57477"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.23460862),
        dec: Angle.Degrees(+35.80289621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201614"},
        {"Hipparcos Number", "HIP 104466"},
        {"Geneva Identification System", "GEN# +1.00201614"},
        {"Smithsonian Astrophysical Observation", "SAO 70989"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.42585006),
        dec: Angle.Degrees(+35.80433364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171679"},
        {"Hipparcos Number", "HIP 91080"},
        {"Geneva Identification System", "GEN# +1.00171679"},
        {"Smithsonian Astrophysical Observation", "SAO 67129"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.66693917),
        dec: Angle.Degrees(+35.80460582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278846"},
        {"Hipparcos Number", "HIP 17077"},
        {"Smithsonian Astrophysical Observation", "SAO 56607"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.89045442),
        dec: Angle.Degrees(+35.80579549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21450"},
        {"Hipparcos Number", "HIP 16206"},
        {"Geneva Identification System", "GEN# +1.00021450"},
        {"Smithsonian Astrophysical Observation", "SAO 56486"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.20413037),
        dec: Angle.Degrees(+35.80787518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175866"},
        {"Hipparcos Number", "HIP 92920"},
        {"Geneva Identification System", "GEN# +1.00175866"},
        {"Smithsonian Astrophysical Observation", "SAO 67595"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.97308941),
        dec: Angle.Degrees(+35.81057074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47080",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7441 A"},
        {"Henry Draper", "HD 82885"},
        {"Hipparcos Number", "HIP 47080"},
        {"Cincinnati Publication", "Ci 20 536"},
        {"Geneva Identification System", "GEN# +1.00082885"},
        {"Smithsonian Astrophysical Observation", "SAO 61586"},
        {"Wilson Evans Batten Catalogue", "WEB 8866"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.91678098),
        dec: Angle.Degrees(+35.81076694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -730.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194738"},
        {"Hipparcos Number", "HIP 100777"},
        {"Geneva Identification System", "GEN# +1.00194738"},
        {"Smithsonian Astrophysical Observation", "SAO 70011"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.50396263),
        dec: Angle.Degrees(+35.81125438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49056"},
        {"Smithsonian Astrophysical Observation", "SAO 61806"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.15192980),
        dec: Angle.Degrees(+35.81127739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10361 A"},
        {"Hipparcos Number", "HIP 83842"},
        {"Smithsonian Astrophysical Observation", "SAO 65814"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.02171622),
        dec: Angle.Degrees(+35.81231961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68797"},
        {"Geneva Identification System", "GEN# +0.03602440"},
        {"Smithsonian Astrophysical Observation", "SAO 63924"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.24066859),
        dec: Angle.Degrees(+35.81406746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70568"},
        {"Smithsonian Astrophysical Observation", "SAO 64139"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.52195822),
        dec: Angle.Degrees(+35.83354690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97334"},
        {"Hipparcos Number", "HIP 54745"},
        {"Geneva Identification System", "GEN# +1.00097334"},
        {"Smithsonian Astrophysical Observation", "SAO 62451"},
        {"Wilson Evans Batten Catalogue", "WEB 9881"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.13553992),
        dec: Angle.Degrees(+35.81444810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47287"},
        {"Smithsonian Astrophysical Observation", "SAO 61610"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.55479820),
        dec: Angle.Degrees(+35.81465971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222089"},
        {"Hipparcos Number", "HIP 116579"},
        {"Geneva Identification System", "GEN# +1.00222089"},
        {"Smithsonian Astrophysical Observation", "SAO 73383"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.36693242),
        dec: Angle.Degrees(+35.81491655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30708"},
        {"Hipparcos Number", "HIP 22576"},
        {"Fundamental Katalog 5th Edition", "FK5 4446"},
        {"Geneva Identification System", "GEN# +1.00030708"},
        {"Smithsonian Astrophysical Observation", "SAO 57460"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.87261722),
        dec: Angle.Degrees(+35.81542612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8 A"},
        {"Henry Draper", "HD 225023"},
        {"Hipparcos Number", "HIP 220"},
        {"Geneva Identification System", "GEN# +1.00225023"},
        {"Smithsonian Astrophysical Observation", "SAO 53596"},
        {"Wilson Evans Batten Catalogue", "WEB 37"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.69173956),
        dec: Angle.Degrees(+35.81547283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71187"},
        {"Hipparcos Number", "HIP 41454"},
        {"Geneva Identification System", "GEN# +1.00071187"},
        {"Smithsonian Astrophysical Observation", "SAO 60822"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.82817870),
        dec: Angle.Degrees(+35.81734584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2189"},
        {"Hipparcos Number", "HIP 2054"},
        {"Geneva Identification System", "GEN# +1.00002189"},
        {"Smithsonian Astrophysical Observation", "SAO 53890"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.51115913),
        dec: Angle.Degrees(+35.81929617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56568"},
        {"Smithsonian Astrophysical Observation", "SAO 62618"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.95232117),
        dec: Angle.Degrees(+35.81935532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176774"},
        {"Hipparcos Number", "HIP 93313"},
        {"Smithsonian Astrophysical Observation", "SAO 67690"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.09608961),
        dec: Angle.Degrees(+35.82024744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79698"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.97932764),
        dec: Angle.Degrees(+35.82075932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157427"},
        {"Hipparcos Number", "HIP 84945"},
        {"Geneva Identification System", "GEN# +1.00157427"},
        {"Smithsonian Astrophysical Observation", "SAO 65981"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.41165310),
        dec: Angle.Degrees(+35.82343057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219926"},
        {"Hipparcos Number", "HIP 115145"},
        {"Geneva Identification System", "GEN# +1.00219926"},
        {"Smithsonian Astrophysical Observation", "SAO 73170"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.85195202),
        dec: Angle.Degrees(+35.82514968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97371"},
        {"Hipparcos Number", "HIP 54763"},
        {"Geneva Identification System", "GEN# +1.00097371"},
        {"Smithsonian Astrophysical Observation", "SAO 62453"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.18467811),
        dec: Angle.Degrees(+35.83014898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109179"},
        {"Hipparcos Number", "HIP 61210"},
        {"Geneva Identification System", "GEN# +1.00109179"},
        {"Smithsonian Astrophysical Observation", "SAO 63054"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.14564425),
        dec: Angle.Degrees(+35.83022999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13905 A"},
        {"Henry Draper", "HD 195271"},
        {"Hipparcos Number", "HIP 101052"},
        {"Geneva Identification System", "GEN# +1.00195271A"},
        {"Smithsonian Astrophysical Observation", "SAO 70092"},
        {"Wilson Evans Batten Catalogue", "WEB 18250"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.27451241),
        dec: Angle.Degrees(+35.83124936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14724"},
        {"Hipparcos Number", "HIP 11155"},
        {"Geneva Identification System", "GEN# +1.00014724"},
        {"Smithsonian Astrophysical Observation", "SAO 55507"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.87751621),
        dec: Angle.Degrees(+35.83325154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46157"},
        {"Smithsonian Astrophysical Observation", "SAO 61463"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.19633234),
        dec: Angle.Degrees(+35.83547838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93948"},
        {"Hipparcos Number", "HIP 53038"},
        {"Smithsonian Astrophysical Observation", "SAO 62280"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.78358127),
        dec: Angle.Degrees(+35.83864252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53563"},
        {"Smithsonian Astrophysical Observation", "SAO 62328"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.36409868),
        dec: Angle.Degrees(+35.83902761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204244"},
        {"Hipparcos Number", "HIP 105846"},
        {"Geneva Identification System", "GEN# +1.00204244"},
        {"Smithsonian Astrophysical Observation", "SAO 71337"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.57338886),
        dec: Angle.Degrees(+35.83931748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56132"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.59398479),
        dec: Angle.Degrees(+35.84168364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7201",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1211 A"},
        {"Henry Draper", "HD 9370"},
        {"Henry Draper 2", "HD 9370A"},
        {"Hipparcos Number", "HIP 7201"},
        {"Smithsonian Astrophysical Observation", "SAO 54771"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.19879964),
        dec: Angle.Degrees(+35.84280230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11202"},
        {"Hipparcos Number", "HIP 8591"},
        {"Geneva Identification System", "GEN# +1.00011202"},
        {"Smithsonian Astrophysical Observation", "SAO 55026"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.72111991),
        dec: Angle.Degrees(+35.84505207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52003"},
        {"Hipparcos Number", "HIP 33821"},
        {"Smithsonian Astrophysical Observation", "SAO 59695"},
    },
    visualMagnitude: 9.43,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.31449972),
        dec: Angle.Degrees(+35.84534573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97832"},
        {"Hipparcos Number", "HIP 54996"},
        {"Geneva Identification System", "GEN# +1.00097832"},
        {"Smithsonian Astrophysical Observation", "SAO 62464"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.90409584),
        dec: Angle.Degrees(+35.84574344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3670 AB"},
        {"Henry Draper", "HD 32574"},
        {"Hipparcos Number", "HIP 23709"},
        {"Smithsonian Astrophysical Observation", "SAO 57626"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.45508256),
        dec: Angle.Degrees(+35.84607610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4883"},
        {"Hipparcos Number", "HIP 3991"},
        {"Smithsonian Astrophysical Observation", "SAO 54201"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.82581119),
        dec: Angle.Degrees(+35.84762238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108056"},
        {"Smithsonian Astrophysical Observation", "SAO 71805"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.39529757),
        dec: Angle.Degrees(+35.84810179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188400"},
        {"Hipparcos Number", "HIP 97891"},
        {"Smithsonian Astrophysical Observation", "SAO 69039"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.39389259),
        dec: Angle.Degrees(+35.84880209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64410"},
        {"Smithsonian Astrophysical Observation", "SAO 63397"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.01708842),
        dec: Angle.Degrees(+35.85202887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62302"},
        {"Hipparcos Number", "HIP 37770"},
        {"Smithsonian Astrophysical Observation", "SAO 60311"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.17342196),
        dec: Angle.Degrees(+35.85298916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17467",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2729 AB"},
        {"Henry Draper", "HD 23204"},
        {"Hipparcos Number", "HIP 17467"},
        {"Geneva Identification System", "GEN# +1.00023204J"},
        {"Smithsonian Astrophysical Observation", "SAO 56677"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.14626412),
        dec: Angle.Degrees(+35.85576343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207088"},
        {"Hipparcos Number", "HIP 107445"},
        {"Fundamental Katalog 5th Edition", "FK5 1571"},
        {"Geneva Identification System", "GEN# +1.00207088"},
        {"Smithsonian Astrophysical Observation", "SAO 71675"},
        {"Wilson Evans Batten Catalogue", "WEB 19398"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.43519586),
        dec: Angle.Degrees(+35.85728391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 454 AB"},
        {"Henry Draper", "HD 2933"},
        {"Hipparcos Number", "HIP 2587"},
        {"Geneva Identification System", "GEN# +1.00002933J"},
        {"Smithsonian Astrophysical Observation", "SAO 53976"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.21588736),
        dec: Angle.Degrees(+35.85797535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77122"},
        {"Hipparcos Number", "HIP 44335"},
        {"Geneva Identification System", "GEN# +1.00077122"},
        {"Smithsonian Astrophysical Observation", "SAO 61205"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.43113862),
        dec: Angle.Degrees(+35.85945455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53816"},
        {"Hipparcos Number", "HIP 34411"},
        {"Geneva Identification System", "GEN# +1.00053816"},
        {"Smithsonian Astrophysical Observation", "SAO 59801"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.01148686),
        dec: Angle.Degrees(+35.86164952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61109"},
        {"Hipparcos Number", "HIP 37266"},
        {"Smithsonian Astrophysical Observation", "SAO 60246"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.79208160),
        dec: Angle.Degrees(+35.86190693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66364"},
        {"Geneva Identification System", "GEN# +0.03602387"},
        {"Smithsonian Astrophysical Observation", "SAO 63636"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.04899639),
        dec: Angle.Degrees(+35.86224241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29724"},
        {"Hipparcos Number", "HIP 21896"},
        {"Smithsonian Astrophysical Observation", "SAO 57380"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.59605525),
        dec: Angle.Degrees(+35.86257475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34426"},
        {"Hipparcos Number", "HIP 24796"},
        {"Celescope Catalog", "CEL 602"},
        {"Geneva Identification System", "GEN# +1.00034426"},
        {"Smithsonian Astrophysical Observation", "SAO 57879"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.73836520),
        dec: Angle.Degrees(+35.86411180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12921 AB"},
        {"Henry Draper", "HD 187092"},
        {"Hipparcos Number", "HIP 97320"},
        {"Smithsonian Astrophysical Observation", "SAO 68838"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.66473155),
        dec: Angle.Degrees(+35.86468909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173846"},
        {"Hipparcos Number", "HIP 92076"},
        {"Smithsonian Astrophysical Observation", "SAO 67359"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.49833842),
        dec: Angle.Degrees(+35.86487877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92302"},
        {"Smithsonian Astrophysical Observation", "SAO 67418"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.19329875),
        dec: Angle.Degrees(+35.86511460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63536"},
        {"Smithsonian Astrophysical Observation", "SAO 63302"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.30231106),
        dec: Angle.Degrees(+35.86556244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3044"},
        {"Smithsonian Astrophysical Observation", "SAO 54049"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.67190722),
        dec: Angle.Degrees(+35.86714147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17468"},
        {"Hipparcos Number", "HIP 13157"},
        {"Geneva Identification System", "GEN# +1.00017468"},
        {"Smithsonian Astrophysical Observation", "SAO 55906"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.29588593),
        dec: Angle.Degrees(+35.87051775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90716"},
        {"Hipparcos Number", "HIP 51342"},
        {"Smithsonian Astrophysical Observation", "SAO 62064"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.30434227),
        dec: Angle.Degrees(+35.87053077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146658"},
        {"Hipparcos Number", "HIP 79701"},
        {"Smithsonian Astrophysical Observation", "SAO 65184"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.98572253),
        dec: Angle.Degrees(+35.87071790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213856"},
        {"Hipparcos Number", "HIP 111378"},
        {"Geneva Identification System", "GEN# +1.00213856"},
        {"Smithsonian Astrophysical Observation", "SAO 72467"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.46275285),
        dec: Angle.Degrees(+35.87335575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204978"},
        {"Hipparcos Number", "HIP 106252"},
        {"Geneva Identification System", "GEN# +1.00204978"},
        {"Smithsonian Astrophysical Observation", "SAO 71423"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.81291633),
        dec: Angle.Degrees(+35.87353277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85052"},
        {"Hipparcos Number", "HIP 48264"},
        {"Smithsonian Astrophysical Observation", "SAO 61708"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.59039314),
        dec: Angle.Degrees(+35.87356699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205513"},
        {"Hipparcos Number", "HIP 106558"},
        {"Smithsonian Astrophysical Observation", "SAO 71481"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.70914319),
        dec: Angle.Degrees(+35.87513142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174063"},
        {"Hipparcos Number", "HIP 92170"},
        {"Geneva Identification System", "GEN# +1.00174063"},
        {"Smithsonian Astrophysical Observation", "SAO 67380"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.78266473),
        dec: Angle.Degrees(+35.87567583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1677"},
        {"Hipparcos Number", "HIP 1688"},
        {"Geneva Identification System", "GEN# +1.00001677"},
        {"Renson", "Renson 360"},
        {"Smithsonian Astrophysical Observation", "SAO 53831"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.28852000),
        dec: Angle.Degrees(+35.87887562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178160"},
        {"Hipparcos Number", "HIP 93788"},
        {"Smithsonian Astrophysical Observation", "SAO 67810"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.49735274),
        dec: Angle.Degrees(+35.88073448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193874"},
        {"Hipparcos Number", "HIP 100367"},
        {"Smithsonian Astrophysical Observation", "SAO 69882"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.32236855),
        dec: Angle.Degrees(+35.88377446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115349"},
        {"Hipparcos Number", "HIP 64747"},
        {"Geneva Identification System", "GEN# +1.00115349"},
        {"Smithsonian Astrophysical Observation", "SAO 63437"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.04607423),
        dec: Angle.Degrees(+35.88628889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64864"},
        {"Smithsonian Astrophysical Observation", "SAO 63454"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.43182839),
        dec: Angle.Degrees(+35.89134167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71323"},
        {"Hipparcos Number", "HIP 41519"},
        {"Smithsonian Astrophysical Observation", "SAO 60830"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.01718841),
        dec: Angle.Degrees(+35.89184915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30944"},
        {"Cincinnati Publication", "Ci 20 388"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.41651853),
        dec: Angle.Degrees(+35.89318406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 353.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -381.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161712"},
        {"Hipparcos Number", "HIP 86908"},
        {"Geneva Identification System", "GEN# +1.00161712"},
        {"Smithsonian Astrophysical Observation", "SAO 66309"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.36863152),
        dec: Angle.Degrees(+35.89330451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44347"},
        {"Smithsonian Astrophysical Observation", "SAO 61208"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.47826927),
        dec: Angle.Degrees(+35.89388286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102159"},
        {"Hipparcos Number", "HIP 57362"},
        {"Geneva Identification System", "GEN# +1.00102159"},
        {"Smithsonian Astrophysical Observation", "SAO 62693"},
        {"Wilson Evans Batten Catalogue", "WEB 10310"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.39611523),
        dec: Angle.Degrees(+35.89428620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72838"},
        {"Smithsonian Astrophysical Observation", "SAO 64380"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.32496989),
        dec: Angle.Degrees(+35.89577240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147587"},
        {"Hipparcos Number", "HIP 80128"},
        {"Smithsonian Astrophysical Observation", "SAO 65245"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.33631502),
        dec: Angle.Degrees(+35.89770316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18088"},
        {"Hipparcos Number", "HIP 13622"},
        {"Smithsonian Astrophysical Observation", "SAO 56000"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86815250),
        dec: Angle.Degrees(+35.89843203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55251"},
        {"Smithsonian Astrophysical Observation", "SAO 62490"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.73777195),
        dec: Angle.Degrees(+35.89908938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35755"},
        {"Geneva Identification System", "GEN# +0.03601611B"},
    },
    visualMagnitude: 11.57,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.62936477),
        dec: Angle.Degrees(+35.89976276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27683"},
        {"Hipparcos Number", "HIP 20497"},
        {"Geneva Identification System", "GEN# +1.00027683"},
        {"Smithsonian Astrophysical Observation", "SAO 57200"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.89663066),
        dec: Angle.Degrees(+35.90308665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50170"},
        {"Smithsonian Astrophysical Observation", "SAO 61945"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.61278299),
        dec: Angle.Degrees(+35.90524256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183184"},
        {"Hipparcos Number", "HIP 95616"},
        {"Celescope Catalog", "CEL 4759"},
        {"Geneva Identification System", "GEN# +1.00183184"},
        {"Smithsonian Astrophysical Observation", "SAO 68320"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.72209070),
        dec: Angle.Degrees(+35.90674981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71845"},
        {"Hipparcos Number", "HIP 41758"},
        {"Smithsonian Astrophysical Observation", "SAO 60859"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.73237465),
        dec: Angle.Degrees(+35.90899605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102704"},
        {"Celescope Catalog", "CEL 5170"},
        {"Geneva Identification System", "GEN# +0.03504272"},
        {"Smithsonian Astrophysical Observation", "SAO 70527"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.14934027),
        dec: Angle.Degrees(+35.91074006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197292"},
        {"Hipparcos Number", "HIP 102105"},
        {"Geneva Identification System", "GEN# +1.00197292"},
        {"Smithsonian Astrophysical Observation", "SAO 70379"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.38384031),
        dec: Angle.Degrees(+35.91116847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40050",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6635 A"},
        {"Henry Draper", "HD 67742"},
        {"Hipparcos Number", "HIP 40050"},
        {"Smithsonian Astrophysical Observation", "SAO 60621"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.71634953),
        dec: Angle.Degrees(+35.91203191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120788"},
        {"Hipparcos Number", "HIP 67579"},
        {"Geneva Identification System", "GEN# +1.00120788J"},
        {"Smithsonian Astrophysical Observation", "SAO 63778"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.71412283),
        dec: Angle.Degrees(+35.91326157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47413"},
        {"Smithsonian Astrophysical Observation", "SAO 61619"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.92063537),
        dec: Angle.Degrees(+35.91516545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25508"},
        {"Hipparcos Number", "HIP 19028"},
        {"Smithsonian Astrophysical Observation", "SAO 56946"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.14068781),
        dec: Angle.Degrees(+35.92058655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72214"},
        {"Smithsonian Astrophysical Observation", "SAO 64318"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.53960774),
        dec: Angle.Degrees(+35.92089776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151878"},
        {"Hipparcos Number", "HIP 82275"},
        {"Smithsonian Astrophysical Observation", "SAO 65569"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.17284011),
        dec: Angle.Degrees(+35.92204026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198691"},
        {"Hipparcos Number", "HIP 102907"},
        {"Smithsonian Astrophysical Observation", "SAO 70574"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.71982374),
        dec: Angle.Degrees(+35.92208830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139243"},
        {"Hipparcos Number", "HIP 76369"},
        {"Geneva Identification System", "GEN# +1.00139243"},
        {"Smithsonian Astrophysical Observation", "SAO 64796"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.96527860),
        dec: Angle.Degrees(+35.92358797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49687"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.14205813),
        dec: Angle.Degrees(+35.92383683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25593"},
        {"Geneva Identification System", "GEN# +2.19120271"},
        {"New General Catalogue", "NGC 1912 271"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04360115),
        dec: Angle.Degrees(+35.92389435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73663"},
        {"Smithsonian Astrophysical Observation", "SAO 64483"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.86728846),
        dec: Angle.Degrees(+35.92472356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83091"},
        {"Smithsonian Astrophysical Observation", "SAO 65694"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.67587021),
        dec: Angle.Degrees(+35.92597597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26291"},
        {"Hipparcos Number", "HIP 19539"},
        {"Smithsonian Astrophysical Observation", "SAO 57049"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.77911395),
        dec: Angle.Degrees(+35.92832399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96660"},
        {"Smithsonian Astrophysical Observation", "SAO 68634"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.79186084),
        dec: Angle.Degrees(+35.92853185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114773"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.73926441),
        dec: Angle.Degrees(+35.92858163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116378"},
        {"Hipparcos Number", "HIP 65274"},
        {"Smithsonian Astrophysical Observation", "SAO 63504"},
        {"Wilson Evans Batten Catalogue", "WEB 11520"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.66856336),
        dec: Angle.Degrees(+35.92859371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89249"},
        {"Smithsonian Astrophysical Observation", "SAO 66755"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.18534910),
        dec: Angle.Degrees(+35.92874937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128661"},
        {"Hipparcos Number", "HIP 71487"},
        {"Geneva Identification System", "GEN# +1.00128661"},
        {"Renson", "Renson 36600"},
        {"Smithsonian Astrophysical Observation", "SAO 64240"},
        {"Wilson Evans Batten Catalogue", "WEB 12332"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.28681365),
        dec: Angle.Degrees(+35.92975143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32054"},
        {"Hipparcos Number", "HIP 23427"},
        {"Geneva Identification System", "GEN# +1.00032054"},
        {"Smithsonian Astrophysical Observation", "SAO 57586"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.52839976),
        dec: Angle.Degrees(+35.93017753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 923"},
        {"Geneva Identification System", "GEN# +0.03500018"},
        {"Smithsonian Astrophysical Observation", "SAO 53704"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.87258462),
        dec: Angle.Degrees(+35.93108811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219372"},
        {"Hipparcos Number", "HIP 114778"},
        {"Smithsonian Astrophysical Observation", "SAO 73113"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.74530222),
        dec: Angle.Degrees(+35.93181849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47703"},
        {"Hipparcos Number", "HIP 32040"},
        {"Fundamental Katalog 5th Edition", "FK5 2516"},
        {"Geneva Identification System", "GEN# +1.00047703"},
        {"Smithsonian Astrophysical Observation", "SAO 59365"},
        {"Wilson Evans Batten Catalogue", "WEB 6464"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.40737405),
        dec: Angle.Degrees(+35.93199076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91485"},
        {"Smithsonian Astrophysical Observation", "SAO 67215"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.87069580),
        dec: Angle.Degrees(+35.93439146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114519"},
        {"Hipparcos Number", "HIP 64293"},
        {"Geneva Identification System", "GEN# +1.00114519"},
        {"Renson", "Renson 33090"},
        {"Smithsonian Astrophysical Observation", "SAO 63382"},
        {"Wilson Evans Batten Catalogue", "WEB 11363"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.65393208),
        dec: Angle.Degrees(+35.93483408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83838",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10360 AB"},
        {"Henry Draper", "HD 155103"},
        {"Hipparcos Number", "HIP 83838"},
        {"Geneva Identification System", "GEN# +1.00155103J"},
        {"Renson", "Renson 43790"},
        {"Smithsonian Astrophysical Observation", "SAO 65812"},
        {"Wilson Evans Batten Catalogue", "WEB 14166"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.00867045),
        dec: Angle.Degrees(+35.93521504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59883"},
        {"Geneva Identification System", "GEN# +0.03602256"},
        {"Smithsonian Astrophysical Observation", "SAO 62933"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.21491289),
        dec: Angle.Degrees(+35.93633929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32608"},
        {"Hipparcos Number", "HIP 23724"},
        {"Fundamental Katalog 5th Edition", "FK5 2379"},
        {"Geneva Identification System", "GEN# +1.00032608"},
        {"Renson", "Renson 8300"},
        {"Smithsonian Astrophysical Observation", "SAO 57629"},
        {"Wilson Evans Batten Catalogue", "WEB 4628"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.50387497),
        dec: Angle.Degrees(+35.93641980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42223"},
        {"Smithsonian Astrophysical Observation", "SAO 60917"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.13227076),
        dec: Angle.Degrees(+35.93677895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213258"},
        {"Hipparcos Number", "HIP 111032"},
        {"Geneva Identification System", "GEN# +1.00213258"},
        {"Smithsonian Astrophysical Observation", "SAO 72395"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.40429929),
        dec: Angle.Degrees(+35.93780655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91577"},
        {"Hipparcos Number", "HIP 51804"},
        {"Smithsonian Astrophysical Observation", "SAO 62135"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.76524655),
        dec: Angle.Degrees(+35.93780832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62548"},
        {"Geneva Identification System", "GEN# +0.03602308"},
        {"Smithsonian Astrophysical Observation", "SAO 63205"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.24092172),
        dec: Angle.Degrees(+35.93859749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64366"},
        {"Geneva Identification System", "GEN# +0.03602345"},
        {"Smithsonian Astrophysical Observation", "SAO 63391"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.88681660),
        dec: Angle.Degrees(+35.93861810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68874"},
        {"Hipparcos Number", "HIP 40470"},
        {"Fundamental Katalog 5th Edition", "FK5 4742"},
        {"Smithsonian Astrophysical Observation", "SAO 60683"},
        {"Wilson Evans Batten Catalogue", "WEB 7881"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.95258129),
        dec: Angle.Degrees(+35.93930676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14017"},
        {"Hipparcos Number", "HIP 10647"},
        {"Geneva Identification System", "GEN# +1.00014017"},
        {"Smithsonian Astrophysical Observation", "SAO 55423"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.26510168),
        dec: Angle.Degrees(+35.94090482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83811"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.92603468),
        dec: Angle.Degrees(+35.94697464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14560",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2361 AB"},
        {"Henry Draper", "HD 19357"},
        {"Hipparcos Number", "HIP 14560"},
        {"Smithsonian Astrophysical Observation", "SAO 56185"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.99462438),
        dec: Angle.Degrees(+35.94791590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112339"},
        {"Hipparcos Number", "HIP 63101"},
        {"Geneva Identification System", "GEN# +1.00112339"},
        {"Smithsonian Astrophysical Observation", "SAO 63254"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.92272001),
        dec: Angle.Degrees(+35.94878304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62006"},
        {"Geneva Identification System", "GEN# +0.03602301"},
        {"Smithsonian Astrophysical Observation", "SAO 63147"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.62253001),
        dec: Angle.Degrees(+35.94955145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110066"},
        {"Hipparcos Number", "HIP 61748"},
        {"Fundamental Katalog 5th Edition", "FK5 3013"},
        {"Geneva Identification System", "GEN# +1.00110066"},
        {"Renson", "Renson 31960"},
        {"Smithsonian Astrophysical Observation", "SAO 63118"},
        {"Wilson Evans Batten Catalogue", "WEB 10984"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.82019537),
        dec: Angle.Degrees(+35.95196539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36936"},
        {"Geneva Identification System", "GEN# +0.03601650"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.89109607),
        dec: Angle.Degrees(+35.95306141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191917"},
        {"Hipparcos Number", "HIP 99437"},
        {"Celescope Catalog", "CEL 4960"},
        {"Geneva Identification System", "GEN# +2.68830038"},
        {"Smithsonian Astrophysical Observation", "SAO 69564"},
        {"Wilson Evans Batten Catalogue", "WEB 17764"},
        {"New General Catalogue", "NGC 6883 38"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.73760042),
        dec: Angle.Degrees(+35.95318368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29409"},
        {"Hipparcos Number", "HIP 21691"},
        {"Smithsonian Astrophysical Observation", "SAO 57362"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.85415428),
        dec: Angle.Degrees(+35.95431882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87092"},
        {"Hipparcos Number", "HIP 49283"},
        {"Smithsonian Astrophysical Observation", "SAO 61831"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.89561457),
        dec: Angle.Degrees(+35.95434880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71322"},
        {"Hipparcos Number", "HIP 41530"},
        {"Geneva Identification System", "GEN# +1.00071322"},
        {"Smithsonian Astrophysical Observation", "SAO 60833"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05030547),
        dec: Angle.Degrees(+35.95461439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117945"},
        {"Fundamental Katalog 5th Edition", "FK5 6121"},
        {"Smithsonian Astrophysical Observation", "SAO 73614"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.85786837),
        dec: Angle.Degrees(+35.95535158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33398"},
        {"Hipparcos Number", "HIP 24184"},
        {"Fundamental Katalog 5th Edition", "FK5 4474"},
        {"Smithsonian Astrophysical Observation", "SAO 57727"},
        {"Wilson Evans Batten Catalogue", "WEB 4695"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.89176687),
        dec: Angle.Degrees(+35.95732786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193064"},
        {"Hipparcos Number", "HIP 99986"},
        {"Celescope Catalog", "CEL 5012"},
        {"Geneva Identification System", "GEN# +1.00193064"},
        {"Smithsonian Astrophysical Observation", "SAO 69753"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.25224130),
        dec: Angle.Degrees(+35.95742012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88499"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.07305002),
        dec: Angle.Degrees(+35.95779754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99284"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.31183080),
        dec: Angle.Degrees(+35.95816381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27411"},
        {"Smithsonian Astrophysical Observation", "SAO 58448"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.06846151),
        dec: Angle.Degrees(+35.95850127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77141"},
        {"Wilson Evans Batten Catalogue", "WEB 13078"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.25101703),
        dec: Angle.Degrees(+35.96140534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108683"},
        {"Smithsonian Astrophysical Observation", "SAO 71947"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.25401470),
        dec: Angle.Degrees(+35.96273263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64490"},
        {"Hipparcos Number", "HIP 38719"},
        {"Geneva Identification System", "GEN# +1.00064490"},
        {"Smithsonian Astrophysical Observation", "SAO 60451"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.90477543),
        dec: Angle.Degrees(+35.96401983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220887"},
        {"Hipparcos Number", "HIP 115763"},
        {"Geneva Identification System", "GEN# +1.00220887"},
        {"Smithsonian Astrophysical Observation", "SAO 73265"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.80518040),
        dec: Angle.Degrees(+35.96451356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73760"},
        {"Hipparcos Number", "HIP 42623"},
        {"Geneva Identification System", "GEN# +1.00073760"},
        {"Smithsonian Astrophysical Observation", "SAO 60981"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.30180607),
        dec: Angle.Degrees(+35.96624131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113546"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.95205006),
        dec: Angle.Degrees(+35.96631848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88427"},
        {"Smithsonian Astrophysical Observation", "SAO 66587"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.80369484),
        dec: Angle.Degrees(+35.96868510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101313"},
        {"Smithsonian Astrophysical Observation", "SAO 70161"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.02692474),
        dec: Angle.Degrees(+35.96895872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165339"},
        {"Hipparcos Number", "HIP 88473"},
        {"Geneva Identification System", "GEN# +1.00165339"},
        {"Smithsonian Astrophysical Observation", "SAO 66598"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.97462384),
        dec: Angle.Degrees(+35.97029987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135181"},
        {"Hipparcos Number", "HIP 74422"},
        {"Smithsonian Astrophysical Observation", "SAO 64558"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.14375483),
        dec: Angle.Degrees(+35.97163539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222491"},
        {"Hipparcos Number", "HIP 116842"},
        {"Smithsonian Astrophysical Observation", "SAO 73433"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.25205618),
        dec: Angle.Degrees(+35.97183561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66593"},
        {"Geneva Identification System", "GEN# +0.03602397"},
        {"Wilson Evans Batten Catalogue", "WEB 11747"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.75731942),
        dec: Angle.Degrees(+35.97189695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78280"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.74718270),
        dec: Angle.Degrees(+35.97216851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64534"},
        {"Hipparcos Number", "HIP 38735"},
        {"Geneva Identification System", "GEN# +1.00064534"},
        {"Smithsonian Astrophysical Observation", "SAO 60455"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.95219585),
        dec: Angle.Degrees(+35.97290599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191026"},
        {"Hipparcos Number", "HIP 99031"},
        {"Cincinnati Publication", "Ci 20 1192"},
        {"Geneva Identification System", "GEN# +1.00191026"},
        {"Smithsonian Astrophysical Observation", "SAO 69413"},
        {"Wilson Evans Batten Catalogue", "WEB 17606"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.59137234),
        dec: Angle.Degrees(+35.97353894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -440.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101777"},
        {"Smithsonian Astrophysical Observation", "SAO 70297"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.40679067),
        dec: Angle.Degrees(+35.97531200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60615"},
        {"Geneva Identification System", "GEN# +0.03602268"},
        {"Wilson Evans Batten Catalogue", "WEB 10781"},
    },
    visualMagnitude: 10.37,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.34770178),
        dec: Angle.Degrees(+35.97596456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26506"},
        {"Smithsonian Astrophysical Observation", "SAO 58270"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.55357206),
        dec: Angle.Degrees(+35.97725569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26140"},
        {"Hipparcos Number", "HIP 19435"},
        {"Geneva Identification System", "GEN# +1.00026140"},
        {"Smithsonian Astrophysical Observation", "SAO 57025"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.42982205),
        dec: Angle.Degrees(+35.97755652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84233"},
        {"Wilson Evans Batten Catalogue", "WEB 14227"},
    },
    visualMagnitude: 11.68,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.26673407),
        dec: Angle.Degrees(+35.97866280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79497"},
        {"Hipparcos Number", "HIP 45438"},
        {"Smithsonian Astrophysical Observation", "SAO 61366"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.90012845),
        dec: Angle.Degrees(+35.98132991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95735"},
        {"Hipparcos Number", "HIP 54035"},
        {"Cincinnati Publication", "Ci 20 604"},
        {"Geneva Identification System", "GEN# +1.00095735"},
        {"Smithsonian Astrophysical Observation", "SAO 62377"},
        {"Wilson Evans Batten Catalogue", "WEB 9772"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.83588409),
        dec: Angle.Degrees(+35.98146424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -580.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4767.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38722"},
        {"Hipparcos Number", "HIP 27501"},
        {"Geneva Identification System", "GEN# +1.00038722"},
        {"Smithsonian Astrophysical Observation", "SAO 58475"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.35335597),
        dec: Angle.Degrees(+35.98186679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17228"},
        {"Hipparcos Number", "HIP 12982"},
        {"Fundamental Katalog 5th Edition", "FK5 4253"},
        {"Geneva Identification System", "GEN# +1.00017228"},
        {"Smithsonian Astrophysical Observation", "SAO 55868"},
        {"Wilson Evans Batten Catalogue", "WEB 2625"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.74284779),
        dec: Angle.Degrees(+35.98353306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216722"},
        {"Hipparcos Number", "HIP 113144"},
        {"Geneva Identification System", "GEN# +1.00216722"},
        {"Smithsonian Astrophysical Observation", "SAO 72833"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.68162806),
        dec: Angle.Degrees(+35.98363303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66232"},
        {"Geneva Identification System", "GEN# +0.03602384"},
        {"Smithsonian Astrophysical Observation", "SAO 63617"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.61128621),
        dec: Angle.Degrees(+35.98714967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195991"},
        {"Hipparcos Number", "HIP 101426"},
        {"Renson", "Renson 54640"},
        {"Smithsonian Astrophysical Observation", "SAO 70188"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.31289753),
        dec: Angle.Degrees(+35.98936202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1492",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 255 A"},
        {"Henry Draper", "HD 1428"},
        {"Hipparcos Number", "HIP 1492"},
        {"Smithsonian Astrophysical Observation", "SAO 53802"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.65134950),
        dec: Angle.Degrees(+35.98998187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180989"},
        {"Hipparcos Number", "HIP 94788"},
        {"Geneva Identification System", "GEN# +1.00180989"},
        {"Smithsonian Astrophysical Observation", "SAO 68082"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.29962325),
        dec: Angle.Degrees(+35.99142906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27126"},
        {"Hipparcos Number", "HIP 20094"},
        {"Geneva Identification System", "GEN# +1.00027126"},
        {"Smithsonian Astrophysical Observation", "SAO 57142"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.62354738),
        dec: Angle.Degrees(+35.99252383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -343.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92221"},
        {"Wilson Evans Batten Catalogue", "WEB 15913"},
    },
    visualMagnitude: 11.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.91802078),
        dec: Angle.Degrees(+35.99278192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5984"},
        {"Hipparcos Number", "HIP 4797"},
        {"Smithsonian Astrophysical Observation", "SAO 54355"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.39478638),
        dec: Angle.Degrees(+35.99540532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56123"},
        {"Hipparcos Number", "HIP 35282"},
        {"Smithsonian Astrophysical Observation", "SAO 59948"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.33307424),
        dec: Angle.Degrees(+35.99729924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76859"},
        {"Smithsonian Astrophysical Observation", "SAO 64851"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.42465724),
        dec: Angle.Degrees(+35.99846313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182842"},
        {"Hipparcos Number", "HIP 95459"},
        {"Smithsonian Astrophysical Observation", "SAO 68282"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28447760),
        dec: Angle.Degrees(+35.99944679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36261"},
        {"Hipparcos Number", "HIP 25940"},
        {"Smithsonian Astrophysical Observation", "SAO 58152"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.03848700),
        dec: Angle.Degrees(+36.00023796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117616"},
        {"Smithsonian Astrophysical Observation", "SAO 73552"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.80527556),
        dec: Angle.Degrees(+36.00050963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162133"},
        {"Hipparcos Number", "HIP 87110"},
        {"Smithsonian Astrophysical Observation", "SAO 66338"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.97669793),
        dec: Angle.Degrees(+36.00163062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11670"},
        {"Hipparcos Number", "HIP 8948"},
        {"Smithsonian Astrophysical Observation", "SAO 55088"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.81217516),
        dec: Angle.Degrees(+36.00223965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24664"},
        {"Hipparcos Number", "HIP 18464"},
        {"Geneva Identification System", "GEN# +1.00024664"},
        {"Smithsonian Astrophysical Observation", "SAO 56829"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.18749276),
        dec: Angle.Degrees(+36.00262800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113874"},
        {"Smithsonian Astrophysical Observation", "SAO 72966"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.92143845),
        dec: Angle.Degrees(+36.00550718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16579"},
        {"Hipparcos Number", "HIP 12465"},
        {"Smithsonian Astrophysical Observation", "SAO 55774"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13029847),
        dec: Angle.Degrees(+36.00588297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221490"},
        {"Hipparcos Number", "HIP 116177"},
        {"Geneva Identification System", "GEN# +1.00221490"},
        {"Smithsonian Astrophysical Observation", "SAO 73324"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.09417110),
        dec: Angle.Degrees(+36.00685758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96677"},
        {"Hipparcos Number", "HIP 54465"},
        {"Smithsonian Astrophysical Observation", "SAO 62421"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.14902289),
        dec: Angle.Degrees(+36.01081584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73251"},
        {"Smithsonian Astrophysical Observation", "SAO 64427"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.56277483),
        dec: Angle.Degrees(+36.01125470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111135"},
        {"Smithsonian Astrophysical Observation", "SAO 72421"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.70857467),
        dec: Angle.Degrees(+36.01271652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55990"},
        {"Smithsonian Astrophysical Observation", "SAO 62570"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.12089398),
        dec: Angle.Degrees(+36.01593033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62832"},
        {"Geneva Identification System", "GEN# +0.03602313"},
        {"Smithsonian Astrophysical Observation", "SAO 63231"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.14007640),
        dec: Angle.Degrees(+36.01738891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278575"},
        {"Hipparcos Number", "HIP 15949"},
        {"Smithsonian Astrophysical Observation", "SAO 56433"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.34211555),
        dec: Angle.Degrees(+36.01746827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217922"},
        {"Hipparcos Number", "HIP 113875"},
        {"Smithsonian Astrophysical Observation", "SAO 72967"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.92397551),
        dec: Angle.Degrees(+36.01749439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145769"},
        {"Hipparcos Number", "HIP 79314"},
        {"Smithsonian Astrophysical Observation", "SAO 65126"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.80184133),
        dec: Angle.Degrees(+36.02106491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13312"},
        {"Hipparcos Number", "HIP 10186"},
        {"Smithsonian Astrophysical Observation", "SAO 55332"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.73667030),
        dec: Angle.Degrees(+36.02164969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184522"},
        {"Hipparcos Number", "HIP 96189"},
        {"Smithsonian Astrophysical Observation", "SAO 68494"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.37421408),
        dec: Angle.Degrees(+36.02203569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143347"},
        {"Hipparcos Number", "HIP 78235"},
        {"Smithsonian Astrophysical Observation", "SAO 64995"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.62834018),
        dec: Angle.Degrees(+36.02214608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13312 AB"},
        {"Henry Draper", "HD 190429"},
        {"Hipparcos Number", "HIP 98753"},
        {"Celescope Catalog", "CEL 4922"},
        {"Geneva Identification System", "GEN# +1.00190429J"},
        {"Smithsonian Astrophysical Observation", "SAO 69324"},
        {"Wilson Evans Batten Catalogue", "WEB 17494"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.87250605),
        dec: Angle.Degrees(+36.02515949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200253"},
        {"Hipparcos Number", "HIP 103734"},
        {"Fundamental Katalog 5th Edition", "FK5 3677"},
        {"Geneva Identification System", "GEN# +1.00200253"},
        {"Smithsonian Astrophysical Observation", "SAO 70794"},
        {"Wilson Evans Batten Catalogue", "WEB 18879"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.30361308),
        dec: Angle.Degrees(+36.02602514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148126"},
        {"Hipparcos Number", "HIP 80393"},
        {"Smithsonian Astrophysical Observation", "SAO 65283"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.14746272),
        dec: Angle.Degrees(+36.02751184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170287"},
        {"Hipparcos Number", "HIP 90426"},
        {"Smithsonian Astrophysical Observation", "SAO 66989"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.75620909),
        dec: Angle.Degrees(+36.02937755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26103"},
        {"Hipparcos Number", "HIP 19405"},
        {"Geneva Identification System", "GEN# +1.00026103"},
        {"Smithsonian Astrophysical Observation", "SAO 57019"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34724208),
        dec: Angle.Degrees(+36.03440451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27658"},
        {"Hipparcos Number", "HIP 20468"},
        {"Smithsonian Astrophysical Observation", "SAO 57198"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.79622149),
        dec: Angle.Degrees(+36.03530561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181381"},
        {"Hipparcos Number", "HIP 94912"},
        {"Smithsonian Astrophysical Observation", "SAO 68118"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.70763100),
        dec: Angle.Degrees(+36.03578704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117858"},
        {"Hipparcos Number", "HIP 66051"},
        {"Geneva Identification System", "GEN# +1.00117858"},
        {"Smithsonian Astrophysical Observation", "SAO 63594"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.12879967),
        dec: Angle.Degrees(+36.03582923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -288.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149956"},
        {"Hipparcos Number", "HIP 81319"},
        {"Geneva Identification System", "GEN# +1.00149956"},
        {"Smithsonian Astrophysical Observation", "SAO 65430"},
        {"Wilson Evans Batten Catalogue", "WEB 13745"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.13204560),
        dec: Angle.Degrees(+36.03999909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152154"},
        {"Hipparcos Number", "HIP 82391"},
        {"Smithsonian Astrophysical Observation", "SAO 65589"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.52674763),
        dec: Angle.Degrees(+36.04001455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95184"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.45099584),
        dec: Angle.Degrees(+36.04065847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37686"},
        {"Smithsonian Astrophysical Observation", "SAO 60303"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.97444329),
        dec: Angle.Degrees(+36.04112096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104438"},
        {"Hipparcos Number", "HIP 58654"},
        {"Fundamental Katalog 5th Edition", "FK5 2963"},
        {"Geneva Identification System", "GEN# +1.00104438"},
        {"Smithsonian Astrophysical Observation", "SAO 62802"},
        {"Wilson Evans Batten Catalogue", "WEB 10464"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.41471830),
        dec: Angle.Degrees(+36.04227697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106908"},
        {"Smithsonian Astrophysical Observation", "SAO 71562"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.77755695),
        dec: Angle.Degrees(+36.04407316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40327"},
        {"Hipparcos Number", "HIP 28388"},
        {"Smithsonian Astrophysical Observation", "SAO 58639"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.94824124),
        dec: Angle.Degrees(+36.04507561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96194"},
        {"Smithsonian Astrophysical Observation", "SAO 68498"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.40001158),
        dec: Angle.Degrees(+36.04611053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69885"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.53056096),
        dec: Angle.Degrees(+36.04915406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28738"},
        {"Smithsonian Astrophysical Observation", "SAO 58705"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.04548087),
        dec: Angle.Degrees(+36.05032177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130742"},
        {"Hipparcos Number", "HIP 72440"},
        {"Smithsonian Astrophysical Observation", "SAO 64339"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.19501070),
        dec: Angle.Degrees(+36.05032942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11190"},
        {"Hipparcos Number", "HIP 8581"},
        {"Smithsonian Astrophysical Observation", "SAO 55023"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.68667868),
        dec: Angle.Degrees(+36.05139327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4321"},
        {"Fundamental Katalog 5th Edition", "FK5 4080"},
        {"Geneva Identification System", "GEN# +0.03500167"},
        {"Smithsonian Astrophysical Observation", "SAO 54262"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.82130715),
        dec: Angle.Degrees(+36.05185293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128040"},
        {"Hipparcos Number", "HIP 71200"},
        {"Smithsonian Astrophysical Observation", "SAO 64214"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.42154820),
        dec: Angle.Degrees(+36.05193425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72145"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.34950488),
        dec: Angle.Degrees(+36.05221434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -242.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11534 A"},
        {"Henry Draper", "HD 172394"},
        {"Henry Draper 2", "HD 172394A"},
        {"Hipparcos Number", "HIP 91399"},
        {"Renson", "Renson 48300"},
        {"Smithsonian Astrophysical Observation", "SAO 67198"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.60700853),
        dec: Angle.Degrees(+36.05323616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86323"},
        {"Smithsonian Astrophysical Observation", "SAO 66202"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.57233122),
        dec: Angle.Degrees(+36.05928558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8508"},
        {"Hipparcos Number", "HIP 6597"},
        {"Geneva Identification System", "GEN# +1.00008508"},
        {"Smithsonian Astrophysical Observation", "SAO 54670"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.17878013),
        dec: Angle.Degrees(+36.06409531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168775"},
        {"Hipparcos Number", "HIP 89826"},
        {"Fundamental Katalog 5th Edition", "FK5 1477"},
        {"Geneva Identification System", "GEN# +1.00168775"},
        {"Smithsonian Astrophysical Observation", "SAO 66869"},
        {"Wilson Evans Batten Catalogue", "WEB 15332"},
    },
    visualMagnitude: 4.33,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.96550503),
        dec: Angle.Degrees(+36.06444696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41599"},
        {"Hipparcos Number", "HIP 29068"},
        {"Smithsonian Astrophysical Observation", "SAO 58769"},
        {"Wilson Evans Batten Catalogue", "WEB 5692"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.98323113),
        dec: Angle.Degrees(+36.06536380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112823"},
    },
    visualMagnitude: 11.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.72513732),
        dec: Angle.Degrees(+36.06635781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -372.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130786"},
        {"Hipparcos Number", "HIP 72458"},
        {"Smithsonian Astrophysical Observation", "SAO 64342"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.25551536),
        dec: Angle.Degrees(+36.06812732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34095"},
        {"Hipparcos Number", "HIP 24587"},
        {"Smithsonian Astrophysical Observation", "SAO 57819"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.12067402),
        dec: Angle.Degrees(+36.07183942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57227"},
        {"Hipparcos Number", "HIP 35688"},
        {"Smithsonian Astrophysical Observation", "SAO 60005"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.45847513),
        dec: Angle.Degrees(+36.07261711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46051"},
        {"Smithsonian Astrophysical Observation", "SAO 61443"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.86713566),
        dec: Angle.Degrees(+36.07332629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170261"},
        {"Hipparcos Number", "HIP 90419"},
        {"Geneva Identification System", "GEN# +1.00170261"},
        {"Smithsonian Astrophysical Observation", "SAO 66987"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.73507780),
        dec: Angle.Degrees(+36.07458006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75846"},
        {"Smithsonian Astrophysical Observation", "SAO 64726"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.39053125),
        dec: Angle.Degrees(+36.07726958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44369"},
        {"Hipparcos Number", "HIP 30359"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.78204904),
        dec: Angle.Degrees(+36.08108595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65392"},
        {"Hipparcos Number", "HIP 39094"},
        {"Smithsonian Astrophysical Observation", "SAO 60505"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.96413674),
        dec: Angle.Degrees(+36.08209513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30239"},
        {"Smithsonian Astrophysical Observation", "SAO 59008"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.42513499),
        dec: Angle.Degrees(+36.08252025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115928"},
        {"Hipparcos Number", "HIP 65019"},
        {"Geneva Identification System", "GEN# +1.00115928"},
        {"Smithsonian Astrophysical Observation", "SAO 63474"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.92790251),
        dec: Angle.Degrees(+36.08284810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22004"},
        {"Hipparcos Number", "HIP 16640"},
        {"Geneva Identification System", "GEN# +1.00022004"},
        {"Smithsonian Astrophysical Observation", "SAO 56547"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.53100891),
        dec: Angle.Degrees(+36.08499391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65990"},
        {"Hipparcos Number", "HIP 39366"},
        {"Smithsonian Astrophysical Observation", "SAO 60527"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.71440108),
        dec: Angle.Degrees(+36.08569476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161958"},
        {"Hipparcos Number", "HIP 87024"},
        {"Fundamental Katalog 5th Edition", "FK5 3414"},
        {"Geneva Identification System", "GEN# +1.00161958"},
        {"Smithsonian Astrophysical Observation", "SAO 66326"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.72160060),
        dec: Angle.Degrees(+36.08754383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97232",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12893 B"},
        {"Henry Draper", "HD 186902"},
        {"Hipparcos Number", "HIP 97232"},
        {"Geneva Identification System", "GEN# +1.00186901B"},
        {"Geneva Identification System 2", "GEN# +1.00186902"},
        {"Smithsonian Astrophysical Observation", "SAO 68806"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.41942736),
        dec: Angle.Degrees(+36.08864502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59444",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8451 A"},
        {"Henry Draper", "HD 105945"},
        {"Hipparcos Number", "HIP 59444"},
        {"Geneva Identification System", "GEN# +1.00105945"},
        {"Smithsonian Astrophysical Observation", "SAO 62887"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.89013320),
        dec: Angle.Degrees(+36.08935341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69924"},
        {"Smithsonian Astrophysical Observation", "SAO 64059"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.65038020),
        dec: Angle.Degrees(+36.08967971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219843"},
        {"Hipparcos Number", "HIP 115093"},
        {"Geneva Identification System", "GEN# +1.00219843"},
        {"Smithsonian Astrophysical Observation", "SAO 73162"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.67592501),
        dec: Angle.Degrees(+36.09019402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97228",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12893 A"},
        {"Henry Draper", "HD 186901"},
        {"Hipparcos Number", "HIP 97228"},
        {"Geneva Identification System", "GEN# +1.00186901A"},
        {"Renson", "Renson 51530"},
        {"Smithsonian Astrophysical Observation", "SAO 68805"},
        {"Wilson Evans Batten Catalogue", "WEB 17073"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.41521750),
        dec: Angle.Degrees(+36.09100655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95129"},
        {"Hipparcos Number", "HIP 53726"},
        {"Geneva Identification System", "GEN# +1.00095129"},
        {"Smithsonian Astrophysical Observation", "SAO 62345"},
        {"Wilson Evans Batten Catalogue", "WEB 9732"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.88641202),
        dec: Angle.Degrees(+36.09322401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15645 AB"},
        {"Henry Draper", "HD 210087"},
        {"Hipparcos Number", "HIP 109180"},
        {"Geneva Identification System", "GEN# +1.00210087J"},
        {"Smithsonian Astrophysical Observation", "SAO 72040"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.75913353),
        dec: Angle.Degrees(+36.09373060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7122"},
        {"Smithsonian Astrophysical Observation", "SAO 54757"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.94404139),
        dec: Angle.Degrees(+36.09389771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156757"},
        {"Hipparcos Number", "HIP 84615"},
        {"Geneva Identification System", "GEN# +1.00156757"},
        {"Smithsonian Astrophysical Observation", "SAO 65925"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.45363927),
        dec: Angle.Degrees(+36.09407004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67654"},
        {"Geneva Identification System", "GEN# +0.03602416"},
        {"Smithsonian Astrophysical Observation", "SAO 63791"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.92008047),
        dec: Angle.Degrees(+36.09631249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8451 B"},
        {"Hipparcos Number", "HIP 59445"},
        {"Geneva Identification System", "GEN# +0.03602245"},
        {"Smithsonian Astrophysical Observation", "SAO 62888"},
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.89353921),
        dec: Angle.Degrees(+36.09635248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93797"},
        {"Hipparcos Number", "HIP 52975"},
        {"Smithsonian Astrophysical Observation", "SAO 62275"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.53373877),
        dec: Angle.Degrees(+36.09810069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187795"},
        {"Hipparcos Number", "HIP 97609"},
        {"Geneva Identification System", "GEN# +1.00187795"},
        {"Smithsonian Astrophysical Observation", "SAO 68935"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.58248918),
        dec: Angle.Degrees(+36.09822312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178475"},
        {"Hipparcos Number", "HIP 93903"},
        {"Celescope Catalog", "CEL 4701"},
        {"Fundamental Katalog 5th Edition", "FK5 719"},
        {"Geneva Identification System", "GEN# +1.00178475"},
        {"Smithsonian Astrophysical Observation", "SAO 67834"},
        {"Wilson Evans Batten Catalogue", "WEB 16340"},
    },
    visualMagnitude: 5.25,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.82553958),
        dec: Angle.Degrees(+36.10016754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107746",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15356 AB"},
        {"Henry Draper", "HD 207649"},
        {"Hipparcos Number", "HIP 107746"},
        {"Smithsonian Astrophysical Observation", "SAO 71744"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.40009191),
        dec: Angle.Degrees(+36.10125046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220845"},
        {"Hipparcos Number", "HIP 115734"},
        {"Geneva Identification System", "GEN# +1.00220845"},
        {"Smithsonian Astrophysical Observation", "SAO 73257"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.70679044),
        dec: Angle.Degrees(+36.10376834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66865"},
        {"Smithsonian Astrophysical Observation", "SAO 63696"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56728533),
        dec: Angle.Degrees(+36.10597012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48272"},
        {"Hipparcos Number", "HIP 32268"},
        {"Geneva Identification System", "GEN# +1.00048272"},
        {"Smithsonian Astrophysical Observation", "SAO 59425"},
        {"Wilson Evans Batten Catalogue", "WEB 6503"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05216634),
        dec: Angle.Degrees(+36.10925853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28423"},
        {"Hipparcos Number", "HIP 21021"},
        {"Smithsonian Astrophysical Observation", "SAO 57264"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.61600712),
        dec: Angle.Degrees(+36.10927326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63999"},
        {"Smithsonian Astrophysical Observation", "SAO 63348"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.71950740),
        dec: Angle.Degrees(+36.11050884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12478"},
        {"Hipparcos Number", "HIP 9585"},
        {"Smithsonian Astrophysical Observation", "SAO 55221"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.79045533),
        dec: Angle.Degrees(+36.11080606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122637"},
        {"Hipparcos Number", "HIP 68576"},
        {"Fundamental Katalog 5th Edition", "FK5 5247"},
        {"Geneva Identification System", "GEN# +1.00122637"},
        {"Smithsonian Astrophysical Observation", "SAO 63903"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58516662),
        dec: Angle.Degrees(+36.11206655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162160"},
        {"Hipparcos Number", "HIP 87117"},
        {"Geneva Identification System", "GEN# +1.00162160"},
        {"Smithsonian Astrophysical Observation", "SAO 66342"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.99131776),
        dec: Angle.Degrees(+36.11686754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15512"},
        {"Hipparcos Number", "HIP 11690"},
        {"Smithsonian Astrophysical Observation", "SAO 55615"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.69720373),
        dec: Angle.Degrees(+36.11724743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18665"},
        {"Hipparcos Number", "HIP 14066"},
        {"Geneva Identification System", "GEN# +1.00018665"},
        {"Smithsonian Astrophysical Observation", "SAO 56092"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.31413079),
        dec: Angle.Degrees(+36.11791871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51460"},
        {"Smithsonian Astrophysical Observation", "SAO 62087"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.66284854),
        dec: Angle.Degrees(+36.11920306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280252"},
        {"Hipparcos Number", "HIP 22982"},
        {"Smithsonian Astrophysical Observation", "SAO 57515"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.18052204),
        dec: Angle.Degrees(+36.11985763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165171"},
        {"Hipparcos Number", "HIP 88407"},
        {"Geneva Identification System", "GEN# +1.00165171"},
        {"Smithsonian Astrophysical Observation", "SAO 66586"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77399954),
        dec: Angle.Degrees(+36.12087113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7173 AB"},
        {"Hipparcos Number", "HIP 44640"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.44392273),
        dec: Angle.Degrees(+36.12349272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61026"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.60876013),
        dec: Angle.Degrees(+36.12404313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36313"},
    },
    visualMagnitude: 10.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.12657173),
        dec: Angle.Degrees(+36.12519701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71276"},
        {"Hipparcos Number", "HIP 41502"},
        {"Smithsonian Astrophysical Observation", "SAO 60829"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.96777344),
        dec: Angle.Degrees(+36.12528562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92749"},
        {"Smithsonian Astrophysical Observation", "SAO 67545"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.50503009),
        dec: Angle.Degrees(+36.12637972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61430"},
        {"Geneva Identification System", "GEN# +4.36010007"},
        {"Smithsonian Astrophysical Observation", "SAO 63082"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.81835014),
        dec: Angle.Degrees(+36.12654669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208135"},
        {"Hipparcos Number", "HIP 108042"},
        {"Smithsonian Astrophysical Observation", "SAO 71801"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.33975040),
        dec: Angle.Degrees(+36.12670076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54896"},
        {"Hipparcos Number", "HIP 34806"},
        {"Smithsonian Astrophysical Observation", "SAO 59882"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.07728484),
        dec: Angle.Degrees(+36.12713459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78016"},
        {"Smithsonian Astrophysical Observation", "SAO 64973"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.95361474),
        dec: Angle.Degrees(+36.12736630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178352"},
        {"Hipparcos Number", "HIP 93851"},
        {"Smithsonian Astrophysical Observation", "SAO 67828"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.70268010),
        dec: Angle.Degrees(+36.12810292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61027"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.60974320),
        dec: Angle.Degrees(+36.12914709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199100"},
        {"Hipparcos Number", "HIP 103131"},
        {"Geneva Identification System", "GEN# +1.00199100"},
        {"Smithsonian Astrophysical Observation", "SAO 70640"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.42407671),
        dec: Angle.Degrees(+36.13024965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91070",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11471 AB"},
        {"Henry Draper", "HD 171678"},
        {"Hipparcos Number", "HIP 91070"},
        {"Smithsonian Astrophysical Observation", "SAO 67126"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.64466980),
        dec: Angle.Degrees(+36.13036617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39330"},
        {"Hipparcos Number", "HIP 27857"},
        {"Fundamental Katalog 5th Edition", "FK5 4535"},
        {"Geneva Identification System", "GEN# +1.00039330"},
        {"Smithsonian Astrophysical Observation", "SAO 58539"},
        {"Wilson Evans Batten Catalogue", "WEB 5454"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.40250018),
        dec: Angle.Degrees(+36.13051833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117416"},
        {"Smithsonian Astrophysical Observation", "SAO 73522"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.13127585),
        dec: Angle.Degrees(+36.13361945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208639"},
        {"Hipparcos Number", "HIP 108330"},
        {"Smithsonian Astrophysical Observation", "SAO 71867"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.21786930),
        dec: Angle.Degrees(+36.13433961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42419"},
        {"Hipparcos Number", "HIP 29445"},
        {"Smithsonian Astrophysical Observation", "SAO 58847"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.06336193),
        dec: Angle.Degrees(+36.13439740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278713"},
        {"Hipparcos Number", "HIP 16483"},
        {"Geneva Identification System", "GEN# +1.00278713"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.05999881),
        dec: Angle.Degrees(+36.13571344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159871"},
        {"Hipparcos Number", "HIP 86068"},
        {"Smithsonian Astrophysical Observation", "SAO 66162"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.85154043),
        dec: Angle.Degrees(+36.13630776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153990"},
        {"Hipparcos Number", "HIP 83279"},
        {"Smithsonian Astrophysical Observation", "SAO 65728"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.30048444),
        dec: Angle.Degrees(+36.13665061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19962"},
        {"Hipparcos Number", "HIP 15035"},
        {"Geneva Identification System", "GEN# +1.00019962"},
        {"Smithsonian Astrophysical Observation", "SAO 56270"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.43984363),
        dec: Angle.Degrees(+36.14013794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90196"},
        {"Smithsonian Astrophysical Observation", "SAO 66940"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.06682453),
        dec: Angle.Degrees(+36.14501644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4849 B"},
        {"Henry Draper", "HD 43017B"},
        {"Hipparcos Number", "HIP 29723"},
        {"Geneva Identification System", "GEN# +1.00043017B"},
        {"Smithsonian Astrophysical Observation", "SAO 58904"},
        {"Wilson Evans Batten Catalogue", "WEB 5861"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91042175),
        dec: Angle.Degrees(+36.14613588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208442"},
        {"Hipparcos Number", "HIP 108213"},
        {"Geneva Identification System", "GEN# +1.00208442"},
        {"Smithsonian Astrophysical Observation", "SAO 71841"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83857614),
        dec: Angle.Degrees(+36.14627020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15656"},
        {"Hipparcos Number", "HIP 11784"},
        {"Fundamental Katalog 5th Edition", "FK5 1070"},
        {"Geneva Identification System", "GEN# +1.00015656"},
        {"Smithsonian Astrophysical Observation", "SAO 55635"},
        {"Wilson Evans Batten Catalogue", "WEB 2443"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.02556633),
        dec: Angle.Degrees(+36.14723132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29725",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4849 A"},
        {"Henry Draper", "HD 43017"},
        {"Hipparcos Number", "HIP 29725"},
        {"Fundamental Katalog 5th Edition", "FK5 1167"},
        {"Geneva Identification System", "GEN# +1.00043017A"},
        {"Smithsonian Astrophysical Observation", "SAO 58905"},
        {"Wilson Evans Batten Catalogue", "WEB 5863"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.91273142),
        dec: Angle.Degrees(+36.14868102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45006"},
        {"Smithsonian Astrophysical Observation", "SAO 61299"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.50291992),
        dec: Angle.Degrees(+36.14903764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200755"},
        {"Hipparcos Number", "HIP 104009"},
        {"Smithsonian Astrophysical Observation", "SAO 70861"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.07988146),
        dec: Angle.Degrees(+36.14927151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37767"},
        {"Hipparcos Number", "HIP 26902"},
        {"Geneva Identification System", "GEN# +1.00037767"},
        {"Smithsonian Astrophysical Observation", "SAO 58354"},
        {"Wilson Evans Batten Catalogue", "WEB 5304"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.67282160),
        dec: Angle.Degrees(+36.14985228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26554"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.69609176),
        dec: Angle.Degrees(+36.15101580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89308"},
        {"Smithsonian Astrophysical Observation", "SAO 66770"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.34614059),
        dec: Angle.Degrees(+36.15263557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95996"},
        {"Cincinnati Publication", "Ci 20 1156"},
        {"Geneva Identification System", "GEN# +0.03503659"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.78849385),
        dec: Angle.Degrees(+36.15419658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -562.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26557"},
        {"Smithsonian Astrophysical Observation", "SAO 58282"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.70529988),
        dec: Angle.Degrees(+36.15451347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94468"},
        {"Hipparcos Number", "HIP 53374"},
        {"Smithsonian Astrophysical Observation", "SAO 62309"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.72130565),
        dec: Angle.Degrees(+36.15457087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211195"},
        {"Hipparcos Number", "HIP 109834"},
        {"Smithsonian Astrophysical Observation", "SAO 72170"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69357622),
        dec: Angle.Degrees(+36.15544652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58023"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.51351775),
        dec: Angle.Degrees(+36.15979666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216798"},
        {"Hipparcos Number", "HIP 113200"},
        {"Smithsonian Astrophysical Observation", "SAO 72844"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.86112435),
        dec: Angle.Degrees(+36.16099691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94342"},
        {"Smithsonian Astrophysical Observation", "SAO 67958"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.03490556),
        dec: Angle.Degrees(+36.16288637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220668"},
        {"Hipparcos Number", "HIP 115621"},
        {"Renson", "Renson 60500"},
        {"Smithsonian Astrophysical Observation", "SAO 73245"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.33560015),
        dec: Angle.Degrees(+36.16443650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11361 A"},
        {"Henry Draper", "HD 170228"},
        {"Hipparcos Number", "HIP 90399"},
        {"Smithsonian Astrophysical Observation", "SAO 66980"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.67247255),
        dec: Angle.Degrees(+36.16476188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180313"},
        {"Hipparcos Number", "HIP 94547"},
        {"Smithsonian Astrophysical Observation", "SAO 68026"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.65036491),
        dec: Angle.Degrees(+36.16558563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31327"},
        {"Hipparcos Number", "HIP 22955"},
        {"Geneva Identification System", "GEN# +1.00031327"},
        {"Smithsonian Astrophysical Observation", "SAO 57511"},
        {"Wilson Evans Batten Catalogue", "WEB 4456"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.08369522),
        dec: Angle.Degrees(+36.16854650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2676"},
        {"Hipparcos Number", "HIP 2400"},
        {"Geneva Identification System", "GEN# +1.00002676"},
        {"Smithsonian Astrophysical Observation", "SAO 53946"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.64554250),
        dec: Angle.Degrees(+36.16907827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63793"},
        {"Hipparcos Number", "HIP 38409"},
        {"Smithsonian Astrophysical Observation", "SAO 60396"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.03526073),
        dec: Angle.Degrees(+36.16926382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 916"},
        {"Hipparcos Number", "HIP 1089"},
        {"Geneva Identification System", "GEN# +1.00000916"},
        {"Smithsonian Astrophysical Observation", "SAO 53736"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.40091424),
        dec: Angle.Degrees(+36.17092831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191765"},
        {"Hipparcos Number", "HIP 99377"},
        {"Celescope Catalog", "CEL 4955"},
        {"Geneva Identification System", "GEN# +1.00191765"},
        {"Smithsonian Astrophysical Observation", "SAO 69541"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.55915172),
        dec: Angle.Degrees(+36.17642881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204772"},
        {"Hipparcos Number", "HIP 106133"},
        {"Smithsonian Astrophysical Observation", "SAO 71396"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.47196620),
        dec: Angle.Degrees(+36.17816859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77745"},
        {"Hipparcos Number", "HIP 44620"},
        {"Geneva Identification System", "GEN# +1.00077745"},
        {"Renson", "Renson 22010"},
        {"Smithsonian Astrophysical Observation", "SAO 61245"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.38924625),
        dec: Angle.Degrees(+36.18044725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29901"},
        {"Hipparcos Number", "HIP 22035"},
        {"Smithsonian Astrophysical Observation", "SAO 57395"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.05714184),
        dec: Angle.Degrees(+36.18123749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179782"},
        {"Hipparcos Number", "HIP 94366"},
        {"Celescope Catalog", "CEL 4721"},
        {"Geneva Identification System", "GEN# +1.00179782"},
        {"Smithsonian Astrophysical Observation", "SAO 67969"},
        {"Wilson Evans Batten Catalogue", "WEB 16440"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.10149196),
        dec: Angle.Degrees(+36.18220482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27503",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4406 AB"},
        {"Henry Draper", "HD 38707"},
        {"Hipparcos Number", "HIP 27503"},
        {"Smithsonian Astrophysical Observation", "SAO 58476"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.35638787),
        dec: Angle.Degrees(+36.18254120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279351"},
        {"Hipparcos Number", "HIP 18967"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.96655027),
        dec: Angle.Degrees(+36.18348102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73727"},
        {"Hipparcos Number", "HIP 42616"},
        {"Geneva Identification System", "GEN# +1.00073727"},
        {"Smithsonian Astrophysical Observation", "SAO 60980"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.27784132),
        dec: Angle.Degrees(+36.18537190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182990"},
        {"Hipparcos Number", "HIP 95537"},
        {"Fundamental Katalog 5th Edition", "FK5 5708"},
        {"Geneva Identification System", "GEN# +1.00182990"},
        {"Smithsonian Astrophysical Observation", "SAO 68296"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.49306370),
        dec: Angle.Degrees(+36.18650834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32862"},
        {"Smithsonian Astrophysical Observation", "SAO 59543"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.73625597),
        dec: Angle.Degrees(+36.18755542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8226"},
        {"Smithsonian Astrophysical Observation", "SAO 54958"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.48397809),
        dec: Angle.Degrees(+36.18842640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163621"},
        {"Hipparcos Number", "HIP 87746"},
        {"Geneva Identification System", "GEN# +1.00163621"},
        {"Smithsonian Astrophysical Observation", "SAO 66472"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.85324358),
        dec: Angle.Degrees(+36.18891938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7314",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1224"},
        {"Henry Draper", "HD 9532"},
        {"Hipparcos Number", "HIP 7314"},
        {"Smithsonian Astrophysical Observation", "SAO 54786"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.54794730),
        dec: Angle.Degrees(+36.19016162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228063"},
        {"Hipparcos Number", "HIP 99372"},
        {"Geneva Identification System", "GEN# +1.00228063"},
        {"Smithsonian Astrophysical Observation", "SAO 69539"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.54859655),
        dec: Angle.Degrees(+36.19133613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76218"},
        {"Hipparcos Number", "HIP 43852"},
        {"Geneva Identification System", "GEN# +1.00076218"},
        {"Smithsonian Astrophysical Observation", "SAO 61138"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.98208889),
        dec: Angle.Degrees(+36.19621953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127065"},
        {"Hipparcos Number", "HIP 70762"},
        {"Fundamental Katalog 5th Edition", "FK5 3144"},
        {"Geneva Identification System", "GEN# +1.00127065"},
        {"Smithsonian Astrophysical Observation", "SAO 64161"},
        {"Wilson Evans Batten Catalogue", "WEB 12259"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.06856594),
        dec: Angle.Degrees(+36.19701883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34425"},
        {"Hipparcos Number", "HIP 24795"},
        {"Celescope Catalog", "CEL 601"},
        {"Geneva Identification System", "GEN# +1.00034425"},
        {"Smithsonian Astrophysical Observation", "SAO 57878"},
        {"Wilson Evans Batten Catalogue", "WEB 4794"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.73717279),
        dec: Angle.Degrees(+36.19726187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192103"},
        {"Hipparcos Number", "HIP 99525"},
        {"Celescope Catalog", "CEL 4968"},
        {"Geneva Identification System", "GEN# +1.00192103"},
        {"Smithsonian Astrophysical Observation", "SAO 69584"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.97303898),
        dec: Angle.Degrees(+36.19738315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188365"},
        {"Hipparcos Number", "HIP 97878"},
        {"Geneva Identification System", "GEN# +1.00188365"},
        {"Smithsonian Astrophysical Observation", "SAO 69034"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.34665255),
        dec: Angle.Degrees(+36.19774006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46664"},
        {"Smithsonian Astrophysical Observation", "SAO 61532"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.71592316),
        dec: Angle.Degrees(+36.19800953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34875"},
        {"Hipparcos Number", "HIP 25084"},
        {"Smithsonian Astrophysical Observation", "SAO 57946"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.54974367),
        dec: Angle.Degrees(+36.19938307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35202"},
        {"Hipparcos Number", "HIP 25301"},
        {"Smithsonian Astrophysical Observation", "SAO 57985"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.18667054),
        dec: Angle.Degrees(+36.19996736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37737"},
        {"Hipparcos Number", "HIP 26889"},
        {"Geneva Identification System", "GEN# +1.00037737"},
        {"Smithsonian Astrophysical Observation", "SAO 58352"},
        {"Wilson Evans Batten Catalogue", "WEB 5300"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.62982554),
        dec: Angle.Degrees(+36.20014829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150679"},
        {"Hipparcos Number", "HIP 81673"},
        {"Fundamental Katalog 5th Edition", "FK5 5475"},
        {"Geneva Identification System", "GEN# +1.00150679"},
        {"Smithsonian Astrophysical Observation", "SAO 65481"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.26900302),
        dec: Angle.Degrees(+36.20124530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50488"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.64085319),
        dec: Angle.Degrees(+36.20148828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45235"},
        {"Hipparcos Number", "HIP 30777"},
        {"Geneva Identification System", "GEN# +1.00045235"},
        {"Smithsonian Astrophysical Observation", "SAO 59104"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.99808604),
        dec: Angle.Degrees(+36.20241656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221766"},
        {"Hipparcos Number", "HIP 116362"},
        {"Smithsonian Astrophysical Observation", "SAO 73349"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.68424735),
        dec: Angle.Degrees(+36.20414348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4564"},
        {"Hipparcos Number", "HIP 3739"},
        {"Geneva Identification System", "GEN# +1.00004564"},
        {"Smithsonian Astrophysical Observation", "SAO 54152"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.00223557),
        dec: Angle.Degrees(+36.20446390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90206"},
        {"Hipparcos Number", "HIP 51029"},
        {"Smithsonian Astrophysical Observation", "SAO 62031"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.37744543),
        dec: Angle.Degrees(+36.20460741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57248"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.08220766),
        dec: Angle.Degrees(+36.20705012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9285 AB"},
        {"Henry Draper", "HD 127303"},
        {"Hipparcos Number", "HIP 70869"},
        {"Smithsonian Astrophysical Observation", "SAO 64174"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.38647069),
        dec: Angle.Degrees(+36.20721341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139194"},
        {"Hipparcos Number", "HIP 76330"},
        {"Smithsonian Astrophysical Observation", "SAO 64794"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.87530737),
        dec: Angle.Degrees(+36.20984343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225457"},
        {"Hipparcos Number", "HIP 96949"},
        {"Smithsonian Astrophysical Observation", "SAO 68729"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.62818504),
        dec: Angle.Degrees(+36.21457544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71565"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.54697341),
        dec: Angle.Degrees(+36.21574817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100946"},
        {"Hipparcos Number", "HIP 56671"},
        {"Geneva Identification System", "GEN# +1.00100946"},
        {"Smithsonian Astrophysical Observation", "SAO 62624"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.30595387),
        dec: Angle.Degrees(+36.21603314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1715"},
        {"Hipparcos Number", "HIP 1721"},
        {"Geneva Identification System", "GEN# +1.00001715"},
        {"Smithsonian Astrophysical Observation", "SAO 53838"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.40682224),
        dec: Angle.Degrees(+36.21736890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63848"},
        {"Smithsonian Astrophysical Observation", "SAO 63334"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.27517005),
        dec: Angle.Degrees(+36.21764200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36626"},
        {"Cincinnati Publication", "Ci 20 426"},
        {"Geneva Identification System", "GEN# +0.03601638A"},
        {"Smithsonian Astrophysical Observation", "SAO 60150"},
        {"Wilson Evans Batten Catalogue", "WEB 7283"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.99117733),
        dec: Angle.Degrees(+36.21991515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30779"},
        {"Hipparcos Number", "HIP 22630"},
        {"Smithsonian Astrophysical Observation", "SAO 57465"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.03829356),
        dec: Angle.Degrees(+36.22034854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122517"},
        {"Hipparcos Number", "HIP 68513"},
        {"Geneva Identification System", "GEN# +1.00122517"},
        {"Smithsonian Astrophysical Observation", "SAO 63894"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.39352832),
        dec: Angle.Degrees(+36.22432655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186257"},
        {"Hipparcos Number", "HIP 96906"},
        {"Geneva Identification System", "GEN# +1.00186257"},
        {"Smithsonian Astrophysical Observation", "SAO 68713"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.48846918),
        dec: Angle.Degrees(+36.22571935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191046"},
        {"Hipparcos Number", "HIP 99041"},
        {"Geneva Identification System", "GEN# +1.00191046"},
        {"Smithsonian Astrophysical Observation", "SAO 69416"},
        {"Wilson Evans Batten Catalogue", "WEB 17608"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.62093361),
        dec: Angle.Degrees(+36.22688626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90345"},
        {"Hipparcos Number", "HIP 51106"},
        {"Smithsonian Astrophysical Observation", "SAO 62043"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.61845653),
        dec: Angle.Degrees(+36.22768892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95953",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12545 A"},
        {"Henry Draper", "HD 183986"},
        {"Hipparcos Number", "HIP 95953"},
        {"Celescope Catalog", "CEL 4778"},
        {"Geneva Identification System", "GEN# +1.00183986"},
        {"Smithsonian Astrophysical Observation", "SAO 68417"},
        {"Wilson Evans Batten Catalogue", "WEB 16807"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.69512816),
        dec: Angle.Degrees(+36.22853276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36627"},
        {"Wilson Evans Batten Catalogue", "WEB 7284"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.98964545),
        dec: Angle.Degrees(+36.23045504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -258.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100066"},
        {"Hipparcos Number", "HIP 56197"},
        {"Geneva Identification System", "GEN# +1.00100066"},
        {"Smithsonian Astrophysical Observation", "SAO 62585"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.79883793),
        dec: Angle.Degrees(+36.23168772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28647"},
        {"Hipparcos Number", "HIP 21188"},
        {"Smithsonian Astrophysical Observation", "SAO 57290"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.13154867),
        dec: Angle.Degrees(+36.23721654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70279"},
        {"Smithsonian Astrophysical Observation", "SAO 64107"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.68880016),
        dec: Angle.Degrees(+36.24200410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67086"},
        {"Hipparcos Number", "HIP 39784"},
        {"Smithsonian Astrophysical Observation", "SAO 60582"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.95183845),
        dec: Angle.Degrees(+36.24378408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48546"},
        {"Smithsonian Astrophysical Observation", "SAO 61743"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52069298),
        dec: Angle.Degrees(+36.24380951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109465"},
        {"Smithsonian Astrophysical Observation", "SAO 72093"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.63616842),
        dec: Angle.Degrees(+36.24402459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42864"},
        {"Cincinnati Publication", "Ci 20 486"},
        {"Geneva Identification System", "GEN# +9.80115022"},
        {"Wilson Evans Batten Catalogue", "WEB 8283"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.02095072),
        dec: Angle.Degrees(+36.24661826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -458.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76563",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9731 AB"},
        {"Henry Draper", "HD 139691"},
        {"Hipparcos Number", "HIP 76563"},
        {"Smithsonian Astrophysical Observation", "SAO 64821"},
        {"Wilson Evans Batten Catalogue", "WEB 12995"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.55398295),
        dec: Angle.Degrees(+36.24674611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76566",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9731 CD"},
        {"Hipparcos Number", "HIP 76566"},
        {"Wilson Evans Batten Catalogue", "WEB 12996"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.55914245),
        dec: Angle.Degrees(+36.24704829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36835"},
        {"Hipparcos Number", "HIP 26307"},
        {"Smithsonian Astrophysical Observation", "SAO 58224"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.04030185),
        dec: Angle.Degrees(+36.24724133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56274",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8198 AB"},
        {"Henry Draper", "HD 100235"},
        {"Hipparcos Number", "HIP 56274"},
        {"Geneva Identification System", "GEN# +1.00100235J"},
        {"Smithsonian Astrophysical Observation", "SAO 62590"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.05223683),
        dec: Angle.Degrees(+36.24732814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141678"},
        {"Hipparcos Number", "HIP 77460"},
        {"Wilson Evans Batten Catalogue", "WEB 13118"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.22302898),
        dec: Angle.Degrees(+36.24795060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39526"},
        {"Hipparcos Number", "HIP 27954"},
        {"Smithsonian Astrophysical Observation", "SAO 58566"},
        {"Wilson Evans Batten Catalogue", "WEB 5477"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71732970),
        dec: Angle.Degrees(+36.24855853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103644"},
        {"Hipparcos Number", "HIP 58202"},
        {"Geneva Identification System", "GEN# +1.00103644"},
        {"Smithsonian Astrophysical Observation", "SAO 62762"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.05122982),
        dec: Angle.Degrees(+36.24863341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170970"},
        {"Hipparcos Number", "HIP 90723"},
        {"Smithsonian Astrophysical Observation", "SAO 67045"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.64407163),
        dec: Angle.Degrees(+36.24917176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126267"},
        {"Hipparcos Number", "HIP 70341"},
        {"Geneva Identification System", "GEN# +1.00126267"},
        {"Smithsonian Astrophysical Observation", "SAO 64116"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.86807917),
        dec: Angle.Degrees(+36.25010889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189066"},
        {"Hipparcos Number", "HIP 98143"},
        {"Celescope Catalog", "CEL 4884"},
        {"Geneva Identification System", "GEN# +1.00189066"},
        {"Smithsonian Astrophysical Observation", "SAO 69129"},
        {"Wilson Evans Batten Catalogue", "WEB 17299"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.18392884),
        dec: Angle.Degrees(+36.25059928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88352"},
        {"Hipparcos Number", "HIP 49959"},
        {"Smithsonian Astrophysical Observation", "SAO 61923"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.99991125),
        dec: Angle.Degrees(+36.25127420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11991"},
        {"Hipparcos Number", "HIP 9217"},
        {"Geneva Identification System", "GEN# +1.00011991"},
        {"Smithsonian Astrophysical Observation", "SAO 55156"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.62883826),
        dec: Angle.Degrees(+36.25152879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1714"},
        {"Hipparcos Number", "HIP 1722"},
        {"Geneva Identification System", "GEN# +1.00001714"},
        {"Renson", "Renson 370"},
        {"Smithsonian Astrophysical Observation", "SAO 53839"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.41031708),
        dec: Angle.Degrees(+36.25298789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204413"},
        {"Hipparcos Number", "HIP 105951"},
        {"Smithsonian Astrophysical Observation", "SAO 71362"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.86658989),
        dec: Angle.Degrees(+36.25377938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193344"},
        {"Hipparcos Number", "HIP 100104"},
        {"Geneva Identification System", "GEN# +1.00193344"},
        {"Renson", "Renson 53970"},
        {"Smithsonian Astrophysical Observation", "SAO 69799"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61485014),
        dec: Angle.Degrees(+36.25438441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278842"},
        {"Hipparcos Number", "HIP 16987"},
        {"Geneva Identification System", "GEN# +1.00278842"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.61684506),
        dec: Angle.Degrees(+36.25449094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117197"},
        {"Geneva Identification System", "GEN# +6.10010906"},
        {"Geneva Identification System 2", "GEN# +9.80130009"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.45521053),
        dec: Angle.Degrees(+36.25493379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 347.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59539"},
        {"Geneva Identification System", "GEN# +0.03702255"},
        {"Smithsonian Astrophysical Observation", "SAO 62893"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.13614605),
        dec: Angle.Degrees(+36.25600969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210667"},
        {"Hipparcos Number", "HIP 109527"},
        {"Cincinnati Publication", "Ci 18 2890"},
        {"Geneva Identification System", "GEN# +1.00210667"},
        {"Smithsonian Astrophysical Observation", "SAO 72103"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.79956227),
        dec: Angle.Degrees(+36.25693789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81954"},
        {"Geneva Identification System", "GEN# +0.03602775"},
        {"Smithsonian Astrophysical Observation", "SAO 65517"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.13384087),
        dec: Angle.Degrees(+36.25700909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80185"},
        {"Smithsonian Astrophysical Observation", "SAO 65256"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.55757247),
        dec: Angle.Degrees(+36.25760099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109648"},
        {"Hipparcos Number", "HIP 61497"},
        {"Geneva Identification System", "GEN# +4.36010004"},
        {"Smithsonian Astrophysical Observation", "SAO 63094"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.99968932),
        dec: Angle.Degrees(+36.25790988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40968",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6756 AB"},
        {"Hipparcos Number", "HIP 40968"},
        {"Smithsonian Astrophysical Observation", "SAO 60758"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.40946712),
        dec: Angle.Degrees(+36.25821284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64012"},
        {"Smithsonian Astrophysical Observation", "SAO 63350"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.74686822),
        dec: Angle.Degrees(+36.26351088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214929"},
        {"Hipparcos Number", "HIP 111990"},
        {"Smithsonian Astrophysical Observation", "SAO 72617"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.26607747),
        dec: Angle.Degrees(+36.26354524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80893"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.77859847),
        dec: Angle.Degrees(+36.26662673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17147"},
        {"Hipparcos Number", "HIP 12919"},
        {"Geneva Identification System", "GEN# +1.00017147"},
        {"Smithsonian Astrophysical Observation", "SAO 55857"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.52843517),
        dec: Angle.Degrees(+36.26702296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7191"},
        {"Hipparcos Number", "HIP 5660"},
        {"Smithsonian Astrophysical Observation", "SAO 54512"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.18009885),
        dec: Angle.Degrees(+36.26876803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63814"},
        {"Hipparcos Number", "HIP 38422"},
        {"Geneva Identification System", "GEN# +1.00063814"},
        {"Smithsonian Astrophysical Observation", "SAO 60398"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.06471933),
        dec: Angle.Degrees(+36.26998807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66682"},
        {"Hipparcos Number", "HIP 39638"},
        {"Geneva Identification System", "GEN# +1.00066682"},
        {"Smithsonian Astrophysical Observation", "SAO 60556"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.50859059),
        dec: Angle.Degrees(+36.27253992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90931"},
        {"Hipparcos Number", "HIP 51457"},
        {"Geneva Identification System", "GEN# +1.00090931"},
        {"Renson", "Renson 26120"},
        {"Smithsonian Astrophysical Observation", "SAO 62084"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.65030919),
        dec: Angle.Degrees(+36.27363387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17019 AB"},
        {"Henry Draper", "HD 223331"},
        {"Hipparcos Number", "HIP 117426"},
        {"Smithsonian Astrophysical Observation", "SAO 73523"},
        {"Wilson Evans Batten Catalogue", "WEB 20679"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.14745528),
        dec: Angle.Degrees(+36.27455815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29024",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4691 AB"},
        {"Aitken 2", "ADS 4691 A"},
        {"Henry Draper", "HD 41523"},
        {"Hipparcos Number", "HIP 29024"},
        {"Smithsonian Astrophysical Observation", "SAO 58762"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.85767340),
        dec: Angle.Degrees(+36.27464265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107194"},
        {"Smithsonian Astrophysical Observation", "SAO 71631"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.68442544),
        dec: Angle.Degrees(+36.28287872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68614"},
        {"Geneva Identification System", "GEN# +0.03602437"},
        {"Smithsonian Astrophysical Observation", "SAO 63908"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.69539162),
        dec: Angle.Degrees(+36.28368787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183752"},
        {"Hipparcos Number", "HIP 95833"},
        {"Geneva Identification System", "GEN# +1.00183752"},
        {"Smithsonian Astrophysical Observation", "SAO 68394"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.37522952),
        dec: Angle.Degrees(+36.28724911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164280"},
        {"Hipparcos Number", "HIP 88020"},
        {"Geneva Identification System", "GEN# +1.00164280"},
        {"Smithsonian Astrophysical Observation", "SAO 66531"},
        {"Wilson Evans Batten Catalogue", "WEB 14866"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.67632168),
        dec: Angle.Degrees(+36.28791591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102208"},
        {"Hipparcos Number", "HIP 57384"},
        {"Geneva Identification System", "GEN# +1.00102208"},
        {"Smithsonian Astrophysical Observation", "SAO 62694"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.47509678),
        dec: Angle.Degrees(+36.29055660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66458",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8974 AB"},
        {"Henry Draper", "HD 118623"},
        {"Hipparcos Number", "HIP 66458"},
        {"Geneva Identification System", "GEN# +1.00118623J"},
        {"Smithsonian Astrophysical Observation", "SAO 63648"},
        {"Wilson Evans Batten Catalogue", "WEB 11732"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.36540378),
        dec: Angle.Degrees(+36.29484073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17594"},
        {"Hipparcos Number", "HIP 13252"},
        {"Smithsonian Astrophysical Observation", "SAO 55929"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.63979818),
        dec: Angle.Degrees(+36.29690530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114811"},
        {"Smithsonian Astrophysical Observation", "SAO 73115"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.85001515),
        dec: Angle.Degrees(+36.29765992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185267"},
        {"Hipparcos Number", "HIP 96477"},
        {"Smithsonian Astrophysical Observation", "SAO 68581"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.21031926),
        dec: Angle.Degrees(+36.29850163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14724 A"},
        {"Henry Draper", "HD 201819"},
        {"Hipparcos Number", "HIP 104579"},
        {"Celescope Catalog", "CEL 5261"},
        {"Geneva Identification System", "GEN# +1.00201819"},
        {"Smithsonian Astrophysical Observation", "SAO 71032"},
        {"Wilson Evans Batten Catalogue", "WEB 19032"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.76569536),
        dec: Angle.Degrees(+36.29957934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64880"},
        {"Wilson Evans Batten Catalogue", "WEB 11469"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.49353344),
        dec: Angle.Degrees(+36.29995254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -336.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85374"},
        {"Hipparcos Number", "HIP 48421"},
        {"Geneva Identification System", "GEN# +1.00085374"},
        {"Smithsonian Astrophysical Observation", "SAO 61724"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.06809192),
        dec: Angle.Degrees(+36.30054923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218418"},
        {"Hipparcos Number", "HIP 114192"},
        {"Smithsonian Astrophysical Observation", "SAO 73013"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.87753734),
        dec: Angle.Degrees(+36.30173980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169244"},
        {"Hipparcos Number", "HIP 90024"},
        {"Geneva Identification System", "GEN# +1.00169244"},
        {"Smithsonian Astrophysical Observation", "SAO 66911"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.53693589),
        dec: Angle.Degrees(+36.30187555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16"},
        {"Hipparcos Number", "HIP 431"},
        {"Geneva Identification System", "GEN# +1.00000016"},
        {"Smithsonian Astrophysical Observation", "SAO 53629"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.30198518),
        dec: Angle.Degrees(+36.30368114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9917"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.91168690),
        dec: Angle.Degrees(+36.30476660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211983"},
        {"Hipparcos Number", "HIP 110290"},
        {"Geneva Identification System", "GEN# +1.00211983"},
        {"Smithsonian Astrophysical Observation", "SAO 72245"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.09744832),
        dec: Angle.Degrees(+36.30665751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7624"},
        {"Hipparcos Number", "HIP 5966"},
        {"Geneva Identification System", "GEN# +1.00007624"},
        {"Smithsonian Astrophysical Observation", "SAO 54574"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.17787410),
        dec: Angle.Degrees(+36.30802209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77514"},
        {"Hipparcos Number", "HIP 44519"},
        {"Smithsonian Astrophysical Observation", "SAO 61232"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.06258200),
        dec: Angle.Degrees(+36.30826290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96813"},
        {"Hipparcos Number", "HIP 54522"},
        {"Fundamental Katalog 5th Edition", "FK5 2892"},
        {"Geneva Identification System", "GEN# +1.00096813"},
        {"Smithsonian Astrophysical Observation", "SAO 62427"},
        {"Wilson Evans Batten Catalogue", "WEB 9840"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.32963314),
        dec: Angle.Degrees(+36.30943441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17672"},
        {"Hipparcos Number", "HIP 13311"},
        {"Geneva Identification System", "GEN# +1.00017672"},
        {"Smithsonian Astrophysical Observation", "SAO 55943"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.82778829),
        dec: Angle.Degrees(+36.31057588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203285"},
        {"Hipparcos Number", "HIP 105346"},
        {"Smithsonian Astrophysical Observation", "SAO 71217"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.06238925),
        dec: Angle.Degrees(+36.31073089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57769"},
        {"Hipparcos Number", "HIP 35919"},
        {"Geneva Identification System", "GEN# +1.00057769"},
        {"Smithsonian Astrophysical Observation", "SAO 60049"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.07155788),
        dec: Angle.Degrees(+36.31100292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117347"},
        {"Hipparcos Number", "HIP 65778"},
        {"Geneva Identification System", "GEN# +1.00117347"},
        {"Smithsonian Astrophysical Observation", "SAO 63562"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.27355464),
        dec: Angle.Degrees(+36.31124174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29743"},
        {"Hipparcos Number", "HIP 21907"},
        {"Smithsonian Astrophysical Observation", "SAO 57384"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.65670975),
        dec: Angle.Degrees(+36.31157564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78275"},
        {"Hipparcos Number", "HIP 44866"},
        {"Geneva Identification System", "GEN# +1.00078275"},
        {"Smithsonian Astrophysical Observation", "SAO 61280"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.12062447),
        dec: Angle.Degrees(+36.31192214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30186",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4955 AB"},
        {"Henry Draper", "HD 44005"},
        {"Hipparcos Number", "HIP 30186"},
        {"Smithsonian Astrophysical Observation", "SAO 59000"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.26312306),
        dec: Angle.Degrees(+36.31319613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52737"},
        {"Hipparcos Number", "HIP 34083"},
        {"Geneva Identification System", "GEN# +1.00052737"},
        {"Smithsonian Astrophysical Observation", "SAO 59738"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.01468569),
        dec: Angle.Degrees(+36.31353629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70517"},
        {"Hipparcos Number", "HIP 41149"},
        {"Smithsonian Astrophysical Observation", "SAO 60778"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.94108432),
        dec: Angle.Degrees(+36.31420216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81655"},
    },
    visualMagnitude: 11.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.20414758),
        dec: Angle.Degrees(+36.31626548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183056"},
        {"Hipparcos Number", "HIP 95556"},
        {"Celescope Catalog", "CEL 4751"},
        {"Fundamental Katalog 5th Edition", "FK5 3554"},
        {"Geneva Identification System", "GEN# +1.00183056"},
        {"Renson", "Renson 50610"},
        {"Smithsonian Astrophysical Observation", "SAO 68301"},
        {"Wilson Evans Batten Catalogue", "WEB 16709"},
    },
    visualMagnitude: 5.17,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.53801621),
        dec: Angle.Degrees(+36.31786478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109462"},
        {"Hipparcos Number", "HIP 61383"},
        {"Geneva Identification System", "GEN# +4.36010005"},
        {"Smithsonian Astrophysical Observation", "SAO 63075"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.68158704),
        dec: Angle.Degrees(+36.31850361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24960"},
        {"Hipparcos Number", "HIP 18646"},
        {"Smithsonian Astrophysical Observation", "SAO 56862"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.86519135),
        dec: Angle.Degrees(+36.31850381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189016"},
        {"Hipparcos Number", "HIP 98126"},
        {"Geneva Identification System", "GEN# +1.00189016"},
        {"Smithsonian Astrophysical Observation", "SAO 69124"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.14742236),
        dec: Angle.Degrees(+36.31999131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36360"},
        {"Hipparcos Number", "HIP 25995"},
        {"Geneva Identification System", "GEN# +1.00036360"},
        {"Renson", "Renson 9380"},
        {"Smithsonian Astrophysical Observation", "SAO 58165"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.22192381),
        dec: Angle.Degrees(+36.32000302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67040"},
        {"Geneva Identification System", "GEN# +0.03702448"},
        {"Smithsonian Astrophysical Observation", "SAO 63715"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.08397586),
        dec: Angle.Degrees(+36.32083234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202711"},
        {"Hipparcos Number", "HIP 105047"},
        {"Renson", "Renson 56490"},
        {"Smithsonian Astrophysical Observation", "SAO 71150"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.16540784),
        dec: Angle.Degrees(+36.32124355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46769"},
        {"Cincinnati Publication", "Ci 20 532"},
        {"Smithsonian Astrophysical Observation", "SAO 61548"},
        {"Wilson Evans Batten Catalogue", "WEB 8824"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98535329),
        dec: Angle.Degrees(+36.32150319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -524.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91752"},
        {"Hipparcos Number", "HIP 51914"},
        {"Geneva Identification System", "GEN# +1.00091752"},
        {"Smithsonian Astrophysical Observation", "SAO 62147"},
        {"Wilson Evans Batten Catalogue", "WEB 9477"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.08914483),
        dec: Angle.Degrees(+36.32700891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171677"},
        {"Hipparcos Number", "HIP 91069"},
        {"Smithsonian Astrophysical Observation", "SAO 67127"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.64338943),
        dec: Angle.Degrees(+36.32745202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189315"},
        {"Hipparcos Number", "HIP 98262"},
        {"Geneva Identification System", "GEN# +1.00189315"},
        {"Smithsonian Astrophysical Observation", "SAO 69169"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.49702102),
        dec: Angle.Degrees(+36.32775759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192445"},
        {"Hipparcos Number", "HIP 99667"},
        {"Celescope Catalog", "CEL 4978"},
        {"Geneva Identification System", "GEN# +1.00192445"},
        {"Smithsonian Astrophysical Observation", "SAO 69639"},
        {"Wilson Evans Batten Catalogue", "WEB 17868"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.38745263),
        dec: Angle.Degrees(+36.32838751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215509"},
        {"Hipparcos Number", "HIP 112329"},
        {"Smithsonian Astrophysical Observation", "SAO 72685"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.27785979),
        dec: Angle.Degrees(+36.32852031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46929"},
        {"Smithsonian Astrophysical Observation", "SAO 61564"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.47358327),
        dec: Angle.Degrees(+36.32896449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222917"},
        {"Hipparcos Number", "HIP 117132"},
        {"Smithsonian Astrophysical Observation", "SAO 73473"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.19791550),
        dec: Angle.Degrees(+36.32920130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205213"},
        {"Hipparcos Number", "HIP 106381"},
        {"Smithsonian Astrophysical Observation", "SAO 71449"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.20024658),
        dec: Angle.Degrees(+36.32967244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60496"},
        {"Geneva Identification System", "GEN# +0.03702271"},
        {"Smithsonian Astrophysical Observation", "SAO 62982"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.03800260),
        dec: Angle.Degrees(+36.33014385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65182"},
    },
    visualMagnitude: 11.71,
    bvColour: -0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.37171295),
        dec: Angle.Degrees(+36.33452523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95618"},
        {"Hipparcos Number", "HIP 53986"},
        {"Geneva Identification System", "GEN# +1.00095618"},
        {"Smithsonian Astrophysical Observation", "SAO 62370"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.65956956),
        dec: Angle.Degrees(+36.33678476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109542"},
        {"Hipparcos Number", "HIP 61435"},
        {"Geneva Identification System", "GEN# +4.36010003"},
        {"Smithsonian Astrophysical Observation", "SAO 63084"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.82893594),
        dec: Angle.Degrees(+36.33839094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16376"},
        {"Hipparcos Number", "HIP 12321"},
        {"Geneva Identification System", "GEN# +1.00016376"},
        {"Smithsonian Astrophysical Observation", "SAO 55742"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.65834588),
        dec: Angle.Degrees(+36.33884465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222858"},
        {"Hipparcos Number", "HIP 117094"},
        {"Geneva Identification System", "GEN# +1.00222858"},
        {"Smithsonian Astrophysical Observation", "SAO 73470"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.06890190),
        dec: Angle.Degrees(+36.33886052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38849"},
        {"Smithsonian Astrophysical Observation", "SAO 60471"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.25225848),
        dec: Angle.Degrees(+36.33904721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44516"},
        {"Smithsonian Astrophysical Observation", "SAO 61231"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.05326786),
        dec: Angle.Degrees(+36.33962491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228854"},
        {"Hipparcos Number", "HIP 100135"},
        {"Smithsonian Astrophysical Observation", "SAO 69812"},
        {"Wilson Evans Batten Catalogue", "WEB 18037"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.69676035),
        dec: Angle.Degrees(+36.34059811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111366"},
        {"Hipparcos Number", "HIP 62504"},
        {"Geneva Identification System", "GEN# +1.00111366"},
        {"Smithsonian Astrophysical Observation", "SAO 63200"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.12330534),
        dec: Angle.Degrees(+36.34270535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8753"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.15079134),
        dec: Angle.Degrees(+36.34297885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25822"},
        {"Hipparcos Number", "HIP 19214"},
        {"Smithsonian Astrophysical Observation", "SAO 56976"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.77831293),
        dec: Angle.Degrees(+36.34335124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66175"},
        {"Hipparcos Number", "HIP 39433"},
        {"Smithsonian Astrophysical Observation", "SAO 60532"},
        {"Wilson Evans Batten Catalogue", "WEB 7715"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.91647078),
        dec: Angle.Degrees(+36.34490461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11430"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.86246222),
        dec: Angle.Degrees(+36.35006614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224921"},
        {"Hipparcos Number", "HIP 141"},
        {"Smithsonian Astrophysical Observation", "SAO 73695"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.45342986),
        dec: Angle.Degrees(+36.35034560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225438"},
        {"Hipparcos Number", "HIP 96924"},
        {"Smithsonian Astrophysical Observation", "SAO 68720"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.53483297),
        dec: Angle.Degrees(+36.35115302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104118"},
        {"Smithsonian Astrophysical Observation", "SAO 70893"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.40570890),
        dec: Angle.Degrees(+36.35126678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16376 A"},
        {"Henry Draper", "HD 216831"},
        {"Hipparcos Number", "HIP 113222"},
        {"Geneva Identification System", "GEN# +1.00216831A"},
        {"Renson", "Renson 59860"},
        {"Smithsonian Astrophysical Observation", "SAO 72851"},
        {"Wilson Evans Batten Catalogue", "WEB 20148"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.93538834),
        dec: Angle.Degrees(+36.35139364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104845"},
        {"Hipparcos Number", "HIP 58873"},
        {"Geneva Identification System", "GEN# +1.00104845"},
        {"Smithsonian Astrophysical Observation", "SAO 62823"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.11854769),
        dec: Angle.Degrees(+36.35406667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20317"},
        {"Hipparcos Number", "HIP 15295"},
        {"Smithsonian Astrophysical Observation", "SAO 56317"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.33846912),
        dec: Angle.Degrees(+36.35461009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223736"},
        {"Hipparcos Number", "HIP 117693"},
        {"Smithsonian Astrophysical Observation", "SAO 73568"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.03221065),
        dec: Angle.Degrees(+36.35593619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6683",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1136 AB"},
        {"Henry Draper", "HD 8622"},
        {"Hipparcos Number", "HIP 6683"},
        {"Smithsonian Astrophysical Observation", "SAO 54691"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.43000957),
        dec: Angle.Degrees(+36.35742056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29701"},
        {"Smithsonian Astrophysical Observation", "SAO 58899"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.85057006),
        dec: Angle.Degrees(+36.35790873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74802"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.31132517),
        dec: Angle.Degrees(+36.35928346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127505"},
        {"Hipparcos Number", "HIP 70951"},
        {"Smithsonian Astrophysical Observation", "SAO 64192"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.69205325),
        dec: Angle.Degrees(+36.35929661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156666"},
        {"Hipparcos Number", "HIP 84571"},
        {"Smithsonian Astrophysical Observation", "SAO 65916"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.32742432),
        dec: Angle.Degrees(+36.36091705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220598"},
        {"Hipparcos Number", "HIP 115579"},
        {"Geneva Identification System", "GEN# +1.00220598"},
        {"Smithsonian Astrophysical Observation", "SAO 73239"},
        {"Wilson Evans Batten Catalogue", "WEB 20458"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.18076711),
        dec: Angle.Degrees(+36.36217586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56140"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.60945235),
        dec: Angle.Degrees(+36.36438454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11069"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.62406174),
        dec: Angle.Degrees(+36.36630752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156163"},
        {"Hipparcos Number", "HIP 84329"},
        {"Smithsonian Astrophysical Observation", "SAO 65885"},
        {"Wilson Evans Batten Catalogue", "WEB 14237"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.60223387),
        dec: Angle.Degrees(+36.36792964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48804"},
        {"Hipparcos Number", "HIP 32496"},
        {"Smithsonian Astrophysical Observation", "SAO 59475"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.72570025),
        dec: Angle.Degrees(+36.36928732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89569"},
        {"Smithsonian Astrophysical Observation", "SAO 66819"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.15417154),
        dec: Angle.Degrees(+36.37087090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115927"},
        {"Hipparcos Number", "HIP 65028"},
        {"Geneva Identification System", "GEN# +1.00115927"},
        {"Smithsonian Astrophysical Observation", "SAO 63476"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.94708682),
        dec: Angle.Degrees(+36.37382886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28280"},
        {"Smithsonian Astrophysical Observation", "SAO 58620"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.63624426),
        dec: Angle.Degrees(+36.37426821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108408"},
        {"Hipparcos Number", "HIP 60758"},
        {"Geneva Identification System", "GEN# +1.00108408"},
        {"Renson", "Renson 31490"},
        {"Smithsonian Astrophysical Observation", "SAO 63007"},
        {"Wilson Evans Batten Catalogue", "WEB 10808"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.80073399),
        dec: Angle.Degrees(+36.37450321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199496"},
        {"Hipparcos Number", "HIP 103354"},
        {"Celescope Catalog", "CEL 5211"},
        {"Geneva Identification System", "GEN# +1.00199496"},
        {"Smithsonian Astrophysical Observation", "SAO 70691"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.09904533),
        dec: Angle.Degrees(+36.37739962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89418"},
        {"Geneva Identification System", "GEN# +0.03603064"},
        {"Smithsonian Astrophysical Observation", "SAO 66793"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.71396032),
        dec: Angle.Degrees(+36.37922345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22814"},
        {"Hipparcos Number", "HIP 17224"},
        {"Geneva Identification System", "GEN# +1.00022814"},
        {"Smithsonian Astrophysical Observation", "SAO 56630"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34398364),
        dec: Angle.Degrees(+36.37930358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72004"},
        {"Hipparcos Number", "HIP 41845"},
        {"Smithsonian Astrophysical Observation", "SAO 60874"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.98095388),
        dec: Angle.Degrees(+36.38027970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78489"},
        {"Hipparcos Number", "HIP 44987"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.45359975),
        dec: Angle.Degrees(+36.38041541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151086"},
        {"Hipparcos Number", "HIP 81894"},
        {"Geneva Identification System", "GEN# +1.00151086"},
        {"Smithsonian Astrophysical Observation", "SAO 65511"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.91590460),
        dec: Angle.Degrees(+36.38052221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197460"},
        {"Hipparcos Number", "HIP 102219"},
        {"Geneva Identification System", "GEN# +1.00197460"},
        {"Smithsonian Astrophysical Observation", "SAO 70410"},
        {"Wilson Evans Batten Catalogue", "WEB 18497"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.67121525),
        dec: Angle.Degrees(+36.38088258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206112"},
        {"Hipparcos Number", "HIP 106883"},
        {"Smithsonian Astrophysical Observation", "SAO 71558"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.73465309),
        dec: Angle.Degrees(+36.38143898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115444"},
        {"Hipparcos Number", "HIP 64786"},
        {"Geneva Identification System", "GEN# +1.00115444"},
        {"Smithsonian Astrophysical Observation", "SAO 63442"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.17689868),
        dec: Angle.Degrees(+36.38144955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55009"},
        {"Smithsonian Astrophysical Observation", "SAO 62468"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.94410198),
        dec: Angle.Degrees(+36.38195013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40616"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.38113715),
        dec: Angle.Degrees(+36.38353876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118288"},
        {"Hipparcos Number", "HIP 66303"},
        {"Geneva Identification System", "GEN# +1.00118288"},
        {"Smithsonian Astrophysical Observation", "SAO 63628"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.82649006),
        dec: Angle.Degrees(+36.38480526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209843"},
        {"Hipparcos Number", "HIP 109057"},
        {"Smithsonian Astrophysical Observation", "SAO 72016"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.39551717),
        dec: Angle.Degrees(+36.38492373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181723"},
        {"Hipparcos Number", "HIP 95030"},
        {"Smithsonian Astrophysical Observation", "SAO 68155"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.03185641),
        dec: Angle.Degrees(+36.38648145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279010"},
        {"Hipparcos Number", "HIP 17841"},
        {"Geneva Identification System", "GEN# +1.00279010"},
        {"Smithsonian Astrophysical Observation", "SAO 56720"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.26179631),
        dec: Angle.Degrees(+36.38727330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18568"},
        {"Hipparcos Number", "HIP 14010"},
        {"Geneva Identification System", "GEN# +1.00018568"},
        {"Smithsonian Astrophysical Observation", "SAO 56075"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.08920663),
        dec: Angle.Degrees(+36.38833846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125798"},
        {"Hipparcos Number", "HIP 70121"},
        {"Geneva Identification System", "GEN# +1.00125798"},
        {"Smithsonian Astrophysical Observation", "SAO 64085"},
        {"Wilson Evans Batten Catalogue", "WEB 12188"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.21148535),
        dec: Angle.Degrees(+36.39238930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104368"},
    },
    visualMagnitude: 11.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.15546181),
        dec: Angle.Degrees(+36.39391337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195544"},
        {"Hipparcos Number", "HIP 101197"},
        {"Geneva Identification System", "GEN# +1.00195544"},
        {"Smithsonian Astrophysical Observation", "SAO 70129"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.68720832),
        dec: Angle.Degrees(+36.39393994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88470"},
        {"Smithsonian Astrophysical Observation", "SAO 66600"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.97237674),
        dec: Angle.Degrees(+36.39492031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51616"},
        {"Smithsonian Astrophysical Observation", "SAO 62112"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.18102222),
        dec: Angle.Degrees(+36.39577983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72979"},
        {"Smithsonian Astrophysical Observation", "SAO 64398"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.71490414),
        dec: Angle.Degrees(+36.39584497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191139"},
        {"Hipparcos Number", "HIP 99088"},
        {"Celescope Catalog", "CEL 4934"},
        {"Geneva Identification System", "GEN# +1.00191139"},
        {"Smithsonian Astrophysical Observation", "SAO 69434"},
        {"Wilson Evans Batten Catalogue", "WEB 17624"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.74005455),
        dec: Angle.Degrees(+36.39659924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82635"},
        {"Hipparcos Number", "HIP 46952"},
        {"Fundamental Katalog 5th Edition", "FK5 360"},
        {"Geneva Identification System", "GEN# +1.00082635"},
        {"Smithsonian Astrophysical Observation", "SAO 61570"},
        {"Wilson Evans Batten Catalogue", "WEB 8851"},
    },
    visualMagnitude: 4.54,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.55573740),
        dec: Angle.Degrees(+36.39761338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14096"},
        {"Hipparcos Number", "HIP 10693"},
        {"Geneva Identification System", "GEN# +1.00014096"},
        {"Smithsonian Astrophysical Observation", "SAO 55432"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.41632824),
        dec: Angle.Degrees(+36.39841380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35089"},
        {"Hipparcos Number", "HIP 25238"},
        {"Geneva Identification System", "GEN# +1.00035089"},
        {"Smithsonian Astrophysical Observation", "SAO 57972"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96359158),
        dec: Angle.Degrees(+36.39843526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166229"},
        {"Hipparcos Number", "HIP 88836"},
        {"Geneva Identification System", "GEN# +1.00166229"},
        {"Smithsonian Astrophysical Observation", "SAO 66666"},
        {"Wilson Evans Batten Catalogue", "WEB 15057"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.00961362),
        dec: Angle.Degrees(+36.40171633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49472"},
        {"Hipparcos Number", "HIP 32798"},
        {"Smithsonian Astrophysical Observation", "SAO 59529"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.55888092),
        dec: Angle.Degrees(+36.40195729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87467"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.07568946),
        dec: Angle.Degrees(+36.40243349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117061"},
        {"Hipparcos Number", "HIP 65612"},
        {"Smithsonian Astrophysical Observation", "SAO 63543"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.79451545),
        dec: Angle.Degrees(+36.40623016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8057"},
        {"Hipparcos Number", "HIP 6279"},
        {"Smithsonian Astrophysical Observation", "SAO 54616"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.13912518),
        dec: Angle.Degrees(+36.40830108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7085"},
        {"Hipparcos Number", "HIP 5595"},
        {"Smithsonian Astrophysical Observation", "SAO 54500"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.93524364),
        dec: Angle.Degrees(+36.40919377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13240 A"},
        {"Henry Draper", "HD 189751"},
        {"Hipparcos Number", "HIP 98448"},
        {"Geneva Identification System", "GEN# +1.00189751"},
        {"Smithsonian Astrophysical Observation", "SAO 69238"},
        {"Wilson Evans Batten Catalogue", "WEB 17381"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.04762821),
        dec: Angle.Degrees(+36.41411772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78737"},
        {"Smithsonian Astrophysical Observation", "SAO 65059"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.10606155),
        dec: Angle.Degrees(+36.41536084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98446",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13240 B"},
        {"Hipparcos Number", "HIP 98446"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.04416012),
        dec: Angle.Degrees(+36.41538522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47716"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.91923024),
        dec: Angle.Degrees(+36.41650270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74178"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.34872342),
        dec: Angle.Degrees(+36.41778131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32089"},
        {"Smithsonian Astrophysical Observation", "SAO 59381"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.56246519),
        dec: Angle.Degrees(+36.41787459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40943"},
        {"Hipparcos Number", "HIP 28707"},
        {"Smithsonian Astrophysical Observation", "SAO 58698"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.94920721),
        dec: Angle.Degrees(+36.41812161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77207"},
        {"Smithsonian Astrophysical Observation", "SAO 64885"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46659345),
        dec: Angle.Degrees(+36.41835174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72524"},
        {"Hipparcos Number", "HIP 42090"},
        {"Geneva Identification System", "GEN# +1.00072524"},
        {"Renson", "Renson 20100"},
        {"Smithsonian Astrophysical Observation", "SAO 60907"},
        {"Wilson Evans Batten Catalogue", "WEB 8092"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.68293147),
        dec: Angle.Degrees(+36.41971903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166012"},
        {"Hipparcos Number", "HIP 88752"},
        {"Fundamental Katalog 5th Edition", "FK5 5597"},
        {"Smithsonian Astrophysical Observation", "SAO 66650"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.77518274),
        dec: Angle.Degrees(+36.42070022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180138"},
        {"Hipparcos Number", "HIP 94484"},
        {"Smithsonian Astrophysical Observation", "SAO 68013"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.46905982),
        dec: Angle.Degrees(+36.42427588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108055"},
        {"Smithsonian Astrophysical Observation", "SAO 71804"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.39394724),
        dec: Angle.Degrees(+36.42512169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145849"},
        {"Hipparcos Number", "HIP 79358"},
        {"Geneva Identification System", "GEN# +1.00145849J"},
        {"Smithsonian Astrophysical Observation", "SAO 65132"},
        {"Wilson Evans Batten Catalogue", "WEB 13416"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.95025417),
        dec: Angle.Degrees(+36.42516245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223460"},
        {"Hipparcos Number", "HIP 117503"},
        {"Fundamental Katalog 5th Edition", "FK5 3914"},
        {"Geneva Identification System", "GEN# +1.00223460"},
        {"Smithsonian Astrophysical Observation", "SAO 73535"},
        {"Wilson Evans Batten Catalogue", "WEB 20694"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.42066699),
        dec: Angle.Degrees(+36.42539712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109530"},
        {"Hipparcos Number", "HIP 61424"},
        {"Geneva Identification System", "GEN# +4.36010001"},
        {"Smithsonian Astrophysical Observation", "SAO 63080"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.79564404),
        dec: Angle.Degrees(+36.42539794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190467"},
        {"Hipparcos Number", "HIP 98778"},
        {"Geneva Identification System", "GEN# +1.00190467"},
        {"Smithsonian Astrophysical Observation", "SAO 69334"},
        {"Wilson Evans Batten Catalogue", "WEB 17502"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.92332382),
        dec: Angle.Degrees(+36.42561364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176375"},
        {"Hipparcos Number", "HIP 93144"},
        {"Geneva Identification System", "GEN# +1.00176375J"},
        {"Smithsonian Astrophysical Observation", "SAO 67655"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61037056),
        dec: Angle.Degrees(+36.42581856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171275"},
        {"Hipparcos Number", "HIP 90880"},
        {"Geneva Identification System", "GEN# +1.00171275"},
        {"Smithsonian Astrophysical Observation", "SAO 67085"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.07114944),
        dec: Angle.Degrees(+36.42616618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26080"},
        {"Hipparcos Number", "HIP 19391"},
        {"Smithsonian Astrophysical Observation", "SAO 57018"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.29941176),
        dec: Angle.Degrees(+36.42751579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203921"},
        {"Hipparcos Number", "HIP 105673"},
        {"Geneva Identification System", "GEN# +2.70630001"},
        {"Renson", "Renson 56778"},
        {"New General Catalogue", "NGC 7063 1"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.05769738),
        dec: Angle.Degrees(+36.42798092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103594",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14512 AB"},
        {"Henry Draper", "HD 199987"},
        {"Hipparcos Number", "HIP 103594"},
        {"Celescope Catalog", "CEL 5225"},
        {"Geneva Identification System", "GEN# +1.00199987J"},
        {"Smithsonian Astrophysical Observation", "SAO 70765"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.84642441),
        dec: Angle.Degrees(+36.42883225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82212"},
        {"Hipparcos Number", "HIP 46749"},
        {"Geneva Identification System", "GEN# +1.00082212"},
        {"Smithsonian Astrophysical Observation", "SAO 61543"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.92676926),
        dec: Angle.Degrees(+36.42912140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132047"},
        {"Hipparcos Number", "HIP 73065"},
        {"Smithsonian Astrophysical Observation", "SAO 64409"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.97347387),
        dec: Angle.Degrees(+36.43018623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206294"},
        {"Hipparcos Number", "HIP 107002"},
        {"Geneva Identification System", "GEN# +1.00206294"},
        {"Smithsonian Astrophysical Observation", "SAO 71579"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.05077438),
        dec: Angle.Degrees(+36.43138925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207133"},
        {"Hipparcos Number", "HIP 107464"},
        {"Smithsonian Astrophysical Observation", "SAO 71679"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.49908050),
        dec: Angle.Degrees(+36.43157193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130289"},
        {"Hipparcos Number", "HIP 72219"},
        {"Smithsonian Astrophysical Observation", "SAO 64320"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.56081927),
        dec: Angle.Degrees(+36.43158484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188149"},
        {"Hipparcos Number", "HIP 97789"},
        {"Geneva Identification System", "GEN# +1.00188149"},
        {"Smithsonian Astrophysical Observation", "SAO 69004"},
        {"Wilson Evans Batten Catalogue", "WEB 17204"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.06835372),
        dec: Angle.Degrees(+36.43228438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209272"},
        {"Hipparcos Number", "HIP 108713"},
        {"Smithsonian Astrophysical Observation", "SAO 71952"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.33106484),
        dec: Angle.Degrees(+36.43288770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112609"},
        {"Smithsonian Astrophysical Observation", "SAO 72738"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.10760254),
        dec: Angle.Degrees(+36.43578839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47845"},
        {"Smithsonian Astrophysical Observation", "SAO 61666"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.28553133),
        dec: Angle.Degrees(+36.43592287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76261"},
        {"Hipparcos Number", "HIP 43861"},
        {"Geneva Identification System", "GEN# +1.00076261"},
        {"Smithsonian Astrophysical Observation", "SAO 61139"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.02940705),
        dec: Angle.Degrees(+36.43638199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72291"},
        {"Hipparcos Number", "HIP 41975"},
        {"Geneva Identification System", "GEN# +1.00072291"},
        {"Geneva Identification System 2", "GEN# +4.35100045"},
        {"Smithsonian Astrophysical Observation", "SAO 60896"},
        {"Wilson Evans Batten Catalogue", "WEB 8078"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.34098179),
        dec: Angle.Degrees(+36.43642315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4498"},
        {"Smithsonian Astrophysical Observation", "SAO 54293"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.40967056),
        dec: Angle.Degrees(+36.43839931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174345"},
        {"Hipparcos Number", "HIP 92282"},
        {"Smithsonian Astrophysical Observation", "SAO 67408"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.11725531),
        dec: Angle.Degrees(+36.44087489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65937"},
        {"Geneva Identification System", "GEN# +0.03702416J"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.75226539),
        dec: Angle.Degrees(+36.44107119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32728"},
        {"Smithsonian Astrophysical Observation", "SAO 59517"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.40880315),
        dec: Angle.Degrees(+36.44179627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18900"},
        {"Henry Draper 2", "HD 18900A"},
        {"Hipparcos Number", "HIP 14237"},
        {"Smithsonian Astrophysical Observation", "SAO 56117"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.89802248),
        dec: Angle.Degrees(+36.44211966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141186"},
        {"Hipparcos Number", "HIP 77252"},
        {"Geneva Identification System", "GEN# +1.00141186A"},
        {"Smithsonian Astrophysical Observation", "SAO 64893"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.60240003),
        dec: Angle.Degrees(+36.44586365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34146"},
        {"Hipparcos Number", "HIP 24620"},
        {"Smithsonian Astrophysical Observation", "SAO 57828"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.20648988),
        dec: Angle.Degrees(+36.44638714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37616"},
        {"Hipparcos Number", "HIP 26804"},
        {"Smithsonian Astrophysical Observation", "SAO 58337"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.38204467),
        dec: Angle.Degrees(+36.44757679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121695"},
        {"Hipparcos Number", "HIP 68069"},
        {"Smithsonian Astrophysical Observation", "SAO 63840"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.04894823),
        dec: Angle.Degrees(+36.44783924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74937"},
        {"Smithsonian Astrophysical Observation", "SAO 64625"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.69748041),
        dec: Angle.Degrees(+36.44846370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149432"},
        {"Hipparcos Number", "HIP 81052"},
        {"Smithsonian Astrophysical Observation", "SAO 65378"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30815120),
        dec: Angle.Degrees(+36.44851039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3742"},
        {"Hipparcos Number", "HIP 3176"},
        {"Smithsonian Astrophysical Observation", "SAO 54068"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.12112629),
        dec: Angle.Degrees(+36.45043841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182635"},
        {"Hipparcos Number", "HIP 95370"},
        {"Smithsonian Astrophysical Observation", "SAO 68258"},
        {"Wilson Evans Batten Catalogue", "WEB 16669"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.02521109),
        dec: Angle.Degrees(+36.45190293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141186B"},
        {"Hipparcos Number", "HIP 77245"},
        {"Smithsonian Astrophysical Observation", "SAO 64892"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.59580423),
        dec: Angle.Degrees(+36.45247363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96626"},
        {"Hipparcos Number", "HIP 54428"},
        {"Geneva Identification System", "GEN# +1.00096626"},
        {"Smithsonian Astrophysical Observation", "SAO 62418"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.06139290),
        dec: Angle.Degrees(+36.45468380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195324"},
        {"Hipparcos Number", "HIP 101067"},
        {"Fundamental Katalog 5th Edition", "FK5 1535"},
        {"Geneva Identification System", "GEN# +1.00195324"},
        {"Smithsonian Astrophysical Observation", "SAO 70096"},
        {"Wilson Evans Batten Catalogue", "WEB 18251"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.33495238),
        dec: Angle.Degrees(+36.45473284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134044"},
        {"Hipparcos Number", "HIP 73941"},
        {"Geneva Identification System", "GEN# +1.00134044"},
        {"Smithsonian Astrophysical Observation", "SAO 64503"},
        {"Wilson Evans Batten Catalogue", "WEB 12629"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.64663107),
        dec: Angle.Degrees(+36.45596449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91637"},
        {"Smithsonian Astrophysical Observation", "SAO 67253"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.31878546),
        dec: Angle.Degrees(+36.45600527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43155"},
        {"Fundamental Katalog 5th Edition", "FK5 4788"},
        {"Smithsonian Astrophysical Observation", "SAO 61052"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.84814090),
        dec: Angle.Degrees(+36.45643192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81440"},
        {"Hipparcos Number", "HIP 46321"},
        {"Geneva Identification System", "GEN# +1.00081440"},
        {"Smithsonian Astrophysical Observation", "SAO 61493"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.67159275),
        dec: Angle.Degrees(+36.45753892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45391"},
        {"Hipparcos Number", "HIP 30862"},
        {"Cincinnati Publication", "Ci 18 801"},
        {"Geneva Identification System", "GEN# +1.00045391"},
        {"Smithsonian Astrophysical Observation", "SAO 59131"},
        {"Wilson Evans Batten Catalogue", "WEB 6149"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.19268426),
        dec: Angle.Degrees(+36.48051961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85133",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10527 AB"},
        {"Henry Draper", "HD 157807"},
        {"Hipparcos Number", "HIP 85133"},
        {"Smithsonian Astrophysical Observation", "SAO 66003"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.97747626),
        dec: Angle.Degrees(+36.45774020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26076",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4143 A"},
        {"Henry Draper", "HD 36483"},
        {"Hipparcos Number", "HIP 26076"},
        {"Geneva Identification System", "GEN# +1.00036483J"},
        {"Smithsonian Astrophysical Observation", "SAO 58181"},
        {"Wilson Evans Batten Catalogue", "WEB 5076"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.42146701),
        dec: Angle.Degrees(+36.45972185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23193"},
        {"Hipparcos Number", "HIP 17460"},
        {"Fundamental Katalog 5th Edition", "FK5 2268"},
        {"Geneva Identification System", "GEN# +1.00023193"},
        {"Renson", "Renson 5880"},
        {"Smithsonian Astrophysical Observation", "SAO 56675"},
        {"Wilson Evans Batten Catalogue", "WEB 3306"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.13082016),
        dec: Angle.Degrees(+36.46020384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40400"},
        {"Smithsonian Astrophysical Observation", "SAO 60671"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.71835405),
        dec: Angle.Degrees(+36.46040003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69304",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9145 AB"},
        {"Hipparcos Number", "HIP 69304"},
        {"Geneva Identification System", "GEN# +0.03702503J"},
        {"Smithsonian Astrophysical Observation", "SAO 63978"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.78154197),
        dec: Angle.Degrees(+36.46306831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67171"},
        {"Smithsonian Astrophysical Observation", "SAO 63728"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.47136377),
        dec: Angle.Degrees(+36.46388425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166640"},
        {"Hipparcos Number", "HIP 89008"},
        {"Geneva Identification System", "GEN# +1.00166640"},
        {"Smithsonian Astrophysical Observation", "SAO 66703"},
        {"Wilson Evans Batten Catalogue", "WEB 15107"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.49577622),
        dec: Angle.Degrees(+36.46625671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88191"},
        {"Hipparcos Number", "HIP 49864"},
        {"Smithsonian Astrophysical Observation", "SAO 61911"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.73282855),
        dec: Angle.Degrees(+36.46812260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176133"},
        {"Hipparcos Number", "HIP 93042"},
        {"Smithsonian Astrophysical Observation", "SAO 67621"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.29403948),
        dec: Angle.Degrees(+36.46986372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 789"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.44298188),
        dec: Angle.Degrees(+36.47378127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101394"},
        {"Hipparcos Number", "HIP 56927"},
        {"Geneva Identification System", "GEN# +1.00101394"},
        {"Smithsonian Astrophysical Observation", "SAO 62647"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.05902383),
        dec: Angle.Degrees(+36.47531634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196361"},
        {"Hipparcos Number", "HIP 101614"},
        {"Geneva Identification System", "GEN# +1.00196361"},
        {"Smithsonian Astrophysical Observation", "SAO 70242"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.91108021),
        dec: Angle.Degrees(+36.47545238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20113"},
        {"Hipparcos Number", "HIP 15151"},
        {"Smithsonian Astrophysical Observation", "SAO 56284"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.82072070),
        dec: Angle.Degrees(+36.47585054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220316"},
        {"Hipparcos Number", "HIP 115394"},
        {"Geneva Identification System", "GEN# +1.00220316"},
        {"Smithsonian Astrophysical Observation", "SAO 73207"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.63150754),
        dec: Angle.Degrees(+36.47653011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46368"},
        {"Smithsonian Astrophysical Observation", "SAO 61497"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.82190887),
        dec: Angle.Degrees(+36.47725003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117673"},
        {"Hipparcos Number", "HIP 65953"},
        {"Geneva Identification System", "GEN# +1.00117673"},
        {"Smithsonian Astrophysical Observation", "SAO 63581"},
        {"Wilson Evans Batten Catalogue", "WEB 11663"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.82174259),
        dec: Angle.Degrees(+36.48037908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88156"},
    },
    visualMagnitude: 11.28,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.07869012),
        dec: Angle.Degrees(+36.48229841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110801"},
        {"Hipparcos Number", "HIP 62148"},
        {"Geneva Identification System", "GEN# +1.00110801"},
        {"Smithsonian Astrophysical Observation", "SAO 63167"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.07033663),
        dec: Angle.Degrees(+36.48361937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2018",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 344 AB"},
        {"Henry Draper", "HD 2125"},
        {"Hipparcos Number", "HIP 2018"},
        {"Smithsonian Astrophysical Observation", "SAO 53882"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.40689985),
        dec: Angle.Degrees(+36.48375203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21753"},
        {"Hipparcos Number", "HIP 16444"},
        {"Geneva Identification System", "GEN# +1.00021753"},
        {"Smithsonian Astrophysical Observation", "SAO 56515"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.94619163),
        dec: Angle.Degrees(+36.48393415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105718"},
        {"Geneva Identification System", "GEN# +2.70630029"},
        {"Smithsonian Astrophysical Observation", "SAO 71302"},
        {"New General Catalogue", "NGC 7063 102"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.18932447),
        dec: Angle.Degrees(+36.48613973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82522"},
        {"Hipparcos Number", "HIP 46904"},
        {"Geneva Identification System", "GEN# +1.00082522"},
        {"Smithsonian Astrophysical Observation", "SAO 61561"},
        {"Wilson Evans Batten Catalogue", "WEB 8842"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.37639032),
        dec: Angle.Degrees(+36.48703015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4563"},
        {"Hipparcos Number", "HIP 3740"},
        {"Geneva Identification System", "GEN# +1.00004563"},
        {"Smithsonian Astrophysical Observation", "SAO 54151"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.00233241),
        dec: Angle.Degrees(+36.48710972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20222"},
        {"Cincinnati Publication", "Ci 20 292"},
        {"Geneva Identification System", "GEN# +9.80038028"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.99806964),
        dec: Angle.Degrees(+36.48758798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -454.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49249"},
        {"Smithsonian Astrophysical Observation", "SAO 61829"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80149218),
        dec: Angle.Degrees(+36.48875503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48337",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7541 AB"},
        {"Henry Draper", "HD 85177"},
        {"Hipparcos Number", "HIP 48337"},
        {"Smithsonian Astrophysical Observation", "SAO 61712"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.78916808),
        dec: Angle.Degrees(+36.48917782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101491"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.50682595),
        dec: Angle.Degrees(+36.48943869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79119",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9939 A"},
        {"Henry Draper", "HD 145328"},
        {"Hipparcos Number", "HIP 79119"},
        {"Fundamental Katalog 5th Edition", "FK5 1423"},
        {"Geneva Identification System", "GEN# +1.00145328"},
        {"Smithsonian Astrophysical Observation", "SAO 65108"},
        {"Wilson Evans Batten Catalogue", "WEB 13375"},
    },
    visualMagnitude: 4.73,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.24303566),
        dec: Angle.Degrees(+36.49010935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 343.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102588"},
        {"Hipparcos Number", "HIP 57608"},
        {"Geneva Identification System", "GEN# +1.00102588"},
        {"Smithsonian Astrophysical Observation", "SAO 62711"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.16482116),
        dec: Angle.Degrees(+36.49046716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14296 AB"},
        {"Henry Draper", "HD 198183"},
        {"Hipparcos Number", "HIP 102589"},
        {"Celescope Catalog", "CEL 5168"},
        {"Geneva Identification System", "GEN# +1.00198183J"},
        {"Smithsonian Astrophysical Observation", "SAO 70505"},
        {"Wilson Evans Batten Catalogue", "WEB 18587"},
    },
    visualMagnitude: 4.53,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.85219564),
        dec: Angle.Degrees(+36.49073658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 221 AB"},
        {"Henry Draper", "HD 1224"},
        {"Hipparcos Number", "HIP 1336"},
        {"Geneva Identification System", "GEN# +1.00001224J"},
        {"Smithsonian Astrophysical Observation", "SAO 53773"},
        {"Wilson Evans Batten Catalogue", "WEB 237"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.18527042),
        dec: Angle.Degrees(+36.49138829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24747"},
        {"Hipparcos Number", "HIP 18518"},
        {"Geneva Identification System", "GEN# +1.00024747"},
        {"Smithsonian Astrophysical Observation", "SAO 56838"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.39617448),
        dec: Angle.Degrees(+36.49153702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81573"},
        {"Geneva Identification System", "GEN# +0.03602764"},
        {"Smithsonian Astrophysical Observation", "SAO 65466"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.89662067),
        dec: Angle.Degrees(+36.49166267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214180"},
        {"Hipparcos Number", "HIP 111562"},
        {"Geneva Identification System", "GEN# +1.00214180"},
        {"Smithsonian Astrophysical Observation", "SAO 72516"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.02391832),
        dec: Angle.Degrees(+36.49426986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55281"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.83189736),
        dec: Angle.Degrees(+36.49678679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105701"},
        {"Geneva Identification System", "GEN# +2.70630004"},
        {"New General Catalogue", "NGC 7063 4"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.12947317),
        dec: Angle.Degrees(+36.49849896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220168"},
        {"Hipparcos Number", "HIP 115317"},
        {"Geneva Identification System", "GEN# +1.00220168"},
        {"Smithsonian Astrophysical Observation", "SAO 73197"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.34635851),
        dec: Angle.Degrees(+36.50113137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26708"},
        {"Hipparcos Number", "HIP 19815"},
        {"Smithsonian Astrophysical Observation", "SAO 57096"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.74278029),
        dec: Angle.Degrees(+36.50206248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102267"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.81929892),
        dec: Angle.Degrees(+36.50207459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26900"},
        {"Hipparcos Number", "HIP 19930"},
        {"Cincinnati Publication", "Ci 18 565"},
        {"Smithsonian Astrophysical Observation", "SAO 57117"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13613292),
        dec: Angle.Degrees(+36.50237672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
