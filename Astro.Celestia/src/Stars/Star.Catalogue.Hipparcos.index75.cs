using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_75() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229680"},
        {"Hipparcos Number", "HIP 92452"},
        {"Geneva Identification System", "GEN# +1.00229680"},
        {"Wilson Evans Batten Catalogue", "WEB 15974"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.61554352),
        dec: Angle.Degrees(+15.94020398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27991"},
        {"Hipparcos Number", "HIP 20661"},
        {"Celescope Catalog", "CEL 398"},
        {"Geneva Identification System", "GEN# +5.20250057"},
        {"Smithsonian Astrophysical Observation", "SAO 93925"},
        {"Wilson Evans Batten Catalogue", "WEB 3960"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.40522319),
        dec: Angle.Degrees(+15.94108006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142227"},
        {"Hipparcos Number", "HIP 77775"},
        {"Geneva Identification System", "GEN# +1.00142227"},
        {"Smithsonian Astrophysical Observation", "SAO 101786"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.22056169),
        dec: Angle.Degrees(+15.94311548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36548"},
        {"Hipparcos Number", "HIP 26027"},
        {"Geneva Identification System", "GEN# +1.00036548"},
        {"Smithsonian Astrophysical Observation", "SAO 94644"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28806064),
        dec: Angle.Degrees(+15.94406119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170651"},
        {"Hipparcos Number", "HIP 90669"},
        {"Fundamental Katalog 5th Edition", "FK5 5623"},
        {"Smithsonian Astrophysical Observation", "SAO 103784"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.49764101),
        dec: Angle.Degrees(+15.94439636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88766"},
        {"Cincinnati Publication", "Ci 18 2397"},
        {"Geneva Identification System", "GEN# +0.01503364"},
        {"Smithsonian Astrophysical Observation", "SAO 103395"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.82771923),
        dec: Angle.Degrees(+15.94645114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26380"},
        {"Hipparcos Number", "HIP 19519"},
        {"Geneva Identification System", "GEN# +1.00026380"},
        {"Smithsonian Astrophysical Observation", "SAO 93803"},
        {"Wilson Evans Batten Catalogue", "WEB 3740"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.72988622),
        dec: Angle.Degrees(+15.94669837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70251"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.61152973),
        dec: Angle.Degrees(+15.95019266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84289",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10407 AB"},
        {"Henry Draper", "HD 155924"},
        {"Hipparcos Number", "HIP 84289"},
        {"Smithsonian Astrophysical Observation", "SAO 102666"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.47363804),
        dec: Angle.Degrees(+15.95087181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86623",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10723 A"},
        {"Henry Draper", "HD 160910"},
        {"Henry Draper 2", "HD 160910A"},
        {"Hipparcos Number", "HIP 86623"},
        {"Geneva Identification System", "GEN# +1.00160910"},
        {"Smithsonian Astrophysical Observation", "SAO 103033"},
        {"Wilson Evans Batten Catalogue", "WEB 14607"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49432602),
        dec: Angle.Degrees(+15.95217942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118149"},
        {"Smithsonian Astrophysical Observation", "SAO 108933"},
        {"Wilson Evans Batten Catalogue", "WEB 20772"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.49376544),
        dec: Angle.Degrees(+15.95292997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38288",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38288"},
        {"Smithsonian Astrophysical Observation", "SAO 97303"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.66698345),
        dec: Angle.Degrees(+15.95476468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88778"},
        {"Geneva Identification System", "GEN# +0.01503367"},
        {"Smithsonian Astrophysical Observation", "SAO 103400"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.85072956),
        dec: Angle.Degrees(+15.95667986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12164"},
        {"Hipparcos Number", "HIP 9328"},
        {"Geneva Identification System", "GEN# +1.00012164"},
        {"Smithsonian Astrophysical Observation", "SAO 92742"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.94423059),
        dec: Angle.Degrees(+15.95792859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244671"},
        {"Hipparcos Number", "HIP 25975"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.14871936),
        dec: Angle.Degrees(+15.95818454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187143"},
        {"Hipparcos Number", "HIP 97406"},
        {"Smithsonian Astrophysical Observation", "SAO 105267"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.96599542),
        dec: Angle.Degrees(+15.95826839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119876"},
        {"Hipparcos Number", "HIP 67148"},
        {"Geneva Identification System", "GEN# +1.00119876"},
        {"Smithsonian Astrophysical Observation", "SAO 100697"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.41400699),
        dec: Angle.Degrees(+15.95918286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210311"},
        {"Hipparcos Number", "HIP 109351"},
        {"Geneva Identification System", "GEN# +1.00210311"},
        {"Smithsonian Astrophysical Observation", "SAO 107693"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.30436084),
        dec: Angle.Degrees(+15.96161075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28307"},
        {"Hipparcos Number", "HIP 20885"},
        {"Celescope Catalog", "CEL 406"},
        {"Geneva Identification System", "GEN# +5.20250071"},
        {"Smithsonian Astrophysical Observation", "SAO 93955"},
        {"Wilson Evans Batten Catalogue", "WEB 4010"},
    },
    visualMagnitude: 3.84,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.14346805),
        dec: Angle.Degrees(+15.96221721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129697"},
        {"Hipparcos Number", "HIP 72008"},
        {"Smithsonian Astrophysical Observation", "SAO 101170"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.91438679),
        dec: Angle.Degrees(+15.96385484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85626",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10592 A"},
        {"Henry Draper", "HD 158656"},
        {"Hipparcos Number", "HIP 85626"},
        {"Geneva Identification System", "GEN# +1.00158656"},
        {"Smithsonian Astrophysical Observation", "SAO 102862"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.46430129),
        dec: Angle.Degrees(+15.96407892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188715"},
        {"Hipparcos Number", "HIP 98080"},
        {"Geneva Identification System", "GEN# +1.00188715"},
        {"Smithsonian Astrophysical Observation", "SAO 105433"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.99070961),
        dec: Angle.Degrees(+15.96479158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164784"},
        {"Hipparcos Number", "HIP 88315"},
        {"Smithsonian Astrophysical Observation", "SAO 103318"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.54272784),
        dec: Angle.Degrees(+15.96636530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13395"},
        {"Hipparcos Number", "HIP 10207"},
        {"Smithsonian Astrophysical Observation", "SAO 92828"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.82869123),
        dec: Angle.Degrees(+15.96682981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200393"},
        {"Hipparcos Number", "HIP 103868"},
        {"Smithsonian Astrophysical Observation", "SAO 106792"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.69657995),
        dec: Angle.Degrees(+15.96712201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32978"},
        {"Hipparcos Number", "HIP 23847"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90249561),
        dec: Angle.Degrees(+15.96817197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63674"},
        {"Hipparcos Number", "HIP 38284"},
        {"Smithsonian Astrophysical Observation", "SAO 97302"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.65990007),
        dec: Angle.Degrees(+15.96832657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98248"},
        {"Hipparcos Number", "HIP 55204"},
        {"Smithsonian Astrophysical Observation", "SAO 99542"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.55849889),
        dec: Angle.Degrees(+15.96977427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29786"},
        {"Hipparcos Number", "HIP 21873"},
        {"Celescope Catalog", "CEL 455"},
        {"Geneva Identification System", "GEN# +1.00029786"},
        {"Smithsonian Astrophysical Observation", "SAO 94074"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.54066702),
        dec: Angle.Degrees(+15.96994500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32593"},
        {"Hipparcos Number", "HIP 23651"},
        {"Smithsonian Astrophysical Observation", "SAO 94298"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.24471592),
        dec: Angle.Degrees(+15.97117650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148317"},
        {"Hipparcos Number", "HIP 80543"},
        {"Geneva Identification System", "GEN# +1.00148317"},
        {"Smithsonian Astrophysical Observation", "SAO 102174"},
        {"Wilson Evans Batten Catalogue", "WEB 13627"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.66335427),
        dec: Angle.Degrees(+15.97264606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39120"},
        {"Smithsonian Astrophysical Observation", "SAO 97455"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.05350599),
        dec: Angle.Degrees(+15.97274855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3871"},
        {"Smithsonian Astrophysical Observation", "SAO 92103"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.42488836),
        dec: Angle.Degrees(+15.97313098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5720 AB"},
        {"Henry Draper", "HD 52634"},
        {"Hipparcos Number", "HIP 33941"},
        {"Smithsonian Astrophysical Observation", "SAO 96411"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.65593040),
        dec: Angle.Degrees(+15.97402676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134322"},
        {"Hipparcos Number", "HIP 74103"},
        {"Smithsonian Astrophysical Observation", "SAO 101401"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.17379184),
        dec: Angle.Degrees(+15.97465429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35329"},
        {"Hipparcos Number", "HIP 25287"},
        {"Smithsonian Astrophysical Observation", "SAO 94527"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.14479890),
        dec: Angle.Degrees(+15.97528489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14761 AB"},
        {"Henry Draper", "HD 202128"},
        {"Hipparcos Number", "HIP 104771"},
        {"Geneva Identification System", "GEN# +1.00202128J"},
        {"Smithsonian Astrophysical Observation", "SAO 106930"},
        {"Wilson Evans Batten Catalogue", "WEB 19057"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.36985452),
        dec: Angle.Degrees(+15.98245122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59997"},
        {"Hipparcos Number", "HIP 36716"},
        {"Smithsonian Astrophysical Observation", "SAO 97008"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.27732425),
        dec: Angle.Degrees(+15.98245497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92197"},
        {"Hipparcos Number", "HIP 52126"},
        {"Geneva Identification System", "GEN# +1.00092197"},
        {"Smithsonian Astrophysical Observation", "SAO 99231"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.74792605),
        dec: Angle.Degrees(+15.98316918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103236"},
        {"Hipparcos Number", "HIP 57969"},
        {"Smithsonian Astrophysical Observation", "SAO 99845"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.35464486),
        dec: Angle.Degrees(+15.98342874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209380"},
        {"Hipparcos Number", "HIP 108814"},
        {"Fundamental Katalog 5th Edition", "FK5 3764"},
        {"Geneva Identification System", "GEN# +1.00209380"},
        {"Smithsonian Astrophysical Observation", "SAO 107611"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.66039078),
        dec: Angle.Degrees(+15.98653650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8910"},
        {"Hipparcos Number", "HIP 6837"},
        {"Geneva Identification System", "GEN# +1.00008910"},
        {"Smithsonian Astrophysical Observation", "SAO 92450"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.00249311),
        dec: Angle.Degrees(+15.98844176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19666"},
        {"Hipparcos Number", "HIP 14751"},
        {"Geneva Identification System", "GEN# +1.00019666"},
        {"Smithsonian Astrophysical Observation", "SAO 93318"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.61560286),
        dec: Angle.Degrees(+15.99038847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1503",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 257 AB"},
        {"Henry Draper", "HD 1450"},
        {"Hipparcos Number", "HIP 1503"},
        {"Geneva Identification System", "GEN# +1.00001450"},
        {"Smithsonian Astrophysical Observation", "SAO 91839"},
        {"Wilson Evans Batten Catalogue", "WEB 279"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.67831359),
        dec: Angle.Degrees(+15.99070755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201006"},
        {"Hipparcos Number", "HIP 104181"},
        {"Geneva Identification System", "GEN# +1.00201006"},
        {"Smithsonian Astrophysical Observation", "SAO 106840"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.61432912),
        dec: Angle.Degrees(+15.99158959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14610"},
        {"Hipparcos Number", "HIP 11027"},
        {"Geneva Identification System", "GEN# +1.00014610"},
        {"Smithsonian Astrophysical Observation", "SAO 92903"},
        {"Wilson Evans Batten Catalogue", "WEB 2318"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.50203177),
        dec: Angle.Degrees(+15.99191228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198402"},
        {"Hipparcos Number", "HIP 102800"},
        {"Geneva Identification System", "GEN# +1.00198402"},
        {"Smithsonian Astrophysical Observation", "SAO 106537"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.40196780),
        dec: Angle.Degrees(+15.99200390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55603"},
        {"Smithsonian Astrophysical Observation", "SAO 99583"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.85917024),
        dec: Angle.Degrees(+15.99283199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18432"},
        {"Hipparcos Number", "HIP 13846"},
        {"Smithsonian Astrophysical Observation", "SAO 93210"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.56402503),
        dec: Angle.Degrees(+15.99324957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113115"},
        {"Smithsonian Astrophysical Observation", "SAO 108243"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.59856997),
        dec: Angle.Degrees(+15.99727498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157067"},
        {"Hipparcos Number", "HIP 84848"},
        {"Geneva Identification System", "GEN# +1.00157067"},
        {"Smithsonian Astrophysical Observation", "SAO 102759"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.11957007),
        dec: Angle.Degrees(+15.99801783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107482"},
        {"Smithsonian Astrophysical Observation", "SAO 107386"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.55131659),
        dec: Angle.Degrees(+15.99836521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75558"},
        {"Hipparcos Number", "HIP 43463"},
        {"Geneva Identification System", "GEN# +1.00075558"},
        {"Smithsonian Astrophysical Observation", "SAO 98169"},
        {"Wilson Evans Batten Catalogue", "WEB 8376"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.79511725),
        dec: Angle.Degrees(+15.99939667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24014"},
        {"Hipparcos Number", "HIP 17944"},
        {"Smithsonian Astrophysical Observation", "SAO 93628"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.55498497),
        dec: Angle.Degrees(+16.00035431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105760"},
        {"Smithsonian Astrophysical Observation", "SAO 107116"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.30377002),
        dec: Angle.Degrees(+16.00153280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231422"},
        {"Hipparcos Number", "HIP 95598"},
        {"Geneva Identification System", "GEN# +1.00231422"},
        {"Smithsonian Astrophysical Observation", "SAO 104840"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.66157976),
        dec: Angle.Degrees(+16.00240286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79499"},
        {"Hipparcos Number", "HIP 45387"},
        {"Geneva Identification System", "GEN# +1.00079499"},
        {"Smithsonian Astrophysical Observation", "SAO 98453"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.74088722),
        dec: Angle.Degrees(+16.00462750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86816"},
        {"Smithsonian Astrophysical Observation", "SAO 103072"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.09088463),
        dec: Angle.Degrees(+16.00641091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79614",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9977 AB"},
        {"Hipparcos Number", "HIP 79614"},
        {"Smithsonian Astrophysical Observation", "SAO 102031"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.68966244),
        dec: Angle.Degrees(+16.00679629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193097"},
        {"Hipparcos Number", "HIP 100056"},
        {"Geneva Identification System", "GEN# +1.00193097"},
        {"Smithsonian Astrophysical Observation", "SAO 105935"},
        {"Wilson Evans Batten Catalogue", "WEB 18017"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.48864858),
        dec: Angle.Degrees(+16.00934144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72955"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.65212192),
        dec: Angle.Degrees(+16.00971202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2171"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.85147412),
        dec: Angle.Degrees(+16.00977378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138685"},
        {"Hipparcos Number", "HIP 76136"},
        {"Geneva Identification System", "GEN# +1.00138685"},
        {"Smithsonian Astrophysical Observation", "SAO 101610"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.26959950),
        dec: Angle.Degrees(+16.01207245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221114"},
        {"Hipparcos Number", "HIP 115910"},
        {"Fundamental Katalog 5th Edition", "FK5 1615"},
        {"Geneva Identification System", "GEN# +1.00221114"},
        {"Smithsonian Astrophysical Observation", "SAO 108636"},
        {"Wilson Evans Batten Catalogue", "WEB 20499"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.25924647),
        dec: Angle.Degrees(+16.01254578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43947"},
        {"Hipparcos Number", "HIP 30067"},
        {"Geneva Identification System", "GEN# +1.00043947"},
        {"Smithsonian Astrophysical Observation", "SAO 95538"},
        {"Wilson Evans Batten Catalogue", "WEB 5977"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.91742934),
        dec: Angle.Degrees(+16.01328387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124677"},
        {"Hipparcos Number", "HIP 69595"},
        {"Cincinnati Publication", "Ci 18 1870"},
        {"Geneva Identification System", "GEN# +1.00124677"},
        {"Smithsonian Astrophysical Observation", "SAO 100932"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.67170105),
        dec: Angle.Degrees(+16.01353119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182381"},
        {"Hipparcos Number", "HIP 95346"},
        {"Geneva Identification System", "GEN# +1.00182381"},
        {"Renson", "Renson 50440"},
        {"Smithsonian Astrophysical Observation", "SAO 104788"},
        {"Wilson Evans Batten Catalogue", "WEB 16662"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.96037550),
        dec: Angle.Degrees(+16.01413721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193622"},
        {"Hipparcos Number", "HIP 100309"},
        {"Geneva Identification System", "GEN# +1.00193622"},
        {"Smithsonian Astrophysical Observation", "SAO 105997"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.16347598),
        dec: Angle.Degrees(+16.01544669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213355"},
        {"Hipparcos Number", "HIP 111108"},
        {"Geneva Identification System", "GEN# +1.00213355"},
        {"Smithsonian Astrophysical Observation", "SAO 107962"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.62925684),
        dec: Angle.Degrees(+16.01675391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39984"},
        {"Hipparcos Number", "HIP 28129"},
        {"Celescope Catalog", "CEL 1040"},
        {"Smithsonian Astrophysical Observation", "SAO 95020"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.18426757),
        dec: Angle.Degrees(+16.01720071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217819"},
        {"Hipparcos Number", "HIP 113845"},
        {"Smithsonian Astrophysical Observation", "SAO 108364"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.82388341),
        dec: Angle.Degrees(+16.01902394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92280"},
        {"Hipparcos Number", "HIP 52175"},
        {"Geneva Identification System", "GEN# +1.00092280"},
        {"Smithsonian Astrophysical Observation", "SAO 99237"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.89457675),
        dec: Angle.Degrees(+16.01915939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17996"},
        {"Hipparcos Number", "HIP 13509"},
        {"Geneva Identification System", "GEN# +1.00017996"},
        {"Smithsonian Astrophysical Observation", "SAO 93170"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.49762699),
        dec: Angle.Degrees(+16.02045716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191654"},
        {"Hipparcos Number", "HIP 99390"},
        {"Geneva Identification System", "GEN# +1.00191654"},
        {"Renson", "Renson 53420"},
        {"Smithsonian Astrophysical Observation", "SAO 105781"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.60484072),
        dec: Angle.Degrees(+16.02068801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211341"},
        {"Hipparcos Number", "HIP 109950"},
        {"Geneva Identification System", "GEN# +1.00211341"},
        {"Smithsonian Astrophysical Observation", "SAO 107782"},
        {"Wilson Evans Batten Catalogue", "WEB 19741"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.02486324),
        dec: Angle.Degrees(+16.02092840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2806"},
        {"Hipparcos Number", "HIP 2490"},
        {"Geneva Identification System", "GEN# +1.00002806"},
        {"Smithsonian Astrophysical Observation", "SAO 91942"},
        {"Wilson Evans Batten Catalogue", "WEB 456"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.90037051),
        dec: Angle.Degrees(+16.02101606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56541"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.90515814),
        dec: Angle.Degrees(+16.02119491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144361"},
        {"Hipparcos Number", "HIP 78770"},
        {"Smithsonian Astrophysical Observation", "SAO 101910"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.22593745),
        dec: Angle.Degrees(+16.02190220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23205"},
        {"Hipparcos Number", "HIP 17413"},
        {"Geneva Identification System", "GEN# +1.00023205"},
        {"Smithsonian Astrophysical Observation", "SAO 93569"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.96818841),
        dec: Angle.Degrees(+16.02226737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154277"},
        {"Hipparcos Number", "HIP 83495"},
        {"Geneva Identification System", "GEN# +1.00154277"},
        {"Smithsonian Astrophysical Observation", "SAO 102568"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.97697200),
        dec: Angle.Degrees(+16.02269429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140027"},
        {"Hipparcos Number", "HIP 76810"},
        {"Geneva Identification System", "GEN# +1.00140027"},
        {"Smithsonian Astrophysical Observation", "SAO 101678"},
        {"Wilson Evans Batten Catalogue", "WEB 13032"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.24619723),
        dec: Angle.Degrees(+16.02462900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2358"},
        {"Hipparcos Number", "HIP 2178"},
        {"Geneva Identification System", "GEN# +1.00002358A"},
        {"Smithsonian Astrophysical Observation", "SAO 91903"},
        {"Wilson Evans Batten Catalogue", "WEB 405"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.87922939),
        dec: Angle.Degrees(+16.02545897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107255"},
        {"Smithsonian Astrophysical Observation", "SAO 107352"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.86131042),
        dec: Angle.Degrees(+16.02580029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106746"},
        {"Hipparcos Number", "HIP 59855"},
        {"Geneva Identification System", "GEN# +1.00106746"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.11812119),
        dec: Angle.Degrees(+16.02853035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51297"},
        {"Hipparcos Number", "HIP 33469"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.36125763),
        dec: Angle.Degrees(+16.02935359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89019"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.51905971),
        dec: Angle.Degrees(+16.03051293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -465.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50323"},
        {"Smithsonian Astrophysical Observation", "SAO 99033"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.15010210),
        dec: Angle.Degrees(+16.03104356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190229"},
        {"Hipparcos Number", "HIP 98754"},
        {"Geneva Identification System", "GEN# +1.00190229"},
        {"Renson", "Renson 52840"},
        {"Smithsonian Astrophysical Observation", "SAO 105615"},
        {"Wilson Evans Batten Catalogue", "WEB 17493"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.87505300),
        dec: Angle.Degrees(+16.03127337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9076"},
        {"Smithsonian Astrophysical Observation", "SAO 92713"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.21089034),
        dec: Angle.Degrees(+16.03164641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29375"},
        {"Hipparcos Number", "HIP 21588"},
        {"Celescope Catalog", "CEL 447"},
        {"Geneva Identification System", "GEN# +5.20250103"},
        {"Smithsonian Astrophysical Observation", "SAO 94043"},
        {"Wilson Evans Batten Catalogue", "WEB 4144"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.53906817),
        dec: Angle.Degrees(+16.03338888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91843"},
        {"Hipparcos Number", "HIP 51935"},
        {"Smithsonian Astrophysical Observation", "SAO 99204"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.13938376),
        dec: Angle.Degrees(+16.03571782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48577"},
        {"Smithsonian Astrophysical Observation", "SAO 98838"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.61663167),
        dec: Angle.Degrees(+16.03589405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38578",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6440 A"},
        {"Henry Draper", "HD 64330"},
        {"Hipparcos Number", "HIP 38578"},
        {"Smithsonian Astrophysical Observation", "SAO 97348"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.49004682),
        dec: Angle.Degrees(+16.03622931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43058"},
        {"Smithsonian Astrophysical Observation", "SAO 98111"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.58187080),
        dec: Angle.Degrees(+16.03666946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43043"},
        {"Hipparcos Number", "HIP 29637"},
        {"Geneva Identification System", "GEN# +1.00043043"},
        {"Smithsonian Astrophysical Observation", "SAO 95429"},
        {"Wilson Evans Batten Catalogue", "WEB 5834"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.68036500),
        dec: Angle.Degrees(+16.03704267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2415",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 420 A"},
        {"Henry Draper", "HD 2714"},
        {"Hipparcos Number", "HIP 2415"},
        {"Geneva Identification System", "GEN# +1.00002714"},
        {"Smithsonian Astrophysical Observation", "SAO 91934"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.69654001),
        dec: Angle.Degrees(+16.03761493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88232"},
        {"Hipparcos Number", "HIP 49846"},
        {"Cincinnati Publication", "Ci 18 1219"},
        {"Geneva Identification System", "GEN# +1.00088232"},
        {"Smithsonian Astrophysical Observation", "SAO 98983"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.66608754),
        dec: Angle.Degrees(+16.03769269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108576"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.91733592),
        dec: Angle.Degrees(+16.03848707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16731"},
        {"Hipparcos Number", "HIP 12538"},
        {"Smithsonian Astrophysical Observation", "SAO 93054"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.33281235),
        dec: Angle.Degrees(+16.04008221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25207",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3969 A"},
        {"Henry Draper", "HD 35173"},
        {"Hipparcos Number", "HIP 25207"},
        {"Geneva Identification System", "GEN# +1.00035173"},
        {"Smithsonian Astrophysical Observation", "SAO 94512"},
        {"Wilson Evans Batten Catalogue", "WEB 4885"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.88224671),
        dec: Angle.Degrees(+16.04050774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210702"},
        {"Hipparcos Number", "HIP 109577"},
        {"Geneva Identification System", "GEN# +1.00210702"},
        {"Smithsonian Astrophysical Observation", "SAO 107729"},
        {"Wilson Evans Batten Catalogue", "WEB 19690"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.96388678),
        dec: Angle.Degrees(+16.04059653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51717"},
        {"Hipparcos Number", "HIP 33618"},
        {"Smithsonian Astrophysical Observation", "SAO 96341"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.77233081),
        dec: Angle.Degrees(+16.04071794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25201",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3969 B"},
        {"Henry Draper", "HD 35172"},
        {"Henry Draper 2", "HD 35173B"},
        {"Hipparcos Number", "HIP 25201"},
        {"Geneva Identification System", "GEN# +1.00035172"},
        {"Smithsonian Astrophysical Observation", "SAO 94511"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.87499582),
        dec: Angle.Degrees(+16.04248207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60909"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.24151822),
        dec: Angle.Degrees(+16.04359381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246262"},
        {"Hipparcos Number", "HIP 26748"},
        {"Smithsonian Astrophysical Observation", "SAO 94755"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.24876294),
        dec: Angle.Degrees(+16.04444628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142680"},
        {"Hipparcos Number", "HIP 77963"},
        {"Smithsonian Astrophysical Observation", "SAO 101816"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.83011228),
        dec: Angle.Degrees(+16.04491718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33554"},
        {"Hipparcos Number", "HIP 24197"},
        {"Fundamental Katalog 5th Edition", "FK5 2391"},
        {"Geneva Identification System", "GEN# +1.00033554"},
        {"Smithsonian Astrophysical Observation", "SAO 94377"},
        {"Wilson Evans Batten Catalogue", "WEB 4699"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.92317268),
        dec: Angle.Degrees(+16.04565766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194211"},
        {"Hipparcos Number", "HIP 100598"},
        {"Geneva Identification System", "GEN# +1.00194211"},
        {"Smithsonian Astrophysical Observation", "SAO 106059"},
        {"Wilson Evans Batten Catalogue", "WEB 18177"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97704986),
        dec: Angle.Degrees(+16.04690516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257822"},
        {"Hipparcos Number", "HIP 30819"},
        {"Smithsonian Astrophysical Observation", "SAO 95721"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.12109505),
        dec: Angle.Degrees(+16.04725435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9313"},
        {"Hipparcos Number", "HIP 7134"},
        {"Geneva Identification System", "GEN# +1.00009313"},
        {"Smithsonian Astrophysical Observation", "SAO 92489"},
        {"Wilson Evans Batten Catalogue", "WEB 1540"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.97856515),
        dec: Angle.Degrees(+16.04731672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7944 AB"},
        {"Henry Draper", "HD 93966"},
        {"Hipparcos Number", "HIP 53031"},
        {"Smithsonian Astrophysical Observation", "SAO 99319"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.75904578),
        dec: Angle.Degrees(+16.05399090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133161"},
        {"Hipparcos Number", "HIP 73593"},
        {"Fundamental Katalog 5th Edition", "FK5 3187"},
        {"Geneva Identification System", "GEN# +1.00133161"},
        {"Smithsonian Astrophysical Observation", "SAO 101345"},
        {"Wilson Evans Batten Catalogue", "WEB 12586"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.63825964),
        dec: Angle.Degrees(+16.05475441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138527"},
        {"Hipparcos Number", "HIP 76069"},
        {"Geneva Identification System", "GEN# +1.00138527"},
        {"Smithsonian Astrophysical Observation", "SAO 101600"},
        {"Wilson Evans Batten Catalogue", "WEB 12928"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.04032004),
        dec: Angle.Degrees(+16.05615239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64745"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.04028369),
        dec: Angle.Degrees(+16.05699445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44867"},
        {"Hipparcos Number", "HIP 30517"},
        {"Geneva Identification System", "GEN# +1.00044867"},
        {"Smithsonian Astrophysical Observation", "SAO 95641"},
        {"Wilson Evans Batten Catalogue", "WEB 6079"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.21981547),
        dec: Angle.Degrees(+16.05723053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69854"},
        {"Smithsonian Astrophysical Observation", "SAO 100961"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.43846340),
        dec: Angle.Degrees(+16.05738641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69032"},
        {"Smithsonian Astrophysical Observation", "SAO 100861"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.97240195),
        dec: Angle.Degrees(+16.05949404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111437"},
        {"Smithsonian Astrophysical Observation", "SAO 108011"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.63707662),
        dec: Angle.Degrees(+16.06054144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3511"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.20460454),
        dec: Angle.Degrees(+16.06344042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200079"},
        {"Hipparcos Number", "HIP 103690"},
        {"Smithsonian Astrophysical Observation", "SAO 106750"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.17914865),
        dec: Angle.Degrees(+16.06379593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230473"},
        {"Hipparcos Number", "HIP 93445"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.46295007),
        dec: Angle.Degrees(+16.06417881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242071"},
        {"Hipparcos Number", "HIP 24524"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.92740206),
        dec: Angle.Degrees(+16.06651092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115860"},
        {"Geneva Identification System", "GEN# +0.01504829A"},
        {"Smithsonian Astrophysical Observation", "SAO 108628"},
        {"Wilson Evans Batten Catalogue", "WEB 20496"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.10869978),
        dec: Angle.Degrees(+16.06692054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220373"},
        {"Hipparcos Number", "HIP 115443"},
        {"Fundamental Katalog 5th Edition", "FK5 6067"},
        {"Geneva Identification System", "GEN# +1.00220373"},
        {"Smithsonian Astrophysical Observation", "SAO 108581"},
        {"Wilson Evans Batten Catalogue", "WEB 20443"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.76666219),
        dec: Angle.Degrees(+16.06912195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106104"},
        {"Hipparcos Number", "HIP 59535"},
        {"Geneva Identification System", "GEN# +1.00106104"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12395425),
        dec: Angle.Degrees(+16.07010897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143064"},
        {"Hipparcos Number", "HIP 78157"},
        {"Smithsonian Astrophysical Observation", "SAO 101837"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.39061413),
        dec: Angle.Degrees(+16.07280690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66694"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.07037062),
        dec: Angle.Degrees(+16.07284317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19409"},
        {"Hipparcos Number", "HIP 14550"},
        {"Geneva Identification System", "GEN# +1.00019409"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.96135021),
        dec: Angle.Degrees(+16.07328246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9828 AB"},
        {"Henry Draper", "HD 142357"},
        {"Hipparcos Number", "HIP 77835"},
        {"Smithsonian Astrophysical Observation", "SAO 101796"},
        {"Wilson Evans Batten Catalogue", "WEB 13165"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.39523924),
        dec: Angle.Degrees(+16.07498779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31349"},
        {"Wilson Evans Batten Catalogue", "WEB 6273"},
    },
    visualMagnitude: 8.64,
    bvColour: 3.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.59965692),
        dec: Angle.Degrees(+16.07509694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60716"},
        {"Hipparcos Number", "HIP 37019"},
        {"Geneva Identification System", "GEN# +1.00060716"},
        {"Smithsonian Astrophysical Observation", "SAO 97074"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.12889995),
        dec: Angle.Degrees(+16.07596514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191048"},
        {"Hipparcos Number", "HIP 99117"},
        {"Geneva Identification System", "GEN# +1.00191048"},
        {"Smithsonian Astrophysical Observation", "SAO 105714"},
        {"Wilson Evans Batten Catalogue", "WEB 17631"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.83658101),
        dec: Angle.Degrees(+16.07630738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19360"},
        {"Hipparcos Number", "HIP 14500"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.82292084),
        dec: Angle.Degrees(+16.07749447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68903"},
        {"Hipparcos Number", "HIP 40410"},
        {"Smithsonian Astrophysical Observation", "SAO 97677"},
        {"Wilson Evans Batten Catalogue", "WEB 7875"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.74808707),
        dec: Angle.Degrees(+16.07864352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52005"},
        {"Hipparcos Number", "HIP 33715"},
        {"Geneva Identification System", "GEN# +1.00052005"},
        {"Smithsonian Astrophysical Observation", "SAO 96363"},
        {"Wilson Evans Batten Catalogue", "WEB 6773"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.06593512),
        dec: Angle.Degrees(+16.07900547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202016"},
        {"Hipparcos Number", "HIP 104725"},
        {"Smithsonian Astrophysical Observation", "SAO 106920"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.22176965),
        dec: Angle.Degrees(+16.08113920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16176"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.09485972),
        dec: Angle.Degrees(+16.08132898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90252"},
        {"Smithsonian Astrophysical Observation", "SAO 103691"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.23032573),
        dec: Angle.Degrees(+16.08137483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116173"},
        {"Hipparcos Number", "HIP 65197"},
        {"Geneva Identification System", "GEN# +1.00116173"},
        {"Smithsonian Astrophysical Observation", "SAO 100531"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.41978943),
        dec: Angle.Degrees(+16.08152653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106912"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.78984848),
        dec: Angle.Degrees(+16.08237548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13595"},
        {"Hipparcos Number", "HIP 10330"},
        {"Smithsonian Astrophysical Observation", "SAO 92842"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.27124559),
        dec: Angle.Degrees(+16.08554027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38219"},
        {"Hipparcos Number", "HIP 27106"},
        {"Celescope Catalog", "CEL 955"},
        {"Smithsonian Astrophysical Observation", "SAO 94823"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.22185318),
        dec: Angle.Degrees(+16.08611320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285690"},
        {"Hipparcos Number", "HIP 20082"},
        {"Geneva Identification System", "GEN# +5.20250025"},
        {"Smithsonian Astrophysical Observation", "SAO 93850"},
        {"Wilson Evans Batten Catalogue", "WEB 3835"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.57999804),
        dec: Angle.Degrees(+16.08838854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285260"},
        {"Hipparcos Number", "HIP 18227"},
        {"Smithsonian Astrophysical Observation", "SAO 93656"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.45243361),
        dec: Angle.Degrees(+16.08888230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154974"},
        {"Hipparcos Number", "HIP 83855"},
        {"Geneva Identification System", "GEN# +1.00154974"},
        {"Smithsonian Astrophysical Observation", "SAO 102611"},
        {"Wilson Evans Batten Catalogue", "WEB 14172"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.06566275),
        dec: Angle.Degrees(+16.09396007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192145"},
        {"Hipparcos Number", "HIP 99607"},
        {"Geneva Identification System", "GEN# +1.00192145"},
        {"Smithsonian Astrophysical Observation", "SAO 105841"},
        {"Wilson Evans Batten Catalogue", "WEB 17836"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.21219426),
        dec: Angle.Degrees(+16.09548395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7952 AB"},
        {"Henry Draper", "HD 94120"},
        {"Hipparcos Number", "HIP 53124"},
        {"Smithsonian Astrophysical Observation", "SAO 99331"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.01225183),
        dec: Angle.Degrees(+16.09556253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113712"},
        {"Hipparcos Number", "HIP 63881"},
        {"Geneva Identification System", "GEN# +1.00113712"},
        {"Smithsonian Astrophysical Observation", "SAO 100408"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.37381202),
        dec: Angle.Degrees(+16.09593960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37242"},
        {"Smithsonian Astrophysical Observation", "SAO 97112"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.73040971),
        dec: Angle.Degrees(+16.09646773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40130",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6648 AB"},
        {"Henry Draper", "HD 68169"},
        {"Hipparcos Number", "HIP 40130"},
        {"Smithsonian Astrophysical Observation", "SAO 97639"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95325638),
        dec: Angle.Degrees(+16.09786853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87863"},
        {"Smithsonian Astrophysical Observation", "SAO 103237"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.22779737),
        dec: Angle.Degrees(+16.09836160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157050"},
        {"Hipparcos Number", "HIP 84843"},
        {"Geneva Identification System", "GEN# +1.00157050"},
        {"Smithsonian Astrophysical Observation", "SAO 102758"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.10372520),
        dec: Angle.Degrees(+16.09919209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147867"},
        {"Hipparcos Number", "HIP 80317"},
        {"Geneva Identification System", "GEN# +1.00147867"},
        {"Smithsonian Astrophysical Observation", "SAO 102129"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.96933441),
        dec: Angle.Degrees(+16.10103810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72944"},
        {"Geneva Identification System", "GEN# +0.01602708"},
        {"Wilson Evans Batten Catalogue", "WEB 12519"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.62112279),
        dec: Angle.Degrees(+16.10135877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16983"},
        {"Hipparcos Number", "HIP 12742"},
        {"Smithsonian Astrophysical Observation", "SAO 93076"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.95460231),
        dec: Angle.Degrees(+16.10414914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12117 AB"},
        {"Henry Draper", "HD 178995"},
        {"Hipparcos Number", "HIP 94173"},
        {"Smithsonian Astrophysical Observation", "SAO 104552"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.54958207),
        dec: Angle.Degrees(+16.10539959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150568"},
        {"Hipparcos Number", "HIP 81707"},
        {"Smithsonian Astrophysical Observation", "SAO 102318"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.34422067),
        dec: Angle.Degrees(+16.10657658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60684"},
    },
    visualMagnitude: 10.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.54876468),
        dec: Angle.Degrees(+16.11295481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31108"},
        {"Wilson Evans Batten Catalogue", "WEB 6201"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.91559036),
        dec: Angle.Degrees(+16.11450343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117189"},
        {"Hipparcos Number", "HIP 65733"},
        {"Geneva Identification System", "GEN# +1.00117189"},
        {"Smithsonian Astrophysical Observation", "SAO 100584"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11691970),
        dec: Angle.Degrees(+16.11793424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126945"},
        {"Hipparcos Number", "HIP 70760"},
        {"Geneva Identification System", "GEN# +1.00126945"},
        {"Smithsonian Astrophysical Observation", "SAO 101037"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.06284471),
        dec: Angle.Degrees(+16.11906896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139225"},
        {"Hipparcos Number", "HIP 76424"},
        {"Geneva Identification System", "GEN# +1.00139225"},
        {"Smithsonian Astrophysical Observation", "SAO 101642"},
        {"Wilson Evans Batten Catalogue", "WEB 12976"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.12164831),
        dec: Angle.Degrees(+16.11909820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69788"},
        {"Hipparcos Number", "HIP 40754"},
        {"Smithsonian Astrophysical Observation", "SAO 97725"},
        {"Wilson Evans Batten Catalogue", "WEB 7910"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.78624939),
        dec: Angle.Degrees(+16.12189591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111893"},
        {"Hipparcos Number", "HIP 62825"},
        {"Geneva Identification System", "GEN# +1.00111893"},
        {"Smithsonian Astrophysical Observation", "SAO 100312"},
        {"Wilson Evans Batten Catalogue", "WEB 11141"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.11468032),
        dec: Angle.Degrees(+16.12252624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13145"},
        {"Smithsonian Astrophysical Observation", "SAO 93125"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.26740062),
        dec: Angle.Degrees(+16.12279163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108319",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15475 A"},
        {"Henry Draper", "HD 208552"},
        {"Hipparcos Number", "HIP 108319"},
        {"Smithsonian Astrophysical Observation", "SAO 107526"},
        {"Wilson Evans Batten Catalogue", "WEB 19511"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.16854049),
        dec: Angle.Degrees(+16.12377583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204277"},
        {"Hipparcos Number", "HIP 105918"},
        {"Fundamental Katalog 5th Edition", "FK5 3713"},
        {"Geneva Identification System", "GEN# +1.00204277"},
        {"Smithsonian Astrophysical Observation", "SAO 107142"},
        {"Wilson Evans Batten Catalogue", "WEB 19206"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.77775816),
        dec: Angle.Degrees(+16.12438738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14279 B"},
        {"Henry Draper", "HD 197963"},
        {"Hipparcos Number", "HIP 102531"},
        {"Geneva Identification System", "GEN# +1.00197963"},
        {"Smithsonian Astrophysical Observation", "SAO 106475"},
        {"Wilson Evans Batten Catalogue", "WEB 18573"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.66194885),
        dec: Angle.Degrees(+16.12462394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14279 A"},
        {"Henry Draper", "HD 197964"},
        {"Hipparcos Number", "HIP 102532"},
        {"Fundamental Katalog 5th Edition", "FK5 1541"},
        {"Geneva Identification System", "GEN# +1.00197964A"},
        {"Smithsonian Astrophysical Observation", "SAO 106476"},
        {"Wilson Evans Batten Catalogue", "WEB 18576"},
    },
    visualMagnitude: 4.27,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.66465833),
        dec: Angle.Degrees(+16.12477326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15258"},
        {"Hipparcos Number", "HIP 11457"},
        {"Smithsonian Astrophysical Observation", "SAO 92958"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.94556803),
        dec: Angle.Degrees(+16.12486232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92196"},
        {"Hipparcos Number", "HIP 52120"},
        {"Fundamental Katalog 5th Edition", "FK5 2851"},
        {"Geneva Identification System", "GEN# +1.00092196"},
        {"Smithsonian Astrophysical Observation", "SAO 99229"},
        {"Wilson Evans Batten Catalogue", "WEB 9499"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.72708494),
        dec: Angle.Degrees(+16.12747716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102212"},
        {"Smithsonian Astrophysical Observation", "SAO 106412"},
        {"Wilson Evans Batten Catalogue", "WEB 18495"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.65762154),
        dec: Angle.Degrees(+16.12840883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9510"},
        {"Hipparcos Number", "HIP 7265"},
        {"Smithsonian Astrophysical Observation", "SAO 92511"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.40086872),
        dec: Angle.Degrees(+16.13044281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42545"},
        {"Hipparcos Number", "HIP 29434"},
        {"Celescope Catalog", "CEL 1116"},
        {"Geneva Identification System", "GEN# +1.00042545"},
        {"Smithsonian Astrophysical Observation", "SAO 95365"},
        {"Wilson Evans Batten Catalogue", "WEB 5786"},
    },
    visualMagnitude: 4.95,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.01365054),
        dec: Angle.Degrees(+16.13044684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102627"},
        {"Hipparcos Number", "HIP 57630"},
        {"Geneva Identification System", "GEN# +1.00102627"},
        {"Smithsonian Astrophysical Observation", "SAO 99806"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.25774766),
        dec: Angle.Degrees(+16.13241626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7374"},
        {"Hipparcos Number", "HIP 5778"},
        {"Fundamental Katalog 5th Edition", "FK5 2083"},
        {"Geneva Identification System", "GEN# +1.00007374"},
        {"Renson", "Renson 1850"},
        {"Smithsonian Astrophysical Observation", "SAO 92326"},
        {"Wilson Evans Batten Catalogue", "WEB 1318"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.53186747),
        dec: Angle.Degrees(+16.13354221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164853"},
        {"Hipparcos Number", "HIP 88359"},
        {"Geneva Identification System", "GEN# +1.00164853"},
        {"Smithsonian Astrophysical Observation", "SAO 103321"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65321247),
        dec: Angle.Degrees(+16.13457109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54130"},
        {"Hipparcos Number", "HIP 34437"},
        {"Geneva Identification System", "GEN# +1.00054130"},
        {"Smithsonian Astrophysical Observation", "SAO 96534"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09098994),
        dec: Angle.Degrees(+16.13507584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6185"},
        {"Hipparcos Number", "HIP 4912"},
        {"Smithsonian Astrophysical Observation", "SAO 92219"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.75729971),
        dec: Angle.Degrees(+16.13527205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88748"},
        {"Hipparcos Number", "HIP 50175"},
        {"Smithsonian Astrophysical Observation", "SAO 99019"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.63244199),
        dec: Angle.Degrees(+16.13836786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168959"},
        {"Hipparcos Number", "HIP 90002"},
        {"Geneva Identification System", "GEN# +1.00168959"},
        {"Smithsonian Astrophysical Observation", "SAO 103641"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.45508124),
        dec: Angle.Degrees(+16.13936677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141933"},
        {"Hipparcos Number", "HIP 77653"},
        {"Smithsonian Astrophysical Observation", "SAO 101775"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.79475572),
        dec: Angle.Degrees(+16.13963135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57048"},
        {"Hipparcos Number", "HIP 35551"},
        {"Smithsonian Astrophysical Observation", "SAO 96786"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.03989875),
        dec: Angle.Degrees(+16.14035963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262397"},
        {"Hipparcos Number", "HIP 32150"},
        {"Smithsonian Astrophysical Observation", "SAO 96030"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.71453101),
        dec: Angle.Degrees(+16.14041039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117618"},
        {"Smithsonian Astrophysical Observation", "SAO 108870"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.81013833),
        dec: Angle.Degrees(+16.14080442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73578"},
        {"Hipparcos Number", "HIP 42480"},
        {"Smithsonian Astrophysical Observation", "SAO 98007"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.91510873),
        dec: Angle.Degrees(+16.14162841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130538"},
        {"Hipparcos Number", "HIP 72414"},
        {"Geneva Identification System", "GEN# +1.00130538"},
        {"Smithsonian Astrophysical Observation", "SAO 101224"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.10080122),
        dec: Angle.Degrees(+16.14283383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43153"},
        {"Hipparcos Number", "HIP 29704"},
        {"Celescope Catalog", "CEL 1142"},
        {"Geneva Identification System", "GEN# +1.00043153"},
        {"Smithsonian Astrophysical Observation", "SAO 95447"},
        {"Wilson Evans Batten Catalogue", "WEB 5851"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.85469568),
        dec: Angle.Degrees(+16.14320591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194337"},
        {"Hipparcos Number", "HIP 100658"},
        {"Smithsonian Astrophysical Observation", "SAO 106073"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.14878957),
        dec: Angle.Degrees(+16.14371682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56200"},
        {"Hipparcos Number", "HIP 35219"},
        {"Geneva Identification System", "GEN# +1.00056200"},
        {"Smithsonian Astrophysical Observation", "SAO 96712"},
        {"Wilson Evans Batten Catalogue", "WEB 7036"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.18560312),
        dec: Angle.Degrees(+16.14706747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114380"},
        {"Hipparcos Number", "HIP 64243"},
        {"Geneva Identification System", "GEN# +1.00114380"},
        {"Smithsonian Astrophysical Observation", "SAO 100442"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.50186334),
        dec: Angle.Degrees(+16.14795564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28568"},
        {"Hipparcos Number", "HIP 21053"},
        {"Celescope Catalog", "CEL 420"},
        {"Geneva Identification System", "GEN# +5.20250085"},
        {"Smithsonian Astrophysical Observation", "SAO 93981"},
        {"Wilson Evans Batten Catalogue", "WEB 4051"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.69473555),
        dec: Angle.Degrees(+16.14875140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94703"},
        {"Hipparcos Number", "HIP 53453"},
        {"Geneva Identification System", "GEN# +1.00094703"},
        {"Smithsonian Astrophysical Observation", "SAO 99359"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.02029221),
        dec: Angle.Degrees(+16.15005635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212516"},
        {"Hipparcos Number", "HIP 110617"},
        {"Smithsonian Astrophysical Observation", "SAO 107890"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.14346859),
        dec: Angle.Degrees(+16.15014602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105159"},
        {"Cincinnati Publication", "Ci 18 2766"},
        {"Smithsonian Astrophysical Observation", "SAO 107008"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.54286386),
        dec: Angle.Degrees(+16.15085898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83320"},
        {"Geneva Identification System", "GEN# +9.80139008"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.43398383),
        dec: Angle.Degrees(+16.15152539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59995"},
        {"Geneva Identification System", "GEN# +0.01602356"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.56674418),
        dec: Angle.Degrees(+16.15448231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147927"},
        {"Hipparcos Number", "HIP 80348"},
        {"Geneva Identification System", "GEN# +1.00147927"},
        {"Smithsonian Astrophysical Observation", "SAO 102135"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.03791159),
        dec: Angle.Degrees(+16.15608513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201547"},
        {"Hipparcos Number", "HIP 104478"},
        {"Smithsonian Astrophysical Observation", "SAO 106884"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.46737066),
        dec: Angle.Degrees(+16.15761933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99689",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13542 AB"},
        {"Henry Draper", "HD 192324"},
        {"Hipparcos Number", "HIP 99689"},
        {"Smithsonian Astrophysical Observation", "SAO 105861"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.43724117),
        dec: Angle.Degrees(+16.15794496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55383"},
        {"Hipparcos Number", "HIP 34909"},
        {"Fundamental Katalog 5th Edition", "FK5 1188"},
        {"Geneva Identification System", "GEN# +1.00055383"},
        {"Smithsonian Astrophysical Observation", "SAO 96638"},
        {"Wilson Evans Batten Catalogue", "WEB 6978"},
    },
    visualMagnitude: 5.07,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.34277923),
        dec: Angle.Degrees(+16.15906775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3248 AB"},
        {"Henry Draper", "HD 28363"},
        {"Hipparcos Number", "HIP 20916"},
        {"Celescope Catalog", "CEL 411"},
        {"Geneva Identification System", "GEN# +5.20250075J"},
        {"Smithsonian Astrophysical Observation", "SAO 93961"},
        {"Wilson Evans Batten Catalogue", "WEB 4019"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.24882218),
        dec: Angle.Degrees(+16.15915391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78560"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.61127831),
        dec: Angle.Degrees(+16.33033458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132881"},
        {"Hipparcos Number", "HIP 73482"},
        {"Smithsonian Astrophysical Observation", "SAO 101329"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25874457),
        dec: Angle.Degrees(+16.15920992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94688",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12236 AB"},
        {"Henry Draper", "HD 180451"},
        {"Hipparcos Number", "HIP 94688"},
        {"Geneva Identification System", "GEN# +1.00180451J"},
        {"Smithsonian Astrophysical Observation", "SAO 104666"},
        {"Wilson Evans Batten Catalogue", "WEB 16510"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.00766882),
        dec: Angle.Degrees(+16.16096373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70433"},
        {"Hipparcos Number", "HIP 41040"},
        {"Smithsonian Astrophysical Observation", "SAO 97773"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.63289874),
        dec: Angle.Degrees(+16.16253239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14596"},
        {"Hipparcos Number", "HIP 11015"},
        {"Geneva Identification System", "GEN# +1.00014596"},
        {"Smithsonian Astrophysical Observation", "SAO 92901"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.45952210),
        dec: Angle.Degrees(+16.16259036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211837"},
        {"Hipparcos Number", "HIP 110225"},
        {"Geneva Identification System", "GEN# +1.00211837"},
        {"Smithsonian Astrophysical Observation", "SAO 107832"},
        {"Wilson Evans Batten Catalogue", "WEB 19780"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.91830042),
        dec: Angle.Degrees(+16.16292703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59203"},
        {"Hipparcos Number", "HIP 36406"},
        {"Smithsonian Astrophysical Observation", "SAO 96947"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.36725067),
        dec: Angle.Degrees(+16.16409750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19833"},
        {"Hipparcos Number", "HIP 14863"},
        {"Geneva Identification System", "GEN# +1.00019833"},
        {"Smithsonian Astrophysical Observation", "SAO 93331"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.98478770),
        dec: Angle.Degrees(+16.16600177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7616"},
        {"Hipparcos Number", "HIP 5932"},
        {"Geneva Identification System", "GEN# +1.00007616"},
        {"Smithsonian Astrophysical Observation", "SAO 92342"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.06712973),
        dec: Angle.Degrees(+16.16662426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53139"},
        {"Smithsonian Astrophysical Observation", "SAO 99333"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04948738),
        dec: Angle.Degrees(+16.16716329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2595",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 458 A"},
        {"Henry Draper", "HD 2954"},
        {"Hipparcos Number", "HIP 2595"},
        {"Geneva Identification System", "GEN# +1.00002954"},
        {"Smithsonian Astrophysical Observation", "SAO 91956"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.23246252),
        dec: Angle.Degrees(+16.16716854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7601 AB"},
        {"Henry Draper", "HD 86609"},
        {"Hipparcos Number", "HIP 49011"},
        {"Smithsonian Astrophysical Observation", "SAO 98888"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.98279874),
        dec: Angle.Degrees(+16.16908759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108155"},
        {"Hipparcos Number", "HIP 60621"},
        {"Geneva Identification System", "GEN# +1.00108155"},
        {"Smithsonian Astrophysical Observation", "SAO 100091"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.36451758),
        dec: Angle.Degrees(+16.17142046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148347"},
        {"Hipparcos Number", "HIP 80555"},
        {"Smithsonian Astrophysical Observation", "SAO 102178"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.70619574),
        dec: Angle.Degrees(+16.17179567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61253"},
        {"Hipparcos Number", "HIP 37254"},
        {"Smithsonian Astrophysical Observation", "SAO 97114"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.76388417),
        dec: Angle.Degrees(+16.17568119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41615"},
        {"Hipparcos Number", "HIP 28980"},
        {"Smithsonian Astrophysical Observation", "SAO 95245"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73397909),
        dec: Angle.Degrees(+16.17711051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86207"},
        {"Smithsonian Astrophysical Observation", "SAO 102968"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.24411764),
        dec: Angle.Degrees(+16.17726139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52974"},
        {"Hipparcos Number", "HIP 34057"},
        {"Smithsonian Astrophysical Observation", "SAO 96431"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.96996434),
        dec: Angle.Degrees(+16.18226569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69482"},
        {"Smithsonian Astrophysical Observation", "SAO 100919"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.36808930),
        dec: Angle.Degrees(+16.18455873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136440"},
        {"Hipparcos Number", "HIP 75048"},
        {"Geneva Identification System", "GEN# +1.00136440"},
        {"Smithsonian Astrophysical Observation", "SAO 101493"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.03574014),
        dec: Angle.Degrees(+16.18546024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191785"},
        {"Hipparcos Number", "HIP 99452"},
        {"Cincinnati Publication", "Ci 20 1195"},
        {"Geneva Identification System", "GEN# +1.00191785A"},
        {"Smithsonian Astrophysical Observation", "SAO 105793"},
        {"Wilson Evans Batten Catalogue", "WEB 17768"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.77635847),
        dec: Angle.Degrees(+16.18702943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -414.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 399.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7563"},
        {"Hipparcos Number", "HIP 5909"},
        {"Geneva Identification System", "GEN# +1.00007563"},
        {"Smithsonian Astrophysical Observation", "SAO 92337"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.98325134),
        dec: Angle.Degrees(+16.19009821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32200"},
        {"Hipparcos Number", "HIP 23423"},
        {"Smithsonian Astrophysical Observation", "SAO 94276"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.51014003),
        dec: Angle.Degrees(+16.19074669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138157"},
        {"Hipparcos Number", "HIP 75861"},
        {"Smithsonian Astrophysical Observation", "SAO 101580"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.43529908),
        dec: Angle.Degrees(+16.19198392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173173"},
        {"Hipparcos Number", "HIP 91831"},
        {"Geneva Identification System", "GEN# +1.00173173"},
        {"Smithsonian Astrophysical Observation", "SAO 104026"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.84450498),
        dec: Angle.Degrees(+16.19320550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28527"},
        {"Hipparcos Number", "HIP 21029"},
        {"Celescope Catalog", "CEL 416"},
        {"Geneva Identification System", "GEN# +5.20250082"},
        {"Renson", "Renson 7324"},
        {"Smithsonian Astrophysical Observation", "SAO 93975"},
        {"Wilson Evans Batten Catalogue", "WEB 4045"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.63987124),
        dec: Angle.Degrees(+16.19407556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108079"},
        {"Hipparcos Number", "HIP 60566"},
        {"Geneva Identification System", "GEN# +1.00108079"},
        {"Smithsonian Astrophysical Observation", "SAO 100088"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.22692223),
        dec: Angle.Degrees(+16.19478131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115183"},
        {"Hipparcos Number", "HIP 64666"},
        {"Geneva Identification System", "GEN# +1.00115183"},
        {"Smithsonian Astrophysical Observation", "SAO 100478"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.82725072),
        dec: Angle.Degrees(+16.19481528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13884"},
        {"Hipparcos Number", "HIP 10521"},
        {"Geneva Identification System", "GEN# +1.00013884"},
        {"Smithsonian Astrophysical Observation", "SAO 92859"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.89687565),
        dec: Angle.Degrees(+16.19508995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180216"},
        {"Hipparcos Number", "HIP 94606"},
        {"Smithsonian Astrophysical Observation", "SAO 104650"},
        {"Wilson Evans Batten Catalogue", "WEB 16486"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.78670045),
        dec: Angle.Degrees(+16.19719564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205498"},
        {"Hipparcos Number", "HIP 106593"},
        {"Smithsonian Astrophysical Observation", "SAO 107256"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.82731904),
        dec: Angle.Degrees(+16.19738598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106120"},
        {"Smithsonian Astrophysical Observation", "SAO 107176"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.43001666),
        dec: Angle.Degrees(+16.19817497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171994"},
        {"Hipparcos Number", "HIP 91279"},
        {"Geneva Identification System", "GEN# +1.00171994"},
        {"Smithsonian Astrophysical Observation", "SAO 103913"},
        {"Wilson Evans Batten Catalogue", "WEB 15685"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.28771035),
        dec: Angle.Degrees(+16.19817678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218132"},
        {"Hipparcos Number", "HIP 114020"},
        {"Smithsonian Astrophysical Observation", "SAO 108389"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.36340230),
        dec: Angle.Degrees(+16.19822249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21568"},
        {"Hipparcos Number", "HIP 16241"},
        {"Geneva Identification System", "GEN# +1.00021568"},
        {"Smithsonian Astrophysical Observation", "SAO 93452"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.33155528),
        dec: Angle.Degrees(+16.19845534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121880"},
        {"Hipparcos Number", "HIP 68209"},
        {"Geneva Identification System", "GEN# +1.00121880"},
        {"Smithsonian Astrophysical Observation", "SAO 100795"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.46713204),
        dec: Angle.Degrees(+16.20222061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353453"},
        {"Hipparcos Number", "HIP 96975"},
        {"Smithsonian Astrophysical Observation", "SAO 105177"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.68113999),
        dec: Angle.Degrees(+16.20230150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49606"},
        {"Hipparcos Number", "HIP 32753"},
        {"Fundamental Katalog 5th Edition", "FK5 2526"},
        {"Geneva Identification System", "GEN# +1.00049606"},
        {"Renson", "Renson 13440"},
        {"Smithsonian Astrophysical Observation", "SAO 96161"},
        {"Wilson Evans Batten Catalogue", "WEB 6593"},
    },
    visualMagnitude: 5.87,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.45768904),
        dec: Angle.Degrees(+16.20291318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115437"},
        {"Smithsonian Astrophysical Observation", "SAO 108577"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.74163962),
        dec: Angle.Degrees(+16.20344452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46594"},
        {"Hipparcos Number", "HIP 31396"},
        {"Geneva Identification System", "GEN# +1.00046594"},
        {"Smithsonian Astrophysical Observation", "SAO 95860"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.72366782),
        dec: Angle.Degrees(+16.20580284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97387"},
        {"Hipparcos Number", "HIP 54758"},
        {"Smithsonian Astrophysical Observation", "SAO 99499"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.16592448),
        dec: Angle.Degrees(+16.20767398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127227"},
        {"Hipparcos Number", "HIP 70899"},
        {"Geneva Identification System", "GEN# +1.00127227"},
        {"Smithsonian Astrophysical Observation", "SAO 101053"},
        {"Wilson Evans Batten Catalogue", "WEB 12275"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.47380935),
        dec: Angle.Degrees(+16.20881829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30738"},
        {"Hipparcos Number", "HIP 22524"},
        {"Geneva Identification System", "GEN# +5.20250121"},
        {"Smithsonian Astrophysical Observation", "SAO 94162"},
        {"Wilson Evans Batten Catalogue", "WEB 4345"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.70205504),
        dec: Angle.Degrees(+16.21051508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112736"},
        {"Hipparcos Number", "HIP 63345"},
        {"Geneva Identification System", "GEN# +1.00112736"},
        {"Smithsonian Astrophysical Observation", "SAO 100355"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.70697551),
        dec: Angle.Degrees(+16.21095409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143257"},
        {"Hipparcos Number", "HIP 78262"},
        {"Smithsonian Astrophysical Observation", "SAO 101846"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.70456464),
        dec: Angle.Degrees(+16.21115423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72239"},
        {"Hipparcos Number", "HIP 41879"},
        {"Smithsonian Astrophysical Observation", "SAO 97894"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.08049883),
        dec: Angle.Degrees(+16.21284361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27029"},
        {"Hipparcos Number", "HIP 19960"},
        {"Geneva Identification System", "GEN# +1.00027029"},
        {"Smithsonian Astrophysical Observation", "SAO 93838"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.20293208),
        dec: Angle.Degrees(+16.21444641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49306"},
        {"Smithsonian Astrophysical Observation", "SAO 98930"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.96785124),
        dec: Angle.Degrees(+16.21607761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192045"},
        {"Hipparcos Number", "HIP 99563"},
        {"Geneva Identification System", "GEN# +1.00192045"},
        {"Smithsonian Astrophysical Observation", "SAO 105828"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.07683393),
        dec: Angle.Degrees(+16.21710369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150175"},
        {"Hipparcos Number", "HIP 81494"},
        {"Smithsonian Astrophysical Observation", "SAO 102288"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.67796898),
        dec: Angle.Degrees(+16.21764591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68122"},
        {"Hipparcos Number", "HIP 40115"},
        {"Geneva Identification System", "GEN# +1.00068122"},
        {"Smithsonian Astrophysical Observation", "SAO 97636"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.90311318),
        dec: Angle.Degrees(+16.21767041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116091",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16812 A"},
        {"Henry Draper", "HD 221355"},
        {"Hipparcos Number", "HIP 116091"},
        {"Geneva Identification System", "GEN# +1.00221355"},
        {"Smithsonian Astrophysical Observation", "SAO 108659"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.85272211),
        dec: Angle.Degrees(+16.21876940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81496"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.68626063),
        dec: Angle.Degrees(+16.21972780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109478"},
        {"Smithsonian Astrophysical Observation", "SAO 107714"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.68129541),
        dec: Angle.Degrees(+16.22095742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69978"},
        {"Hipparcos Number", "HIP 40835"},
        {"Smithsonian Astrophysical Observation", "SAO 97731"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00552277),
        dec: Angle.Degrees(+16.22346993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58657"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.42467681),
        dec: Angle.Degrees(+16.22483320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7456 AB"},
        {"Henry Draper", "HD 83190"},
        {"Hipparcos Number", "HIP 47196"},
        {"Smithsonian Astrophysical Observation", "SAO 98674"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.28152579),
        dec: Angle.Degrees(+16.22591512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112340"},
        {"Hipparcos Number", "HIP 63118"},
        {"Geneva Identification System", "GEN# +1.00112340"},
        {"Renson", "Renson 32624"},
        {"Smithsonian Astrophysical Observation", "SAO 100338"},
        {"Wilson Evans Batten Catalogue", "WEB 11190"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.98799437),
        dec: Angle.Degrees(+16.22771958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11385 AB"},
        {"Hipparcos Number", "HIP 90554"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.16576920),
        dec: Angle.Degrees(+16.22865557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217732"},
        {"Hipparcos Number", "HIP 113787"},
        {"Smithsonian Astrophysical Observation", "SAO 108356"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.64655902),
        dec: Angle.Degrees(+16.23241510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76573"},
        {"Hipparcos Number", "HIP 44000"},
        {"Smithsonian Astrophysical Observation", "SAO 98249"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.39528491),
        dec: Angle.Degrees(+16.23378164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62044"},
        {"Smithsonian Astrophysical Observation", "SAO 100219"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.76612408),
        dec: Angle.Degrees(+16.23415191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138483"},
        {"Hipparcos Number", "HIP 76043"},
        {"Smithsonian Astrophysical Observation", "SAO 101597"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.95202584),
        dec: Angle.Degrees(+16.23449584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14410"},
        {"Hipparcos Number", "HIP 10875"},
        {"Geneva Identification System", "GEN# +1.00014410"},
        {"Smithsonian Astrophysical Observation", "SAO 92888"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.98752376),
        dec: Angle.Degrees(+16.23592098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45506"},
        {"Hipparcos Number", "HIP 30815"},
        {"Fundamental Katalog 5th Edition", "FK5 2494"},
        {"Geneva Identification System", "GEN# +1.00045506"},
        {"Smithsonian Astrophysical Observation", "SAO 95719"},
        {"Wilson Evans Batten Catalogue", "WEB 6143"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.11712064),
        dec: Angle.Degrees(+16.23850447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198109"},
        {"Hipparcos Number", "HIP 102611"},
        {"Geneva Identification System", "GEN# +1.00198109"},
        {"Smithsonian Astrophysical Observation", "SAO 106495"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.90968883),
        dec: Angle.Degrees(+16.23851822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6384"},
        {"Hipparcos Number", "HIP 5075"},
        {"Smithsonian Astrophysical Observation", "SAO 92229"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.22976036),
        dec: Angle.Degrees(+16.24225993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102660"},
        {"Hipparcos Number", "HIP 57646"},
        {"Geneva Identification System", "GEN# +1.00102660"},
        {"Renson", "Renson 29630"},
        {"Smithsonian Astrophysical Observation", "SAO 99812"},
        {"Wilson Evans Batten Catalogue", "WEB 10352"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.31152200),
        dec: Angle.Degrees(+16.24301299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107764"},
        {"Hipparcos Number", "HIP 60392"},
        {"Geneva Identification System", "GEN# +1.00107764"},
        {"Smithsonian Astrophysical Observation", "SAO 100067"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.74710098),
        dec: Angle.Degrees(+16.24348619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1563"},
        {"Hipparcos Number", "HIP 1595"},
        {"Geneva Identification System", "GEN# +1.00001563"},
        {"Smithsonian Astrophysical Observation", "SAO 91850"},
        {"Wilson Evans Batten Catalogue", "WEB 289"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.98451465),
        dec: Angle.Degrees(+16.25090005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199498"},
        {"Hipparcos Number", "HIP 103417"},
        {"Smithsonian Astrophysical Observation", "SAO 106690"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.29680479),
        dec: Angle.Degrees(+16.25140685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176441"},
        {"Hipparcos Number", "HIP 93252"},
        {"Geneva Identification System", "GEN# +1.00176441"},
        {"Smithsonian Astrophysical Observation", "SAO 104328"},
        {"Wilson Evans Batten Catalogue", "WEB 16169"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.92746028),
        dec: Angle.Degrees(+16.25287380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243998"},
        {"Hipparcos Number", "HIP 25629"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.12207051),
        dec: Angle.Degrees(+16.25326740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195154"},
        {"Hipparcos Number", "HIP 101047"},
        {"Smithsonian Astrophysical Observation", "SAO 106151"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.26347474),
        dec: Angle.Degrees(+16.25427078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67580"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.71493882),
        dec: Angle.Degrees(+16.25455125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20181"},
        {"Hipparcos Number", "HIP 15129"},
        {"Smithsonian Astrophysical Observation", "SAO 93358"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.77707896),
        dec: Angle.Degrees(+16.25540078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285263"},
        {"Hipparcos Number", "HIP 18425"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.09723745),
        dec: Angle.Degrees(+16.25548356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225001"},
        {"Hipparcos Number", "HIP 199"},
        {"Geneva Identification System", "GEN# +1.00225001"},
        {"Smithsonian Astrophysical Observation", "SAO 108979"},
        {"Wilson Evans Batten Catalogue", "WEB 33"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.63503230),
        dec: Angle.Degrees(+16.25655097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92317",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11711 AD"},
        {"Henry Draper", "HD 174224"},
        {"Hipparcos Number", "HIP 92317"},
        {"Smithsonian Astrophysical Observation", "SAO 104127"},
        {"Wilson Evans Batten Catalogue", "WEB 15933"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.22878352),
        dec: Angle.Degrees(+16.25663138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95897"},
        {"Hipparcos Number", "HIP 54089"},
        {"Fundamental Katalog 5th Edition", "FK5 4977"},
        {"Smithsonian Astrophysical Observation", "SAO 99422"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.02114702),
        dec: Angle.Degrees(+16.25665600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8626"},
        {"Hipparcos Number", "HIP 6649"},
        {"Geneva Identification System", "GEN# +1.00008626"},
        {"Smithsonian Astrophysical Observation", "SAO 92428"},
        {"Wilson Evans Batten Catalogue", "WEB 1452"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.32962314),
        dec: Angle.Degrees(+16.25708174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211733"},
        {"Hipparcos Number", "HIP 110166"},
        {"Smithsonian Astrophysical Observation", "SAO 107820"},
        {"Wilson Evans Batten Catalogue", "WEB 19772"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.71857463),
        dec: Angle.Degrees(+16.25797301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136924"},
        {"Hipparcos Number", "HIP 75269"},
        {"Cincinnati Publication", "Ci 18 2057"},
        {"Geneva Identification System", "GEN# +1.00136924"},
        {"Smithsonian Astrophysical Observation", "SAO 101512"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.68212366),
        dec: Angle.Degrees(+16.26131105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -387.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212500"},
        {"Hipparcos Number", "HIP 110600"},
        {"Geneva Identification System", "GEN# +1.00212500"},
        {"Smithsonian Astrophysical Observation", "SAO 107888"},
        {"Wilson Evans Batten Catalogue", "WEB 19822"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.10391377),
        dec: Angle.Degrees(+16.26300747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184502"},
        {"Hipparcos Number", "HIP 96254"},
        {"Geneva Identification System", "GEN# +1.00184502"},
        {"Smithsonian Astrophysical Observation", "SAO 104978"},
        {"Wilson Evans Batten Catalogue", "WEB 16870"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.57793534),
        dec: Angle.Degrees(+16.26501333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192289"},
        {"Hipparcos Number", "HIP 99670"},
        {"Smithsonian Astrophysical Observation", "SAO 105856"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.39487358),
        dec: Angle.Degrees(+16.26523187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8205"},
        {"Smithsonian Astrophysical Observation", "SAO 92616"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.37880091),
        dec: Angle.Degrees(+16.26608907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116317"},
        {"Hipparcos Number", "HIP 65277"},
        {"Geneva Identification System", "GEN# +1.00116317"},
        {"Smithsonian Astrophysical Observation", "SAO 100536"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68384962),
        dec: Angle.Degrees(+16.26677745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104883"},
        {"Hipparcos Number", "HIP 58893"},
        {"Smithsonian Astrophysical Observation", "SAO 99928"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.17670509),
        dec: Angle.Degrees(+16.26910133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41663"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.42159081),
        dec: Angle.Degrees(+16.27028053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154652"},
        {"Hipparcos Number", "HIP 83682"},
        {"Smithsonian Astrophysical Observation", "SAO 102593"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54670239),
        dec: Angle.Degrees(+16.27050202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209600"},
        {"Hipparcos Number", "HIP 108939"},
        {"Smithsonian Astrophysical Observation", "SAO 107632"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.06971545),
        dec: Angle.Degrees(+16.27056997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116363"},
        {"Hipparcos Number", "HIP 65297"},
        {"Geneva Identification System", "GEN# +1.00116363"},
        {"Renson", "Renson 33565"},
        {"Smithsonian Astrophysical Observation", "SAO 100540"},
        {"Wilson Evans Batten Catalogue", "WEB 11526"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.74449681),
        dec: Angle.Degrees(+16.27063139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118001"},
        {"Hipparcos Number", "HIP 66176"},
        {"Geneva Identification System", "GEN# +1.00118001"},
        {"Smithsonian Astrophysical Observation", "SAO 100618"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45809355),
        dec: Angle.Degrees(+16.27308862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167134"},
        {"Hipparcos Number", "HIP 89294"},
        {"Geneva Identification System", "GEN# +1.00167134"},
        {"Smithsonian Astrophysical Observation", "SAO 103495"},
        {"Wilson Evans Batten Catalogue", "WEB 15180"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.31530787),
        dec: Angle.Degrees(+16.27327829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195162"},
        {"Hipparcos Number", "HIP 101056"},
        {"Geneva Identification System", "GEN# +1.00195162"},
        {"Smithsonian Astrophysical Observation", "SAO 106153"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.29026469),
        dec: Angle.Degrees(+16.27364221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126269"},
        {"Henry Draper 2", "HD 126270"},
        {"Hipparcos Number", "HIP 70399"},
        {"Geneva Identification System", "GEN# +1.00126270"},
        {"Geneva Identification System 2", "GEN# +1.00126269"},
        {"Renson", "Renson 35990"},
        {"Smithsonian Astrophysical Observation", "SAO 101011"},
        {"Wilson Evans Batten Catalogue", "WEB 12218"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.04699679),
        dec: Angle.Degrees(+16.27365211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87775"},
        {"Hipparcos Number", "HIP 49627"},
        {"Smithsonian Astrophysical Observation", "SAO 98961"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.92816717),
        dec: Angle.Degrees(+16.27478429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215193"},
        {"Hipparcos Number", "HIP 112184"},
        {"Smithsonian Astrophysical Observation", "SAO 108128"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.81982517),
        dec: Angle.Degrees(+16.27760119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62258"},
        {"Hipparcos Number", "HIP 37662"},
        {"Smithsonian Astrophysical Observation", "SAO 97188"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.91447788),
        dec: Angle.Degrees(+16.27791869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110220"},
        {"Hipparcos Number", "HIP 61844"},
        {"Geneva Identification System", "GEN# +1.00110220"},
        {"Smithsonian Astrophysical Observation", "SAO 100201"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.12175185),
        dec: Angle.Degrees(+16.27931870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76542"},
        {"Hipparcos Number", "HIP 43975"},
        {"Geneva Identification System", "GEN# +1.00076542"},
        {"Smithsonian Astrophysical Observation", "SAO 98248"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.32738952),
        dec: Angle.Degrees(+16.28251421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230043"},
        {"Hipparcos Number", "HIP 92842"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.76718863),
        dec: Angle.Degrees(+16.28334618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156731"},
        {"Hipparcos Number", "HIP 84677"},
        {"Geneva Identification System", "GEN# +1.00156731"},
        {"Smithsonian Astrophysical Observation", "SAO 102727"},
        {"Wilson Evans Batten Catalogue", "WEB 14299"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.66576479),
        dec: Angle.Degrees(+16.28340062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48827"},
        {"Hipparcos Number", "HIP 32413"},
        {"Smithsonian Astrophysical Observation", "SAO 96085"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.49982991),
        dec: Angle.Degrees(+16.28343088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52363",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7890 AB"},
        {"Henry Draper", "HD 92648"},
        {"Hipparcos Number", "HIP 52363"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.53385872),
        dec: Angle.Degrees(+16.28429814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153015"},
        {"Hipparcos Number", "HIP 82892"},
        {"Geneva Identification System", "GEN# +1.00153015"},
        {"Smithsonian Astrophysical Observation", "SAO 102484"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.09185685),
        dec: Angle.Degrees(+16.28527529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186637"},
        {"Hipparcos Number", "HIP 97179"},
        {"Smithsonian Astrophysical Observation", "SAO 105211"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.27497096),
        dec: Angle.Degrees(+16.28579741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112874"},
        {"Hipparcos Number", "HIP 63416"},
        {"Geneva Identification System", "GEN# +1.00112874"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.92895624),
        dec: Angle.Degrees(+16.28732214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35266"},
        {"Smithsonian Astrophysical Observation", "SAO 96720"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.29050116),
        dec: Angle.Degrees(+16.29175719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113060"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.44548150),
        dec: Angle.Degrees(+16.29194212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18357"},
        {"Hipparcos Number", "HIP 13786"},
        {"Fundamental Katalog 5th Edition", "FK5 4269"},
        {"Smithsonian Astrophysical Observation", "SAO 93205"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.36918852),
        dec: Angle.Degrees(+16.29380727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40569"},
        {"Hipparcos Number", "HIP 28447"},
        {"Fundamental Katalog 5th Edition", "FK5 2456"},
        {"Geneva Identification System", "GEN# +1.00040569"},
        {"Smithsonian Astrophysical Observation", "SAO 95106"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.10116593),
        dec: Angle.Degrees(+16.29897876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157740"},
        {"Hipparcos Number", "HIP 85185"},
        {"Geneva Identification System", "GEN# +1.00157740"},
        {"Renson", "Renson 44300"},
        {"Smithsonian Astrophysical Observation", "SAO 102805"},
        {"Wilson Evans Batten Catalogue", "WEB 14384"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.13137304),
        dec: Angle.Degrees(+16.30107639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30284"},
        {"Hipparcos Number", "HIP 22225"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.70581929),
        dec: Angle.Degrees(+16.30160739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8369"},
        {"Hipparcos Number", "HIP 6464"},
        {"Geneva Identification System", "GEN# +1.00008369"},
        {"Smithsonian Astrophysical Observation", "SAO 92408"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.78744655),
        dec: Angle.Degrees(+16.30176269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2429 AB"},
        {"Hipparcos Number", "HIP 15134"},
        {"Geneva Identification System", "GEN# +0.01500452"},
        {"Smithsonian Astrophysical Observation", "SAO 93359"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.78156611),
        dec: Angle.Degrees(+16.30358652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179589"},
        {"Hipparcos Number", "HIP 94381"},
        {"Geneva Identification System", "GEN# +1.00179589"},
        {"Smithsonian Astrophysical Observation", "SAO 104604"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.15075185),
        dec: Angle.Degrees(+16.30513812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1431 AB"},
        {"Hipparcos Number", "HIP 8414"},
        {"Smithsonian Astrophysical Observation", "SAO 92641"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.13877382),
        dec: Angle.Degrees(+16.30608748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125560"},
        {"Hipparcos Number", "HIP 70027"},
        {"Fundamental Katalog 5th Edition", "FK5 3135"},
        {"Geneva Identification System", "GEN# +1.00125560"},
        {"Smithsonian Astrophysical Observation", "SAO 100980"},
        {"Wilson Evans Batten Catalogue", "WEB 12178"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.93883677),
        dec: Angle.Degrees(+16.30680118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117995"},
        {"Smithsonian Astrophysical Observation", "SAO 108913"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.01069921),
        dec: Angle.Degrees(+16.30697794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241599"},
        {"Hipparcos Number", "HIP 24292"},
        {"Geneva Identification System", "GEN# +9.80085053"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.19974178),
        dec: Angle.Degrees(+16.30770350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163242"},
        {"Hipparcos Number", "HIP 87683"},
        {"Smithsonian Astrophysical Observation", "SAO 103200"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.64032639),
        dec: Angle.Degrees(+16.30901675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145549"},
        {"Hipparcos Number", "HIP 79306"},
        {"Geneva Identification System", "GEN# +1.00145549"},
        {"Smithsonian Astrophysical Observation", "SAO 101990"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.78332508),
        dec: Angle.Degrees(+16.30916844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18144"},
        {"Hipparcos Number", "HIP 13601"},
        {"Geneva Identification System", "GEN# +1.00018144"},
        {"Smithsonian Astrophysical Observation", "SAO 93185"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.82200779),
        dec: Angle.Degrees(+16.30930363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216686"},
        {"Hipparcos Number", "HIP 113151"},
        {"Smithsonian Astrophysical Observation", "SAO 108248"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.69801866),
        dec: Angle.Degrees(+16.30941543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94219"},
        {"Hipparcos Number", "HIP 53177"},
        {"Geneva Identification System", "GEN# +1.00094219"},
        {"Smithsonian Astrophysical Observation", "SAO 99336"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.16896244),
        dec: Angle.Degrees(+16.31275902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152776"},
        {"Hipparcos Number", "HIP 82757"},
        {"Geneva Identification System", "GEN# +1.00152776"},
        {"Smithsonian Astrophysical Observation", "SAO 102469"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.70985827),
        dec: Angle.Degrees(+16.31312360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5675"},
        {"Hipparcos Number", "HIP 4573"},
        {"Smithsonian Astrophysical Observation", "SAO 92188"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.63222724),
        dec: Angle.Degrees(+16.31364598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139799"},
        {"Hipparcos Number", "HIP 76699"},
        {"Smithsonian Astrophysical Observation", "SAO 101670"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.91656598),
        dec: Angle.Degrees(+16.31391885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6527"},
        {"Hipparcos Number", "HIP 5185"},
        {"Geneva Identification System", "GEN# +1.00006527"},
        {"Smithsonian Astrophysical Observation", "SAO 92246"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.59370581),
        dec: Angle.Degrees(+16.31413064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1496"},
        {"Hipparcos Number", "HIP 1538"},
        {"Geneva Identification System", "GEN# +1.00001496"},
        {"Smithsonian Astrophysical Observation", "SAO 91843"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.79973773),
        dec: Angle.Degrees(+16.31487073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18773"},
        {"Hipparcos Number", "HIP 14089"},
        {"Smithsonian Astrophysical Observation", "SAO 93242"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.41909999),
        dec: Angle.Degrees(+16.31548746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159353"},
        {"Hipparcos Number", "HIP 85930"},
        {"Fundamental Katalog 5th Edition", "FK5 3394"},
        {"Geneva Identification System", "GEN# +1.00159353"},
        {"Smithsonian Astrophysical Observation", "SAO 102917"},
        {"Wilson Evans Batten Catalogue", "WEB 14502"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.41413313),
        dec: Angle.Degrees(+16.31770553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72984"},
        {"Hipparcos Number", "HIP 42208"},
        {"Geneva Identification System", "GEN# +1.00072984"},
        {"Smithsonian Astrophysical Observation", "SAO 97956"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09087314),
        dec: Angle.Degrees(+16.31778310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1431 C"},
        {"Henry Draper", "HD 11016"},
        {"Hipparcos Number", "HIP 8413"},
        {"Smithsonian Astrophysical Observation", "SAO 92639"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.13030909),
        dec: Angle.Degrees(+16.31850477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85302"},
        {"Hipparcos Number", "HIP 48340"},
        {"Smithsonian Astrophysical Observation", "SAO 98810"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.80726515),
        dec: Angle.Degrees(+16.32002513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55690"},
        {"Smithsonian Astrophysical Observation", "SAO 99595"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.16583510),
        dec: Angle.Degrees(+16.32033555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105211"},
        {"Smithsonian Astrophysical Observation", "SAO 107017"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.67671613),
        dec: Angle.Degrees(+16.32116288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101907"},
        {"Hipparcos Number", "HIP 57204"},
        {"Fundamental Katalog 5th Edition", "FK5 5039"},
        {"Geneva Identification System", "GEN# +1.00101907"},
        {"Smithsonian Astrophysical Observation", "SAO 99759"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.95007345),
        dec: Angle.Degrees(+16.32315142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28879"},
        {"Hipparcos Number", "HIP 21257"},
        {"Celescope Catalog", "CEL 429"},
        {"Geneva Identification System", "GEN# +1.00028879"},
        {"Smithsonian Astrophysical Observation", "SAO 94004"},
        {"Wilson Evans Batten Catalogue", "WEB 4085"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.40866078),
        dec: Angle.Degrees(+16.32337964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110493"},
    },
    visualMagnitude: 11.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.73698658),
        dec: Angle.Degrees(+16.32446057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219239"},
        {"Hipparcos Number", "HIP 114723"},
        {"Smithsonian Astrophysical Observation", "SAO 108480"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.57903575),
        dec: Angle.Degrees(+16.32770575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132070"},
        {"Hipparcos Number", "HIP 73137"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.20133456),
        dec: Angle.Degrees(+16.32894473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42"},
        {"Hipparcos Number", "HIP 451"},
        {"Smithsonian Astrophysical Observation", "SAO 91699"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.35116229),
        dec: Angle.Degrees(+16.32907717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1352"},
        {"Hipparcos Number", "HIP 1427"},
        {"Geneva Identification System", "GEN# +1.00001352"},
        {"Smithsonian Astrophysical Observation", "SAO 91825"},
        {"Wilson Evans Batten Catalogue", "WEB 259"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.45769929),
        dec: Angle.Degrees(+16.33108213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15564"},
        {"Smithsonian Astrophysical Observation", "SAO 93397"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.13570955),
        dec: Angle.Degrees(+16.33300742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185803"},
        {"Hipparcos Number", "HIP 96784"},
        {"Smithsonian Astrophysical Observation", "SAO 105122"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.09392697),
        dec: Angle.Degrees(+16.33338203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222683"},
        {"Hipparcos Number", "HIP 116972"},
        {"Fundamental Katalog 5th Edition", "FK5 3901"},
        {"Geneva Identification System", "GEN# +1.00222683"},
        {"Smithsonian Astrophysical Observation", "SAO 108782"},
        {"Wilson Evans Batten Catalogue", "WEB 20633"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.68253025),
        dec: Angle.Degrees(+16.33569249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7405"},
        {"Smithsonian Astrophysical Observation", "SAO 92526"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.85960083),
        dec: Angle.Degrees(+16.33740159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93077"},
        {"Hipparcos Number", "HIP 52580"},
        {"Geneva Identification System", "GEN# +1.00093077"},
        {"Smithsonian Astrophysical Observation", "SAO 99275"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.27828791),
        dec: Angle.Degrees(+16.33777802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134476"},
        {"Hipparcos Number", "HIP 74189"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.39866662),
        dec: Angle.Degrees(+16.33813306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41271"},
        {"Hipparcos Number", "HIP 28801"},
        {"Smithsonian Astrophysical Observation", "SAO 95198"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.20644586),
        dec: Angle.Degrees(+16.33857972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198934"},
        {"Hipparcos Number", "HIP 103085"},
        {"Smithsonian Astrophysical Observation", "SAO 106619"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.30666265),
        dec: Angle.Degrees(+16.34163512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105943"},
        {"Smithsonian Astrophysical Observation", "SAO 107149"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.84092323),
        dec: Angle.Degrees(+16.34354419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59926"},
        {"Hipparcos Number", "HIP 36689"},
        {"Smithsonian Astrophysical Observation", "SAO 97002"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.21093219),
        dec: Angle.Degrees(+16.34511398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39395"},
        {"Hipparcos Number", "HIP 27805"},
        {"Smithsonian Astrophysical Observation", "SAO 94955"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.26051535),
        dec: Angle.Degrees(+16.34567232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46561"},
        {"Smithsonian Astrophysical Observation", "SAO 98601"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.42751781),
        dec: Angle.Degrees(+16.34597434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5529"},
        {"Hipparcos Number", "HIP 4472"},
        {"Smithsonian Astrophysical Observation", "SAO 92176"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.32524909),
        dec: Angle.Degrees(+16.34816208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84293",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10408 A"},
        {"Henry Draper", "HD 155937"},
        {"Hipparcos Number", "HIP 84293"},
        {"Smithsonian Astrophysical Observation", "SAO 102668"},
        {"Wilson Evans Batten Catalogue", "WEB 14233"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.49086914),
        dec: Angle.Degrees(+16.35028627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51221"},
        {"Smithsonian Astrophysical Observation", "SAO 99137"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.93127935),
        dec: Angle.Degrees(+16.35152067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34304"},
        {"Hipparcos Number", "HIP 24634"},
        {"Geneva Identification System", "GEN# +1.00034304"},
        {"Smithsonian Astrophysical Observation", "SAO 94437"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.27336651),
        dec: Angle.Degrees(+16.35165523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144724"},
        {"Hipparcos Number", "HIP 78936"},
        {"Geneva Identification System", "GEN# +1.00144724"},
        {"Smithsonian Astrophysical Observation", "SAO 101931"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.71016378),
        dec: Angle.Degrees(+16.35253973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216047"},
        {"Hipparcos Number", "HIP 112704"},
        {"Geneva Identification System", "GEN# +1.00216047"},
        {"Smithsonian Astrophysical Observation", "SAO 108203"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.35720420),
        dec: Angle.Degrees(+16.35301690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69259"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.68037049),
        dec: Angle.Degrees(+16.35363797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7762"},
        {"Hipparcos Number", "HIP 6031"},
        {"Smithsonian Astrophysical Observation", "SAO 92349"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.37130387),
        dec: Angle.Degrees(+16.35413353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40005"},
        {"Hipparcos Number", "HIP 28142"},
        {"Celescope Catalog", "CEL 1042"},
        {"Geneva Identification System", "GEN# +1.00040005"},
        {"Smithsonian Astrophysical Observation", "SAO 95025"},
        {"Wilson Evans Batten Catalogue", "WEB 5504"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.21081024),
        dec: Angle.Degrees(+16.35508305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75842"},
        {"Hipparcos Number", "HIP 43613"},
        {"Geneva Identification System", "GEN# +1.00075842"},
        {"Smithsonian Astrophysical Observation", "SAO 98194"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.24477389),
        dec: Angle.Degrees(+16.35694714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60355"},
        {"Geneva Identification System", "GEN# +0.01702470"},
        {"Smithsonian Astrophysical Observation", "SAO 100066"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.63715158),
        dec: Angle.Degrees(+16.35826118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28292"},
        {"Hipparcos Number", "HIP 20877"},
        {"Geneva Identification System", "GEN# +1.00028292"},
        {"Smithsonian Astrophysical Observation", "SAO 93950"},
        {"Wilson Evans Batten Catalogue", "WEB 4005"},
    },
    visualMagnitude: 4.96,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.10985479),
        dec: Angle.Degrees(+16.35962902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91632"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.31168873),
        dec: Angle.Degrees(+16.35986781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22744"},
        {"Hipparcos Number", "HIP 17121"},
        {"Smithsonian Astrophysical Observation", "SAO 93542"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.00131318),
        dec: Angle.Degrees(+16.36019209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7608"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.50034497),
        dec: Angle.Degrees(+16.36175467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41602"},
        {"Hipparcos Number", "HIP 28978"},
        {"Smithsonian Astrophysical Observation", "SAO 95244"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73263865),
        dec: Angle.Degrees(+16.36672132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3694"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.83591302),
        dec: Angle.Degrees(+16.36995083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153313"},
        {"Hipparcos Number", "HIP 83033"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.51613766),
        dec: Angle.Degrees(+16.37003816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105740"},
        {"Hipparcos Number", "HIP 59334"},
        {"Geneva Identification System", "GEN# +1.00105740"},
        {"Smithsonian Astrophysical Observation", "SAO 99972"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.57074890),
        dec: Angle.Degrees(+16.37060182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48205"},
        {"Smithsonian Astrophysical Observation", "SAO 98791"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.41952351),
        dec: Angle.Degrees(+16.37062219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82856"},
        {"Smithsonian Astrophysical Observation", "SAO 102481"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.99910279),
        dec: Angle.Degrees(+16.37172720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219327"},
        {"Hipparcos Number", "HIP 114764"},
        {"Smithsonian Astrophysical Observation", "SAO 108487"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.71100620),
        dec: Angle.Degrees(+16.37176401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100451"},
        {"Smithsonian Astrophysical Observation", "SAO 106030"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55554917),
        dec: Angle.Degrees(+16.37299099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4754"},
        {"Geneva Identification System", "GEN# +0.01500150"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.27622879),
        dec: Angle.Degrees(+16.37301339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 340.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23501"},
        {"Hipparcos Number", "HIP 17610"},
        {"Geneva Identification System", "GEN# +1.00023501"},
        {"Smithsonian Astrophysical Observation", "SAO 93589"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.58553186),
        dec: Angle.Degrees(+16.37412822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187505"},
        {"Hipparcos Number", "HIP 97560"},
        {"Geneva Identification System", "GEN# +1.00187505"},
        {"Smithsonian Astrophysical Observation", "SAO 105320"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.43751002),
        dec: Angle.Degrees(+16.37551695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77218"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.48762947),
        dec: Angle.Degrees(+16.37573447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11054"},
        {"Hipparcos Number", "HIP 8448"},
        {"Geneva Identification System", "GEN# +1.00011054"},
        {"Smithsonian Astrophysical Observation", "SAO 92645"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.22733341),
        dec: Angle.Degrees(+16.37749140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99833"},
        {"Hipparcos Number", "HIP 56043"},
        {"Geneva Identification System", "GEN# +1.00099833"},
        {"Smithsonian Astrophysical Observation", "SAO 99624"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.29096107),
        dec: Angle.Degrees(+16.37918177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355469"},
        {"Hipparcos Number", "HIP 100446"},
        {"Smithsonian Astrophysical Observation", "SAO 106029"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55160314),
        dec: Angle.Degrees(+16.38038169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75021"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.94214003),
        dec: Angle.Degrees(+16.38250358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8231"},
        {"Hipparcos Number", "HIP 6373"},
        {"Smithsonian Astrophysical Observation", "SAO 92393"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.47418602),
        dec: Angle.Degrees(+16.38344251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157935"},
        {"Hipparcos Number", "HIP 85289"},
        {"Geneva Identification System", "GEN# +1.00157935"},
        {"Smithsonian Astrophysical Observation", "SAO 102816"},
        {"Wilson Evans Batten Catalogue", "WEB 14397"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.42040928),
        dec: Angle.Degrees(+16.38388884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57778"},
        {"Geneva Identification System", "GEN# +0.01702405"},
        {"Smithsonian Astrophysical Observation", "SAO 99826"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.72511265),
        dec: Angle.Degrees(+16.38397155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31268"},
        {"Hipparcos Number", "HIP 22846"},
        {"Smithsonian Astrophysical Observation", "SAO 94200"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.72836596),
        dec: Angle.Degrees(+16.38651534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95215"},
        {"Hipparcos Number", "HIP 53746"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.95109449),
        dec: Angle.Degrees(+16.38729827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132146"},
        {"Hipparcos Number", "HIP 73166"},
        {"Geneva Identification System", "GEN# +1.00132146"},
        {"Smithsonian Astrophysical Observation", "SAO 101299"},
        {"Wilson Evans Batten Catalogue", "WEB 12539"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.29866769),
        dec: Angle.Degrees(+16.38813986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211625"},
        {"Hipparcos Number", "HIP 110092"},
        {"Geneva Identification System", "GEN# +1.00211625"},
        {"Smithsonian Astrophysical Observation", "SAO 107808"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.52334507),
        dec: Angle.Degrees(+16.38904104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35591"},
        {"Smithsonian Astrophysical Observation", "SAO 96796"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.16727233),
        dec: Angle.Degrees(+16.38928709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37588"},
        {"Hipparcos Number", "HIP 26689"},
        {"Geneva Identification System", "GEN# +1.00037588"},
        {"Smithsonian Astrophysical Observation", "SAO 94743"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.07329557),
        dec: Angle.Degrees(+16.39321489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84470"},
        {"Smithsonian Astrophysical Observation", "SAO 102700"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.03913622),
        dec: Angle.Degrees(+16.39398527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11050 AB"},
        {"Henry Draper", "HD 165436"},
        {"Hipparcos Number", "HIP 88598"},
        {"Smithsonian Astrophysical Observation", "SAO 103367"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.35723260),
        dec: Angle.Degrees(+16.39507709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56276"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.05568071),
        dec: Angle.Degrees(+16.39523622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138085"},
        {"Hipparcos Number", "HIP 75810"},
        {"Geneva Identification System", "GEN# +1.00138085"},
        {"Smithsonian Astrophysical Observation", "SAO 101578"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.30056522),
        dec: Angle.Degrees(+16.39547022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66430"},
        {"Geneva Identification System", "GEN# +0.01702650"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.28302411),
        dec: Angle.Degrees(+16.39567984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47863"},
        {"Hipparcos Number", "HIP 32020"},
        {"Geneva Identification System", "GEN# +1.00047863"},
        {"Smithsonian Astrophysical Observation", "SAO 95996"},
        {"Wilson Evans Batten Catalogue", "WEB 6460"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.34143469),
        dec: Angle.Degrees(+16.39766033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217558"},
        {"Hipparcos Number", "HIP 113676"},
        {"Geneva Identification System", "GEN# +1.00217558"},
        {"Smithsonian Astrophysical Observation", "SAO 108336"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.35437648),
        dec: Angle.Degrees(+16.39772420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159907"},
        {"Hipparcos Number", "HIP 86176"},
        {"Smithsonian Astrophysical Observation", "SAO 102959"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.14990382),
        dec: Angle.Degrees(+16.39802563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29588"},
        {"Hipparcos Number", "HIP 21751"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.05297681),
        dec: Angle.Degrees(+16.39865881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11320"},
        {"Hipparcos Number", "HIP 8667"},
        {"Smithsonian Astrophysical Observation", "SAO 92663"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90934581),
        dec: Angle.Degrees(+16.39888990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31681",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alhena"},
        {"Henry Draper", "HD 47105"},
        {"Hipparcos Number", "HIP 31681"},
        {"Celescope Catalog", "CEL 1322"},
        {"Fundamental Katalog 5th Edition", "FK5 251"},
        {"Geneva Identification System", "GEN# +1.00047105"},
        {"Renson", "Renson 12640"},
        {"Smithsonian Astrophysical Observation", "SAO 95912"},
        {"Wilson Evans Batten Catalogue", "WEB 6349"},
    },
    visualMagnitude: 1.93,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42792641),
        dec: Angle.Degrees(+16.39941482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55626"},
        {"Smithsonian Astrophysical Observation", "SAO 99586"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.93939638),
        dec: Angle.Degrees(+16.39987745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121907"},
        {"Hipparcos Number", "HIP 68234"},
        {"Geneva Identification System", "GEN# +1.00121907"},
        {"Smithsonian Astrophysical Observation", "SAO 100796"},
        {"Wilson Evans Batten Catalogue", "WEB 11970"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.52625177),
        dec: Angle.Degrees(+16.40308139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152775"},
        {"Hipparcos Number", "HIP 82753"},
        {"Geneva Identification System", "GEN# +1.00152775"},
        {"Smithsonian Astrophysical Observation", "SAO 102468"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.70335898),
        dec: Angle.Degrees(+16.40546134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10164"},
        {"Hipparcos Number", "HIP 7740"},
        {"Geneva Identification System", "GEN# +1.00010164"},
        {"Smithsonian Astrophysical Observation", "SAO 92558"},
        {"Wilson Evans Batten Catalogue", "WEB 1663"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.91986640),
        dec: Angle.Degrees(+16.40588595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2021"},
        {"Hipparcos Number", "HIP 1949"},
        {"Geneva Identification System", "GEN# +1.00002021"},
        {"Smithsonian Astrophysical Observation", "SAO 91880"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.15981909),
        dec: Angle.Degrees(+16.40786865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188877"},
        {"Hipparcos Number", "HIP 98149"},
        {"Geneva Identification System", "GEN# +1.00188877"},
        {"Smithsonian Astrophysical Observation", "SAO 105449"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.19944542),
        dec: Angle.Degrees(+16.40879663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155526"},
        {"Hipparcos Number", "HIP 84096"},
        {"Geneva Identification System", "GEN# +1.00155526"},
        {"Smithsonian Astrophysical Observation", "SAO 102639"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.89033742),
        dec: Angle.Degrees(+16.41090328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86984"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.63114141),
        dec: Angle.Degrees(+16.41194101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105603"},
        {"Hipparcos Number", "HIP 59274"},
        {"Geneva Identification System", "GEN# +1.00105603"},
        {"Smithsonian Astrophysical Observation", "SAO 99966"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.38151821),
        dec: Angle.Degrees(+16.41269870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84281"},
        {"Hipparcos Number", "HIP 47784"},
        {"Smithsonian Astrophysical Observation", "SAO 98744"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.14286549),
        dec: Angle.Degrees(+16.41369888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9264 AB"},
        {"Henry Draper", "HD 126695"},
        {"Hipparcos Number", "HIP 70619"},
        {"Geneva Identification System", "GEN# +1.00126695J"},
        {"Smithsonian Astrophysical Observation", "SAO 101027"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.68281738),
        dec: Angle.Degrees(+16.41424438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114841"},
        {"Hipparcos Number", "HIP 64487"},
        {"Smithsonian Astrophysical Observation", "SAO 100464"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.27585479),
        dec: Angle.Degrees(+16.41542235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90877"},
        {"Smithsonian Astrophysical Observation", "SAO 103822"},
    },
    visualMagnitude: 9.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.06384486),
        dec: Angle.Degrees(+16.41629759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167277"},
        {"Hipparcos Number", "HIP 89350"},
        {"Geneva Identification System", "GEN# +1.00167277"},
        {"Smithsonian Astrophysical Observation", "SAO 103507"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.48062091),
        dec: Angle.Degrees(+16.41633845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67371"},
        {"Hipparcos Number", "HIP 39812"},
        {"Fundamental Katalog 5th Edition", "FK5 4731"},
        {"Geneva Identification System", "GEN# +1.00067371"},
        {"Smithsonian Astrophysical Observation", "SAO 97581"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.02879193),
        dec: Angle.Degrees(+16.41704654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44541"},
    },
    visualMagnitude: 10.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.13060327),
        dec: Angle.Degrees(+16.41739715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78451"},
        {"Hipparcos Number", "HIP 44894"},
        {"Geneva Identification System", "GEN# +1.00078451"},
        {"Smithsonian Astrophysical Observation", "SAO 98386"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.20542850),
        dec: Angle.Degrees(+16.41782584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9338 A"},
        {"Henry Draper", "HD 129174"},
        {"Hipparcos Number", "HIP 71762"},
        {"Geneva Identification System", "GEN# +1.00129174A"},
        {"Renson", "Renson 36820"},
        {"Smithsonian Astrophysical Observation", "SAO 101138"},
        {"Wilson Evans Batten Catalogue", "WEB 12364"},
    },
    visualMagnitude: 4.49,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.18150404),
        dec: Angle.Degrees(+16.41830130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149012"},
        {"Hipparcos Number", "HIP 80912"},
        {"Smithsonian Astrophysical Observation", "SAO 102219"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.84646313),
        dec: Angle.Degrees(+16.41993620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71297"},
        {"Fundamental Katalog 5th Edition", "FK5 5294"},
        {"Smithsonian Astrophysical Observation", "SAO 101088"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.71528241),
        dec: Angle.Degrees(+16.42207445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103551",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14490 C"},
        {"Henry Draper", "HD 199765"},
        {"Hipparcos Number", "HIP 103551"},
        {"Geneva Identification System", "GEN# +1.00199765"},
        {"Smithsonian Astrophysical Observation", "SAO 106724"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.69334784),
        dec: Angle.Degrees(+16.42311254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221812"},
        {"Hipparcos Number", "HIP 116400"},
        {"Smithsonian Astrophysical Observation", "SAO 108695"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.80305765),
        dec: Angle.Degrees(+16.42312976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15546"},
        {"Smithsonian Astrophysical Observation", "SAO 93393"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.08062315),
        dec: Angle.Degrees(+16.42371946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231640"},
        {"Hipparcos Number", "HIP 95963"},
        {"Geneva Identification System", "GEN# +1.00231640"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.72171173),
        dec: Angle.Degrees(+16.42595168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147096"},
        {"Hipparcos Number", "HIP 79959"},
        {"Geneva Identification System", "GEN# +1.00147096"},
        {"Smithsonian Astrophysical Observation", "SAO 102084"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.81862397),
        dec: Angle.Degrees(+16.42664769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35945"},
        {"Hipparcos Number", "HIP 25657"},
        {"Celescope Catalog", "CEL 725"},
        {"Geneva Identification System", "GEN# +1.00035945"},
        {"Smithsonian Astrophysical Observation", "SAO 94582"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.20873912),
        dec: Angle.Degrees(+16.42667006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105699"},
        {"Hipparcos Number", "HIP 59317"},
        {"Geneva Identification System", "GEN# +1.00105699"},
        {"Smithsonian Astrophysical Observation", "SAO 99969"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.53280466),
        dec: Angle.Degrees(+16.42695801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33428"},
        {"Hipparcos Number", "HIP 24121"},
        {"Geneva Identification System", "GEN# +2.18070018"},
        {"Smithsonian Astrophysical Observation", "SAO 94371"},
        {"New General Catalogue", "NGC 1807 18"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.71220862),
        dec: Angle.Degrees(+16.42915792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146759"},
        {"Hipparcos Number", "HIP 79809"},
        {"Geneva Identification System", "GEN# +1.00146759"},
        {"Smithsonian Astrophysical Observation", "SAO 102060"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.32627314),
        dec: Angle.Degrees(+16.42922798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58325"},
        {"Smithsonian Astrophysical Observation", "SAO 99885"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.40780704),
        dec: Angle.Degrees(+16.43071198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43152"},
        {"Hipparcos Number", "HIP 29694"},
        {"Geneva Identification System", "GEN# +1.00043152"},
        {"Smithsonian Astrophysical Observation", "SAO 95445"},
        {"Wilson Evans Batten Catalogue", "WEB 5850"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.84169037),
        dec: Angle.Degrees(+16.43097600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90317"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.41925312),
        dec: Angle.Degrees(+16.43181270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146081"},
        {"Hipparcos Number", "HIP 79543"},
        {"Fundamental Katalog 5th Edition", "FK5 5430"},
        {"Smithsonian Astrophysical Observation", "SAO 102021"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.46810171),
        dec: Angle.Degrees(+16.43428202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14490 B"},
        {"Henry Draper", "HD 199721"},
        {"Hipparcos Number", "HIP 103533"},
        {"Geneva Identification System", "GEN# +1.00199721"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.63013108),
        dec: Angle.Degrees(+16.43558356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14490 A"},
        {"Henry Draper", "HD 199722"},
        {"Hipparcos Number", "HIP 103537"},
        {"Geneva Identification System", "GEN# +1.00199722"},
        {"Smithsonian Astrophysical Observation", "SAO 106719"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.63430250),
        dec: Angle.Degrees(+16.43671237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83189"},
        {"Hipparcos Number", "HIP 47189"},
        {"Fundamental Katalog 5th Edition", "FK5 2766"},
        {"Geneva Identification System", "GEN# +1.00083189"},
        {"Smithsonian Astrophysical Observation", "SAO 98673"},
        {"Wilson Evans Batten Catalogue", "WEB 8875"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.26079440),
        dec: Angle.Degrees(+16.43795912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62767"},
        {"Hipparcos Number", "HIP 37911"},
        {"Fundamental Katalog 5th Edition", "FK5 4701"},
        {"Smithsonian Astrophysical Observation", "SAO 97222"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.53864647),
        dec: Angle.Degrees(+16.43847624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35833"},
        {"Hipparcos Number", "HIP 25589"},
        {"Geneva Identification System", "GEN# +1.00035833"},
        {"Smithsonian Astrophysical Observation", "SAO 94577"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.03860605),
        dec: Angle.Degrees(+16.43914771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3113"},
    },
    visualMagnitude: 11.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.90389577),
        dec: Angle.Degrees(+16.44097068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231448"},
        {"Hipparcos Number", "HIP 95634"},
        {"Geneva Identification System", "GEN# +1.00231448"},
        {"Smithsonian Astrophysical Observation", "SAO 104852"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.78995154),
        dec: Angle.Degrees(+16.44100882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353446"},
        {"Hipparcos Number", "HIP 96959"},
        {"Renson", "Renson 51360"},
        {"Smithsonian Astrophysical Observation", "SAO 105172"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64254839),
        dec: Angle.Degrees(+16.44366193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74739"},
        {"Wilson Evans Batten Catalogue", "WEB 12750"},
    },
    visualMagnitude: 12.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.11878845),
        dec: Angle.Degrees(+16.44439170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2436"},
        {"Hipparcos Number", "HIP 2224"},
        {"Fundamental Katalog 5th Edition", "FK5 1012"},
        {"Geneva Identification System", "GEN# +1.00002436"},
        {"Smithsonian Astrophysical Observation", "SAO 91912"},
        {"Wilson Evans Batten Catalogue", "WEB 414"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.05288647),
        dec: Angle.Degrees(+16.44510093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7433 AB"},
        {"Henry Draper", "HD 82793"},
        {"Hipparcos Number", "HIP 46999"},
        {"Smithsonian Astrophysical Observation", "SAO 98649"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.68490293),
        dec: Angle.Degrees(+16.44651645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68882"},
        {"Smithsonian Astrophysical Observation", "SAO 100850"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.56078861),
        dec: Angle.Degrees(+16.44958878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254052"},
        {"Hipparcos Number", "HIP 29721"},
        {"Geneva Identification System", "GEN# +1.00254052"},
        {"Wilson Evans Batten Catalogue", "WEB 5860"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.90132353),
        dec: Angle.Degrees(+16.44973018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74155"},
        {"Hipparcos Number", "HIP 42770"},
        {"Smithsonian Astrophysical Observation", "SAO 98062"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.72578134),
        dec: Angle.Degrees(+16.44987836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114"},
        {"Hipparcos Number", "HIP 503"},
        {"Geneva Identification System", "GEN# +1.00000114"},
        {"Smithsonian Astrophysical Observation", "SAO 91711"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.50439459),
        dec: Angle.Degrees(+16.45207976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49659"},
        {"Hipparcos Number", "HIP 32789"},
        {"Geneva Identification System", "GEN# +1.00049659"},
        {"Smithsonian Astrophysical Observation", "SAO 96171"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.54584573),
        dec: Angle.Degrees(+16.45381162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65873"},
        {"Hipparcos Number", "HIP 39236"},
        {"Geneva Identification System", "GEN# +1.00065873"},
        {"Smithsonian Astrophysical Observation", "SAO 97485"},
        {"Wilson Evans Batten Catalogue", "WEB 7693"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.37619077),
        dec: Angle.Degrees(+16.45532309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106667"},
        {"Smithsonian Astrophysical Observation", "SAO 107265"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.07108349),
        dec: Angle.Degrees(+16.45648398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99285"},
        {"Hipparcos Number", "HIP 55765"},
        {"Fundamental Katalog 5th Edition", "FK5 2913"},
        {"Geneva Identification System", "GEN# +1.00099285"},
        {"Smithsonian Astrophysical Observation", "SAO 99601"},
        {"Wilson Evans Batten Catalogue", "WEB 10021"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.40191420),
        dec: Angle.Degrees(+16.45655059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10560 AB"},
        {"Henry Draper", "HD 158251"},
        {"Hipparcos Number", "HIP 85434"},
        {"Renson", "Renson 44520"},
        {"Smithsonian Astrophysical Observation", "SAO 102832"},
        {"Wilson Evans Batten Catalogue", "WEB 14430"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.88663057),
        dec: Angle.Degrees(+16.45680187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86238"},
        {"Hipparcos Number", "HIP 48823"},
        {"Smithsonian Astrophysical Observation", "SAO 98862"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.39055033),
        dec: Angle.Degrees(+16.45909665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23854"},
        {"Hipparcos Number", "HIP 17830"},
        {"Geneva Identification System", "GEN# +1.00023854"},
        {"Smithsonian Astrophysical Observation", "SAO 93615"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.23426090),
        dec: Angle.Degrees(+16.45973849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10508 ABC"},
        {"Henry Draper", "HD 157483"},
        {"Hipparcos Number", "HIP 85045"},
        {"Smithsonian Astrophysical Observation", "SAO 102783"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.71972215),
        dec: Angle.Degrees(+16.46136010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155118"},
        {"Hipparcos Number", "HIP 83921"},
        {"Geneva Identification System", "GEN# +1.00155118"},
        {"Smithsonian Astrophysical Observation", "SAO 102617"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.27053401),
        dec: Angle.Degrees(+16.46224809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107090"},
        {"Smithsonian Astrophysical Observation", "SAO 107327"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.37069405),
        dec: Angle.Degrees(+16.46250053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96516",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12693 A"},
        {"Henry Draper", "HD 185194"},
        {"Hipparcos Number", "HIP 96516"},
        {"Geneva Identification System", "GEN# +1.00185194"},
        {"Smithsonian Astrophysical Observation", "SAO 105061"},
        {"Wilson Evans Batten Catalogue", "WEB 16938"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.32243004),
        dec: Angle.Degrees(+16.46276921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48406",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7549 AB"},
        {"Henry Draper", "HD 85442"},
        {"Hipparcos Number", "HIP 48406"},
        {"Smithsonian Astrophysical Observation", "SAO 98818"},
    },
    visualMagnitude: 8.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.03557309),
        dec: Angle.Degrees(+16.46300775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177414"},
        {"Hipparcos Number", "HIP 93632"},
        {"Smithsonian Astrophysical Observation", "SAO 104431"},
        {"Wilson Evans Batten Catalogue", "WEB 16264"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.00805640),
        dec: Angle.Degrees(+16.46344137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50378"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.30199552),
        dec: Angle.Degrees(+16.46421515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98332"},
        {"Hipparcos Number", "HIP 55234"},
        {"Geneva Identification System", "GEN# +1.00098332"},
        {"Smithsonian Astrophysical Observation", "SAO 99547"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.66223419),
        dec: Angle.Degrees(+16.46428803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181144"},
        {"Hipparcos Number", "HIP 94905"},
        {"Geneva Identification System", "GEN# +1.00181144"},
        {"Smithsonian Astrophysical Observation", "SAO 104707"},
        {"Wilson Evans Batten Catalogue", "WEB 16568"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.68825089),
        dec: Angle.Degrees(+16.48838911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86541",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10714 AB"},
        {"Henry Draper", "HD 160764"},
        {"Hipparcos Number", "HIP 86541"},
        {"Smithsonian Astrophysical Observation", "SAO 103019"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.28055494),
        dec: Angle.Degrees(+16.46451873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49422"},
        {"Smithsonian Astrophysical Observation", "SAO 98939"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.32243860),
        dec: Angle.Degrees(+16.46544456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193223"},
        {"Hipparcos Number", "HIP 100115"},
        {"Smithsonian Astrophysical Observation", "SAO 105946"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.64130945),
        dec: Angle.Degrees(+16.46679401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108752"},
        {"Geneva Identification System", "GEN# +9.80126049"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.45336272),
        dec: Angle.Degrees(+16.46707780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 392.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 154.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22309"},
        {"Hipparcos Number", "HIP 16788"},
        {"Cincinnati Publication", "Ci 18 474"},
        {"Cincinnati Publication 2", "Ci 20 243"},
        {"Geneva Identification System", "GEN# +1.00022309"},
        {"Smithsonian Astrophysical Observation", "SAO 93504"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.01396137),
        dec: Angle.Degrees(+16.46808013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -284.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89793"},
        {"Hipparcos Number", "HIP 50784"},
        {"Geneva Identification System", "GEN# +1.00089793"},
        {"Smithsonian Astrophysical Observation", "SAO 99083"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.54208284),
        dec: Angle.Degrees(+16.46988833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81907"},
        {"Smithsonian Astrophysical Observation", "SAO 102351"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.95698548),
        dec: Angle.Degrees(+16.47074645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96078",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Uruk"},
        {"Henry Draper", "HD 231701"},
        {"Hipparcos Number", "HIP 96078"},
        {"Geneva Identification System", "GEN# +1.00231701"},
        {"Smithsonian Astrophysical Observation", "SAO 104946"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.01717645),
        dec: Angle.Degrees(+16.47425232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89023",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11123 AB"},
        {"Hipparcos Number", "HIP 89023"},
        {"Smithsonian Astrophysical Observation", "SAO 103443"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.53636926),
        dec: Angle.Degrees(+16.47661734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114327"},
        {"Hipparcos Number", "HIP 64228"},
        {"Geneva Identification System", "GEN# +1.00114327"},
        {"Smithsonian Astrophysical Observation", "SAO 100440"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.45230857),
        dec: Angle.Degrees(+16.47795411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82099"},
    },
    visualMagnitude: 11.74,
    bvColour: 2.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.55815985),
        dec: Angle.Degrees(+16.47914545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -344.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -464.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202351"},
        {"Hipparcos Number", "HIP 104884"},
        {"Geneva Identification System", "GEN# +1.00202351"},
        {"Smithsonian Astrophysical Observation", "SAO 106954"},
        {"Wilson Evans Batten Catalogue", "WEB 19070"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.69228818),
        dec: Angle.Degrees(+16.47922191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110025"},
        {"Hipparcos Number", "HIP 61727"},
        {"Geneva Identification System", "GEN# +1.00110025"},
        {"Smithsonian Astrophysical Observation", "SAO 100194"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.78862938),
        dec: Angle.Degrees(+16.47975610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221800"},
        {"Hipparcos Number", "HIP 116391"},
        {"Smithsonian Astrophysical Observation", "SAO 108693"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.77343740),
        dec: Angle.Degrees(+16.47980657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222901"},
        {"Hipparcos Number", "HIP 117120"},
        {"Smithsonian Astrophysical Observation", "SAO 108805"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.15856189),
        dec: Angle.Degrees(+16.48192941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17918"},
        {"Hipparcos Number", "HIP 13448"},
        {"Geneva Identification System", "GEN# +1.00017918"},
        {"Smithsonian Astrophysical Observation", "SAO 93164"},
        {"Wilson Evans Batten Catalogue", "WEB 2687"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.29856682),
        dec: Angle.Degrees(+16.48361261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62372"},
        {"Smithsonian Astrophysical Observation", "SAO 100257"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.74834426),
        dec: Angle.Degrees(+16.49211258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13182 A"},
        {"Henry Draper", "HD 189183"},
        {"Hipparcos Number", "HIP 98291"},
        {"Smithsonian Astrophysical Observation", "SAO 105485"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.55953433),
        dec: Angle.Degrees(+16.49374796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5763"},
        {"Geneva Identification System", "GEN# +0.01500176"},
        {"Smithsonian Astrophysical Observation", "SAO 92324"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.49524148),
        dec: Angle.Degrees(+16.49465738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46866"},
        {"Smithsonian Astrophysical Observation", "SAO 98635"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.24814758),
        dec: Angle.Degrees(+16.49474381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54245"},
        {"Hipparcos Number", "HIP 34482"},
        {"Smithsonian Astrophysical Observation", "SAO 96546"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.19238144),
        dec: Angle.Degrees(+16.49504711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151972"},
        {"Hipparcos Number", "HIP 82390"},
        {"Smithsonian Astrophysical Observation", "SAO 102419"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.52666519),
        dec: Angle.Degrees(+16.49563572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203631"},
        {"Hipparcos Number", "HIP 105583"},
        {"Geneva Identification System", "GEN# +1.00203631"},
        {"Smithsonian Astrophysical Observation", "SAO 107089"},
        {"Wilson Evans Batten Catalogue", "WEB 19170"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.78259618),
        dec: Angle.Degrees(+16.49673045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17795"},
        {"Hipparcos Number", "HIP 13358"},
        {"Smithsonian Astrophysical Observation", "SAO 93148"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.96821578),
        dec: Angle.Degrees(+16.49776159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231157"},
        {"Hipparcos Number", "HIP 94991"},
        {"Geneva Identification System", "GEN# +1.00231157"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.94126951),
        dec: Angle.Degrees(+16.49838453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72237"},
        {"Cincinnati Publication", "Ci 20 884"},
        {"Geneva Identification System", "GEN# +0.01702785"},
        {"Smithsonian Astrophysical Observation", "SAO 101203"},
        {"Wilson Evans Batten Catalogue", "WEB 12429"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.59728479),
        dec: Angle.Degrees(+16.49893914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -919.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73821"},
        {"Hipparcos Number", "HIP 42598"},
        {"Geneva Identification System", "GEN# +1.00073821"},
        {"Smithsonian Astrophysical Observation", "SAO 98033"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.22733740),
        dec: Angle.Degrees(+16.49972686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9609 AB"},
        {"Henry Draper", "HD 136755"},
        {"Hipparcos Number", "HIP 75189"},
        {"Smithsonian Astrophysical Observation", "SAO 101506"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.47877619),
        dec: Angle.Degrees(+16.50221721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91542"},
        {"Smithsonian Astrophysical Observation", "SAO 103972"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.02498729),
        dec: Angle.Degrees(+16.50403090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112166"},
        {"Smithsonian Astrophysical Observation", "SAO 108125"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.76206551),
        dec: Angle.Degrees(+16.50424874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159503"},
        {"Hipparcos Number", "HIP 85987"},
        {"Geneva Identification System", "GEN# +1.00159503"},
        {"Smithsonian Astrophysical Observation", "SAO 102928"},
        {"Wilson Evans Batten Catalogue", "WEB 14508"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.61349108),
        dec: Angle.Degrees(+16.50437770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124424"},
        {"Hipparcos Number", "HIP 69467"},
        {"Smithsonian Astrophysical Observation", "SAO 100917"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.33192667),
        dec: Angle.Degrees(+16.50443324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198059"},
        {"Hipparcos Number", "HIP 102583"},
        {"Smithsonian Astrophysical Observation", "SAO 106490"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.82676158),
        dec: Angle.Degrees(+16.50520922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7938 AB"},
        {"Hipparcos Number", "HIP 52938"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.39232543),
        dec: Angle.Degrees(+16.50668779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215929"},
        {"Hipparcos Number", "HIP 112618"},
        {"Smithsonian Astrophysical Observation", "SAO 108188"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.12916094),
        dec: Angle.Degrees(+16.50838330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1388",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 237 B"},
        {"Hipparcos Number", "HIP 1388"},
        {"Geneva Identification System", "GEN# +1.00001309B"},
        {"Wilson Evans Batten Catalogue", "WEB 254"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.34030737),
        dec: Angle.Degrees(+16.50842454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53953"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.58049645),
        dec: Angle.Degrees(+16.50864841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11920"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.46701902),
        dec: Angle.Degrees(+16.50918881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53947"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.57518647),
        dec: Angle.Degrees(+16.50970179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21421",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aldebaran"},
        {"Aitken", "ADS 3321 A"},
        {"Henry Draper", "HD 29139"},
        {"Hipparcos Number", "HIP 21421"},
        {"Celescope Catalog", "CEL 436"},
        {"Fundamental Katalog 5th Edition", "FK5 168"},
        {"Geneva Identification System", "GEN# +1.00029139"},
        {"Smithsonian Astrophysical Observation", "SAO 94027"},
        {"Wilson Evans Batten Catalogue", "WEB 4111"},
    },
    visualMagnitude: 0.87,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.98000195),
        dec: Angle.Degrees(+16.50976164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61732"},
        {"Smithsonian Astrophysical Observation", "SAO 100196"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.80175796),
        dec: Angle.Degrees(+16.51006546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140700"},
        {"Hipparcos Number", "HIP 77092"},
        {"Geneva Identification System", "GEN# +1.00140700"},
        {"Smithsonian Astrophysical Observation", "SAO 101710"},
        {"Wilson Evans Batten Catalogue", "WEB 13075"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.12228685),
        dec: Angle.Degrees(+16.51037113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 237 A"},
        {"Henry Draper", "HD 1309"},
        {"Hipparcos Number", "HIP 1390"},
        {"Geneva Identification System", "GEN# +1.00001309A"},
        {"Smithsonian Astrophysical Observation", "SAO 91819"},
        {"Wilson Evans Batten Catalogue", "WEB 251"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.34307016),
        dec: Angle.Degrees(+16.51041465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135281"},
        {"Hipparcos Number", "HIP 74527"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.43975972),
        dec: Angle.Degrees(+16.51163392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189885"},
        {"Hipparcos Number", "HIP 98617"},
        {"Geneva Identification System", "GEN# +1.00189885"},
        {"Smithsonian Astrophysical Observation", "SAO 105567"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.45277464),
        dec: Angle.Degrees(+16.51261128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172188"},
        {"Hipparcos Number", "HIP 91375"},
        {"Geneva Identification System", "GEN# +1.00172188"},
        {"Smithsonian Astrophysical Observation", "SAO 103936"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.54497541),
        dec: Angle.Degrees(+16.51358126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29608"},
        {"Hipparcos Number", "HIP 21762"},
        {"Geneva Identification System", "GEN# +5.20250185"},
        {"Wilson Evans Batten Catalogue", "WEB 4185"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.10589116),
        dec: Angle.Degrees(+16.51373414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3433"},
        {"Hipparcos Number", "HIP 2938"},
        {"Smithsonian Astrophysical Observation", "SAO 92000"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.32724365),
        dec: Angle.Degrees(+16.51389528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21912"},
        {"Geneva Identification System", "GEN# +9.80083031"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.68320546),
        dec: Angle.Degrees(+16.51416174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68461"},
        {"Hipparcos Number", "HIP 40231"},
        {"Geneva Identification System", "GEN# +1.00068461"},
        {"Smithsonian Astrophysical Observation", "SAO 97653"},
        {"Wilson Evans Batten Catalogue", "WEB 7845"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.24890279),
        dec: Angle.Degrees(+16.51434897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10324"},
        {"Hipparcos Number", "HIP 7867"},
        {"Geneva Identification System", "GEN# +1.00010324"},
        {"Smithsonian Astrophysical Observation", "SAO 92577"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.30405594),
        dec: Angle.Degrees(+16.51438470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30364",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4997 AB"},
        {"Henry Draper", "HD 44584"},
        {"Hipparcos Number", "HIP 30364"},
        {"Celescope Catalog", "CEL 1205"},
        {"Geneva Identification System", "GEN# +1.00044584J"},
        {"Smithsonian Astrophysical Observation", "SAO 95604"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.78921721),
        dec: Angle.Degrees(+16.51518257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70954"},
        {"Smithsonian Astrophysical Observation", "SAO 101061"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.70063653),
        dec: Angle.Degrees(+16.51538994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250550"},
        {"Hipparcos Number", "HIP 28582"},
        {"Geneva Identification System", "GEN# +1.00250550"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.49995614),
        dec: Angle.Degrees(+16.51577217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88134"},
        {"Hipparcos Number", "HIP 49811"},
        {"Geneva Identification System", "GEN# +1.00088134"},
        {"Smithsonian Astrophysical Observation", "SAO 98979"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.53125344),
        dec: Angle.Degrees(+16.51673466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19896"},
        {"Hipparcos Number", "HIP 14910"},
        {"Smithsonian Astrophysical Observation", "SAO 93335"},
        {"Wilson Evans Batten Catalogue", "WEB 2880"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10372996),
        dec: Angle.Degrees(+16.51677154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18783"},
        {"Hipparcos Number", "HIP 14098"},
        {"Smithsonian Astrophysical Observation", "SAO 93243"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46032992),
        dec: Angle.Degrees(+16.51817673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65257"},
        {"Hipparcos Number", "HIP 38975"},
        {"Geneva Identification System", "GEN# +1.00065257"},
        {"Smithsonian Astrophysical Observation", "SAO 97429"},
        {"Wilson Evans Batten Catalogue", "WEB 7642"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.63114807),
        dec: Angle.Degrees(+16.51869028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285482"},
        {"Hipparcos Number", "HIP 19263"},
        {"Geneva Identification System", "GEN# +5.20252016"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.92968553),
        dec: Angle.Degrees(+16.51885052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285315"},
        {"Hipparcos Number", "HIP 18754"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.25630386),
        dec: Angle.Degrees(+16.52125888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111057"},
        {"Hipparcos Number", "HIP 62341"},
        {"Geneva Identification System", "GEN# +1.00111057"},
        {"Renson", "Renson 32290"},
        {"Smithsonian Astrophysical Observation", "SAO 100249"},
        {"Wilson Evans Batten Catalogue", "WEB 11074"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.62070787),
        dec: Angle.Degrees(+16.52145768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20215",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3135 AB"},
        {"Henry Draper", "HD 27383"},
        {"Hipparcos Number", "HIP 20215"},
        {"Geneva Identification System", "GEN# +5.20250029J"},
        {"Smithsonian Astrophysical Observation", "SAO 93870"},
        {"Wilson Evans Batten Catalogue", "WEB 3854"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.97826903),
        dec: Angle.Degrees(+16.52267742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68168"},
        {"Hipparcos Number", "HIP 40133"},
        {"Geneva Identification System", "GEN# +1.00068168"},
        {"Smithsonian Astrophysical Observation", "SAO 97640"},
        {"Wilson Evans Batten Catalogue", "WEB 7829"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95505719),
        dec: Angle.Degrees(+16.52449002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45201",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7236 AB"},
        {"Henry Draper", "HD 79127"},
        {"Hipparcos Number", "HIP 45201"},
        {"Smithsonian Astrophysical Observation", "SAO 98430"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.16713222),
        dec: Angle.Degrees(+16.52496214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159226"},
        {"Hipparcos Number", "HIP 85870"},
        {"Smithsonian Astrophysical Observation", "SAO 102904"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.21068751),
        dec: Angle.Degrees(+16.52532173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173881"},
        {"Hipparcos Number", "HIP 92168"},
        {"Smithsonian Astrophysical Observation", "SAO 104095"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.77360584),
        dec: Angle.Degrees(+16.52592326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79256"},
        {"Geneva Identification System", "GEN# +9.80138005"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.64093456),
        dec: Angle.Degrees(+16.52780040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139422"},
        {"Hipparcos Number", "HIP 76511"},
        {"Smithsonian Astrophysical Observation", "SAO 101654"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.38908168),
        dec: Angle.Degrees(+16.52973300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26039"},
        {"Hipparcos Number", "HIP 19281"},
        {"Geneva Identification System", "GEN# +1.00026039"},
        {"Renson", "Renson 6610"},
        {"Smithsonian Astrophysical Observation", "SAO 93776"},
        {"Wilson Evans Batten Catalogue", "WEB 3704"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.97779016),
        dec: Angle.Degrees(+16.53064530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62814"},
        {"Geneva Identification System", "GEN# +0.01702552"},
        {"Smithsonian Astrophysical Observation", "SAO 100310"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.06884832),
        dec: Angle.Degrees(+16.53148255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47972"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.66555586),
        dec: Angle.Degrees(+16.53177352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88546"},
        {"Hipparcos Number", "HIP 50040"},
        {"Geneva Identification System", "GEN# +1.00088546"},
        {"Smithsonian Astrophysical Observation", "SAO 99004"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.24777936),
        dec: Angle.Degrees(+16.53188121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26777",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4265 AB"},
        {"Henry Draper", "HD 37711"},
        {"Hipparcos Number", "HIP 26777"},
        {"Celescope Catalog", "CEL 924"},
        {"Geneva Identification System", "GEN# +1.00037711J"},
        {"Smithsonian Astrophysical Observation", "SAO 94759"},
        {"Wilson Evans Batten Catalogue", "WEB 5283"},
    },
    visualMagnitude: 4.84,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.32381426),
        dec: Angle.Degrees(+16.53418318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259160"},
        {"Hipparcos Number", "HIP 31177"},
        {"Smithsonian Astrophysical Observation", "SAO 95806"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.13296294),
        dec: Angle.Degrees(+16.53440684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2661 A"},
        {"Henry Draper", "HD 22695"},
        {"Hipparcos Number", "HIP 17058"},
        {"Fundamental Katalog 5th Edition", "FK5 2257"},
        {"Geneva Identification System", "GEN# +1.00022695A"},
        {"Smithsonian Astrophysical Observation", "SAO 93536"},
        {"Wilson Evans Batten Catalogue", "WEB 3242"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.85719860),
        dec: Angle.Degrees(+16.53676604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101278"},
        {"Hipparcos Number", "HIP 56858"},
        {"Geneva Identification System", "GEN# +1.00101278"},
        {"Smithsonian Astrophysical Observation", "SAO 99715"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.86249844),
        dec: Angle.Degrees(+16.53782776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9228"},
        {"Smithsonian Astrophysical Observation", "SAO 92730"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.65014494),
        dec: Angle.Degrees(+16.53789896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183035"},
        {"Hipparcos Number", "HIP 95627"},
        {"Geneva Identification System", "GEN# +1.00183035"},
        {"Smithsonian Astrophysical Observation", "SAO 104846"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.75033691),
        dec: Angle.Degrees(+16.53807979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61194"},
        {"Smithsonian Astrophysical Observation", "SAO 100144"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.08324328),
        dec: Angle.Degrees(+16.53815417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145833"},
        {"Hipparcos Number", "HIP 79421"},
        {"Geneva Identification System", "GEN# +1.00145833"},
        {"Smithsonian Astrophysical Observation", "SAO 102007"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.13778319),
        dec: Angle.Degrees(+16.53935542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149699"},
        {"Hipparcos Number", "HIP 81271"},
        {"Smithsonian Astrophysical Observation", "SAO 102265"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.98463343),
        dec: Angle.Degrees(+16.53993431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35350",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5961 A"},
        {"Henry Draper", "HD 56537"},
        {"Henry Draper 2", "HD 56537A"},
        {"Hipparcos Number", "HIP 35350"},
        {"Fundamental Katalog 5th Edition", "FK5 277"},
        {"Geneva Identification System", "GEN# +1.00056537"},
        {"Smithsonian Astrophysical Observation", "SAO 96746"},
        {"Wilson Evans Batten Catalogue", "WEB 7054"},
    },
    visualMagnitude: 3.58,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.52336162),
        dec: Angle.Degrees(+16.54047526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11530 AB"},
        {"Henry Draper", "HD 172246"},
        {"Hipparcos Number", "HIP 91413"},
        {"Geneva Identification System", "GEN# +1.00172246J"},
        {"Smithsonian Astrophysical Observation", "SAO 103945"},
        {"Wilson Evans Batten Catalogue", "WEB 15711"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.65306838),
        dec: Angle.Degrees(+16.54102923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93328"},
        {"Hipparcos Number", "HIP 52718"},
        {"Smithsonian Astrophysical Observation", "SAO 99286"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.67342733),
        dec: Angle.Degrees(+16.54290300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56742"},
    },
    visualMagnitude: 11.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.50866314),
        dec: Angle.Degrees(+16.54342115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81035"},
        {"Smithsonian Astrophysical Observation", "SAO 102237"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.25640991),
        dec: Angle.Degrees(+16.54400547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219685"},
        {"Hipparcos Number", "HIP 115024"},
        {"Geneva Identification System", "GEN# +1.00219685"},
        {"Smithsonian Astrophysical Observation", "SAO 108516"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.44225259),
        dec: Angle.Degrees(+16.54810934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127714"},
        {"Hipparcos Number", "HIP 71106"},
        {"Smithsonian Astrophysical Observation", "SAO 101071"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12736784),
        dec: Angle.Degrees(+16.54829143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107146"},
        {"Hipparcos Number", "HIP 60074"},
        {"Geneva Identification System", "GEN# +1.00107146"},
        {"Smithsonian Astrophysical Observation", "SAO 100038"},
        {"Wilson Evans Batten Catalogue", "WEB 10676"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77753470),
        dec: Angle.Degrees(+16.54865721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54405"},
        {"Hipparcos Number", "HIP 34540"},
        {"Geneva Identification System", "GEN# +1.00054405"},
        {"Smithsonian Astrophysical Observation", "SAO 96566"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.34230434),
        dec: Angle.Degrees(+16.54984404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79930"},
        {"Hipparcos Number", "HIP 45579"},
        {"Smithsonian Astrophysical Observation", "SAO 98472"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.34219658),
        dec: Angle.Degrees(+16.55124527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116754"},
        {"Hipparcos Number", "HIP 65499"},
        {"Geneva Identification System", "GEN# +1.00116754"},
        {"Smithsonian Astrophysical Observation", "SAO 100560"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.36722842),
        dec: Angle.Degrees(+16.55181058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196492"},
        {"Hipparcos Number", "HIP 101730"},
        {"Smithsonian Astrophysical Observation", "SAO 106312"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.30790070),
        dec: Angle.Degrees(+16.55183756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216899"},
        {"Hipparcos Number", "HIP 113296"},
        {"Cincinnati Publication", "Ci 20 1392"},
        {"Geneva Identification System", "GEN# +1.00216899"},
        {"Smithsonian Astrophysical Observation", "SAO 108272"},
        {"Wilson Evans Batten Catalogue", "WEB 20157"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.14764241),
        dec: Angle.Degrees(+16.55412209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1033.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126895"},
        {"Hipparcos Number", "HIP 70731"},
        {"Smithsonian Astrophysical Observation", "SAO 101035"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.98176289),
        dec: Angle.Degrees(+16.55496987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136477"},
        {"Hipparcos Number", "HIP 75066"},
        {"Geneva Identification System", "GEN# +1.00136477"},
        {"Smithsonian Astrophysical Observation", "SAO 101495"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.09738194),
        dec: Angle.Degrees(+16.55547060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105552"},
        {"Smithsonian Astrophysical Observation", "SAO 107081"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.65664587),
        dec: Angle.Degrees(+16.55624993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41640"},
        {"Hipparcos Number", "HIP 29001"},
        {"Geneva Identification System", "GEN# +1.00041640"},
        {"Smithsonian Astrophysical Observation", "SAO 95247"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.78822383),
        dec: Angle.Degrees(+16.55629700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37204"},
        {"Hipparcos Number", "HIP 26435"},
        {"Smithsonian Astrophysical Observation", "SAO 94712"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.38751570),
        dec: Angle.Degrees(+16.55664577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172542"},
        {"Hipparcos Number", "HIP 91545"},
        {"Smithsonian Astrophysical Observation", "SAO 103973"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.03678167),
        dec: Angle.Degrees(+16.55800620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7530 AB"},
        {"Henry Draper", "HD 85088"},
        {"Hipparcos Number", "HIP 48226"},
        {"Smithsonian Astrophysical Observation", "SAO 98799"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.49153544),
        dec: Angle.Degrees(+16.55980127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86439"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.92528750),
        dec: Angle.Degrees(+16.56006350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221271"},
        {"Hipparcos Number", "HIP 116021"},
        {"Geneva Identification System", "GEN# +1.00221271"},
        {"Smithsonian Astrophysical Observation", "SAO 108650"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.63202467),
        dec: Angle.Degrees(+16.56326383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218101"},
        {"Hipparcos Number", "HIP 113994"},
        {"Cincinnati Publication", "Ci 18 3017"},
        {"Geneva Identification System", "GEN# +1.00218101"},
        {"Smithsonian Astrophysical Observation", "SAO 108383"},
        {"Wilson Evans Batten Catalogue", "WEB 20242"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.27665583),
        dec: Angle.Degrees(+16.56334967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1605 AB"},
        {"Henry Draper", "HD 12315"},
        {"Hipparcos Number", "HIP 9434"},
        {"Smithsonian Astrophysical Observation", "SAO 92750"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.29072915),
        dec: Angle.Degrees(+16.56520706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15777",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2506 A"},
        {"Henry Draper", "HD 20955"},
        {"Hipparcos Number", "HIP 15777"},
        {"Geneva Identification System", "GEN# +1.00020955J"},
        {"Smithsonian Astrophysical Observation", "SAO 93408"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.82887220),
        dec: Angle.Degrees(+16.56581264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3255"},
        {"Hipparcos Number", "HIP 2815"},
        {"Geneva Identification System", "GEN# +1.00003255"},
        {"Smithsonian Astrophysical Observation", "SAO 91988"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.95891726),
        dec: Angle.Degrees(+16.56977927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64140"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.17940561),
        dec: Angle.Degrees(+16.57099291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204843"},
        {"Hipparcos Number", "HIP 106223"},
        {"Geneva Identification System", "GEN# +1.00204843"},
        {"Smithsonian Astrophysical Observation", "SAO 107191"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.73776289),
        dec: Angle.Degrees(+16.57108076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96688",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12750 A"},
        {"Henry Draper", "HD 185622"},
        {"Hipparcos Number", "HIP 96688"},
        {"Geneva Identification System", "GEN# +1.00185622"},
        {"Smithsonian Astrophysical Observation", "SAO 105104"},
        {"Wilson Evans Batten Catalogue", "WEB 16961"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.85556676),
        dec: Angle.Degrees(+16.57113626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248196"},
        {"Hipparcos Number", "HIP 27567"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.57394644),
        dec: Angle.Degrees(+16.57229761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43908"},
        {"Hipparcos Number", "HIP 30052"},
        {"Celescope Catalog", "CEL 1172"},
        {"Smithsonian Astrophysical Observation", "SAO 95531"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.86440263),
        dec: Angle.Degrees(+16.57511602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111067"},
        {"Hipparcos Number", "HIP 62356"},
        {"Geneva Identification System", "GEN# +1.00111067"},
        {"Smithsonian Astrophysical Observation", "SAO 100252"},
        {"Wilson Evans Batten Catalogue", "WEB 11075"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.66147205),
        dec: Angle.Degrees(+16.57764912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3758"},
        {"Hipparcos Number", "HIP 3174"},
        {"Smithsonian Astrophysical Observation", "SAO 92017"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.11418791),
        dec: Angle.Degrees(+16.58014668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55508"},
        {"Hipparcos Number", "HIP 34947"},
        {"Geneva Identification System", "GEN# +1.00055508"},
        {"Smithsonian Astrophysical Observation", "SAO 96652"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.47083837),
        dec: Angle.Degrees(+16.58034698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 930"},
        {"Hipparcos Number", "HIP 1108"},
        {"Geneva Identification System", "GEN# +1.00000930"},
        {"Smithsonian Astrophysical Observation", "SAO 91784"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.45258056),
        dec: Angle.Degrees(+16.58062794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117969"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.91864443),
        dec: Angle.Degrees(+16.58067979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229793"},
        {"Hipparcos Number", "HIP 92573"},
        {"Geneva Identification System", "GEN# +9.80184035"},
        {"Wilson Evans Batten Catalogue", "WEB 16014"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.96383719),
        dec: Angle.Degrees(+16.58445361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -482.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81361"},
        {"Hipparcos Number", "HIP 46232"},
        {"Fundamental Katalog 5th Edition", "FK5 2750"},
        {"Geneva Identification System", "GEN# +1.00081361"},
        {"Smithsonian Astrophysical Observation", "SAO 98561"},
        {"Wilson Evans Batten Catalogue", "WEB 8747"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.38562969),
        dec: Angle.Degrees(+16.58564659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35404"},
        {"Smithsonian Astrophysical Observation", "SAO 96753"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65566983),
        dec: Angle.Degrees(+16.58629185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167784"},
        {"Hipparcos Number", "HIP 89536"},
        {"Smithsonian Astrophysical Observation", "SAO 103542"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.05145025),
        dec: Angle.Degrees(+16.58684394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65760"},
        {"Hipparcos Number", "HIP 39171"},
        {"Smithsonian Astrophysical Observation", "SAO 97470"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.18266003),
        dec: Angle.Degrees(+16.58811888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27110"},
        {"Hipparcos Number", "HIP 20011"},
        {"Geneva Identification System", "GEN# +1.00027110"},
        {"Smithsonian Astrophysical Observation", "SAO 93843"},
        {"Wilson Evans Batten Catalogue", "WEB 3820"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.36454097),
        dec: Angle.Degrees(+16.59062760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83260",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10308 A"},
        {"Henry Draper", "HD 153809"},
        {"Hipparcos Number", "HIP 83260"},
        {"Fundamental Katalog 5th Edition", "FK5 5498"},
        {"Geneva Identification System", "GEN# +1.00153809J"},
        {"Smithsonian Astrophysical Observation", "SAO 102532"},
        {"Wilson Evans Batten Catalogue", "WEB 14070"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.26114405),
        dec: Angle.Degrees(+16.59350976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76796"},
        {"Smithsonian Astrophysical Observation", "SAO 101676"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.19550705),
        dec: Angle.Degrees(+16.59508884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68340"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.83620910),
        dec: Angle.Degrees(+16.59568590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57663"},
        {"Geneva Identification System", "GEN# +0.01702404"},
        {"Smithsonian Astrophysical Observation", "SAO 99815"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.39627220),
        dec: Angle.Degrees(+16.59732761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40316"},
        {"Hipparcos Number", "HIP 28289"},
        {"Celescope Catalog", "CEL 1048"},
        {"Geneva Identification System", "GEN# +1.00040316"},
        {"Smithsonian Astrophysical Observation", "SAO 95068"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.66680156),
        dec: Angle.Degrees(+16.59773074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80652"},
        {"Hipparcos Number", "HIP 45894"},
        {"Geneva Identification System", "GEN# +1.00080652"},
        {"Smithsonian Astrophysical Observation", "SAO 98521"},
        {"Wilson Evans Batten Catalogue", "WEB 8703"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.35626206),
        dec: Angle.Degrees(+16.59840896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21962"},
        {"Hipparcos Number", "HIP 16538"},
        {"Geneva Identification System", "GEN# +1.00021962"},
        {"Smithsonian Astrophysical Observation", "SAO 93484"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.23977846),
        dec: Angle.Degrees(+16.59866190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108360"},
        {"Smithsonian Astrophysical Observation", "SAO 107535"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.28298896),
        dec: Angle.Degrees(+16.60195909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95022"},
        {"Hipparcos Number", "HIP 53635"},
        {"Geneva Identification System", "GEN# +1.00095022"},
        {"Smithsonian Astrophysical Observation", "SAO 99379"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.59056176),
        dec: Angle.Degrees(+16.60423046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104217"},
        {"Hipparcos Number", "HIP 58537"},
        {"Smithsonian Astrophysical Observation", "SAO 99903"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.06107165),
        dec: Angle.Degrees(+16.60442994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107087"},
        {"Smithsonian Astrophysical Observation", "SAO 107326"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.36390822),
        dec: Angle.Degrees(+16.60488088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55675"},
        {"Hipparcos Number", "HIP 35006"},
        {"Geneva Identification System", "GEN# +1.00055675"},
        {"Smithsonian Astrophysical Observation", "SAO 96667"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.63684679),
        dec: Angle.Degrees(+16.60625350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78213"},
        {"Hipparcos Number", "HIP 44773"},
        {"Smithsonian Astrophysical Observation", "SAO 98373"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.87662103),
        dec: Angle.Degrees(+16.61015734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43751",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7081 AB"},
        {"Hipparcos Number", "HIP 43751"},
        {"Smithsonian Astrophysical Observation", "SAO 98223"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.67332969),
        dec: Angle.Degrees(+16.61127834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16112"},
        {"Hipparcos Number", "HIP 12075"},
        {"Smithsonian Astrophysical Observation", "SAO 93014"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.92004561),
        dec: Angle.Degrees(+16.61272354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50003"},
        {"Hipparcos Number", "HIP 32958"},
        {"Geneva Identification System", "GEN# +1.00050003"},
        {"Smithsonian Astrophysical Observation", "SAO 96206"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.96832576),
        dec: Angle.Degrees(+16.61315203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108957"},
        {"Hipparcos Number", "HIP 61080"},
        {"Geneva Identification System", "GEN# +1.00108957"},
        {"Smithsonian Astrophysical Observation", "SAO 100135"},
        {"Wilson Evans Batten Catalogue", "WEB 10873"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.77668549),
        dec: Angle.Degrees(+16.61420756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147006"},
        {"Hipparcos Number", "HIP 79918"},
        {"Geneva Identification System", "GEN# +1.00147006"},
        {"Smithsonian Astrophysical Observation", "SAO 102078"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.68515800),
        dec: Angle.Degrees(+16.61504146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109495"},
        {"Smithsonian Astrophysical Observation", "SAO 107718"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.72689423),
        dec: Angle.Degrees(+16.61521453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87189"},
        {"Smithsonian Astrophysical Observation", "SAO 103130"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.19340375),
        dec: Angle.Degrees(+16.61640708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24496"},
        {"Henry Draper 2", "HD 24496A"},
        {"Hipparcos Number", "HIP 18267"},
        {"Geneva Identification System", "GEN# +1.00024496"},
        {"Smithsonian Astrophysical Observation", "SAO 93662"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.61625430),
        dec: Angle.Degrees(+16.61645599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206902"},
        {"Hipparcos Number", "HIP 107378"},
        {"Smithsonian Astrophysical Observation", "SAO 107369"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.22910717),
        dec: Angle.Degrees(+16.61937396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1300 AB"},
        {"Henry Draper", "HD 10113"},
        {"Hipparcos Number", "HIP 7709"},
        {"Smithsonian Astrophysical Observation", "SAO 92555"},
        {"Wilson Evans Batten Catalogue", "WEB 1652"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.81338797),
        dec: Angle.Degrees(+16.62553931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285391"},
        {"Hipparcos Number", "HIP 19032"},
        {"Smithsonian Astrophysical Observation", "SAO 93748"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.15588440),
        dec: Angle.Degrees(+16.62742472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187344"},
        {"Hipparcos Number", "HIP 97493"},
        {"Smithsonian Astrophysical Observation", "SAO 105296"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.24194757),
        dec: Angle.Degrees(+16.62773092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164216"},
        {"Hipparcos Number", "HIP 88092"},
        {"Smithsonian Astrophysical Observation", "SAO 103276"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.86950767),
        dec: Angle.Degrees(+16.62867561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221443"},
        {"Hipparcos Number", "HIP 116160"},
        {"Smithsonian Astrophysical Observation", "SAO 108665"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.03914712),
        dec: Angle.Degrees(+16.62872665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69903"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.59863206),
        dec: Angle.Degrees(+16.62888324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115800",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16766 CD"},
        {"Henry Draper", "HD 220923"},
        {"Hipparcos Number", "HIP 115800"},
        {"Smithsonian Astrophysical Observation", "SAO 108618"},
    },
    visualMagnitude: 8.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.90205597),
        dec: Angle.Degrees(+16.62890986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79145"},
        {"Hipparcos Number", "HIP 45209"},
        {"Geneva Identification System", "GEN# +1.00079145"},
        {"Smithsonian Astrophysical Observation", "SAO 98433"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.19828782),
        dec: Angle.Degrees(+16.63033321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162772"},
        {"Hipparcos Number", "HIP 87439"},
        {"Smithsonian Astrophysical Observation", "SAO 103162"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01041321),
        dec: Angle.Degrees(+16.63254767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220197"},
        {"Hipparcos Number", "HIP 115359"},
        {"Cincinnati Publication", "Ci 18 3060"},
        {"Geneva Identification System", "GEN# +1.00220197"},
        {"Smithsonian Astrophysical Observation", "SAO 108566"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.49182963),
        dec: Angle.Degrees(+16.63265660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 405.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134903"},
        {"Hipparcos Number", "HIP 74374"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.97954896),
        dec: Angle.Degrees(+16.63370445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30483"},
        {"Hipparcos Number", "HIP 22347"},
        {"Geneva Identification System", "GEN# +1.00030483"},
        {"Smithsonian Astrophysical Observation", "SAO 94138"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.17191832),
        dec: Angle.Degrees(+16.63446836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188727"},
        {"Hipparcos Number", "HIP 98085"},
        {"Geneva Identification System", "GEN# +1.00188727"},
        {"Smithsonian Astrophysical Observation", "SAO 105436"},
        {"Wilson Evans Batten Catalogue", "WEB 17286"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.00526400),
        dec: Angle.Degrees(+16.63481590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243529"},
        {"Hipparcos Number", "HIP 25372"},
        {"Smithsonian Astrophysical Observation", "SAO 94538"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.41489529),
        dec: Angle.Degrees(+16.63599587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 997"},
        {"Hipparcos Number", "HIP 1156"},
        {"Smithsonian Astrophysical Observation", "SAO 91790"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.61280756),
        dec: Angle.Degrees(+16.64089821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184607"},
        {"Hipparcos Number", "HIP 96294"},
        {"Smithsonian Astrophysical Observation", "SAO 104993"},
        {"Wilson Evans Batten Catalogue", "WEB 16883"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.68873452),
        dec: Angle.Degrees(+16.64167413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173111"},
        {"Hipparcos Number", "HIP 91800"},
        {"Geneva Identification System", "GEN# +1.00173111"},
        {"Smithsonian Astrophysical Observation", "SAO 104016"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.77237191),
        dec: Angle.Degrees(+16.64297276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15227"},
        {"Hipparcos Number", "HIP 11441"},
        {"Geneva Identification System", "GEN# +1.00015227"},
        {"Smithsonian Astrophysical Observation", "SAO 92957"},
        {"Wilson Evans Batten Catalogue", "WEB 2388"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.88367037),
        dec: Angle.Degrees(+16.64361085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66411"},
        {"Hipparcos Number", "HIP 39460"},
        {"Geneva Identification System", "GEN# +1.00066411"},
        {"Smithsonian Astrophysical Observation", "SAO 97522"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.98230014),
        dec: Angle.Degrees(+16.64532268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1301"},
        {"Cincinnati Publication", "Ci 18 22"},
        {"Geneva Identification System", "GEN# +0.01500028"},
        {"Smithsonian Astrophysical Observation", "SAO 91809"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.08605605),
        dec: Angle.Degrees(+16.64653473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 347.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68582"},
        {"Hipparcos Number", "HIP 40289"},
        {"Geneva Identification System", "GEN# +1.00068582"},
        {"Smithsonian Astrophysical Observation", "SAO 97661"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.40747801),
        dec: Angle.Degrees(+16.64697188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26398"},
        {"Hipparcos Number", "HIP 19529"},
        {"Geneva Identification System", "GEN# +1.00026398"},
        {"Smithsonian Astrophysical Observation", "SAO 93805"},
        {"Wilson Evans Batten Catalogue", "WEB 3742"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.76414497),
        dec: Angle.Degrees(+16.64697895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191084"},
        {"Hipparcos Number", "HIP 99131"},
        {"Smithsonian Astrophysical Observation", "SAO 105717"},
        {"Wilson Evans Batten Catalogue", "WEB 17638"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.88058940),
        dec: Angle.Degrees(+16.64730762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62858"},
        {"Hipparcos Number", "HIP 37947"},
        {"Smithsonian Astrophysical Observation", "SAO 97226"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.66455545),
        dec: Angle.Degrees(+16.64845655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89802"},
        {"Smithsonian Astrophysical Observation", "SAO 103615"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.91182482),
        dec: Angle.Degrees(+16.65226924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109847"},
        {"Smithsonian Astrophysical Observation", "SAO 107761"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.71178385),
        dec: Angle.Degrees(+16.65440245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41285"},
        {"Hipparcos Number", "HIP 28802"},
        {"Celescope Catalog", "CEL 1070"},
        {"Geneva Identification System", "GEN# +1.00041285"},
        {"Smithsonian Astrophysical Observation", "SAO 95199"},
        {"Wilson Evans Batten Catalogue", "WEB 5632"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.21228691),
        dec: Angle.Degrees(+16.65982322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115900"},
        {"Hipparcos Number", "HIP 65043"},
        {"Geneva Identification System", "GEN# +1.00115900"},
        {"Smithsonian Astrophysical Observation", "SAO 100514"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.98615886),
        dec: Angle.Degrees(+16.66082951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156341"},
        {"Hipparcos Number", "HIP 84488"},
        {"Geneva Identification System", "GEN# +1.00156341"},
        {"Smithsonian Astrophysical Observation", "SAO 102701"},
        {"Wilson Evans Batten Catalogue", "WEB 14261"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.08491429),
        dec: Angle.Degrees(+16.66083595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95214",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12358 AB"},
        {"Henry Draper", "HD 231247"},
        {"Hipparcos Number", "HIP 95214"},
        {"Geneva Identification System", "GEN# +1.00231247J"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.55362220),
        dec: Angle.Degrees(+16.66251001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4014"},
        {"Hipparcos Number", "HIP 3371"},
        {"Smithsonian Astrophysical Observation", "SAO 92047"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.71987702),
        dec: Angle.Degrees(+16.66266875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21404"},
        {"Hipparcos Number", "HIP 16117"},
        {"Smithsonian Astrophysical Observation", "SAO 93441"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.90870623),
        dec: Angle.Degrees(+16.66298255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191178"},
        {"Hipparcos Number", "HIP 99176"},
        {"Geneva Identification System", "GEN# +1.00191178"},
        {"Smithsonian Astrophysical Observation", "SAO 105733"},
        {"Wilson Evans Batten Catalogue", "WEB 17655"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.02708254),
        dec: Angle.Degrees(+16.66437317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76867"},
        {"Hipparcos Number", "HIP 44141"},
        {"Smithsonian Astrophysical Observation", "SAO 98277"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.85001716),
        dec: Angle.Degrees(+16.66487208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145647"},
        {"Hipparcos Number", "HIP 79332"},
        {"Celescope Catalog", "CEL 4417"},
        {"Fundamental Katalog 5th Edition", "FK5 3279"},
        {"Geneva Identification System", "GEN# +1.00145647"},
        {"Smithsonian Astrophysical Observation", "SAO 101994"},
        {"Wilson Evans Batten Catalogue", "WEB 13409"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.86973483),
        dec: Angle.Degrees(+16.66567858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69975"},
        {"Smithsonian Astrophysical Observation", "SAO 100974"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77787375),
        dec: Angle.Degrees(+16.66776983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252468"},
        {"Hipparcos Number", "HIP 29187"},
        {"Smithsonian Astrophysical Observation", "SAO 95300"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.35904531),
        dec: Angle.Degrees(+16.66781335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17405"},
        {"Geneva Identification System", "GEN# +9.80006028"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.93813416),
        dec: Angle.Degrees(+16.66802202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -313.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49"},
        {"Smithsonian Astrophysical Observation", "SAO 108957"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.13950066),
        dec: Angle.Degrees(+16.66903183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17414"},
        {"Geneva Identification System", "GEN# +0.01600502"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.96861637),
        dec: Angle.Degrees(+16.67279765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28462"},
        {"Hipparcos Number", "HIP 20978"},
        {"Geneva Identification System", "GEN# +5.20250180"},
        {"Wilson Evans Batten Catalogue", "WEB 4035"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.49026205),
        dec: Angle.Degrees(+16.67290921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55802"},
        {"Hipparcos Number", "HIP 35068"},
        {"Smithsonian Astrophysical Observation", "SAO 96681"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.77752335),
        dec: Angle.Degrees(+16.67337655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52609"},
        {"Hipparcos Number", "HIP 33937"},
        {"Geneva Identification System", "GEN# +1.00052609"},
        {"Smithsonian Astrophysical Observation", "SAO 96409"},
        {"Wilson Evans Batten Catalogue", "WEB 6809"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.63872677),
        dec: Angle.Degrees(+16.67446500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57881"},
        {"Hipparcos Number", "HIP 35875"},
        {"Smithsonian Astrophysical Observation", "SAO 96848"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.94953411),
        dec: Angle.Degrees(+16.67511969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190593"},
        {"Hipparcos Number", "HIP 98924"},
        {"Renson", "Renson 52990"},
        {"Smithsonian Astrophysical Observation", "SAO 105657"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.29371047),
        dec: Angle.Degrees(+16.67613693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16831"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.12905304),
        dec: Angle.Degrees(+16.67834330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94249"},
        {"Hipparcos Number", "HIP 53208"},
        {"Smithsonian Astrophysical Observation", "SAO 99340"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.24221194),
        dec: Angle.Degrees(+16.67949171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111470"},
        {"Smithsonian Astrophysical Observation", "SAO 108016"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.75258878),
        dec: Angle.Degrees(+16.68006052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137258"},
        {"Hipparcos Number", "HIP 75412"},
        {"Smithsonian Astrophysical Observation", "SAO 101530"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.12347154),
        dec: Angle.Degrees(+16.68282227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86868"},
        {"Smithsonian Astrophysical Observation", "SAO 103075"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.23072192),
        dec: Angle.Degrees(+16.68583844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169223"},
        {"Hipparcos Number", "HIP 90086"},
        {"Geneva Identification System", "GEN# +1.00169223"},
        {"Smithsonian Astrophysical Observation", "SAO 103660"},
        {"Wilson Evans Batten Catalogue", "WEB 15399"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.76223559),
        dec: Angle.Degrees(+16.68803424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123086"},
        {"Hipparcos Number", "HIP 68809"},
        {"Smithsonian Astrophysical Observation", "SAO 100842"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.31477429),
        dec: Angle.Degrees(+16.69184030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117418"},
        {"Hipparcos Number", "HIP 65854"},
        {"Smithsonian Astrophysical Observation", "SAO 100599"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.48453311),
        dec: Angle.Degrees(+16.69392791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59602"},
        {"Cincinnati Publication", "Ci 20 691"},
    },
    visualMagnitude: 11.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.33653887),
        dec: Angle.Degrees(+16.69547079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -507.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -459.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181099"},
        {"Hipparcos Number", "HIP 94884"},
        {"Geneva Identification System", "GEN# +1.00181099"},
        {"Renson", "Renson 50210"},
        {"Smithsonian Astrophysical Observation", "SAO 104700"},
        {"Wilson Evans Batten Catalogue", "WEB 16562"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.63071789),
        dec: Angle.Degrees(+16.69776238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81540"},
        {"Hipparcos Number", "HIP 46311"},
        {"Geneva Identification System", "GEN# +1.00081540"},
        {"Smithsonian Astrophysical Observation", "SAO 98568"},
        {"Wilson Evans Batten Catalogue", "WEB 8759"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.65787042),
        dec: Angle.Degrees(+16.69831808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26980",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4301 AB"},
        {"Henry Draper", "HD 38037"},
        {"Hipparcos Number", "HIP 26980"},
        {"Celescope Catalog", "CEL 941"},
        {"Smithsonian Astrophysical Observation", "SAO 94803"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.87370567),
        dec: Angle.Degrees(+16.69835875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243614"},
        {"Hipparcos Number", "HIP 25419"},
        {"Smithsonian Astrophysical Observation", "SAO 94546"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.55840226),
        dec: Angle.Degrees(+16.69836362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35189"},
        {"Hipparcos Number", "HIP 25216"},
        {"Geneva Identification System", "GEN# +1.00035189"},
        {"Smithsonian Astrophysical Observation", "SAO 94514"},
        {"Wilson Evans Batten Catalogue", "WEB 4891"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90717601),
        dec: Angle.Degrees(+16.69935160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69836"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.38654461),
        dec: Angle.Degrees(+16.69999621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35532"},
        {"Hipparcos Number", "HIP 25410"},
        {"Celescope Catalog", "CEL 690"},
        {"Geneva Identification System", "GEN# +1.00035532"},
        {"Smithsonian Astrophysical Observation", "SAO 94543"},
        {"Wilson Evans Batten Catalogue", "WEB 4924"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.52384342),
        dec: Angle.Degrees(+16.70017305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13545"},
        {"Hipparcos Number", "HIP 10287"},
        {"Geneva Identification System", "GEN# +1.00013545"},
        {"Smithsonian Astrophysical Observation", "SAO 92833"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.12366605),
        dec: Angle.Degrees(+16.70070256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219670"},
        {"Hipparcos Number", "HIP 115008"},
        {"Geneva Identification System", "GEN# +1.00219670"},
        {"Smithsonian Astrophysical Observation", "SAO 108513"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.39909760),
        dec: Angle.Degrees(+16.70169383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78419"},
        {"Hipparcos Number", "HIP 44870"},
        {"Smithsonian Astrophysical Observation", "SAO 98384"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.14250035),
        dec: Angle.Degrees(+16.70170387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79992"},
        {"Hipparcos Number", "HIP 45597"},
        {"Geneva Identification System", "GEN# +1.00079992"},
        {"Smithsonian Astrophysical Observation", "SAO 98474"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.40886289),
        dec: Angle.Degrees(+16.70504678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23679"},
        {"Hipparcos Number", "HIP 17708"},
        {"Smithsonian Astrophysical Observation", "SAO 93602"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.89275453),
        dec: Angle.Degrees(+16.70591759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210501"},
        {"Hipparcos Number", "HIP 109452"},
        {"Smithsonian Astrophysical Observation", "SAO 107709"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.61545668),
        dec: Angle.Degrees(+16.70815558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220077"},
        {"Hipparcos Number", "HIP 115279"},
        {"Geneva Identification System", "GEN# +1.00220077"},
        {"Smithsonian Astrophysical Observation", "SAO 108556"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.22047259),
        dec: Angle.Degrees(+16.71089693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194822"},
        {"Hipparcos Number", "HIP 100880"},
        {"Geneva Identification System", "GEN# +1.00194822"},
        {"Renson", "Renson 54350"},
        {"Smithsonian Astrophysical Observation", "SAO 106120"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.81521592),
        dec: Angle.Degrees(+16.71108227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183728"},
        {"Hipparcos Number", "HIP 95915"},
        {"Smithsonian Astrophysical Observation", "SAO 104909"},
        {"Wilson Evans Batten Catalogue", "WEB 16795"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.59281324),
        dec: Angle.Degrees(+16.71113283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196410"},
        {"Hipparcos Number", "HIP 101687"},
        {"Smithsonian Astrophysical Observation", "SAO 106298"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.16979439),
        dec: Angle.Degrees(+16.71356426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2424"},
        {"Hipparcos Number", "HIP 2220"},
        {"Geneva Identification System", "GEN# +1.00002424"},
        {"Smithsonian Astrophysical Observation", "SAO 91911"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.03186843),
        dec: Angle.Degrees(+16.71604599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49007"},
        {"Smithsonian Astrophysical Observation", "SAO 98886"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.97106385),
        dec: Angle.Degrees(+16.71662430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4970"},
        {"Hipparcos Number", "HIP 4048"},
        {"Geneva Identification System", "GEN# +1.00004970"},
        {"Smithsonian Astrophysical Observation", "SAO 92125"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.96309520),
        dec: Angle.Degrees(+16.71664916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164670"},
        {"Hipparcos Number", "HIP 88283"},
        {"Smithsonian Astrophysical Observation", "SAO 103309"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.41769090),
        dec: Angle.Degrees(+16.71814035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89850"},
        {"Smithsonian Astrophysical Observation", "SAO 103621"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.03218728),
        dec: Angle.Degrees(+16.71834393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47592"},
        {"Hipparcos Number", "HIP 31909"},
        {"Smithsonian Astrophysical Observation", "SAO 95974"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.03204345),
        dec: Angle.Degrees(+16.71932593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20996"},
        {"Hipparcos Number", "HIP 15823"},
        {"Smithsonian Astrophysical Observation", "SAO 93410"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.96881823),
        dec: Angle.Degrees(+16.72137665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57339"},
        {"Hipparcos Number", "HIP 35658"},
        {"Geneva Identification System", "GEN# +1.00057339"},
        {"Smithsonian Astrophysical Observation", "SAO 96810"},
        {"Wilson Evans Batten Catalogue", "WEB 7104"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.36625395),
        dec: Angle.Degrees(+16.72209377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51443"},
        {"Hipparcos Number", "HIP 33527"},
        {"Smithsonian Astrophysical Observation", "SAO 96324"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.52364591),
        dec: Angle.Degrees(+16.72497696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9119 AB"},
        {"Hipparcos Number", "HIP 69071"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.07977489),
        dec: Angle.Degrees(+16.72565945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16607"},
        {"Hipparcos Number", "HIP 12441"},
        {"Smithsonian Astrophysical Observation", "SAO 93039"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.03750270),
        dec: Angle.Degrees(+16.72701036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202478"},
        {"Hipparcos Number", "HIP 104967"},
        {"Geneva Identification System", "GEN# +1.00202478"},
        {"Smithsonian Astrophysical Observation", "SAO 106973"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.92596610),
        dec: Angle.Degrees(+16.72779980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21865"},
        {"Hipparcos Number", "HIP 16469"},
        {"Smithsonian Astrophysical Observation", "SAO 93477"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.02584587),
        dec: Angle.Degrees(+16.72817308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120997"},
        {"Hipparcos Number", "HIP 67735"},
        {"Geneva Identification System", "GEN# +1.00120997"},
        {"Smithsonian Astrophysical Observation", "SAO 100747"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.13613922),
        dec: Angle.Degrees(+16.72905766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14801"},
        {"Hipparcos Number", "HIP 11154"},
        {"Geneva Identification System", "GEN# +1.00014801"},
        {"Smithsonian Astrophysical Observation", "SAO 92918"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.87559678),
        dec: Angle.Degrees(+16.72951564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175919"},
        {"Hipparcos Number", "HIP 93033"},
        {"Smithsonian Astrophysical Observation", "SAO 104279"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27571668),
        dec: Angle.Degrees(+16.73078935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34683"},
        {"Hipparcos Number", "HIP 24872"},
        {"Smithsonian Astrophysical Observation", "SAO 94464"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.99439622),
        dec: Angle.Degrees(+16.73081478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157257"},
        {"Hipparcos Number", "HIP 84938"},
        {"Geneva Identification System", "GEN# +1.00157257"},
        {"Smithsonian Astrophysical Observation", "SAO 102770"},
        {"Wilson Evans Batten Catalogue", "WEB 14343"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.38935959),
        dec: Angle.Degrees(+16.73126622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41119"},
        {"Hipparcos Number", "HIP 28710"},
        {"Smithsonian Astrophysical Observation", "SAO 95177"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.95586309),
        dec: Angle.Degrees(+16.73199629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55366"},
        {"Smithsonian Astrophysical Observation", "SAO 99563"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.05485700),
        dec: Angle.Degrees(+16.73293413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31476"},
        {"Hipparcos Number", "HIP 22990"},
        {"Smithsonian Astrophysical Observation", "SAO 94220"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.19793414),
        dec: Angle.Degrees(+16.73436293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144922"},
        {"Hipparcos Number", "HIP 79024"},
        {"Geneva Identification System", "GEN# +1.00144922"},
        {"Smithsonian Astrophysical Observation", "SAO 101943"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.94023892),
        dec: Angle.Degrees(+16.73459745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12568"},
        {"Smithsonian Astrophysical Observation", "SAO 93056"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.40794444),
        dec: Angle.Degrees(+16.73607330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78154"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.37535959),
        dec: Angle.Degrees(+16.73613374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140730"},
        {"Hipparcos Number", "HIP 77118"},
        {"Smithsonian Astrophysical Observation", "SAO 101713"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.20092114),
        dec: Angle.Degrees(+16.73737503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89866"},
        {"Hipparcos Number", "HIP 50819"},
        {"Geneva Identification System", "GEN# +1.00089866"},
        {"Smithsonian Astrophysical Observation", "SAO 99088"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.64522883),
        dec: Angle.Degrees(+16.74134825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57494"},
        {"Hipparcos Number", "HIP 35720"},
        {"Geneva Identification System", "GEN# +1.00057494"},
        {"Smithsonian Astrophysical Observation", "SAO 96825"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54282502),
        dec: Angle.Degrees(+16.74477367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107612"},
        {"Hipparcos Number", "HIP 60313"},
        {"Geneva Identification System", "GEN# +1.00107612"},
        {"Renson", "Renson 31190"},
        {"Smithsonian Astrophysical Observation", "SAO 100062"},
        {"Wilson Evans Batten Catalogue", "WEB 10725"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.50876083),
        dec: Angle.Degrees(+16.74479769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43080"},
        {"Hipparcos Number", "HIP 29665"},
        {"Geneva Identification System", "GEN# +1.00043080"},
        {"Smithsonian Astrophysical Observation", "SAO 95437"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.74011780),
        dec: Angle.Degrees(+16.74604351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28099"},
        {"Hipparcos Number", "HIP 20741"},
        {"Geneva Identification System", "GEN# +5.20250064"},
        {"Smithsonian Astrophysical Observation", "SAO 93936"},
        {"Wilson Evans Batten Catalogue", "WEB 3978"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.66689131),
        dec: Angle.Degrees(+16.74696616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71523"},
        {"Smithsonian Astrophysical Observation", "SAO 101115"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.42808887),
        dec: Angle.Degrees(+16.74872409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209947"},
        {"Hipparcos Number", "HIP 109160"},
        {"Geneva Identification System", "GEN# +1.00209947"},
        {"Renson", "Renson 58454"},
        {"Smithsonian Astrophysical Observation", "SAO 107667"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.67458221),
        dec: Angle.Degrees(+16.74960791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77582"},
        {"Smithsonian Astrophysical Observation", "SAO 101767"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.60086776),
        dec: Angle.Degrees(+16.75042249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164349"},
        {"Hipparcos Number", "HIP 88128"},
        {"Fundamental Katalog 5th Edition", "FK5 1469"},
        {"Geneva Identification System", "GEN# +1.00164349"},
        {"Smithsonian Astrophysical Observation", "SAO 103285"},
        {"Wilson Evans Batten Catalogue", "WEB 14886"},
    },
    visualMagnitude: 4.67,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.01425282),
        dec: Angle.Degrees(+16.75094481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353753"},
        {"Hipparcos Number", "HIP 97504"},
        {"Smithsonian Astrophysical Observation", "SAO 105299"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.26732875),
        dec: Angle.Degrees(+16.75633473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148602"},
        {"Hipparcos Number", "HIP 80701"},
        {"Smithsonian Astrophysical Observation", "SAO 102193"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.15197922),
        dec: Angle.Degrees(+16.75653359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122457"},
        {"Hipparcos Number", "HIP 68517"},
        {"Geneva Identification System", "GEN# +1.00122457"},
        {"Smithsonian Astrophysical Observation", "SAO 100820"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.40527883),
        dec: Angle.Degrees(+16.75762356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62760"},
        {"Geneva Identification System", "GEN# +0.01702550"},
        {"Smithsonian Astrophysical Observation", "SAO 100303"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.91636985),
        dec: Angle.Degrees(+16.75989782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21590"},
        {"Hipparcos Number", "HIP 16268"},
        {"Geneva Identification System", "GEN# +1.00021590"},
        {"Renson", "Renson 5400"},
        {"Smithsonian Astrophysical Observation", "SAO 93454"},
        {"Wilson Evans Batten Catalogue", "WEB 3100"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.42730329),
        dec: Angle.Degrees(+16.76237441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87737"},
        {"Hipparcos Number", "HIP 49583"},
        {"Fundamental Katalog 5th Edition", "FK5 379"},
        {"Geneva Identification System", "GEN# +1.00087737"},
        {"Smithsonian Astrophysical Observation", "SAO 98955"},
        {"Wilson Evans Batten Catalogue", "WEB 9145"},
    },
    visualMagnitude: 3.48,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.83313948),
        dec: Angle.Degrees(+16.76266572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46593"},
        {"Hipparcos Number", "HIP 31403"},
        {"Celescope Catalog", "CEL 1304"},
        {"Geneva Identification System", "GEN# +1.00046593"},
        {"Renson", "Renson 12470"},
        {"Smithsonian Astrophysical Observation", "SAO 95861"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.73637778),
        dec: Angle.Degrees(+16.76384106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192938"},
        {"Hipparcos Number", "HIP 99972"},
        {"Geneva Identification System", "GEN# +1.00192938"},
        {"Smithsonian Astrophysical Observation", "SAO 105922"},
        {"Wilson Evans Batten Catalogue", "WEB 17989"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23545681),
        dec: Angle.Degrees(+16.76608059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285571"},
        {"Hipparcos Number", "HIP 19696"},
        {"Geneva Identification System", "GEN# +5.20251051"},
        {"Smithsonian Astrophysical Observation", "SAO 93819"},
        {"Wilson Evans Batten Catalogue", "WEB 3758"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.29529360),
        dec: Angle.Degrees(+16.76694369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195775"},
        {"Hipparcos Number", "HIP 101371"},
        {"Smithsonian Astrophysical Observation", "SAO 106218"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.18226490),
        dec: Angle.Degrees(+16.76723476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60874"},
        {"Geneva Identification System", "GEN# +0.01702488"},
        {"Smithsonian Astrophysical Observation", "SAO 100119"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.14975702),
        dec: Angle.Degrees(+16.76842727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97457"},
        {"Hipparcos Number", "HIP 54792"},
        {"Smithsonian Astrophysical Observation", "SAO 99502"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.26874968),
        dec: Angle.Degrees(+16.76914956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159267"},
        {"Hipparcos Number", "HIP 85892"},
        {"Smithsonian Astrophysical Observation", "SAO 102908"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.28857286),
        dec: Angle.Degrees(+16.76931089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48953"},
        {"Henry Draper 2", "HD 48954"},
        {"Hipparcos Number", "HIP 32488"},
        {"Geneva Identification System", "GEN# +1.00048953"},
        {"Renson", "Renson 13123"},
        {"Smithsonian Astrophysical Observation", "SAO 96097"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.70553584),
        dec: Angle.Degrees(+16.77249110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105086"},
        {"Hipparcos Number", "HIP 59011"},
        {"Smithsonian Astrophysical Observation", "SAO 99938"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.49929162),
        dec: Angle.Degrees(+16.77286503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90559"},
        {"Smithsonian Astrophysical Observation", "SAO 103758"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.18485850),
        dec: Angle.Degrees(+16.77401110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7057"},
        {"Hipparcos Number", "HIP 5541"},
        {"Geneva Identification System", "GEN# +1.00007057"},
        {"Smithsonian Astrophysical Observation", "SAO 92300"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.76735059),
        dec: Angle.Degrees(+16.77726670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27749"},
        {"Hipparcos Number", "HIP 20484"},
        {"Geneva Identification System", "GEN# +5.20250045"},
        {"Renson", "Renson 7110"},
        {"Smithsonian Astrophysical Observation", "SAO 93900"},
        {"Wilson Evans Batten Catalogue", "WEB 3916"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.85415980),
        dec: Angle.Degrees(+16.77732694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188262"},
        {"Henry Draper 2", "HD 188263"},
        {"Hipparcos Number", "HIP 97904"},
        {"Geneva Identification System", "GEN# +1.00188262"},
        {"Smithsonian Astrophysical Observation", "SAO 105392"},
        {"Wilson Evans Batten Catalogue", "WEB 17226"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.44139509),
        dec: Angle.Degrees(+16.77809084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48330"},
        {"Hipparcos Number", "HIP 32224"},
        {"Smithsonian Astrophysical Observation", "SAO 96044"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.90538522),
        dec: Angle.Degrees(+16.78291261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8856"},
        {"Hipparcos Number", "HIP 6803"},
        {"Geneva Identification System", "GEN# +1.00008856"},
        {"Smithsonian Astrophysical Observation", "SAO 92448"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.88709736),
        dec: Angle.Degrees(+16.78785693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189090"},
        {"Hipparcos Number", "HIP 98234"},
        {"Fundamental Katalog 5th Edition", "FK5 3592"},
        {"Geneva Identification System", "GEN# +1.00189090"},
        {"Smithsonian Astrophysical Observation", "SAO 105471"},
        {"Wilson Evans Batten Catalogue", "WEB 17331"},
    },
    visualMagnitude: 5.54,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.43932749),
        dec: Angle.Degrees(+16.78911537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27685"},
        {"Hipparcos Number", "HIP 20441"},
        {"Fundamental Katalog 5th Edition", "FK5 4401"},
        {"Geneva Identification System", "GEN# +5.20250039"},
        {"Smithsonian Astrophysical Observation", "SAO 93895"},
        {"Wilson Evans Batten Catalogue", "WEB 3907"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.68614403),
        dec: Angle.Degrees(+16.79102888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113243"},
        {"Hipparcos Number", "HIP 63612"},
        {"Geneva Identification System", "GEN# +1.00113243"},
        {"Smithsonian Astrophysical Observation", "SAO 100385"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.56170260),
        dec: Angle.Degrees(+16.79395364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135792"},
        {"Hipparcos Number", "HIP 74734"},
        {"Smithsonian Astrophysical Observation", "SAO 101471"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.10680675),
        dec: Angle.Degrees(+16.79468550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211855"},
        {"Hipparcos Number", "HIP 110239"},
        {"Smithsonian Astrophysical Observation", "SAO 107833"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.95267699),
        dec: Angle.Degrees(+16.79541542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8220 AB"},
        {"Henry Draper", "HD 100600"},
        {"Hipparcos Number", "HIP 56473"},
        {"Geneva Identification System", "GEN# +1.00100600J"},
        {"Smithsonian Astrophysical Observation", "SAO 99673"},
        {"Wilson Evans Batten Catalogue", "WEB 10147"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.67707018),
        dec: Angle.Degrees(+16.79691629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46781"},
        {"Hipparcos Number", "HIP 31525"},
        {"Geneva Identification System", "GEN# +1.00046781"},
        {"Smithsonian Astrophysical Observation", "SAO 95889"},
        {"Wilson Evans Batten Catalogue", "WEB 6309"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.00882878),
        dec: Angle.Degrees(+16.79709636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16569 BC"},
        {"Hipparcos Number", "HIP 114469"},
    },
    visualMagnitude: 11.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.73857034),
        dec: Angle.Degrees(+16.79733009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71095"},
        {"Smithsonian Astrophysical Observation", "SAO 101069"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.08855749),
        dec: Angle.Degrees(+16.79857529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183775"},
        {"Hipparcos Number", "HIP 95927"},
        {"Geneva Identification System", "GEN# +1.00183775"},
        {"Smithsonian Astrophysical Observation", "SAO 104916"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.63238383),
        dec: Angle.Degrees(+16.80129500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354449"},
        {"Hipparcos Number", "HIP 98503"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.17703292),
        dec: Angle.Degrees(+16.80220677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285683"},
        {"Hipparcos Number", "HIP 20352"},
        {"Smithsonian Astrophysical Observation", "SAO 93884"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38690121),
        dec: Angle.Degrees(+16.80320961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35051"},
        {"Hipparcos Number", "HIP 25111"},
        {"Geneva Identification System", "GEN# +1.00035051"},
        {"Smithsonian Astrophysical Observation", "SAO 94500"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.64368014),
        dec: Angle.Degrees(+16.80395703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145287"},
        {"Hipparcos Number", "HIP 79181"},
        {"Smithsonian Astrophysical Observation", "SAO 101976"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.41619085),
        dec: Angle.Degrees(+16.80506509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191499"},
        {"Hipparcos Number", "HIP 99316"},
        {"Geneva Identification System", "GEN# +1.00191499J"},
        {"Smithsonian Astrophysical Observation", "SAO 105765"},
        {"Wilson Evans Batten Catalogue", "WEB 17719"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.39292263),
        dec: Angle.Degrees(+16.80533865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 175.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130895"},
        {"Hipparcos Number", "HIP 72570"},
        {"Smithsonian Astrophysical Observation", "SAO 101240"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.56922862),
        dec: Angle.Degrees(+16.80547321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114468",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16569 A"},
        {"Henry Draper", "HD 218832"},
        {"Hipparcos Number", "HIP 114468"},
        {"Smithsonian Astrophysical Observation", "SAO 108446"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.73672089),
        dec: Angle.Degrees(+16.80632949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232078"},
        {"Hipparcos Number", "HIP 96599"},
        {"Geneva Identification System", "GEN# +1.00232078"},
        {"Smithsonian Astrophysical Observation", "SAO 105082"},
    },
    visualMagnitude: 8.57,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.55026268),
        dec: Angle.Degrees(+16.80720036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96741"},
        {"Hipparcos Number", "HIP 54483"},
        {"Smithsonian Astrophysical Observation", "SAO 99466"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.20200361),
        dec: Angle.Degrees(+16.80916415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105778"},
        {"Hipparcos Number", "HIP 59352"},
        {"Fundamental Katalog 5th Edition", "FK5 1313"},
        {"Geneva Identification System", "GEN# +1.00105778"},
        {"Smithsonian Astrophysical Observation", "SAO 99973"},
        {"Wilson Evans Batten Catalogue", "WEB 10557"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.63184055),
        dec: Angle.Degrees(+16.80927624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72849"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.35241096),
        dec: Angle.Degrees(+16.81016719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211542"},
        {"Hipparcos Number", "HIP 110064"},
        {"Geneva Identification System", "GEN# +1.00211542"},
        {"Smithsonian Astrophysical Observation", "SAO 107799"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.38668958),
        dec: Angle.Degrees(+16.81072055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203185"},
        {"Hipparcos Number", "HIP 105350"},
        {"Geneva Identification System", "GEN# +1.00203185"},
        {"Smithsonian Astrophysical Observation", "SAO 107042"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.08340779),
        dec: Angle.Degrees(+16.81134140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66077"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.18515210),
        dec: Angle.Degrees(+16.81138664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 252.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154511"},
        {"Hipparcos Number", "HIP 83606"},
        {"Smithsonian Astrophysical Observation", "SAO 102586"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.33255323),
        dec: Angle.Degrees(+16.81183378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19647"},
        {"Hipparcos Number", "HIP 14735"},
        {"Geneva Identification System", "GEN# +1.00019647"},
        {"Smithsonian Astrophysical Observation", "SAO 93315"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.57399289),
        dec: Angle.Degrees(+16.81352598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196345"},
        {"Hipparcos Number", "HIP 101645"},
        {"Smithsonian Astrophysical Observation", "SAO 106287"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.06618795),
        dec: Angle.Degrees(+16.81469249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164901"},
        {"Hipparcos Number", "HIP 88370"},
        {"Geneva Identification System", "GEN# +1.00164901"},
        {"Smithsonian Astrophysical Observation", "SAO 103323"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.67887019),
        dec: Angle.Degrees(+16.81469674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12861 AB"},
        {"Henry Draper", "HD 186586"},
        {"Hipparcos Number", "HIP 97149"},
        {"Smithsonian Astrophysical Observation", "SAO 105206"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.19922080),
        dec: Angle.Degrees(+16.81516858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67142"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.40359523),
        dec: Angle.Degrees(+16.81793508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6493 A"},
        {"Henry Draper", "HD 65431"},
        {"Hipparcos Number", "HIP 39046"},
        {"Smithsonian Astrophysical Observation", "SAO 97439"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.82390304),
        dec: Angle.Degrees(+16.81910953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23810"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.75953015),
        dec: Angle.Degrees(+16.82060038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286150"},
        {"Hipparcos Number", "HIP 22740"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.38286379),
        dec: Angle.Degrees(+16.82203286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159063"},
        {"Hipparcos Number", "HIP 85799"},
        {"Geneva Identification System", "GEN# +1.00159063"},
        {"Smithsonian Astrophysical Observation", "SAO 102891"},
        {"Wilson Evans Batten Catalogue", "WEB 14478"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.97556500),
        dec: Angle.Degrees(+16.82405994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199941"},
        {"Hipparcos Number", "HIP 103635"},
        {"Geneva Identification System", "GEN# +1.00199941A"},
        {"Smithsonian Astrophysical Observation", "SAO 106738"},
        {"Wilson Evans Batten Catalogue", "WEB 18854"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.96173603),
        dec: Angle.Degrees(+16.82436487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12230"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.36590846),
        dec: Angle.Degrees(+16.82467450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36107"},
        {"Smithsonian Astrophysical Observation", "SAO 96895"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.57353498),
        dec: Angle.Degrees(+16.82496998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150341"},
        {"Hipparcos Number", "HIP 81602"},
        {"Smithsonian Astrophysical Observation", "SAO 102302"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.97276216),
        dec: Angle.Degrees(+16.82534590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222098"},
        {"Hipparcos Number", "HIP 116592"},
        {"Geneva Identification System", "GEN# +1.00222098J"},
        {"Renson", "Renson 60854"},
        {"Smithsonian Astrophysical Observation", "SAO 108729"},
        {"Wilson Evans Batten Catalogue", "WEB 20584"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.41525906),
        dec: Angle.Degrees(+16.82550399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8275"},
        {"Hipparcos Number", "HIP 6413"},
        {"Geneva Identification System", "GEN# +1.00008275"},
        {"Smithsonian Astrophysical Observation", "SAO 92400"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.59297160),
        dec: Angle.Degrees(+16.82578056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62409"},
        {"Smithsonian Astrophysical Observation", "SAO 100261"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.84433327),
        dec: Angle.Degrees(+16.82641983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32879"},
        {"Hipparcos Number", "HIP 23807"},
        {"Geneva Identification System", "GEN# +1.00032879"},
        {"Smithsonian Astrophysical Observation", "SAO 94328"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.75583023),
        dec: Angle.Degrees(+16.82755891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7603"},
        {"Hipparcos Number", "HIP 5930"},
        {"Geneva Identification System", "GEN# +1.00007603"},
        {"Smithsonian Astrophysical Observation", "SAO 92341"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.05588188),
        dec: Angle.Degrees(+16.82773048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46017"},
        {"Hipparcos Number", "HIP 31100"},
        {"Smithsonian Astrophysical Observation", "SAO 95773"},
        {"Wilson Evans Batten Catalogue", "WEB 6194"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.89597154),
        dec: Angle.Degrees(+16.82829078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31857"},
        {"Hipparcos Number", "HIP 23227"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.97145643),
        dec: Angle.Degrees(+16.82940541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61470"},
        {"Smithsonian Astrophysical Observation", "SAO 100164"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.94395871),
        dec: Angle.Degrees(+16.82992240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90695"},
        {"Smithsonian Astrophysical Observation", "SAO 103789"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.56352730),
        dec: Angle.Degrees(+16.83281975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83327"},
        {"Hipparcos Number", "HIP 47262"},
        {"Geneva Identification System", "GEN# +1.00083327"},
        {"Smithsonian Astrophysical Observation", "SAO 98681"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.49419634),
        dec: Angle.Degrees(+16.83406071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218473"},
        {"Hipparcos Number", "HIP 114235"},
        {"Geneva Identification System", "GEN# +1.00218473"},
        {"Smithsonian Astrophysical Observation", "SAO 108420"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.03549996),
        dec: Angle.Degrees(+16.83533822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82710"},
        {"Smithsonian Astrophysical Observation", "SAO 102464"},
        {"Wilson Evans Batten Catalogue", "WEB 13978"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.59569031),
        dec: Angle.Degrees(+16.83706740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85070"},
        {"Hipparcos Number", "HIP 48220"},
        {"Smithsonian Astrophysical Observation", "SAO 98792"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.47012004),
        dec: Angle.Degrees(+16.83851280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216489"},
        {"Hipparcos Number", "HIP 112997"},
        {"Fundamental Katalog 5th Edition", "FK5 3829"},
        {"Geneva Identification System", "GEN# +1.00216489"},
        {"Smithsonian Astrophysical Observation", "SAO 108231"},
        {"Wilson Evans Batten Catalogue", "WEB 20117"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.25949461),
        dec: Angle.Degrees(+16.84126106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231187"},
        {"Hipparcos Number", "HIP 95057"},
        {"Geneva Identification System", "GEN# +1.00231187"},
        {"Smithsonian Astrophysical Observation", "SAO 104736"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.11479205),
        dec: Angle.Degrees(+16.84129646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41560"},
        {"Smithsonian Astrophysical Observation", "SAO 97839"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.10694187),
        dec: Angle.Degrees(+16.84330920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 864"},
        {"Smithsonian Astrophysical Observation", "SAO 91757"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.65873023),
        dec: Angle.Degrees(+16.84407826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72342"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.89699799),
        dec: Angle.Degrees(+16.84552468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64210"},
        {"Hipparcos Number", "HIP 38533"},
        {"Smithsonian Astrophysical Observation", "SAO 97338"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.35819134),
        dec: Angle.Degrees(+16.84599445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12160 AB"},
        {"Henry Draper", "HD 179588"},
        {"Hipparcos Number", "HIP 94377"},
        {"Geneva Identification System", "GEN# +1.00179588"},
        {"Smithsonian Astrophysical Observation", "SAO 104602"},
        {"Wilson Evans Batten Catalogue", "WEB 16447"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.14355604),
        dec: Angle.Degrees(+16.84644822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90984"},
        {"Smithsonian Astrophysical Observation", "SAO 103844"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37969130),
        dec: Angle.Degrees(+16.84746304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149178"},
        {"Hipparcos Number", "HIP 80994"},
        {"Geneva Identification System", "GEN# +1.00149178"},
        {"Smithsonian Astrophysical Observation", "SAO 102231"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.12284348),
        dec: Angle.Degrees(+16.84761919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66300"},
        {"Hipparcos Number", "HIP 39416"},
        {"Smithsonian Astrophysical Observation", "SAO 97512"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.86508535),
        dec: Angle.Degrees(+16.84769323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114326"},
        {"Hipparcos Number", "HIP 64226"},
        {"Fundamental Katalog 5th Edition", "FK5 3049"},
        {"Geneva Identification System", "GEN# +1.00114326"},
        {"Smithsonian Astrophysical Observation", "SAO 100439"},
        {"Wilson Evans Batten Catalogue", "WEB 11354"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.44953121),
        dec: Angle.Degrees(+16.84864890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103216"},
        {"Hipparcos Number", "HIP 57952"},
        {"Smithsonian Astrophysical Observation", "SAO 99844"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.29544017),
        dec: Angle.Degrees(+16.84904777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94371",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12160 C"},
        {"Henry Draper", "HD 179558"},
        {"Hipparcos Number", "HIP 94371"},
        {"Geneva Identification System", "GEN# +1.00179558J"},
        {"Smithsonian Astrophysical Observation", "SAO 104594"},
        {"Wilson Evans Batten Catalogue", "WEB 16444"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.11440211),
        dec: Angle.Degrees(+16.85059796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62859"},
        {"Geneva Identification System", "GEN# +0.01702554"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.26258703),
        dec: Angle.Degrees(+16.85135574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178619"},
        {"Hipparcos Number", "HIP 94034"},
        {"Cincinnati Publication", "Ci 18 2499"},
        {"Fundamental Katalog 5th Edition", "FK5 3529"},
        {"Geneva Identification System", "GEN# +1.00178619"},
        {"Smithsonian Astrophysical Observation", "SAO 104524"},
        {"Wilson Evans Batten Catalogue", "WEB 16367"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.16759836),
        dec: Angle.Degrees(+16.85155902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41561"},
        {"Smithsonian Astrophysical Observation", "SAO 97840"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.10813883),
        dec: Angle.Degrees(+16.85252535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191838"},
        {"Hipparcos Number", "HIP 99464"},
        {"Geneva Identification System", "GEN# +1.00191838"},
        {"Smithsonian Astrophysical Observation", "SAO 105797"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.81413580),
        dec: Angle.Degrees(+16.85299073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70430"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.11771953),
        dec: Angle.Degrees(+16.85326235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28068"},
        {"Hipparcos Number", "HIP 20719"},
        {"Geneva Identification System", "GEN# +5.20250063"},
        {"Smithsonian Astrophysical Observation", "SAO 93933"},
        {"Wilson Evans Batten Catalogue", "WEB 3973"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.60227009),
        dec: Angle.Degrees(+16.85336496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178428"},
        {"Hipparcos Number", "HIP 93966"},
        {"Cincinnati Publication", "Ci 18 2495"},
        {"Geneva Identification System", "GEN# +1.00178428J"},
        {"Smithsonian Astrophysical Observation", "SAO 104511"},
        {"Wilson Evans Batten Catalogue", "WEB 16351"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.98867463),
        dec: Angle.Degrees(+16.85412507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187731"},
        {"Hipparcos Number", "HIP 97670"},
        {"Smithsonian Astrophysical Observation", "SAO 105340"},
        {"Wilson Evans Batten Catalogue", "WEB 17177"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.74549593),
        dec: Angle.Degrees(+16.85777085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192387"},
        {"Hipparcos Number", "HIP 99713"},
        {"Smithsonian Astrophysical Observation", "SAO 105868"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.50161354),
        dec: Angle.Degrees(+16.85809029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353577"},
        {"Hipparcos Number", "HIP 97230"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.41705848),
        dec: Angle.Degrees(+16.85959049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88852"},
        {"Hipparcos Number", "HIP 50229"},
        {"Geneva Identification System", "GEN# +1.00088852"},
        {"Smithsonian Astrophysical Observation", "SAO 99024"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.80261358),
        dec: Angle.Degrees(+16.85967906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16648 ABC"},
        {"Henry Draper", "HD 219669"},
        {"Hipparcos Number", "HIP 115002"},
        {"Smithsonian Astrophysical Observation", "SAO 108512"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.37963323),
        dec: Angle.Degrees(+16.86028933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94289",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "BAC 209"},
        {"Common Name 2", "Merrill's star"},
        {"Hipparcos Number", "HIP 94289"},
        {"Wilson Evans Batten Catalogue", "WEB 16426"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.87865299),
        dec: Angle.Degrees(+16.86062483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153699"},
        {"Hipparcos Number", "HIP 83212"},
        {"Smithsonian Astrophysical Observation", "SAO 102524"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.09302787),
        dec: Angle.Degrees(+16.86364867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108100"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.54173949),
        dec: Angle.Degrees(+16.86547511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123519"},
        {"Hipparcos Number", "HIP 69030"},
        {"Geneva Identification System", "GEN# +1.00123519"},
        {"Smithsonian Astrophysical Observation", "SAO 100860"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.96933111),
        dec: Angle.Degrees(+16.86666595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117792"},
        {"Smithsonian Astrophysical Observation", "SAO 108887"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.30780574),
        dec: Angle.Degrees(+16.86835040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93290"},
        {"Hipparcos Number", "HIP 52703"},
        {"Smithsonian Astrophysical Observation", "SAO 99283"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.63630741),
        dec: Angle.Degrees(+16.86960410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14688"},
        {"Hipparcos Number", "HIP 11075"},
        {"Fundamental Katalog 5th Edition", "FK5 4220"},
        {"Geneva Identification System", "GEN# +1.00014688"},
        {"Renson", "Renson 3680"},
        {"Smithsonian Astrophysical Observation", "SAO 92905"},
        {"Wilson Evans Batten Catalogue", "WEB 2329"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.63820512),
        dec: Angle.Degrees(+16.87029607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190920"},
        {"Hipparcos Number", "HIP 99074"},
        {"Smithsonian Astrophysical Observation", "SAO 105703"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.70768933),
        dec: Angle.Degrees(+16.87070836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110251"},
        {"Smithsonian Astrophysical Observation", "SAO 107838"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.98331955),
        dec: Angle.Degrees(+16.87264015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61679"},
        {"Hipparcos Number", "HIP 37436"},
        {"Smithsonian Astrophysical Observation", "SAO 97137"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.27435894),
        dec: Angle.Degrees(+16.87331592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161021"},
        {"Hipparcos Number", "HIP 86676"},
        {"Smithsonian Astrophysical Observation", "SAO 103042"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.63691328),
        dec: Angle.Degrees(+16.87335927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12848"},
        {"Hipparcos Number", "HIP 9820"},
        {"Smithsonian Astrophysical Observation", "SAO 92792"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.59219431),
        dec: Angle.Degrees(+16.87366741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92511"},
        {"Hipparcos Number", "HIP 52295"},
        {"Smithsonian Astrophysical Observation", "SAO 99248"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.28789624),
        dec: Angle.Degrees(+16.87397093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63107"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.96882721),
        dec: Angle.Degrees(+16.87520341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1764"},
        {"Hipparcos Number", "HIP 1736"},
        {"Geneva Identification System", "GEN# +1.00001764"},
        {"Smithsonian Astrophysical Observation", "SAO 91863"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.48870262),
        dec: Angle.Degrees(+16.87708993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194304"},
        {"Hipparcos Number", "HIP 100636"},
        {"Smithsonian Astrophysical Observation", "SAO 106065"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.08741745),
        dec: Angle.Degrees(+16.87808216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63647"},
        {"Hipparcos Number", "HIP 38281"},
        {"Geneva Identification System", "GEN# +1.00063647"},
        {"Smithsonian Astrophysical Observation", "SAO 97301"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.64904177),
        dec: Angle.Degrees(+16.87945232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95620"},
        {"Hipparcos Number", "HIP 53965"},
        {"Geneva Identification System", "GEN# +1.00095620"},
        {"Smithsonian Astrophysical Observation", "SAO 99415"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60348873),
        dec: Angle.Degrees(+16.87969370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72616"},
        {"Hipparcos Number", "HIP 42057"},
        {"Geneva Identification System", "GEN# +1.00072616"},
        {"Smithsonian Astrophysical Observation", "SAO 97919"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.59140390),
        dec: Angle.Degrees(+16.88036329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57651"},
        {"Geneva Identification System", "GEN# +0.01702403"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.34915140),
        dec: Angle.Degrees(+16.88050633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96593"},
        {"Hipparcos Number", "HIP 54398"},
        {"Smithsonian Astrophysical Observation", "SAO 99462"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.97330259),
        dec: Angle.Degrees(+16.88098769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132170"},
        {"Hipparcos Number", "HIP 73173"},
        {"Smithsonian Astrophysical Observation", "SAO 101300"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.31852487),
        dec: Angle.Degrees(+16.88222881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42814"},
        {"Smithsonian Astrophysical Observation", "SAO 98070"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.86195581),
        dec: Angle.Degrees(+16.88329301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59202"},
        {"Hipparcos Number", "HIP 36408"},
        {"Geneva Identification System", "GEN# +1.00059202"},
        {"Smithsonian Astrophysical Observation", "SAO 96948"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.37563054),
        dec: Angle.Degrees(+16.88418635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200863"},
        {"Hipparcos Number", "HIP 104119"},
        {"Geneva Identification System", "GEN# +1.00200863"},
        {"Smithsonian Astrophysical Observation", "SAO 106828"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.40865170),
        dec: Angle.Degrees(+16.88472997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63854"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.29607235),
        dec: Angle.Degrees(+16.88552077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27859"},
        {"Hipparcos Number", "HIP 20577"},
        {"Geneva Identification System", "GEN# +5.20250052"},
        {"Smithsonian Astrophysical Observation", "SAO 93914"},
        {"Wilson Evans Batten Catalogue", "WEB 3943"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.11773850),
        dec: Angle.Degrees(+16.88622603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10665"},
        {"Smithsonian Astrophysical Observation", "SAO 92870"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.31088582),
        dec: Angle.Degrees(+16.88994741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111092"},
        {"Smithsonian Astrophysical Observation", "SAO 107958"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.58883068),
        dec: Angle.Degrees(+16.88996047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9925 AB"},
        {"Henry Draper", "HD 144802"},
        {"Hipparcos Number", "HIP 78957"},
        {"Smithsonian Astrophysical Observation", "SAO 101935"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.78297559),
        dec: Angle.Degrees(+16.89381931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70570"},
        {"Hipparcos Number", "HIP 41104"},
        {"Smithsonian Astrophysical Observation", "SAO 97777"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.80345709),
        dec: Angle.Degrees(+16.89404335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139102"},
        {"Hipparcos Number", "HIP 76349"},
        {"Smithsonian Astrophysical Observation", "SAO 101632"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.91238779),
        dec: Angle.Degrees(+16.89595986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229355"},
        {"Hipparcos Number", "HIP 91966"},
        {"Smithsonian Astrophysical Observation", "SAO 104054"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.18372584),
        dec: Angle.Degrees(+16.89676653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212525"},
        {"Hipparcos Number", "HIP 110623"},
        {"Geneva Identification System", "GEN# +1.00212525"},
        {"Smithsonian Astrophysical Observation", "SAO 107892"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15552803),
        dec: Angle.Degrees(+16.89687863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90142"},
        {"Smithsonian Astrophysical Observation", "SAO 103671"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.94222096),
        dec: Angle.Degrees(+16.89972783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162865"},
        {"Hipparcos Number", "HIP 87485"},
        {"Geneva Identification System", "GEN# +1.00162865"},
        {"Smithsonian Astrophysical Observation", "SAO 103168"},
        {"Wilson Evans Batten Catalogue", "WEB 14756"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.12993984),
        dec: Angle.Degrees(+16.90059576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60319"},
        {"Hipparcos Number", "HIP 36849"},
        {"Geneva Identification System", "GEN# +9.80088040"},
        {"Geneva Identification System 2", "GEN# +1.00060319"},
        {"Smithsonian Astrophysical Observation", "SAO 97032"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.64626615),
        dec: Angle.Degrees(+16.90183765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85096",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10516 AB"},
        {"Henry Draper", "HD 157582"},
        {"Hipparcos Number", "HIP 85096"},
        {"Smithsonian Astrophysical Observation", "SAO 102789"},
        {"Wilson Evans Batten Catalogue", "WEB 14368"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.87542855),
        dec: Angle.Degrees(+16.90296263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117391"},
        {"Hipparcos Number", "HIP 65836"},
        {"Geneva Identification System", "GEN# +1.00117391"},
        {"Smithsonian Astrophysical Observation", "SAO 100597"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.43093069),
        dec: Angle.Degrees(+16.90314434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197940"},
        {"Hipparcos Number", "HIP 102504"},
        {"Smithsonian Astrophysical Observation", "SAO 106472"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.60847430),
        dec: Angle.Degrees(+16.90357767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24999"},
        {"Hipparcos Number", "HIP 18609"},
        {"Cincinnati Publication", "Ci 18 537"},
        {"Smithsonian Astrophysical Observation", "SAO 93702"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.73095333),
        dec: Angle.Degrees(+16.90379656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60848"},
        {"Hipparcos Number", "HIP 37074"},
        {"Geneva Identification System", "GEN# +1.00060848"},
        {"Smithsonian Astrophysical Observation", "SAO 97083"},
        {"Wilson Evans Batten Catalogue", "WEB 7353"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.27388896),
        dec: Angle.Degrees(+16.90425503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19584"},
        {"Hipparcos Number", "HIP 14679"},
        {"Geneva Identification System", "GEN# +1.00019584"},
        {"Smithsonian Astrophysical Observation", "SAO 93306"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.40832159),
        dec: Angle.Degrees(+16.90473291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191382"},
        {"Hipparcos Number", "HIP 99277"},
        {"Smithsonian Astrophysical Observation", "SAO 105756"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.28387813),
        dec: Angle.Degrees(+16.90708917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106542"},
        {"Hipparcos Number", "HIP 59753"},
        {"Geneva Identification System", "GEN# +1.00106542"},
        {"Smithsonian Astrophysical Observation", "SAO 100009"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.80657926),
        dec: Angle.Degrees(+16.90741038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173921"},
        {"Hipparcos Number", "HIP 92191"},
        {"Smithsonian Astrophysical Observation", "SAO 104098"},
        {"Wilson Evans Batten Catalogue", "WEB 15897"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.83309531),
        dec: Angle.Degrees(+16.90853524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54244"},
        {"Hipparcos Number", "HIP 34484"},
        {"Smithsonian Astrophysical Observation", "SAO 96547"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.19477352),
        dec: Angle.Degrees(+16.90880813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355455"},
        {"Hipparcos Number", "HIP 100329"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.20347630),
        dec: Angle.Degrees(+16.90969303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5318"},
        {"Hipparcos Number", "HIP 4303"},
        {"Geneva Identification System", "GEN# +1.00005318"},
        {"Smithsonian Astrophysical Observation", "SAO 92151"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.78375551),
        dec: Angle.Degrees(+16.91008729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102938"},
        {"Smithsonian Astrophysical Observation", "SAO 106575"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.83636554),
        dec: Angle.Degrees(+16.91245884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193950"},
        {"Hipparcos Number", "HIP 100468"},
        {"Smithsonian Astrophysical Observation", "SAO 106035"},
        {"Wilson Evans Batten Catalogue", "WEB 18142"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.61113053),
        dec: Angle.Degrees(+16.91673616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157967"},
        {"Hipparcos Number", "HIP 85302"},
        {"Smithsonian Astrophysical Observation", "SAO 102819"},
        {"Wilson Evans Batten Catalogue", "WEB 14401"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.47655520),
        dec: Angle.Degrees(+16.91753762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13670"},
        {"Hipparcos Number", "HIP 10375"},
        {"Smithsonian Astrophysical Observation", "SAO 92845"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.41867708),
        dec: Angle.Degrees(+16.91821711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126914"},
        {"Hipparcos Number", "HIP 70740"},
        {"Geneva Identification System", "GEN# +1.00126914"},
        {"Smithsonian Astrophysical Observation", "SAO 101036"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99742332),
        dec: Angle.Degrees(+16.91880419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14758 AB"},
        {"Henry Draper", "HD 202091"},
        {"Hipparcos Number", "HIP 104748"},
        {"Geneva Identification System", "GEN# +1.00202091J"},
        {"Smithsonian Astrophysical Observation", "SAO 106927"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.31914683),
        dec: Angle.Degrees(+16.91900058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90252"},
        {"Hipparcos Number", "HIP 51020"},
        {"Geneva Identification System", "GEN# +1.00090252"},
        {"Smithsonian Astrophysical Observation", "SAO 99110"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.34729145),
        dec: Angle.Degrees(+16.92025294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116479"},
        {"Hipparcos Number", "HIP 65361"},
        {"Geneva Identification System", "GEN# +1.00116479"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.93524211),
        dec: Angle.Degrees(+16.92133556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 874"},
        {"Hipparcos Number", "HIP 1057"},
        {"Geneva Identification System", "GEN# +1.00000874"},
        {"Smithsonian Astrophysical Observation", "SAO 91779"},
        {"Wilson Evans Batten Catalogue", "WEB 184"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.28963960),
        dec: Angle.Degrees(+16.92165199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66655"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.95073844),
        dec: Angle.Degrees(+16.92210663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93430"},
        {"Hipparcos Number", "HIP 52768"},
        {"Smithsonian Astrophysical Observation", "SAO 99291"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.84243151),
        dec: Angle.Degrees(+16.92240452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13297"},
        {"Smithsonian Astrophysical Observation", "SAO 93143"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.78623993),
        dec: Angle.Degrees(+16.92429595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355183"},
        {"Hipparcos Number", "HIP 99702"},
        {"Geneva Identification System", "GEN# +1.00355183"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.47799343),
        dec: Angle.Degrees(+16.92489543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19430"},
        {"Hipparcos Number", "HIP 14567"},
        {"Geneva Identification System", "GEN# +1.00019430"},
        {"Smithsonian Astrophysical Observation", "SAO 93289"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.02407517),
        dec: Angle.Degrees(+16.92546910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49042"},
        {"Hipparcos Number", "HIP 32525"},
        {"Geneva Identification System", "GEN# +1.00049042"},
        {"Smithsonian Astrophysical Observation", "SAO 96108"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.80708445),
        dec: Angle.Degrees(+16.92641287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165374"},
        {"Hipparcos Number", "HIP 88563"},
        {"Smithsonian Astrophysical Observation", "SAO 103362"},
        {"Wilson Evans Batten Catalogue", "WEB 14995"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.25157249),
        dec: Angle.Degrees(+16.92667636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58634"},
        {"Geneva Identification System", "GEN# +0.01702425"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.35992690),
        dec: Angle.Degrees(+16.92824414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170878"},
        {"Hipparcos Number", "HIP 90762"},
        {"Fundamental Katalog 5th Edition", "FK5 1481"},
        {"Geneva Identification System", "GEN# +1.00170878"},
        {"Smithsonian Astrophysical Observation", "SAO 103800"},
        {"Wilson Evans Batten Catalogue", "WEB 15550"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.76861912),
        dec: Angle.Degrees(+16.92860639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24423"},
        {"Hipparcos Number", "HIP 18222"},
        {"Smithsonian Astrophysical Observation", "SAO 93654"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.44039178),
        dec: Angle.Degrees(+16.93068734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50826"},
        {"Smithsonian Astrophysical Observation", "SAO 99090"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.67210059),
        dec: Angle.Degrees(+16.93137904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40773"},
        {"Hipparcos Number", "HIP 28556"},
        {"Smithsonian Astrophysical Observation", "SAO 95133"},
        {"Wilson Evans Batten Catalogue", "WEB 5582"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41553892),
        dec: Angle.Degrees(+16.93414282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157822"},
        {"Hipparcos Number", "HIP 85231"},
        {"Smithsonian Astrophysical Observation", "SAO 102808"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.24022647),
        dec: Angle.Degrees(+16.93493076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93353"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.21915214),
        dec: Angle.Degrees(+16.93622997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223212"},
        {"Hipparcos Number", "HIP 117339"},
        {"Geneva Identification System", "GEN# +1.00223212"},
        {"Smithsonian Astrophysical Observation", "SAO 108837"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.88392871),
        dec: Angle.Degrees(+16.93759540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182490"},
        {"Hipparcos Number", "HIP 95398"},
        {"Geneva Identification System", "GEN# +1.00182490"},
        {"Renson", "Renson 50460"},
        {"Smithsonian Astrophysical Observation", "SAO 104797"},
        {"Wilson Evans Batten Catalogue", "WEB 16675"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.09198653),
        dec: Angle.Degrees(+16.93775593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111349"},
        {"Hipparcos Number", "HIP 62510"},
        {"Geneva Identification System", "GEN# +1.00111349"},
        {"Smithsonian Astrophysical Observation", "SAO 100274"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.16203069),
        dec: Angle.Degrees(+16.93816570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13859 A"},
        {"Hipparcos Number", "HIP 100846"},
        {"Smithsonian Astrophysical Observation", "SAO 106107"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.70645343),
        dec: Angle.Degrees(+16.93829831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31067",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5146 A"},
        {"Henry Draper", "HD 45951"},
        {"Hipparcos Number", "HIP 31067"},
        {"Geneva Identification System", "GEN# +1.00045951A"},
        {"Smithsonian Astrophysical Observation", "SAO 95765"},
        {"Wilson Evans Batten Catalogue", "WEB 6184"},
    },
    visualMagnitude: 6.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)31, 10.0300),
        dec: Angle.DegreesMinutesSeconds((int)+16, (int)56, 19.100)
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
    primaryId: "HIP 3810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4676"},
        {"Hipparcos Number", "HIP 3810"},
        {"Fundamental Katalog 5th Edition", "FK5 1020"},
        {"Geneva Identification System", "GEN# +1.00004676"},
        {"Smithsonian Astrophysical Observation", "SAO 92099"},
        {"Wilson Evans Batten Catalogue", "WEB 676"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.24462380),
        dec: Angle.Degrees(+16.94113370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216672"},
        {"Hipparcos Number", "HIP 113131"},
        {"Geneva Identification System", "GEN# +1.00216672"},
        {"Smithsonian Astrophysical Observation", "SAO 108246"},
        {"Wilson Evans Batten Catalogue", "WEB 20135"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.64840834),
        dec: Angle.Degrees(+16.94185315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24558"},
        {"Geneva Identification System", "GEN# +9.80085060"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.03775345),
        dec: Angle.Degrees(+16.94280949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163175"},
        {"Hipparcos Number", "HIP 87643"},
        {"Smithsonian Astrophysical Observation", "SAO 103195"},
        {"Wilson Evans Batten Catalogue", "WEB 14791"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.53278176),
        dec: Angle.Degrees(+16.94380416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14206 AB"},
        {"Henry Draper", "HD 197474"},
        {"Hipparcos Number", "HIP 102283"},
        {"Smithsonian Astrophysical Observation", "SAO 106426"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.86627638),
        dec: Angle.Degrees(+16.94497162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42968"},
        {"Smithsonian Astrophysical Observation", "SAO 98099"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.36958609),
        dec: Angle.Degrees(+16.94571998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1202 A"},
        {"Henry Draper", "HD 9312"},
        {"Hipparcos Number", "HIP 7143"},
        {"Geneva Identification System", "GEN# +1.00009312A"},
        {"Smithsonian Astrophysical Observation", "SAO 92492"},
        {"Wilson Evans Batten Catalogue", "WEB 1541"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.01271973),
        dec: Angle.Degrees(+16.94770727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27130"},
        {"Hipparcos Number", "HIP 20019"},
        {"Geneva Identification System", "GEN# +5.20250022"},
        {"Smithsonian Astrophysical Observation", "SAO 93845"},
        {"Wilson Evans Batten Catalogue", "WEB 3821"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.41196917),
        dec: Angle.Degrees(+16.94791093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116941"},
        {"Hipparcos Number", "HIP 65583"},
        {"Geneva Identification System", "GEN# +1.00116941"},
        {"Smithsonian Astrophysical Observation", "SAO 100566"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.68509918),
        dec: Angle.Degrees(+16.94850065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46264"},
        {"Hipparcos Number", "HIP 31236"},
        {"Celescope Catalog", "CEL 1292"},
        {"Geneva Identification System", "GEN# +1.00046264"},
        {"Smithsonian Astrophysical Observation", "SAO 95819"},
        {"Wilson Evans Batten Catalogue", "WEB 6241"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.27330917),
        dec: Angle.Degrees(+16.94875989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6519 A"},
        {"Henry Draper", "HD 65857"},
        {"Hipparcos Number", "HIP 39226"},
        {"Geneva Identification System", "GEN# +1.00065857"},
        {"Smithsonian Astrophysical Observation", "SAO 97483"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.34640480),
        dec: Angle.Degrees(+16.94948163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109903"},
        {"Smithsonian Astrophysical Observation", "SAO 107773"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.89912209),
        dec: Angle.Degrees(+16.94957003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85458"},
        {"Smithsonian Astrophysical Observation", "SAO 102836"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.95499084),
        dec: Angle.Degrees(+16.94973116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70133"},
        {"Hipparcos Number", "HIP 40904"},
        {"Geneva Identification System", "GEN# +1.00070133"},
        {"Smithsonian Astrophysical Observation", "SAO 97740"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.20477541),
        dec: Angle.Degrees(+16.95018611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48504"},
        {"Smithsonian Astrophysical Observation", "SAO 98828"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.37908933),
        dec: Angle.Degrees(+16.95051888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39228",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6519 B"},
        {"Henry Draper", "HD 65857B"},
        {"Hipparcos Number", "HIP 39228"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.34875650),
        dec: Angle.Degrees(+16.95128386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81537"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.80766149),
        dec: Angle.Degrees(+16.95271789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89406"},
        {"Hipparcos Number", "HIP 50549"},
        {"Geneva Identification System", "GEN# +1.00089406"},
        {"Smithsonian Astrophysical Observation", "SAO 99060"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.87228783),
        dec: Angle.Degrees(+16.95397975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60301"},
        {"Hipparcos Number", "HIP 36838"},
        {"Geneva Identification System", "GEN# +1.00060301"},
        {"Smithsonian Astrophysical Observation", "SAO 97030"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.62157298),
        dec: Angle.Degrees(+16.95411303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98117"},
        {"Hipparcos Number", "HIP 55136"},
        {"Geneva Identification System", "GEN# +1.00098117"},
        {"Smithsonian Astrophysical Observation", "SAO 99537"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.31662194),
        dec: Angle.Degrees(+16.95413381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10982"},
        {"Hipparcos Number", "HIP 8387"},
        {"Fundamental Katalog 5th Edition", "FK5 1050"},
        {"Geneva Identification System", "GEN# +1.00010982"},
        {"Smithsonian Astrophysical Observation", "SAO 92637"},
        {"Wilson Evans Batten Catalogue", "WEB 1784"},
    },
    visualMagnitude: 5.86,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.04542790),
        dec: Angle.Degrees(+16.95563093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2702 A"},
        {"Hipparcos Number", "HIP 17291"},
        {"Smithsonian Astrophysical Observation", "SAO 93555"},
    },
    visualMagnitude: 8.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.52688575),
        dec: Angle.Degrees(+16.95602588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182571"},
        {"Hipparcos Number", "HIP 95435"},
        {"Geneva Identification System", "GEN# +1.00182571"},
        {"Renson", "Renson 50502"},
        {"Smithsonian Astrophysical Observation", "SAO 104804"},
        {"Wilson Evans Batten Catalogue", "WEB 16684"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.18910984),
        dec: Angle.Degrees(+16.95705708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16821"},
        {"Hipparcos Number", "HIP 12634"},
        {"Smithsonian Astrophysical Observation", "SAO 93063"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58475810),
        dec: Angle.Degrees(+16.95907480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52124"},
        {"Hipparcos Number", "HIP 33752"},
        {"Smithsonian Astrophysical Observation", "SAO 96371"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16298829),
        dec: Angle.Degrees(+16.95920627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4582"},
        {"Hipparcos Number", "HIP 3728"},
        {"Smithsonian Astrophysical Observation", "SAO 92091"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.96839480),
        dec: Angle.Degrees(+16.95924340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23735"},
        {"Hipparcos Number", "HIP 17746"},
        {"Geneva Identification System", "GEN# +1.00023735"},
        {"Smithsonian Astrophysical Observation", "SAO 93608"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.00112719),
        dec: Angle.Degrees(+16.96254928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93600",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11992 B"},
        {"Hipparcos Number", "HIP 93600"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.92423660),
        dec: Angle.Degrees(+16.96332962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129972"},
        {"Hipparcos Number", "HIP 72125"},
        {"Geneva Identification System", "GEN# +1.00129972"},
        {"Smithsonian Astrophysical Observation", "SAO 101184"},
        {"Wilson Evans Batten Catalogue", "WEB 12410"},
    },
    visualMagnitude: 4.60,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.31040511),
        dec: Angle.Degrees(+16.96440296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61774"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.91301983),
        dec: Angle.Degrees(+16.96561363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93601",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11992 A"},
        {"Henry Draper", "HD 177349"},
        {"Hipparcos Number", "HIP 93601"},
        {"Smithsonian Astrophysical Observation", "SAO 104422"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.92591247),
        dec: Angle.Degrees(+16.96623478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56578"},
        {"Geneva Identification System", "GEN# +0.01702376"},
        {"Wilson Evans Batten Catalogue", "WEB 10171"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.99646515),
        dec: Angle.Degrees(+16.96834273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47455"},
        {"Smithsonian Astrophysical Observation", "SAO 98702"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.10304279),
        dec: Angle.Degrees(+16.96881615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230987"},
        {"Hipparcos Number", "HIP 94607"},
        {"Smithsonian Astrophysical Observation", "SAO 104651"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.79096681),
        dec: Angle.Degrees(+16.96960820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123303"},
        {"Hipparcos Number", "HIP 68913"},
        {"Smithsonian Astrophysical Observation", "SAO 100852"},
        {"Wilson Evans Batten Catalogue", "WEB 12041"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62333543),
        dec: Angle.Degrees(+16.97019974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64113"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.10337951),
        dec: Angle.Degrees(+16.97198984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3564"},
        {"Geneva Identification System", "GEN# +9.80033009"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.38927612),
        dec: Angle.Degrees(+16.97214002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58365"},
        {"Hipparcos Number", "HIP 36073"},
        {"Smithsonian Astrophysical Observation", "SAO 96890"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.49670542),
        dec: Angle.Degrees(+16.97344221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217755"},
        {"Hipparcos Number", "HIP 113808"},
        {"Smithsonian Astrophysical Observation", "SAO 108359"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.69712827),
        dec: Angle.Degrees(+16.97494681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94291"},
        {"Hipparcos Number", "HIP 53225"},
        {"Geneva Identification System", "GEN# +1.00094291"},
        {"Smithsonian Astrophysical Observation", "SAO 99341"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.30601371),
        dec: Angle.Degrees(+16.97559935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50664"},
        {"Hipparcos Number", "HIP 33230"},
        {"Smithsonian Astrophysical Observation", "SAO 96267"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.71833978),
        dec: Angle.Degrees(+16.97575492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91159",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11483 AB"},
        {"Henry Draper", "HD 171746"},
        {"Hipparcos Number", "HIP 91159"},
        {"Geneva Identification System", "GEN# +1.00171746"},
        {"Smithsonian Astrophysical Observation", "SAO 103886"},
        {"Wilson Evans Batten Catalogue", "WEB 15655"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97163554),
        dec: Angle.Degrees(+16.97586994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54986"},
        {"Hipparcos Number", "HIP 34763"},
        {"Smithsonian Astrophysical Observation", "SAO 96611"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.94517387),
        dec: Angle.Degrees(+16.97642385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5112 AB"},
        {"Henry Draper", "HD 45688"},
        {"Hipparcos Number", "HIP 30941"},
        {"Geneva Identification System", "GEN# +1.00045688J"},
        {"Smithsonian Astrophysical Observation", "SAO 95741"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.40593597),
        dec: Angle.Degrees(+16.97720377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145646"},
        {"Hipparcos Number", "HIP 79338"},
        {"Geneva Identification System", "GEN# +1.00145646"},
        {"Smithsonian Astrophysical Observation", "SAO 101992"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.87528783),
        dec: Angle.Degrees(+16.97768092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201657"},
        {"Hipparcos Number", "HIP 104542"},
        {"Geneva Identification System", "GEN# +1.00201657"},
        {"Smithsonian Astrophysical Observation", "SAO 106895"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.63962949),
        dec: Angle.Degrees(+16.97953533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111920"},
        {"Smithsonian Astrophysical Observation", "SAO 108084"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.06128744),
        dec: Angle.Degrees(+16.97982799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2020"},
        {"Hipparcos Number", "HIP 1946"},
        {"Geneva Identification System", "GEN# +1.00002020"},
        {"Smithsonian Astrophysical Observation", "SAO 91879"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.15145220),
        dec: Angle.Degrees(+16.97983528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90862"},
        {"Hipparcos Number", "HIP 51388"},
        {"Geneva Identification System", "GEN# +1.00090862"},
        {"Smithsonian Astrophysical Observation", "SAO 99158"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.43507123),
        dec: Angle.Degrees(+16.97998462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35147"},
        {"Hipparcos Number", "HIP 25195"},
        {"Geneva Identification System", "GEN# +1.00035147"},
        {"Smithsonian Astrophysical Observation", "SAO 94509"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.86054681),
        dec: Angle.Degrees(+16.98186124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3551"},
        {"Geneva Identification System", "GEN# +0.01600071"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.34030450),
        dec: Angle.Degrees(+16.98439472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353127"},
        {"Hipparcos Number", "HIP 102844"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.51990114),
        dec: Angle.Degrees(+16.98465394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43162"},
        {"Smithsonian Astrophysical Observation", "SAO 98123"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.86899490),
        dec: Angle.Degrees(+16.98489162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99948"},
        {"Hipparcos Number", "HIP 56101"},
        {"Fundamental Katalog 5th Edition", "FK5 5013"},
        {"Smithsonian Astrophysical Observation", "SAO 99633"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.49372132),
        dec: Angle.Degrees(+16.98529160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82261"},
        {"Smithsonian Astrophysical Observation", "SAO 102398"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.12029454),
        dec: Angle.Degrees(+16.98759286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224808"},
        {"Hipparcos Number", "HIP 68"},
        {"Cincinnati Publication", "Ci 18 3150"},
        {"Geneva Identification System", "GEN# +1.00224808"},
        {"Smithsonian Astrophysical Observation", "SAO 108960"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.20063628),
        dec: Angle.Degrees(+16.98896499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -315.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4845"},
        {"Hipparcos Number", "HIP 3944"},
        {"Smithsonian Astrophysical Observation", "SAO 92113"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.65780780),
        dec: Angle.Degrees(+16.98984687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60222"},
        {"Geneva Identification System", "GEN# +0.01702464"},
        {"Smithsonian Astrophysical Observation", "SAO 100055"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.23604009),
        dec: Angle.Degrees(+16.98989844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9831 AB"},
        {"Henry Draper", "HD 142455"},
        {"Hipparcos Number", "HIP 77875"},
        {"Smithsonian Astrophysical Observation", "SAO 101804"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.54285127),
        dec: Angle.Degrees(+16.99110244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40681"},
        {"Hipparcos Number", "HIP 28509"},
        {"Celescope Catalog", "CEL 1058"},
        {"Geneva Identification System", "GEN# +1.00040681"},
        {"Smithsonian Astrophysical Observation", "SAO 95117"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27343256),
        dec: Angle.Degrees(+16.99148003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195612"},
        {"Hipparcos Number", "HIP 101290"},
        {"Smithsonian Astrophysical Observation", "SAO 106204"},
        {"Wilson Evans Batten Catalogue", "WEB 18303"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.96767450),
        dec: Angle.Degrees(+16.99175821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2085"},
        {"Hipparcos Number", "HIP 1989"},
        {"Geneva Identification System", "GEN# +1.00002085"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.29567764),
        dec: Angle.Degrees(+16.99205716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73704"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.97473547),
        dec: Angle.Degrees(+16.99215945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44904"},
        {"Hipparcos Number", "HIP 30532"},
        {"Celescope Catalog", "CEL 1225"},
        {"Fundamental Katalog 5th Edition", "FK5 4581"},
        {"Geneva Identification System", "GEN# +1.00044904"},
        {"Smithsonian Astrophysical Observation", "SAO 95648"},
        {"Wilson Evans Batten Catalogue", "WEB 6084"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.27382061),
        dec: Angle.Degrees(+16.99470026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29038"},
        {"Hipparcos Number", "HIP 21359"},
        {"Geneva Identification System", "GEN# +1.00029038"},
        {"Smithsonian Astrophysical Observation", "SAO 94018"},
        {"Wilson Evans Batten Catalogue", "WEB 4102"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.74422677),
        dec: Angle.Degrees(+16.99488119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68098"},
        {"Hipparcos Number", "HIP 40113"},
        {"Geneva Identification System", "GEN# +1.00068098"},
        {"Smithsonian Astrophysical Observation", "SAO 97634"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.89666237),
        dec: Angle.Degrees(+16.99795582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285252"},
        {"Hipparcos Number", "HIP 18327"},
        {"Geneva Identification System", "GEN# +5.20250007"},
        {"Smithsonian Astrophysical Observation", "SAO 93671"},
        {"Wilson Evans Batten Catalogue", "WEB 3538"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.77671455),
        dec: Angle.Degrees(+16.99853743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 354615"},
        {"Hipparcos Number", "HIP 98825"},
        {"Smithsonian Astrophysical Observation", "SAO 105636"},
        {"Wilson Evans Batten Catalogue", "WEB 17523"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.03744347),
        dec: Angle.Degrees(+17.00079669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88868"},
        {"Smithsonian Astrophysical Observation", "SAO 103418"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.14920278),
        dec: Angle.Degrees(+17.00264539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168364"},
        {"Hipparcos Number", "HIP 89720"},
        {"Geneva Identification System", "GEN# +1.00168364"},
        {"Smithsonian Astrophysical Observation", "SAO 103590"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.65234954),
        dec: Angle.Degrees(+17.00298767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35369"},
        {"Smithsonian Astrophysical Observation", "SAO 96747"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.58789013),
        dec: Angle.Degrees(+17.00393002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62459"},
        {"Hipparcos Number", "HIP 37769"},
        {"Smithsonian Astrophysical Observation", "SAO 97207"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.17075868),
        dec: Angle.Degrees(+17.00459981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249536"},
        {"Hipparcos Number", "HIP 28167"},
        {"Smithsonian Astrophysical Observation", "SAO 95033"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28162075),
        dec: Angle.Degrees(+17.01078187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177394"},
        {"Hipparcos Number", "HIP 93617"},
        {"Smithsonian Astrophysical Observation", "SAO 104426"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.96978918),
        dec: Angle.Degrees(+17.01160992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101486"},
        {"Hipparcos Number", "HIP 56981"},
        {"Smithsonian Astrophysical Observation", "SAO 99732"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.21230386),
        dec: Angle.Degrees(+17.01262096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222268"},
        {"Hipparcos Number", "HIP 116702"},
        {"Smithsonian Astrophysical Observation", "SAO 108747"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.75131818),
        dec: Angle.Degrees(+17.01420544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37922",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6349 A"},
        {"Henry Draper", "HD 62766"},
        {"Hipparcos Number", "HIP 37922"},
        {"Geneva Identification System", "GEN# +1.00062766"},
        {"Smithsonian Astrophysical Observation", "SAO 97223"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.56835659),
        dec: Angle.Degrees(+17.01426419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67743"},
        {"Hipparcos Number", "HIP 39990"},
        {"Smithsonian Astrophysical Observation", "SAO 97614"},
        {"Wilson Evans Batten Catalogue", "WEB 7795"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.50379074),
        dec: Angle.Degrees(+17.01651233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64797",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8841 A"},
        {"Henry Draper", "HD 115404"},
        {"Hipparcos Number", "HIP 64797"},
        {"Cincinnati Publication", "Ci 20 767"},
        {"Geneva Identification System", "GEN# +1.00115404"},
        {"Smithsonian Astrophysical Observation", "SAO 100491"},
        {"Wilson Evans Batten Catalogue", "WEB 11452"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.21111349),
        dec: Angle.Degrees(+17.01781641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 631.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34252"},
        {"Hipparcos Number", "HIP 24609"},
        {"Geneva Identification System", "GEN# +1.00034252"},
        {"Smithsonian Astrophysical Observation", "SAO 94432"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.17700846),
        dec: Angle.Degrees(+17.02003001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88580"},
        {"Hipparcos Number", "HIP 50053"},
        {"Geneva Identification System", "GEN# +1.00088580"},
        {"Smithsonian Astrophysical Observation", "SAO 99006"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.28961715),
        dec: Angle.Degrees(+17.02023375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71635"},
        {"Smithsonian Astrophysical Observation", "SAO 101126"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.78393222),
        dec: Angle.Degrees(+17.02042844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191066"},
        {"Hipparcos Number", "HIP 99128"},
        {"Geneva Identification System", "GEN# +1.00191066"},
        {"Smithsonian Astrophysical Observation", "SAO 105716"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.87051001),
        dec: Angle.Degrees(+17.02055814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17176"},
        {"Hipparcos Number", "HIP 12893"},
        {"Smithsonian Astrophysical Observation", "SAO 93089"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.42949144),
        dec: Angle.Degrees(+17.02115151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10995"},
        {"Hipparcos Number", "HIP 8399"},
        {"Geneva Identification System", "GEN# +1.00010995"},
        {"Smithsonian Astrophysical Observation", "SAO 92638"},
        {"Wilson Evans Batten Catalogue", "WEB 1785"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.08674534),
        dec: Angle.Degrees(+17.02264629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56476"},
    },
    visualMagnitude: 11.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.68352462),
        dec: Angle.Degrees(+17.02510665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12063"},
        {"Hipparcos Number", "HIP 9240"},
        {"Smithsonian Astrophysical Observation", "SAO 92732"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.69760650),
        dec: Angle.Degrees(+17.02594336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31153"},
        {"Hipparcos Number", "HIP 22782"},
        {"Geneva Identification System", "GEN# +5.20250146"},
        {"Smithsonian Astrophysical Observation", "SAO 94187"},
        {"Wilson Evans Batten Catalogue", "WEB 4410"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.51251267),
        dec: Angle.Degrees(+17.02682678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19447"},
        {"Hipparcos Number", "HIP 14569"},
        {"Geneva Identification System", "GEN# +1.00019447"},
        {"Smithsonian Astrophysical Observation", "SAO 93290"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.02675635),
        dec: Angle.Degrees(+17.02737979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68115"},
        {"Smithsonian Astrophysical Observation", "SAO 100782"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.18025611),
        dec: Angle.Degrees(+17.02740702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28124"},
        {"Hipparcos Number", "HIP 20756"},
        {"Smithsonian Astrophysical Observation", "SAO 93938"},
        {"Wilson Evans Batten Catalogue", "WEB 3981"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.71298475),
        dec: Angle.Degrees(+17.02875980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75431"},
        {"Hipparcos Number", "HIP 43412"},
        {"Smithsonian Astrophysical Observation", "SAO 98159"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.63876676),
        dec: Angle.Degrees(+17.03206277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160956"},
        {"Hipparcos Number", "HIP 86636"},
        {"Geneva Identification System", "GEN# +1.00160956"},
        {"Smithsonian Astrophysical Observation", "SAO 103037"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.52832667),
        dec: Angle.Degrees(+17.03350856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69172"},
        {"Smithsonian Astrophysical Observation", "SAO 100880"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.38274004),
        dec: Angle.Degrees(+17.03798826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108623"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.07994042),
        dec: Angle.Degrees(+17.03912091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231416"},
        {"Hipparcos Number", "HIP 95583"},
        {"Geneva Identification System", "GEN# +1.00231416"},
        {"Smithsonian Astrophysical Observation", "SAO 104837"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.62319311),
        dec: Angle.Degrees(+17.03914361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157121"},
        {"Hipparcos Number", "HIP 84875"},
        {"Smithsonian Astrophysical Observation", "SAO 102762"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.19093259),
        dec: Angle.Degrees(+17.04001473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62718"},
        {"Geneva Identification System", "GEN# +0.01702549"},
        {"Smithsonian Astrophysical Observation", "SAO 100299"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.79059981),
        dec: Angle.Degrees(+17.04008700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37147"},
        {"Hipparcos Number", "HIP 26382"},
        {"Geneva Identification System", "GEN# +5.20250168"},
        {"Smithsonian Astrophysical Observation", "SAO 94700"},
        {"Wilson Evans Batten Catalogue", "WEB 5204"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26545679),
        dec: Angle.Degrees(+17.04040910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151122"},
        {"Hipparcos Number", "HIP 81974"},
        {"Smithsonian Astrophysical Observation", "SAO 102360"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.18585455),
        dec: Angle.Degrees(+17.04314289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34128"},
        {"Smithsonian Astrophysical Observation", "SAO 96450"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.15142916),
        dec: Angle.Degrees(+17.04381032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
