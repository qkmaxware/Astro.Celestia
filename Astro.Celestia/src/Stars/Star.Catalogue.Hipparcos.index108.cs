using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_108() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237619"},
        {"Hipparcos Number", "HIP 36271"},
        {"Smithsonian Astrophysical Observation", "SAO 26352"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01718803),
        dec: Angle.Degrees(+55.78720965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108889"},
        {"Smithsonian Astrophysical Observation", "SAO 34007"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.85828060),
        dec: Angle.Degrees(+55.78742097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238877"},
        {"Hipparcos Number", "HIP 90495"},
        {"Geneva Identification System", "GEN# +1.00238877"},
        {"Smithsonian Astrophysical Observation", "SAO 30991"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.99120882),
        dec: Angle.Degrees(+55.78827596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239699"},
        {"Hipparcos Number", "HIP 106492"},
        {"Smithsonian Astrophysical Observation", "SAO 33537"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.54575004),
        dec: Angle.Degrees(+55.79061617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232206"},
        {"Hipparcos Number", "HIP 2432"},
        {"Geneva Identification System", "GEN# +1.00232206"},
        {"Smithsonian Astrophysical Observation", "SAO 21468"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.75084557),
        dec: Angle.Degrees(+55.79098557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107929",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15405 B"},
        {"Henry Draper", "HD 208063"},
        {"Hipparcos Number", "HIP 107929"},
        {"Geneva Identification System", "GEN# +1.00208063"},
        {"Geneva Identification System 2", "GEN# +1.00208095B"},
        {"Renson", "Renson 57840"},
        {"Smithsonian Astrophysical Observation", "SAO 33817"},
        {"Wilson Evans Batten Catalogue", "WEB 19463"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.00185977),
        dec: Angle.Degrees(+55.79193672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1845"},
        {"Hipparcos Number", "HIP 1834"},
        {"Geneva Identification System", "GEN# +1.00001845"},
        {"Smithsonian Astrophysical Observation", "SAO 21343"},
        {"Wilson Evans Batten Catalogue", "WEB 326"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.80937510),
        dec: Angle.Degrees(+55.79258099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237761"},
        {"Hipparcos Number", "HIP 43740"},
        {"Smithsonian Astrophysical Observation", "SAO 27038"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.62886693),
        dec: Angle.Degrees(+55.79280212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13669"},
        {"Hipparcos Number", "HIP 10475"},
        {"Celescope Catalog", "CEL 229"},
        {"Geneva Identification System", "GEN# +1.00013669"},
        {"Smithsonian Astrophysical Observation", "SAO 23079"},
        {"Wilson Evans Batten Catalogue", "WEB 2195"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.76084727),
        dec: Angle.Degrees(+55.79322857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186239"},
        {"Hipparcos Number", "HIP 96777"},
        {"Geneva Identification System", "GEN# +1.00186239"},
        {"Smithsonian Astrophysical Observation", "SAO 31882"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.06706405),
        dec: Angle.Degrees(+55.79390657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107930",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15405 A"},
        {"Henry Draper", "HD 208095"},
        {"Hipparcos Number", "HIP 107930"},
        {"Celescope Catalog", "CEL 5396"},
        {"Geneva Identification System", "GEN# +1.00208095A"},
        {"Smithsonian Astrophysical Observation", "SAO 33819"},
        {"Wilson Evans Batten Catalogue", "WEB 19464"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.00426049),
        dec: Angle.Degrees(+55.79674452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209654"},
        {"Hipparcos Number", "HIP 108887"},
        {"Geneva Identification System", "GEN# +1.00209654"},
        {"Smithsonian Astrophysical Observation", "SAO 34005"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.85348802),
        dec: Angle.Degrees(+55.79756427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202987"},
        {"Hipparcos Number", "HIP 105080"},
        {"Fundamental Katalog 5th Edition", "FK5 3699"},
        {"Geneva Identification System", "GEN# +1.00202987"},
        {"Smithsonian Astrophysical Observation", "SAO 33287"},
        {"Wilson Evans Batten Catalogue", "WEB 19087"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.30929003),
        dec: Angle.Degrees(+55.79796866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4603"},
        {"Hipparcos Number", "HIP 3784"},
        {"Smithsonian Astrophysical Observation", "SAO 21725"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.16482950),
        dec: Angle.Degrees(+55.79873408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5854 B"},
        {"Hipparcos Number", "HIP 34869"},
        {"Smithsonian Astrophysical Observation", "SAO 26217"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.22222837),
        dec: Angle.Degrees(+55.79873452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237114"},
        {"Hipparcos Number", "HIP 15377"},
        {"Geneva Identification System", "GEN# +1.00237114"},
        {"Smithsonian Astrophysical Observation", "SAO 23937"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.57766008),
        dec: Angle.Degrees(+55.79943801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146813"},
        {"Hipparcos Number", "HIP 79649"},
        {"Geneva Identification System", "GEN# +1.00146813"},
        {"Smithsonian Astrophysical Observation", "SAO 29857"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81168083),
        dec: Angle.Degrees(+55.79955167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240072"},
        {"Hipparcos Number", "HIP 112608"},
        {"Geneva Identification System", "GEN# +1.00240072"},
        {"Smithsonian Astrophysical Observation", "SAO 34840"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.10589214),
        dec: Angle.Degrees(+55.79964305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222932"},
        {"Hipparcos Number", "HIP 117133"},
        {"Geneva Identification System", "GEN# +1.00222932"},
        {"Smithsonian Astrophysical Observation", "SAO 35728"},
        {"Wilson Evans Batten Catalogue", "WEB 20646"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.20152941),
        dec: Angle.Degrees(+55.79969308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1873"},
        {"Hipparcos Number", "HIP 1852"},
        {"Geneva Identification System", "GEN# +1.00001873"},
        {"Smithsonian Astrophysical Observation", "SAO 21351"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.85057734),
        dec: Angle.Degrees(+55.80215829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5854 A"},
        {"Henry Draper", "HD 54649"},
        {"Hipparcos Number", "HIP 34866"},
        {"Smithsonian Astrophysical Observation", "SAO 26215"},
        {"Wilson Evans Batten Catalogue", "WEB 6972"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.21237761),
        dec: Angle.Degrees(+55.80345704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6620 A"},
        {"Henry Draper", "HD 67317"},
        {"Hipparcos Number", "HIP 40006"},
        {"Renson", "Renson 18580"},
        {"Smithsonian Astrophysical Observation", "SAO 26702"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.55242321),
        dec: Angle.Degrees(+55.80446076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56661"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.26713559),
        dec: Angle.Degrees(+55.80606833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220058"},
        {"Hipparcos Number", "HIP 115224"},
        {"Celescope Catalog", "CEL 5599"},
        {"Geneva Identification System", "GEN# +1.00220058"},
        {"Smithsonian Astrophysical Observation", "SAO 35333"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.07924700),
        dec: Angle.Degrees(+55.80780216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194667"},
        {"Hipparcos Number", "HIP 100634"},
        {"Geneva Identification System", "GEN# +1.00194667"},
        {"Smithsonian Astrophysical Observation", "SAO 32532"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.08484125),
        dec: Angle.Degrees(+55.81610539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45388"},
        {"Hipparcos Number", "HIP 30999"},
        {"Geneva Identification System", "GEN# +1.00045388"},
        {"Smithsonian Astrophysical Observation", "SAO 25768"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.59076574),
        dec: Angle.Degrees(+55.81628978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143078"},
        {"Hipparcos Number", "HIP 77989"},
        {"Smithsonian Astrophysical Observation", "SAO 29714"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.88392640),
        dec: Angle.Degrees(+55.81713753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9354"},
        {"Hipparcos Number", "HIP 7247"},
        {"Smithsonian Astrophysical Observation", "SAO 22387"},
        {"Wilson Evans Batten Catalogue", "WEB 1559"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.33866261),
        dec: Angle.Degrees(+55.81770036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122315"},
        {"Hipparcos Number", "HIP 68361"},
        {"Smithsonian Astrophysical Observation", "SAO 28963"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.90185863),
        dec: Angle.Degrees(+55.81797984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211430"},
        {"Hipparcos Number", "HIP 109894"},
        {"Celescope Catalog", "CEL 5460"},
        {"Geneva Identification System", "GEN# +1.00211430"},
        {"Smithsonian Astrophysical Observation", "SAO 34238"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.87246436),
        dec: Angle.Degrees(+55.81856753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51113"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.64622177),
        dec: Angle.Degrees(+55.82325676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31189"},
        {"Hipparcos Number", "HIP 22994"},
        {"Smithsonian Astrophysical Observation", "SAO 24925"},
        {"Wilson Evans Batten Catalogue", "WEB 4463"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.20619420),
        dec: Angle.Degrees(+55.82417369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5553"},
        {"Hipparcos Number", "HIP 4538"},
        {"Geneva Identification System", "GEN# +1.00005553"},
        {"Smithsonian Astrophysical Observation", "SAO 21886"},
        {"Wilson Evans Batten Catalogue", "WEB 821"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.53205969),
        dec: Angle.Degrees(+55.82437986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14331"},
        {"Hipparcos Number", "HIP 10935"},
        {"Celescope Catalog", "CEL 256"},
        {"Geneva Identification System", "GEN# +1.00014331"},
        {"Smithsonian Astrophysical Observation", "SAO 23215"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.21419055),
        dec: Angle.Degrees(+55.82537896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142531"},
        {"Hipparcos Number", "HIP 77738"},
        {"Fundamental Katalog 5th Edition", "FK5 3255"},
        {"Geneva Identification System", "GEN# +1.00142531"},
        {"Smithsonian Astrophysical Observation", "SAO 29698"},
        {"Wilson Evans Batten Catalogue", "WEB 13153"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.06909055),
        dec: Angle.Degrees(+55.82658167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238061"},
        {"Hipparcos Number", "HIP 58672"},
        {"Smithsonian Astrophysical Observation", "SAO 28222"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.45408400),
        dec: Angle.Degrees(+55.82703162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145694"},
        {"Hipparcos Number", "HIP 79164"},
        {"Fundamental Katalog 5th Edition", "FK5 5424"},
        {"Geneva Identification System", "GEN# +1.00145694"},
        {"Smithsonian Astrophysical Observation", "SAO 29825"},
        {"Wilson Evans Batten Catalogue", "WEB 13383"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.35836422),
        dec: Angle.Degrees(+55.82891851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239489"},
        {"Hipparcos Number", "HIP 102334"},
        {"Geneva Identification System", "GEN# +1.00239489"},
        {"Smithsonian Astrophysical Observation", "SAO 32842"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.01019932),
        dec: Angle.Degrees(+55.82931065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240010"},
        {"Hipparcos Number", "HIP 111785"},
        {"Geneva Identification System", "GEN# +1.00240010"},
        {"Smithsonian Astrophysical Observation", "SAO 34649"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.63263569),
        dec: Angle.Degrees(+55.83483524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107761"},
        {"Hipparcos Number", "HIP 60365"},
        {"Smithsonian Astrophysical Observation", "SAO 28357"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.66955866),
        dec: Angle.Degrees(+55.83516536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217851"},
        {"Hipparcos Number", "HIP 113803"},
        {"Smithsonian Astrophysical Observation", "SAO 35095"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68866573),
        dec: Angle.Degrees(+55.83528711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30518"},
        {"Hipparcos Number", "HIP 22569"},
        {"Smithsonian Astrophysical Observation", "SAO 24872"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.86286039),
        dec: Angle.Degrees(+55.83722651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115459"},
        {"Hipparcos Number", "HIP 64756"},
        {"Geneva Identification System", "GEN# +1.00115459"},
        {"Smithsonian Astrophysical Observation", "SAO 28700"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.06768683),
        dec: Angle.Degrees(+55.83797538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72720"},
        {"Hipparcos Number", "HIP 42261"},
        {"Smithsonian Astrophysical Observation", "SAO 26924"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.26445216),
        dec: Angle.Degrees(+55.83921459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97167"},
    },
    visualMagnitude: 10.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.24372685),
        dec: Angle.Degrees(+55.83923253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240133"},
        {"Hipparcos Number", "HIP 113380"},
        {"Geneva Identification System", "GEN# +1.00240133"},
        {"Smithsonian Astrophysical Observation", "SAO 35004"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.43353619),
        dec: Angle.Degrees(+55.83924581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94831"},
        {"Hipparcos Number", "HIP 53584"},
        {"Geneva Identification System", "GEN# +1.00094831"},
        {"Smithsonian Astrophysical Observation", "SAO 27847"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.43873301),
        dec: Angle.Degrees(+55.83998643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118057",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17114 AB"},
        {"Henry Draper", "HD 224320"},
        {"Hipparcos Number", "HIP 118057"},
        {"Smithsonian Astrophysical Observation", "SAO 35913"},
        {"Wilson Evans Batten Catalogue", "WEB 20758"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.23180785),
        dec: Angle.Degrees(+55.84035364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26146"},
        {"Hipparcos Number", "HIP 19547"},
        {"Geneva Identification System", "GEN# +1.00026146"},
        {"Smithsonian Astrophysical Observation", "SAO 24457"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.79330194),
        dec: Angle.Degrees(+55.84300420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1802 A"},
        {"Henry Draper", "HD 14489"},
        {"Hipparcos Number", "HIP 11060"},
        {"Celescope Catalog", "CEL 262"},
        {"Fundamental Katalog 5th Edition", "FK5 2159"},
        {"Geneva Identification System", "GEN# +1.00014489"},
        {"Smithsonian Astrophysical Observation", "SAO 23256"},
        {"Wilson Evans Batten Catalogue", "WEB 2326"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.58930899),
        dec: Angle.Degrees(+55.84565637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110259"},
        {"Hipparcos Number", "HIP 61839"},
        {"Smithsonian Astrophysical Observation", "SAO 28471"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.08868334),
        dec: Angle.Degrees(+55.84655306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6239"},
        {"Hipparcos Number", "HIP 5012"},
        {"Smithsonian Astrophysical Observation", "SAO 21970"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.05892772),
        dec: Angle.Degrees(+55.84683081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187053"},
        {"Hipparcos Number", "HIP 97170"},
        {"Smithsonian Astrophysical Observation", "SAO 31956"},
        {"Wilson Evans Batten Catalogue", "WEB 17061"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.25031944),
        dec: Angle.Degrees(+55.84764122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65469"},
        {"Hipparcos Number", "HIP 39265"},
        {"Smithsonian Astrophysical Observation", "SAO 26626"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.44247348),
        dec: Angle.Degrees(+55.84868881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209706"},
        {"Hipparcos Number", "HIP 108921"},
        {"Geneva Identification System", "GEN# +1.00209706"},
        {"Smithsonian Astrophysical Observation", "SAO 34013"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.95028001),
        dec: Angle.Degrees(+55.84907528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13971"},
        {"Hipparcos Number", "HIP 10698"},
        {"Geneva Identification System", "GEN# +1.00013971"},
        {"Smithsonian Astrophysical Observation", "SAO 23137"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.42805398),
        dec: Angle.Degrees(+55.85032367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99283"},
        {"Hipparcos Number", "HIP 55797"},
        {"Smithsonian Astrophysical Observation", "SAO 28017"},
        {"Wilson Evans Batten Catalogue", "WEB 10030"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.48826775),
        dec: Angle.Degrees(+55.85034058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53409"},
        {"Hipparcos Number", "HIP 34422"},
        {"Geneva Identification System", "GEN# +1.00053409"},
        {"Smithsonian Astrophysical Observation", "SAO 26168"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.03929754),
        dec: Angle.Degrees(+55.85179597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215501"},
        {"Hipparcos Number", "HIP 112282"},
        {"Geneva Identification System", "GEN# +1.00215501"},
        {"Smithsonian Astrophysical Observation", "SAO 34752"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.14717669),
        dec: Angle.Degrees(+55.85682942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 842"},
        {"Hipparcos Number", "HIP 1039"},
        {"Geneva Identification System", "GEN# +1.00000842"},
        {"Smithsonian Astrophysical Observation", "SAO 21214"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.25145846),
        dec: Angle.Degrees(+55.85901187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76854"},
        {"Hipparcos Number", "HIP 44289"},
        {"Geneva Identification System", "GEN# +1.00076854"},
        {"Smithsonian Astrophysical Observation", "SAO 27084"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.29759055),
        dec: Angle.Degrees(+55.85995209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76428"},
        {"Hipparcos Number", "HIP 44065"},
        {"Geneva Identification System", "GEN# +1.00076428"},
        {"Smithsonian Astrophysical Observation", "SAO 27064"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.62112328),
        dec: Angle.Degrees(+55.86159026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238895"},
        {"Hipparcos Number", "HIP 90857"},
        {"Smithsonian Astrophysical Observation", "SAO 31033"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.02792597),
        dec: Angle.Degrees(+55.86504684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237951"},
        {"Hipparcos Number", "HIP 53517"},
        {"Smithsonian Astrophysical Observation", "SAO 27836"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.21911774),
        dec: Angle.Degrees(+55.86654477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83564"},
        {"Hipparcos Number", "HIP 47521"},
        {"Geneva Identification System", "GEN# +1.00083564"},
        {"Smithsonian Astrophysical Observation", "SAO 27340"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.31984556),
        dec: Angle.Degrees(+55.86657520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18243"},
        {"Hipparcos Number", "HIP 13833"},
        {"Smithsonian Astrophysical Observation", "SAO 23736"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.52012798),
        dec: Angle.Degrees(+55.86668431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47954"},
        {"Hipparcos Number", "HIP 32280"},
        {"Geneva Identification System", "GEN# +1.00047954"},
        {"Smithsonian Astrophysical Observation", "SAO 25919"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.08750501),
        dec: Angle.Degrees(+55.86801870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236362"},
        {"Hipparcos Number", "HIP 1291"},
        {"Geneva Identification System", "GEN# +1.00236362"},
        {"Smithsonian Astrophysical Observation", "SAO 21260"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.04539817),
        dec: Angle.Degrees(+55.86805083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23580"},
        {"Hipparcos Number", "HIP 17840"},
        {"Smithsonian Astrophysical Observation", "SAO 24240"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.26141928),
        dec: Angle.Degrees(+55.86839275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126244"},
        {"Hipparcos Number", "HIP 70253"},
        {"Geneva Identification System", "GEN# +1.00126244"},
        {"Smithsonian Astrophysical Observation", "SAO 29122"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.62399701),
        dec: Angle.Degrees(+55.86971227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 165.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13995"},
        {"Hipparcos Number", "HIP 10707"},
        {"Smithsonian Astrophysical Observation", "SAO 23142"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.46635395),
        dec: Angle.Degrees(+55.86975096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44648"},
        {"Hipparcos Number", "HIP 30623"},
        {"Geneva Identification System", "GEN# +1.00044648"},
        {"Smithsonian Astrophysical Observation", "SAO 25727"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.53684610),
        dec: Angle.Degrees(+55.87267446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222077"},
        {"Hipparcos Number", "HIP 116549"},
        {"Smithsonian Astrophysical Observation", "SAO 35603"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.30102560),
        dec: Angle.Degrees(+55.87662280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1353 A"},
        {"Henry Draper", "HD 10495"},
        {"Hipparcos Number", "HIP 8081"},
        {"Smithsonian Astrophysical Observation", "SAO 22555"},
        {"Wilson Evans Batten Catalogue", "WEB 1728"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.94607380),
        dec: Angle.Degrees(+55.87753548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22518"},
        {"Hipparcos Number", "HIP 17110"},
        {"Geneva Identification System", "GEN# +1.00022518"},
        {"Smithsonian Astrophysical Observation", "SAO 24147"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.97752834),
        dec: Angle.Degrees(+55.87895597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182511"},
        {"Hipparcos Number", "HIP 95194"},
        {"Geneva Identification System", "GEN# +1.00182511"},
        {"Smithsonian Astrophysical Observation", "SAO 31609"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.47693461),
        dec: Angle.Degrees(+55.87916153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119992"},
        {"Hipparcos Number", "HIP 67103"},
        {"Geneva Identification System", "GEN# +1.00119992"},
        {"Smithsonian Astrophysical Observation", "SAO 28878"},
        {"Wilson Evans Batten Catalogue", "WEB 11818"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.30459790),
        dec: Angle.Degrees(+55.88022143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -358.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32754"},
        {"Geneva Identification System", "GEN# +6.20030011"},
        {"Wilson Evans Batten Catalogue", "WEB 6600"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.45740098),
        dec: Angle.Degrees(+55.88287635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102597",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14316 A"},
        {"Henry Draper", "HD 239498"},
        {"Hipparcos Number", "HIP 102597"},
        {"Geneva Identification System", "GEN# +1.00239498"},
        {"Smithsonian Astrophysical Observation", "SAO 32895"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.88206563),
        dec: Angle.Degrees(+55.88494269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28383"},
        {"Hipparcos Number", "HIP 21126"},
        {"Geneva Identification System", "GEN# +1.00028383"},
        {"Smithsonian Astrophysical Observation", "SAO 24664"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.92291742),
        dec: Angle.Degrees(+55.88539935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22105"},
        {"Hipparcos Number", "HIP 16810"},
        {"Geneva Identification System", "GEN# +1.00022105"},
        {"Smithsonian Astrophysical Observation", "SAO 24119"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.09129436),
        dec: Angle.Degrees(+55.88686599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239295"},
        {"Hipparcos Number", "HIP 98671"},
        {"Geneva Identification System", "GEN# +1.00239295"},
        {"Smithsonian Astrophysical Observation", "SAO 32231"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.62045641),
        dec: Angle.Degrees(+55.88918470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92635"},
        {"Hipparcos Number", "HIP 52416"},
        {"Smithsonian Astrophysical Observation", "SAO 27742"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.72592877),
        dec: Angle.Degrees(+55.89085137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205039"},
        {"Hipparcos Number", "HIP 106198"},
        {"Geneva Identification System", "GEN# +1.00205039"},
        {"Smithsonian Astrophysical Observation", "SAO 33485"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.66542983),
        dec: Angle.Degrees(+55.89384651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207117"},
        {"Hipparcos Number", "HIP 107383"},
        {"Smithsonian Astrophysical Observation", "SAO 33720"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25168724),
        dec: Angle.Degrees(+55.89388879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39685"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.65139222),
        dec: Angle.Degrees(+55.89418609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13268",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Miram"},
        {"Aitken", "ADS 2157 A"},
        {"Henry Draper", "HD 17506"},
        {"Hipparcos Number", "HIP 13268"},
        {"Fundamental Katalog 5th Edition", "FK5 99"},
        {"Geneva Identification System", "GEN# +1.00017506A"},
        {"Smithsonian Astrophysical Observation", "SAO 23655"},
        {"Wilson Evans Batten Catalogue", "WEB 2661"},
    },
    visualMagnitude: 3.77,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.67413655),
        dec: Angle.Degrees(+55.89552955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239768"},
        {"Hipparcos Number", "HIP 107545"},
        {"Smithsonian Astrophysical Observation", "SAO 33750"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.73149036),
        dec: Angle.Degrees(+55.89845913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88999"},
        {"Hipparcos Number", "HIP 50401"},
        {"Smithsonian Astrophysical Observation", "SAO 27591"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.37645417),
        dec: Angle.Degrees(+55.89861194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139992"},
        {"Hipparcos Number", "HIP 76598"},
        {"Geneva Identification System", "GEN# +1.00139992"},
        {"Smithsonian Astrophysical Observation", "SAO 29602"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.66186018),
        dec: Angle.Degrees(+55.89906988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237975"},
        {"Hipparcos Number", "HIP 54412"},
        {"Geneva Identification System", "GEN# +1.00237975"},
        {"Smithsonian Astrophysical Observation", "SAO 27919"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.01301061),
        dec: Angle.Degrees(+55.90027785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98316"},
        {"Hipparcos Number", "HIP 55272"},
        {"Geneva Identification System", "GEN# +1.00098316"},
        {"Smithsonian Astrophysical Observation", "SAO 27986"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.79928877),
        dec: Angle.Degrees(+55.90104304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238221"},
        {"Hipparcos Number", "HIP 65212"},
        {"Geneva Identification System", "GEN# +1.00238221"},
        {"Smithsonian Astrophysical Observation", "SAO 28726"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.46551405),
        dec: Angle.Degrees(+55.90116816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216174"},
        {"Hipparcos Number", "HIP 112731"},
        {"Geneva Identification System", "GEN# +1.00216174"},
        {"Smithsonian Astrophysical Observation", "SAO 34858"},
        {"Wilson Evans Batten Catalogue", "WEB 20088"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.44261913),
        dec: Angle.Degrees(+55.90268437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63816"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.19488501),
        dec: Angle.Degrees(+55.90272477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4530 AB"},
        {"Henry Draper", "HD 39799"},
        {"Hipparcos Number", "HIP 28253"},
        {"Smithsonian Astrophysical Observation", "SAO 25491"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.55314346),
        dec: Angle.Degrees(+55.90718447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239862"},
        {"Hipparcos Number", "HIP 109249"},
        {"Geneva Identification System", "GEN# +1.00239862"},
        {"Smithsonian Astrophysical Observation", "SAO 34090"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.98881221),
        dec: Angle.Degrees(+55.90723912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186196"},
        {"Hipparcos Number", "HIP 96755"},
        {"Geneva Identification System", "GEN# +1.00186196"},
        {"Smithsonian Astrophysical Observation", "SAO 31880"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02292553),
        dec: Angle.Degrees(+55.90751228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14322"},
        {"Hipparcos Number", "HIP 10926"},
        {"Geneva Identification System", "GEN# +1.00014322"},
        {"Smithsonian Astrophysical Observation", "SAO 23214"},
        {"Wilson Evans Batten Catalogue", "WEB 2300"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.17883085),
        dec: Angle.Degrees(+55.90908136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73183"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.35829209),
        dec: Angle.Degrees(+55.90998683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 356.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236891"},
        {"Hipparcos Number", "HIP 8585"},
        {"Smithsonian Astrophysical Observation", "SAO 22670"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.70612025),
        dec: Angle.Degrees(+55.91048214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26158"},
        {"Hipparcos Number", "HIP 19551"},
        {"Smithsonian Astrophysical Observation", "SAO 24458"},
    },
    visualMagnitude: 7.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.81034414),
        dec: Angle.Degrees(+55.91051763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189611"},
        {"Hipparcos Number", "HIP 98271"},
        {"Smithsonian Astrophysical Observation", "SAO 32153"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.51129173),
        dec: Angle.Degrees(+55.91072989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238119"},
        {"Hipparcos Number", "HIP 60676"},
        {"Smithsonian Astrophysical Observation", "SAO 28384"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.52714949),
        dec: Angle.Degrees(+55.91079795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46732"},
        {"Hipparcos Number", "HIP 31726"},
        {"Smithsonian Astrophysical Observation", "SAO 25848"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.56311666),
        dec: Angle.Degrees(+55.91464316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109872"},
        {"Geneva Identification System", "GEN# +0.05502707"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.79628929),
        dec: Angle.Degrees(+55.91849292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7637"},
        {"Hipparcos Number", "HIP 6016"},
        {"Geneva Identification System", "GEN# +1.00007637"},
        {"Smithsonian Astrophysical Observation", "SAO 22152"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33392026),
        dec: Angle.Degrees(+55.91849756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236890"},
        {"Hipparcos Number", "HIP 8582"},
        {"Smithsonian Astrophysical Observation", "SAO 22666"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.68812703),
        dec: Angle.Degrees(+55.91905163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106711"},
        {"Hipparcos Number", "HIP 59834"},
        {"Geneva Identification System", "GEN# +1.00106711"},
        {"Smithsonian Astrophysical Observation", "SAO 28321"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.04071411),
        dec: Angle.Degrees(+55.92024934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23383"},
        {"Hipparcos Number", "HIP 17707"},
        {"Geneva Identification System", "GEN# +1.00023383"},
        {"Smithsonian Astrophysical Observation", "SAO 24215"},
        {"Wilson Evans Batten Catalogue", "WEB 3381"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.88383173),
        dec: Angle.Degrees(+55.92204893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16040"},
        {"Hipparcos Number", "HIP 12152"},
        {"Geneva Identification System", "GEN# +4.35020004"},
        {"Smithsonian Astrophysical Observation", "SAO 23463"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.15301268),
        dec: Angle.Degrees(+55.92538068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81898"},
        {"Hipparcos Number", "HIP 46632"},
        {"Smithsonian Astrophysical Observation", "SAO 27274"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.64583651),
        dec: Angle.Degrees(+55.92542884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114777"},
        {"Hipparcos Number", "HIP 64376"},
        {"Smithsonian Astrophysical Observation", "SAO 28672"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.91712663),
        dec: Angle.Degrees(+55.92665062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213909"},
        {"Hipparcos Number", "HIP 111346"},
        {"Smithsonian Astrophysical Observation", "SAO 34572"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.35996567),
        dec: Angle.Degrees(+55.92842789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15990"},
        {"Hipparcos Number", "HIP 12128"},
        {"Geneva Identification System", "GEN# +4.35020003"},
        {"Smithsonian Astrophysical Observation", "SAO 23455"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.05707931),
        dec: Angle.Degrees(+55.93172634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171993"},
        {"Hipparcos Number", "HIP 91065"},
        {"Smithsonian Astrophysical Observation", "SAO 31057"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.63622756),
        dec: Angle.Degrees(+55.93363399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157440"},
        {"Hipparcos Number", "HIP 84818"},
        {"Smithsonian Astrophysical Observation", "SAO 30345"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.02371371),
        dec: Angle.Degrees(+55.93541335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236657"},
        {"Hipparcos Number", "HIP 5670"},
        {"Geneva Identification System", "GEN# +1.00236657"},
        {"Smithsonian Astrophysical Observation", "SAO 22091"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.21526879),
        dec: Angle.Degrees(+55.93875404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200167"},
        {"Hipparcos Number", "HIP 103606"},
        {"Smithsonian Astrophysical Observation", "SAO 33047"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.87131954),
        dec: Angle.Degrees(+55.94009836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180656"},
        {"Hipparcos Number", "HIP 94528"},
        {"Smithsonian Astrophysical Observation", "SAO 31503"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.58534402),
        dec: Angle.Degrees(+55.94035480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236481"},
        {"Hipparcos Number", "HIP 2904"},
        {"Smithsonian Astrophysical Observation", "SAO 21563"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.19837671),
        dec: Angle.Degrees(+55.94455879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109858"},
        {"Hipparcos Number", "HIP 61610"},
        {"Geneva Identification System", "GEN# +1.00109858"},
        {"Smithsonian Astrophysical Observation", "SAO 28455"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.38626047),
        dec: Angle.Degrees(+55.94599556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209514"},
        {"Hipparcos Number", "HIP 108794"},
        {"Geneva Identification System", "GEN# +1.00209514"},
        {"Smithsonian Astrophysical Observation", "SAO 33995"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.59556978),
        dec: Angle.Degrees(+55.94614379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39628"},
        {"Hipparcos Number", "HIP 28168"},
        {"Geneva Identification System", "GEN# +1.00039628"},
        {"Smithsonian Astrophysical Observation", "SAO 25477"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28204206),
        dec: Angle.Degrees(+55.94755803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238216"},
        {"Hipparcos Number", "HIP 65024"},
        {"Smithsonian Astrophysical Observation", "SAO 28717"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.93521349),
        dec: Angle.Degrees(+55.94762893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238725"},
        {"Hipparcos Number", "HIP 86075"},
        {"Smithsonian Astrophysical Observation", "SAO 30474"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.86899921),
        dec: Angle.Degrees(+55.94858052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68204"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.44659976),
        dec: Angle.Degrees(+55.94866755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50130"},
        {"Hipparcos Number", "HIP 33245"},
        {"Renson", "Renson 13660"},
        {"Smithsonian Astrophysical Observation", "SAO 26035"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.75814340),
        dec: Angle.Degrees(+55.94878123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7494 A"},
        {"Henry Draper", "HD 83950"},
        {"Hipparcos Number", "HIP 47727"},
        {"Geneva Identification System", "GEN# +1.00083950A"},
        {"Smithsonian Astrophysical Observation", "SAO 27364"},
        {"Wilson Evans Batten Catalogue", "WEB 8943"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93938588),
        dec: Angle.Degrees(+55.95258720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239355"},
        {"Hipparcos Number", "HIP 99715"},
        {"Geneva Identification System", "GEN# +1.00239355"},
        {"Smithsonian Astrophysical Observation", "SAO 32383"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.50264043),
        dec: Angle.Degrees(+55.95310452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240407"},
        {"Hipparcos Number", "HIP 117408"},
        {"Smithsonian Astrophysical Observation", "SAO 35783"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.10156250),
        dec: Angle.Degrees(+55.95478225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224600"},
        {"Hipparcos Number", "HIP 118250"},
        {"Celescope Catalog", "CEL 5733"},
        {"Geneva Identification System", "GEN# +1.00224600"},
        {"Smithsonian Astrophysical Observation", "SAO 35950"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.77383029),
        dec: Angle.Degrees(+55.95611175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239140"},
        {"Hipparcos Number", "HIP 96384"},
        {"Smithsonian Astrophysical Observation", "SAO 31805"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.94801165),
        dec: Angle.Degrees(+55.95930313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62956",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alioth"},
        {"Henry Draper", "HD 112185"},
        {"Hipparcos Number", "HIP 62956"},
        {"Celescope Catalog", "CEL 4168"},
        {"Fundamental Katalog 5th Edition", "FK5 483"},
        {"Geneva Identification System", "GEN# +1.00112185"},
        {"Renson", "Renson 32580"},
        {"Smithsonian Astrophysical Observation", "SAO 28553"},
        {"Wilson Evans Batten Catalogue", "WEB 11163"},
    },
    visualMagnitude: 1.76,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.50680410),
        dec: Angle.Degrees(+55.95984301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16107"},
        {"Hipparcos Number", "HIP 12216"},
        {"Geneva Identification System", "GEN# +4.35020002"},
        {"Smithsonian Astrophysical Observation", "SAO 23475"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.32600458),
        dec: Angle.Degrees(+55.96019404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 143 AB"},
        {"Henry Draper", "HD 709"},
        {"Hipparcos Number", "HIP 945"},
        {"Smithsonian Astrophysical Observation", "SAO 21191"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.91222169),
        dec: Angle.Degrees(+55.96148616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212466"},
        {"Hipparcos Number", "HIP 110504"},
        {"Geneva Identification System", "GEN# +1.00212466"},
        {"Smithsonian Astrophysical Observation", "SAO 34387"},
    },
    visualMagnitude: 6.44,
    bvColour: 2.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.77924734),
        dec: Angle.Degrees(+55.96323584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41589"},
        {"Hipparcos Number", "HIP 29182"},
        {"Smithsonian Astrophysical Observation", "SAO 25592"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.34623774),
        dec: Angle.Degrees(+55.96350493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40614"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.37452533),
        dec: Angle.Degrees(+55.97003648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163929"},
        {"Hipparcos Number", "HIP 87744"},
        {"Fundamental Katalog 5th Edition", "FK5 3428"},
        {"Geneva Identification System", "GEN# +1.00163929"},
        {"Smithsonian Astrophysical Observation", "SAO 30645"},
        {"Wilson Evans Batten Catalogue", "WEB 14809"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.84840678),
        dec: Angle.Degrees(+55.97109132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1487"},
        {"Hipparcos Number", "HIP 1542"},
        {"Smithsonian Astrophysical Observation", "SAO 21295"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.80766378),
        dec: Angle.Degrees(+55.97140528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16159"},
        {"Hipparcos Number", "HIP 12249"},
        {"Geneva Identification System", "GEN# +4.35020005"},
        {"Smithsonian Astrophysical Observation", "SAO 23480"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.43477434),
        dec: Angle.Degrees(+55.97300287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236726"},
        {"Hipparcos Number", "HIP 6681"},
        {"Geneva Identification System", "GEN# +1.00236726"},
        {"Smithsonian Astrophysical Observation", "SAO 22269"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.42222462),
        dec: Angle.Degrees(+55.97429228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236526"},
        {"Hipparcos Number", "HIP 3689"},
        {"Geneva Identification System", "GEN# +1.00236526"},
        {"Smithsonian Astrophysical Observation", "SAO 21703"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.82412926),
        dec: Angle.Degrees(+55.97863627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104987"},
        {"Hipparcos Number", "HIP 58953"},
        {"Smithsonian Astrophysical Observation", "SAO 28240"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.32618104),
        dec: Angle.Degrees(+55.98030653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90839"},
        {"Hipparcos Number", "HIP 51459"},
        {"Fundamental Katalog 5th Edition", "FK5 394"},
        {"Geneva Identification System", "GEN# +1.00090839A"},
        {"Smithsonian Astrophysical Observation", "SAO 27670"},
        {"Wilson Evans Batten Catalogue", "WEB 9393"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.65735143),
        dec: Angle.Degrees(+55.98061759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212183"},
        {"Hipparcos Number", "HIP 110356"},
        {"Celescope Catalog", "CEL 5469"},
        {"Geneva Identification System", "GEN# +1.00212183"},
        {"Smithsonian Astrophysical Observation", "SAO 34346"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.26615325),
        dec: Angle.Degrees(+55.98582274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15461"},
        {"Hipparcos Number", "HIP 11730"},
        {"Geneva Identification System", "GEN# +1.00015461"},
        {"Smithsonian Astrophysical Observation", "SAO 23396"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.85861431),
        dec: Angle.Degrees(+55.98596291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72792"},
        {"Hipparcos Number", "HIP 42297"},
        {"Geneva Identification System", "GEN# +1.00072792"},
        {"Renson", "Renson 20170"},
        {"Smithsonian Astrophysical Observation", "SAO 26928"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.35771914),
        dec: Angle.Degrees(+55.98598963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224257"},
        {"Hipparcos Number", "HIP 118023"},
        {"Celescope Catalog", "CEL 5717"},
        {"Geneva Identification System", "GEN# +1.00224257"},
        {"Smithsonian Astrophysical Observation", "SAO 35907"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.10403423),
        dec: Angle.Degrees(+55.99035365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223988"},
        {"Hipparcos Number", "HIP 117855"},
        {"Geneva Identification System", "GEN# +1.00223988"},
        {"Smithsonian Astrophysical Observation", "SAO 35878"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.56911312),
        dec: Angle.Degrees(+55.99226139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2824"},
        {"Hipparcos Number", "HIP 2526"},
        {"Smithsonian Astrophysical Observation", "SAO 21492"},
        {"Wilson Evans Batten Catalogue", "WEB 463"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.01766844),
        dec: Angle.Degrees(+55.99417417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13745"},
        {"Hipparcos Number", "HIP 10541"},
        {"Celescope Catalog", "CEL 232"},
        {"Geneva Identification System", "GEN# +1.00013745"},
        {"Smithsonian Astrophysical Observation", "SAO 23099"},
        {"Wilson Evans Batten Catalogue", "WEB 2212"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.94139662),
        dec: Angle.Degrees(+55.99632411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79493"},
        {"Hipparcos Number", "HIP 45524"},
        {"Smithsonian Astrophysical Observation", "SAO 27195"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.16799941),
        dec: Angle.Degrees(+55.99698996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152860"},
        {"Hipparcos Number", "HIP 82575"},
        {"Smithsonian Astrophysical Observation", "SAO 30139"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.21189672),
        dec: Angle.Degrees(+55.99755099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217160"},
        {"Hipparcos Number", "HIP 113370"},
        {"Geneva Identification System", "GEN# +1.00217160"},
        {"Smithsonian Astrophysical Observation", "SAO 35002"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.41665004),
        dec: Angle.Degrees(+55.99767066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209340"},
        {"Hipparcos Number", "HIP 108689"},
        {"Smithsonian Astrophysical Observation", "SAO 33972"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.26475938),
        dec: Angle.Degrees(+55.99867237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2711"},
        {"Hipparcos Number", "HIP 2450"},
        {"Geneva Identification System", "GEN# +1.00002711"},
        {"Smithsonian Astrophysical Observation", "SAO 21473"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.79402100),
        dec: Angle.Degrees(+56.00140307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110105"},
        {"Hipparcos Number", "HIP 61734"},
        {"Geneva Identification System", "GEN# +1.00110105"},
        {"Smithsonian Astrophysical Observation", "SAO 28464"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.80332305),
        dec: Angle.Degrees(+56.00394460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197101"},
        {"Hipparcos Number", "HIP 101900"},
        {"Geneva Identification System", "GEN# +1.00197101"},
        {"Smithsonian Astrophysical Observation", "SAO 32763"},
        {"Wilson Evans Batten Catalogue", "WEB 18414"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.75078432),
        dec: Angle.Degrees(+56.00494916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238128"},
        {"Hipparcos Number", "HIP 61137"},
        {"Smithsonian Astrophysical Observation", "SAO 28415"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.91863231),
        dec: Angle.Degrees(+56.00499639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237213"},
        {"Hipparcos Number", "HIP 19014"},
        {"Geneva Identification System", "GEN# +1.00237213"},
        {"Smithsonian Astrophysical Observation", "SAO 24386"},
        {"Wilson Evans Batten Catalogue", "WEB 3657"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.10232366),
        dec: Angle.Degrees(+56.00540633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114158"},
        {"Geneva Identification System", "GEN# +0.05502899"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.78658593),
        dec: Angle.Degrees(+56.00588276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213594"},
        {"Hipparcos Number", "HIP 111179"},
        {"Smithsonian Astrophysical Observation", "SAO 34546"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.84527745),
        dec: Angle.Degrees(+56.00801176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64427"},
        {"Hipparcos Number", "HIP 38840"},
        {"Smithsonian Astrophysical Observation", "SAO 26583"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.22665300),
        dec: Angle.Degrees(+56.00873608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103518"},
        {"Hipparcos Number", "HIP 58124"},
        {"Smithsonian Astrophysical Observation", "SAO 28187"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.82670199),
        dec: Angle.Degrees(+56.01044497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236669"},
        {"Hipparcos Number", "HIP 5776"},
        {"Fundamental Katalog 5th Edition", "FK5 4109"},
        {"Smithsonian Astrophysical Observation", "SAO 22114"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.52936039),
        dec: Angle.Degrees(+56.01301087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43979"},
        {"Hipparcos Number", "HIP 30307"},
        {"Geneva Identification System", "GEN# +1.00043979"},
        {"Smithsonian Astrophysical Observation", "SAO 25687"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.60838382),
        dec: Angle.Degrees(+56.01301932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67807"},
        {"Hipparcos Number", "HIP 40185"},
        {"Smithsonian Astrophysical Observation", "SAO 26722"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.13153654),
        dec: Angle.Degrees(+56.01395193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150449"},
        {"Hipparcos Number", "HIP 81437"},
        {"Fundamental Katalog 5th Edition", "FK5 3320"},
        {"Geneva Identification System", "GEN# +1.00150449"},
        {"Smithsonian Astrophysical Observation", "SAO 30026"},
        {"Wilson Evans Batten Catalogue", "WEB 13764"},
    },
    visualMagnitude: 5.28,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50191391),
        dec: Angle.Degrees(+56.01538883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17829"},
        {"Cincinnati Publication", "Ci 20 261"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.22936341),
        dec: Angle.Degrees(+56.01715384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 348.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -392.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64127"},
    },
    visualMagnitude: 10.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.15232684),
        dec: Angle.Degrees(+56.01836232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47279"},
        {"Geneva Identification System", "GEN# +0.05601395"},
        {"Wilson Evans Batten Catalogue", "WEB 8889"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.52808101),
        dec: Angle.Degrees(+56.01867766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101797"},
        {"Hipparcos Number", "HIP 57144"},
        {"Smithsonian Astrophysical Observation", "SAO 28109"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.79371213),
        dec: Angle.Degrees(+56.01981906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8909 AB"},
        {"Henry Draper", "HD 117202"},
        {"Hipparcos Number", "HIP 65645"},
        {"Smithsonian Astrophysical Observation", "SAO 28761"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.87620230),
        dec: Angle.Degrees(+56.02262184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135295"},
        {"Hipparcos Number", "HIP 74377"},
        {"Smithsonian Astrophysical Observation", "SAO 29440"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.98717403),
        dec: Angle.Degrees(+56.02515584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239500"},
        {"Hipparcos Number", "HIP 102638"},
        {"Smithsonian Astrophysical Observation", "SAO 32900"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.96001320),
        dec: Angle.Degrees(+56.02597842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18577"},
        {"Hipparcos Number", "HIP 14092"},
        {"Smithsonian Astrophysical Observation", "SAO 23770"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.43389582),
        dec: Angle.Degrees(+56.02613631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191892"},
        {"Hipparcos Number", "HIP 99294"},
        {"Smithsonian Astrophysical Observation", "SAO 32322"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.34320542),
        dec: Angle.Degrees(+56.02687302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210414"},
        {"Hipparcos Number", "HIP 109307"},
        {"Geneva Identification System", "GEN# +1.00210414"},
        {"Smithsonian Astrophysical Observation", "SAO 34103"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.17915625),
        dec: Angle.Degrees(+56.03072767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240451"},
        {"Hipparcos Number", "HIP 118022"},
        {"Smithsonian Astrophysical Observation", "SAO 35906"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.10120363),
        dec: Angle.Degrees(+56.03260317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238273"},
        {"Hipparcos Number", "HIP 66807"},
        {"Smithsonian Astrophysical Observation", "SAO 28853"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41280766),
        dec: Angle.Degrees(+56.03403896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238648"},
        {"Hipparcos Number", "HIP 83476"},
        {"Smithsonian Astrophysical Observation", "SAO 30221"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.90424313),
        dec: Angle.Degrees(+56.03492754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133666"},
        {"Hipparcos Number", "HIP 73654"},
        {"Geneva Identification System", "GEN# +1.00133666"},
        {"Smithsonian Astrophysical Observation", "SAO 29393"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.84016857),
        dec: Angle.Degrees(+56.03527238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126968"},
        {"Hipparcos Number", "HIP 70630"},
        {"Smithsonian Astrophysical Observation", "SAO 29148"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.71492559),
        dec: Angle.Degrees(+56.03627275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25021"},
        {"Hipparcos Number", "HIP 18777"},
        {"Renson", "Renson 6380"},
        {"Smithsonian Astrophysical Observation", "SAO 24348"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.33785260),
        dec: Angle.Degrees(+56.03978507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193287"},
        {"Hipparcos Number", "HIP 99955"},
        {"Smithsonian Astrophysical Observation", "SAO 32433"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.20427211),
        dec: Angle.Degrees(+56.04031574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147715"},
        {"Hipparcos Number", "HIP 80075"},
        {"Geneva Identification System", "GEN# +1.00147715"},
        {"Smithsonian Astrophysical Observation", "SAO 29903"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.14848451),
        dec: Angle.Degrees(+56.04345784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9590"},
        {"Hipparcos Number", "HIP 7401"},
        {"Celescope Catalog", "CEL 147"},
        {"Smithsonian Astrophysical Observation", "SAO 22413"},
        {"Wilson Evans Batten Catalogue", "WEB 1589"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.85797832),
        dec: Angle.Degrees(+56.04374328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239581"},
        {"Hipparcos Number", "HIP 104356"},
        {"Geneva Identification System", "GEN# +1.00239581"},
        {"Smithsonian Astrophysical Observation", "SAO 33168"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.11522705),
        dec: Angle.Degrees(+56.04534749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74458",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9546 AB"},
        {"Henry Draper", "HD 135501"},
        {"Hipparcos Number", "HIP 74458"},
        {"Smithsonian Astrophysical Observation", "SAO 29446"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.24133043),
        dec: Angle.Degrees(+56.04644026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217508"},
        {"Hipparcos Number", "HIP 113584"},
        {"Smithsonian Astrophysical Observation", "SAO 35045"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08333926),
        dec: Angle.Degrees(+56.05038028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238820"},
        {"Hipparcos Number", "HIP 88934"},
        {"Smithsonian Astrophysical Observation", "SAO 30774"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.30913310),
        dec: Angle.Degrees(+56.05176388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237909"},
        {"Hipparcos Number", "HIP 51833"},
        {"Smithsonian Astrophysical Observation", "SAO 27697"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.85058401),
        dec: Angle.Degrees(+56.05327026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238038"},
        {"Hipparcos Number", "HIP 57445"},
        {"Geneva Identification System", "GEN# +1.00238038"},
        {"Smithsonian Astrophysical Observation", "SAO 28139"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.64441684),
        dec: Angle.Degrees(+56.05577070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 612"},
        {"Hipparcos Number", "HIP 866"},
        {"Smithsonian Astrophysical Observation", "SAO 21167"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.66144965),
        dec: Angle.Degrees(+56.05613623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240493"},
        {"Hipparcos Number", "HIP 401"},
        {"Smithsonian Astrophysical Observation", "SAO 21063"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.23422583),
        dec: Angle.Degrees(+56.05695930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79391"},
        {"Hipparcos Number", "HIP 45465"},
        {"Smithsonian Astrophysical Observation", "SAO 27187"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.97752092),
        dec: Angle.Degrees(+56.06472188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65465"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.27611418),
        dec: Angle.Degrees(+56.06533389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161368"},
        {"Hipparcos Number", "HIP 86612"},
        {"Smithsonian Astrophysical Observation", "SAO 30525"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48295021),
        dec: Angle.Degrees(+56.06608043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237940"},
        {"Hipparcos Number", "HIP 53042"},
        {"Smithsonian Astrophysical Observation", "SAO 27790"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.79478702),
        dec: Angle.Degrees(+56.06807265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195554"},
        {"Hipparcos Number", "HIP 101084"},
        {"Celescope Catalog", "CEL 5086"},
        {"Fundamental Katalog 5th Edition", "FK5 3640"},
        {"Geneva Identification System", "GEN# +1.00195554J"},
        {"Renson", "Renson 54510"},
        {"Smithsonian Astrophysical Observation", "SAO 32627"},
        {"Wilson Evans Batten Catalogue", "WEB 18254"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36294172),
        dec: Angle.Degrees(+56.06817898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18991"},
        {"Hipparcos Number", "HIP 14392"},
        {"Geneva Identification System", "GEN# +1.00018991"},
        {"Smithsonian Astrophysical Observation", "SAO 23793"},
        {"Wilson Evans Batten Catalogue", "WEB 2810"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.41728851),
        dec: Angle.Degrees(+56.06902466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145144"},
        {"Hipparcos Number", "HIP 78911"},
        {"Smithsonian Astrophysical Observation", "SAO 29802"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.61723357),
        dec: Angle.Degrees(+56.06969622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236756"},
        {"Hipparcos Number", "HIP 6923"},
        {"Smithsonian Astrophysical Observation", "SAO 22320"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.29765099),
        dec: Angle.Degrees(+56.07022188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214279"},
        {"Hipparcos Number", "HIP 111543"},
        {"Celescope Catalog", "CEL 5492"},
        {"Geneva Identification System", "GEN# +1.00214279"},
        {"Smithsonian Astrophysical Observation", "SAO 34605"},
        {"Wilson Evans Batten Catalogue", "WEB 19942"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.96657940),
        dec: Angle.Degrees(+56.07057602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38925"},
        {"Hipparcos Number", "HIP 27764"},
        {"Geneva Identification System", "GEN# +1.00038925"},
        {"Smithsonian Astrophysical Observation", "SAO 25425"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.13140201),
        dec: Angle.Degrees(+56.07525818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156678"},
        {"Hipparcos Number", "HIP 84439"},
        {"Smithsonian Astrophysical Observation", "SAO 30318"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.95168964),
        dec: Angle.Degrees(+56.07766547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220301"},
        {"Hipparcos Number", "HIP 115369"},
        {"Geneva Identification System", "GEN# +1.00220301J"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.55065420),
        dec: Angle.Degrees(+56.07890933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3148"},
        {"Hipparcos Number", "HIP 2763"},
        {"Smithsonian Astrophysical Observation", "SAO 21535"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.81109364),
        dec: Angle.Degrees(+56.08289652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210628"},
        {"Hipparcos Number", "HIP 109424"},
        {"Celescope Catalog", "CEL 5445"},
        {"Geneva Identification System", "GEN# +1.00210628"},
        {"Smithsonian Astrophysical Observation", "SAO 34126"},
        {"Wilson Evans Batten Catalogue", "WEB 19661"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.54281092),
        dec: Angle.Degrees(+56.08388262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85584"},
        {"Hipparcos Number", "HIP 48595"},
        {"Smithsonian Astrophysical Observation", "SAO 27425"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.64890106),
        dec: Angle.Degrees(+56.08808975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239457"},
        {"Hipparcos Number", "HIP 101652"},
        {"Smithsonian Astrophysical Observation", "SAO 32727"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.08791851),
        dec: Angle.Degrees(+56.08835320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34853"},
        {"Hipparcos Number", "HIP 25226"},
        {"Geneva Identification System", "GEN# +1.00034853"},
        {"Smithsonian Astrophysical Observation", "SAO 25166"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.93041442),
        dec: Angle.Degrees(+56.08888279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96233"},
        {"Hipparcos Number", "HIP 54314"},
        {"Smithsonian Astrophysical Observation", "SAO 27907"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.67063122),
        dec: Angle.Degrees(+56.09165930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56289",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8199 A"},
        {"Henry Draper", "HD 100214"},
        {"Henry Draper 2", "HD 100214A"},
        {"Hipparcos Number", "HIP 56289"},
        {"Geneva Identification System", "GEN# +1.00100214"},
        {"Smithsonian Astrophysical Observation", "SAO 28050"},
        {"Wilson Evans Batten Catalogue", "WEB 10121"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.08578229),
        dec: Angle.Degrees(+56.09516646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -241.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32748"},
        {"Hipparcos Number", "HIP 23937"},
        {"Smithsonian Astrophysical Observation", "SAO 25041"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.16267574),
        dec: Angle.Degrees(+56.09838010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238509"},
        {"Hipparcos Number", "HIP 77438"},
        {"Smithsonian Astrophysical Observation", "SAO 29677"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.12394510),
        dec: Angle.Degrees(+56.09885836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47254"},
        {"Hipparcos Number", "HIP 31979"},
        {"Smithsonian Astrophysical Observation", "SAO 25874"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.24784100),
        dec: Angle.Degrees(+56.09932633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236645"},
        {"Hipparcos Number", "HIP 5576"},
        {"Smithsonian Astrophysical Observation", "SAO 22074"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.87119446),
        dec: Angle.Degrees(+56.09995360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77889"},
        {"Hipparcos Number", "HIP 44778"},
        {"Smithsonian Astrophysical Observation", "SAO 27130"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.89016957),
        dec: Angle.Degrees(+56.10139637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237247"},
        {"Hipparcos Number", "HIP 20276"},
        {"Smithsonian Astrophysical Observation", "SAO 24545"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.19470894),
        dec: Angle.Degrees(+56.10248652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14871"},
        {"Hipparcos Number", "HIP 11346"},
        {"Celescope Catalog", "CEL 275"},
        {"Geneva Identification System", "GEN# +1.00014871"},
        {"Smithsonian Astrophysical Observation", "SAO 23321"},
        {"Wilson Evans Batten Catalogue", "WEB 2368"},
        {"Wilson Evans Batten Catalogue 2", "WEB 2369"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.49169331),
        dec: Angle.Degrees(+56.10278720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174157"},
        {"Hipparcos Number", "HIP 92073"},
        {"Smithsonian Astrophysical Observation", "SAO 31158"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.49046689),
        dec: Angle.Degrees(+56.10336196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201611"},
        {"Hipparcos Number", "HIP 104355"},
        {"Smithsonian Astrophysical Observation", "SAO 33167"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.11140583),
        dec: Angle.Degrees(+56.10445044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220653"},
        {"Hipparcos Number", "HIP 115596"},
        {"Smithsonian Astrophysical Observation", "SAO 35401"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.23190507),
        dec: Angle.Degrees(+56.10654679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130082"},
        {"Hipparcos Number", "HIP 72026"},
        {"Smithsonian Astrophysical Observation", "SAO 29259"},
        {"Wilson Evans Batten Catalogue", "WEB 12397"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.00802825),
        dec: Angle.Degrees(+56.10699979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237184"},
        {"Hipparcos Number", "HIP 18023"},
        {"Smithsonian Astrophysical Observation", "SAO 24259"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.76659651),
        dec: Angle.Degrees(+56.10767495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105859"},
        {"Hipparcos Number", "HIP 59388"},
        {"Smithsonian Astrophysical Observation", "SAO 28281"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75201761),
        dec: Angle.Degrees(+56.10772250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50457"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.53523766),
        dec: Angle.Degrees(+56.10834455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237856"},
        {"Hipparcos Number", "HIP 48966"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.83537253),
        dec: Angle.Degrees(+56.10902538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78212"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.56484728),
        dec: Angle.Degrees(+56.11103703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11150"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.86025250),
        dec: Angle.Degrees(+56.11140645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2218"},
        {"Hipparcos Number", "HIP 2096"},
        {"Smithsonian Astrophysical Observation", "SAO 21401"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.62866135),
        dec: Angle.Degrees(+56.11317307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239928"},
        {"Hipparcos Number", "HIP 110327"},
        {"Geneva Identification System", "GEN# +1.00239928"},
        {"Smithsonian Astrophysical Observation", "SAO 34340"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.19047437),
        dec: Angle.Degrees(+56.11389671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127538"},
        {"Hipparcos Number", "HIP 70907"},
        {"Smithsonian Astrophysical Observation", "SAO 29172"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.50177123),
        dec: Angle.Degrees(+56.11403312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38091"},
        {"Hipparcos Number", "HIP 27249"},
        {"Geneva Identification System", "GEN# +1.00038091"},
        {"Smithsonian Astrophysical Observation", "SAO 25362"},
        {"Wilson Evans Batten Catalogue", "WEB 5355"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.62653944),
        dec: Angle.Degrees(+56.11571824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29092"},
        {"Hipparcos Number", "HIP 21569"},
        {"Smithsonian Astrophysical Observation", "SAO 24723"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.46115988),
        dec: Angle.Degrees(+56.11726791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51323"},
        {"Hipparcos Number", "HIP 33707"},
        {"Smithsonian Astrophysical Observation", "SAO 26085"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.04786447),
        dec: Angle.Degrees(+56.11904984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199938"},
        {"Hipparcos Number", "HIP 103485"},
        {"Geneva Identification System", "GEN# +1.00199938"},
        {"Smithsonian Astrophysical Observation", "SAO 33031"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.50169088),
        dec: Angle.Degrees(+56.11950024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163203"},
        {"Hipparcos Number", "HIP 87405"},
        {"Smithsonian Astrophysical Observation", "SAO 30616"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.93635061),
        dec: Angle.Degrees(+56.12019395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211853"},
        {"Hipparcos Number", "HIP 110154"},
        {"Geneva Identification System", "GEN# +1.00211853"},
        {"Smithsonian Astrophysical Observation", "SAO 34301"},
        {"Wilson Evans Batten Catalogue", "WEB 19770"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.69003974),
        dec: Angle.Degrees(+56.12608963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20778"},
        {"Hipparcos Number", "HIP 15785"},
        {"Geneva Identification System", "GEN# +1.00020778"},
        {"Smithsonian Astrophysical Observation", "SAO 23997"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.86076915),
        dec: Angle.Degrees(+56.12654884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45333"},
        {"Hipparcos Number", "HIP 30985"},
        {"Smithsonian Astrophysical Observation", "SAO 25767"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.54062835),
        dec: Angle.Degrees(+56.12669908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237943"},
        {"Hipparcos Number", "HIP 53061"},
        {"Smithsonian Astrophysical Observation", "SAO 27795"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.84330442),
        dec: Angle.Degrees(+56.12983059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36958"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.97028522),
        dec: Angle.Degrees(+56.13083972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90103"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.81893662),
        dec: Angle.Degrees(+56.13169703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147307"},
        {"Hipparcos Number", "HIP 79875"},
        {"Smithsonian Astrophysical Observation", "SAO 29879"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.56424257),
        dec: Angle.Degrees(+56.13364926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84300",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10425 AB"},
        {"Henry Draper", "HD 156389"},
        {"Hipparcos Number", "HIP 84300"},
        {"Geneva Identification System", "GEN# +1.00156389J"},
        {"Smithsonian Astrophysical Observation", "SAO 30306"},
        {"Wilson Evans Batten Catalogue", "WEB 14235"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.52853672),
        dec: Angle.Degrees(+56.13376333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154986"},
        {"Hipparcos Number", "HIP 83642"},
        {"Smithsonian Astrophysical Observation", "SAO 30244"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.41995752),
        dec: Angle.Degrees(+56.13513282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46894"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.34573759),
        dec: Angle.Degrees(+56.13526536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100831"},
        {"Hipparcos Number", "HIP 56622"},
        {"Smithsonian Astrophysical Observation", "SAO 28071"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.14950197),
        dec: Angle.Degrees(+56.13557459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184240"},
        {"Hipparcos Number", "HIP 95931"},
        {"Geneva Identification System", "GEN# +1.00184240"},
        {"Smithsonian Astrophysical Observation", "SAO 31724"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.64363448),
        dec: Angle.Degrees(+56.13618191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62095"},
        {"Hipparcos Number", "HIP 37828"},
        {"Smithsonian Astrophysical Observation", "SAO 26492"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.33823717),
        dec: Angle.Degrees(+56.13795661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239424"},
        {"Hipparcos Number", "HIP 100964"},
        {"Smithsonian Astrophysical Observation", "SAO 32612"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.05686343),
        dec: Angle.Degrees(+56.13955157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21037"},
        {"Hipparcos Number", "HIP 16019"},
        {"Smithsonian Astrophysical Observation", "SAO 24029"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.56706481),
        dec: Angle.Degrees(+56.14171924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 504 AB"},
        {"Henry Draper", "HD 3304"},
        {"Hipparcos Number", "HIP 2886"},
        {"Smithsonian Astrophysical Observation", "SAO 21557"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.13940628),
        dec: Angle.Degrees(+56.14220132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238349"},
        {"Hipparcos Number", "HIP 70412"},
        {"Geneva Identification System", "GEN# +1.00238349"},
        {"Smithsonian Astrophysical Observation", "SAO 29130"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.07401188),
        dec: Angle.Degrees(+56.14618756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19683"},
        {"Hipparcos Number", "HIP 14927"},
        {"Smithsonian Astrophysical Observation", "SAO 23875"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.13314755),
        dec: Angle.Degrees(+56.14913188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218982"},
        {"Hipparcos Number", "HIP 114516"},
        {"Geneva Identification System", "GEN# +1.00218982"},
        {"Smithsonian Astrophysical Observation", "SAO 35213"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.92223017),
        dec: Angle.Degrees(+56.15410680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239617"},
        {"Hipparcos Number", "HIP 104881"},
        {"Smithsonian Astrophysical Observation", "SAO 33257"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.68668011),
        dec: Angle.Degrees(+56.15574393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238887"},
        {"Hipparcos Number", "HIP 90685"},
        {"Smithsonian Astrophysical Observation", "SAO 31013"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.54697916),
        dec: Angle.Degrees(+56.15753897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238361"},
        {"Hipparcos Number", "HIP 71015"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.85724291),
        dec: Angle.Degrees(+56.15811665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13268"},
        {"Hipparcos Number", "HIP 10228"},
        {"Celescope Catalog", "CEL 218"},
        {"Geneva Identification System", "GEN# +1.00013268"},
        {"Smithsonian Astrophysical Observation", "SAO 23014"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.87375163),
        dec: Angle.Degrees(+56.15881813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72389"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.01191430),
        dec: Angle.Degrees(+56.15920916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54756"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.16454089),
        dec: Angle.Degrees(+56.16031629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10580 AB"},
        {"Henry Draper", "HD 238701"},
        {"Hipparcos Number", "HIP 85466"},
        {"Smithsonian Astrophysical Observation", "SAO 30403"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.97347684),
        dec: Angle.Degrees(+56.16116761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108427"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46956446),
        dec: Angle.Degrees(+56.16390876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91394"},
        {"Hipparcos Number", "HIP 51763"},
        {"Geneva Identification System", "GEN# +1.00091394"},
        {"Smithsonian Astrophysical Observation", "SAO 27688"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.63753789),
        dec: Angle.Degrees(+56.16407684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150871"},
        {"Hipparcos Number", "HIP 81637"},
        {"Smithsonian Astrophysical Observation", "SAO 30042"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.15492547),
        dec: Angle.Degrees(+56.16708462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155356"},
        {"Hipparcos Number", "HIP 83822"},
        {"Geneva Identification System", "GEN# +1.00155356"},
        {"Smithsonian Astrophysical Observation", "SAO 30261"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.96308455),
        dec: Angle.Degrees(+56.17082120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236404"},
        {"Hipparcos Number", "HIP 2009"},
        {"Smithsonian Astrophysical Observation", "SAO 21385"},
        {"Wilson Evans Batten Catalogue", "WEB 383"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35509341),
        dec: Angle.Degrees(+56.17572723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211643"},
        {"Hipparcos Number", "HIP 110021"},
        {"Geneva Identification System", "GEN# +1.00211643"},
        {"Renson", "Renson 58750"},
        {"Smithsonian Astrophysical Observation", "SAO 34268"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.25424451),
        dec: Angle.Degrees(+56.17666032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237206"},
        {"Hipparcos Number", "HIP 18801"},
        {"Smithsonian Astrophysical Observation", "SAO 24349"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.42549361),
        dec: Angle.Degrees(+56.17686417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18078"},
        {"Hipparcos Number", "HIP 13712"},
        {"Geneva Identification System", "GEN# +1.00018078"},
        {"Renson", "Renson 4500"},
        {"Smithsonian Astrophysical Observation", "SAO 23714"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.13338369),
        dec: Angle.Degrees(+56.17817341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157343"},
        {"Hipparcos Number", "HIP 84756"},
        {"Geneva Identification System", "GEN# +1.00157343"},
        {"Smithsonian Astrophysical Observation", "SAO 30338"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.87234049),
        dec: Angle.Degrees(+56.17936256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237264"},
        {"Hipparcos Number", "HIP 20821"},
        {"Smithsonian Astrophysical Observation", "SAO 24623"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.92543100),
        dec: Angle.Degrees(+56.17945615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239436"},
        {"Hipparcos Number", "HIP 101256"},
        {"Smithsonian Astrophysical Observation", "SAO 32661"},
        {"Wilson Evans Batten Catalogue", "WEB 18294"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.87321058),
        dec: Angle.Degrees(+56.17999295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239670"},
        {"Hipparcos Number", "HIP 105908"},
        {"Smithsonian Astrophysical Observation", "SAO 33437"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.74848588),
        dec: Angle.Degrees(+56.18333150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14405"},
        {"Hipparcos Number", "HIP 10982"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.37722877),
        dec: Angle.Degrees(+56.18350047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43813"},
        {"Hipparcos Number", "HIP 30230"},
        {"Smithsonian Astrophysical Observation", "SAO 25676"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.40227580),
        dec: Angle.Degrees(+56.18493338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83728"},
        {"Hipparcos Number", "HIP 47609"},
        {"Smithsonian Astrophysical Observation", "SAO 27353"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.62099839),
        dec: Angle.Degrees(+56.18735049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239467"},
        {"Hipparcos Number", "HIP 101903"},
        {"Smithsonian Astrophysical Observation", "SAO 32764"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.75789732),
        dec: Angle.Degrees(+56.18877019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238491"},
        {"Hipparcos Number", "HIP 76740"},
        {"Smithsonian Astrophysical Observation", "SAO 29615"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.06620560),
        dec: Angle.Degrees(+56.19228850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161767"},
        {"Hipparcos Number", "HIP 86795"},
        {"Geneva Identification System", "GEN# +1.00161767"},
        {"Smithsonian Astrophysical Observation", "SAO 30542"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.03133467),
        dec: Angle.Degrees(+56.19364686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98214"},
        {"Hipparcos Number", "HIP 55223"},
        {"Geneva Identification System", "GEN# +1.00098214"},
        {"Smithsonian Astrophysical Observation", "SAO 27980"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.63261811),
        dec: Angle.Degrees(+56.19478446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88545"},
        {"Hipparcos Number", "HIP 50154"},
        {"Smithsonian Astrophysical Observation", "SAO 27572"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.57940365),
        dec: Angle.Degrees(+56.19567901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112395"},
        {"Hipparcos Number", "HIP 63089"},
        {"Geneva Identification System", "GEN# +1.00112395"},
        {"Smithsonian Astrophysical Observation", "SAO 28565"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.89757847),
        dec: Angle.Degrees(+56.19648835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41518"},
        {"Hipparcos Number", "HIP 29162"},
        {"Smithsonian Astrophysical Observation", "SAO 25588"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.27537208),
        dec: Angle.Degrees(+56.19732589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81338"},
        {"Hipparcos Number", "HIP 46355"},
        {"Smithsonian Astrophysical Observation", "SAO 27257"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.76893602),
        dec: Angle.Degrees(+56.19847552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203377"},
        {"Hipparcos Number", "HIP 105308"},
        {"Smithsonian Astrophysical Observation", "SAO 33330"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.93418663),
        dec: Angle.Degrees(+56.20009427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236721"},
        {"Hipparcos Number", "HIP 6600"},
        {"Smithsonian Astrophysical Observation", "SAO 22256"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.19213894),
        dec: Angle.Degrees(+56.20043516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64412"},
        {"Hipparcos Number", "HIP 38822"},
        {"Smithsonian Astrophysical Observation", "SAO 26581"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.18473298),
        dec: Angle.Degrees(+56.20648543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -349.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43376",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7016 AB"},
        {"Henry Draper", "HD 75031"},
        {"Hipparcos Number", "HIP 43376"},
        {"Smithsonian Astrophysical Observation", "SAO 27008"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.53067587),
        dec: Angle.Degrees(+56.20658058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6295",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1089 AB"},
        {"Henry Draper", "HD 8026"},
        {"Hipparcos Number", "HIP 6295"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.19945978),
        dec: Angle.Degrees(+56.20732897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239671"},
        {"Hipparcos Number", "HIP 105925"},
        {"Smithsonian Astrophysical Observation", "SAO 33440"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.80592917),
        dec: Angle.Degrees(+56.20839373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237866"},
        {"Hipparcos Number", "HIP 49581"},
        {"Smithsonian Astrophysical Observation", "SAO 27524"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.82503449),
        dec: Angle.Degrees(+56.21029267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208219"},
        {"Hipparcos Number", "HIP 108029"},
        {"Smithsonian Astrophysical Observation", "SAO 33832"},
        {"Wilson Evans Batten Catalogue", "WEB 19475"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.27975897),
        dec: Angle.Degrees(+56.21254763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239373"},
        {"Hipparcos Number", "HIP 100055"},
        {"Smithsonian Astrophysical Observation", "SAO 32449"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.48741152),
        dec: Angle.Degrees(+56.21633126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189590"},
        {"Hipparcos Number", "HIP 98254"},
        {"Smithsonian Astrophysical Observation", "SAO 32150"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48467169),
        dec: Angle.Degrees(+56.22234636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182735"},
        {"Hipparcos Number", "HIP 95271"},
        {"Geneva Identification System", "GEN# +1.00182735"},
        {"Smithsonian Astrophysical Observation", "SAO 31620"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.75151000),
        dec: Angle.Degrees(+56.22555911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19482"},
        {"Hipparcos Number", "HIP 14730"},
        {"Geneva Identification System", "GEN# +1.00019482"},
        {"Smithsonian Astrophysical Observation", "SAO 23847"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.56439408),
        dec: Angle.Degrees(+56.23024541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8921 AB"},
        {"Henry Draper", "HD 117417"},
        {"Hipparcos Number", "HIP 65774"},
        {"Smithsonian Astrophysical Observation", "SAO 28774"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.26372230),
        dec: Angle.Degrees(+56.23317937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239856"},
        {"Hipparcos Number", "HIP 109200"},
        {"Geneva Identification System", "GEN# +1.00239856"},
        {"Smithsonian Astrophysical Observation", "SAO 34074"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.82083502),
        dec: Angle.Degrees(+56.23402880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141989"},
        {"Hipparcos Number", "HIP 77484"},
        {"Geneva Identification System", "GEN# +1.00141989"},
        {"Smithsonian Astrophysical Observation", "SAO 29680"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.31978843),
        dec: Angle.Degrees(+56.23648489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93847"},
        {"Hipparcos Number", "HIP 53036"},
        {"Geneva Identification System", "GEN# +1.00093847"},
        {"Smithsonian Astrophysical Observation", "SAO 27788"},
        {"Wilson Evans Batten Catalogue", "WEB 9641"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.77474793),
        dec: Angle.Degrees(+56.23778360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5440"},
        {"Hipparcos Number", "HIP 4451"},
        {"Smithsonian Astrophysical Observation", "SAO 21861"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.24191847),
        dec: Angle.Degrees(+56.24002265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81702"},
        {"Hipparcos Number", "HIP 46524"},
        {"Fundamental Katalog 5th Edition", "FK5 4844"},
        {"Geneva Identification System", "GEN# +1.00081702"},
        {"Smithsonian Astrophysical Observation", "SAO 27268"},
        {"Wilson Evans Batten Catalogue", "WEB 8782"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.34009545),
        dec: Angle.Degrees(+56.24119845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145370"},
        {"Hipparcos Number", "HIP 79011"},
        {"Smithsonian Astrophysical Observation", "SAO 29810"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.91028652),
        dec: Angle.Degrees(+56.24344868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26006"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.25789368),
        dec: Angle.Degrees(+56.24766689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100582"},
        {"Wilson Evans Batten Catalogue", "WEB 18180"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.98103939),
        dec: Angle.Degrees(+56.24783318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236349"},
        {"Hipparcos Number", "HIP 1162"},
        {"Smithsonian Astrophysical Observation", "SAO 21233"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.61768272),
        dec: Angle.Degrees(+56.25294128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213049"},
        {"Hipparcos Number", "HIP 110836"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.82425986),
        dec: Angle.Degrees(+56.25327574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69263"},
        {"Hipparcos Number", "HIP 40743"},
        {"Smithsonian Astrophysical Observation", "SAO 26766"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.74566219),
        dec: Angle.Degrees(+56.25473254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65547"},
        {"Wilson Evans Batten Catalogue", "WEB 11579"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.55637649),
        dec: Angle.Degrees(+56.25695644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236940"},
        {"Hipparcos Number", "HIP 9703"},
        {"Celescope Catalog", "CEL 196"},
        {"Geneva Identification System", "GEN# +1.00236940"},
        {"Smithsonian Astrophysical Observation", "SAO 22902"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.20184376),
        dec: Angle.Degrees(+56.26201545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41671"},
        {"Hipparcos Number", "HIP 29249"},
        {"Smithsonian Astrophysical Observation", "SAO 25600"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.50649140),
        dec: Angle.Degrees(+56.26405401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167027"},
        {"Hipparcos Number", "HIP 89017"},
        {"Smithsonian Astrophysical Observation", "SAO 30783"},
        {"Wilson Evans Batten Catalogue", "WEB 15110"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.51392503),
        dec: Angle.Degrees(+56.26669826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237726"},
        {"Hipparcos Number", "HIP 41885"},
        {"Smithsonian Astrophysical Observation", "SAO 26893"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.11313677),
        dec: Angle.Degrees(+56.26970204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31690"},
        {"Hipparcos Number", "HIP 23332"},
        {"Geneva Identification System", "GEN# +1.00031690"},
        {"Smithsonian Astrophysical Observation", "SAO 24953"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.28208657),
        dec: Angle.Degrees(+56.26978729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16524"},
        {"Hipparcos Number", "HIP 12520"},
        {"Smithsonian Astrophysical Observation", "SAO 23524"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.28198725),
        dec: Angle.Degrees(+56.27012632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56383"},
        {"Hipparcos Number", "HIP 35530"},
        {"Smithsonian Astrophysical Observation", "SAO 26280"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98979337),
        dec: Angle.Degrees(+56.27073439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36332"},
        {"Hipparcos Number", "HIP 26124"},
        {"Smithsonian Astrophysical Observation", "SAO 25255"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.56833368),
        dec: Angle.Degrees(+56.27140792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10266"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.03416714),
        dec: Angle.Degrees(+56.27212999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239616"},
        {"Hipparcos Number", "HIP 104879"},
        {"Smithsonian Astrophysical Observation", "SAO 33255"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.67416912),
        dec: Angle.Degrees(+56.27246026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35421"},
        {"Hipparcos Number", "HIP 25566"},
        {"Geneva Identification System", "GEN# +1.00035421"},
        {"Smithsonian Astrophysical Observation", "SAO 25203"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.97077483),
        dec: Angle.Degrees(+56.27902434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106813"},
        {"Hipparcos Number", "HIP 59882"},
        {"Smithsonian Astrophysical Observation", "SAO 28323"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.20888662),
        dec: Angle.Degrees(+56.28150952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44691"},
        {"Hipparcos Number", "HIP 30651"},
        {"Fundamental Katalog 5th Edition", "FK5 2491"},
        {"Geneva Identification System", "GEN# +1.00044691"},
        {"Renson", "Renson 11840"},
        {"Smithsonian Astrophysical Observation", "SAO 25731"},
        {"Wilson Evans Batten Catalogue", "WEB 6112"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.60776525),
        dec: Angle.Degrees(+56.28504370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240236"},
        {"Hipparcos Number", "HIP 114788"},
        {"Smithsonian Astrophysical Observation", "SAO 35263"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.78433646),
        dec: Angle.Degrees(+56.29501571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13149"},
        {"Hipparcos Number", "HIP 10139"},
        {"Smithsonian Astrophysical Observation", "SAO 22997"},
        {"Wilson Evans Batten Catalogue", "WEB 2118"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.59998120),
        dec: Angle.Degrees(+56.29720974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103248"},
        {"Hipparcos Number", "HIP 57977"},
        {"Geneva Identification System", "GEN# +1.00103248"},
        {"Smithsonian Astrophysical Observation", "SAO 28178"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.38974292),
        dec: Angle.Degrees(+56.29974897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22079"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.23416348),
        dec: Angle.Degrees(+56.30016025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239544"},
        {"Hipparcos Number", "HIP 103685"},
        {"Geneva Identification System", "GEN# +1.00239544"},
        {"Smithsonian Astrophysical Observation", "SAO 33061"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.15047502),
        dec: Angle.Degrees(+56.30218547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19961"},
        {"Hipparcos Number", "HIP 15111"},
        {"Geneva Identification System", "GEN# +1.00019961"},
        {"Smithsonian Astrophysical Observation", "SAO 23892"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.72916022),
        dec: Angle.Degrees(+56.30492690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54348"},
        {"Hipparcos Number", "HIP 34754"},
        {"Smithsonian Astrophysical Observation", "SAO 26202"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.91420736),
        dec: Angle.Degrees(+56.30826798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56412"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.48763048),
        dec: Angle.Degrees(+56.30876778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18460"},
        {"Hipparcos Number", "HIP 14013"},
        {"Geneva Identification System", "GEN# +1.00018460"},
        {"Renson", "Renson 4590"},
        {"Smithsonian Astrophysical Observation", "SAO 23757"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.10161972),
        dec: Angle.Degrees(+56.31354503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122729"},
        {"Hipparcos Number", "HIP 68545"},
        {"Smithsonian Astrophysical Observation", "SAO 28982"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.48617473),
        dec: Angle.Degrees(+56.31382112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21831"},
        {"Hipparcos Number", "HIP 16623"},
        {"Geneva Identification System", "GEN# +1.00021831"},
        {"Smithsonian Astrophysical Observation", "SAO 24100"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.47426614),
        dec: Angle.Degrees(+56.31398879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237331"},
        {"Hipparcos Number", "HIP 22922"},
        {"Smithsonian Astrophysical Observation", "SAO 24917"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.99266287),
        dec: Angle.Degrees(+56.31464397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1934 AB"},
        {"Henry Draper", "HD 236970"},
        {"Hipparcos Number", "HIP 11888"},
        {"Geneva Identification System", "GEN# +1.00236970J"},
        {"Smithsonian Astrophysical Observation", "SAO 23423"},
        {"Wilson Evans Batten Catalogue", "WEB 2459"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.32645153),
        dec: Angle.Degrees(+56.31806218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124795"},
        {"Hipparcos Number", "HIP 69510"},
        {"Smithsonian Astrophysical Observation", "SAO 29051"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44605938),
        dec: Angle.Degrees(+56.31848675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5177"},
        {"Hipparcos Number", "HIP 4264"},
        {"Geneva Identification System", "GEN# +1.00005177"},
        {"Smithsonian Astrophysical Observation", "SAO 21827"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.62478540),
        dec: Angle.Degrees(+56.31962729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240073"},
        {"Hipparcos Number", "HIP 112626"},
        {"Smithsonian Astrophysical Observation", "SAO 34841"},
        {"Wilson Evans Batten Catalogue", "WEB 20079"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.15832964),
        dec: Angle.Degrees(+56.32154327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175"},
        {"Hipparcos Number", "HIP 550"},
        {"Smithsonian Astrophysical Observation", "SAO 21091"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.67432667),
        dec: Angle.Degrees(+56.32466451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74871"},
        {"Hipparcos Number", "HIP 43289"},
        {"Smithsonian Astrophysical Observation", "SAO 27003"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.27249910),
        dec: Angle.Degrees(+56.32721346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5981"},
        {"Hipparcos Number", "HIP 4834"},
        {"Smithsonian Astrophysical Observation", "SAO 21937"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.53174885),
        dec: Angle.Degrees(+56.32870093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7861"},
        {"Hipparcos Number", "HIP 6191"},
        {"Smithsonian Astrophysical Observation", "SAO 22182"},
        {"Wilson Evans Batten Catalogue", "WEB 1388"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.85690885),
        dec: Angle.Degrees(+56.32918126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152550"},
        {"Hipparcos Number", "HIP 82435"},
        {"Smithsonian Astrophysical Observation", "SAO 30124"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.70540512),
        dec: Angle.Degrees(+56.32993274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108793"},
        {"Hipparcos Number", "HIP 60946"},
        {"Geneva Identification System", "GEN# +1.00108793"},
        {"Smithsonian Astrophysical Observation", "SAO 28402"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.38772799),
        dec: Angle.Degrees(+56.33239561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216730"},
        {"Hipparcos Number", "HIP 113102"},
        {"Geneva Identification System", "GEN# +1.00216730"},
        {"Smithsonian Astrophysical Observation", "SAO 34937"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.57155731),
        dec: Angle.Degrees(+56.33301541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236374"},
        {"Hipparcos Number", "HIP 1520"},
        {"Smithsonian Astrophysical Observation", "SAO 21291"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.73656500),
        dec: Angle.Degrees(+56.33839061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14739 AB"},
        {"Henry Draper", "HD 202031"},
        {"Hipparcos Number", "HIP 104589"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.79916821),
        dec: Angle.Degrees(+56.34118625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191096"},
        {"Hipparcos Number", "HIP 98946"},
        {"Geneva Identification System", "GEN# +1.00191096"},
        {"Smithsonian Astrophysical Observation", "SAO 32276"},
        {"Wilson Evans Batten Catalogue", "WEB 17568"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.33959613),
        dec: Angle.Degrees(+56.34122669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210071"},
        {"Hipparcos Number", "HIP 109124"},
        {"Celescope Catalog", "CEL 5436"},
        {"Geneva Identification System", "GEN# +1.00210071"},
        {"Renson", "Renson 58470"},
        {"Smithsonian Astrophysical Observation", "SAO 34055"},
        {"Wilson Evans Batten Catalogue", "WEB 19619"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55645490),
        dec: Angle.Degrees(+56.34338987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220300"},
        {"Hipparcos Number", "HIP 115368"},
        {"Celescope Catalog", "CEL 5607"},
        {"Geneva Identification System", "GEN# +1.00220300"},
        {"Smithsonian Astrophysical Observation", "SAO 35357"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.54361235),
        dec: Angle.Degrees(+56.34822939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85369",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10567 AB"},
        {"Henry Draper", "HD 238694"},
        {"Hipparcos Number", "HIP 85369"},
        {"Smithsonian Astrophysical Observation", "SAO 30389"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.66722912),
        dec: Angle.Degrees(+56.35312027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238475"},
        {"Hipparcos Number", "HIP 76215"},
        {"Smithsonian Astrophysical Observation", "SAO 29575"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.53796851),
        dec: Angle.Degrees(+56.35377402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7797 B"},
        {"Hipparcos Number", "HIP 51441"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.59031261),
        dec: Angle.Degrees(+56.35480857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7797 A"},
        {"Henry Draper", "HD 90804"},
        {"Hipparcos Number", "HIP 51445"},
        {"Smithsonian Astrophysical Observation", "SAO 27666"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.59532199),
        dec: Angle.Degrees(+56.35562440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195917"},
        {"Hipparcos Number", "HIP 101266"},
        {"Celescope Catalog", "CEL 5101"},
        {"Geneva Identification System", "GEN# +1.00195917"},
        {"Smithsonian Astrophysical Observation", "SAO 32662"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.89551214),
        dec: Angle.Degrees(+56.35590038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113405"},
        {"Hipparcos Number", "HIP 63646"},
        {"Smithsonian Astrophysical Observation", "SAO 28612"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.66588698),
        dec: Angle.Degrees(+56.35729020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37070"},
        {"Hipparcos Number", "HIP 26587"},
        {"Geneva Identification System", "GEN# +1.00037070"},
        {"Smithsonian Astrophysical Observation", "SAO 25298"},
        {"Wilson Evans Batten Catalogue", "WEB 5240"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.77247542),
        dec: Angle.Degrees(+56.36036185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239652"},
        {"Hipparcos Number", "HIP 105690"},
        {"Smithsonian Astrophysical Observation", "SAO 33396"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.09690590),
        dec: Angle.Degrees(+56.36157386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199308"},
        {"Hipparcos Number", "HIP 103141"},
        {"Celescope Catalog", "CEL 5201"},
        {"Geneva Identification System", "GEN# +1.00199308"},
        {"Smithsonian Astrophysical Observation", "SAO 32978"},
        {"Wilson Evans Batten Catalogue", "WEB 18735"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.46744475),
        dec: Angle.Degrees(+56.36302616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198959"},
        {"Hipparcos Number", "HIP 102952"},
        {"Geneva Identification System", "GEN# +1.00198959"},
        {"Smithsonian Astrophysical Observation", "SAO 32945"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.87841923),
        dec: Angle.Degrees(+56.36578776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63503",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8739 AB"},
        {"Aitken 2", "ADS 8739"},
        {"Henry Draper", "HD 113139"},
        {"Hipparcos Number", "HIP 63503"},
        {"Celescope Catalog", "CEL 4190"},
        {"Geneva Identification System", "GEN# +1.00113139J"},
        {"Smithsonian Astrophysical Observation", "SAO 28601"},
        {"Wilson Evans Batten Catalogue", "WEB 11238"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.18160731),
        dec: Angle.Degrees(+56.36633134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60047",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8507 AB"},
        {"Henry Draper", "HD 238098"},
        {"Hipparcos Number", "HIP 60047"},
        {"Smithsonian Astrophysical Observation", "SAO 28334"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.72421012),
        dec: Angle.Degrees(+56.36853651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238420"},
        {"Hipparcos Number", "HIP 73618"},
        {"Geneva Identification System", "GEN# +1.00238420"},
        {"Smithsonian Astrophysical Observation", "SAO 29389"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.72126701),
        dec: Angle.Degrees(+56.36888262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6539"},
        {"Hipparcos Number", "HIP 5252"},
        {"Smithsonian Astrophysical Observation", "SAO 22019"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.79453124),
        dec: Angle.Degrees(+56.37446137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63277"},
        {"Hipparcos Number", "HIP 38333"},
        {"Fundamental Katalog 5th Edition", "FK5 4707"},
        {"Smithsonian Astrophysical Observation", "SAO 26532"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.78231785),
        dec: Angle.Degrees(+56.37538621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118657"},
        {"Hipparcos Number", "HIP 66412"},
        {"Smithsonian Astrophysical Observation", "SAO 28817"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.23446321),
        dec: Angle.Degrees(+56.37975668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60134"},
        {"Hipparcos Number", "HIP 36999"},
        {"Smithsonian Astrophysical Observation", "SAO 26420"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.06727563),
        dec: Angle.Degrees(+56.38118492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53910",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Merak"},
        {"Henry Draper", "HD 95418"},
        {"Hipparcos Number", "HIP 53910"},
        {"Celescope Catalog", "CEL 3775"},
        {"Fundamental Katalog 5th Edition", "FK5 416"},
        {"Geneva Identification System", "GEN# +1.00095418"},
        {"Renson", "Renson 27493"},
        {"Smithsonian Astrophysical Observation", "SAO 27876"},
        {"Wilson Evans Batten Catalogue", "WEB 9758"},
    },
    visualMagnitude: 2.34,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.45996150),
        dec: Angle.Degrees(+56.38234478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22489"},
        {"Hipparcos Number", "HIP 17098"},
        {"Geneva Identification System", "GEN# +1.00022489"},
        {"Smithsonian Astrophysical Observation", "SAO 24145"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.93816584),
        dec: Angle.Degrees(+56.38304102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25150"},
        {"Hipparcos Number", "HIP 18865"},
        {"Geneva Identification System", "GEN# +1.00025150"},
        {"Smithsonian Astrophysical Observation", "SAO 24362"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.66563999),
        dec: Angle.Degrees(+56.38478224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46318"},
        {"Hipparcos Number", "HIP 31526"},
        {"Geneva Identification System", "GEN# +1.00046318"},
        {"Smithsonian Astrophysical Observation", "SAO 25829"},
        {"Wilson Evans Batten Catalogue", "WEB 6307"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.00944631),
        dec: Angle.Degrees(+56.38620747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239124"},
        {"Hipparcos Number", "HIP 96112"},
        {"Geneva Identification System", "GEN# +1.00239124"},
        {"Smithsonian Astrophysical Observation", "SAO 31761"},
        {"Wilson Evans Batten Catalogue", "WEB 16835"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.12173976),
        dec: Angle.Degrees(+56.38825316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73783"},
        {"Hipparcos Number", "HIP 42745"},
        {"Smithsonian Astrophysical Observation", "SAO 26971"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.67707073),
        dec: Angle.Degrees(+56.38831730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240370"},
        {"Hipparcos Number", "HIP 116990"},
        {"Smithsonian Astrophysical Observation", "SAO 35699"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.76695515),
        dec: Angle.Degrees(+56.39081627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163607"},
        {"Hipparcos Number", "HIP 87601"},
        {"Geneva Identification System", "GEN# +1.00163607"},
        {"Smithsonian Astrophysical Observation", "SAO 30632"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.41906135),
        dec: Angle.Degrees(+56.39166442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115691"},
        {"Hipparcos Number", "HIP 64862"},
        {"Smithsonian Astrophysical Observation", "SAO 28709"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.42618157),
        dec: Angle.Degrees(+56.40055418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97321"},
        {"Hipparcos Number", "HIP 54775"},
        {"Geneva Identification System", "GEN# +1.00097321"},
        {"Smithsonian Astrophysical Observation", "SAO 27953"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.20676137),
        dec: Angle.Degrees(+56.40280243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22844"},
        {"Hipparcos Number", "HIP 17356"},
        {"Geneva Identification System", "GEN# +1.00022844"},
        {"Smithsonian Astrophysical Observation", "SAO 24173"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.72806260),
        dec: Angle.Degrees(+56.40520749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176624"},
        {"Hipparcos Number", "HIP 93105"},
        {"Smithsonian Astrophysical Observation", "SAO 31295"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.50802147),
        dec: Angle.Degrees(+56.40822421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215322"},
        {"Hipparcos Number", "HIP 112183"},
        {"Geneva Identification System", "GEN# +1.00215322"},
        {"Smithsonian Astrophysical Observation", "SAO 34734"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.81413638),
        dec: Angle.Degrees(+56.40823773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59922"},
        {"Hipparcos Number", "HIP 36916"},
        {"Smithsonian Astrophysical Observation", "SAO 26414"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.84330871),
        dec: Angle.Degrees(+56.41312037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236685"},
        {"Hipparcos Number", "HIP 6014"},
        {"Geneva Identification System", "GEN# +1.00236685"},
        {"Smithsonian Astrophysical Observation", "SAO 22151"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33377295),
        dec: Angle.Degrees(+56.41404206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236517"},
        {"Hipparcos Number", "HIP 3512"},
        {"Smithsonian Astrophysical Observation", "SAO 21675"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.20782010),
        dec: Angle.Degrees(+56.41491061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239642"},
        {"Hipparcos Number", "HIP 105524"},
        {"Smithsonian Astrophysical Observation", "SAO 33365"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.58561429),
        dec: Angle.Degrees(+56.41617400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110275"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.05214857),
        dec: Angle.Degrees(+56.42020941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30582"},
        {"Hipparcos Number", "HIP 22624"},
        {"Geneva Identification System", "GEN# +1.00030582"},
        {"Smithsonian Astrophysical Observation", "SAO 24878"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.01742138),
        dec: Angle.Degrees(+56.42342347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186742"},
        {"Hipparcos Number", "HIP 97049"},
        {"Smithsonian Astrophysical Observation", "SAO 31925"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.85230366),
        dec: Angle.Degrees(+56.42613498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88381",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11035 A"},
        {"Henry Draper", "HD 165502"},
        {"Hipparcos Number", "HIP 88381"},
        {"Smithsonian Astrophysical Observation", "SAO 30715"},
        {"Wilson Evans Batten Catalogue", "WEB 14941"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.72033398),
        dec: Angle.Degrees(+56.42785942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216105"},
        {"Hipparcos Number", "HIP 112675"},
        {"Geneva Identification System", "GEN# +1.00216105"},
        {"Smithsonian Astrophysical Observation", "SAO 34850"},
        {"Wilson Evans Batten Catalogue", "WEB 20084"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.26326767),
        dec: Angle.Degrees(+56.42820674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236589"},
        {"Hipparcos Number", "HIP 4532"},
        {"Geneva Identification System", "GEN# +1.00236589"},
        {"Smithsonian Astrophysical Observation", "SAO 21884"},
        {"Wilson Evans Batten Catalogue", "WEB 819"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.50753426),
        dec: Angle.Degrees(+56.43113755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25939"},
        {"Hipparcos Number", "HIP 19415"},
        {"Smithsonian Astrophysical Observation", "SAO 24441"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.36997906),
        dec: Angle.Degrees(+56.43118977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91810"},
        {"Hipparcos Number", "HIP 51992"},
        {"Geneva Identification System", "GEN# +1.00091810"},
        {"Smithsonian Astrophysical Observation", "SAO 27707"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.33582567),
        dec: Angle.Degrees(+56.43135673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222704"},
        {"Hipparcos Number", "HIP 116969"},
        {"Smithsonian Astrophysical Observation", "SAO 35692"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.67071302),
        dec: Angle.Degrees(+56.43257233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240024"},
        {"Hipparcos Number", "HIP 112026"},
        {"Geneva Identification System", "GEN# +1.00240024"},
        {"Smithsonian Astrophysical Observation", "SAO 34699"},
        {"Wilson Evans Batten Catalogue", "WEB 19998"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.36054261),
        dec: Angle.Degrees(+56.43279437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212986"},
        {"Hipparcos Number", "HIP 110807"},
        {"Celescope Catalog", "CEL 5476"},
        {"Fundamental Katalog 5th Edition", "FK5 3795"},
        {"Geneva Identification System", "GEN# +1.00212986"},
        {"Smithsonian Astrophysical Observation", "SAO 34460"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.74649939),
        dec: Angle.Degrees(+56.43354961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94683",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12268 AB"},
        {"Henry Draper", "HD 181093"},
        {"Hipparcos Number", "HIP 94683"},
        {"Smithsonian Astrophysical Observation", "SAO 31524"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.99530605),
        dec: Angle.Degrees(+56.43498227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11035 BC"},
        {"Henry Draper", "HD 165501"},
        {"Hipparcos Number", "HIP 88385"},
        {"Smithsonian Astrophysical Observation", "SAO 30716"},
    },
    visualMagnitude: 7.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.72884305),
        dec: Angle.Degrees(+56.43677190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144082"},
        {"Hipparcos Number", "HIP 78474"},
        {"Geneva Identification System", "GEN# +1.00144082"},
        {"Smithsonian Astrophysical Observation", "SAO 29758"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.29100183),
        dec: Angle.Degrees(+56.43983986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21599"},
        {"Hipparcos Number", "HIP 16448"},
        {"Geneva Identification System", "GEN# +1.00021599"},
        {"Smithsonian Astrophysical Observation", "SAO 24078"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.97220406),
        dec: Angle.Degrees(+56.44046494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195131"},
        {"Hipparcos Number", "HIP 100845"},
        {"Smithsonian Astrophysical Observation", "SAO 32597"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.70620833),
        dec: Angle.Degrees(+56.44307299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180007"},
        {"Hipparcos Number", "HIP 94293"},
        {"Smithsonian Astrophysical Observation", "SAO 31465"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.89325882),
        dec: Angle.Degrees(+56.44446708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216928"},
        {"Hipparcos Number", "HIP 113268"},
        {"Celescope Catalog", "CEL 5545"},
        {"Fundamental Katalog 5th Edition", "FK5 6029"},
        {"Geneva Identification System", "GEN# +1.00216928"},
        {"Smithsonian Astrophysical Observation", "SAO 34972"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.04479312),
        dec: Angle.Degrees(+56.45043962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68077"},
        {"Hipparcos Number", "HIP 40305"},
        {"Fundamental Katalog 5th Edition", "FK5 2640"},
        {"Geneva Identification System", "GEN# +1.00068077"},
        {"Smithsonian Astrophysical Observation", "SAO 26732"},
        {"Wilson Evans Batten Catalogue", "WEB 7858"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.45916037),
        dec: Angle.Degrees(+56.45231827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6589 A"},
        {"Henry Draper", "HD 66772"},
        {"Hipparcos Number", "HIP 39807"},
        {"Smithsonian Astrophysical Observation", "SAO 26681"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.01408142),
        dec: Angle.Degrees(+56.45280861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238030"},
        {"Hipparcos Number", "HIP 57044"},
        {"Smithsonian Astrophysical Observation", "SAO 28100"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.42957629),
        dec: Angle.Degrees(+56.45353081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238578"},
        {"Hipparcos Number", "HIP 81158"},
        {"Smithsonian Astrophysical Observation", "SAO 29997"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.63109630),
        dec: Angle.Degrees(+56.45449309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118822"},
        {"Hipparcos Number", "HIP 66501"},
        {"Smithsonian Astrophysical Observation", "SAO 28822"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.48354380),
        dec: Angle.Degrees(+56.45639715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218091"},
        {"Hipparcos Number", "HIP 113939"},
        {"Geneva Identification System", "GEN# +1.00218091"},
        {"Smithsonian Astrophysical Observation", "SAO 35121"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.10483633),
        dec: Angle.Degrees(+56.45677956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184959"},
        {"Hipparcos Number", "HIP 96214"},
        {"Smithsonian Astrophysical Observation", "SAO 31778"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.47397674),
        dec: Angle.Degrees(+56.45985673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118172"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.56985410),
        dec: Angle.Degrees(+56.47106679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52668"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.54580993),
        dec: Angle.Degrees(+56.47150086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61146"},
        {"Hipparcos Number", "HIP 37431"},
        {"Geneva Identification System", "GEN# +1.00061146"},
        {"Smithsonian Astrophysical Observation", "SAO 26461"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.25360311),
        dec: Angle.Degrees(+56.47369613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86335"},
        {"Hipparcos Number", "HIP 48981"},
        {"Smithsonian Astrophysical Observation", "SAO 27462"},
        {"Wilson Evans Batten Catalogue", "WEB 9089"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.89758560),
        dec: Angle.Degrees(+56.47452159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79423"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.14091516),
        dec: Angle.Degrees(+56.47666051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237769"},
        {"Hipparcos Number", "HIP 44223"},
        {"Smithsonian Astrophysical Observation", "SAO 27079"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.11507431),
        dec: Angle.Degrees(+56.47849553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122284"},
        {"Hipparcos Number", "HIP 68336"},
        {"Smithsonian Astrophysical Observation", "SAO 28960"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.83030045),
        dec: Angle.Degrees(+56.48588321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238251"},
        {"Hipparcos Number", "HIP 66082"},
        {"Smithsonian Astrophysical Observation", "SAO 28796"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.19770681),
        dec: Angle.Degrees(+56.48629438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36770"},
        {"Hipparcos Number", "HIP 26426"},
        {"Geneva Identification System", "GEN# +1.00036770"},
        {"Smithsonian Astrophysical Observation", "SAO 25277"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.36269872),
        dec: Angle.Degrees(+56.48783262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197939"},
        {"Hipparcos Number", "HIP 102358"},
        {"Geneva Identification System", "GEN# +1.00197939"},
        {"Smithsonian Astrophysical Observation", "SAO 32849"},
        {"Wilson Evans Batten Catalogue", "WEB 18529"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.09183699),
        dec: Angle.Degrees(+56.48840856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223969"},
        {"Hipparcos Number", "HIP 117842"},
        {"Smithsonian Astrophysical Observation", "SAO 35875"},
        {"Wilson Evans Batten Catalogue", "WEB 20730"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.50840496),
        dec: Angle.Degrees(+56.48941000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217071"},
        {"Hipparcos Number", "HIP 113324"},
        {"Geneva Identification System", "GEN# +1.00217071"},
        {"Smithsonian Astrophysical Observation", "SAO 34990"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.26123591),
        dec: Angle.Degrees(+56.49062989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187749"},
        {"Hipparcos Number", "HIP 97462"},
        {"Smithsonian Astrophysical Observation", "SAO 32018"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.14801677),
        dec: Angle.Degrees(+56.50080486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4868"},
        {"Hipparcos Number", "HIP 4016"},
        {"Smithsonian Astrophysical Observation", "SAO 21773"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.87115851),
        dec: Angle.Degrees(+56.50196415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236503"},
        {"Hipparcos Number", "HIP 3341"},
        {"Smithsonian Astrophysical Observation", "SAO 21644"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.64556488),
        dec: Angle.Degrees(+56.50373158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64347"},
        {"Hipparcos Number", "HIP 38800"},
        {"Geneva Identification System", "GEN# +1.00064347"},
        {"Smithsonian Astrophysical Observation", "SAO 26579"},
        {"Wilson Evans Batten Catalogue", "WEB 7598"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.11135122),
        dec: Angle.Degrees(+56.50450871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27322"},
        {"Hipparcos Number", "HIP 20380"},
        {"Geneva Identification System", "GEN# +1.00027322"},
        {"Smithsonian Astrophysical Observation", "SAO 24563"},
        {"Wilson Evans Batten Catalogue", "WEB 3895"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.46592207),
        dec: Angle.Degrees(+56.50630039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90319"},
        {"Hipparcos Number", "HIP 51153"},
        {"Smithsonian Astrophysical Observation", "SAO 27645"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.73698393),
        dec: Angle.Degrees(+56.50740747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33500"},
        {"Hipparcos Number", "HIP 24390"},
        {"Smithsonian Astrophysical Observation", "SAO 25080"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.49038556),
        dec: Angle.Degrees(+56.50804811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55555"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.69570104),
        dec: Angle.Degrees(+56.50833743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239857"},
        {"Hipparcos Number", "HIP 109213"},
        {"Geneva Identification System", "GEN# +1.00239857"},
        {"Smithsonian Astrophysical Observation", "SAO 34080"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.87523803),
        dec: Angle.Degrees(+56.50844951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204400"},
        {"Hipparcos Number", "HIP 105836"},
        {"Smithsonian Astrophysical Observation", "SAO 33429"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.55225447),
        dec: Angle.Degrees(+56.50900450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236835"},
        {"Hipparcos Number", "HIP 8025"},
        {"Geneva Identification System", "GEN# +0.05500388"},
        {"Smithsonian Astrophysical Observation", "SAO 22538"},
    },
    visualMagnitude: 8.87,
    bvColour: 2.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.76131848),
        dec: Angle.Degrees(+56.51278671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239644"},
        {"Hipparcos Number", "HIP 105545"},
        {"Geneva Identification System", "GEN# +1.00239644"},
        {"Smithsonian Astrophysical Observation", "SAO 33369"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.64489165),
        dec: Angle.Degrees(+56.51322450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164"},
        {"Hipparcos Number", "HIP 542"},
        {"Smithsonian Astrophysical Observation", "SAO 21088"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.64950882),
        dec: Angle.Degrees(+56.51450029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216510"},
        {"Hipparcos Number", "HIP 112956"},
        {"Smithsonian Astrophysical Observation", "SAO 34912"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14703322),
        dec: Angle.Degrees(+56.52029689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123338"},
        {"Hipparcos Number", "HIP 68814"},
        {"Geneva Identification System", "GEN# +1.00123338"},
        {"Smithsonian Astrophysical Observation", "SAO 29004"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.32429500),
        dec: Angle.Degrees(+56.52062000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89862"},
        {"Hipparcos Number", "HIP 50892"},
        {"Geneva Identification System", "GEN# +1.00089862"},
        {"Smithsonian Astrophysical Observation", "SAO 27629"},
        {"Wilson Evans Batten Catalogue", "WEB 9311"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.88532437),
        dec: Angle.Degrees(+56.52141034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238382"},
        {"Hipparcos Number", "HIP 71896"},
        {"Smithsonian Astrophysical Observation", "SAO 29252"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.58068530),
        dec: Angle.Degrees(+56.52227160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177195"},
        {"Hipparcos Number", "HIP 93321"},
        {"Geneva Identification System", "GEN# +1.00177195"},
        {"Smithsonian Astrophysical Observation", "SAO 31318"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.11461129),
        dec: Angle.Degrees(+56.52533534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237922"},
        {"Hipparcos Number", "HIP 52265"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.19640667),
        dec: Angle.Degrees(+56.52535592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111363"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.41984868),
        dec: Angle.Degrees(+56.52630850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88800"},
        {"Hipparcos Number", "HIP 50301"},
        {"Smithsonian Astrophysical Observation", "SAO 27583"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.05472051),
        dec: Angle.Degrees(+56.52639087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43352"},
        {"Hipparcos Number", "HIP 30031"},
        {"Smithsonian Astrophysical Observation", "SAO 25662"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.79165668),
        dec: Angle.Degrees(+56.52666856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67991"},
        {"Hipparcos Number", "HIP 40262"},
        {"Geneva Identification System", "GEN# +1.00067991"},
        {"Smithsonian Astrophysical Observation", "SAO 26727"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34030918),
        dec: Angle.Degrees(+56.52799685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30427"},
        {"Hipparcos Number", "HIP 22522"},
        {"Geneva Identification System", "GEN# +1.00030427"},
        {"Smithsonian Astrophysical Observation", "SAO 24861"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.70028433),
        dec: Angle.Degrees(+56.53028103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4029"},
        {"Hipparcos Number", "HIP 3413"},
        {"Smithsonian Astrophysical Observation", "SAO 21657"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.86025525),
        dec: Angle.Degrees(+56.53396499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219135"},
        {"Hipparcos Number", "HIP 114594"},
        {"Geneva Identification System", "GEN# +1.00219135"},
        {"Smithsonian Astrophysical Observation", "SAO 35235"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.22141244),
        dec: Angle.Degrees(+56.53663808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154904"},
        {"Hipparcos Number", "HIP 83589"},
        {"Smithsonian Astrophysical Observation", "SAO 30236"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.26589635),
        dec: Angle.Degrees(+56.53736576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3179",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Schedar"},
        {"Aitken", "ADS 561 A"},
        {"Henry Draper", "HD 3712"},
        {"Hipparcos Number", "HIP 3179"},
        {"Fundamental Katalog 5th Edition", "FK5 21"},
        {"Geneva Identification System", "GEN# +1.00003712"},
        {"Smithsonian Astrophysical Observation", "SAO 21609"},
        {"Wilson Evans Batten Catalogue", "WEB 569"},
    },
    visualMagnitude: 2.24,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.12661349),
        dec: Angle.Degrees(+56.53740928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142815"},
        {"Hipparcos Number", "HIP 77850"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.44862430),
        dec: Angle.Degrees(+56.54058709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203591"},
        {"Hipparcos Number", "HIP 105415"},
        {"Smithsonian Astrophysical Observation", "SAO 33344"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.27243924),
        dec: Angle.Degrees(+56.54171970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236462"},
        {"Hipparcos Number", "HIP 2624"},
        {"Smithsonian Astrophysical Observation", "SAO 21516"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.32103424),
        dec: Angle.Degrees(+56.54376029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57667"},
        {"Hipparcos Number", "HIP 36026"},
        {"Geneva Identification System", "GEN# +1.00057667"},
        {"Smithsonian Astrophysical Observation", "SAO 26337"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.35981692),
        dec: Angle.Degrees(+56.54413321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9017"},
        {"Geneva Identification System", "GEN# +0.05500441"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.02975172),
        dec: Angle.Degrees(+56.55438536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1598"},
        {"Hipparcos Number", "HIP 1644"},
        {"Geneva Identification System", "GEN# +1.00001598"},
        {"Smithsonian Astrophysical Observation", "SAO 21313"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.14214023),
        dec: Angle.Degrees(+56.55696240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237380"},
        {"Hipparcos Number", "HIP 25102"},
        {"Smithsonian Astrophysical Observation", "SAO 25149"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.61718018),
        dec: Angle.Degrees(+56.55826119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239775"},
        {"Hipparcos Number", "HIP 107725"},
        {"Geneva Identification System", "GEN# +1.00239775"},
        {"Smithsonian Astrophysical Observation", "SAO 33784"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.33748979),
        dec: Angle.Degrees(+56.55915217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239696"},
        {"Hipparcos Number", "HIP 106430"},
        {"Smithsonian Astrophysical Observation", "SAO 33526"},
    },
    visualMagnitude: 9.17,
    bvColour: 2.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.35411865),
        dec: Angle.Degrees(+56.55975527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2094 A"},
        {"Henry Draper", "HD 16965"},
        {"Hipparcos Number", "HIP 12866"},
        {"Smithsonian Astrophysical Observation", "SAO 23588"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.35313045),
        dec: Angle.Degrees(+56.56372784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12865",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2094 B"},
        {"Henry Draper", "HD 16964"},
        {"Hipparcos Number", "HIP 12865"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.34524190),
        dec: Angle.Degrees(+56.56436228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16641"},
        {"Hipparcos Number", "HIP 12624"},
        {"Renson", "Renson 4170"},
        {"Smithsonian Astrophysical Observation", "SAO 23542"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.56423418),
        dec: Angle.Degrees(+56.56550923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112677"},
        {"Hipparcos Number", "HIP 63254"},
        {"Smithsonian Astrophysical Observation", "SAO 28580"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.41982542),
        dec: Angle.Degrees(+56.56639694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192696"},
        {"Hipparcos Number", "HIP 99655"},
        {"Celescope Catalog", "CEL 4983"},
        {"Fundamental Katalog 5th Edition", "FK5 758"},
        {"Geneva Identification System", "GEN# +1.00192696"},
        {"Smithsonian Astrophysical Observation", "SAO 32378"},
        {"Wilson Evans Batten Catalogue", "WEB 17866"},
    },
    visualMagnitude: 4.28,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.34917142),
        dec: Angle.Degrees(+56.56752223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90859"},
        {"Hipparcos Number", "HIP 51464"},
        {"Smithsonian Astrophysical Observation", "SAO 27671"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.67395874),
        dec: Angle.Degrees(+56.56909038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57625"},
        {"Hipparcos Number", "HIP 36014"},
        {"Geneva Identification System", "GEN# +1.00057625"},
        {"Smithsonian Astrophysical Observation", "SAO 26335"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.32538612),
        dec: Angle.Degrees(+56.56930063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19936"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.14354330),
        dec: Angle.Degrees(+56.57054402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239001"},
        {"Hipparcos Number", "HIP 94095"},
        {"Smithsonian Astrophysical Observation", "SAO 31429"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.31824921),
        dec: Angle.Degrees(+56.57206245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237321"},
        {"Hipparcos Number", "HIP 22456"},
        {"Smithsonian Astrophysical Observation", "SAO 24855"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.48170505),
        dec: Angle.Degrees(+56.57239241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99532"},
        {"Hipparcos Number", "HIP 55905"},
        {"Geneva Identification System", "GEN# +1.00099532"},
        {"Smithsonian Astrophysical Observation", "SAO 28023"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.88941639),
        dec: Angle.Degrees(+56.57551673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8605 B"},
        {"Hipparcos Number", "HIP 61469"},
        {"Smithsonian Astrophysical Observation", "SAO 28438"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.94414574),
        dec: Angle.Degrees(+56.57581208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8605 A"},
        {"Henry Draper", "HD 109654"},
        {"Hipparcos Number", "HIP 61474"},
        {"Smithsonian Astrophysical Observation", "SAO 28440"},
        {"Wilson Evans Batten Catalogue", "WEB 10941"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.95263743),
        dec: Angle.Degrees(+56.57847152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210322"},
        {"Hipparcos Number", "HIP 109252"},
        {"Geneva Identification System", "GEN# +1.00210322"},
        {"Smithsonian Astrophysical Observation", "SAO 34091"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.99455278),
        dec: Angle.Degrees(+56.57881179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10251"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.97139849),
        dec: Angle.Degrees(+56.57978894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37601"},
        {"Hipparcos Number", "HIP 26942"},
        {"Geneva Identification System", "GEN# +1.00037601"},
        {"Smithsonian Astrophysical Observation", "SAO 25333"},
        {"Wilson Evans Batten Catalogue", "WEB 5309"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.75690634),
        dec: Angle.Degrees(+56.58145257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93859"},
        {"Hipparcos Number", "HIP 53043"},
        {"Geneva Identification System", "GEN# +1.00093859"},
        {"Smithsonian Astrophysical Observation", "SAO 27791"},
        {"Wilson Evans Batten Catalogue", "WEB 9643"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.79617975),
        dec: Angle.Degrees(+56.58223677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11544"},
        {"Hipparcos Number", "HIP 8929"},
        {"Geneva Identification System", "GEN# +1.00011544"},
        {"Smithsonian Astrophysical Observation", "SAO 22740"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.73488453),
        dec: Angle.Degrees(+56.58247875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199136"},
        {"Hipparcos Number", "HIP 103050"},
        {"Celescope Catalog", "CEL 5193"},
        {"Geneva Identification System", "GEN# +1.00199136"},
        {"Smithsonian Astrophysical Observation", "SAO 32961"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.18018403),
        dec: Angle.Degrees(+56.58495187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11213 A"},
        {"Henry Draper", "HD 168092"},
        {"Hipparcos Number", "HIP 89401"},
        {"Geneva Identification System", "GEN# +1.00168092"},
        {"Smithsonian Astrophysical Observation", "SAO 30836"},
        {"Wilson Evans Batten Catalogue", "WEB 15206"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.67089504),
        dec: Angle.Degrees(+56.58817842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239728"},
        {"Hipparcos Number", "HIP 106941"},
        {"Smithsonian Astrophysical Observation", "SAO 33638"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.87868066),
        dec: Angle.Degrees(+56.59414386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31419"},
        {"Hipparcos Number", "HIP 23169"},
        {"Geneva Identification System", "GEN# +1.00031419"},
        {"Smithsonian Astrophysical Observation", "SAO 24938"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.76776347),
        dec: Angle.Degrees(+56.59700888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103605"},
        {"Hipparcos Number", "HIP 58181"},
        {"Fundamental Katalog 5th Edition", "FK5 2953"},
        {"Geneva Identification System", "GEN# +1.00103605"},
        {"Smithsonian Astrophysical Observation", "SAO 28191"},
        {"Wilson Evans Batten Catalogue", "WEB 10413"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.99336544),
        dec: Angle.Degrees(+56.59856271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71089"},
        {"Hipparcos Number", "HIP 41544"},
        {"Geneva Identification System", "GEN# +1.00071089"},
        {"Smithsonian Astrophysical Observation", "SAO 26851"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.07668648),
        dec: Angle.Degrees(+56.60173518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239967"},
        {"Hipparcos Number", "HIP 110967"},
        {"Geneva Identification System", "GEN# +1.00239967"},
        {"Smithsonian Astrophysical Observation", "SAO 34499"},
        {"Wilson Evans Batten Catalogue", "WEB 19867"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.23650948),
        dec: Angle.Degrees(+56.60324262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149007"},
        {"Hipparcos Number", "HIP 80729"},
        {"Smithsonian Astrophysical Observation", "SAO 29962"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.23063441),
        dec: Angle.Degrees(+56.60461216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98449"},
        {"Hipparcos Number", "HIP 55371"},
        {"Geneva Identification System", "GEN# +1.00098449"},
        {"Smithsonian Astrophysical Observation", "SAO 27992"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.06646603),
        dec: Angle.Degrees(+56.60669242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236711"},
        {"Hipparcos Number", "HIP 6435"},
        {"Smithsonian Astrophysical Observation", "SAO 22224"},
        {"Wilson Evans Batten Catalogue", "WEB 1426"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.66383453),
        dec: Angle.Degrees(+56.60956326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14818"},
        {"Hipparcos Number", "HIP 11279"},
        {"Celescope Catalog", "CEL 269"},
        {"Geneva Identification System", "GEN# +1.00014818"},
        {"Smithsonian Astrophysical Observation", "SAO 23304"},
        {"Wilson Evans Batten Catalogue", "WEB 2359"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.31678817),
        dec: Angle.Degrees(+56.60982421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208501"},
        {"Hipparcos Number", "HIP 108165"},
        {"Fundamental Katalog 5th Edition", "FK5 3749"},
        {"Geneva Identification System", "GEN# +1.00208501"},
        {"Renson", "Renson 57960"},
        {"Smithsonian Astrophysical Observation", "SAO 33864"},
        {"Wilson Evans Batten Catalogue", "WEB 19498"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.72149220),
        dec: Angle.Degrees(+56.61123260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32404"},
        {"Hipparcos Number", "HIP 23748"},
        {"Geneva Identification System", "GEN# +1.00032404"},
        {"Smithsonian Astrophysical Observation", "SAO 25004"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.56871633),
        dec: Angle.Degrees(+56.61269520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4787"},
        {"Hipparcos Number", "HIP 3942"},
        {"Smithsonian Astrophysical Observation", "SAO 21760"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.65073842),
        dec: Angle.Degrees(+56.61287556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177778"},
        {"Hipparcos Number", "HIP 93527"},
        {"Smithsonian Astrophysical Observation", "SAO 31348"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.73537937),
        dec: Angle.Degrees(+56.61479288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130499"},
        {"Hipparcos Number", "HIP 72238"},
        {"Smithsonian Astrophysical Observation", "SAO 29274"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.59767074),
        dec: Angle.Degrees(+56.61639997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50243"},
        {"Hipparcos Number", "HIP 33313"},
        {"Smithsonian Astrophysical Observation", "SAO 26039"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.93558644),
        dec: Angle.Degrees(+56.61768419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62117"},
        {"Hipparcos Number", "HIP 37840"},
        {"Smithsonian Astrophysical Observation", "SAO 26494"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.36696640),
        dec: Angle.Degrees(+56.61874600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76067"},
        {"Hipparcos Number", "HIP 43884"},
        {"Smithsonian Astrophysical Observation", "SAO 27049"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.10232580),
        dec: Angle.Degrees(+56.61992229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237651"},
        {"Hipparcos Number", "HIP 38865"},
        {"Smithsonian Astrophysical Observation", "SAO 26585"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.30725420),
        dec: Angle.Degrees(+56.62241530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69893"},
        {"Hipparcos Number", "HIP 40992"},
        {"Geneva Identification System", "GEN# +1.00069893"},
        {"Smithsonian Astrophysical Observation", "SAO 26796"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.48289053),
        dec: Angle.Degrees(+56.62439167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213930"},
        {"Hipparcos Number", "HIP 111362"},
        {"Geneva Identification System", "GEN# +1.00213930"},
        {"Smithsonian Astrophysical Observation", "SAO 34574"},
        {"Wilson Evans Batten Catalogue", "WEB 19918"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.41902799),
        dec: Angle.Degrees(+56.62463722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43125"},
        {"Hipparcos Number", "HIP 29924"},
        {"Smithsonian Astrophysical Observation", "SAO 25651"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.49857147),
        dec: Angle.Degrees(+56.62547988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4121",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 719 ABCD"},
        {"Henry Draper", "HD 5005"},
        {"Hipparcos Number", "HIP 4121"},
        {"Geneva Identification System", "GEN# +1.00005005J"},
        {"Wilson Evans Batten Catalogue", "WEB 735"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.20506815),
        dec: Angle.Degrees(+56.62764622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157787"},
        {"Hipparcos Number", "HIP 84973"},
        {"Smithsonian Astrophysical Observation", "SAO 30359"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.50845233),
        dec: Angle.Degrees(+56.62845067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53519"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.22154651),
        dec: Angle.Degrees(+56.63080299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7666"},
        {"Hipparcos Number", "HIP 6057"},
        {"Smithsonian Astrophysical Observation", "SAO 22159"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.43855172),
        dec: Angle.Degrees(+56.63163455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237389"},
        {"Hipparcos Number", "HIP 25444"},
        {"Smithsonian Astrophysical Observation", "SAO 25194"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.63063488),
        dec: Angle.Degrees(+56.63177474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238464"},
        {"Hipparcos Number", "HIP 75652"},
        {"Smithsonian Astrophysical Observation", "SAO 29533"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.83599633),
        dec: Angle.Degrees(+56.63516985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53050"},
        {"Hipparcos Number", "HIP 34324"},
        {"Smithsonian Astrophysical Observation", "SAO 26152"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.73263885),
        dec: Angle.Degrees(+56.63524602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13870 B"},
        {"Henry Draper", "HD 239413"},
        {"Hipparcos Number", "HIP 100812"},
        {"Geneva Identification System", "GEN# +1.00239413"},
        {"Smithsonian Astrophysical Observation", "SAO 32591"},
        {"Wilson Evans Batten Catalogue", "WEB 18218"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.60958659),
        dec: Angle.Degrees(+56.63537546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29191"},
        {"Hipparcos Number", "HIP 21655"},
        {"Geneva Identification System", "GEN# +1.00029191"},
        {"Smithsonian Astrophysical Observation", "SAO 24737"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.74098161),
        dec: Angle.Degrees(+56.63812882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100808",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13870 A"},
        {"Henry Draper", "HD 195066"},
        {"Hipparcos Number", "HIP 100808"},
        {"Celescope Catalog", "CEL 5066"},
        {"Geneva Identification System", "GEN# +1.00195066"},
        {"Smithsonian Astrophysical Observation", "SAO 32590"},
        {"Wilson Evans Batten Catalogue", "WEB 18217"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.59776500),
        dec: Angle.Degrees(+56.63867785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2244"},
        {"Hipparcos Number", "HIP 2101"},
        {"Smithsonian Astrophysical Observation", "SAO 21405"},
        {"Wilson Evans Batten Catalogue", "WEB 395"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.66437705),
        dec: Angle.Degrees(+56.64120708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1748 AB"},
        {"Henry Draper", "HD 13970"},
        {"Hipparcos Number", "HIP 10704"},
        {"Celescope Catalog", "CEL 243"},
        {"Geneva Identification System", "GEN# +1.00013970J"},
        {"Smithsonian Astrophysical Observation", "SAO 23138"},
        {"Wilson Evans Batten Catalogue", "WEB 2256"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.44307661),
        dec: Angle.Degrees(+56.64137385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236861"},
        {"Hipparcos Number", "HIP 8186"},
        {"Smithsonian Astrophysical Observation", "SAO 22590"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.30399969),
        dec: Angle.Degrees(+56.64328107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95901",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12552 AB"},
        {"Henry Draper", "HD 184195"},
        {"Hipparcos Number", "HIP 95901"},
        {"Smithsonian Astrophysical Observation", "SAO 31716"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.55250658),
        dec: Angle.Degrees(+56.64445927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14870"},
        {"Hipparcos Number", "HIP 11347"},
        {"Geneva Identification System", "GEN# +1.00014870"},
        {"Smithsonian Astrophysical Observation", "SAO 23320"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.49580985),
        dec: Angle.Degrees(+56.65791320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155902"},
        {"Hipparcos Number", "HIP 84062"},
        {"Geneva Identification System", "GEN# +1.00155902"},
        {"Smithsonian Astrophysical Observation", "SAO 30285"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.78510887),
        dec: Angle.Degrees(+56.65936960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237828"},
        {"Hipparcos Number", "HIP 47523"},
        {"Smithsonian Astrophysical Observation", "SAO 27339"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.32226165),
        dec: Angle.Degrees(+56.66140229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176228"},
        {"Hipparcos Number", "HIP 92935"},
        {"Geneva Identification System", "GEN# +1.00176228"},
        {"Smithsonian Astrophysical Observation", "SAO 31276"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.02139023),
        dec: Angle.Degrees(+56.66161587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105897"},
        {"Hipparcos Number", "HIP 59407"},
        {"Geneva Identification System", "GEN# +1.00105897"},
        {"Smithsonian Astrophysical Observation", "SAO 28283"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.79970927),
        dec: Angle.Degrees(+56.66199374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15548"},
        {"Hipparcos Number", "HIP 11782"},
        {"Geneva Identification System", "GEN# +1.00015548"},
        {"Smithsonian Astrophysical Observation", "SAO 23406"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.02098801),
        dec: Angle.Degrees(+56.66621805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71224"},
        {"Hipparcos Number", "HIP 41607"},
        {"Smithsonian Astrophysical Observation", "SAO 26857"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.23135249),
        dec: Angle.Degrees(+56.66711822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86894"},
        {"Hipparcos Number", "HIP 49262"},
        {"Geneva Identification System", "GEN# +1.00086894"},
        {"Smithsonian Astrophysical Observation", "SAO 27493"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.84366589),
        dec: Angle.Degrees(+56.66769601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14575 AB"},
        {"Henry Draper", "HD 200614"},
        {"Hipparcos Number", "HIP 103810"},
        {"Celescope Catalog", "CEL 5234"},
        {"Geneva Identification System", "GEN# +1.00200614J"},
        {"Smithsonian Astrophysical Observation", "SAO 33078"},
        {"Wilson Evans Batten Catalogue", "WEB 18892"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.53748512),
        dec: Angle.Degrees(+56.66961137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11631",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1893 AB"},
        {"Henry Draper", "HD 15332"},
        {"Hipparcos Number", "HIP 11631"},
        {"Smithsonian Astrophysical Observation", "SAO 23379"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.52093713),
        dec: Angle.Degrees(+56.67353368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109792"},
        {"Hipparcos Number", "HIP 61570"},
        {"Smithsonian Astrophysical Observation", "SAO 28448"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.23561803),
        dec: Angle.Degrees(+56.67450098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219537"},
        {"Hipparcos Number", "HIP 114853"},
        {"Celescope Catalog", "CEL 5588"},
        {"Geneva Identification System", "GEN# +1.00219537"},
        {"Smithsonian Astrophysical Observation", "SAO 35271"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.96508985),
        dec: Angle.Degrees(+56.67615560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193836"},
        {"Hipparcos Number", "HIP 100218"},
        {"Smithsonian Astrophysical Observation", "SAO 32478"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.89326228),
        dec: Angle.Degrees(+56.67744330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203763"},
        {"Hipparcos Number", "HIP 105508"},
        {"Smithsonian Astrophysical Observation", "SAO 33359"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.53932523),
        dec: Angle.Degrees(+56.68032894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115019"},
        {"Hipparcos Number", "HIP 64523"},
        {"Geneva Identification System", "GEN# +1.00115019"},
        {"Smithsonian Astrophysical Observation", "SAO 28677"},
        {"Wilson Evans Batten Catalogue", "WEB 11408"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.36833084),
        dec: Angle.Degrees(+56.68091877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191527"},
        {"Hipparcos Number", "HIP 99133"},
        {"Smithsonian Astrophysical Observation", "SAO 32301"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.88650858),
        dec: Angle.Degrees(+56.68123782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145021"},
        {"Hipparcos Number", "HIP 78856"},
        {"Smithsonian Astrophysical Observation", "SAO 29795"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.45848182),
        dec: Angle.Degrees(+56.68366682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189296"},
        {"Hipparcos Number", "HIP 98111"},
        {"Geneva Identification System", "GEN# +1.00189296"},
        {"Smithsonian Astrophysical Observation", "SAO 32128"},
        {"Wilson Evans Batten Catalogue", "WEB 17291"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.07925317),
        dec: Angle.Degrees(+56.68697532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153956"},
        {"Hipparcos Number", "HIP 83138"},
        {"Fundamental Katalog 5th Edition", "FK5 3353"},
        {"Geneva Identification System", "GEN# +1.00153956"},
        {"Smithsonian Astrophysical Observation", "SAO 30190"},
        {"Wilson Evans Batten Catalogue", "WEB 14050"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.83987304),
        dec: Angle.Degrees(+56.68850477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73553"},
        {"Hipparcos Number", "HIP 42663"},
        {"Geneva Identification System", "GEN# +1.00073553"},
        {"Smithsonian Astrophysical Observation", "SAO 26963"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.43294772),
        dec: Angle.Degrees(+56.68865462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69699",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9197 C"},
        {"Henry Draper", "HD 125193"},
        {"Hipparcos Number", "HIP 69699"},
        {"Fundamental Katalog 5th Edition", "FK5 5261"},
        {"Geneva Identification System", "GEN# +1.00125193"},
        {"Smithsonian Astrophysical Observation", "SAO 29070"},
        {"Wilson Evans Batten Catalogue", "WEB 12136"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.99953250),
        dec: Angle.Degrees(+56.68937159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237334"},
        {"Hipparcos Number", "HIP 23008"},
        {"Smithsonian Astrophysical Observation", "SAO 24926"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.23485529),
        dec: Angle.Degrees(+56.68986939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218151"},
        {"Hipparcos Number", "HIP 113975"},
        {"Smithsonian Astrophysical Observation", "SAO 35130"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.23048039),
        dec: Angle.Degrees(+56.69059653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128729"},
        {"Hipparcos Number", "HIP 71440"},
        {"Geneva Identification System", "GEN# +1.00128729"},
        {"Smithsonian Astrophysical Observation", "SAO 29218"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.15303991),
        dec: Angle.Degrees(+56.69160793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47606"},
        {"Hipparcos Number", "HIP 32151"},
        {"Geneva Identification System", "GEN# +1.00047606"},
        {"Renson", "Renson 12760"},
        {"Smithsonian Astrophysical Observation", "SAO 25890"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.71666090),
        dec: Angle.Degrees(+56.69308573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160383"},
        {"Hipparcos Number", "HIP 86144"},
        {"Smithsonian Astrophysical Observation", "SAO 30476"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.05877044),
        dec: Angle.Degrees(+56.69477151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236748"},
        {"Hipparcos Number", "HIP 6863"},
        {"Smithsonian Astrophysical Observation", "SAO 22299"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.08035722),
        dec: Angle.Degrees(+56.69839971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80390"},
        {"Hipparcos Number", "HIP 45915"},
        {"Fundamental Katalog 5th Edition", "FK5 2743"},
        {"Geneva Identification System", "GEN# +1.00080390"},
        {"Smithsonian Astrophysical Observation", "SAO 27219"},
        {"Wilson Evans Batten Catalogue", "WEB 8708"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.43041783),
        dec: Angle.Degrees(+56.69924850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7441"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.96042900),
        dec: Angle.Degrees(+56.69968295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238427"},
        {"Hipparcos Number", "HIP 74031"},
        {"Smithsonian Astrophysical Observation", "SAO 29417"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.92744718),
        dec: Angle.Degrees(+56.70279362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18970"},
        {"Hipparcos Number", "HIP 14382"},
        {"Fundamental Katalog 5th Edition", "FK5 2217"},
        {"Geneva Identification System", "GEN# +1.00018970"},
        {"Smithsonian Astrophysical Observation", "SAO 23791"},
        {"Wilson Evans Batten Catalogue", "WEB 2808"},
    },
    visualMagnitude: 4.77,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.38510717),
        dec: Angle.Degrees(+56.70554810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115043"},
        {"Hipparcos Number", "HIP 64532"},
        {"Geneva Identification System", "GEN# +1.00115043"},
        {"Smithsonian Astrophysical Observation", "SAO 28679"},
        {"Wilson Evans Batten Catalogue", "WEB 11413"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.40370674),
        dec: Angle.Degrees(+56.70831399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216509"},
        {"Hipparcos Number", "HIP 112957"},
        {"Geneva Identification System", "GEN# +1.00216509"},
        {"Smithsonian Astrophysical Observation", "SAO 34911"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14739819),
        dec: Angle.Degrees(+56.70970019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239948"},
        {"Hipparcos Number", "HIP 110648"},
        {"Smithsonian Astrophysical Observation", "SAO 34424"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.22949020),
        dec: Angle.Degrees(+56.71020005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209296"},
        {"Hipparcos Number", "HIP 108654"},
        {"Geneva Identification System", "GEN# +1.00209296"},
        {"Smithsonian Astrophysical Observation", "SAO 33968"},
        {"Wilson Evans Batten Catalogue", "WEB 19550"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.16788262),
        dec: Angle.Degrees(+56.71062796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238857"},
        {"Hipparcos Number", "HIP 89905"},
        {"Smithsonian Astrophysical Observation", "SAO 30911"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.18296581),
        dec: Angle.Degrees(+56.71109240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238029"},
        {"Hipparcos Number", "HIP 57031"},
        {"Smithsonian Astrophysical Observation", "SAO 28098"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.40225460),
        dec: Angle.Degrees(+56.71192167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27224"},
        {"Hipparcos Number", "HIP 20308"},
        {"Geneva Identification System", "GEN# +1.00027224"},
        {"Smithsonian Astrophysical Observation", "SAO 24550"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26501413),
        dec: Angle.Degrees(+56.71224214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9197 A"},
        {"Henry Draper", "HD 125229"},
        {"Hipparcos Number", "HIP 69711"},
        {"Smithsonian Astrophysical Observation", "SAO 29074"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.03546840),
        dec: Angle.Degrees(+56.71268043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32959"},
        {"Hipparcos Number", "HIP 24056"},
        {"Smithsonian Astrophysical Observation", "SAO 25054"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.53663501),
        dec: Angle.Degrees(+56.71470353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239601"},
        {"Hipparcos Number", "HIP 104669"},
        {"Smithsonian Astrophysical Observation", "SAO 33214"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.02031741),
        dec: Angle.Degrees(+56.71855638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13866"},
        {"Hipparcos Number", "HIP 10641"},
        {"Celescope Catalog", "CEL 236"},
        {"Geneva Identification System", "GEN# +1.00013866"},
        {"Smithsonian Astrophysical Observation", "SAO 23117"},
        {"Wilson Evans Batten Catalogue", "WEB 2238"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.23990230),
        dec: Angle.Degrees(+56.71880234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111094"},
        {"Hipparcos Number", "HIP 62319"},
        {"Smithsonian Astrophysical Observation", "SAO 28511"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.56638535),
        dec: Angle.Degrees(+56.71882379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186303"},
        {"Hipparcos Number", "HIP 96797"},
        {"Smithsonian Astrophysical Observation", "SAO 31885"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.14910516),
        dec: Angle.Degrees(+56.71902659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71905"},
        {"Hipparcos Number", "HIP 41895"},
        {"Geneva Identification System", "GEN# +1.00071905"},
        {"Smithsonian Astrophysical Observation", "SAO 26895"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.14193011),
        dec: Angle.Degrees(+56.72043844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123669"},
        {"Hipparcos Number", "HIP 68984"},
        {"Smithsonian Astrophysical Observation", "SAO 29014"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.84531234),
        dec: Angle.Degrees(+56.72111825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70954"},
        {"Hipparcos Number", "HIP 41480"},
        {"Geneva Identification System", "GEN# +1.00070954"},
        {"Smithsonian Astrophysical Observation", "SAO 26842"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.89920183),
        dec: Angle.Degrees(+56.72183903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28617"},
        {"Hipparcos Number", "HIP 21274"},
        {"Renson", "Renson 7360"},
        {"Smithsonian Astrophysical Observation", "SAO 24689"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.46231938),
        dec: Angle.Degrees(+56.72488858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119332"},
        {"Hipparcos Number", "HIP 66781"},
        {"Smithsonian Astrophysical Observation", "SAO 28849"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.30592914),
        dec: Angle.Degrees(+56.72700106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117466"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.27124482),
        dec: Angle.Degrees(+56.72737242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16523"},
        {"Hipparcos Number", "HIP 12527"},
        {"Smithsonian Astrophysical Observation", "SAO 23526"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.29865008),
        dec: Angle.Degrees(+56.73047603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82759"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.71556265),
        dec: Angle.Degrees(+56.73246586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 246"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.76368704),
        dec: Angle.Degrees(+56.73318400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10081 AB"},
        {"Henry Draper", "HD 148962"},
        {"Hipparcos Number", "HIP 80690"},
        {"Smithsonian Astrophysical Observation", "SAO 29959"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.13352956),
        dec: Angle.Degrees(+56.73550657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99859"},
        {"Hipparcos Number", "HIP 56083"},
        {"Geneva Identification System", "GEN# +1.00099859"},
        {"Renson", "Renson 28740"},
        {"Smithsonian Astrophysical Observation", "SAO 28035"},
        {"Wilson Evans Batten Catalogue", "WEB 10068"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.43191375),
        dec: Angle.Degrees(+56.73765523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13831"},
        {"Hipparcos Number", "HIP 10615"},
        {"Geneva Identification System", "GEN# +1.00013831"},
        {"Smithsonian Astrophysical Observation", "SAO 23109"},
        {"Wilson Evans Batten Catalogue", "WEB 2234"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.16341284),
        dec: Angle.Degrees(+56.73780450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25641"},
        {"Hipparcos Number", "HIP 19224"},
        {"Cincinnati Publication", "Ci 18 545"},
        {"Smithsonian Astrophysical Observation", "SAO 24416"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.80014572),
        dec: Angle.Degrees(+56.73813461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22253"},
        {"Hipparcos Number", "HIP 16917"},
        {"Geneva Identification System", "GEN# +1.00022253"},
        {"Smithsonian Astrophysical Observation", "SAO 24128"},
        {"Wilson Evans Batten Catalogue", "WEB 3218"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.43395927),
        dec: Angle.Degrees(+56.73938634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79354"},
        {"Hipparcos Number", "HIP 45455"},
        {"Geneva Identification System", "GEN# +1.00079354"},
        {"Smithsonian Astrophysical Observation", "SAO 27185"},
        {"Wilson Evans Batten Catalogue", "WEB 8647"},
    },
    visualMagnitude: 5.28,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.95753521),
        dec: Angle.Degrees(+56.74147744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25347"},
        {"Hipparcos Number", "HIP 19034"},
        {"Geneva Identification System", "GEN# +1.00025347"},
        {"Smithsonian Astrophysical Observation", "SAO 24390"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.16330879),
        dec: Angle.Degrees(+56.74220632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99983"},
        {"Hipparcos Number", "HIP 56158"},
        {"Geneva Identification System", "GEN# +1.00099983"},
        {"Smithsonian Astrophysical Observation", "SAO 28041"},
        {"Wilson Evans Batten Catalogue", "WEB 10083"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.67824351),
        dec: Angle.Degrees(+56.74635488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240324"},
        {"Hipparcos Number", "HIP 116203"},
        {"Smithsonian Astrophysical Observation", "SAO 35529"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.16382047),
        dec: Angle.Degrees(+56.74743721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238786"},
        {"Hipparcos Number", "HIP 88068"},
        {"Smithsonian Astrophysical Observation", "SAO 30672"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.79965899),
        dec: Angle.Degrees(+56.74819672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93013",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11883 A"},
        {"Henry Draper", "HD 176409"},
        {"Hipparcos Number", "HIP 93013"},
        {"Geneva Identification System", "GEN# +1.00176409"},
        {"Smithsonian Astrophysical Observation", "SAO 31286"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.22990874),
        dec: Angle.Degrees(+56.74927664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3432 A"},
        {"Henry Draper", "HD 30121"},
        {"Hipparcos Number", "HIP 22287"},
        {"Fundamental Katalog 5th Edition", "FK5 175"},
        {"Geneva Identification System", "GEN# +1.00030121J"},
        {"Renson", "Renson 7760"},
        {"Smithsonian Astrophysical Observation", "SAO 24829"},
        {"Wilson Evans Batten Catalogue", "WEB 4296"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.00090298),
        dec: Angle.Degrees(+56.75753919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88828"},
        {"Hipparcos Number", "HIP 50314"},
        {"Geneva Identification System", "GEN# +1.00088828"},
        {"Smithsonian Astrophysical Observation", "SAO 27584"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.10246595),
        dec: Angle.Degrees(+56.76128820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203026"},
        {"Hipparcos Number", "HIP 105108"},
        {"Celescope Catalog", "CEL 5288"},
        {"Geneva Identification System", "GEN# +1.00203026"},
        {"Smithsonian Astrophysical Observation", "SAO 33290"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.36655982),
        dec: Angle.Degrees(+56.76297025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141507"},
        {"Hipparcos Number", "HIP 77275"},
        {"Smithsonian Astrophysical Observation", "SAO 29656"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.66120773),
        dec: Angle.Degrees(+56.76998996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6948"},
        {"Hipparcos Number", "HIP 5536"},
        {"Celescope Catalog", "CEL 123"},
        {"Geneva Identification System", "GEN# +1.00006948"},
        {"Smithsonian Astrophysical Observation", "SAO 22068"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.74464905),
        dec: Angle.Degrees(+56.77441961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4266"},
        {"Hipparcos Number", "HIP 3584"},
        {"Geneva Identification System", "GEN# +1.00004266"},
        {"Smithsonian Astrophysical Observation", "SAO 21681"},
        {"Wilson Evans Batten Catalogue", "WEB 634"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.44146046),
        dec: Angle.Degrees(+56.77489645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108135"},
        {"Hipparcos Number", "HIP 60584"},
        {"Geneva Identification System", "GEN# +1.00108135"},
        {"Smithsonian Astrophysical Observation", "SAO 28375"},
        {"Wilson Evans Batten Catalogue", "WEB 10776"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.26343152),
        dec: Angle.Degrees(+56.77785826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238932"},
        {"Hipparcos Number", "HIP 91935"},
        {"Smithsonian Astrophysical Observation", "SAO 31144"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12264181),
        dec: Angle.Degrees(+56.77860356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238715"},
        {"Hipparcos Number", "HIP 85859"},
        {"Smithsonian Astrophysical Observation", "SAO 30456"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.18440243),
        dec: Angle.Degrees(+56.77863984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2074",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 350 A"},
        {"Henry Draper", "HD 2170"},
        {"Hipparcos Number", "HIP 2074"},
        {"Geneva Identification System", "GEN# +1.00002170"},
        {"Smithsonian Astrophysical Observation", "SAO 21395"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.55042158),
        dec: Angle.Degrees(+56.77934000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195964"},
        {"Hipparcos Number", "HIP 101285"},
        {"Geneva Identification System", "GEN# +1.00195964"},
        {"Smithsonian Astrophysical Observation", "SAO 32667"},
        {"Wilson Evans Batten Catalogue", "WEB 18301"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.94383104),
        dec: Angle.Degrees(+56.77987434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151613"},
        {"Hipparcos Number", "HIP 82020"},
        {"Fundamental Katalog 5th Edition", "FK5 627"},
        {"Geneva Identification System", "GEN# +1.00151613"},
        {"Smithsonian Astrophysical Observation", "SAO 30076"},
        {"Wilson Evans Batten Catalogue", "WEB 13849"},
    },
    visualMagnitude: 4.84,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.32412380),
        dec: Angle.Degrees(+56.78168723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57910",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8328 A"},
        {"Henry Draper", "HD 103127"},
        {"Hipparcos Number", "HIP 57910"},
        {"Smithsonian Astrophysical Observation", "SAO 28175"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.16961511),
        dec: Angle.Degrees(+56.78217593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213419"},
        {"Hipparcos Number", "HIP 111060"},
        {"Smithsonian Astrophysical Observation", "SAO 34522"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.47706312),
        dec: Angle.Degrees(+56.78385761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238449"},
        {"Hipparcos Number", "HIP 75098"},
        {"Smithsonian Astrophysical Observation", "SAO 29492"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.18419568),
        dec: Angle.Degrees(+56.78558828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111795",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16140 A"},
        {"Henry Draper", "HD 214665"},
        {"Hipparcos Number", "HIP 111795"},
        {"Geneva Identification System", "GEN# +1.00214665"},
        {"Smithsonian Astrophysical Observation", "SAO 34651"},
        {"Wilson Evans Batten Catalogue", "WEB 19968"},
    },
    visualMagnitude: 5.11,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.65778029),
        dec: Angle.Degrees(+56.79571012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238148"},
        {"Hipparcos Number", "HIP 61857"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.16412820),
        dec: Angle.Degrees(+56.79770335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198793"},
        {"Hipparcos Number", "HIP 102858"},
        {"Celescope Catalog", "CEL 5185"},
        {"Geneva Identification System", "GEN# +1.00198793"},
        {"Smithsonian Astrophysical Observation", "SAO 32929"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.57602467),
        dec: Angle.Degrees(+56.79843379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166494"},
        {"Hipparcos Number", "HIP 88790"},
        {"Smithsonian Astrophysical Observation", "SAO 30763"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.87250210),
        dec: Angle.Degrees(+56.80174547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238066"},
        {"Hipparcos Number", "HIP 58902"},
        {"Smithsonian Astrophysical Observation", "SAO 28235"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.19137930),
        dec: Angle.Degrees(+56.80180500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236646"},
        {"Hipparcos Number", "HIP 5582"},
        {"Smithsonian Astrophysical Observation", "SAO 22075"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.89694258),
        dec: Angle.Degrees(+56.80214506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221238"},
        {"Hipparcos Number", "HIP 115971"},
        {"Smithsonian Astrophysical Observation", "SAO 35474"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.44907432),
        dec: Angle.Degrees(+56.80347904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51018"},
        {"Hipparcos Number", "HIP 33615"},
        {"Smithsonian Astrophysical Observation", "SAO 26076"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.76418334),
        dec: Angle.Degrees(+56.80542066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121016"},
        {"Hipparcos Number", "HIP 67628"},
        {"Smithsonian Astrophysical Observation", "SAO 28908"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.85758237),
        dec: Angle.Degrees(+56.81008215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9389"},
        {"Hipparcos Number", "HIP 7279"},
        {"Geneva Identification System", "GEN# +1.00009389"},
        {"Smithsonian Astrophysical Observation", "SAO 22394"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.43762177),
        dec: Angle.Degrees(+56.81029520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86378"},
        {"Hipparcos Number", "HIP 49005"},
        {"Fundamental Katalog 5th Edition", "FK5 2802"},
        {"Geneva Identification System", "GEN# +1.00086378"},
        {"Smithsonian Astrophysical Observation", "SAO 27464"},
        {"Wilson Evans Batten Catalogue", "WEB 9093"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.96549960),
        dec: Angle.Degrees(+56.81187557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237733"},
        {"Hipparcos Number", "HIP 42449"},
        {"Smithsonian Astrophysical Observation", "SAO 26943"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81878185),
        dec: Angle.Degrees(+56.81630700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15609 AB"},
        {"Henry Draper", "HD 239843"},
        {"Hipparcos Number", "HIP 108977"},
        {"Geneva Identification System", "GEN# +1.00239843J"},
        {"Smithsonian Astrophysical Observation", "SAO 34027"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.16114624),
        dec: Angle.Degrees(+56.81674537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223924"},
        {"Hipparcos Number", "HIP 117810"},
        {"Celescope Catalog", "CEL 5704"},
        {"Geneva Identification System", "GEN# +1.00223924"},
        {"Smithsonian Astrophysical Observation", "SAO 35871"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.40226526),
        dec: Angle.Degrees(+56.81990392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112184"},
        {"Hipparcos Number", "HIP 62936"},
        {"Smithsonian Astrophysical Observation", "SAO 28552"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.46603535),
        dec: Angle.Degrees(+56.81997086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240058"},
        {"Hipparcos Number", "HIP 112436"},
        {"Smithsonian Astrophysical Observation", "SAO 34798"},
        {"Wilson Evans Batten Catalogue", "WEB 20054"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.62499881),
        dec: Angle.Degrees(+56.82545544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8607 AB"},
        {"Henry Draper", "HD 109702"},
        {"Hipparcos Number", "HIP 61512"},
        {"Geneva Identification System", "GEN# +1.00109702J"},
        {"Smithsonian Astrophysical Observation", "SAO 28441"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.04259730),
        dec: Angle.Degrees(+56.82557259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162825"},
        {"Hipparcos Number", "HIP 87243"},
        {"Smithsonian Astrophysical Observation", "SAO 30596"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.39133117),
        dec: Angle.Degrees(+56.82712067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214975"},
        {"Hipparcos Number", "HIP 111972"},
        {"Geneva Identification System", "GEN# +1.00214975"},
        {"Smithsonian Astrophysical Observation", "SAO 34693"},
        {"Wilson Evans Batten Catalogue", "WEB 19993"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.21729162),
        dec: Angle.Degrees(+56.82947410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238206"},
        {"Hipparcos Number", "HIP 64561"},
        {"Smithsonian Astrophysical Observation", "SAO 28680"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.50327799),
        dec: Angle.Degrees(+56.82979143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239514"},
        {"Hipparcos Number", "HIP 103033"},
        {"Smithsonian Astrophysical Observation", "SAO 32958"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.11697401),
        dec: Angle.Degrees(+56.83126970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46254"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.44922191),
        dec: Angle.Degrees(+56.83131347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114446"},
        {"Hipparcos Number", "HIP 64208"},
        {"Geneva Identification System", "GEN# +1.00114446"},
        {"Smithsonian Astrophysical Observation", "SAO 28655"},
        {"Wilson Evans Batten Catalogue", "WEB 11349"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.38878142),
        dec: Angle.Degrees(+56.83324260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239511"},
        {"Hipparcos Number", "HIP 102983"},
        {"Smithsonian Astrophysical Observation", "SAO 32948"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.96243011),
        dec: Angle.Degrees(+56.83463811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198224"},
        {"Hipparcos Number", "HIP 102502"},
        {"Geneva Identification System", "GEN# +1.00198224"},
        {"Smithsonian Astrophysical Observation", "SAO 32878"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.60211579),
        dec: Angle.Degrees(+56.83497852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69960"},
        {"Hipparcos Number", "HIP 41022"},
        {"Geneva Identification System", "GEN# +1.00069960"},
        {"Smithsonian Astrophysical Observation", "SAO 26800"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.56720944),
        dec: Angle.Degrees(+56.83649603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238020"},
        {"Hipparcos Number", "HIP 56593"},
        {"Geneva Identification System", "GEN# +1.00238020"},
        {"Smithsonian Astrophysical Observation", "SAO 28070"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.04597546),
        dec: Angle.Degrees(+56.83823489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210855"},
        {"Hipparcos Number", "HIP 109572"},
        {"Fundamental Katalog 5th Edition", "FK5 3775"},
        {"Geneva Identification System", "GEN# +1.00210855"},
        {"Smithsonian Astrophysical Observation", "SAO 34151"},
        {"Wilson Evans Batten Catalogue", "WEB 19687"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.95214631),
        dec: Angle.Degrees(+56.83904211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238350"},
        {"Hipparcos Number", "HIP 70453"},
        {"Smithsonian Astrophysical Observation", "SAO 29131"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.17099258),
        dec: Angle.Degrees(+56.84037579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237137"},
        {"Hipparcos Number", "HIP 15945"},
        {"Smithsonian Astrophysical Observation", "SAO 24019"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.33190205),
        dec: Angle.Degrees(+56.84039669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84576"},
        {"Hipparcos Number", "HIP 48078"},
        {"Smithsonian Astrophysical Observation", "SAO 27383"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.02069721),
        dec: Angle.Degrees(+56.84216703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220682"},
        {"Hipparcos Number", "HIP 115613"},
        {"Smithsonian Astrophysical Observation", "SAO 35405"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.30051413),
        dec: Angle.Degrees(+56.84317629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238067"},
        {"Hipparcos Number", "HIP 58920"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.23830725),
        dec: Angle.Degrees(+56.84356469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16449"},
        {"Hipparcos Number", "HIP 12477"},
        {"Smithsonian Astrophysical Observation", "SAO 23516"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15384030),
        dec: Angle.Degrees(+56.84393126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54686"},
        {"Hipparcos Number", "HIP 34886"},
        {"Smithsonian Astrophysical Observation", "SAO 26218"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.27950048),
        dec: Angle.Degrees(+56.84416314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14581"},
        {"Hipparcos Number", "HIP 11146"},
        {"Geneva Identification System", "GEN# +2.08842763"},
        {"Renson", "Renson 3674"},
        {"Smithsonian Astrophysical Observation", "SAO 23275"},
        {"Wilson Evans Batten Catalogue", "WEB 2343"},
        {"New General Catalogue", "NGC 884 2763"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84973381),
        dec: Angle.Degrees(+56.85425124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46590"},
        {"Hipparcos Number", "HIP 31665"},
        {"Geneva Identification System", "GEN# +1.00046590"},
        {"Smithsonian Astrophysical Observation", "SAO 25842"},
        {"Wilson Evans Batten Catalogue", "WEB 6340"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.40999549),
        dec: Angle.Degrees(+56.85750718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60252"},
        {"Hipparcos Number", "HIP 37049"},
        {"Geneva Identification System", "GEN# +1.00060252"},
        {"Smithsonian Astrophysical Observation", "SAO 26422"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.20207868),
        dec: Angle.Degrees(+56.85829131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180006"},
        {"Hipparcos Number", "HIP 94302"},
        {"Fundamental Katalog 5th Edition", "FK5 3535"},
        {"Geneva Identification System", "GEN# +1.00180006"},
        {"Smithsonian Astrophysical Observation", "SAO 31468"},
        {"Wilson Evans Batten Catalogue", "WEB 16427"},
    },
    visualMagnitude: 5.13,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.91883762),
        dec: Angle.Degrees(+56.85909594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161053"},
        {"Hipparcos Number", "HIP 86459"},
        {"Smithsonian Astrophysical Observation", "SAO 30509"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98720549),
        dec: Angle.Degrees(+56.87049831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145623"},
        {"Hipparcos Number", "HIP 79123"},
        {"Geneva Identification System", "GEN# +1.00145623"},
        {"Smithsonian Astrophysical Observation", "SAO 29820"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.26090049),
        dec: Angle.Degrees(+56.87187283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87585",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Grumium"},
        {"Henry Draper", "HD 163588"},
        {"Hipparcos Number", "HIP 87585"},
        {"Fundamental Katalog 5th Edition", "FK5 671"},
        {"Geneva Identification System", "GEN# +1.00163588"},
        {"Smithsonian Astrophysical Observation", "SAO 30631"},
        {"Wilson Evans Batten Catalogue", "WEB 14775"},
    },
    visualMagnitude: 3.73,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.38178961),
        dec: Angle.Degrees(+56.87245216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193052"},
        {"Hipparcos Number", "HIP 99845"},
        {"Smithsonian Astrophysical Observation", "SAO 32401"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.86046353),
        dec: Angle.Degrees(+56.87409377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49116"},
        {"Hipparcos Number", "HIP 32803"},
        {"Smithsonian Astrophysical Observation", "SAO 25978"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.57410681),
        dec: Angle.Degrees(+56.87446808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237399"},
        {"Hipparcos Number", "HIP 26114"},
        {"Smithsonian Astrophysical Observation", "SAO 25254"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.53804937),
        dec: Angle.Degrees(+56.87557715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147923"},
        {"Hipparcos Number", "HIP 80150"},
        {"Smithsonian Astrophysical Observation", "SAO 29914"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.40098503),
        dec: Angle.Degrees(+56.87705645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90401"},
        {"Hipparcos Number", "HIP 51207"},
        {"Renson", "Renson 25980"},
        {"Smithsonian Astrophysical Observation", "SAO 27647"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.89123879),
        dec: Angle.Degrees(+56.87879941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202583"},
        {"Hipparcos Number", "HIP 104871"},
        {"Smithsonian Astrophysical Observation", "SAO 33254"},
        {"Wilson Evans Batten Catalogue", "WEB 19068"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.65152751),
        dec: Angle.Degrees(+56.88340904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47171"},
        {"Hipparcos Number", "HIP 31961"},
        {"Smithsonian Astrophysical Observation", "SAO 25869"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.19731632),
        dec: Angle.Degrees(+56.88385082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182191"},
        {"Hipparcos Number", "HIP 95042"},
        {"Smithsonian Astrophysical Observation", "SAO 31588"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.07916357),
        dec: Angle.Degrees(+56.88605138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220842"},
        {"Hipparcos Number", "HIP 115714"},
        {"Geneva Identification System", "GEN# +1.00220842"},
        {"Smithsonian Astrophysical Observation", "SAO 35419"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.65451202),
        dec: Angle.Degrees(+56.88618706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237141"},
        {"Hipparcos Number", "HIP 16100"},
        {"Smithsonian Astrophysical Observation", "SAO 24041"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.85207074),
        dec: Angle.Degrees(+56.88676252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168268"},
        {"Hipparcos Number", "HIP 89473"},
        {"Smithsonian Astrophysical Observation", "SAO 30849"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.88160576),
        dec: Angle.Degrees(+56.88694481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239226"},
        {"Hipparcos Number", "HIP 97487"},
        {"Smithsonian Astrophysical Observation", "SAO 32024"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.21263967),
        dec: Angle.Degrees(+56.88726713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199661"},
        {"Hipparcos Number", "HIP 103346"},
        {"Celescope Catalog", "CEL 5216"},
        {"Fundamental Katalog 5th Edition", "FK5 3671"},
        {"Geneva Identification System", "GEN# +1.00199661"},
        {"Smithsonian Astrophysical Observation", "SAO 33005"},
        {"Wilson Evans Batten Catalogue", "WEB 18785"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.07085481),
        dec: Angle.Degrees(+56.88750678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126229"},
        {"Hipparcos Number", "HIP 70247"},
        {"Smithsonian Astrophysical Observation", "SAO 29121"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.59580695),
        dec: Angle.Degrees(+56.88761985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209146"},
        {"Hipparcos Number", "HIP 108570"},
        {"Geneva Identification System", "GEN# +1.00209146"},
        {"Smithsonian Astrophysical Observation", "SAO 33948"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.89334197),
        dec: Angle.Degrees(+56.88794276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76169"},
        {"Hipparcos Number", "HIP 43933"},
        {"Smithsonian Astrophysical Observation", "SAO 27052"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.23718063),
        dec: Angle.Degrees(+56.88894018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67196"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.55929881),
        dec: Angle.Degrees(+56.88966365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195872"},
        {"Hipparcos Number", "HIP 101234"},
        {"Smithsonian Astrophysical Observation", "SAO 32654"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.80221181),
        dec: Angle.Degrees(+56.89040376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152012"},
        {"Hipparcos Number", "HIP 82210"},
        {"Geneva Identification System", "GEN# +1.00152012"},
        {"Smithsonian Astrophysical Observation", "SAO 30099"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.92289633),
        dec: Angle.Degrees(+56.89238359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131039"},
        {"Hipparcos Number", "HIP 72467"},
        {"Geneva Identification System", "GEN# +1.00131039"},
        {"Smithsonian Astrophysical Observation", "SAO 29295"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27750386),
        dec: Angle.Degrees(+56.89610287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15450"},
        {"Hipparcos Number", "HIP 11722"},
        {"Celescope Catalog", "CEL 282"},
        {"Geneva Identification System", "GEN# +1.00015450"},
        {"Smithsonian Astrophysical Observation", "SAO 23392"},
        {"Wilson Evans Batten Catalogue", "WEB 2433"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.83140016),
        dec: Angle.Degrees(+56.89783173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73477"},
    },
    visualMagnitude: 11.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25291244),
        dec: Angle.Degrees(+56.90147705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 252.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237204"},
        {"Hipparcos Number", "HIP 18701"},
        {"Geneva Identification System", "GEN# +1.00237204"},
        {"Smithsonian Astrophysical Observation", "SAO 24337"},
        {"Wilson Evans Batten Catalogue", "WEB 3600"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.09700901),
        dec: Angle.Degrees(+56.90160432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240364"},
        {"Hipparcos Number", "HIP 116899"},
        {"Smithsonian Astrophysical Observation", "SAO 35677"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.43710991),
        dec: Angle.Degrees(+56.90299816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16691"},
        {"Hipparcos Number", "HIP 12676"},
        {"Geneva Identification System", "GEN# +1.00016691"},
        {"Smithsonian Astrophysical Observation", "SAO 23550"},
        {"Wilson Evans Batten Catalogue", "WEB 2576"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.71678460),
        dec: Angle.Degrees(+56.90458145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193342"},
        {"Hipparcos Number", "HIP 99987"},
        {"Smithsonian Astrophysical Observation", "SAO 32436"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.25242987),
        dec: Angle.Degrees(+56.90472217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14434"},
        {"Hipparcos Number", "HIP 11018"},
        {"Celescope Catalog", "CEL 260"},
        {"Geneva Identification System", "GEN# +2.08842172"},
        {"Smithsonian Astrophysical Observation", "SAO 23240"},
        {"Wilson Evans Batten Catalogue", "WEB 2315"},
        {"New General Catalogue", "NGC 884 2172"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.46838695),
        dec: Angle.Degrees(+56.90501679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214419"},
        {"Hipparcos Number", "HIP 111633"},
        {"Geneva Identification System", "GEN# +1.00214419"},
        {"Smithsonian Astrophysical Observation", "SAO 34622"},
        {"Wilson Evans Batten Catalogue", "WEB 19954"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.22482713),
        dec: Angle.Degrees(+56.90583771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88895"},
        {"Hipparcos Number", "HIP 50347"},
        {"Smithsonian Astrophysical Observation", "SAO 27586"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.20077867),
        dec: Angle.Degrees(+56.90805322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238007"},
        {"Hipparcos Number", "HIP 56131"},
        {"Smithsonian Astrophysical Observation", "SAO 28039"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.59126559),
        dec: Angle.Degrees(+56.90816720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1264"},
        {"Hipparcos Number", "HIP 1363"},
        {"Smithsonian Astrophysical Observation", "SAO 21269"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.27038297),
        dec: Angle.Degrees(+56.90960852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238453"},
        {"Hipparcos Number", "HIP 75213"},
        {"Smithsonian Astrophysical Observation", "SAO 29501"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55055610),
        dec: Angle.Degrees(+56.90972965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187546"},
        {"Hipparcos Number", "HIP 97382"},
        {"Smithsonian Astrophysical Observation", "SAO 32001"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.87665702),
        dec: Angle.Degrees(+56.91113362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237117"},
        {"Hipparcos Number", "HIP 15448"},
        {"Smithsonian Astrophysical Observation", "SAO 23948"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.79338480),
        dec: Angle.Degrees(+56.91540157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85794",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10626 B"},
        {"Hipparcos Number", "HIP 85794"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.96394348),
        dec: Angle.Degrees(+56.91599773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239767"},
        {"Hipparcos Number", "HIP 107500"},
        {"Smithsonian Astrophysical Observation", "SAO 33744"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.59415162),
        dec: Angle.Degrees(+56.91717996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212043"},
        {"Hipparcos Number", "HIP 110266"},
        {"Celescope Catalog", "CEL 5466"},
        {"Fundamental Katalog 5th Edition", "FK5 5971"},
        {"Geneva Identification System", "GEN# +1.00212043"},
        {"Smithsonian Astrophysical Observation", "SAO 34325"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.02599045),
        dec: Angle.Degrees(+56.91800204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147160"},
        {"Hipparcos Number", "HIP 79799"},
        {"Geneva Identification System", "GEN# +1.00147160"},
        {"Smithsonian Astrophysical Observation", "SAO 29870"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.29101374),
        dec: Angle.Degrees(+56.91836328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85796",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10626 A"},
        {"Henry Draper", "HD 159540"},
        {"Hipparcos Number", "HIP 85796"},
        {"Smithsonian Astrophysical Observation", "SAO 30443"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.96735792),
        dec: Angle.Degrees(+56.91888366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4412 A"},
        {"Henry Draper", "HD 38618"},
        {"Hipparcos Number", "HIP 27592"},
        {"Geneva Identification System", "GEN# +1.00038618"},
        {"Smithsonian Astrophysical Observation", "SAO 25403"},
        {"Wilson Evans Batten Catalogue", "WEB 5417"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.64122571),
        dec: Angle.Degrees(+56.91894767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24395"},
        {"Hipparcos Number", "HIP 18383"},
        {"Fundamental Katalog 5th Edition", "FK5 4357"},
        {"Geneva Identification System", "GEN# +1.00024395"},
        {"Smithsonian Astrophysical Observation", "SAO 24298"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.94309382),
        dec: Angle.Degrees(+56.91909645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118059"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.24367084),
        dec: Angle.Degrees(+56.91920531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93075"},
        {"Hipparcos Number", "HIP 52650"},
        {"Geneva Identification System", "GEN# +1.00093075"},
        {"Renson", "Renson 26870"},
        {"Smithsonian Astrophysical Observation", "SAO 27758"},
        {"Wilson Evans Batten Catalogue", "WEB 9588"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.49941228),
        dec: Angle.Degrees(+56.92080295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213225"},
        {"Hipparcos Number", "HIP 110934"},
        {"Smithsonian Astrophysical Observation", "SAO 34492"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.14882223),
        dec: Angle.Degrees(+56.92097688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225170"},
        {"Hipparcos Number", "HIP 322"},
        {"Smithsonian Astrophysical Observation", "SAO 21048"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.03517441),
        dec: Angle.Degrees(+56.92100467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6867 AB"},
        {"Henry Draper", "HD 72183"},
        {"Hipparcos Number", "HIP 42046"},
        {"Smithsonian Astrophysical Observation", "SAO 26911"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.55145187),
        dec: Angle.Degrees(+56.92315661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40141"},
        {"Hipparcos Number", "HIP 28467"},
        {"Geneva Identification System", "GEN# +1.00040141"},
        {"Smithsonian Astrophysical Observation", "SAO 25516"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.15349341),
        dec: Angle.Degrees(+56.92329818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38129"},
        {"Hipparcos Number", "HIP 27283"},
        {"Renson", "Renson 10250"},
        {"Smithsonian Astrophysical Observation", "SAO 25364"},
        {"Wilson Evans Batten Catalogue", "WEB 5359"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.72748860),
        dec: Angle.Degrees(+56.92399304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43508"},
        {"Hipparcos Number", "HIP 30100"},
        {"Geneva Identification System", "GEN# +1.00043508"},
        {"Renson", "Renson 11550"},
        {"Smithsonian Astrophysical Observation", "SAO 25670"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.01810184),
        dec: Angle.Degrees(+56.92537709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103380",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14473 AB"},
        {"Henry Draper", "HD 199739"},
        {"Hipparcos Number", "HIP 103380"},
        {"Geneva Identification System", "GEN# +1.00199739J"},
        {"Smithsonian Astrophysical Observation", "SAO 33010"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.17000441),
        dec: Angle.Degrees(+56.92667368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76342"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.89851319),
        dec: Angle.Degrees(+56.93001890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22316"},
        {"Hipparcos Number", "HIP 16974"},
        {"Geneva Identification System", "GEN# +1.00022316"},
        {"Renson", "Renson 5620"},
        {"Smithsonian Astrophysical Observation", "SAO 24133"},
        {"Wilson Evans Batten Catalogue", "WEB 3226"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.58210319),
        dec: Angle.Degrees(+56.93279793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47930"},
        {"Hipparcos Number", "HIP 32284"},
        {"Smithsonian Astrophysical Observation", "SAO 25918"},
        {"Wilson Evans Batten Catalogue", "WEB 6508"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.10274661),
        dec: Angle.Degrees(+56.93306955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165607"},
        {"Hipparcos Number", "HIP 88437"},
        {"Smithsonian Astrophysical Observation", "SAO 30720"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.83861984),
        dec: Angle.Degrees(+56.93361715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42819"},
        {"Hipparcos Number", "HIP 29777"},
        {"Cincinnati Publication", "Ci 18 774"},
        {"Geneva Identification System", "GEN# +1.00042819"},
        {"Smithsonian Astrophysical Observation", "SAO 25638"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.05227766),
        dec: Angle.Degrees(+56.93481331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6497"},
        {"Hipparcos Number", "HIP 5240"},
        {"Fundamental Katalog 5th Edition", "FK5 2069"},
        {"Geneva Identification System", "GEN# +1.00006497"},
        {"Smithsonian Astrophysical Observation", "SAO 22015"},
        {"Wilson Evans Batten Catalogue", "WEB 1101"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.75030618),
        dec: Angle.Degrees(+56.93523628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17638"},
        {"Hipparcos Number", "HIP 13380"},
        {"Geneva Identification System", "GEN# +1.00017638"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.04858932),
        dec: Angle.Degrees(+56.93531641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127148"},
        {"Hipparcos Number", "HIP 70711"},
        {"Geneva Identification System", "GEN# +1.00127148"},
        {"Smithsonian Astrophysical Observation", "SAO 29159"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.93464188),
        dec: Angle.Degrees(+56.93683506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78865"},
        {"Hipparcos Number", "HIP 45213"},
        {"Geneva Identification System", "GEN# +1.00078865"},
        {"Smithsonian Astrophysical Observation", "SAO 27170"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.20967194),
        dec: Angle.Degrees(+56.94187917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69250"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.64726099),
        dec: Angle.Degrees(+56.94322387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6503 A"},
        {"Henry Draper", "HD 65365"},
        {"Hipparcos Number", "HIP 39230"},
        {"Smithsonian Astrophysical Observation", "SAO 26621"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.35635748),
        dec: Angle.Degrees(+56.94365142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238034"},
        {"Hipparcos Number", "HIP 57168"},
        {"Smithsonian Astrophysical Observation", "SAO 28111"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.86663221),
        dec: Angle.Degrees(+56.94517297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217476"},
        {"Hipparcos Number", "HIP 113561"},
        {"Fundamental Katalog 5th Edition", "FK5 3839"},
        {"Geneva Identification System", "GEN# +1.00217476"},
        {"Smithsonian Astrophysical Observation", "SAO 35039"},
        {"Wilson Evans Batten Catalogue", "WEB 20188"},
    },
    visualMagnitude: 5.10,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.02126622),
        dec: Angle.Degrees(+56.94538131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239691"},
        {"Hipparcos Number", "HIP 106228"},
        {"Smithsonian Astrophysical Observation", "SAO 33492"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.75242457),
        dec: Angle.Degrees(+56.94555436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236424"},
        {"Hipparcos Number", "HIP 2307"},
        {"Smithsonian Astrophysical Observation", "SAO 21434"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.35469713),
        dec: Angle.Degrees(+56.94625340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238446"},
        {"Hipparcos Number", "HIP 74916"},
        {"Smithsonian Astrophysical Observation", "SAO 29477"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.64183949),
        dec: Angle.Degrees(+56.94697404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237306"},
        {"Hipparcos Number", "HIP 21924"},
        {"Smithsonian Astrophysical Observation", "SAO 24773"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.71630158),
        dec: Angle.Degrees(+56.94940003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113253"},
        {"Hipparcos Number", "HIP 63570"},
        {"Smithsonian Astrophysical Observation", "SAO 28604"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.40888169),
        dec: Angle.Degrees(+56.94957036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239725"},
        {"Hipparcos Number", "HIP 106905"},
        {"Geneva Identification System", "GEN# +4.35370174"},
        {"Smithsonian Astrophysical Observation", "SAO 33627"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.76980311),
        dec: Angle.Degrees(+56.94984354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69660"},
        {"Hipparcos Number", "HIP 40905"},
        {"Geneva Identification System", "GEN# +1.00069660"},
        {"Smithsonian Astrophysical Observation", "SAO 26789"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.20588550),
        dec: Angle.Degrees(+56.95252758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38418"},
        {"Hipparcos Number", "HIP 27484"},
        {"Smithsonian Astrophysical Observation", "SAO 25390"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.29902048),
        dec: Angle.Degrees(+56.95474978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1986"},
        {"Hipparcos Number", "HIP 1935"},
        {"Geneva Identification System", "GEN# +1.00001986"},
        {"Smithsonian Astrophysical Observation", "SAO 21370"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.09688156),
        dec: Angle.Degrees(+56.95554576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239922"},
        {"Hipparcos Number", "HIP 110180"},
        {"Smithsonian Astrophysical Observation", "SAO 34307"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.75540912),
        dec: Angle.Degrees(+56.96315465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1993"},
        {"Hipparcos Number", "HIP 1942"},
        {"Geneva Identification System", "GEN# +1.00001993"},
        {"Smithsonian Astrophysical Observation", "SAO 21374"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.13960098),
        dec: Angle.Degrees(+56.96745234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165169"},
        {"Hipparcos Number", "HIP 88250"},
        {"Smithsonian Astrophysical Observation", "SAO 30703"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.31066295),
        dec: Angle.Degrees(+56.96760851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82861"},
        {"Hipparcos Number", "HIP 47169"},
        {"Geneva Identification System", "GEN# +1.00082861"},
        {"Renson", "Renson 23610"},
        {"Smithsonian Astrophysical Observation", "SAO 27311"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.17864700),
        dec: Angle.Degrees(+56.97013535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116956"},
        {"Hipparcos Number", "HIP 65515"},
        {"Fundamental Katalog 5th Edition", "FK5 5183"},
        {"Geneva Identification System", "GEN# +1.00116956"},
        {"Smithsonian Astrophysical Observation", "SAO 28753"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.44068669),
        dec: Angle.Degrees(+56.97046608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58680"},
        {"Hipparcos Number", "HIP 36434"},
        {"Fundamental Katalog 5th Edition", "FK5 4673"},
        {"Smithsonian Astrophysical Observation", "SAO 26367"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.46802237),
        dec: Angle.Degrees(+56.97204544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15174 A"},
        {"Henry Draper", "HD 206183"},
        {"Hipparcos Number", "HIP 106843"},
        {"Celescope Catalog", "CEL 5357"},
        {"Geneva Identification System", "GEN# +4.35370171J"},
        {"Smithsonian Astrophysical Observation", "SAO 33615"},
        {"Wilson Evans Batten Catalogue", "WEB 19313"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.60952851),
        dec: Angle.Degrees(+56.97375248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240465"},
        {"Hipparcos Number", "HIP 118252"},
        {"Smithsonian Astrophysical Observation", "SAO 35951"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.78301158),
        dec: Angle.Degrees(+56.97443904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44061"},
        {"Hipparcos Number", "HIP 30357"},
        {"Smithsonian Astrophysical Observation", "SAO 25693"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.77654113),
        dec: Angle.Degrees(+56.97652534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109202"},
        {"Hipparcos Number", "HIP 61203"},
        {"Fundamental Katalog 5th Edition", "FK5 5105"},
        {"Smithsonian Astrophysical Observation", "SAO 28422"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.12727148),
        dec: Angle.Degrees(+56.97663504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236892"},
        {"Hipparcos Number", "HIP 8601"},
        {"Geneva Identification System", "GEN# +1.00236892"},
        {"Smithsonian Astrophysical Observation", "SAO 22673"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.74461946),
        dec: Angle.Degrees(+56.97709542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238103"},
        {"Hipparcos Number", "HIP 60255"},
        {"Smithsonian Astrophysical Observation", "SAO 28348"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.33236865),
        dec: Angle.Degrees(+56.97891792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58983",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8415 AB"},
        {"Henry Draper", "HD 238069"},
        {"Hipparcos Number", "HIP 58983"},
        {"Smithsonian Astrophysical Observation", "SAO 28243"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.39801131),
        dec: Angle.Degrees(+56.97901213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237008"},
        {"Hipparcos Number", "HIP 13262"},
        {"Smithsonian Astrophysical Observation", "SAO 23647"},
    },
    visualMagnitude: 8.91,
    bvColour: 2.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.65788480),
        dec: Angle.Degrees(+56.98341590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185414"},
        {"Hipparcos Number", "HIP 96395"},
        {"Geneva Identification System", "GEN# +1.00185414"},
        {"Smithsonian Astrophysical Observation", "SAO 31813"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.98172144),
        dec: Angle.Degrees(+56.98438763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57202"},
        {"Hipparcos Number", "HIP 35844"},
        {"Geneva Identification System", "GEN# +1.00057202"},
        {"Smithsonian Astrophysical Observation", "SAO 26316"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.86820893),
        dec: Angle.Degrees(+56.98544680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13051"},
        {"Hipparcos Number", "HIP 10055"},
        {"Celescope Catalog", "CEL 211"},
        {"Geneva Identification System", "GEN# +1.00013051"},
        {"Smithsonian Astrophysical Observation", "SAO 22971"},
        {"Wilson Evans Batten Catalogue", "WEB 2105"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.35706769),
        dec: Angle.Degrees(+56.99171202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236912"},
        {"Hipparcos Number", "HIP 9048"},
        {"Smithsonian Astrophysical Observation", "SAO 22768"},
        {"Wilson Evans Batten Catalogue", "WEB 1899"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.14105432),
        dec: Angle.Degrees(+56.99190632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8045 AB"},
        {"Henry Draper", "HD 95917"},
        {"Hipparcos Number", "HIP 54162"},
        {"Smithsonian Astrophysical Observation", "SAO 27892"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.19443710),
        dec: Angle.Degrees(+56.99229199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14032",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2249"},
        {"Aitken 2", "ADS 2249 AB"},
        {"Henry Draper", "HD 18481"},
        {"Hipparcos Number", "HIP 14032"},
        {"Geneva Identification System", "GEN# +1.00018481"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.17473830),
        dec: Angle.Degrees(+56.99522110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238024"},
        {"Hipparcos Number", "HIP 56653"},
        {"Smithsonian Astrophysical Observation", "SAO 28073"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.24852586),
        dec: Angle.Degrees(+56.99565197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222263"},
        {"Hipparcos Number", "HIP 116683"},
        {"Smithsonian Astrophysical Observation", "SAO 35634"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.69268313),
        dec: Angle.Degrees(+56.99718333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39860"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.14243055),
        dec: Angle.Degrees(+56.99772955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110570"},
        {"Hipparcos Number", "HIP 62008"},
        {"Smithsonian Astrophysical Observation", "SAO 28484"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.63170249),
        dec: Angle.Degrees(+56.99886326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158013"},
        {"Hipparcos Number", "HIP 85086"},
        {"Geneva Identification System", "GEN# +1.00158013"},
        {"Renson", "Renson 44416"},
        {"Smithsonian Astrophysical Observation", "SAO 30366"},
        {"Wilson Evans Batten Catalogue", "WEB 14367"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.84442729),
        dec: Angle.Degrees(+57.01168468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217127"},
        {"Hipparcos Number", "HIP 113353"},
        {"Smithsonian Astrophysical Observation", "SAO 34998"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.35601638),
        dec: Angle.Degrees(+57.01292006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19256"},
        {"Hipparcos Number", "HIP 14592"},
        {"Geneva Identification System", "GEN# +1.00019256"},
        {"Smithsonian Astrophysical Observation", "SAO 23829"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.10679318),
        dec: Angle.Degrees(+57.01318092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5136"},
        {"Hipparcos Number", "HIP 4237"},
        {"Geneva Identification System", "GEN# +1.00005136"},
        {"Smithsonian Astrophysical Observation", "SAO 21820"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.52086539),
        dec: Angle.Degrees(+57.01412864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181824"},
        {"Hipparcos Number", "HIP 94901"},
        {"Geneva Identification System", "GEN# +1.00181824"},
        {"Smithsonian Astrophysical Observation", "SAO 31567"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.67844221),
        dec: Angle.Degrees(+57.01436985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95264",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12401 A"},
        {"Henry Draper", "HD 182734"},
        {"Hipparcos Number", "HIP 95264"},
        {"Smithsonian Astrophysical Observation", "SAO 31619"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.72740939),
        dec: Angle.Degrees(+57.01661750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239742"},
        {"Hipparcos Number", "HIP 107209"},
        {"Geneva Identification System", "GEN# +4.35370204"},
        {"Smithsonian Astrophysical Observation", "SAO 33685"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.71710255),
        dec: Angle.Degrees(+57.01696534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63534"},
        {"Hipparcos Number", "HIP 38437"},
        {"Smithsonian Astrophysical Observation", "SAO 26541"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.11752509),
        dec: Angle.Degrees(+57.01765127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238208"},
        {"Hipparcos Number", "HIP 64626"},
        {"Geneva Identification System", "GEN# +1.00238208"},
        {"Smithsonian Astrophysical Observation", "SAO 28687"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.69441301),
        dec: Angle.Degrees(+57.01792602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40568"},
        {"Hipparcos Number", "HIP 28656"},
        {"Fundamental Katalog 5th Edition", "FK5 4551"},
        {"Geneva Identification System", "GEN# +1.00040568"},
        {"Smithsonian Astrophysical Observation", "SAO 25530"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.76794164),
        dec: Angle.Degrees(+57.01842488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23510"},
        {"Hipparcos Number", "HIP 17809"},
        {"Geneva Identification System", "GEN# +1.00023510"},
        {"Smithsonian Astrophysical Observation", "SAO 24233"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16798899),
        dec: Angle.Degrees(+57.02082784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45898"},
        {"Hipparcos Number", "HIP 31274"},
        {"Smithsonian Astrophysical Observation", "SAO 25804"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.37987861),
        dec: Angle.Degrees(+57.02289013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239745"},
        {"Hipparcos Number", "HIP 107250"},
        {"Celescope Catalog", "CEL 5374"},
        {"Geneva Identification System", "GEN# +4.35370207"},
        {"Smithsonian Astrophysical Observation", "SAO 33691"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.85194286),
        dec: Angle.Degrees(+57.02316750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113983"},
        {"Hipparcos Number", "HIP 63956"},
        {"Geneva Identification System", "GEN# +1.00113983"},
        {"Smithsonian Astrophysical Observation", "SAO 28635"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.60374193),
        dec: Angle.Degrees(+57.02527474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4761 A"},
        {"Henry Draper", "HD 41963"},
        {"Hipparcos Number", "HIP 29377"},
        {"Geneva Identification System", "GEN# +1.00041963"},
        {"Smithsonian Astrophysical Observation", "SAO 25611"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88144173),
        dec: Angle.Degrees(+57.02565969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29372",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4761 B"},
        {"Hipparcos Number", "HIP 29372"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.87014779),
        dec: Angle.Degrees(+57.02566402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146735"},
        {"Hipparcos Number", "HIP 79613"},
        {"Geneva Identification System", "GEN# +1.00146735"},
        {"Smithsonian Astrophysical Observation", "SAO 29854"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.68585998),
        dec: Angle.Degrees(+57.02638478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13841"},
        {"Hipparcos Number", "HIP 10624"},
        {"Geneva Identification System", "GEN# +2.08690003"},
        {"Smithsonian Astrophysical Observation", "SAO 23113"},
        {"Wilson Evans Batten Catalogue", "WEB 2235"},
        {"New General Catalogue", "NGC 869 3"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.19329793),
        dec: Angle.Degrees(+57.02935498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2559"},
        {"Hipparcos Number", "HIP 2329"},
        {"Geneva Identification System", "GEN# +1.00002559"},
        {"Smithsonian Astrophysical Observation", "SAO 21441"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.44935650),
        dec: Angle.Degrees(+57.03071802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59774",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Megrez"},
        {"Henry Draper", "HD 106591"},
        {"Hipparcos Number", "HIP 59774"},
        {"Celescope Catalog", "CEL 4078"},
        {"Fundamental Katalog 5th Edition", "FK5 456"},
        {"Geneva Identification System", "GEN# +1.00106591"},
        {"Smithsonian Astrophysical Observation", "SAO 28315"},
        {"Wilson Evans Batten Catalogue", "WEB 10621"},
    },
    visualMagnitude: 3.32,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.85603795),
        dec: Angle.Degrees(+57.03259792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17346"},
        {"Hipparcos Number", "HIP 13160"},
        {"Geneva Identification System", "GEN# +1.00017346"},
        {"Smithsonian Astrophysical Observation", "SAO 23632"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.30958114),
        dec: Angle.Degrees(+57.03327608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12994"},
        {"Hipparcos Number", "HIP 10021"},
        {"Celescope Catalog", "CEL 209"},
        {"Geneva Identification System", "GEN# +1.00012994"},
        {"Smithsonian Astrophysical Observation", "SAO 22967"},
        {"Wilson Evans Batten Catalogue", "WEB 2100"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.25850291),
        dec: Angle.Degrees(+57.03598453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236802"},
        {"Hipparcos Number", "HIP 7524"},
        {"Smithsonian Astrophysical Observation", "SAO 22432"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.21395101),
        dec: Angle.Degrees(+57.03699153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238893"},
        {"Hipparcos Number", "HIP 90783"},
        {"Smithsonian Astrophysical Observation", "SAO 31026"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82172874),
        dec: Angle.Degrees(+57.04073780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186815"},
        {"Hipparcos Number", "HIP 97070"},
        {"Geneva Identification System", "GEN# +1.00186815"},
        {"Smithsonian Astrophysical Observation", "SAO 31933"},
        {"Wilson Evans Batten Catalogue", "WEB 17039"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.91455272),
        dec: Angle.Degrees(+57.04265606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211336"},
        {"Hipparcos Number", "HIP 109857"},
        {"Celescope Catalog", "CEL 5458"},
        {"Cincinnati Publication", "Ci 20 1349"},
        {"Geneva Identification System", "GEN# +1.00211336"},
        {"Renson", "Renson 58660"},
        {"Smithsonian Astrophysical Observation", "SAO 34227"},
        {"Wilson Evans Batten Catalogue", "WEB 19727"},
    },
    visualMagnitude: 4.18,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.75699582),
        dec: Angle.Degrees(+57.04346522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 476.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132423"},
        {"Hipparcos Number", "HIP 73126"},
        {"Smithsonian Astrophysical Observation", "SAO 29347"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.18204915),
        dec: Angle.Degrees(+57.04462035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171635"},
        {"Hipparcos Number", "HIP 90905"},
        {"Fundamental Katalog 5th Edition", "FK5 3475"},
        {"Geneva Identification System", "GEN# +1.00171635"},
        {"Smithsonian Astrophysical Observation", "SAO 31039"},
        {"Wilson Evans Batten Catalogue", "WEB 15592"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.14384287),
        dec: Angle.Degrees(+57.04561627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39166"},
        {"Hipparcos Number", "HIP 27885"},
        {"Geneva Identification System", "GEN# +1.00039166"},
        {"Smithsonian Astrophysical Observation", "SAO 25439"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.51438656),
        dec: Angle.Degrees(+57.04562354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236979"},
        {"Hipparcos Number", "HIP 12302"},
        {"Geneva Identification System", "GEN# +0.05600673"},
        {"Smithsonian Astrophysical Observation", "SAO 23484"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.60591715),
        dec: Angle.Degrees(+57.04616817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9826",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1648 A"},
        {"Henry Draper", "HD 12727"},
        {"Hipparcos Number", "HIP 9826"},
        {"Celescope Catalog", "CEL 200"},
        {"Geneva Identification System", "GEN# +1.00012727"},
        {"Smithsonian Astrophysical Observation", "SAO 22920"},
        {"Wilson Evans Batten Catalogue", "WEB 2064"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.62189821),
        dec: Angle.Degrees(+57.04627328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239251"},
        {"Hipparcos Number", "HIP 97920"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.50329398),
        dec: Angle.Degrees(+57.04765755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96232"},
        {"Hipparcos Number", "HIP 54312"},
        {"Geneva Identification System", "GEN# +1.00096232"},
        {"Smithsonian Astrophysical Observation", "SAO 27906"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.66308240),
        dec: Angle.Degrees(+57.05139767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238432"},
        {"Hipparcos Number", "HIP 74472"},
        {"Smithsonian Astrophysical Observation", "SAO 29447"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.26396576),
        dec: Angle.Degrees(+57.05158984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106002"},
        {"Hipparcos Number", "HIP 59458"},
        {"Smithsonian Astrophysical Observation", "SAO 28291"},
        {"Wilson Evans Batten Catalogue", "WEB 10570"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.93706229),
        dec: Angle.Degrees(+57.05444463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13854"},
        {"Hipparcos Number", "HIP 10633"},
        {"Celescope Catalog", "CEL 238"},
        {"Geneva Identification System", "GEN# +2.08690016"},
        {"Smithsonian Astrophysical Observation", "SAO 23115"},
        {"Wilson Evans Batten Catalogue", "WEB 2237"},
        {"New General Catalogue", "NGC 869 16"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.21548842),
        dec: Angle.Degrees(+57.05524766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87604"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.43732086),
        dec: Angle.Degrees(+57.05591486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239510"},
        {"Hipparcos Number", "HIP 102943"},
        {"Smithsonian Astrophysical Observation", "SAO 32944"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.85050346),
        dec: Angle.Degrees(+57.06200454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237688"},
        {"Hipparcos Number", "HIP 40510"},
        {"Smithsonian Astrophysical Observation", "SAO 26744"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.06276868),
        dec: Angle.Degrees(+57.06491559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2665"},
        {"Hipparcos Number", "HIP 2413"},
        {"Geneva Identification System", "GEN# +1.00002665"},
        {"Smithsonian Astrophysical Observation", "SAO 21465"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.68917654),
        dec: Angle.Degrees(+57.06505408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128332"},
        {"Hipparcos Number", "HIP 71251"},
        {"Fundamental Katalog 5th Edition", "FK5 3154"},
        {"Geneva Identification System", "GEN# +1.00128332"},
        {"Smithsonian Astrophysical Observation", "SAO 29202"},
        {"Wilson Evans Batten Catalogue", "WEB 12312"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.56542001),
        dec: Angle.Degrees(+57.06582344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237271"},
        {"Hipparcos Number", "HIP 20996"},
        {"Smithsonian Astrophysical Observation", "SAO 24650"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.53762742),
        dec: Angle.Degrees(+57.06817917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14900"},
        {"Hipparcos Number", "HIP 11361"},
        {"Smithsonian Astrophysical Observation", "SAO 23325"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.56769977),
        dec: Angle.Degrees(+57.06860298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14574 AB"},
        {"Henry Draper", "HD 200575"},
        {"Hipparcos Number", "HIP 103792"},
        {"Celescope Catalog", "CEL 5233"},
        {"Fundamental Katalog 5th Edition", "FK5 5854"},
        {"Geneva Identification System", "GEN# +1.00200575J"},
        {"Smithsonian Astrophysical Observation", "SAO 33075"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.47921055),
        dec: Angle.Degrees(+57.07185586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24067",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3725 AB"},
        {"Henry Draper", "HD 32973"},
        {"Hipparcos Number", "HIP 24067"},
        {"Smithsonian Astrophysical Observation", "SAO 25057"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.57432707),
        dec: Angle.Degrees(+57.07225068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240224"},
        {"Hipparcos Number", "HIP 114566"},
        {"Smithsonian Astrophysical Observation", "SAO 35230"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.10676648),
        dec: Angle.Degrees(+57.07357389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98673"},
        {"Hipparcos Number", "HIP 55485"},
        {"Fundamental Katalog 5th Edition", "FK5 2907"},
        {"Geneva Identification System", "GEN# +1.00098673"},
        {"Smithsonian Astrophysical Observation", "SAO 27999"},
        {"Wilson Evans Batten Catalogue", "WEB 9979"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.45563074),
        dec: Angle.Degrees(+57.07484314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4647"},
        {"Hipparcos Number", "HIP 3833"},
        {"Geneva Identification System", "GEN# +1.00004647"},
        {"Smithsonian Astrophysical Observation", "SAO 21738"},
        {"Wilson Evans Batten Catalogue", "WEB 682"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.30780333),
        dec: Angle.Degrees(+57.07503538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91480"},
        {"Hipparcos Number", "HIP 51814"},
        {"Fundamental Katalog 5th Edition", "FK5 398"},
        {"Geneva Identification System", "GEN# +1.00091480"},
        {"Smithsonian Astrophysical Observation", "SAO 27695"},
        {"Wilson Evans Batten Catalogue", "WEB 9441"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.79009325),
        dec: Angle.Degrees(+57.08254651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61106"},
        {"Hipparcos Number", "HIP 37406"},
        {"Fundamental Katalog 5th Edition", "FK5 2593"},
        {"Geneva Identification System", "GEN# +1.00061106"},
        {"Smithsonian Astrophysical Observation", "SAO 26459"},
        {"Wilson Evans Batten Catalogue", "WEB 7400"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.20649105),
        dec: Angle.Degrees(+57.08287527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17378"},
        {"Hipparcos Number", "HIP 13178"},
        {"Geneva Identification System", "GEN# +1.00017378"},
        {"Smithsonian Astrophysical Observation", "SAO 23637"},
        {"Wilson Evans Batten Catalogue", "WEB 2649"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.37807146),
        dec: Angle.Degrees(+57.08432152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190625"},
        {"Hipparcos Number", "HIP 98712"},
        {"Smithsonian Astrophysical Observation", "SAO 32238"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.74194557),
        dec: Angle.Degrees(+57.08456608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240442"},
        {"Hipparcos Number", "HIP 117923"},
        {"Geneva Identification System", "GEN# +1.00240442"},
        {"Smithsonian Astrophysical Observation", "SAO 35888"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.77348031),
        dec: Angle.Degrees(+57.08521640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12530"},
        {"Hipparcos Number", "HIP 9695"},
        {"Celescope Catalog", "CEL 194"},
        {"Geneva Identification System", "GEN# +1.00012530"},
        {"Smithsonian Astrophysical Observation", "SAO 22900"},
        {"Wilson Evans Batten Catalogue", "WEB 2037"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.17397849),
        dec: Angle.Degrees(+57.08803643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173977"},
        {"Hipparcos Number", "HIP 91983"},
        {"Smithsonian Astrophysical Observation", "SAO 31153"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.22137732),
        dec: Angle.Degrees(+57.08808508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10587"},
        {"Hipparcos Number", "HIP 8148"},
        {"Geneva Identification System", "GEN# +1.00010587"},
        {"Smithsonian Astrophysical Observation", "SAO 22578"},
        {"Wilson Evans Batten Catalogue", "WEB 1740"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.19229561),
        dec: Angle.Degrees(+57.08922153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115442"},
        {"Hipparcos Number", "HIP 64740"},
        {"Geneva Identification System", "GEN# +1.00115442"},
        {"Smithsonian Astrophysical Observation", "SAO 28698"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.03152369),
        dec: Angle.Degrees(+57.09089443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25914"},
        {"Hipparcos Number", "HIP 19404"},
        {"Geneva Identification System", "GEN# +1.00025914"},
        {"Smithsonian Astrophysical Observation", "SAO 24438"},
        {"Wilson Evans Batten Catalogue", "WEB 3726"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34685196),
        dec: Angle.Degrees(+57.09118055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240280"},
        {"Hipparcos Number", "HIP 115482"},
        {"Smithsonian Astrophysical Observation", "SAO 35377"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.89904284),
        dec: Angle.Degrees(+57.09169681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11577"},
        {"Hipparcos Number", "HIP 8950"},
        {"Geneva Identification System", "GEN# +1.00011577"},
        {"Smithsonian Astrophysical Observation", "SAO 22749"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.82295714),
        dec: Angle.Degrees(+57.09214655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68638"},
        {"Hipparcos Number", "HIP 40497"},
        {"Cincinnati Publication", "Ci 20 465"},
        {"Geneva Identification System", "GEN# +1.00068638"},
        {"Smithsonian Astrophysical Observation", "SAO 26742"},
        {"Wilson Evans Batten Catalogue", "WEB 7882"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.02774101),
        dec: Angle.Degrees(+57.09467911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -316.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3040"},
        {"Hipparcos Number", "HIP 2690"},
        {"Smithsonian Astrophysical Observation", "SAO 21526"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.53776953),
        dec: Angle.Degrees(+57.09884035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187545"},
        {"Hipparcos Number", "HIP 97375"},
        {"Smithsonian Astrophysical Observation", "SAO 31999"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86456383),
        dec: Angle.Degrees(+57.10003071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91971"},
        {"Hipparcos Number", "HIP 52072"},
        {"Geneva Identification System", "GEN# +1.00091971"},
        {"Smithsonian Astrophysical Observation", "SAO 27720"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.61249411),
        dec: Angle.Degrees(+57.10388898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217673"},
        {"Hipparcos Number", "HIP 113684"},
        {"Geneva Identification System", "GEN# +1.00217673"},
        {"Smithsonian Astrophysical Observation", "SAO 35062"},
        {"Wilson Evans Batten Catalogue", "WEB 20201"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.37799709),
        dec: Angle.Degrees(+57.10547492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12856"},
        {"Hipparcos Number", "HIP 9935"},
        {"Celescope Catalog", "CEL 203"},
        {"Geneva Identification System", "GEN# +1.00012856"},
        {"Smithsonian Astrophysical Observation", "SAO 22951"},
        {"Wilson Evans Batten Catalogue", "WEB 2083"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.97258556),
        dec: Angle.Degrees(+57.10568839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112394"},
        {"Hipparcos Number", "HIP 63091"},
        {"Geneva Identification System", "GEN# +1.00112394"},
        {"Smithsonian Astrophysical Observation", "SAO 28566"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.90422373),
        dec: Angle.Degrees(+57.10675709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48257"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.56591431),
        dec: Angle.Degrees(+57.10974739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158933"},
        {"Hipparcos Number", "HIP 85513"},
        {"Geneva Identification System", "GEN# +1.00158933"},
        {"Smithsonian Astrophysical Observation", "SAO 30409"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.13020883),
        dec: Angle.Degrees(+57.11036982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29091"},
        {"Hipparcos Number", "HIP 21581"},
        {"Geneva Identification System", "GEN# +1.00029091"},
        {"Smithsonian Astrophysical Observation", "SAO 24727"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.51459182),
        dec: Angle.Degrees(+57.11066126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134788"},
        {"Hipparcos Number", "HIP 74176"},
        {"Geneva Identification System", "GEN# +1.00134788"},
        {"Smithsonian Astrophysical Observation", "SAO 29427"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.34309550),
        dec: Angle.Degrees(+57.11237275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237782"},
        {"Hipparcos Number", "HIP 44877"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.15481138),
        dec: Angle.Degrees(+57.11289834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154255"},
        {"Hipparcos Number", "HIP 83265"},
        {"Geneva Identification System", "GEN# +1.00154255"},
        {"Smithsonian Astrophysical Observation", "SAO 30203"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.27505438),
        dec: Angle.Degrees(+57.11375102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197770"},
        {"Hipparcos Number", "HIP 102258"},
        {"Celescope Catalog", "CEL 5155"},
        {"Geneva Identification System", "GEN# +1.00197770"},
        {"Smithsonian Astrophysical Observation", "SAO 32832"},
        {"Wilson Evans Batten Catalogue", "WEB 18504"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.80702339),
        dec: Angle.Degrees(+57.11400468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127183"},
        {"Hipparcos Number", "HIP 70743"},
        {"Geneva Identification System", "GEN# +1.00127183"},
        {"Smithsonian Astrophysical Observation", "SAO 29161"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.00158531),
        dec: Angle.Degrees(+57.11416166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51547"},
        {"Geneva Identification System", "GEN# +0.05701274"},
        {"Wilson Evans Batten Catalogue", "WEB 9403"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.93040109),
        dec: Angle.Degrees(+57.11544323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 172.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174018"},
        {"Hipparcos Number", "HIP 92003"},
        {"Smithsonian Astrophysical Observation", "SAO 31154"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.28716106),
        dec: Angle.Degrees(+57.11570112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6238"},
        {"Hipparcos Number", "HIP 5013"},
        {"Smithsonian Astrophysical Observation", "SAO 21971"},
        {"Wilson Evans Batten Catalogue", "WEB 1024"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.06485717),
        dec: Angle.Degrees(+57.11674377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1371 AB"},
        {"Henry Draper", "HD 236857"},
        {"Hipparcos Number", "HIP 8166"},
        {"Geneva Identification System", "GEN# +1.00236857J"},
        {"Smithsonian Astrophysical Observation", "SAO 22585"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.25296897),
        dec: Angle.Degrees(+57.11675966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103810"},
        {"Hipparcos Number", "HIP 58302"},
        {"Smithsonian Astrophysical Observation", "SAO 28200"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.33989344),
        dec: Angle.Degrees(+57.11679553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23594"},
        {"Hipparcos Number", "HIP 17858"},
        {"Geneva Identification System", "GEN# +1.00023594"},
        {"Smithsonian Astrophysical Observation", "SAO 24244"},
        {"Wilson Evans Batten Catalogue", "WEB 3431"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.33218998),
        dec: Angle.Degrees(+57.11832721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239292"},
        {"Hipparcos Number", "HIP 98645"},
        {"Geneva Identification System", "GEN# +1.00239292"},
        {"Smithsonian Astrophysical Observation", "SAO 32223"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.55233195),
        dec: Angle.Degrees(+57.11979319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 223.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109767"},
        {"Geneva Identification System", "GEN# +0.05602737"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.50407305),
        dec: Angle.Degrees(+57.11997945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23603"},
        {"Hipparcos Number", "HIP 17872"},
        {"Smithsonian Astrophysical Observation", "SAO 24245"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.36116560),
        dec: Angle.Degrees(+57.12224319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238987"},
        {"Hipparcos Number", "HIP 93727"},
        {"Smithsonian Astrophysical Observation", "SAO 31377"},
        {"Wilson Evans Batten Catalogue", "WEB 16291"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.26404911),
        dec: Angle.Degrees(+57.12552301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209991"},
        {"Hipparcos Number", "HIP 109065"},
        {"Geneva Identification System", "GEN# +1.00209991"},
        {"Smithsonian Astrophysical Observation", "SAO 34046"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.41487015),
        dec: Angle.Degrees(+57.12638576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236614"},
        {"Hipparcos Number", "HIP 5044"},
        {"Smithsonian Astrophysical Observation", "SAO 21983"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.14418280),
        dec: Angle.Degrees(+57.12678214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237215"},
        {"Hipparcos Number", "HIP 19105"},
        {"Smithsonian Astrophysical Observation", "SAO 24400"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.42647637),
        dec: Angle.Degrees(+57.12696318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84335"},
        {"Hipparcos Number", "HIP 47965"},
        {"Geneva Identification System", "GEN# +1.00084335"},
        {"Smithsonian Astrophysical Observation", "SAO 27377"},
        {"Wilson Evans Batten Catalogue", "WEB 8972"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.63193397),
        dec: Angle.Degrees(+57.12798971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31757"},
        {"Hipparcos Number", "HIP 23403"},
        {"Geneva Identification System", "GEN# +1.00031757"},
        {"Smithsonian Astrophysical Observation", "SAO 24957"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.44358308),
        dec: Angle.Degrees(+57.13341886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100082"},
        {"Hipparcos Number", "HIP 56216"},
        {"Smithsonian Astrophysical Observation", "SAO 28044"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.86390756),
        dec: Angle.Degrees(+57.13487250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14134"},
        {"Hipparcos Number", "HIP 10805"},
        {"Celescope Catalog", "CEL 250"},
        {"Geneva Identification System", "GEN# +2.08691057"},
        {"Smithsonian Astrophysical Observation", "SAO 23178"},
        {"Wilson Evans Batten Catalogue", "WEB 2275"},
        {"New General Catalogue", "NGC 869 1057"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.76855593),
        dec: Angle.Degrees(+57.13550187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224425"},
        {"Hipparcos Number", "HIP 118135"},
        {"Celescope Catalog", "CEL 5726"},
        {"Geneva Identification System", "GEN# +1.00224425"},
        {"Smithsonian Astrophysical Observation", "SAO 35927"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44680823),
        dec: Angle.Degrees(+57.13974729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215606"},
        {"Hipparcos Number", "HIP 112343"},
        {"Geneva Identification System", "GEN# +1.00215606"},
        {"Renson", "Renson 59550"},
        {"Smithsonian Astrophysical Observation", "SAO 34768"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.33101266),
        dec: Angle.Degrees(+57.14038498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15192",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2424 A"},
        {"Henry Draper", "HD 20041"},
        {"Hipparcos Number", "HIP 15192"},
        {"Geneva Identification System", "GEN# +1.00020041"},
        {"Smithsonian Astrophysical Observation", "SAO 23903"},
        {"Wilson Evans Batten Catalogue", "WEB 2922"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.94988581),
        dec: Angle.Degrees(+57.14062522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142393"},
        {"Hipparcos Number", "HIP 77674"},
        {"Smithsonian Astrophysical Observation", "SAO 29695"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.86834006),
        dec: Angle.Degrees(+57.14227733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238628"},
        {"Hipparcos Number", "HIP 82939"},
        {"Smithsonian Astrophysical Observation", "SAO 30173"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.23415893),
        dec: Angle.Degrees(+57.14229424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26102"},
        {"Hipparcos Number", "HIP 19522"},
        {"Smithsonian Astrophysical Observation", "SAO 24455"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.73834253),
        dec: Angle.Degrees(+57.14421096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49470"},
        {"Hipparcos Number", "HIP 32967"},
        {"Geneva Identification System", "GEN# +1.00049470"},
        {"Smithsonian Astrophysical Observation", "SAO 25999"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.99992660),
        dec: Angle.Degrees(+57.14905615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238222"},
        {"Hipparcos Number", "HIP 65228"},
        {"Geneva Identification System", "GEN# +1.00238222"},
        {"Smithsonian Astrophysical Observation", "SAO 28727"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.51166198),
        dec: Angle.Degrees(+57.15697242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7433"},
        {"Hipparcos Number", "HIP 5887"},
        {"Smithsonian Astrophysical Observation", "SAO 22131"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.90073646),
        dec: Angle.Degrees(+57.15811699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223569"},
        {"Hipparcos Number", "HIP 117554"},
        {"Celescope Catalog", "CEL 5689"},
        {"Smithsonian Astrophysical Observation", "SAO 35824"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.60377590),
        dec: Angle.Degrees(+57.16106660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11714"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.80053621),
        dec: Angle.Degrees(+57.16302420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 584"},
        {"Hipparcos Number", "HIP 857"},
        {"Geneva Identification System", "GEN# +1.00000584"},
        {"Smithsonian Astrophysical Observation", "SAO 21162"},
        {"Wilson Evans Batten Catalogue", "WEB 143"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.62358027),
        dec: Angle.Degrees(+57.16549747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237636"},
        {"Hipparcos Number", "HIP 38086"},
        {"Smithsonian Astrophysical Observation", "SAO 26510"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.08084202),
        dec: Angle.Degrees(+57.16614845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238468"},
        {"Hipparcos Number", "HIP 76016"},
        {"Smithsonian Astrophysical Observation", "SAO 29559"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.89097871),
        dec: Angle.Degrees(+57.16663416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127412"},
        {"Hipparcos Number", "HIP 70842"},
        {"Smithsonian Astrophysical Observation", "SAO 29170"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.30247902),
        dec: Angle.Degrees(+57.16699527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238405"},
        {"Hipparcos Number", "HIP 72914"},
        {"Geneva Identification System", "GEN# +1.00238405"},
        {"Smithsonian Astrophysical Observation", "SAO 29330"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52933868),
        dec: Angle.Degrees(+57.16717818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219134"},
        {"Hipparcos Number", "HIP 114622"},
        {"Cincinnati Publication", "Ci 20 1406"},
        {"Fundamental Katalog 5th Edition", "FK5 875"},
        {"Geneva Identification System", "GEN# +1.00219134"},
        {"Smithsonian Astrophysical Observation", "SAO 35236"},
        {"Wilson Evans Batten Catalogue", "WEB 20333"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31143134),
        dec: Angle.Degrees(+57.16763844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2074.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 294.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10816",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1766 A"},
        {"Henry Draper", "HD 14143"},
        {"Hipparcos Number", "HIP 10816"},
        {"Geneva Identification System", "GEN# +2.08691162"},
        {"Smithsonian Astrophysical Observation", "SAO 23182"},
        {"Wilson Evans Batten Catalogue", "WEB 2277"},
        {"New General Catalogue", "NGC 869 1162"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.80809533),
        dec: Angle.Degrees(+57.16923543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48432"},
        {"Hipparcos Number", "HIP 32489"},
        {"Fundamental Katalog 5th Edition", "FK5 2520"},
        {"Geneva Identification System", "GEN# +1.00048432"},
        {"Smithsonian Astrophysical Observation", "SAO 25947"},
        {"Wilson Evans Batten Catalogue", "WEB 6551"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.70622699),
        dec: Angle.Degrees(+57.16927050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3777"},
        {"Hipparcos Number", "HIP 3227"},
        {"Geneva Identification System", "GEN# +1.00003777"},
        {"Renson", "Renson 1020"},
        {"Smithsonian Astrophysical Observation", "SAO 21617"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.27245169),
        dec: Angle.Degrees(+57.17155492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26792"},
        {"Hipparcos Number", "HIP 20004"},
        {"Renson", "Renson 6840"},
        {"Smithsonian Astrophysical Observation", "SAO 24516"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33789919),
        dec: Angle.Degrees(+57.17828570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218573"},
        {"Hipparcos Number", "HIP 114259"},
        {"Geneva Identification System", "GEN# +1.00218573"},
        {"Smithsonian Astrophysical Observation", "SAO 35164"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.09833767),
        dec: Angle.Degrees(+57.17976537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184239"},
        {"Hipparcos Number", "HIP 95911"},
        {"Smithsonian Astrophysical Observation", "SAO 31717"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.57914591),
        dec: Angle.Degrees(+57.18032899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125960"},
        {"Hipparcos Number", "HIP 70105"},
        {"Geneva Identification System", "GEN# +1.00125960"},
        {"Smithsonian Astrophysical Observation", "SAO 29112"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.17857262),
        dec: Angle.Degrees(+57.18133522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236658"},
        {"Hipparcos Number", "HIP 5680"},
        {"Smithsonian Astrophysical Observation", "SAO 22095"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.24927094),
        dec: Angle.Degrees(+57.18243356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2907"},
        {"Hipparcos Number", "HIP 2591"},
        {"Geneva Identification System", "GEN# +1.00002907"},
        {"Renson", "Renson 730"},
        {"Smithsonian Astrophysical Observation", "SAO 21507"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.22237599),
        dec: Angle.Degrees(+57.18487832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151085"},
        {"Hipparcos Number", "HIP 81761"},
        {"Geneva Identification System", "GEN# +1.00151085"},
        {"Smithsonian Astrophysical Observation", "SAO 30054"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.50364894),
        dec: Angle.Degrees(+57.18488326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10320"},
        {"Hipparcos Number", "HIP 7964"},
        {"Renson", "Renson 2580"},
        {"Smithsonian Astrophysical Observation", "SAO 22525"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.58115573),
        dec: Angle.Degrees(+57.18533972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82910",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10276 AB"},
        {"Henry Draper", "HD 153495"},
        {"Hipparcos Number", "HIP 82910"},
        {"Geneva Identification System", "GEN# +1.00153495"},
        {"Smithsonian Astrophysical Observation", "SAO 30169"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.14577395),
        dec: Angle.Degrees(+57.18810913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238433"},
        {"Hipparcos Number", "HIP 74517"},
        {"Smithsonian Astrophysical Observation", "SAO 29451"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.40821603),
        dec: Angle.Degrees(+57.19153224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46702"},
        {"Hipparcos Number", "HIP 31731"},
        {"Geneva Identification System", "GEN# +1.00046702"},
        {"Smithsonian Astrophysical Observation", "SAO 25849"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.58331755),
        dec: Angle.Degrees(+57.19175249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237711"},
        {"Hipparcos Number", "HIP 41511"},
        {"Smithsonian Astrophysical Observation", "SAO 26846"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.98583158),
        dec: Angle.Degrees(+57.19316777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240165"},
        {"Hipparcos Number", "HIP 113753"},
        {"Geneva Identification System", "GEN# +1.00240165"},
        {"Smithsonian Astrophysical Observation", "SAO 35079"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.55148202),
        dec: Angle.Degrees(+57.19386226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7141"},
        {"Smithsonian Astrophysical Observation", "SAO 22361"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.00692980),
        dec: Angle.Degrees(+57.19464772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8397"},
        {"Hipparcos Number", "HIP 6571"},
        {"Smithsonian Astrophysical Observation", "SAO 22244"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.10522440),
        dec: Angle.Degrees(+57.19824302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92728"},
        {"Hipparcos Number", "HIP 52478"},
        {"Geneva Identification System", "GEN# +1.00092728"},
        {"Renson", "Renson 26760"},
        {"Smithsonian Astrophysical Observation", "SAO 27748"},
        {"Wilson Evans Batten Catalogue", "WEB 9558"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.93048735),
        dec: Angle.Degrees(+57.19932851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210128"},
        {"Hipparcos Number", "HIP 109146"},
        {"Geneva Identification System", "GEN# +1.00210128"},
        {"Smithsonian Astrophysical Observation", "SAO 34064"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64088859),
        dec: Angle.Degrees(+57.19996703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239689"},
        {"Hipparcos Number", "HIP 106210"},
        {"Geneva Identification System", "GEN# +4.35370136"},
        {"Smithsonian Astrophysical Observation", "SAO 33489"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.69136987),
        dec: Angle.Degrees(+57.20005592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3389 AB"},
        {"Henry Draper", "HD 29599"},
        {"Hipparcos Number", "HIP 21941"},
        {"Smithsonian Astrophysical Observation", "SAO 24775"},
        {"Wilson Evans Batten Catalogue", "WEB 4215"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.74486103),
        dec: Angle.Degrees(+57.20201873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201732"},
        {"Hipparcos Number", "HIP 104425"},
        {"Geneva Identification System", "GEN# +1.00201732"},
        {"Smithsonian Astrophysical Observation", "SAO 33173"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.30137787),
        dec: Angle.Degrees(+57.20259071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13403"},
        {"Hipparcos Number", "HIP 10322"},
        {"Geneva Identification System", "GEN# +1.00013403"},
        {"Smithsonian Astrophysical Observation", "SAO 23033"},
        {"Wilson Evans Batten Catalogue", "WEB 2152"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.23239165),
        dec: Angle.Degrees(+57.20502258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223694"},
        {"Hipparcos Number", "HIP 117653"},
        {"Geneva Identification System", "GEN# +1.00223694"},
        {"Smithsonian Astrophysical Observation", "SAO 35846"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.91046265),
        dec: Angle.Degrees(+57.20741126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119213"},
        {"Hipparcos Number", "HIP 66700"},
        {"Geneva Identification System", "GEN# +1.00119213"},
        {"Renson", "Renson 34410"},
        {"Smithsonian Astrophysical Observation", "SAO 28838"},
        {"Wilson Evans Batten Catalogue", "WEB 11767"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.08932457),
        dec: Angle.Degrees(+57.20754182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236471"},
        {"Hipparcos Number", "HIP 2791"},
        {"Renson", "Renson 850"},
        {"Smithsonian Astrophysical Observation", "SAO 21542"},
        {"Wilson Evans Batten Catalogue", "WEB 502"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.89259096),
        dec: Angle.Degrees(+57.20767120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236497"},
        {"Hipparcos Number", "HIP 3248"},
        {"Smithsonian Astrophysical Observation", "SAO 21623"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.34040192),
        dec: Angle.Degrees(+57.20898384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2469"},
        {"Hipparcos Number", "HIP 2267"},
        {"Geneva Identification System", "GEN# +1.00002469"},
        {"Smithsonian Astrophysical Observation", "SAO 21428"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.22601145),
        dec: Angle.Degrees(+57.20974899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240333"},
        {"Hipparcos Number", "HIP 116328"},
        {"Geneva Identification System", "GEN# +1.00240333"},
        {"Smithsonian Astrophysical Observation", "SAO 35557"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.56603408),
        dec: Angle.Degrees(+57.21637514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 723 A"},
        {"Henry Draper", "HD 5032"},
        {"Hipparcos Number", "HIP 4155"},
        {"Smithsonian Astrophysical Observation", "SAO 21799"},
        {"Wilson Evans Batten Catalogue", "WEB 742"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.27336624),
        dec: Angle.Degrees(+57.21918257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211554"},
        {"Hipparcos Number", "HIP 109972"},
        {"Geneva Identification System", "GEN# +1.00211554"},
        {"Smithsonian Astrophysical Observation", "SAO 34256"},
        {"Wilson Evans Batten Catalogue", "WEB 19743"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.11046921),
        dec: Angle.Degrees(+57.22022542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221692"},
        {"Hipparcos Number", "HIP 116299"},
        {"Celescope Catalog", "CEL 5629"},
        {"Geneva Identification System", "GEN# +1.00221692"},
        {"Smithsonian Astrophysical Observation", "SAO 35549"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.46244634),
        dec: Angle.Degrees(+57.22109151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84779"},
        {"Hipparcos Number", "HIP 48193"},
        {"Geneva Identification System", "GEN# +1.00084779"},
        {"Smithsonian Astrophysical Observation", "SAO 27391"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.36932918),
        dec: Angle.Degrees(+57.22117190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36066"},
        {"Hipparcos Number", "HIP 25973"},
        {"Fundamental Katalog 5th Edition", "FK5 1150"},
        {"Geneva Identification System", "GEN# +1.00036066"},
        {"Smithsonian Astrophysical Observation", "SAO 25241"},
        {"Wilson Evans Batten Catalogue", "WEB 5052"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.14033281),
        dec: Angle.Degrees(+57.22161686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236543"},
        {"Hipparcos Number", "HIP 3888"},
        {"Smithsonian Astrophysical Observation", "SAO 21747"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.47727045),
        dec: Angle.Degrees(+57.22299687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156127"},
        {"Hipparcos Number", "HIP 84168"},
        {"Smithsonian Astrophysical Observation", "SAO 30292"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09526499),
        dec: Angle.Degrees(+57.22344913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149131"},
        {"Hipparcos Number", "HIP 80775"},
        {"Smithsonian Astrophysical Observation", "SAO 29965"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.38835960),
        dec: Angle.Degrees(+57.22397679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11383"},
        {"Hipparcos Number", "HIP 8823"},
        {"Smithsonian Astrophysical Observation", "SAO 22708"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.35912725),
        dec: Angle.Degrees(+57.22433069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9089 AB"},
        {"Henry Draper", "HD 122740"},
        {"Hipparcos Number", "HIP 68554"},
        {"Geneva Identification System", "GEN# +1.00122740J"},
        {"Smithsonian Astrophysical Observation", "SAO 28984"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.50248348),
        dec: Angle.Degrees(+57.22460216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16001 A"},
        {"Henry Draper", "HD 213470"},
        {"Hipparcos Number", "HIP 111088"},
        {"Geneva Identification System", "GEN# +1.00213470"},
        {"Smithsonian Astrophysical Observation", "SAO 34531"},
        {"Wilson Evans Batten Catalogue", "WEB 19889"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.57794732),
        dec: Angle.Degrees(+57.22545013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 809"},
        {"Hipparcos Number", "HIP 1023"},
        {"Smithsonian Astrophysical Observation", "SAO 21208"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.18847272),
        dec: Angle.Degrees(+57.22755962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7635"},
        {"Cincinnati Publication", "Ci 20 112"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)38, 22.1900),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)13, 58.500)
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
    primaryId: "HIP 113941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113941"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.10783199),
        dec: Angle.Degrees(+57.23766993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -279.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237237"},
        {"Hipparcos Number", "HIP 19969"},
        {"Smithsonian Astrophysical Observation", "SAO 24511"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.22639351),
        dec: Angle.Degrees(+57.24120415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14433"},
        {"Hipparcos Number", "HIP 11020"},
        {"Geneva Identification System", "GEN# +2.08842178"},
        {"Renson", "Renson 3630"},
        {"Smithsonian Astrophysical Observation", "SAO 23243"},
        {"Wilson Evans Batten Catalogue", "WEB 2314"},
        {"New General Catalogue", "NGC 884 2178"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.48098509),
        dec: Angle.Degrees(+57.24292010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37837"},
        {"Hipparcos Number", "HIP 27104"},
        {"Smithsonian Astrophysical Observation", "SAO 25349"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.21108562),
        dec: Angle.Degrees(+57.24346414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239110"},
        {"Hipparcos Number", "HIP 95894"},
        {"Smithsonian Astrophysical Observation", "SAO 31714"},
    },
    visualMagnitude: 9.87,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.53793299),
        dec: Angle.Degrees(+57.24349910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16681 A"},
        {"Henry Draper", "HD 220007"},
        {"Hipparcos Number", "HIP 115187"},
        {"Smithsonian Astrophysical Observation", "SAO 35330"},
        {"Wilson Evans Batten Catalogue", "WEB 20404"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.95776442),
        dec: Angle.Degrees(+57.24363434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64389"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.96248816),
        dec: Angle.Degrees(+57.24440811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14535"},
        {"Hipparcos Number", "HIP 11098"},
        {"Geneva Identification System", "GEN# +2.08842589"},
        {"Smithsonian Astrophysical Observation", "SAO 23263"},
        {"Wilson Evans Batten Catalogue", "WEB 2332"},
        {"New General Catalogue", "NGC 884 2589"},
        {"New General Catalogue 2", "NGC 869 2589"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.72290997),
        dec: Angle.Degrees(+57.24515470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172670"},
        {"Hipparcos Number", "HIP 91379"},
        {"Smithsonian Astrophysical Observation", "SAO 31081"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.55693382),
        dec: Angle.Degrees(+57.24805099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87599"},
        {"Hipparcos Number", "HIP 49614"},
        {"Smithsonian Astrophysical Observation", "SAO 27527"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.89190671),
        dec: Angle.Degrees(+57.24972145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239998"},
        {"Hipparcos Number", "HIP 111457"},
        {"Smithsonian Astrophysical Observation", "SAO 34584"},
    },
    visualMagnitude: 9.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.70032315),
        dec: Angle.Degrees(+57.24981936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236445"},
        {"Hipparcos Number", "HIP 2459"},
        {"Geneva Identification System", "GEN# +1.00236445"},
        {"Smithsonian Astrophysical Observation", "SAO 21474"},
        {"Wilson Evans Batten Catalogue", "WEB 449"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.81433489),
        dec: Angle.Degrees(+57.25169081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48507"},
        {"Hipparcos Number", "HIP 32522"},
        {"Smithsonian Astrophysical Observation", "SAO 25953"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.80308496),
        dec: Angle.Degrees(+57.25610973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195046"},
        {"Hipparcos Number", "HIP 100794"},
        {"Smithsonian Astrophysical Observation", "SAO 32586"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.55413967),
        dec: Angle.Degrees(+57.25672173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238287"},
        {"Hipparcos Number", "HIP 67290"},
        {"Smithsonian Astrophysical Observation", "SAO 28888"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.85799963),
        dec: Angle.Degrees(+57.25710316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238827"},
        {"Hipparcos Number", "HIP 89083"},
        {"Smithsonian Astrophysical Observation", "SAO 30797"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.71913543),
        dec: Angle.Degrees(+57.25842480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59642"},
        {"Hipparcos Number", "HIP 36793"},
        {"Smithsonian Astrophysical Observation", "SAO 26406"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.51218901),
        dec: Angle.Degrees(+57.25844756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236318"},
        {"Hipparcos Number", "HIP 784"},
        {"Smithsonian Astrophysical Observation", "SAO 21142"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.42191400),
        dec: Angle.Degrees(+57.25958655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222618"},
        {"Hipparcos Number", "HIP 116912"},
        {"Smithsonian Astrophysical Observation", "SAO 35682"},
        {"Wilson Evans Batten Catalogue", "WEB 20624"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.47731287),
        dec: Angle.Degrees(+57.25996583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60959"},
        {"Hipparcos Number", "HIP 37362"},
        {"Smithsonian Astrophysical Observation", "SAO 26453"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.03997396),
        dec: Angle.Degrees(+57.26215577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141336"},
        {"Hipparcos Number", "HIP 77192"},
        {"Geneva Identification System", "GEN# +1.00141336"},
        {"Smithsonian Astrophysical Observation", "SAO 29650"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.42956201),
        dec: Angle.Degrees(+57.26285402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 725"},
        {"Hipparcos Number", "HIP 951"},
        {"Geneva Identification System", "GEN# +1.00000725"},
        {"Smithsonian Astrophysical Observation", "SAO 21193"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.93644202),
        dec: Angle.Degrees(+57.27152515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109603"},
        {"Geneva Identification System", "GEN# +2.72350002"},
        {"New General Catalogue", "NGC 7235 2"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.03656556),
        dec: Angle.Degrees(+57.27222521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65626"},
        {"Hipparcos Number", "HIP 39348"},
        {"Geneva Identification System", "GEN# +1.00065626"},
        {"Smithsonian Astrophysical Observation", "SAO 26634"},
        {"Wilson Evans Batten Catalogue", "WEB 7705"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.64926248),
        dec: Angle.Degrees(+57.27377091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7860"},
        {"Hipparcos Number", "HIP 6189"},
        {"Smithsonian Astrophysical Observation", "SAO 22180"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.85228512),
        dec: Angle.Degrees(+57.27402139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15124"},
        {"Hipparcos Number", "HIP 11487"},
        {"Celescope Catalog", "CEL 278"},
        {"Geneva Identification System", "GEN# +1.00015124"},
        {"Smithsonian Astrophysical Observation", "SAO 23355"},
        {"Wilson Evans Batten Catalogue", "WEB 2399"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.04329808),
        dec: Angle.Degrees(+57.27480543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5258"},
        {"Hipparcos Number", "HIP 4305"},
        {"Smithsonian Astrophysical Observation", "SAO 21836"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.79073673),
        dec: Angle.Degrees(+57.27615030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55128"},
        {"Hipparcos Number", "HIP 35069"},
        {"Geneva Identification System", "GEN# +1.00055128"},
        {"Smithsonian Astrophysical Observation", "SAO 26242"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.77755013),
        dec: Angle.Degrees(+57.27716426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41052"},
        {"Hipparcos Number", "HIP 28925"},
        {"Smithsonian Astrophysical Observation", "SAO 25564"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.57698441),
        dec: Angle.Degrees(+57.28041404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75697"},
        {"Hipparcos Number", "HIP 43707"},
        {"Geneva Identification System", "GEN# +1.00075697"},
        {"Smithsonian Astrophysical Observation", "SAO 27035"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.51698858),
        dec: Angle.Degrees(+57.28085530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143188"},
        {"Hipparcos Number", "HIP 78032"},
        {"Smithsonian Astrophysical Observation", "SAO 29724"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.99981883),
        dec: Angle.Degrees(+57.28277718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115587"},
        {"Hipparcos Number", "HIP 64812"},
        {"Smithsonian Astrophysical Observation", "SAO 28703"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.25527789),
        dec: Angle.Degrees(+57.28288687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86791"},
        {"Hipparcos Number", "HIP 49195"},
        {"Geneva Identification System", "GEN# +1.00086791"},
        {"Smithsonian Astrophysical Observation", "SAO 27487"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.61479232),
        dec: Angle.Degrees(+57.28378647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212454"},
        {"Hipparcos Number", "HIP 110497"},
        {"Celescope Catalog", "CEL 5470"},
        {"Geneva Identification System", "GEN# +1.00212454"},
        {"Renson", "Renson 58950"},
        {"Smithsonian Astrophysical Observation", "SAO 34383"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.75070386),
        dec: Angle.Degrees(+57.28460062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173906"},
        {"Hipparcos Number", "HIP 91941"},
        {"Geneva Identification System", "GEN# +1.00173906"},
        {"Smithsonian Astrophysical Observation", "SAO 31146"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12925576),
        dec: Angle.Degrees(+57.28488217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5380"},
        {"Hipparcos Number", "HIP 4407"},
        {"Geneva Identification System", "GEN# +1.00005380"},
        {"Smithsonian Astrophysical Observation", "SAO 21853"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.12500757),
        dec: Angle.Degrees(+57.28648256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237103"},
        {"Hipparcos Number", "HIP 15231"},
        {"Smithsonian Astrophysical Observation", "SAO 23912"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.09698064),
        dec: Angle.Degrees(+57.28754265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236545"},
        {"Hipparcos Number", "HIP 3891"},
        {"Smithsonian Astrophysical Observation", "SAO 21748"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.48239843),
        dec: Angle.Degrees(+57.29771176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55198"},
        {"Hipparcos Number", "HIP 35085"},
        {"Smithsonian Astrophysical Observation", "SAO 26244"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.83971587),
        dec: Angle.Degrees(+57.29916034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147112"},
        {"Hipparcos Number", "HIP 79761"},
        {"Geneva Identification System", "GEN# +1.00147112"},
        {"Smithsonian Astrophysical Observation", "SAO 29864"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18922954),
        dec: Angle.Degrees(+57.30010393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14641"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.30037283),
        dec: Angle.Degrees(+57.30313800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69549"},
        {"Hipparcos Number", "HIP 40863"},
        {"Geneva Identification System", "GEN# +1.00069549"},
        {"Smithsonian Astrophysical Observation", "SAO 26781"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.07972330),
        dec: Angle.Degrees(+57.30479314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239399"},
        {"Hipparcos Number", "HIP 100688"},
        {"Smithsonian Astrophysical Observation", "SAO 32550"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.19982121),
        dec: Angle.Degrees(+57.30535486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238045"},
        {"Hipparcos Number", "HIP 57622"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.22153615),
        dec: Angle.Degrees(+57.30628460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91750"},
        {"Hipparcos Number", "HIP 51960"},
        {"Smithsonian Astrophysical Observation", "SAO 27704"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.21812881),
        dec: Angle.Degrees(+57.30649622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12709"},
        {"Hipparcos Number", "HIP 9817"},
        {"Celescope Catalog", "CEL 198"},
        {"Geneva Identification System", "GEN# +1.00012709"},
        {"Smithsonian Astrophysical Observation", "SAO 22919"},
        {"Wilson Evans Batten Catalogue", "WEB 2062"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.56843437),
        dec: Angle.Degrees(+57.30713091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31325"},
        {"Hipparcos Number", "HIP 23089"},
        {"Smithsonian Astrophysical Observation", "SAO 24932"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54192825),
        dec: Angle.Degrees(+57.30755041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3250"},
        {"Hipparcos Number", "HIP 2859"},
        {"Smithsonian Astrophysical Observation", "SAO 21552"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.06174544),
        dec: Angle.Degrees(+57.30772315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16448"},
        {"Hipparcos Number", "HIP 12488"},
        {"Geneva Identification System", "GEN# +1.00016448"},
        {"Smithsonian Astrophysical Observation", "SAO 23518"},
        {"Wilson Evans Batten Catalogue", "WEB 2552"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.16946057),
        dec: Angle.Degrees(+57.30896273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161162"},
        {"Hipparcos Number", "HIP 86499"},
        {"Fundamental Katalog 5th Edition", "FK5 3406"},
        {"Geneva Identification System", "GEN# +1.00161162"},
        {"Smithsonian Astrophysical Observation", "SAO 30515"},
        {"Wilson Evans Batten Catalogue", "WEB 14590"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.15068418),
        dec: Angle.Degrees(+57.31025952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12342"},
        {"Hipparcos Number", "HIP 9556"},
        {"Celescope Catalog", "CEL 190"},
        {"Geneva Identification System", "GEN# +1.00012342"},
        {"Smithsonian Astrophysical Observation", "SAO 22867"},
        {"Wilson Evans Batten Catalogue", "WEB 2005"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.69379895),
        dec: Angle.Degrees(+57.31026418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93470"},
        {"Hipparcos Number", "HIP 52859"},
        {"Geneva Identification System", "GEN# +1.00093470"},
        {"Smithsonian Astrophysical Observation", "SAO 27771"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.15106662),
        dec: Angle.Degrees(+57.31241677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13331"},
        {"Hipparcos Number", "HIP 10265"},
        {"Celescope Catalog", "CEL 219"},
        {"Geneva Identification System", "GEN# +1.00013331"},
        {"Smithsonian Astrophysical Observation", "SAO 23021"},
        {"Wilson Evans Batten Catalogue", "WEB 2139"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.02948319),
        dec: Angle.Degrees(+57.31278943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113491"},
        {"Hipparcos Number", "HIP 63702"},
        {"Smithsonian Astrophysical Observation", "SAO 28618"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.81967758),
        dec: Angle.Degrees(+57.31526164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240172"},
        {"Hipparcos Number", "HIP 113820"},
        {"Smithsonian Astrophysical Observation", "SAO 35101"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.73591103),
        dec: Angle.Degrees(+57.31717350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14210"},
        {"Hipparcos Number", "HIP 10873"},
        {"Geneva Identification System", "GEN# +2.08691482"},
        {"Smithsonian Astrophysical Observation", "SAO 23200"},
        {"Wilson Evans Batten Catalogue", "WEB 2292"},
        {"New General Catalogue", "NGC 869 1482"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.98389055),
        dec: Angle.Degrees(+57.31810611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204613"},
        {"Hipparcos Number", "HIP 105969"},
        {"Geneva Identification System", "GEN# +1.00204613"},
        {"Smithsonian Astrophysical Observation", "SAO 33445"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.92812636),
        dec: Angle.Degrees(+57.32213592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150172"},
        {"Hipparcos Number", "HIP 81288"},
        {"Smithsonian Astrophysical Observation", "SAO 30014"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.03987097),
        dec: Angle.Degrees(+57.32344076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 276.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111854"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.85799112),
        dec: Angle.Degrees(+57.32421728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39583"},
        {"Hipparcos Number", "HIP 28161"},
        {"Smithsonian Astrophysical Observation", "SAO 25473"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.26774921),
        dec: Angle.Degrees(+57.32443010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237373"},
        {"Hipparcos Number", "HIP 24894"},
        {"Smithsonian Astrophysical Observation", "SAO 25129"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.03842015),
        dec: Angle.Degrees(+57.32477827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6290"},
        {"Cincinnati Publication", "Ci 20 96"},
        {"Geneva Identification System", "GEN# +9.80219005"},
        {"Wilson Evans Batten Catalogue", "WEB 1405"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.17109890),
        dec: Angle.Degrees(+57.32685005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 436.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236387"},
        {"Hipparcos Number", "HIP 1717"},
        {"Smithsonian Astrophysical Observation", "SAO 21323"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.39772831),
        dec: Angle.Degrees(+57.32806703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203762"},
        {"Hipparcos Number", "HIP 105507"},
        {"Smithsonian Astrophysical Observation", "SAO 33360"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.53527516),
        dec: Angle.Degrees(+57.33470503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95844"},
        {"Hipparcos Number", "HIP 54127"},
        {"Geneva Identification System", "GEN# +1.00095844"},
        {"Smithsonian Astrophysical Observation", "SAO 27889"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.11445001),
        dec: Angle.Degrees(+57.33486826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168242"},
        {"Hipparcos Number", "HIP 89455"},
        {"Smithsonian Astrophysical Observation", "SAO 30845"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.84055086),
        dec: Angle.Degrees(+57.33564102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237774"},
        {"Hipparcos Number", "HIP 44492"},
        {"Smithsonian Astrophysical Observation", "SAO 27103"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.97336410),
        dec: Angle.Degrees(+57.33613847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203110"},
        {"Hipparcos Number", "HIP 105142"},
        {"Smithsonian Astrophysical Observation", "SAO 33298"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.48648151),
        dec: Angle.Degrees(+57.33870323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25666"},
        {"Hipparcos Number", "HIP 19247"},
        {"Smithsonian Astrophysical Observation", "SAO 24417"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.86847455),
        dec: Angle.Degrees(+57.34260206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238391"},
        {"Hipparcos Number", "HIP 72371"},
        {"Geneva Identification System", "GEN# +1.00238391"},
        {"Smithsonian Astrophysical Observation", "SAO 29284"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.96979710),
        dec: Angle.Degrees(+57.34355874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238246"},
        {"Hipparcos Number", "HIP 65967"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.88162659),
        dec: Angle.Degrees(+57.34945007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6795"},
        {"Hipparcos Number", "HIP 5440"},
        {"Geneva Identification System", "GEN# +1.00006795"},
        {"Smithsonian Astrophysical Observation", "SAO 22040"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.39592874),
        dec: Angle.Degrees(+57.35008196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237996"},
        {"Hipparcos Number", "HIP 55637"},
        {"Smithsonian Astrophysical Observation", "SAO 28008"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.96576780),
        dec: Angle.Degrees(+57.35039405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239153"},
        {"Hipparcos Number", "HIP 96489"},
        {"Smithsonian Astrophysical Observation", "SAO 31826"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.22983834),
        dec: Angle.Degrees(+57.35121182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108099"},
        {"Hipparcos Number", "HIP 60550"},
        {"Smithsonian Astrophysical Observation", "SAO 28372"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.19136698),
        dec: Angle.Degrees(+57.35238653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53957"},
        {"Hipparcos Number", "HIP 34639"},
        {"Smithsonian Astrophysical Observation", "SAO 26186"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.61846734),
        dec: Angle.Degrees(+57.35355556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166155"},
        {"Hipparcos Number", "HIP 88654"},
        {"Smithsonian Astrophysical Observation", "SAO 30748"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.49969882),
        dec: Angle.Degrees(+57.35921468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2710"},
        {"Hipparcos Number", "HIP 2442"},
        {"Geneva Identification System", "GEN# +1.00002710"},
        {"Smithsonian Astrophysical Observation", "SAO 21470"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.76711445),
        dec: Angle.Degrees(+57.36562139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93132"},
        {"Hipparcos Number", "HIP 52685"},
        {"Geneva Identification System", "GEN# +1.00093132"},
        {"Smithsonian Astrophysical Observation", "SAO 27760"},
        {"Wilson Evans Batten Catalogue", "WEB 9593"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.59390791),
        dec: Angle.Degrees(+57.36605450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239031"},
        {"Hipparcos Number", "HIP 94585"},
        {"Smithsonian Astrophysical Observation", "SAO 31515"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74119303),
        dec: Angle.Degrees(+57.37207432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222993"},
        {"Hipparcos Number", "HIP 117178"},
        {"Celescope Catalog", "CEL 5662"},
        {"Geneva Identification System", "GEN# +1.00222993"},
        {"Smithsonian Astrophysical Observation", "SAO 35734"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.35322241),
        dec: Angle.Degrees(+57.37239876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239326"},
        {"Hipparcos Number", "HIP 99079"},
        {"Celescope Catalog", "CEL 4939"},
        {"Geneva Identification System", "GEN# +1.00239326"},
        {"Smithsonian Astrophysical Observation", "SAO 32297"},
        {"Wilson Evans Batten Catalogue", "WEB 17623"},
    },
    visualMagnitude: 9.23,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.71702329),
        dec: Angle.Degrees(+57.37322193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111850"},
        {"Hipparcos Number", "HIP 62750"},
        {"Smithsonian Astrophysical Observation", "SAO 28539"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.86198731),
        dec: Angle.Degrees(+57.37343717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225137"},
        {"Hipparcos Number", "HIP 303"},
        {"Renson", "Renson 61750"},
        {"Smithsonian Astrophysical Observation", "SAO 21046"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.96915935),
        dec: Angle.Degrees(+57.37827711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238440"},
        {"Hipparcos Number", "HIP 74770"},
        {"Smithsonian Astrophysical Observation", "SAO 29469"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.21885562),
        dec: Angle.Degrees(+57.37867827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238525"},
        {"Hipparcos Number", "HIP 78237"},
        {"Smithsonian Astrophysical Observation", "SAO 29736"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63091444),
        dec: Angle.Degrees(+57.37955897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75401"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.09250443),
        dec: Angle.Degrees(+57.38481788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -326.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102183",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14196 AB"},
        {"Henry Draper", "HD 197618"},
        {"Hipparcos Number", "HIP 102183"},
        {"Smithsonian Astrophysical Observation", "SAO 32812"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.57000523),
        dec: Angle.Degrees(+57.38535950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192161"},
        {"Hipparcos Number", "HIP 99414"},
        {"Geneva Identification System", "GEN# +1.00192161"},
        {"Smithsonian Astrophysical Observation", "SAO 32338"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.65752456),
        dec: Angle.Degrees(+57.38665396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14542"},
        {"Hipparcos Number", "HIP 11115"},
        {"Geneva Identification System", "GEN# +2.08842621"},
        {"Smithsonian Astrophysical Observation", "SAO 23266"},
        {"Wilson Evans Batten Catalogue", "WEB 2338"},
        {"New General Catalogue", "NGC 884 2621"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.75177868),
        dec: Angle.Degrees(+57.38700880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192492"},
        {"Hipparcos Number", "HIP 99561"},
        {"Smithsonian Astrophysical Observation", "SAO 32356"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.07089999),
        dec: Angle.Degrees(+57.38721973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195871"},
        {"Hipparcos Number", "HIP 101230"},
        {"Smithsonian Astrophysical Observation", "SAO 32653"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.79410974),
        dec: Angle.Degrees(+57.38773267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238329"},
        {"Hipparcos Number", "HIP 69138"},
        {"Smithsonian Astrophysical Observation", "SAO 29020"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.29122412),
        dec: Angle.Degrees(+57.39008364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56793"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.64871457),
        dec: Angle.Degrees(+57.39124091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239995"},
        {"Hipparcos Number", "HIP 111423"},
        {"Smithsonian Astrophysical Observation", "SAO 34579"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.60796451),
        dec: Angle.Degrees(+57.39569392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170812"},
        {"Hipparcos Number", "HIP 90498"},
        {"Smithsonian Astrophysical Observation", "SAO 30993"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.99997679),
        dec: Angle.Degrees(+57.39836664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32747"},
        {"Hipparcos Number", "HIP 23944"},
        {"Geneva Identification System", "GEN# +1.00032747"},
        {"Smithsonian Astrophysical Observation", "SAO 25042"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.19122569),
        dec: Angle.Degrees(+57.40173363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161072"},
        {"Hipparcos Number", "HIP 86466"},
        {"Smithsonian Astrophysical Observation", "SAO 30510"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.00190494),
        dec: Angle.Degrees(+57.40399160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125750"},
        {"Hipparcos Number", "HIP 70007"},
        {"Smithsonian Astrophysical Observation", "SAO 29104"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.87265182),
        dec: Angle.Degrees(+57.40629284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116243",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16828 A"},
        {"Henry Draper", "HD 221625"},
        {"Hipparcos Number", "HIP 116243"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.30131124),
        dec: Angle.Degrees(+57.40803373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144464"},
        {"Hipparcos Number", "HIP 78623"},
        {"Smithsonian Astrophysical Observation", "SAO 29773"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.76333353),
        dec: Angle.Degrees(+57.40852976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16616"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.45433523),
        dec: Angle.Degrees(+57.40895294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187876"},
        {"Hipparcos Number", "HIP 97517"},
        {"Geneva Identification System", "GEN# +1.00187876"},
        {"Smithsonian Astrophysical Observation", "SAO 32031"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.30076200),
        dec: Angle.Degrees(+57.40947980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21059"},
        {"Hipparcos Number", "HIP 16043"},
        {"Geneva Identification System", "GEN# +1.00021059"},
        {"Smithsonian Astrophysical Observation", "SAO 24032"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64938169),
        dec: Angle.Degrees(+57.41009865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131360"},
        {"Hipparcos Number", "HIP 72613"},
        {"Smithsonian Astrophysical Observation", "SAO 29309"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.70229909),
        dec: Angle.Degrees(+57.41087696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19572"},
        {"Hipparcos Number", "HIP 14837"},
        {"Smithsonian Astrophysical Observation", "SAO 23860"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.90247410),
        dec: Angle.Degrees(+57.41104587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28257"},
        {"Hipparcos Number", "HIP 21046"},
        {"Geneva Identification System", "GEN# +1.00028257"},
        {"Smithsonian Astrophysical Observation", "SAO 24656"},
        {"Wilson Evans Batten Catalogue", "WEB 4049"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.67368677),
        dec: Angle.Degrees(+57.41172931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224151"},
        {"Hipparcos Number", "HIP 117957"},
        {"Celescope Catalog", "CEL 5713"},
        {"Geneva Identification System", "GEN# +1.00224151"},
        {"Smithsonian Astrophysical Observation", "SAO 35899"},
        {"Wilson Evans Batten Catalogue", "WEB 20744"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.89101310),
        dec: Angle.Degrees(+57.41216874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197071"},
        {"Hipparcos Number", "HIP 101874"},
        {"Geneva Identification System", "GEN# +1.00197071"},
        {"Smithsonian Astrophysical Observation", "SAO 32759"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.66261292),
        dec: Angle.Degrees(+57.41406887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42994"},
        {"Hipparcos Number", "HIP 29873"},
        {"Geneva Identification System", "GEN# +1.00042994"},
        {"Smithsonian Astrophysical Observation", "SAO 25647"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.34746795),
        dec: Angle.Degrees(+57.41482409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89523"},
        {"Hipparcos Number", "HIP 50725"},
        {"Smithsonian Astrophysical Observation", "SAO 27617"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.35606385),
        dec: Angle.Degrees(+57.41502369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239620"},
        {"Hipparcos Number", "HIP 105004"},
        {"Smithsonian Astrophysical Observation", "SAO 33269"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.00754218),
        dec: Angle.Degrees(+57.41575287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
